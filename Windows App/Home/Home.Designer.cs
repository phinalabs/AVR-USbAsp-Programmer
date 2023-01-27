namespace Home
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            this.linkEmail = new System.Windows.Forms.LinkLabel();
            this.linkLicense = new System.Windows.Forms.LinkLabel();
            this.pnSupport = new System.Windows.Forms.Panel();
            this.linkHelp = new System.Windows.Forms.LinkLabel();
            this.linkSupport = new System.Windows.Forms.LinkLabel();
            this.tbxHeaderUp = new System.Windows.Forms.TextBox();
            this.tbxHeaderDown = new System.Windows.Forms.TextBox();
            this.pnHomeData = new System.Windows.Forms.Panel();
            this.lstView = new System.Windows.Forms.ListView();
            this.CHDEC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHHEX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHASCII = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHBIN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyTsm = new System.Windows.Forms.ToolStripMenuItem();
            this.decTsm = new System.Windows.Forms.ToolStripMenuItem();
            this.hexTsm = new System.Windows.Forms.ToolStripMenuItem();
            this.asciiTsm = new System.Windows.Forms.ToolStripMenuItem();
            this.binTsm = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnSupport.SuspendLayout();
            this.pnHomeData.SuspendLayout();
            this.cmsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkEmail
            // 
            this.linkEmail.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.linkEmail.AutoSize = true;
            this.linkEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkEmail.ForeColor = System.Drawing.Color.White;
            this.linkEmail.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.linkEmail.Location = new System.Drawing.Point(-3, 26);
            this.linkEmail.Name = "linkEmail";
            this.linkEmail.Size = new System.Drawing.Size(96, 13);
            this.linkEmail.TabIndex = 1;
            this.linkEmail.TabStop = true;
            this.linkEmail.Text = "info@warefab.com";
            this.linkEmail.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.linkEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEmail_LinkClicked);
            // 
            // linkLicense
            // 
            this.linkLicense.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.linkLicense.AutoSize = true;
            this.linkLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLicense.ForeColor = System.Drawing.Color.White;
            this.linkLicense.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.linkLicense.Location = new System.Drawing.Point(-3, 0);
            this.linkLicense.Name = "linkLicense";
            this.linkLicense.Size = new System.Drawing.Size(44, 13);
            this.linkLicense.TabIndex = 3;
            this.linkLicense.TabStop = true;
            this.linkLicense.Text = "License";
            this.linkLicense.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.linkLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLicense_LinkClicked);
            // 
            // pnSupport
            // 
            this.pnSupport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnSupport.Controls.Add(this.linkHelp);
            this.pnSupport.Controls.Add(this.linkLicense);
            this.pnSupport.Controls.Add(this.linkEmail);
            this.pnSupport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnSupport.ForeColor = System.Drawing.Color.White;
            this.pnSupport.Location = new System.Drawing.Point(219, 30);
            this.pnSupport.Name = "pnSupport";
            this.pnSupport.Size = new System.Drawing.Size(132, 43);
            this.pnSupport.TabIndex = 4;
            // 
            // linkHelp
            // 
            this.linkHelp.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.linkHelp.AutoSize = true;
            this.linkHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkHelp.ForeColor = System.Drawing.Color.White;
            this.linkHelp.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.linkHelp.Location = new System.Drawing.Point(-3, 13);
            this.linkHelp.Name = "linkHelp";
            this.linkHelp.Size = new System.Drawing.Size(29, 13);
            this.linkHelp.TabIndex = 4;
            this.linkHelp.TabStop = true;
            this.linkHelp.Text = "Help";
            this.linkHelp.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // linkSupport
            // 
            this.linkSupport.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.linkSupport.AutoSize = true;
            this.linkSupport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkSupport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.linkSupport.LinkColor = System.Drawing.Color.White;
            this.linkSupport.Location = new System.Drawing.Point(216, 14);
            this.linkSupport.Name = "linkSupport";
            this.linkSupport.Size = new System.Drawing.Size(44, 13);
            this.linkSupport.TabIndex = 4;
            this.linkSupport.TabStop = true;
            this.linkSupport.Text = "Support";
            this.linkSupport.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.linkSupport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSupport_LinkClicked);
            // 
            // tbxHeaderUp
            // 
            this.tbxHeaderUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxHeaderUp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxHeaderUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbxHeaderUp.Location = new System.Drawing.Point(43, 14);
            this.tbxHeaderUp.Multiline = true;
            this.tbxHeaderUp.Name = "tbxHeaderUp";
            this.tbxHeaderUp.ReadOnly = true;
            this.tbxHeaderUp.Size = new System.Drawing.Size(143, 58);
            this.tbxHeaderUp.TabIndex = 6;
            this.tbxHeaderUp.Text = "Atmel ISP programmer\r\n v 2.1.0\r\n(c) 2015 warefab\r\n\r\n";
            // 
            // tbxHeaderDown
            // 
            this.tbxHeaderDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxHeaderDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxHeaderDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbxHeaderDown.Location = new System.Drawing.Point(43, 469);
            this.tbxHeaderDown.Multiline = true;
            this.tbxHeaderDown.Name = "tbxHeaderDown";
            this.tbxHeaderDown.ReadOnly = true;
            this.tbxHeaderDown.Size = new System.Drawing.Size(143, 17);
            this.tbxHeaderDown.TabIndex = 7;
            this.tbxHeaderDown.Text = "Research. Design.Innovate\r\n";
            // 
            // pnHomeData
            // 
            this.pnHomeData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnHomeData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnHomeData.Controls.Add(this.lstView);
            this.pnHomeData.Location = new System.Drawing.Point(43, 78);
            this.pnHomeData.Name = "pnHomeData";
            this.pnHomeData.Size = new System.Drawing.Size(298, 389);
            this.pnHomeData.TabIndex = 8;
            // 
            // lstView
            // 
            this.lstView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lstView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CHDEC,
            this.CHHEX,
            this.CHASCII,
            this.CHBIN});
            this.lstView.ContextMenuStrip = this.cmsMain;
            this.lstView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstView.ForeColor = System.Drawing.Color.Silver;
            this.lstView.FullRowSelect = true;
            this.lstView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstView.HideSelection = false;
            this.lstView.Location = new System.Drawing.Point(0, 0);
            this.lstView.Name = "lstView";
            this.lstView.ShowItemToolTips = true;
            this.lstView.Size = new System.Drawing.Size(296, 387);
            this.lstView.TabIndex = 0;
            this.lstView.UseCompatibleStateImageBehavior = false;
            this.lstView.View = System.Windows.Forms.View.Details;
            // 
            // CHDEC
            // 
            this.CHDEC.Text = "DEC";
            // 
            // CHHEX
            // 
            this.CHHEX.Text = "HEX";
            this.CHHEX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CHASCII
            // 
            this.CHASCII.Text = "ASCII";
            this.CHASCII.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CHASCII.Width = 57;
            // 
            // CHBIN
            // 
            this.CHBIN.Text = "BIN";
            this.CHBIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CHBIN.Width = 90;
            // 
            // cmsMain
            // 
            this.cmsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyTsm,
            this.copyAllToolStripMenuItem});
            this.cmsMain.Name = "contextMenuStrip1";
            this.cmsMain.Size = new System.Drawing.Size(138, 48);
            // 
            // copyTsm
            // 
            this.copyTsm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.decTsm,
            this.hexTsm,
            this.asciiTsm,
            this.binTsm});
            this.copyTsm.Name = "copyTsm";
            this.copyTsm.Size = new System.Drawing.Size(137, 22);
            this.copyTsm.Text = "Copy Single";
            // 
            // decTsm
            // 
            this.decTsm.Name = "decTsm";
            this.decTsm.Size = new System.Drawing.Size(102, 22);
            this.decTsm.Text = "DEC";
            this.decTsm.Click += new System.EventHandler(this.decTsm_Click);
            // 
            // hexTsm
            // 
            this.hexTsm.Name = "hexTsm";
            this.hexTsm.Size = new System.Drawing.Size(102, 22);
            this.hexTsm.Text = "HEX";
            this.hexTsm.Click += new System.EventHandler(this.hexTsm_Click);
            // 
            // asciiTsm
            // 
            this.asciiTsm.Name = "asciiTsm";
            this.asciiTsm.Size = new System.Drawing.Size(102, 22);
            this.asciiTsm.Text = "ASCII";
            this.asciiTsm.Click += new System.EventHandler(this.asciiTsm_Click);
            // 
            // binTsm
            // 
            this.binTsm.Name = "binTsm";
            this.binTsm.Size = new System.Drawing.Size(102, 22);
            this.binTsm.Text = "BIN";
            this.binTsm.Click += new System.EventHandler(this.binTsm_Click);
            // 
            // copyAllToolStripMenuItem
            // 
            this.copyAllToolStripMenuItem.Name = "copyAllToolStripMenuItem";
            this.copyAllToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.copyAllToolStripMenuItem.Text = "Copy All";
            this.copyAllToolStripMenuItem.Click += new System.EventHandler(this.copyAllToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.pnHomeData);
            this.Controls.Add(this.tbxHeaderDown);
            this.Controls.Add(this.tbxHeaderUp);
            this.Controls.Add(this.linkSupport);
            this.Controls.Add(this.pnSupport);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Name = "Home";
            this.Size = new System.Drawing.Size(424, 498);
            this.pnSupport.ResumeLayout(false);
            this.pnSupport.PerformLayout();
            this.pnHomeData.ResumeLayout(false);
            this.cmsMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkEmail;
        private System.Windows.Forms.LinkLabel linkLicense;
        private System.Windows.Forms.Panel pnSupport;
        private System.Windows.Forms.LinkLabel linkSupport;
        private System.Windows.Forms.TextBox tbxHeaderDown;
        private System.Windows.Forms.TextBox tbxHeaderUp;
        private System.Windows.Forms.LinkLabel linkHelp;
        private System.Windows.Forms.Panel pnHomeData;
        private System.Windows.Forms.ListView lstView;
        private System.Windows.Forms.ColumnHeader CHDEC;
        private System.Windows.Forms.ColumnHeader CHHEX;
        private System.Windows.Forms.ColumnHeader CHASCII;
        private System.Windows.Forms.ColumnHeader CHBIN;
        private System.Windows.Forms.ContextMenuStrip cmsMain;
        private System.Windows.Forms.ToolStripMenuItem copyTsm;
        private System.Windows.Forms.ToolStripMenuItem decTsm;
        private System.Windows.Forms.ToolStripMenuItem hexTsm;
        private System.Windows.Forms.ToolStripMenuItem asciiTsm;
        private System.Windows.Forms.ToolStripMenuItem binTsm;
        private System.Windows.Forms.ToolStripMenuItem copyAllToolStripMenuItem;
    }
}
