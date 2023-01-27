namespace LockBits
{
    partial class ATmega328P
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLock1 = new System.Windows.Forms.Label();
            this.lblLock2 = new System.Windows.Forms.Label();
            this.lblLock3 = new System.Windows.Forms.Label();
            this.cbbLock1 = new System.Windows.Forms.ComboBox();
            this.cbbLock2 = new System.Windows.Forms.ComboBox();
            this.cbbLock3 = new System.Windows.Forms.ComboBox();
            this.ttp = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lock Bit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(97, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Value";
            // 
            // lblLock1
            // 
            this.lblLock1.AutoSize = true;
            this.lblLock1.Location = new System.Drawing.Point(19, 60);
            this.lblLock1.Name = "lblLock1";
            this.lblLock1.Size = new System.Drawing.Size(33, 13);
            this.lblLock1.TabIndex = 2;
            this.lblLock1.Text = "lock1";
            // 
            // lblLock2
            // 
            this.lblLock2.AutoSize = true;
            this.lblLock2.Location = new System.Drawing.Point(19, 108);
            this.lblLock2.Name = "lblLock2";
            this.lblLock2.Size = new System.Drawing.Size(33, 13);
            this.lblLock2.TabIndex = 3;
            this.lblLock2.Text = "lock2";
            // 
            // lblLock3
            // 
            this.lblLock3.AutoSize = true;
            this.lblLock3.Location = new System.Drawing.Point(19, 156);
            this.lblLock3.Name = "lblLock3";
            this.lblLock3.Size = new System.Drawing.Size(33, 13);
            this.lblLock3.TabIndex = 4;
            this.lblLock3.Text = "lock3";
            // 
            // cbbLock1
            // 
            this.cbbLock1.BackColor = System.Drawing.Color.Gray;
            this.cbbLock1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLock1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbbLock1.FormattingEnabled = true;
            this.cbbLock1.Location = new System.Drawing.Point(100, 57);
            this.cbbLock1.Name = "cbbLock1";
            this.cbbLock1.Size = new System.Drawing.Size(158, 21);
            this.cbbLock1.TabIndex = 5;
            // 
            // cbbLock2
            // 
            this.cbbLock2.BackColor = System.Drawing.Color.Gray;
            this.cbbLock2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLock2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbbLock2.FormattingEnabled = true;
            this.cbbLock2.Location = new System.Drawing.Point(100, 105);
            this.cbbLock2.Name = "cbbLock2";
            this.cbbLock2.Size = new System.Drawing.Size(158, 21);
            this.cbbLock2.TabIndex = 6;
            // 
            // cbbLock3
            // 
            this.cbbLock3.BackColor = System.Drawing.Color.Gray;
            this.cbbLock3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLock3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbbLock3.FormattingEnabled = true;
            this.cbbLock3.Location = new System.Drawing.Point(100, 153);
            this.cbbLock3.Name = "cbbLock3";
            this.cbbLock3.Size = new System.Drawing.Size(158, 21);
            this.cbbLock3.TabIndex = 7;
            // 
            // ATmega328P
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.cbbLock3);
            this.Controls.Add(this.cbbLock2);
            this.Controls.Add(this.cbbLock1);
            this.Controls.Add(this.lblLock3);
            this.Controls.Add(this.lblLock2);
            this.Controls.Add(this.lblLock1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Name = "ATmega328P";
            this.Size = new System.Drawing.Size(282, 328);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLock1;
        private System.Windows.Forms.Label lblLock2;
        private System.Windows.Forms.Label lblLock3;
        private System.Windows.Forms.ComboBox cbbLock1;
        private System.Windows.Forms.ComboBox cbbLock2;
        private System.Windows.Forms.ComboBox cbbLock3;
        private System.Windows.Forms.ToolTip ttp;
    }
}
