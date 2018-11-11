using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

using RfidApiLib;
using System.Text.RegularExpressions;
using Microsoft.Win32;
using System.IO.Ports;

namespace Demo
{
    public partial class Form1 : Form
    {
        RfidApi Reader1 = new RfidApi();
        public byte IsoReading = 0;
        public byte EpcReading = 0;
        public int TagCnt = 0;
        public int ScanTimes = 0;
        Date objdata;
        public Form1()
        {
            InitializeComponent();
            this.objdata = new Date();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            bRs232Con.Enabled = true;
            bRs232Discon.Enabled = false;
            bReset.Enabled = false;

            bRfSet.Enabled = false;
            bRfQuery.Enabled = false;
            
            bEpcId.Enabled = false;
            bEpcRead.Enabled = false;
            bEpcWrite.Enabled = false;
            bEpcKill.Enabled = false;
            bEpcInit.Enabled = false;
            
            cEpcTimes.SelectedIndex = 0;

            cEpcMembank.SelectedIndex = 1;
            int nLoop = 0;
            for (nLoop = 0; nLoop < 256; nLoop++)
                cEpcWordptr.Items.Add(Convert.ToString(nLoop));
            cEpcWordptr.SelectedIndex = 2;
            for (nLoop = 0; nLoop < 256; nLoop++)
                cEpcWordcnt.Items.Add(Convert.ToString(nLoop));
            cEpcWordcnt.SelectedIndex = 6;

            PopulateCommPortList();
            if (cCommPort.Items.Count > 0)
                cCommPort.SelectedIndex = 0;
            cCommPort.Click += new System.EventHandler(CommPortList_clicked);
        }

        private void CommPortList_clicked(object sender, EventArgs e)
        {
            PopulateCommPortList();
        }

        private void PopulateCommPortList()
        {
            List<string> possiblePorts = ComPortNames("10C4", "EA60");
            string priorValue = cCommPort.Text;

            cCommPort.Items.Clear();
            foreach(string s in possiblePorts) 
                cCommPort.Items.Add((object)s);
            
            if (priorValue != string.Empty && possiblePorts.Contains(priorValue))
                cCommPort.SelectedIndex = possiblePorts.IndexOf(priorValue);

            if (possiblePorts.Count == 0)
                bRs232Con.Enabled = false;
            else
                bRs232Con.Enabled = true;
        }

        // Compile an array of COM port names associated with given VID and PID
        // From https://www.codeproject.com/Tips/349002/Select-a-USB-Serial-Device-via-its-VID-PID
        List<string> ComPortNames(String VID, String PID)
        {
            // Stage 1: Find what comm ports the registry has assigned for this VID and PID
            // whether the devices are connected or not:-
            String pattern = String.Format("^VID_{0}.PID_{1}", VID, PID);
            Regex _rx = new Regex(pattern, RegexOptions.IgnoreCase);
            List<string> candidatePorts = new List<string>();
            RegistryKey rk1 = Registry.LocalMachine;
            RegistryKey rk2 = rk1.OpenSubKey("SYSTEM\\CurrentControlSet\\Enum");
            foreach (String s3 in rk2.GetSubKeyNames())
            {
                RegistryKey rk3 = rk2.OpenSubKey(s3);
                foreach (String s in rk3.GetSubKeyNames())
                {
                    if (_rx.Match(s).Success)
                    {
                        RegistryKey rk4 = rk3.OpenSubKey(s);
                        foreach (String s2 in rk4.GetSubKeyNames())
                        {
                            RegistryKey rk5 = rk4.OpenSubKey(s2);
                            RegistryKey rk6 = rk5.OpenSubKey("Device Parameters");
                            candidatePorts.Add((string)rk6.GetValue("PortName"));
                        }
                    }
                }
            }

            // Stage 2: Find intersection of that with the list of serial ports
            // that are currently connected:-
            List<string> result = new List<string>();
            foreach (String s in SerialPort.GetPortNames())
                if (candidatePorts.Contains(s))
                    result.Add(s);

            return result;
        }

        private void bRs232Con_Click(object sender, EventArgs e)
        {
            int status;
            byte v1 = 0;
            byte v2 = 0;
            string s = "";
            status = Reader1.OpenCommPort(cCommPort.Text);
            if (status != 0)
            {
                lInfo.Items.Add("Open Comm Port Failed!");
                return;
            }
            status = Reader1.GetFirmwareVersion(ref v1, ref v2);
            if (status != 0)
            {
                lInfo.Items.Add("Can not connect with the reader!");
                Reader1.CloseCommPort();
                return;
            }
            lInfo.Items.Add("Connect the reader success!");
            s = string.Format("The reader's firmware version is:V{0:d2}.{1:d2}", v1, v2);
            lInfo.Items.Add(s);
            bAntQuery_Click(sender, e);

            // Changing the baud rate produces weird results if the software crashes
            // or similar, as it expects a response from a change-baud-rate command sent
            // at 9600 baud. Leads to software claiming connection failure etc :(
            status = Reader1.SetBaudRate(0); 
            if (status != 0)
            {
                lInfo.Items.Add("Set baudrate failed!");
                Reader1.CloseCommPort();
                return;
            }
            lInfo.Items.Add("Set baudrate success!");

            bReset.Enabled = true;

            cCommPort.Enabled = false;
            bRs232Con.Enabled = false;
            bRs232Discon.Enabled = true;

            bRfSet.Enabled = true;
            bRfQuery.Enabled = true;
            
            bEpcId.Enabled = true;
            bEpcRead.Enabled = true;
            bEpcWrite.Enabled = true;
            bEpcInit.Enabled = true;
            bEpcKill.Enabled = false;

            bRfQuery_Click(null, null);
        }

        private void bRs232Discon_Click(object sender, EventArgs e)
        {
            // �޸��˲����ʣ��������˳�ǰҪ�������ʻָ�Ϊ9600�������´λ��޷�����
            Reader1.SetBaudRate(0);
            Reader1.CloseCommPort();
            bRs232Con.Enabled = true;
            cCommPort.Enabled = true;
            bRs232Discon.Enabled = false;
            bReset.Enabled = false;

            bRfSet.Enabled = false;
            bRfQuery.Enabled = false;
            
            bEpcId.Enabled = false;
            bEpcRead.Enabled = false;
            bEpcWrite.Enabled = false;
            bEpcKill.Enabled = false;
            bEpcInit.Enabled = false;
        }

        private void bRfQuery_Click(object sender, EventArgs e)
        {
            byte pwr = 0;
            byte freq = 0;

            int status;

            status = Reader1.GetRf(ref pwr, ref freq);
            if (status != 0)
            {
                lInfo.Items.Add("Get Rf settings failed!");
                return;
            }
            tRfPwr.Value = pwr;
            cRfFreq.SelectedIndex = freq;
            lInfo.Items.Add("Get Rf settings success!");
        }

        private void bRfSet_Click(object sender, EventArgs e)
        {
            byte pwr = 0;
            byte freq = 0;

            int status;
            pwr = (byte)(tRfPwr.Value);
            freq = (byte)(cRfFreq.SelectedIndex);
            status = Reader1.SetRf(pwr, freq);
            if (status != 0)
            {
                lInfo.Items.Add("Set Rf settings failed!");
                return;
            }
            lInfo.Items.Add("Set Rf settings success!");
        }

        private void bEpcId_Click(object sender, EventArgs e)
        {
            if (EpcReading == 0)
            {
                Reader1.ClearIdBuf();
                lInfo.Items.Clear();
                lInfo.Items.Add("Start multiply tags identify!");
                TagCnt = 0;
                if (cEpcTimes.SelectedIndex > 0)
                    ScanTimes = Convert.ToInt16(cEpcTimes.Text);
                else
                    ScanTimes = 9999;
                timerScanEPC.Interval = (tEpcSpeed.Value + 1) * 20;
                timerScanEPC.Enabled = true;
                bEpcId.Text = "Stop";
                EpcReading = 1;
            }
            else
            {
                timerScanEPC.Enabled = false;
                EpcReading = 0;
                bEpcId.Text = "Identify";
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int status;
            int i, j;
            byte[,] IsoBuf = new byte[100, 12];
            byte tag_cnt = 0;
            string s = "";
            string s1 = "";
            byte tag_flag = 0;
            int listIn = 0;

            // Filter same tag
            if (!chkFilter.Checked)
                Reader1.ClearIdBuf();
            status = Reader1.EpcMultiTagIdentify(ref IsoBuf, ref tag_cnt, ref tag_flag);
            if (tag_cnt > 0)
            {
                for (i = 0; i < tag_cnt; i++)
                {
                    s1 = "";
                    for (j = 0; j < Convert.ToInt16(cEpcWordcnt.Text) * 2; j++)
                    {
                        s = string.Format("{0:X2} ", IsoBuf[i, j]);
                        s1 += s;
                    }
                    lInfo.Items.Add(s1);
                    ListViewItem lviList = new ListViewItem();
                    if (lvTagList.Items.Count <= 0)
                    {
                        lviList.SubItems[0].Text = "1";
                        lviList.SubItems.Add("");
                        lviList.SubItems.Add("");
                        lvTagList.Items.Add(lviList);
                        listIn = 0;
                        lvTagList.Items[listIn].SubItems[1].Text = s1;
                        lvTagList.Items[listIn].SubItems[2].Text = "1";
                    }
                    else
                    {
                        listIn = -1;
                        for (i = 0; i < lvTagList.Items.Count; i++)
                        {
                            if (lvTagList.Items[i].SubItems[1].Text == s1)
                            {
                                listIn = i;
                                break;
                            }
                        }
                        if (listIn < 0)
                        {
                            listIn = lvTagList.Items.Count;
                            lviList.SubItems[0].Text = Convert.ToString(listIn + 1);
                            lviList.SubItems.Add("");
                            lviList.SubItems.Add("");
                            lvTagList.Items.Add(lviList);
                        }
                        lvTagList.Items[listIn].SubItems[1].Text = s1;
                        if (lvTagList.Items[listIn].SubItems[2].Text == "")
                            lvTagList.Items[listIn].SubItems[2].Text = "0";
                        Int64 intTimes = Convert.ToInt64(lvTagList.Items[listIn].SubItems[2].Text);
                        lvTagList.Items[listIn].SubItems[2].Text = Convert.ToString(intTimes + 1);
                    }
                }
            }
            if (ScanTimes <= 0)
            {
                bEpcId_Click(sender, e);
            }
        }

        private void bEpcRead_Click(object sender, EventArgs e)
        {
            int membank;
            int wordptr;
            int wordcnt;
            int status = 0;
            byte[] value = new byte[32];

            string s = "The data is:";
            string s1 = "";

            membank = cEpcMembank.SelectedIndex;
            wordptr = cEpcWordptr.SelectedIndex;
            wordcnt = cEpcWordcnt.SelectedIndex;

            status = Reader1.EpcRead((byte)membank, (byte)wordptr, (byte)wordcnt, ref value);

            if (status != 0)
            {
                lInfo.Items.Add("Read failed!");
                return;
            }
            else
            {
                for (int i = 0; i < wordcnt * 2; i++)
                {
                    s1 = string.Format("{0:X2}", value[i]);
                    s += s1;
                }
                lInfo.Items.Add("Read success!");
                lInfo.Items.Add(s);
            }
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            lInfo.Items.Clear();
            lvTagList.Items.Clear();
        }

        private void bEpcInit_Click(object sender, EventArgs e)
        {
            int status;

            status = Reader1.EpcInitEpc(96);

            if (status == 0)
            {
                lInfo.Items.Add("Init tag success!");
            }
            else
            {
                lInfo.Items.Add("Init tag failed!");
            }
        }

        public static byte[] StringToByteArray(String hex)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }

        private void bEpcWrite_Click(object sender, EventArgs e)
        {
            ushort[] value = new ushort[16];

            int i = 0;
            byte membank;
            byte wordptr;
            byte wordcnt;
            int status;
            string hexValues;

            membank = (byte)(cEpcMembank.SelectedIndex);
            wordptr = (byte)(cEpcWordptr.SelectedIndex);
            wordcnt = (byte)(cEpcWordcnt.SelectedIndex);

            hexValues = tEpcData.Text;
            string[] hexValuesSplit = hexValues.Split(' ');
            try
            {
                foreach (String hex in hexValuesSplit)
                {
                    // Convert the number expressed in base-16 to an integer.
                    if (hex.Length >= 2)
                    {
                        int x = Convert.ToInt32(hex, 16);
                        value[i++] = (ushort)x;
                    }
                }
            }
            catch (Exception)
            {
                lInfo.Items.Add("Please input data needed");
                return;
            }
            if (i != wordcnt)
            {
                lInfo.Items.Add("Please input data needed");
                return;
            }
            for (byte j = 0; j < wordcnt; j++)
            {
                status = Reader1.EpcWrite(membank, (byte)(wordptr + j), value[j]);
                if (status != 0)
                {
                    lInfo.Items.Add("Write failed!");
                    return;
                }
            }
            lInfo.Items.Add("Write success!");
        }

        private void tEpcData_TextChanged(object sender, EventArgs e)
        {
            if (((tEpcData.Text.Length - 4) % 5) == 0)
            {
                tEpcData.Text += " ";
                tEpcData.Select(tEpcData.Text.Length, 0);
            }
        }

        private void btnSecRead_Click(object sender, EventArgs e)
        {
            int membank;
            int wordptr;
            int wordcnt;
            int status = 0;
            byte[] value = new byte[16];

            string s = "The data is:";
            string s1 = "";
            if (tEpcAccess.TextLength != 8)
            {
                lInfo.Items.Add("Access Password length not enough");
                return;
            }
            uint unAccPwd;
            unAccPwd = Convert.ToUInt32(tEpcAccess.Text, 16);
            membank = cEpcMembank.SelectedIndex;
            wordptr = cEpcWordptr.SelectedIndex;
            wordcnt = cEpcWordcnt.SelectedIndex;

            status = Reader1.Gen2SecRead(unAccPwd, (byte)membank, (byte)wordptr, (byte)wordcnt, ref value);
            if (status != 0)
            {
                lInfo.Items.Add("Read failed!");
                return;
            }
            else
            {
                for (int i = 0; i < wordcnt * 2; i++)
                {
                    s1 = string.Format("{0:X2}", value[i]);
                    s += s1;
                }
                lInfo.Items.Add("Read success!");
                lInfo.Items.Add(s);
            }
        }

        private void btnSecWrite_Click(object sender, EventArgs e)
        {
            ushort[] value = new ushort[16];
            int i = 0;
            byte membank;
            byte wordptr;
            byte wordcnt;
            int status;
            string hexValues;

            membank = (byte)(cEpcMembank.SelectedIndex);
            wordptr = (byte)(cEpcWordptr.SelectedIndex);
            wordcnt = (byte)(cEpcWordcnt.SelectedIndex);
            uint unAccPwd;
            unAccPwd = Convert.ToUInt32(tEpcAccess.Text, 16);

            hexValues = tEpcData.Text;
            string[] hexValuesSplit = hexValues.Split(' ');
            foreach (String hex in hexValuesSplit)
            {
                // Convert the number expressed in base-16 to an integer.
                if (hex != "")
                {
                    int x = Convert.ToInt32(hex, 16);
                    value[i++] = (ushort)x;
                }
            }
            if (i != wordcnt)
            {
                lInfo.Items.Add("Please input data needed");
                return;
            }
            for (byte j = 0; j < wordcnt; j++)
            {
                status = Reader1.Gen2SecWrite(unAccPwd, membank, (byte)(wordptr + j), value[j]);
                if (status != 0)
                {
                    lInfo.Items.Add("Write failed!");
                    return;
                }
            }
            lInfo.Items.Add("Write success!");
        }

        private void bEpcKill_Click(object sender, EventArgs e)
        {
            int status = 0;
            byte[] value = new byte[16];

            string s = "";
            if (tEpcAccess.TextLength != 8)
            {
                lInfo.Items.Add("Access Password length not enough");
                return;
            }
            uint unAccPwd;
            unAccPwd = Convert.ToUInt32(tEpcAccess.Text, 16);
            status = Reader1.Gen2KillTag(unAccPwd);
            if (status != 0)
            {
                lInfo.Items.Add("Set Password failed!");
                return;
            }
            else
            {
                lInfo.Items.Add("Set Password success!");
                lInfo.Items.Add(s);
            }
        }

        private void btnSecLock_Click(object sender, EventArgs e)
        {
            byte membank;
            byte pwdLevel;

            int status = 0;
            byte[] value = new byte[16];

            string s = "";
            if (tEpcAccess.TextLength != 8)
            {
                lInfo.Items.Add("Access Password length not enough");
                return;
            }
            uint unAccPwd;
            switch (cEpcMembank.SelectedIndex)
            {
                case 0:
                    membank = 3;
                    break;
                case 1:
                    membank = 2;
                    break;
                case 2:
                    membank = 1;
                    break;
                case 3:
                    membank = 0;
                    break;
                default:
                    membank = 2;
                    break;
            }
            pwdLevel = (byte)(cmbLevel.SelectedIndex);

            unAccPwd = Convert.ToUInt32(tEpcAccess.Text, 16);
            status = Reader1.Gen2SecLock(unAccPwd, membank, pwdLevel);
            if (status != 0)
            {
                lInfo.Items.Add("Lock EPC tag failed!");
                return;
            }
            else
            {
                lInfo.Items.Add("Lock EPC tag success!");
                lInfo.Items.Add(s);
            }
        }

        private void btnSetAccessPWD_Click(object sender, EventArgs e)
        {
            int status = 0;
            byte[] value = new byte[16];

            string s = "";
            if (tEpcAccess.TextLength != 8)
            {
                lInfo.Items.Add("Access Password length not enough");
                return;
            }
            uint unAccPwd;
            unAccPwd = Convert.ToUInt32(tEpcAccess.Text, 16);
            status = Reader1.Gen2SetAccPwd(unAccPwd);
            if (status != 0)
            {
                lInfo.Items.Add("Set Password failed!");
                return;
            }
            else
            {
                lInfo.Items.Add("Set Password success!");
                lInfo.Items.Add(s);
            }
        }

        private void bReset_Click(object sender, EventArgs e)
        {
            Reader1.ResetReader();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Reader1.EndPing();
        }

        private void timerPing_Tick(object sender, EventArgs e)
        {
            if (Reader1.CheckPing() > 0)
            {
                lInfo.Items.Add("Reader already dropped");
                // If you are identifying label,can immediately stop.
                if (1 == EpcReading)
                {
                    bEpcId_Click(sender, e);
                }
            }
        }

        private void bAntQuery_Click(object sender, EventArgs e)
        {
            byte ant_sel = 0;
            byte antH = 0;
            int status = 0;

            status = Reader1.GetAnt(ref ant_sel);
            if (status != 0)
            {
                lInfo.Items.Add("Get Ant settings failed!");
                return;
            }
            lInfo.Items.Add("Get Ant settings success!");
            if ((ant_sel & 0x01) == 0x01)
                ant1.Checked = true;
            else
                ant1.Checked = false;
            if ((ant_sel & 0x02) == 0x02)
                ant2.Checked = true;
            else
                ant2.Checked = false;
            if ((ant_sel & 0x04) == 0x04)
                ant3.Checked = true;
            else
                ant3.Checked = false;
            if ((ant_sel & 0x08) == 0x08)
                ant4.Checked = true;
            else
                ant4.Checked = false;
        }

        private void bAntSet_Click(object sender, EventArgs e)
        {
            byte ant_sel = 0;
            byte antH = 0;
            int status = 0;

            if (ant1.Checked)
                ant_sel |= 0x01;
            if (ant2.Checked)
                ant_sel |= 0x02;
            if (ant3.Checked)
                ant_sel |= 0x04;
            if (ant4.Checked)
                ant_sel |= 0x08;

            status = Reader1.SetAnt(ant_sel);
            if (status != 0)
            {
                lInfo.Items.Add("Set ant failed!");
                return;
            }
            lInfo.Items.Add("Set ant success!");
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {

        }

        private void lvTagList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btntxt_Click(object sender, EventArgs e)
        {
            if (this.lvTagList.Items.Count == 0)
            {
                MessageBox.Show("���Ȼ�ȡ����");
                return;
            }

            string fileName = DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Second.ToString();
            FileStream fs = new FileStream(fileName, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);     
            for (int i = 0; i < lvTagList .Items .Count ; i++)
            {
                for (int j = 0; j < lvTagList.Items [i].SubItems.Count; j++)
                {
                    string ab = lvTagList.Items[i].SubItems[j].Text;                 
                    sw.Write(ab);           
                }
                sw.WriteLine();
                
            }
            sw.Close();
            fs.Close();
            MessageBox.Show("����ɹ�");
            
        }
    }
}