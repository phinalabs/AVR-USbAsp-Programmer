namespace LibMsg
{
    partial class MsgBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MsgBox));
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.linkOk = new System.Windows.Forms.LinkLabel();
            this.linkCancel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblMessage.Location = new System.Drawing.Point(9, 32);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(261, 75);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "XSoft";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblHeader.Location = new System.Drawing.Point(12, 5);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(33, 13);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "XSoft";
            // 
            // linkOk
            // 
            this.linkOk.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.linkOk.AutoSize = true;
            this.linkOk.LinkColor = System.Drawing.Color.White;
            this.linkOk.Location = new System.Drawing.Point(12, 116);
            this.linkOk.Name = "linkOk";
            this.linkOk.Size = new System.Drawing.Size(21, 13);
            this.linkOk.TabIndex = 4;
            this.linkOk.TabStop = true;
            this.linkOk.Text = "Ok";
            this.linkOk.VisitedLinkColor = System.Drawing.Color.White;
            this.linkOk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkOk_LinkClicked);
            // 
            // linkCancel
            // 
            this.linkCancel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.linkCancel.AutoSize = true;
            this.linkCancel.LinkColor = System.Drawing.Color.White;
            this.linkCancel.Location = new System.Drawing.Point(226, 116);
            this.linkCancel.Name = "linkCancel";
            this.linkCancel.Size = new System.Drawing.Size(40, 13);
            this.linkCancel.TabIndex = 5;
            this.linkCancel.TabStop = true;
            this.linkCancel.Text = "Cancel";
            this.linkCancel.VisitedLinkColor = System.Drawing.Color.White;
            this.linkCancel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCancel_LinkClicked);
            // 
            // MsgBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(287, 142);
            this.Controls.Add(this.linkCancel);
            this.Controls.Add(this.linkOk);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblMessage);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MsgBox";
            this.Opacity = 0.8D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Message Box";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.LinkLabel linkOk;
        private System.Windows.Forms.LinkLabel linkCancel;
    }
}

