namespace Fuses
{
    partial class Fuses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fuses));
            this.label1 = new System.Windows.Forms.Label();
            this.txtefuse = new System.Windows.Forms.TextBox();
            this.txthfuse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtlfuse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEfuseHeader = new System.Windows.Forms.Label();
            this.lblHfuseHeader = new System.Windows.Forms.Label();
            this.lblLfuseHeader = new System.Windows.Forms.Label();
            this.linkWrite = new System.Windows.Forms.LinkLabel();
            this.linkRead = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ttpFuses = new System.Windows.Forms.ToolTip(this.components);
            this.ttp = new System.Windows.Forms.ToolTip(this.components);
            this.BtnFusesCalculate = new System.Windows.Forms.Button();
            this.pnFusesCalc = new System.Windows.Forms.Panel();
            this.lblFuseWarning = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnFusesCalc.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(124, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "0x";
            // 
            // txtefuse
            // 
            this.txtefuse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtefuse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtefuse.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtefuse.ForeColor = System.Drawing.Color.White;
            this.txtefuse.Location = new System.Drawing.Point(146, 3);
            this.txtefuse.MaxLength = 2;
            this.txtefuse.Name = "txtefuse";
            this.txtefuse.Size = new System.Drawing.Size(31, 20);
            this.txtefuse.TabIndex = 2;
            this.ttpFuses.SetToolTip(this.txtefuse, "Extended fuse byte.");
            // 
            // txthfuse
            // 
            this.txthfuse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txthfuse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txthfuse.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txthfuse.ForeColor = System.Drawing.Color.White;
            this.txthfuse.Location = new System.Drawing.Point(146, 36);
            this.txthfuse.MaxLength = 2;
            this.txthfuse.Name = "txthfuse";
            this.txthfuse.Size = new System.Drawing.Size(31, 20);
            this.txthfuse.TabIndex = 4;
            this.ttpFuses.SetToolTip(this.txthfuse, "High fuse byte.");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(124, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "0x";
            // 
            // txtlfuse
            // 
            this.txtlfuse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtlfuse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtlfuse.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtlfuse.ForeColor = System.Drawing.Color.White;
            this.txtlfuse.Location = new System.Drawing.Point(146, 66);
            this.txtlfuse.MaxLength = 2;
            this.txtlfuse.Name = "txtlfuse";
            this.txtlfuse.Size = new System.Drawing.Size(31, 20);
            this.txtlfuse.TabIndex = 6;
            this.ttpFuses.SetToolTip(this.txtlfuse, "Low fuse byte.");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(124, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "0x";
            // 
            // lblEfuseHeader
            // 
            this.lblEfuseHeader.AutoSize = true;
            this.lblEfuseHeader.ForeColor = System.Drawing.Color.White;
            this.lblEfuseHeader.Location = new System.Drawing.Point(35, 5);
            this.lblEfuseHeader.Name = "lblEfuseHeader";
            this.lblEfuseHeader.Size = new System.Drawing.Size(75, 13);
            this.lblEfuseHeader.TabIndex = 7;
            this.lblEfuseHeader.Text = "Extended fuse";
            // 
            // lblHfuseHeader
            // 
            this.lblHfuseHeader.AutoSize = true;
            this.lblHfuseHeader.ForeColor = System.Drawing.Color.White;
            this.lblHfuseHeader.Location = new System.Drawing.Point(35, 38);
            this.lblHfuseHeader.Name = "lblHfuseHeader";
            this.lblHfuseHeader.Size = new System.Drawing.Size(52, 13);
            this.lblHfuseHeader.TabIndex = 8;
            this.lblHfuseHeader.Text = "High fuse";
            // 
            // lblLfuseHeader
            // 
            this.lblLfuseHeader.AutoSize = true;
            this.lblLfuseHeader.ForeColor = System.Drawing.Color.White;
            this.lblLfuseHeader.Location = new System.Drawing.Point(35, 68);
            this.lblLfuseHeader.Name = "lblLfuseHeader";
            this.lblLfuseHeader.Size = new System.Drawing.Size(50, 13);
            this.lblLfuseHeader.TabIndex = 9;
            this.lblLfuseHeader.Text = "Low fuse";
            // 
            // linkWrite
            // 
            this.linkWrite.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.linkWrite.AutoSize = true;
            this.linkWrite.ForeColor = System.Drawing.Color.White;
            this.linkWrite.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.linkWrite.Location = new System.Drawing.Point(220, 7);
            this.linkWrite.Name = "linkWrite";
            this.linkWrite.Size = new System.Drawing.Size(32, 13);
            this.linkWrite.TabIndex = 10;
            this.linkWrite.TabStop = true;
            this.linkWrite.Text = "Write";
            this.linkWrite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkWrite_LinkClicked);
            // 
            // linkRead
            // 
            this.linkRead.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.linkRead.AutoSize = true;
            this.linkRead.ForeColor = System.Drawing.Color.White;
            this.linkRead.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.linkRead.Location = new System.Drawing.Point(220, 38);
            this.linkRead.Name = "linkRead";
            this.linkRead.Size = new System.Drawing.Size(33, 13);
            this.linkRead.TabIndex = 11;
            this.linkRead.TabStop = true;
            this.linkRead.Text = "Read";
            this.linkRead.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRead_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.txthfuse);
            this.panel1.Controls.Add(this.linkRead);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.linkWrite);
            this.panel1.Controls.Add(this.txtefuse);
            this.panel1.Controls.Add(this.lblLfuseHeader);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblHfuseHeader);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblEfuseHeader);
            this.panel1.Controls.Add(this.txtlfuse);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(3, 385);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 94);
            this.panel1.TabIndex = 12;
            // 
            // ttpFuses
            // 
            this.ttpFuses.ForeColor = System.Drawing.Color.White;
            // 
            // BtnFusesCalculate
            // 
            this.BtnFusesCalculate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnFusesCalculate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnFusesCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFusesCalculate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnFusesCalculate.Location = new System.Drawing.Point(3, 4);
            this.BtnFusesCalculate.Name = "BtnFusesCalculate";
            this.BtnFusesCalculate.Size = new System.Drawing.Size(324, 26);
            this.BtnFusesCalculate.TabIndex = 17;
            this.BtnFusesCalculate.Text = "Calculate Devices Fuses";
            this.ttp.SetToolTip(this.BtnFusesCalculate, "Calculate device fuses");
            this.BtnFusesCalculate.UseVisualStyleBackColor = true;
            this.BtnFusesCalculate.Click += new System.EventHandler(this.BtnFusesCalculate_Click);
            // 
            // pnFusesCalc
            // 
            this.pnFusesCalc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnFusesCalc.Controls.Add(this.lblFuseWarning);
            this.pnFusesCalc.Location = new System.Drawing.Point(3, 36);
            this.pnFusesCalc.Name = "pnFusesCalc";
            this.pnFusesCalc.Size = new System.Drawing.Size(324, 343);
            this.pnFusesCalc.TabIndex = 16;
            // 
            // lblFuseWarning
            // 
            this.lblFuseWarning.AutoSize = true;
            this.lblFuseWarning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblFuseWarning.Location = new System.Drawing.Point(3, 133);
            this.lblFuseWarning.Name = "lblFuseWarning";
            this.lblFuseWarning.Size = new System.Drawing.Size(312, 91);
            this.lblFuseWarning.TabIndex = 0;
            this.lblFuseWarning.Text = resources.GetString("lblFuseWarning.Text");
            this.lblFuseWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Fuses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.BtnFusesCalculate);
            this.Controls.Add(this.pnFusesCalc);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Name = "Fuses";
            this.Size = new System.Drawing.Size(332, 498);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnFusesCalc.ResumeLayout(false);
            this.pnFusesCalc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtefuse;
        private System.Windows.Forms.TextBox txthfuse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtlfuse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEfuseHeader;
        private System.Windows.Forms.Label lblHfuseHeader;
        private System.Windows.Forms.Label lblLfuseHeader;
        private System.Windows.Forms.LinkLabel linkWrite;
        private System.Windows.Forms.LinkLabel linkRead;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip ttpFuses;
        private System.Windows.Forms.ToolTip ttp;
        private System.Windows.Forms.Panel pnFusesCalc;
        private System.Windows.Forms.Button BtnFusesCalculate;
        private System.Windows.Forms.Label lblFuseWarning;
    }
}
