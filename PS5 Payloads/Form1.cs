using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PS5_Payloads
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader nr = new StreamReader(Application.StartupPath + "\\" + "ip.ini");
            ipbox.Text = nr.ReadLine();
            portbox.Text = nr.ReadLine();
            nr.Close();
        }



        private void btconectar_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(Application.StartupPath + "\\" + "IP.Ini");
            sw.WriteLine(ipbox.Text);
            sw.WriteLine(portbox.Text);
            sw.Close();

        }

        private void butetaHEN17_Click(object sender, EventArgs e)
        {
            this.Injector_butetaHEN17(this.ipbox.Text);
        }
        private void Injector_butetaHEN17(string IP)
        {
            string str = Application.StartupPath + "\\Files\\payloads";
            try
            {

                SendPayload(IP, str + "\\etaHEN17.bin", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(0, 200, 0);
                payloadStatus.Text = "Successful. etaHEN17";
            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Injector_button2(this.ipbox.Text);
        }
        private void Injector_button2(string IP)
        {
            string str = Application.StartupPath + "\\Files\\payloads";
            try
            {

                SendPayload(IP, str + "\\etaHEN18.bin", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(0, 200, 0);
                payloadStatus.Text = "Successful. etaHEN18";
            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";
            }
        }

        public void SendPayload(string IP, string payloadPath, int port)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
            {
                ReceiveTimeout = 1500,
                SendTimeout = 1500
            };
            socket.Connect(new IPEndPoint(IPAddress.Parse(IP), port));
            socket.SendFile(payloadPath);
            socket.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Injector_button1(this.ipbox.Text);
        }
        private void Injector_button1(string IP)
        {
            string str = Application.StartupPath + "\\Files\\payloads";
            try
            {

                SendPayload(IP, str + "\\etaHEN19.bin", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(0, 200, 0);
                payloadStatus.Text = "Successful. etaHEN19";
            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Injector_button3(this.ipbox.Text);
        }
        private void Injector_button3(string IP)
        {
            string str = Application.StartupPath + "\\Files\\payloads";
            try
            {

                SendPayload(IP, str + "\\etaHEN_no_toolbox.bin", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(0, 200, 0);
                payloadStatus.Text = "Successful. etaHEN no toolbox";
            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.Injector_button4(this.ipbox.Text);
        }
        private void Injector_button4(string IP)
        {
            string str = Application.StartupPath + "\\Files\\payloads";
            try
            {

                SendPayload(IP, str + "\\ftpsrv.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(0, 200, 0);
                payloadStatus.Text = "Successful. ftpsrv";
            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            this.Injector_button5(this.ipbox.Text);
        }
        private void Injector_button5(string IP)
        {
            string str = Application.StartupPath + "\\Files\\payloads";
            try
            {

                SendPayload(IP, str + "\\ps5debug_dizz.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(0, 200, 0);
                payloadStatus.Text = "Successful. ps5debug dizz";
            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            this.Injector_button6(this.ipbox.Text);
        }
        private void Injector_button6(string IP)
        {
            string str = Application.StartupPath + "\\Files\\payloads";
            try
            {

                SendPayload(IP, str + "\\ps5debug_v1.0b2.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(0, 200, 0);
                payloadStatus.Text = "Successful. ps5debug v1.0b2";
            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            this.Injector_button7(this.ipbox.Text);
        }
        private void Injector_button7(string IP)
        {
            string str = Application.StartupPath + "\\Files\\payloads";
            try
            {

                SendPayload(IP, str + "\\Browser_appCache_remove.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(0, 200, 0);
                payloadStatus.Text = "Successful. Browser appCache remove";
            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            this.Injector_button8(this.ipbox.Text);
        }
        private void Injector_button8(string IP)
        {
            string str = Application.StartupPath + "\\Files\\payloads";
            try
            {

                SendPayload(IP, str + "\\getbasicsavemounteroffsets.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(0, 200, 0);
                payloadStatus.Text = "Successful. getbasicsavemounteroffsets";
            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";
            }
        }
        //ps5-kstuff
        private void button9_Click(object sender, EventArgs e)
        {
            this.Injector_button9(this.ipbox.Text);
        }
        private void Injector_button9(string IP)
        {
            string str = Application.StartupPath + "\\Files\\payloads";
            try
            {

                SendPayload(IP, str + "\\ps5-kstuff.bin", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(0, 200, 0);
                payloadStatus.Text = "Successful. ps5-kstuff";
            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";
            }
        }
        //libhijacker-game-patch.v1.160.elf
        private void button10_Click(object sender, EventArgs e)
        {
            this.Injector_button10(this.ipbox.Text);
        }
        private void Injector_button10(string IP)
        {
            string str = Application.StartupPath + "\\Files\\payloads";
            try
            {

                SendPayload(IP, str + "\\libhijacker-game-patch.v1.160.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(0, 200, 0);
                payloadStatus.Text = "Successful. libhijacker-game-patch.v1.160";
            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";
            }
        }
        //byepervisor.elf
        private void button11_Click(object sender, EventArgs e)
        {
            this.Injector_button11(this.ipbox.Text);
        }
        private void Injector_button11(string IP)
        {
            string str = Application.StartupPath + "\\Files\\payloads";
            try
            {

                SendPayload(IP, str + "\\byepervisor.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(0, 200, 0);
                payloadStatus.Text = "Successful. byepervisor";
            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";
            }
        }
        //websrv
        private void butwebsrv_Click(object sender, EventArgs e)
        {
            this.Injector_butwebsrv(this.ipbox.Text);
        }
        private void Injector_butwebsrv(string IP)
        {
            string str = Application.StartupPath + "\\Files\\payloads";
            try
            {

                SendPayload(IP, str + "\\websrv.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(0, 200, 0);
                payloadStatus.Text = "Successful. websrv";
            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";
            }
        }
        //shsrv
        private void butshsrv_Click(object sender, EventArgs e)
        {
            this.Injector_butshsrv(this.ipbox.Text);
        }
        private void Injector_butshsrv(string IP)
        {
            string str = Application.StartupPath + "\\Files\\payloads";
            try
            {

                SendPayload(IP, str + "\\shsrv.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(0, 200, 0);
                payloadStatus.Text = "Successful. shsrv";
            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";
            }
        }
        //klogsrv
        private void butklogsrv_Click(object sender, EventArgs e)
        {
            this.Injector_butklogsrv(this.ipbox.Text);
        }
        private void Injector_butklogsrv(string IP)
        {
            string str = Application.StartupPath + "\\Files\\payloads";
            try
            {

                SendPayload(IP, str + "\\klogsrv.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(0, 200, 0);
                payloadStatus.Text = "Successful. klogsrv";
            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";
            }
        }
        //gdbsrv
        private void butgdbsrv_Click(object sender, EventArgs e)
        {
            this.Injector_butgdbsrv(this.ipbox.Text);
        }
        private void Injector_butgdbsrv(string IP)
        {
            string str = Application.StartupPath + "\\Files\\payloads";
            try
            {

                SendPayload(IP, str + "\\gdbsrv.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(0, 200, 0);
                payloadStatus.Text = "Successful. gdbsrv";
            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";
            }
        }
        //ps5versions
        private void butps5versions_Click(object sender, EventArgs e)
        {
            this.Injector_butps5versions(this.ipbox.Text);
        }
        private void Injector_butps5versions(string IP)
        {
            string str = Application.StartupPath + "\\Files\\payloads";
            try
            {

                SendPayload(IP, str + "\\ps5-versions.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(0, 200, 0);
                payloadStatus.Text = "Successful. ps5versions";
            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";
            }
        }
        //rp_get_pin
        private void but_rp_get_pin_Click(object sender, EventArgs e)
        {
            this.Injector_but_rp_get_pin(this.ipbox.Text);
        }
        private void Injector_but_rp_get_pin(string IP)
        {
            string str = Application.StartupPath + "\\Files\\payloads";
            try
            {

                SendPayload(IP, str + "\\rp-get-pin.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(0, 200, 0);
                payloadStatus.Text = "Successful. rp-get-pin";
            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";
            }
        }

        private void butHEN0_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
        }

        private void butBackup0_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox2.Location = new System.Drawing.Point(4, 144);
            groupBox1.Visible = false;
            groupBox3.Visible = false;
        }
        private void butUpdate_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            groupBox3.Location = new System.Drawing.Point(4, 144);
            groupBox1.Visible = false;
            groupBox2.Visible = false;
        }
        //BackupDbUser
        private void butBackupDbUser_Click(object sender, EventArgs e)
        {
            this.Injector_BackupDbUser(this.ipbox.Text);
        }
        private void Injector_BackupDbUser(string IP)
        {
            string str = Application.StartupPath + "\\Files\\payloads";
            try
            {

                SendPayload(IP, str + "\\BackupDbUser.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(0, 200, 0);
                payloadStatus.Text = "Successful. BackupDbUser";
            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";
            }
        }
        //BackupDB
        private void butBackupDB_Click(object sender, EventArgs e)
        {
            this.Injector_BackupDB(this.ipbox.Text);
        }
        private void Injector_BackupDB(string IP)
        {
            string str = Application.StartupPath + "\\Files\\payloads";
            try
            {

                SendPayload(IP, str + "\\BackupDB.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(0, 200, 0);
                payloadStatus.Text = "Successful. BackupDB";
            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";
            }
        }
        //BFW_300
        private void butBFW_300_Click(object sender, EventArgs e)
        {
            this.Injector_BFW_300(this.ipbox.Text);
        }
        private void Injector_BFW_300(string IP)
        {
            string str = Application.StartupPath + "\\Files\\payloads";
            try
            {

                SendPayload(IP, str + "\\Backup-SAV-PS5_FW_3.00.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(0, 200, 0);
                payloadStatus.Text = "Successful. Backup-SAV-PS5_FW_3.00";
            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";
            }
        }
        //BFW_320
        private void butBFW_320_Click(object sender, EventArgs e)
        {
            this.Injector_BFW_320(this.ipbox.Text);
        }
        private void Injector_BFW_320(string IP)
        {
            string str = Application.StartupPath + "\\Files\\payloads";
            try
            {

                SendPayload(IP, str + "\\Backup-SAV-PS5_FW_3.20.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(0, 200, 0);
                payloadStatus.Text = "Successful. Backup-SAV-PS5_FW_3.20";
            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";
            }
        }
        //BFW_321
        private void butBFW_321_Click(object sender, EventArgs e)
        {
            this.Injector_BFW_321(this.ipbox.Text);
        }
        private void Injector_BFW_321(string IP)
        {
            string str = Application.StartupPath + "\\Files\\payloads";
            try
            {

                SendPayload(IP, str + "\\Backup-SAV-PS5_FW_3.21.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(0, 200, 0);
                payloadStatus.Text = "Successful. Backup-SAV-PS5_FW_3.21";
            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";
            }
        }
        //BFW_402
        private void butBFW_402_Click(object sender, EventArgs e)
        {
            this.Injector_BFW_402(this.ipbox.Text);
        }
        private void Injector_BFW_402(string IP)
        {
            string str = Application.StartupPath + "\\Files\\payloads";
            try
            {

                SendPayload(IP, str + "\\Backup-SAV-PS5_FW_4.02.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(0, 200, 0);
                payloadStatus.Text = "Successful. Backup-SAV-PS5_FW_4.02";
            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";
            }
        }
        //BFW_403
        private void butBFW_403_Click(object sender, EventArgs e)
        {
            this.Injector_BFW_403(this.ipbox.Text);
        }
        private void Injector_BFW_403(string IP)
        {
            string str = Application.StartupPath + "\\Files\\payloads";
            try
            {

                SendPayload(IP, str + "\\Backup-SAV-PS5_FW_4.03.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(0, 200, 0);
                payloadStatus.Text = "Successful. Backup-SAV-PS5_FW_4.03";
            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";
            }
        }
        //BFW_450
        private void butBFW_450_Click(object sender, EventArgs e)
        {
            this.Injector_BFW_450(this.ipbox.Text);
        }
        private void Injector_BFW_450(string IP)
        {
            string str = Application.StartupPath + "\\Files\\payloads";
            try
            {

                SendPayload(IP, str + "\\Backup-SAV-PS5_FW_4.50.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(0, 200, 0);
                payloadStatus.Text = "Successful. Backup-SAV-PS5_FW_4.50";
            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";
            }
        }
        //BFW_451
        private void butBFW_451_Click(object sender, EventArgs e)
        {
            this.Injector_BFW_451(this.ipbox.Text);
        }
        private void Injector_BFW_451(string IP)
        {
            string str = Application.StartupPath + "\\Files\\payloads";
            try
            {

                SendPayload(IP, str + "\\Backup-SAV-PS5_FW_4.51.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(0, 200, 0);
                payloadStatus.Text = "Successful. Backup-SAV-PS5_FW_4.51";
            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";
            }
        }
        //Enable-Disable
        private void buEnable_Disable_Click(object sender, EventArgs e)
        {
            this.Injector_buEnable_Disable(this.ipbox.Text);
        }
        private void Injector_buEnable_Disable(string IP)
        {
            string str = Application.StartupPath + "\\Files\\payloads";
            try
            {

                SendPayload(IP, str + "\\Enable-Disable-UPD-PS5v1.0.3.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(0, 200, 0);
                payloadStatus.Text = "Successful. Enable-Disable-UPD-PS5v1.0.3";
            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";
            }
        }
        //elfldr
        private void buttelfldr_Click(object sender, EventArgs e)
        {
            this.Injector_buttelfldr(this.ipbox.Text);
        }
        private void Injector_buttelfldr(string IP)
        {
            string str = Application.StartupPath + "\\Files\\payloads";
            try
            {

                SendPayload(IP, str + "\\elfldr.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(0, 200, 0);
                payloadStatus.Text = "Successful. elfldr";
            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";
            }
        }
    }
}
