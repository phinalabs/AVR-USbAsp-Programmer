namespace LockBits
{
    partial class LockBits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LockBits));
            this.linkRead = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.linkWrite = new System.Windows.Forms.LinkLabel();
            this.txtlBits = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sFd = new System.Windows.Forms.SaveFileDialog();
            this.pnLockBits = new System.Windows.Forms.Panel();
            this.lblWarning = new System.Windows.Forms.Label();
            this.btnCalcLocks = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnLockBits.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkRead
            // 
            this.linkRead.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.linkRead.AutoSize = true;
            this.linkRead.ForeColor = System.Drawing.Color.White;
            this.linkRead.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.linkRead.Location = new System.Drawing.Point(174, 45);
            this.linkRead.Name = "linkRead";
            this.linkRead.Size = new System.Drawing.Size(33, 13);
            this.linkRead.TabIndex = 20;
            this.linkRead.TabStop = true;
            this.linkRead.Text = "Read";
            this.linkRead.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRead_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "0x";
            // 
            // linkWrite
            // 
            this.linkWrite.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.linkWrite.AutoSize = true;
            this.linkWrite.ForeColor = System.Drawing.Color.White;
            this.linkWrite.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.linkWrite.Location = new System.Drawing.Point(174, 15);
            this.linkWrite.Name = "linkWrite";
            this.linkWrite.Size = new System.Drawing.Size(32, 13);
            this.linkWrite.TabIndex = 19;
            this.linkWrite.TabStop = true;
            this.linkWrite.Text = "Write";
            this.linkWrite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkWrite_LinkClicked);
            // 
            // txtlBits
            // 
            this.txtlBits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtlBits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtlBits.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtlBits.ForeColor = System.Drawing.Color.White;
            this.txtlBits.Location = new System.Drawing.Point(103, 27);
            this.txtlBits.MaxLength = 2;
            this.txtlBits.Name = "txtlBits";
            this.txtlBits.Size = new System.Drawing.Size(31, 20);
            this.txtlBits.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(26, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "lock byte";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.linkRead);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtlBits);
            this.panel1.Controls.Add(this.linkWrite);
            this.panel1.Location = new System.Drawing.Point(3, 386);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 75);
            this.panel1.TabIndex = 21;
            // 
            // sFd
            // 
            this.sFd.DefaultExt = "xs";
            this.sFd.Filter = "xsoft files|*.xs";
            this.sFd.RestoreDirectory = true;
            // 
            // pnLockBits
            // 
            this.pnLockBits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnLockBits.Controls.Add(this.lblWarning);
            this.pnLockBits.Location = new System.Drawing.Point(3, 37);
            this.pnLockBits.Name = "pnLockBits";
            this.pnLockBits.Size = new System.Drawing.Size(302, 332);
            this.pnLockBits.TabIndex = 22;
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblWarning.Location = new System.Drawing.Point(45, 139);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(191, 52);
            this.lblWarning.TabIndex = 0;
            this.lblWarning.Text = "Calculate device lockbits \r\nOnly ATmega328P is Activated\r\nNote: Lockbits calculat" +
    "or in Beta Mode\r\nuse it at your own risk";
            this.lblWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalcLocks
            // 
            this.btnCalcLocks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCalcLocks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnCalcLocks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCalcLocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcLocks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCalcLocks.Location = new System.Drawing.Point(3, 5);
            this.btnCalcLocks.Name = "btnCalcLocks";
            this.btnCalcLocks.Size = new System.Drawing.Size(302, 26);
            this.btnCalcLocks.TabIndex = 23;
            this.btnCalcLocks.Text = "Calculate LockBits";
            this.btnCalcLocks.UseVisualStyleBackColor = false;
            this.btnCalcLocks.Click += new System.EventHandler(this.btnCalcLocks_Click);
            // 
            // LockBits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.btnCalcLocks);
            this.Controls.Add(this.pnLockBits);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Name = "LockBits";
            this.Size = new System.Drawing.Size(321, 498);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnLockBits.ResumeLayout(false);
            this.pnLockBits.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkRead;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkWrite;
        private System.Windows.Forms.TextBox txtlBits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SaveFileDialog sFd;
        private System.Windows.Forms.Panel pnLockBits;
        private System.Windows.Forms.Button btnCalcLocks;
        private System.Windows.Forms.Label lblWarning;
    }
}
