namespace DeviceInfo
{
    partial class DevInfo
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
            this.lblDevInfoHeader = new System.Windows.Forms.Label();
            this.lblDeviceHeader = new System.Windows.Forms.Label();
            this.lblDevice = new System.Windows.Forms.Label();
            this.linkRead = new System.Windows.Forms.LinkLabel();
            this.lblInfoHeader = new System.Windows.Forms.Label();
            this.linkAtmel = new System.Windows.Forms.LinkLabel();
            this.lblDevSpecs = new System.Windows.Forms.Label();
            this.SpecsView = new System.Windows.Forms.ListView();
            this.lblDatasheetHeader = new System.Windows.Forms.Label();
            this.linkDatasheet = new System.Windows.Forms.LinkLabel();
            this.TtpDevInfo = new System.Windows.Forms.ToolTip(this.components);
            this.linkPinConfig = new System.Windows.Forms.LinkLabel();
            this.pnSpecs = new System.Windows.Forms.Panel();
            this.pnPinConfig = new System.Windows.Forms.Panel();
            this.pbxPackage = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.lblPackage = new System.Windows.Forms.Label();
            this.pnSpecs.SuspendLayout();
            this.pnPinConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPackage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDevInfoHeader
            // 
            this.lblDevInfoHeader.AutoSize = true;
            this.lblDevInfoHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblDevInfoHeader.Location = new System.Drawing.Point(18, 34);
            this.lblDevInfoHeader.Name = "lblDevInfoHeader";
            this.lblDevInfoHeader.Size = new System.Drawing.Size(95, 13);
            this.lblDevInfoHeader.TabIndex = 0;
            this.lblDevInfoHeader.Text = "Device information";
            // 
            // lblDeviceHeader
            // 
            this.lblDeviceHeader.AutoSize = true;
            this.lblDeviceHeader.Location = new System.Drawing.Point(18, 65);
            this.lblDeviceHeader.Name = "lblDeviceHeader";
            this.lblDeviceHeader.Size = new System.Drawing.Size(44, 13);
            this.lblDeviceHeader.TabIndex = 1;
            this.lblDeviceHeader.Text = "Device:";
            // 
            // lblDevice
            // 
            this.lblDevice.AutoSize = true;
            this.lblDevice.Location = new System.Drawing.Point(87, 65);
            this.lblDevice.Name = "lblDevice";
            this.lblDevice.Size = new System.Drawing.Size(0, 13);
            this.lblDevice.TabIndex = 2;
            // 
            // linkRead
            // 
            this.linkRead.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.linkRead.AutoSize = true;
            this.linkRead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.linkRead.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.linkRead.Location = new System.Drawing.Point(145, 34);
            this.linkRead.Name = "linkRead";
            this.linkRead.Size = new System.Drawing.Size(73, 13);
            this.linkRead.TabIndex = 3;
            this.linkRead.TabStop = true;
            this.linkRead.Text = "Specifications";
            this.TtpDevInfo.SetToolTip(this.linkRead, "Read device specifications.");
            this.linkRead.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRead_LinkClicked);
            // 
            // lblInfoHeader
            // 
            this.lblInfoHeader.AutoSize = true;
            this.lblInfoHeader.ForeColor = System.Drawing.Color.White;
            this.lblInfoHeader.Location = new System.Drawing.Point(-3, 331);
            this.lblInfoHeader.Name = "lblInfoHeader";
            this.lblInfoHeader.Size = new System.Drawing.Size(64, 13);
            this.lblInfoHeader.TabIndex = 4;
            this.lblInfoHeader.Text = "information :";
            this.TtpDevInfo.SetToolTip(this.lblInfoHeader, "Device information");
            // 
            // linkAtmel
            // 
            this.linkAtmel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.linkAtmel.AutoEllipsis = true;
            this.linkAtmel.AutoSize = true;
            this.linkAtmel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.linkAtmel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.linkAtmel.Location = new System.Drawing.Point(-3, 344);
            this.linkAtmel.Name = "linkAtmel";
            this.linkAtmel.Size = new System.Drawing.Size(82, 13);
            this.linkAtmel.TabIndex = 5;
            this.linkAtmel.TabStop = true;
            this.linkAtmel.Text = "www.atmel.com";
            this.linkAtmel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAtmel_LinkClicked);
            // 
            // lblDevSpecs
            // 
            this.lblDevSpecs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDevSpecs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblDevSpecs.Location = new System.Drawing.Point(21, 92);
            this.lblDevSpecs.Name = "lblDevSpecs";
            this.lblDevSpecs.Size = new System.Drawing.Size(333, 21);
            this.lblDevSpecs.TabIndex = 6;
            this.lblDevSpecs.Text = "Specifications.";
            // 
            // SpecsView
            // 
            this.SpecsView.AllowColumnReorder = true;
            this.SpecsView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SpecsView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SpecsView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SpecsView.GridLines = true;
            this.SpecsView.HoverSelection = true;
            this.SpecsView.Location = new System.Drawing.Point(0, 0);
            this.SpecsView.Name = "SpecsView";
            this.SpecsView.Size = new System.Drawing.Size(333, 295);
            this.SpecsView.TabIndex = 7;
            this.SpecsView.UseCompatibleStateImageBehavior = false;
            this.SpecsView.View = System.Windows.Forms.View.List;
            // 
            // lblDatasheetHeader
            // 
            this.lblDatasheetHeader.AutoSize = true;
            this.lblDatasheetHeader.ForeColor = System.Drawing.Color.White;
            this.lblDatasheetHeader.Location = new System.Drawing.Point(-4, 298);
            this.lblDatasheetHeader.Name = "lblDatasheetHeader";
            this.lblDatasheetHeader.Size = new System.Drawing.Size(65, 13);
            this.lblDatasheetHeader.TabIndex = 8;
            this.lblDatasheetHeader.Text = "Datasheet  :";
            // 
            // linkDatasheet
            // 
            this.linkDatasheet.ActiveLinkColor = System.Drawing.Color.White;
            this.linkDatasheet.AutoEllipsis = true;
            this.linkDatasheet.AutoSize = true;
            this.linkDatasheet.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.linkDatasheet.Location = new System.Drawing.Point(-4, 311);
            this.linkDatasheet.Name = "linkDatasheet";
            this.linkDatasheet.Size = new System.Drawing.Size(82, 13);
            this.linkDatasheet.TabIndex = 9;
            this.linkDatasheet.TabStop = true;
            this.linkDatasheet.Text = "www.atmel.com";
            this.TtpDevInfo.SetToolTip(this.linkDatasheet, "Device datasheet");
            this.linkDatasheet.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDatasheet_LinkClicked);
            // 
            // linkPinConfig
            // 
            this.linkPinConfig.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.linkPinConfig.AutoSize = true;
            this.linkPinConfig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.linkPinConfig.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.linkPinConfig.Location = new System.Drawing.Point(267, 34);
            this.linkPinConfig.Name = "linkPinConfig";
            this.linkPinConfig.Size = new System.Drawing.Size(87, 13);
            this.linkPinConfig.TabIndex = 10;
            this.linkPinConfig.TabStop = true;
            this.linkPinConfig.Text = "Pin Configuration";
            this.TtpDevInfo.SetToolTip(this.linkPinConfig, "Read device pin configuration.\r\nFor more information on pins data please refer to" +
        " the\r\ndevice datasheet.");
            this.linkPinConfig.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPinConfig_LinkClicked);
            // 
            // pnSpecs
            // 
            this.pnSpecs.Controls.Add(this.linkDatasheet);
            this.pnSpecs.Controls.Add(this.lblDatasheetHeader);
            this.pnSpecs.Controls.Add(this.SpecsView);
            this.pnSpecs.Controls.Add(this.linkAtmel);
            this.pnSpecs.Controls.Add(this.lblInfoHeader);
            this.pnSpecs.Location = new System.Drawing.Point(21, 116);
            this.pnSpecs.Name = "pnSpecs";
            this.pnSpecs.Size = new System.Drawing.Size(333, 373);
            this.pnSpecs.TabIndex = 11;
            // 
            // pnPinConfig
            // 
            this.pnPinConfig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnPinConfig.Controls.Add(this.pbxPackage);
            this.pnPinConfig.Controls.Add(this.btnNext);
            this.pnPinConfig.Controls.Add(this.btnPrev);
            this.pnPinConfig.Controls.Add(this.lblPackage);
            this.pnPinConfig.Location = new System.Drawing.Point(21, 116);
            this.pnPinConfig.Name = "pnPinConfig";
            this.pnPinConfig.Size = new System.Drawing.Size(333, 373);
            this.pnPinConfig.TabIndex = 12;
            this.pnPinConfig.Visible = false;
            // 
            // pbxPackage
            // 
            this.pbxPackage.Location = new System.Drawing.Point(2, 25);
            this.pbxPackage.Name = "pbxPackage";
            this.pbxPackage.Size = new System.Drawing.Size(327, 343);
            this.pbxPackage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPackage.TabIndex = 3;
            this.pbxPackage.TabStop = false;
            this.pbxPackage.Click += new System.EventHandler(this.pbxPackage_Click);
            // 
            // btnNext
            // 
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(272, -1);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(28, 20);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Location = new System.Drawing.Point(32, 0);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(28, 20);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.Text = "<<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // lblPackage
            // 
            this.lblPackage.AutoSize = true;
            this.lblPackage.Location = new System.Drawing.Point(136, 0);
            this.lblPackage.Name = "lblPackage";
            this.lblPackage.Size = new System.Drawing.Size(50, 13);
            this.lblPackage.TabIndex = 0;
            this.lblPackage.Text = "Package";
            // 
            // DevInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.pnPinConfig);
            this.Controls.Add(this.pnSpecs);
            this.Controls.Add(this.linkPinConfig);
            this.Controls.Add(this.lblDevSpecs);
            this.Controls.Add(this.linkRead);
            this.Controls.Add(this.lblDevice);
            this.Controls.Add(this.lblDeviceHeader);
            this.Controls.Add(this.lblDevInfoHeader);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Name = "DevInfo";
            this.Size = new System.Drawing.Size(362, 498);
            this.pnSpecs.ResumeLayout(false);
            this.pnSpecs.PerformLayout();
            this.pnPinConfig.ResumeLayout(false);
            this.pnPinConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPackage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDevInfoHeader;
        private System.Windows.Forms.Label lblDeviceHeader;
        private System.Windows.Forms.Label lblDevice;
        private System.Windows.Forms.LinkLabel linkRead;
        private System.Windows.Forms.Label lblInfoHeader;
        private System.Windows.Forms.LinkLabel linkAtmel;
        private System.Windows.Forms.Label lblDevSpecs;
        private System.Windows.Forms.ListView SpecsView;
        private System.Windows.Forms.Label lblDatasheetHeader;
        private System.Windows.Forms.LinkLabel linkDatasheet;
        private System.Windows.Forms.ToolTip TtpDevInfo;
        private System.Windows.Forms.LinkLabel linkPinConfig;
        private System.Windows.Forms.Panel pnSpecs;
        private System.Windows.Forms.Panel pnPinConfig;
        private System.Windows.Forms.PictureBox pbxPackage;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label lblPackage;
    }
}
