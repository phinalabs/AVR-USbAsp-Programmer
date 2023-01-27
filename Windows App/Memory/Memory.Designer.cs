namespace Memory
{
    partial class Memory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Memory));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkErase = new System.Windows.Forms.LinkLabel();
            this.linkWriteFlash = new System.Windows.Forms.LinkLabel();
            this.linkReadFlash = new System.Windows.Forms.LinkLabel();
            this.linkVerifyFlash = new System.Windows.Forms.LinkLabel();
            this.ttpMem = new System.Windows.Forms.ToolTip(this.components);
            this.btnFlashFile = new System.Windows.Forms.Button();
            this.BtnEepFile = new System.Windows.Forms.Button();
            this.linkVerifyEep = new System.Windows.Forms.LinkLabel();
            this.linkReadEep = new System.Windows.Forms.LinkLabel();
            this.linkWriteEep = new System.Windows.Forms.LinkLabel();
            this.txtFlashFile = new System.Windows.Forms.TextBox();
            this.lblFlashHeader = new System.Windows.Forms.Label();
            this.lblEepHeader = new System.Windows.Forms.Label();
            this.txtEepFile = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // linkErase
            // 
            this.linkErase.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.linkErase.AutoSize = true;
            this.linkErase.BackColor = System.Drawing.Color.Transparent;
            this.linkErase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkErase.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.linkErase.Location = new System.Drawing.Point(236, 458);
            this.linkErase.Name = "linkErase";
            this.linkErase.Size = new System.Drawing.Size(103, 20);
            this.linkErase.TabIndex = 2;
            this.linkErase.TabStop = true;
            this.linkErase.Text = "Erase Device";
            this.ttpMem.SetToolTip(this.linkErase, "Erase contents of the flash memory.");
            this.linkErase.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkErase_LinkClicked);
            // 
            // linkWriteFlash
            // 
            this.linkWriteFlash.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.linkWriteFlash.AutoSize = true;
            this.linkWriteFlash.BackColor = System.Drawing.Color.Transparent;
            this.linkWriteFlash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkWriteFlash.ForeColor = System.Drawing.Color.White;
            this.linkWriteFlash.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.linkWriteFlash.Location = new System.Drawing.Point(34, 172);
            this.linkWriteFlash.Name = "linkWriteFlash";
            this.linkWriteFlash.Size = new System.Drawing.Size(46, 20);
            this.linkWriteFlash.TabIndex = 3;
            this.linkWriteFlash.TabStop = true;
            this.linkWriteFlash.Text = "Write";
            this.ttpMem.SetToolTip(this.linkWriteFlash, "Write to flash memory.");
            this.linkWriteFlash.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkWriteFlash_LinkClicked);
            // 
            // linkReadFlash
            // 
            this.linkReadFlash.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.linkReadFlash.AutoSize = true;
            this.linkReadFlash.BackColor = System.Drawing.Color.Transparent;
            this.linkReadFlash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkReadFlash.ForeColor = System.Drawing.Color.White;
            this.linkReadFlash.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.linkReadFlash.Location = new System.Drawing.Point(141, 172);
            this.linkReadFlash.Name = "linkReadFlash";
            this.linkReadFlash.Size = new System.Drawing.Size(48, 20);
            this.linkReadFlash.TabIndex = 4;
            this.linkReadFlash.TabStop = true;
            this.linkReadFlash.Text = "Read";
            this.ttpMem.SetToolTip(this.linkReadFlash, "Read flash memory contents.");
            this.linkReadFlash.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkReadFlash_LinkClicked);
            // 
            // linkVerifyFlash
            // 
            this.linkVerifyFlash.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.linkVerifyFlash.AutoSize = true;
            this.linkVerifyFlash.BackColor = System.Drawing.Color.Transparent;
            this.linkVerifyFlash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkVerifyFlash.ForeColor = System.Drawing.Color.White;
            this.linkVerifyFlash.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.linkVerifyFlash.Location = new System.Drawing.Point(238, 172);
            this.linkVerifyFlash.Name = "linkVerifyFlash";
            this.linkVerifyFlash.Size = new System.Drawing.Size(49, 20);
            this.linkVerifyFlash.TabIndex = 5;
            this.linkVerifyFlash.TabStop = true;
            this.linkVerifyFlash.Text = "Verify";
            this.ttpMem.SetToolTip(this.linkVerifyFlash, "Verify flash contents.");
            this.linkVerifyFlash.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkVerifyFlash_LinkClicked);
            // 
            // btnFlashFile
            // 
            this.btnFlashFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlashFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlashFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFlashFile.Location = new System.Drawing.Point(293, 140);
            this.btnFlashFile.Name = "btnFlashFile";
            this.btnFlashFile.Size = new System.Drawing.Size(24, 26);
            this.btnFlashFile.TabIndex = 7;
            this.btnFlashFile.Text = "+";
            this.ttpMem.SetToolTip(this.btnFlashFile, "load .hex file");
            this.btnFlashFile.UseVisualStyleBackColor = true;
            this.btnFlashFile.Click += new System.EventHandler(this.btnFlashFile_Click);
            // 
            // BtnEepFile
            // 
            this.BtnEepFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEepFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEepFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnEepFile.Location = new System.Drawing.Point(293, 303);
            this.BtnEepFile.Name = "BtnEepFile";
            this.BtnEepFile.Size = new System.Drawing.Size(24, 26);
            this.BtnEepFile.TabIndex = 14;
            this.BtnEepFile.Text = "+";
            this.ttpMem.SetToolTip(this.BtnEepFile, "load .eep file ");
            this.BtnEepFile.UseVisualStyleBackColor = true;
            this.BtnEepFile.Click += new System.EventHandler(this.BtnEepFile_Click);
            // 
            // linkVerifyEep
            // 
            this.linkVerifyEep.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.linkVerifyEep.AutoSize = true;
            this.linkVerifyEep.BackColor = System.Drawing.Color.Transparent;
            this.linkVerifyEep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkVerifyEep.ForeColor = System.Drawing.Color.White;
            this.linkVerifyEep.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.linkVerifyEep.Location = new System.Drawing.Point(238, 335);
            this.linkVerifyEep.Name = "linkVerifyEep";
            this.linkVerifyEep.Size = new System.Drawing.Size(49, 20);
            this.linkVerifyEep.TabIndex = 12;
            this.linkVerifyEep.TabStop = true;
            this.linkVerifyEep.Text = "Verify";
            this.ttpMem.SetToolTip(this.linkVerifyEep, "Verify eeprom contents.");
            this.linkVerifyEep.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkVerifyEep_LinkClicked);
            // 
            // linkReadEep
            // 
            this.linkReadEep.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.linkReadEep.AutoSize = true;
            this.linkReadEep.BackColor = System.Drawing.Color.Transparent;
            this.linkReadEep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkReadEep.ForeColor = System.Drawing.Color.White;
            this.linkReadEep.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.linkReadEep.Location = new System.Drawing.Point(141, 335);
            this.linkReadEep.Name = "linkReadEep";
            this.linkReadEep.Size = new System.Drawing.Size(48, 20);
            this.linkReadEep.TabIndex = 11;
            this.linkReadEep.TabStop = true;
            this.linkReadEep.Text = "Read";
            this.ttpMem.SetToolTip(this.linkReadEep, "Read eeprom memory contents.");
            this.linkReadEep.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkReadEep_LinkClicked);
            // 
            // linkWriteEep
            // 
            this.linkWriteEep.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.linkWriteEep.AutoSize = true;
            this.linkWriteEep.BackColor = System.Drawing.Color.Transparent;
            this.linkWriteEep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkWriteEep.ForeColor = System.Drawing.Color.White;
            this.linkWriteEep.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.linkWriteEep.Location = new System.Drawing.Point(34, 335);
            this.linkWriteEep.Name = "linkWriteEep";
            this.linkWriteEep.Size = new System.Drawing.Size(46, 20);
            this.linkWriteEep.TabIndex = 10;
            this.linkWriteEep.TabStop = true;
            this.linkWriteEep.Text = "Write";
            this.ttpMem.SetToolTip(this.linkWriteEep, "Write to eeprom memory.");
            this.linkWriteEep.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkWriteEep_LinkClicked);
            // 
            // txtFlashFile
            // 
            this.txtFlashFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFlashFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFlashFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFlashFile.ForeColor = System.Drawing.Color.White;
            this.txtFlashFile.Location = new System.Drawing.Point(37, 140);
            this.txtFlashFile.Name = "txtFlashFile";
            this.txtFlashFile.Size = new System.Drawing.Size(250, 26);
            this.txtFlashFile.TabIndex = 6;
            // 
            // lblFlashHeader
            // 
            this.lblFlashHeader.AutoSize = true;
            this.lblFlashHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblFlashHeader.Location = new System.Drawing.Point(57, 103);
            this.lblFlashHeader.Name = "lblFlashHeader";
            this.lblFlashHeader.Size = new System.Drawing.Size(72, 13);
            this.lblFlashHeader.TabIndex = 8;
            this.lblFlashHeader.Text = "Flash Memory";
            // 
            // lblEepHeader
            // 
            this.lblEepHeader.AutoSize = true;
            this.lblEepHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblEepHeader.Location = new System.Drawing.Point(57, 268);
            this.lblEepHeader.Name = "lblEepHeader";
            this.lblEepHeader.Size = new System.Drawing.Size(83, 13);
            this.lblEepHeader.TabIndex = 15;
            this.lblEepHeader.Text = "Eeprom Memory";
            // 
            // txtEepFile
            // 
            this.txtEepFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEepFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEepFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEepFile.ForeColor = System.Drawing.Color.White;
            this.txtEepFile.Location = new System.Drawing.Point(37, 303);
            this.txtEepFile.Name = "txtEepFile";
            this.txtEepFile.Size = new System.Drawing.Size(250, 26);
            this.txtEepFile.TabIndex = 13;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(19, 276);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(313, 94);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblHeader.Location = new System.Drawing.Point(16, 23);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(167, 13);
            this.lblHeader.TabIndex = 16;
            this.lblHeader.Text = "Flash/Eeprom memory operations.";
            // 
            // ofd
            // 
            this.ofd.RestoreDirectory = true;
            // 
            // sfd
            // 
            this.sfd.RestoreDirectory = true;
            // 
            // Memory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblEepHeader);
            this.Controls.Add(this.BtnEepFile);
            this.Controls.Add(this.txtEepFile);
            this.Controls.Add(this.linkVerifyEep);
            this.Controls.Add(this.linkReadEep);
            this.Controls.Add(this.linkWriteEep);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblFlashHeader);
            this.Controls.Add(this.btnFlashFile);
            this.Controls.Add(this.txtFlashFile);
            this.Controls.Add(this.linkVerifyFlash);
            this.Controls.Add(this.linkReadFlash);
            this.Controls.Add(this.linkWriteFlash);
            this.Controls.Add(this.linkErase);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Memory";
            this.Size = new System.Drawing.Size(342, 498);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkErase;
        private System.Windows.Forms.LinkLabel linkWriteFlash;
        private System.Windows.Forms.LinkLabel linkReadFlash;
        private System.Windows.Forms.LinkLabel linkVerifyFlash;
        private System.Windows.Forms.ToolTip ttpMem;
        private System.Windows.Forms.TextBox txtFlashFile;
        private System.Windows.Forms.Button btnFlashFile;
        private System.Windows.Forms.Label lblFlashHeader;
        private System.Windows.Forms.Label lblEepHeader;
        private System.Windows.Forms.Button BtnEepFile;
        private System.Windows.Forms.TextBox txtEepFile;
        private System.Windows.Forms.LinkLabel linkVerifyEep;
        private System.Windows.Forms.LinkLabel linkReadEep;
        private System.Windows.Forms.LinkLabel linkWriteEep;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.SaveFileDialog sfd;
    }
}
