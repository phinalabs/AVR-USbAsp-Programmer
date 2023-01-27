namespace XSoft
{
    partial class MainInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainInterface));
            this.SpcMain = new System.Windows.Forms.SplitContainer();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cbxDevices = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.rTxtInfo = new System.Windows.Forms.RichTextBox();
            this.pnControls = new System.Windows.Forms.Panel();
            this.pnButtons = new System.Windows.Forms.Panel();
            this.btnXView = new System.Windows.Forms.Button();
            this.btnTerminal = new System.Windows.Forms.Button();
            this.btnLockBits = new System.Windows.Forms.Button();
            this.btnFuses = new System.Windows.Forms.Button();
            this.btnMemory = new System.Windows.Forms.Button();
            this.btnDevInfo = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.ttpMain = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SpcMain)).BeginInit();
            this.SpcMain.Panel1.SuspendLayout();
            this.SpcMain.Panel2.SuspendLayout();
            this.SpcMain.SuspendLayout();
            this.pnButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // SpcMain
            // 
            this.SpcMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SpcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpcMain.ForeColor = System.Drawing.Color.White;
            this.SpcMain.IsSplitterFixed = true;
            this.SpcMain.Location = new System.Drawing.Point(0, 0);
            this.SpcMain.Name = "SpcMain";
            this.SpcMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SpcMain.Panel1
            // 
            this.SpcMain.Panel1.Controls.Add(this.btnMinimize);
            this.SpcMain.Panel1.Controls.Add(this.lblVersion);
            this.SpcMain.Panel1.Controls.Add(this.btnConnect);
            this.SpcMain.Panel1.Controls.Add(this.cbxDevices);
            this.SpcMain.Panel1.Controls.Add(this.btnExit);
            // 
            // SpcMain.Panel2
            // 
            this.SpcMain.Panel2.Controls.Add(this.rTxtInfo);
            this.SpcMain.Panel2.Controls.Add(this.pnControls);
            this.SpcMain.Panel2.Controls.Add(this.pnButtons);
            this.SpcMain.Size = new System.Drawing.Size(530, 654);
            this.SpcMain.SplitterDistance = 38;
            this.SpcMain.SplitterWidth = 1;
            this.SpcMain.TabIndex = 0;
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(478, -2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(21, 20);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.Location = new System.Drawing.Point(24, 3);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(40, 26);
            this.lblVersion.TabIndex = 3;
            this.lblVersion.Text = "XSoft\r\nv 2.1.0";
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Gray;
            this.btnConnect.FlatAppearance.BorderSize = 0;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Location = new System.Drawing.Point(327, -1);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(69, 21);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cbxDevices
            // 
            this.cbxDevices.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxDevices.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxDevices.BackColor = System.Drawing.Color.White;
            this.cbxDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDevices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxDevices.ForeColor = System.Drawing.Color.Gray;
            this.cbxDevices.FormattingEnabled = true;
            this.cbxDevices.Items.AddRange(new object[] {
            "AT32UC3A0512",
            "AT90CAN128",
            "AT90CAN32",
            "AT90CAN64",
            "AT90PWM2",
            "AT90PWM2B",
            "AT90PWM3",
            "AT90PWM316",
            "AT90PWM3B",
            "AT90S1200",
            "AT90S2313",
            "AT90S2333",
            "AT90S2343",
            "AT90S4414",
            "AT90S4433",
            "AT90S4434",
            "AT90S8515",
            "AT90S8535",
            "AT90USB1286",
            "AT90USB1287",
            "AT90USB162",
            "AT90USB646",
            "AT90USB647",
            "AT90USB82",
            "ATmega103",
            "ATmega128",
            "ATmega1280",
            "ATmega1281",
            "ATmega1284",
            "ATmega1284P",
            "ATmega1284RFR2",
            "ATmega128RFA1",
            "ATmega128RFR2",
            "ATmega16",
            "ATmega161",
            "ATmega162",
            "ATmega163",
            "ATmega164P",
            "ATmega168",
            "ATmega168P",
            "ATmega169",
            "ATmega16U2",
            "ATmega2560",
            "ATmega2561",
            "ATmega2564RFR2",
            "ATmega256RFR2",
            "ATmega32",
            "ATmega324P",
            "ATmega324PA",
            "ATmega325",
            "ATmega3250",
            "ATmega328",
            "ATmega328P",
            "ATmega329",
            "ATmega3290",
            "ATmega3290P",
            "ATmega329P",
            "ATmega32U2",
            "ATmega32U4",
            "ATMEGA406",
            "ATmega48",
            "ATmega48P",
            "ATmega64",
            "ATmega640",
            "ATmega644",
            "ATmega644P",
            "ATmega644RFR2",
            "ATmega645",
            "ATmega6450",
            "ATmega649",
            "ATmega6490",
            "ATmega64RFR2",
            "ATmega8",
            "ATmega8515",
            "ATmega8535",
            "ATmega88",
            "ATmega88P",
            "ATmega8U2",
            "ATtiny10",
            "ATtiny11",
            "ATtiny12",
            "ATtiny13",
            "ATtiny15",
            "ATtiny1634",
            "ATtiny20",
            "ATtiny2313",
            "ATtiny24",
            "ATtiny25",
            "ATtiny26",
            "ATtiny261",
            "ATtiny4",
            "ATtiny40",
            "ATtiny4313",
            "ATtiny43u",
            "ATtiny44",
            "ATtiny45",
            "ATtiny461",
            "ATtiny5",
            "ATtiny84",
            "ATtiny85",
            "ATtiny861",
            "ATtiny88",
            "ATtiny9",
            "ATxmega128A1",
            "ATxmega128A1revD",
            "ATxmega128A1U",
            "ATxmega128A3",
            "ATxmega128A3U",
            "ATxmega128A4",
            "ATxmega128A4U",
            "ATxmega128B1",
            "ATxmega128B3",
            "ATxmega128C3",
            "ATxmega128D3",
            "ATxmega128D4",
            "ATxmega16A4",
            "ATxmega16A4U",
            "ATxmega16C4",
            "ATxmega16D4",
            "ATxmega16E5",
            "ATxmega192A1",
            "ATxmega192A3",
            "ATxmega192A3U",
            "ATxmega192C3",
            "ATxmega192D3",
            "ATxmega256A1",
            "ATxmega256A3",
            "ATxmega256A3B",
            "ATxmega256A3BU",
            "ATxmega256A3U",
            "ATxmega256C3",
            "ATxmega256D3",
            "ATxmega32A4",
            "ATxmega32A4U",
            "ATxmega32C4",
            "ATxmega32D4",
            "ATxmega32E5",
            "ATxmega384C3",
            "ATxmega384D3",
            "ATxmega64A1",
            "ATxmega64A1U",
            "ATxmega64A3",
            "ATxmega64A3U",
            "ATxmega64A4",
            "ATxmega64A4U",
            "ATxmega64B1",
            "ATxmega64B3",
            "ATxmega64C3",
            "ATxmega64D3",
            "ATxmega64D4",
            "ATxmega8E5"});
            this.cbxDevices.Location = new System.Drawing.Point(204, -1);
            this.cbxDevices.Name = "cbxDevices";
            this.cbxDevices.Size = new System.Drawing.Size(113, 21);
            this.cbxDevices.TabIndex = 1;
            this.ttpMain.SetToolTip(this.cbxDevices, "Select device.");
            this.cbxDevices.SelectedIndexChanged += new System.EventHandler(this.cbxDevices_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(505, -2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(21, 20);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "x";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rTxtInfo
            // 
            this.rTxtInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rTxtInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTxtInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rTxtInfo.ForeColor = System.Drawing.Color.White;
            this.rTxtInfo.Location = new System.Drawing.Point(0, 499);
            this.rTxtInfo.Name = "rTxtInfo";
            this.rTxtInfo.Size = new System.Drawing.Size(528, 114);
            this.rTxtInfo.TabIndex = 2;
            this.rTxtInfo.Text = "";
            // 
            // pnControls
            // 
            this.pnControls.BackColor = System.Drawing.Color.Transparent;
            this.pnControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnControls.ForeColor = System.Drawing.Color.White;
            this.pnControls.Location = new System.Drawing.Point(147, 0);
            this.pnControls.Name = "pnControls";
            this.pnControls.Size = new System.Drawing.Size(382, 498);
            this.pnControls.TabIndex = 1;
            // 
            // pnButtons
            // 
            this.pnButtons.BackColor = System.Drawing.Color.Transparent;
            this.pnButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnButtons.Controls.Add(this.btnXView);
            this.pnButtons.Controls.Add(this.btnTerminal);
            this.pnButtons.Controls.Add(this.btnLockBits);
            this.pnButtons.Controls.Add(this.btnFuses);
            this.pnButtons.Controls.Add(this.btnMemory);
            this.pnButtons.Controls.Add(this.btnDevInfo);
            this.pnButtons.Controls.Add(this.btnHome);
            this.pnButtons.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnButtons.ForeColor = System.Drawing.Color.White;
            this.pnButtons.Location = new System.Drawing.Point(0, 0);
            this.pnButtons.Name = "pnButtons";
            this.pnButtons.Size = new System.Drawing.Size(149, 498);
            this.pnButtons.TabIndex = 0;
            // 
            // btnXView
            // 
            this.btnXView.BackColor = System.Drawing.Color.Gray;
            this.btnXView.FlatAppearance.BorderSize = 0;
            this.btnXView.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnXView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnXView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnXView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnXView.Location = new System.Drawing.Point(26, 388);
            this.btnXView.Name = "btnXView";
            this.btnXView.Size = new System.Drawing.Size(122, 37);
            this.btnXView.TabIndex = 6;
            this.btnXView.Text = "Arduino";
            this.ttpMain.SetToolTip(this.btnXView, "view device pin/application information.\r\n");
            this.btnXView.UseVisualStyleBackColor = false;
            this.btnXView.Click += new System.EventHandler(this.btnXView_Click);
            // 
            // btnTerminal
            // 
            this.btnTerminal.BackColor = System.Drawing.Color.Gray;
            this.btnTerminal.FlatAppearance.BorderSize = 0;
            this.btnTerminal.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnTerminal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTerminal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTerminal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTerminal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTerminal.Location = new System.Drawing.Point(26, 328);
            this.btnTerminal.Name = "btnTerminal";
            this.btnTerminal.Size = new System.Drawing.Size(122, 37);
            this.btnTerminal.TabIndex = 5;
            this.btnTerminal.Text = "Terminal";
            this.ttpMain.SetToolTip(this.btnTerminal, "Serial port terminal.\r\n");
            this.btnTerminal.UseVisualStyleBackColor = false;
            this.btnTerminal.Click += new System.EventHandler(this.btnTerminal_Click);
            // 
            // btnLockBits
            // 
            this.btnLockBits.BackColor = System.Drawing.Color.Gray;
            this.btnLockBits.FlatAppearance.BorderSize = 0;
            this.btnLockBits.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnLockBits.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLockBits.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLockBits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLockBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLockBits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLockBits.Location = new System.Drawing.Point(26, 267);
            this.btnLockBits.Name = "btnLockBits";
            this.btnLockBits.Size = new System.Drawing.Size(122, 37);
            this.btnLockBits.TabIndex = 4;
            this.btnLockBits.Text = "Lock Bits";
            this.ttpMain.SetToolTip(this.btnLockBits, "Program, read and verify\r\ndevice lockbits.");
            this.btnLockBits.UseVisualStyleBackColor = false;
            this.btnLockBits.Click += new System.EventHandler(this.btnLockBits_Click);
            // 
            // btnFuses
            // 
            this.btnFuses.BackColor = System.Drawing.Color.Gray;
            this.btnFuses.FlatAppearance.BorderSize = 0;
            this.btnFuses.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnFuses.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFuses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFuses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFuses.Location = new System.Drawing.Point(26, 206);
            this.btnFuses.Name = "btnFuses";
            this.btnFuses.Size = new System.Drawing.Size(122, 37);
            this.btnFuses.TabIndex = 3;
            this.btnFuses.Text = "Fuse Bits";
            this.ttpMain.SetToolTip(this.btnFuses, "Write, read and verify device\r\nfuse bits.");
            this.btnFuses.UseVisualStyleBackColor = false;
            this.btnFuses.Click += new System.EventHandler(this.btnFuses_Click);
            // 
            // btnMemory
            // 
            this.btnMemory.BackColor = System.Drawing.Color.Gray;
            this.btnMemory.FlatAppearance.BorderSize = 0;
            this.btnMemory.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnMemory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMemory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMemory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMemory.Location = new System.Drawing.Point(26, 145);
            this.btnMemory.Name = "btnMemory";
            this.btnMemory.Size = new System.Drawing.Size(122, 37);
            this.btnMemory.TabIndex = 2;
            this.btnMemory.Text = "Flash/Eep";
            this.ttpMain.SetToolTip(this.btnMemory, "Write, read and verify device \r\nflash and eeprom memories.");
            this.btnMemory.UseVisualStyleBackColor = false;
            this.btnMemory.Click += new System.EventHandler(this.btnMemory_Click);
            // 
            // btnDevInfo
            // 
            this.btnDevInfo.BackColor = System.Drawing.Color.Gray;
            this.btnDevInfo.FlatAppearance.BorderSize = 0;
            this.btnDevInfo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnDevInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDevInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDevInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDevInfo.Location = new System.Drawing.Point(26, 84);
            this.btnDevInfo.Name = "btnDevInfo";
            this.btnDevInfo.Size = new System.Drawing.Size(122, 37);
            this.btnDevInfo.TabIndex = 1;
            this.btnDevInfo.Text = "Device";
            this.ttpMain.SetToolTip(this.btnDevInfo, "Device information");
            this.btnDevInfo.UseVisualStyleBackColor = false;
            this.btnDevInfo.Click += new System.EventHandler(this.btnDevInfo_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Gray;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHome.Location = new System.Drawing.Point(26, 24);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(122, 37);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // ttpMain
            // 
            this.ttpMain.ForeColor = System.Drawing.Color.White;
            // 
            // MainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(530, 654);
            this.ControlBox = false;
            this.Controls.Add(this.SpcMain);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainInterface";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XSoft";
            this.Load += new System.EventHandler(this.MainInterface_Load);
            this.SpcMain.Panel1.ResumeLayout(false);
            this.SpcMain.Panel1.PerformLayout();
            this.SpcMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpcMain)).EndInit();
            this.SpcMain.ResumeLayout(false);
            this.pnButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SpcMain;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnControls;
        private System.Windows.Forms.Panel pnButtons;
        private System.Windows.Forms.Button btnXView;
        private System.Windows.Forms.ToolTip ttpMain;
        private System.Windows.Forms.Button btnTerminal;
        private System.Windows.Forms.Button btnLockBits;
        private System.Windows.Forms.Button btnFuses;
        private System.Windows.Forms.Button btnMemory;
        private System.Windows.Forms.Button btnDevInfo;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.ComboBox cbxDevices;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.RichTextBox rTxtInfo;
    }
}

