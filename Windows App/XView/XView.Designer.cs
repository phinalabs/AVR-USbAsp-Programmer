namespace XView
{
    partial class XView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XView));
            this.BtnOpenArdu = new System.Windows.Forms.Button();
            this.lbltarget = new System.Windows.Forms.Label();
            this.lblsource = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.BtnTfolder = new System.Windows.Forms.Button();
            this.BtnSfolder = new System.Windows.Forms.Button();
            this.CbxAll = new System.Windows.Forms.CheckBox();
            this.CbxCpp = new System.Windows.Forms.CheckBox();
            this.CbxElf = new System.Windows.Forms.CheckBox();
            this.CbxHex = new System.Windows.Forms.CheckBox();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.TxtHexTarget = new System.Windows.Forms.TextBox();
            this.TxtHexPath = new System.Windows.Forms.TextBox();
            this.TxtHexName = new System.Windows.Forms.TextBox();
            this.btnArdProg = new System.Windows.Forms.Button();
            this.ttp = new System.Windows.Forms.ToolTip(this.components);
            this.lblBoard = new System.Windows.Forms.Label();
            this.cbxBoard = new System.Windows.Forms.ComboBox();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.opfd = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnOpenArdu
            // 
            this.BtnOpenArdu.BackColor = System.Drawing.Color.Transparent;
            this.BtnOpenArdu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOpenArdu.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOpenArdu.Location = new System.Drawing.Point(223, 398);
            this.BtnOpenArdu.Name = "BtnOpenArdu";
            this.BtnOpenArdu.Size = new System.Drawing.Size(91, 24);
            this.BtnOpenArdu.TabIndex = 31;
            this.BtnOpenArdu.Text = "Ard.&IDE";
            this.ttp.SetToolTip(this.BtnOpenArdu, "Load Arduino IDE");
            this.BtnOpenArdu.UseVisualStyleBackColor = false;
            this.BtnOpenArdu.Click += new System.EventHandler(this.BtnOpenArdu_Click);
            // 
            // lbltarget
            // 
            this.lbltarget.AutoSize = true;
            this.lbltarget.Location = new System.Drawing.Point(19, 280);
            this.lbltarget.Name = "lbltarget";
            this.lbltarget.Size = new System.Drawing.Size(70, 13);
            this.lbltarget.TabIndex = 30;
            this.lbltarget.Text = "Target Folder";
            // 
            // lblsource
            // 
            this.lblsource.AutoSize = true;
            this.lblsource.Location = new System.Drawing.Point(19, 217);
            this.lblsource.Name = "lblsource";
            this.lblsource.Size = new System.Drawing.Size(73, 13);
            this.lblsource.TabIndex = 29;
            this.lblsource.Text = "Source Folder";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(18, 160);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(91, 13);
            this.lblname.TabIndex = 28;
            this.lblname.Text = "Sketch File Name";
            // 
            // BtnTfolder
            // 
            this.BtnTfolder.BackColor = System.Drawing.Color.Transparent;
            this.BtnTfolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTfolder.Location = new System.Drawing.Point(319, 300);
            this.BtnTfolder.Name = "BtnTfolder";
            this.BtnTfolder.Size = new System.Drawing.Size(24, 27);
            this.BtnTfolder.TabIndex = 27;
            this.BtnTfolder.Text = "+";
            this.ttp.SetToolTip(this.BtnTfolder, "Open folder where the the hex filename will be saved to.");
            this.BtnTfolder.UseVisualStyleBackColor = false;
            this.BtnTfolder.Click += new System.EventHandler(this.BtnTfolder_Click);
            // 
            // BtnSfolder
            // 
            this.BtnSfolder.BackColor = System.Drawing.Color.Transparent;
            this.BtnSfolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSfolder.Location = new System.Drawing.Point(319, 237);
            this.BtnSfolder.Name = "BtnSfolder";
            this.BtnSfolder.Size = new System.Drawing.Size(24, 27);
            this.BtnSfolder.TabIndex = 26;
            this.BtnSfolder.Text = "+";
            this.ttp.SetToolTip(this.BtnSfolder, "Source folder to fetch files.");
            this.BtnSfolder.UseVisualStyleBackColor = false;
            this.BtnSfolder.Click += new System.EventHandler(this.BtnSfolder_Click);
            // 
            // CbxAll
            // 
            this.CbxAll.AutoSize = true;
            this.CbxAll.Location = new System.Drawing.Point(277, 351);
            this.CbxAll.Name = "CbxAll";
            this.CbxAll.Size = new System.Drawing.Size(37, 17);
            this.CbxAll.TabIndex = 25;
            this.CbxAll.Text = "&All";
            this.ttp.SetToolTip(this.CbxAll, "select all.");
            this.CbxAll.UseVisualStyleBackColor = true;
            this.CbxAll.CheckedChanged += new System.EventHandler(this.CbxAll_CheckedChanged);
            // 
            // CbxCpp
            // 
            this.CbxCpp.AutoSize = true;
            this.CbxCpp.Location = new System.Drawing.Point(184, 351);
            this.CbxCpp.Name = "CbxCpp";
            this.CbxCpp.Size = new System.Drawing.Size(48, 17);
            this.CbxCpp.TabIndex = 24;
            this.CbxCpp.Text = ".&Cpp";
            this.ttp.SetToolTip(this.CbxCpp, "Fetch CPP file");
            this.CbxCpp.UseVisualStyleBackColor = true;
            // 
            // CbxElf
            // 
            this.CbxElf.AutoSize = true;
            this.CbxElf.Location = new System.Drawing.Point(100, 351);
            this.CbxElf.Name = "CbxElf";
            this.CbxElf.Size = new System.Drawing.Size(41, 17);
            this.CbxElf.TabIndex = 23;
            this.CbxElf.Text = ".&Elf";
            this.ttp.SetToolTip(this.CbxElf, "fetch ELF file.");
            this.CbxElf.UseVisualStyleBackColor = true;
            // 
            // CbxHex
            // 
            this.CbxHex.AutoSize = true;
            this.CbxHex.Checked = true;
            this.CbxHex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbxHex.Location = new System.Drawing.Point(21, 351);
            this.CbxHex.Name = "CbxHex";
            this.CbxHex.Size = new System.Drawing.Size(48, 17);
            this.CbxHex.TabIndex = 22;
            this.CbxHex.Text = ".&Hex";
            this.ttp.SetToolTip(this.CbxHex, "Fetch Hex file.");
            this.CbxHex.UseVisualStyleBackColor = true;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.Location = new System.Drawing.Point(22, 398);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(95, 24);
            this.BtnUpdate.TabIndex = 21;
            this.BtnUpdate.Text = "&Save/Update";
            this.ttp.SetToolTip(this.BtnUpdate, "Fetch file(s).");
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // TxtHexTarget
            // 
            this.TxtHexTarget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtHexTarget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtHexTarget.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHexTarget.ForeColor = System.Drawing.Color.White;
            this.TxtHexTarget.Location = new System.Drawing.Point(21, 300);
            this.TxtHexTarget.MaxLength = 240;
            this.TxtHexTarget.Name = "TxtHexTarget";
            this.TxtHexTarget.Size = new System.Drawing.Size(293, 27);
            this.TxtHexTarget.TabIndex = 20;
            // 
            // TxtHexPath
            // 
            this.TxtHexPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtHexPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtHexPath.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHexPath.ForeColor = System.Drawing.Color.White;
            this.TxtHexPath.Location = new System.Drawing.Point(22, 237);
            this.TxtHexPath.MaxLength = 240;
            this.TxtHexPath.Name = "TxtHexPath";
            this.TxtHexPath.Size = new System.Drawing.Size(292, 27);
            this.TxtHexPath.TabIndex = 19;
            // 
            // TxtHexName
            // 
            this.TxtHexName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtHexName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtHexName.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHexName.ForeColor = System.Drawing.Color.White;
            this.TxtHexName.Location = new System.Drawing.Point(21, 176);
            this.TxtHexName.MaxLength = 240;
            this.TxtHexName.Name = "TxtHexName";
            this.TxtHexName.Size = new System.Drawing.Size(293, 29);
            this.TxtHexName.TabIndex = 18;
            // 
            // btnArdProg
            // 
            this.btnArdProg.BackColor = System.Drawing.Color.Transparent;
            this.btnArdProg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArdProg.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArdProg.Location = new System.Drawing.Point(126, 398);
            this.btnArdProg.Name = "btnArdProg";
            this.btnArdProg.Size = new System.Drawing.Size(91, 24);
            this.btnArdProg.TabIndex = 32;
            this.btnArdProg.Text = "&Program";
            this.ttp.SetToolTip(this.btnArdProg, "Program device.");
            this.btnArdProg.UseVisualStyleBackColor = false;
            this.btnArdProg.Click += new System.EventHandler(this.btnArdProg_Click);
            // 
            // lblBoard
            // 
            this.lblBoard.AutoSize = true;
            this.lblBoard.Location = new System.Drawing.Point(18, 60);
            this.lblBoard.Name = "lblBoard";
            this.lblBoard.Size = new System.Drawing.Size(35, 13);
            this.lblBoard.TabIndex = 33;
            this.lblBoard.Text = "Board";
            // 
            // cbxBoard
            // 
            this.cbxBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbxBoard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBoard.DropDownWidth = 10;
            this.cbxBoard.ForeColor = System.Drawing.Color.White;
            this.cbxBoard.FormattingEnabled = true;
            this.cbxBoard.Items.AddRange(new object[] {
            "Dueminalove/Uno / Nano w/ ATmega328",
            "Diecimila with / Nano w/ ATmega168",
            "Mega 2560",
            "Mega 1280"});
            this.cbxBoard.Location = new System.Drawing.Point(80, 57);
            this.cbxBoard.Name = "cbxBoard";
            this.cbxBoard.Size = new System.Drawing.Size(232, 21);
            this.cbxBoard.TabIndex = 34;
            // 
            // fbd
            // 
            this.fbd.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // opfd
            // 
            this.opfd.Filter = "Arduino|*.exe|All Files|*.*";
            this.opfd.RestoreDirectory = true;
            this.opfd.Title = "Arduino IDE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(108, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // XView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.cbxBoard);
            this.Controls.Add(this.lblBoard);
            this.Controls.Add(this.btnArdProg);
            this.Controls.Add(this.BtnOpenArdu);
            this.Controls.Add(this.lbltarget);
            this.Controls.Add(this.lblsource);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.BtnTfolder);
            this.Controls.Add(this.BtnSfolder);
            this.Controls.Add(this.CbxAll);
            this.Controls.Add(this.CbxCpp);
            this.Controls.Add(this.CbxElf);
            this.Controls.Add(this.CbxHex);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.TxtHexTarget);
            this.Controls.Add(this.TxtHexPath);
            this.Controls.Add(this.TxtHexName);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "XView";
            this.Size = new System.Drawing.Size(365, 552);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOpenArdu;
        private System.Windows.Forms.ToolTip ttp;
        private System.Windows.Forms.Label lbltarget;
        private System.Windows.Forms.Label lblsource;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Button BtnTfolder;
        private System.Windows.Forms.Button BtnSfolder;
        private System.Windows.Forms.CheckBox CbxAll;
        private System.Windows.Forms.CheckBox CbxCpp;
        private System.Windows.Forms.CheckBox CbxElf;
        private System.Windows.Forms.CheckBox CbxHex;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.TextBox TxtHexTarget;
        private System.Windows.Forms.TextBox TxtHexPath;
        private System.Windows.Forms.TextBox TxtHexName;
        private System.Windows.Forms.Button btnArdProg;
        private System.Windows.Forms.Label lblBoard;
        private System.Windows.Forms.ComboBox cbxBoard;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.OpenFileDialog opfd;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
