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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PS5_Payloads
{
    public partial class formMain : Form
    {
        const string AppVersion = "1.6 MOD";

        public formMain()
        {
            InitializeComponent();
            this.Text = "PS5 Payloads " + AppVersion;
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            StreamReader nr = new StreamReader(Application.StartupPath + "\\" + "ip.ini");
            ipbox.Text = nr.ReadLine();
            portbox.Text = nr.ReadLine();
            nr.Close();

            addButtons(groupBox1, "payloads1.txt");
            addButtons(groupBox2, "payloads2.txt");
            addButtons(groupBox3, "payloads3.txt");
        }

        private void addButtons(Control groupBox, string payloadsFile)
        {
            if (File.Exists(Application.StartupPath + "\\" + payloadsFile) == false) return;

            int leftMargin = 2;
            int top = 20;
            int left = leftMargin;
            int width = 170;
            Color color = Color.White;
            Color color2 = Color.LightGray;

            var lines = File.ReadAllLines(Application.StartupPath + "\\" + payloadsFile);
            int height = lines.Length <= 12 ? 60 : 30;
            for (var i = 0; i < lines.Length; i += 1)
            {
                // Process line
                if (lines[i].Contains(';'))
                {
                    var args = lines[i].Split(';');
                    Button btn = new Button();
                    btn.Size = new Size(width, height);
                    btn.BackColor = color;
                    btn.Top = top;
                    btn.Left = left; left += width + 1; if (left + width > this.Width) { left = leftMargin; top += height + 1; (color, color2) = (color2, color); }
                    btn.Text = args[0];
                    btn.Tag = args[1];
                    btn.Click += buttonSendPayload_Click;
                    groupBox.Controls.Add(btn);
                }
            }
        }

        private void btnSaveIP_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(Application.StartupPath + "\\" + "IP.Ini");
            sw.WriteLine(ipbox.Text);
            sw.WriteLine(portbox.Text);
            sw.Close();

            this.payloadStatus.ForeColor = Color.Blue;
            this.payloadStatus.Text = "PS5 IP address && port saved";
        }

        public void SendPayload(string IP, string payloadPath, int port)
        {
            if(File.Exists(payloadPath))
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
            else
            {
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = payloadPath + " does not exist";
                MessageBox.Show("Payload nount found.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        
        private void tabHEN_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
        }

        private void tabBackup_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox2.Location = new System.Drawing.Point(4, 144);
            groupBox1.Visible = false;
            groupBox3.Visible = false;
        }
        private void tabPayloads_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            groupBox3.Location = new System.Drawing.Point(4, 144);
            groupBox1.Visible = false;
            groupBox2.Visible = false;
        }
                        
        private void buttonSendPayload_Click(object sender, EventArgs e)
        {
            Button obj = (Button)sender;

            string payloadFile = Application.StartupPath + "\\Files\\payloads\\" + obj.Tag.ToString();
            try
            {
                string IP = this.ipbox.Text;

                this.payloadStatus.ForeColor = Color.Blue;
                this.payloadStatus.Text = "Sending " + obj.Tag.ToString();
                this.payloadStatus.Refresh();

                SendPayload(IP, payloadFile, Convert.ToInt32(this.portbox.Text));

                payloadStatus.ForeColor = Color.FromArgb(0, 120, 0);
                payloadStatus.Text = "Successful. " + obj.Text;
            }
            catch
            {
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";
                MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PS5 Payloads " + AppVersion + " by master\n\n" +
                            "MOD by aldostools\n", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void portbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true;
        }
    }
}
