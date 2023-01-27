namespace Terminal
{
    partial class Terminal
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Terminal));
            this.rtxtDisplayWindow = new System.Windows.Forms.RichTextBox();
            this.pnDisplayWindow = new System.Windows.Forms.Panel();
            this.pnSettings = new System.Windows.Forms.Panel();
            this.lblTransType = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdoText = new System.Windows.Forms.RadioButton();
            this.rdoHex = new System.Windows.Forms.RadioButton();
            this.cboData = new System.Windows.Forms.ComboBox();
            this.cboStop = new System.Windows.Forms.ComboBox();
            this.cboParity = new System.Windows.Forms.ComboBox();
            this.cboBaud = new System.Windows.Forms.ComboBox();
            this.lblDataHeader = new System.Windows.Forms.Label();
            this.lblStopHeader = new System.Windows.Forms.Label();
            this.lblParityHeader = new System.Windows.Forms.Label();
            this.lblBaudHeader = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.cboPort = new System.Windows.Forms.ComboBox();
            this.lblPortHeader = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.pnDisplayWindow.SuspendLayout();
            this.pnSettings.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtxtDisplayWindow
            // 
            this.rtxtDisplayWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rtxtDisplayWindow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtDisplayWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtDisplayWindow.ForeColor = System.Drawing.Color.White;
            this.rtxtDisplayWindow.Location = new System.Drawing.Point(0, 0);
            this.rtxtDisplayWindow.Name = "rtxtDisplayWindow";
            this.rtxtDisplayWindow.ReadOnly = true;
            this.rtxtDisplayWindow.Size = new System.Drawing.Size(356, 396);
            this.rtxtDisplayWindow.TabIndex = 0;
            this.rtxtDisplayWindow.Text = "";
            // 
            // pnDisplayWindow
            // 
            this.pnDisplayWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnDisplayWindow.Controls.Add(this.pnSettings);
            this.pnDisplayWindow.Controls.Add(this.rtxtDisplayWindow);
            this.pnDisplayWindow.ForeColor = System.Drawing.Color.White;
            this.pnDisplayWindow.Location = new System.Drawing.Point(13, 45);
            this.pnDisplayWindow.Name = "pnDisplayWindow";
            this.pnDisplayWindow.Size = new System.Drawing.Size(361, 398);
            this.pnDisplayWindow.TabIndex = 1;
            // 
            // pnSettings
            // 
            this.pnSettings.BackColor = System.Drawing.Color.Gray;
            this.pnSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnSettings.Controls.Add(this.lblTransType);
            this.pnSettings.Controls.Add(this.panel1);
            this.pnSettings.Controls.Add(this.cboData);
            this.pnSettings.Controls.Add(this.cboStop);
            this.pnSettings.Controls.Add(this.cboParity);
            this.pnSettings.Controls.Add(this.cboBaud);
            this.pnSettings.Controls.Add(this.lblDataHeader);
            this.pnSettings.Controls.Add(this.lblStopHeader);
            this.pnSettings.Controls.Add(this.lblParityHeader);
            this.pnSettings.Controls.Add(this.lblBaudHeader);
            this.pnSettings.ForeColor = System.Drawing.Color.White;
            this.pnSettings.Location = new System.Drawing.Point(189, 99);
            this.pnSettings.Name = "pnSettings";
            this.pnSettings.Size = new System.Drawing.Size(167, 294);
            this.pnSettings.TabIndex = 1;
            this.pnSettings.Visible = false;
            // 
            // lblTransType
            // 
            this.lblTransType.AutoSize = true;
            this.lblTransType.ForeColor = System.Drawing.Color.White;
            this.lblTransType.Location = new System.Drawing.Point(19, 227);
            this.lblTransType.Name = "lblTransType";
            this.lblTransType.Size = new System.Drawing.Size(95, 13);
            this.lblTransType.TabIndex = 15;
            this.lblTransType.Text = "Transmission Type";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.rdoText);
            this.panel1.Controls.Add(this.rdoHex);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(13, 234);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 49);
            this.panel1.TabIndex = 14;
            // 
            // rdoText
            // 
            this.rdoText.AutoSize = true;
            this.rdoText.ForeColor = System.Drawing.Color.White;
            this.rdoText.Location = new System.Drawing.Point(75, 22);
            this.rdoText.Name = "rdoText";
            this.rdoText.Size = new System.Drawing.Size(46, 17);
            this.rdoText.TabIndex = 1;
            this.rdoText.TabStop = true;
            this.rdoText.Text = "Text";
            this.rdoText.UseVisualStyleBackColor = true;
            // 
            // rdoHex
            // 
            this.rdoHex.AutoSize = true;
            this.rdoHex.ForeColor = System.Drawing.Color.White;
            this.rdoHex.Location = new System.Drawing.Point(11, 22);
            this.rdoHex.Name = "rdoHex";
            this.rdoHex.Size = new System.Drawing.Size(44, 17);
            this.rdoHex.TabIndex = 0;
            this.rdoHex.TabStop = true;
            this.rdoHex.Text = "Hex";
            this.rdoHex.UseVisualStyleBackColor = true;
            this.rdoHex.CheckedChanged += new System.EventHandler(this.rdoHex_CheckedChanged);
            // 
            // cboData
            // 
            this.cboData.BackColor = System.Drawing.Color.Gray;
            this.cboData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboData.ForeColor = System.Drawing.Color.White;
            this.cboData.FormattingEnabled = true;
            this.cboData.Items.AddRange(new object[] {
            "7",
            "8",
            "9"});
            this.cboData.Location = new System.Drawing.Point(88, 175);
            this.cboData.Name = "cboData";
            this.cboData.Size = new System.Drawing.Size(62, 21);
            this.cboData.TabIndex = 12;
            // 
            // cboStop
            // 
            this.cboStop.BackColor = System.Drawing.Color.Gray;
            this.cboStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboStop.ForeColor = System.Drawing.Color.White;
            this.cboStop.FormattingEnabled = true;
            this.cboStop.Location = new System.Drawing.Point(88, 116);
            this.cboStop.Name = "cboStop";
            this.cboStop.Size = new System.Drawing.Size(62, 21);
            this.cboStop.TabIndex = 10;
            // 
            // cboParity
            // 
            this.cboParity.BackColor = System.Drawing.Color.Gray;
            this.cboParity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboParity.ForeColor = System.Drawing.Color.White;
            this.cboParity.FormattingEnabled = true;
            this.cboParity.Location = new System.Drawing.Point(88, 63);
            this.cboParity.Name = "cboParity";
            this.cboParity.Size = new System.Drawing.Size(62, 21);
            this.cboParity.TabIndex = 8;
            // 
            // cboBaud
            // 
            this.cboBaud.BackColor = System.Drawing.Color.Gray;
            this.cboBaud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboBaud.ForeColor = System.Drawing.Color.White;
            this.cboBaud.FormattingEnabled = true;
            this.cboBaud.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cboBaud.Location = new System.Drawing.Point(88, 10);
            this.cboBaud.Name = "cboBaud";
            this.cboBaud.Size = new System.Drawing.Size(62, 21);
            this.cboBaud.TabIndex = 6;
            // 
            // lblDataHeader
            // 
            this.lblDataHeader.AutoSize = true;
            this.lblDataHeader.ForeColor = System.Drawing.Color.White;
            this.lblDataHeader.Location = new System.Drawing.Point(10, 178);
            this.lblDataHeader.Name = "lblDataHeader";
            this.lblDataHeader.Size = new System.Drawing.Size(50, 13);
            this.lblDataHeader.TabIndex = 13;
            this.lblDataHeader.Text = "Data Bits";
            // 
            // lblStopHeader
            // 
            this.lblStopHeader.AutoSize = true;
            this.lblStopHeader.ForeColor = System.Drawing.Color.White;
            this.lblStopHeader.Location = new System.Drawing.Point(10, 119);
            this.lblStopHeader.Name = "lblStopHeader";
            this.lblStopHeader.Size = new System.Drawing.Size(49, 13);
            this.lblStopHeader.TabIndex = 11;
            this.lblStopHeader.Text = "Stop Bits";
            // 
            // lblParityHeader
            // 
            this.lblParityHeader.AutoSize = true;
            this.lblParityHeader.ForeColor = System.Drawing.Color.White;
            this.lblParityHeader.Location = new System.Drawing.Point(10, 66);
            this.lblParityHeader.Name = "lblParityHeader";
            this.lblParityHeader.Size = new System.Drawing.Size(48, 13);
            this.lblParityHeader.TabIndex = 9;
            this.lblParityHeader.Text = "Parity Bit";
            // 
            // lblBaudHeader
            // 
            this.lblBaudHeader.AutoSize = true;
            this.lblBaudHeader.ForeColor = System.Drawing.Color.White;
            this.lblBaudHeader.Location = new System.Drawing.Point(10, 13);
            this.lblBaudHeader.Name = "lblBaudHeader";
            this.lblBaudHeader.Size = new System.Drawing.Size(58, 13);
            this.lblBaudHeader.TabIndex = 7;
            this.lblBaudHeader.Text = "Baud Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Serial port terminal";
            // 
            // txtData
            // 
            this.txtData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.ForeColor = System.Drawing.Color.White;
            this.txtData.Location = new System.Drawing.Point(13, 459);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(251, 22);
            this.txtData.TabIndex = 3;
            // 
            // btnSend
            // 
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(276, 458);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(61, 22);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(343, 459);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(31, 22);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "+";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // cboPort
            // 
            this.cboPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cboPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPort.ForeColor = System.Drawing.Color.Gray;
            this.cboPort.FormattingEnabled = true;
            this.cboPort.Location = new System.Drawing.Point(221, 9);
            this.cboPort.Name = "cboPort";
            this.cboPort.Size = new System.Drawing.Size(62, 21);
            this.cboPort.TabIndex = 0;
            // 
            // lblPortHeader
            // 
            this.lblPortHeader.AutoSize = true;
            this.lblPortHeader.ForeColor = System.Drawing.Color.White;
            this.lblPortHeader.Location = new System.Drawing.Point(190, 12);
            this.lblPortHeader.Name = "lblPortHeader";
            this.lblPortHeader.Size = new System.Drawing.Size(25, 13);
            this.lblPortHeader.TabIndex = 1;
            this.lblPortHeader.Text = "port";
            // 
            // btnOpen
            // 
            this.btnOpen.FlatAppearance.BorderSize = 0;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.ForeColor = System.Drawing.Color.White;
            this.btnOpen.Location = new System.Drawing.Point(303, 9);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(43, 21);
            this.btnOpen.TabIndex = 6;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // Terminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.cboPort);
            this.Controls.Add(this.lblPortHeader);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnDisplayWindow);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Name = "Terminal";
            this.Size = new System.Drawing.Size(377, 498);
            this.pnDisplayWindow.ResumeLayout(false);
            this.pnSettings.ResumeLayout(false);
            this.pnSettings.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtDisplayWindow;
        private System.Windows.Forms.Panel pnDisplayWindow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel pnSettings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDataHeader;
        private System.Windows.Forms.ComboBox cboData;
        private System.Windows.Forms.Label lblStopHeader;
        private System.Windows.Forms.ComboBox cboStop;
        private System.Windows.Forms.Label lblParityHeader;
        private System.Windows.Forms.ComboBox cboParity;
        private System.Windows.Forms.Label lblBaudHeader;
        private System.Windows.Forms.ComboBox cboBaud;
        private System.Windows.Forms.ComboBox cboPort;
        private System.Windows.Forms.Label lblPortHeader;
        private System.Windows.Forms.RadioButton rdoText;
        private System.Windows.Forms.RadioButton rdoHex;
        private System.Windows.Forms.Label lblTransType;
        private System.Windows.Forms.Button btnOpen;
    }
}
