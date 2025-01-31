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
        private const string AppVersion = "1.8a MOD";
        private bool sent = false;
        private bool silent = false;
        //private Form f;

        public formMain()
        {
            InitializeComponent();
            this.Text = "PS5 Payloads " + AppVersion;
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            // load ip.ini
            try
            {
                StreamReader nr = new StreamReader(Application.StartupPath + "\\" + "ip.ini");
                ipbox.Text = nr.ReadLine();
                portbox.Text = nr.ReadLine();
                nr.Close();
            }
            catch { }

            // load logo.png
            try
            {
                if (File.Exists(Application.StartupPath + "\\" + "logo.png"))
                {
                    picLogo.Image.Dispose();
                    picLogo.Image = Image.FromFile(Application.StartupPath + "\\" + "logo.png");
                }
            }
            catch { }

            // process command line arguments
            processCommandLineArguments();

            //load payload buttons
            loadPayloadButtons();
            silent = false;
        }
        
        private void btnSaveIP_Click(object sender, EventArgs e)
        {
            // save ip and port to IP.ini file
            StreamWriter sw = new StreamWriter(Application.StartupPath + "\\" + "IP.Ini");
            sw.WriteLine(ipbox.Text);
            sw.WriteLine(portbox.Text);
            sw.Close();

            // update status label
            this.payloadStatus.ForeColor = Color.Blue;
            this.payloadStatus.Text = "PS5 IP address && port saved";
        }

        private void resetTabs()
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;

            this.payloadStatus.ForeColor = System.Drawing.Color.Black;
            this.payloadStatus.Text = "Status";
            this.payloadStatus.Tag = "";
        }

        private void tabHEN_Click(object sender, EventArgs e)
        {
            // show groupBox1 buttons
            resetTabs();
            groupBox1.Visible = true;
        }

        private void tabBackup_Click(object sender, EventArgs e)
        {
            // show groupBox2 buttons
            resetTabs();
            groupBox2.Visible = true;
            groupBox2.Location = new System.Drawing.Point(4, 144);
        }
        private void tabPayloads_Click(object sender, EventArgs e)
        {
            // show groupBox3 buttons
            resetTabs();
            groupBox3.Visible = true;
            groupBox3.Location = new System.Drawing.Point(4, 144);
        }
        private void tabMore_Click(object sender, EventArgs e)
        {
            // show groupBox4 buttons
            resetTabs();
            groupBox4.Visible = true;
            groupBox4.Location = new System.Drawing.Point(4,144);
        }

        public void SendPayload(string IP, string payloadFile, int port)
        {
            if (File.Exists(payloadFile))
            {
                try
                {
                    // send payload to PS5
                    Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
                    {
                        ReceiveTimeout = 1500,
                        SendTimeout = 1500
                    };
                    socket.Connect(new IPEndPoint(IPAddress.Parse(IP), port));
                    socket.SendFile(payloadFile);
                    socket.Close();

                    // update status label after send payload
                    payloadStatus.ForeColor = Color.FromArgb(0, 120, 0);
                    payloadStatus.Text = "Successful. " + Path.GetFileName(payloadFile);
                }
                catch
                {
                    if (!silent) MessageBox.Show("Payload injection failed.\nSending " + Path.GetFileName(payloadFile), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                    // update status label if failed
                    this.payloadStatus.ForeColor = Color.Red;
                    this.payloadStatus.Text = "Payload injection failed. " + Path.GetFileName(payloadFile);
                }
            }
            else
            {
                // update status label
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = payloadFile + " does not exist";
                if (!silent) MessageBox.Show("Payload not found.\n" + payloadFile, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void SendPayloadAction(string payloadFile)
        {
            // send payload & update status label
            string IP = this.ipbox.Text;

            // update status label
            this.payloadStatus.ForeColor = Color.Blue;
            this.payloadStatus.Text = "Sending " + Path.GetFileName(payloadFile);
            this.payloadStatus.Tag = payloadFile;
            this.payloadStatus.Refresh();

            // send payload
            SendPayload(IP, payloadFile, Convert.ToInt32(this.portbox.Text));
        }

        private void buttonSendPayload_Click(object sender, EventArgs e)
        {
            Button obj = (Button)sender;

            // get payload file name & path (remove optional description after ;)
            string payloadFile = obj.Tag.ToString();
            string payloadURL = "";
            if (payloadFile.Contains(';'))
            {
                var items = payloadFile.Split(';');
                if(items.Count() >= 3)
                    payloadURL = items[2];
                else if(items[1].StartsWith("http"))
                    payloadURL = items[1];

                payloadFile = items[0];
            }

            // send payload & update status label
            string payloadPath = Application.StartupPath + "\\Files\\" + payloadFile;

            if (payloadURL.StartsWith("http"))
            {
                try
                {
                    string tempPath = Application.StartupPath + "\\Files\\temp.bin";

                    this.payloadStatus.ForeColor = Color.Blue;
                    this.payloadStatus.Text = "Downloading " + Path.GetFileName(payloadFile);

                    WebClient webClient = new WebClient();
                    webClient.DownloadFile(payloadURL, tempPath);

                    if(File.Exists(tempPath))
                    {
                        if (File.Exists(payloadPath))
                        {
                            File.Delete(payloadPath);
                        }
                        File.Move(tempPath, payloadPath);
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Payload " + payloadFile, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            }

            SendPayloadAction(payloadPath);
        }
                
        private void buttonSendPayload_MouseHover(object sender, System.EventArgs e)
        {
            Button obj = (Button)sender;

            string description = obj.Tag.ToString();

            // get payload file name & description from button's Tag
            if (description.Contains(';'))
            {
                this.payloadStatus.Tag = Application.StartupPath + "\\Files\\" + description.Split(';')[0];
                description = description.Split(';')[1];
            }
            else
            {
                this.payloadStatus.Tag = Application.StartupPath + "\\Files\\" + description;
                description = "Send payload " + Path.GetFileNameWithoutExtension(description).ToString().Replace("_", " ");
            }

            // update status label with payload description
            this.payloadStatus.ForeColor = Color.Navy;
            this.payloadStatus.Text = description;
        }

        private void portbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allow only numbers
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true;
        }

        private void formMain_DragEnter(object sender, DragEventArgs e)
        {
            // check if file is .elf or .bin
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false)) e.Effect = DragDropEffects.All;
        }

        private void formMain_DragDrop(object sender, DragEventArgs e)
        {
            List<string> allowedExtensions = new List<string>() { ".bin", ".elf" };

            // send dropped payload files .bin & .elf only
            string[] droppedFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string payloadFile in droppedFiles)
            {
                if (allowedExtensions.Contains(Path.GetExtension(payloadFile).ToLower()))
                {
                    SendPayloadAction(payloadFile);
                }
            }
        }

        private void processCommandLineArguments()
        {
            // process command line arguments
            string[] args = Environment.GetCommandLineArgs();
            if (args.Count() > 1)
            {
                bool nogui = false;

                //add temporary display button
                Button btn = new Button();
                btn.Top = 100;
                btn.Left = 50;
                btn.Size = new Size(420, 60);
                btn.BackColor = Color.White;
                btn.ForeColor = Color.Blue;
                groupBox1.Controls.Add(btn);

                for (int i = 1; i < args.Count(); i++)
                {
                    if (args[i] == "--ip") ipbox.Text = args[++i];
                    if (args[i] == "--port") portbox.Text = args[++i];
                    if (args[i] == "--silent") silent = true;
                    if (args[i] == "--nogui") nogui = args.Count() > 2;
                    if (args[i] == "--help")
                    {
                        MessageBox.Show("PS5 Payloads " + AppVersion + "\n\n" +
                            "Usage:\n" +
                            "PS5 Payloads.exe [options] [payloads]\n" +
                            "\n" +
                            "--ip <ip> - set ip address\n" +
                            "--port <port> - set port\n" +
                            "--silent - send payloads silently\n" +
                            "--nogui - run without gui\n" +
                            "--help - show this message\n", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close(); Application.Exit();
                    }

                    // send payloads
                    string payloadFile = args[i].ToString().Replace("\"", "");
                    if (File.Exists(payloadFile))
                    {
                        if (nogui == false)
                        {
                            btn.Text = "Sending " + Path.GetFileName(payloadFile);

                            this.Show();
                            this.Refresh();
                        }

                        SendPayloadAction(payloadFile);
                    }
                }
                if (sent || silent || nogui) { this.Close(); Application.Exit(); }

                // remove temporary display button
                groupBox1.Controls.Remove(btn);
            }
        }

        private void loadPayloadButtons()
        {
            //unload current payload buttons
            foreach (System.Windows.Forms.GroupBox groupBox in (new System.Windows.Forms.GroupBox[] { groupBox1, groupBox2, groupBox3, groupBox4 }))
            {
                while (groupBox.Controls.Count > 0)
                {
                    Button btn = (Button)groupBox.Controls[0];
                    groupBox.Controls.Remove(btn);
                }
            }

            //reload payload buttons
            addButtons(groupBox1, "payloads1.txt");
            addButtons(groupBox2, "payloads2.txt");
            addButtons(groupBox3, "payloads3.txt");
            addButtons(groupBox4, "payloads4.txt");
        }
        private void addButtons(Control groupBox, string payloadsFile)
        {
            string[] lines;
            string payloadsPath = Application.StartupPath + "\\" + payloadsFile;
            int count = 0;
            double size = 0;

            // check if file exists and is less than 64kb
            if (File.Exists(payloadsPath))
            {
                size = new System.IO.FileInfo(payloadsPath).Length;
                if (size > 65535) size = 0;
            }

            // if file is empty or larger than 64kb, get files from directory
            if (size == 0)
            {
                string str = "";
                string payloadsDirectory = "";

                if (payloadsFile.Contains("1")) payloadsDirectory = "hen";
                if (payloadsFile.Contains("2")) payloadsDirectory = "backup";
                if (payloadsFile.Contains("3")) payloadsDirectory = "payloads";
                if (payloadsFile.Contains("4")) payloadsDirectory = "more";

                try
                {
                    DirectoryInfo d = new DirectoryInfo(Application.StartupPath + "\\Files\\" + payloadsDirectory);

                    foreach (string ext in (new String[] { "*.bin", "*.elf" }))
                    {
                        FileInfo[] Files = d.GetFiles(ext);

                        foreach (FileInfo file in Files)
                        {
                            if (++count > 24) break;
                            str = str + Path.GetFileNameWithoutExtension(file.Name) + ";" + payloadsDirectory + "\\" + file.Name + "\n";
                        }
                    }
                }
                catch { }

                lines = str.Split('\n');
            }
            else
            {
                // if file exists and is less than 64kb, read from file
                lines = File.ReadAllLines(payloadsPath);
            }

            int leftMargin = 2;
            int top = 20;
            int left = leftMargin;
            int width = 170;
            Color color = Color.White;
            Color color2 = Color.LightGray;
            payloadStatus.Tag = "";
            count = 0;

            int height = lines.Length <= 12 ? 60 :
                         lines.Length <= 15 ? 48 :
                         lines.Length <= 18 ? 38 :
                         lines.Length <= 21 ? 34 : 30;
            for (var i = 0; i < lines.Length; i += 1)
            {
                // Process line
                if (lines[i].Contains(';'))
                {
                    if (++count > 24) break;

                    Color bgColor = color;
                    var args = lines[i].Split(';');
                    if (args[0].Contains('|'))
                    {
                        var args2 = args[0].Split('|');
                        args[0] = args2[0];
                        bgColor = System.Drawing.ColorTranslator.FromHtml(args2[1]);
                    }

                    // add button to groupBox panel
                    Button btn = new Button();
                    btn.Size = new Size(width, height);
                    btn.BackColor = bgColor;
                    btn.Top = top;
                    btn.Left = left; left += width + 1; if (left + width > this.Width) { left = leftMargin; top += height + 1; (color, color2) = (color2, color); }
                    btn.Text = args[0];
                    if (args.Length < 3)
                        btn.Tag = args[1];
                    else if (args.Length <= 3)
                        btn.Tag = args[1] + ";" + args[2];
                    else
                        btn.Tag = args[1] + ";" + args[2] + ";" + args[3];
                    btn.Click += buttonSendPayload_Click;
                    btn.MouseHover += new System.EventHandler(this.buttonSendPayload_MouseHover);
                    groupBox.Controls.Add(btn);

                    // add tooltip to button
                    ToolTip tooltip = new ToolTip();
                    tooltip.SetToolTip(btn, args[1]);
                }
            }
        }

        private void showFileInExplorer(string path)
        {
            try
            {
                // show file in explorer if Tag is not empty
                if (this.payloadStatus.Tag.ToString().Length > 0)
                    System.Diagnostics.Process.Start("explorer.exe", "/select, \"" + path + "\"");
                else
                    System.Diagnostics.Process.Start(Application.StartupPath + "\\Files\\"); // show files folder
            }
            catch (Exception ex)
            {
                // Show error message if failed
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void executeTool(int id)
        {
            string toolsIni = Application.StartupPath + "\\tools.ini";

            // exit if tools.ini doesn't exist
            if (File.Exists(toolsIni) == false) return;

            // exit if payload is too big
            double size = new System.IO.FileInfo(toolsIni).Length;
            if (size > 65535) return;

            // read tools.ini
            var lines = File.ReadAllLines(toolsIni);
            if (lines.Length == 0) return;

            // execute tool
            try
            {
                // Check path contains ';' for arguments
                if (lines[id].Contains(';'))
                    System.Diagnostics.Process.Start(lines[id].Split(';')[0], lines[id].Split(';')[1]);
                else
                    System.Diagnostics.Process.Start(lines[id]);
            }
            catch
            {
                // Show error message if failed
                MessageBox.Show("Ctrl+" + id.ToString() + " has no tool associated.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picLogo_DblClick(object sender, EventArgs e)
        {
            // execute first tool in tools.ini on double click on logo (same as Ctrl+1)
            executeTool(0);
        }

        private void formMain_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape) this.Close();

                // Press F2 to show current payload file in explorer
                if (e.KeyCode == Keys.F2)
                    showFileInExplorer(payloadStatus.Tag.ToString());

                // Press F5 to reload buttons 
                if (e.KeyCode == Keys.F5)
                    loadPayloadButtons();

                // Press Ctrl+1-9 to execute one of the tools defined in tools.ini
                if (e.Control && (e.KeyCode >= Keys.D1 && e.KeyCode <= Keys.D9))
                    executeTool(e.KeyCode - Keys.D1);
            }
            catch { }
        }

        private void payloadStatus_DblClick(object sender, EventArgs e)
        {
            // show file in explorer if Tag is not empty
            try { showFileInExplorer(payloadStatus.Tag.ToString()); } catch { }
        }
    }
}
