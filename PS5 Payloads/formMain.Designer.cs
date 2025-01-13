
namespace PS5_Payloads
{
    partial class formMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.payloadStatus = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.portbox = new System.Windows.Forms.TextBox();
            this.ipbox = new System.Windows.Forms.TextBox();
            this.btnSaveIP = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabMore = new System.Windows.Forms.Button();
            this.tabPayloads = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabBackup = new System.Windows.Forms.Button();
            this.tabHEN = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(0, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 266);
            this.groupBox1.TabIndex = 146;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payload ";
            // 
            // payloadStatus
            // 
            this.payloadStatus.AutoSize = true;
            this.payloadStatus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.payloadStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.payloadStatus.ForeColor = System.Drawing.Color.Black;
            this.payloadStatus.Location = new System.Drawing.Point(4, 334);
            this.payloadStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.payloadStatus.Name = "payloadStatus";
            this.payloadStatus.Size = new System.Drawing.Size(43, 13);
            this.payloadStatus.TabIndex = 134;
            this.payloadStatus.Text = "Status";
            this.payloadStatus.DoubleClick += new System.EventHandler(this.payloadStatus_DblClick);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label17.Cursor = System.Windows.Forms.Cursors.Default;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(5, 6);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 17);
            this.label17.TabIndex = 142;
            this.label17.Text = "PS IP  :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(181, 6);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(54, 17);
            this.label18.TabIndex = 144;
            this.label18.Text = "PORT  :";
            // 
            // portbox
            // 
            this.portbox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.portbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.portbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portbox.ForeColor = System.Drawing.Color.Black;
            this.portbox.Location = new System.Drawing.Point(240, 4);
            this.portbox.Margin = new System.Windows.Forms.Padding(4);
            this.portbox.MaxLength = 5;
            this.portbox.Name = "portbox";
            this.portbox.Size = new System.Drawing.Size(73, 25);
            this.portbox.TabIndex = 143;
            this.portbox.Text = "9021";
            this.portbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.portbox_KeyPress);
            // 
            // ipbox
            // 
            this.ipbox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ipbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ipbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipbox.ForeColor = System.Drawing.Color.Black;
            this.ipbox.Location = new System.Drawing.Point(63, 4);
            this.ipbox.Margin = new System.Windows.Forms.Padding(4);
            this.ipbox.MaxLength = 18;
            this.ipbox.Name = "ipbox";
            this.ipbox.Size = new System.Drawing.Size(114, 25);
            this.ipbox.TabIndex = 141;
            // 
            // btnSaveIP
            // 
            this.btnSaveIP.BackColor = System.Drawing.Color.White;
            this.btnSaveIP.FlatAppearance.BorderSize = 0;
            this.btnSaveIP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveIP.ForeColor = System.Drawing.Color.Black;
            this.btnSaveIP.Location = new System.Drawing.Point(315, 4);
            this.btnSaveIP.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveIP.Name = "btnSaveIP";
            this.btnSaveIP.Size = new System.Drawing.Size(202, 25);
            this.btnSaveIP.TabIndex = 147;
            this.btnSaveIP.Text = "Save PS5 IP";
            this.btnSaveIP.UseVisualStyleBackColor = false;
            this.btnSaveIP.Click += new System.EventHandler(this.btnSaveIP_Click);
            this.btnSaveIP.Enter += new System.EventHandler(this.btnSaveIP_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = global::PS5_Payloads.Properties.Resources.ps5payload_01;
            this.picLogo.Location = new System.Drawing.Point(-1, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(538, 76);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 148;
            this.picLogo.TabStop = false;
            this.picLogo.DoubleClick += new System.EventHandler(this.picLogo_DblClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(81)))), ((int)(((byte)(149)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-1, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 359);
            this.panel1.TabIndex = 149;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.tabMore);
            this.panel2.Controls.Add(this.tabPayloads);
            this.panel2.Controls.Add(this.tabBackup);
            this.panel2.Controls.Add(this.tabHEN);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.ipbox);
            this.panel2.Controls.Add(this.btnSaveIP);
            this.panel2.Controls.Add(this.portbox);
            this.panel2.Controls.Add(this.payloadStatus);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(521, 353);
            this.panel2.TabIndex = 150;
            // 
            // tabMore
            // 
            this.tabMore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabMore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tabMore.Image = ((System.Drawing.Image)(resources.GetObject("tabMore.Image")));
            this.tabMore.Location = new System.Drawing.Point(390, 32);
            this.tabMore.Name = "tabMore";
            this.tabMore.Size = new System.Drawing.Size(127, 32);
            this.tabMore.TabIndex = 152;
            this.tabMore.UseVisualStyleBackColor = true;
            this.tabMore.Click += new System.EventHandler(this.tabMore_Click);
            // 
            // tabPayloads
            // 
            this.tabPayloads.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabPayloads.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tabPayloads.ImageIndex = 4;
            this.tabPayloads.ImageList = this.imageList1;
            this.tabPayloads.Location = new System.Drawing.Point(259, 32);
            this.tabPayloads.Name = "tabPayloads";
            this.tabPayloads.Size = new System.Drawing.Size(128, 32);
            this.tabPayloads.TabIndex = 150;
            this.tabPayloads.UseVisualStyleBackColor = true;
            this.tabPayloads.Click += new System.EventHandler(this.tabPayloads_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "PS5HEN.png");
            this.imageList1.Images.SetKeyName(1, "PS5Backup.png");
            this.imageList1.Images.SetKeyName(2, "PS5Update.png");
            this.imageList1.Images.SetKeyName(3, "PS5About.png");
            this.imageList1.Images.SetKeyName(4, "Payload.png");
            // 
            // tabBackup
            // 
            this.tabBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabBackup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tabBackup.ImageIndex = 1;
            this.tabBackup.ImageList = this.imageList1;
            this.tabBackup.Location = new System.Drawing.Point(130, 32);
            this.tabBackup.Name = "tabBackup";
            this.tabBackup.Size = new System.Drawing.Size(128, 32);
            this.tabBackup.TabIndex = 149;
            this.tabBackup.UseVisualStyleBackColor = true;
            this.tabBackup.Click += new System.EventHandler(this.tabBackup_Click);
            // 
            // tabHEN
            // 
            this.tabHEN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabHEN.BackgroundImage")));
            this.tabHEN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabHEN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tabHEN.Location = new System.Drawing.Point(1, 32);
            this.tabHEN.Name = "tabHEN";
            this.tabHEN.Size = new System.Drawing.Size(128, 32);
            this.tabHEN.TabIndex = 148;
            this.tabHEN.UseVisualStyleBackColor = true;
            this.tabHEN.Click += new System.EventHandler(this.tabHEN_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(543, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(517, 266);
            this.groupBox2.TabIndex = 150;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Backup";
            this.groupBox2.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(543, 144);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(517, 266);
            this.groupBox3.TabIndex = 151;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update";
            this.groupBox3.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(543, 144);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(517, 266);
            this.groupBox4.TabIndex = 151;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "More";
            this.groupBox4.Visible = false;
            // 
            // formMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 435);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.formMain_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.formMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.formMain_DragEnter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formMain_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label payloadStatus;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox portbox;
        private System.Windows.Forms.TextBox ipbox;
        private System.Windows.Forms.Button btnSaveIP;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button tabBackup;
        private System.Windows.Forms.Button tabHEN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button tabPayloads;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button tabMore;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

