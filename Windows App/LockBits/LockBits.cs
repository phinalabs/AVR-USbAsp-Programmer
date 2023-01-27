using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using Cmdp;
using DeviceInfo;
using LibMsg;

namespace LockBits
{
    public partial class LockBits : UserControl
    {
        public LockBits(RichTextBox rtxt = null)
        {
            InitializeComponent();
            try
            {
                this._displayWindow = rtxt;
                cmdProcessor = new Cmd(_displayWindow);
                deviceInfo = new DevInfo();
                msgWindow = new MsgBox();
            }
            catch (Exception ex) { }
        }

        #region  variables
            private RichTextBox _displayWindow;
            Cmd cmdProcessor;
            DevInfo deviceInfo;
            MsgBox msgWindow;
       #endregion

        #region write lock byte
        private void linkWrite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!Regex.Match(this.txtlBits.Text.Trim(), @"[0-9a-fA-F][0-9a-fA-F]").Success)
            {
                msgWindow.show("Cannot verify lock byte.", "Lock Byte");
                return;
            }
            if(this.txtlBits.Text.Length >= 2)
                cmdProcessor.ProgramLockBits(deviceInfo.GetDevice(), "0x" + this.txtlBits.Text.Trim());
            else
                cmdProcessor.ErrorMessage("Lock bits not specified.");
        }
        #endregion

        #region read lock byte
        private void linkRead_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //cmdProcessor.ErrorMessage("Failed to read lock bits. Check for new software version.");
            cmdProcessor.ReadLockBits(deviceInfo.GetDevice());
            ReadLockByte();
        }
        /// <summary>
        /// Read lock byte
        /// </summary>
        private void ReadLockByte()
        {
            try
            {
                if (File.Exists("lb.xs"))
                {
                    this.txtlBits.Text = File.ReadAllText("lb.xs").Substring(2).Trim();
                    File.Delete("lb.xs");
                }
            }
            catch (Exception ex)
            {
                cmdProcessor.ErrorMessage("Failed to read Lock byte.\n" + ex.Message);
            }
        }
        #endregion

        private void btnCalcLocks_Click(object sender, EventArgs e)
        {
            try
            {
                if (deviceInfo.GetDevice().Equals("ATmega328P"))
                {
                    if (!(this.pnLockBits.Controls.Count > 1))
                    {
                        ATmega328P atmega328p = new ATmega328P(
                                           this.txtlBits);
                        this.pnLockBits.Controls.Add(atmega328p);
                        atmega328p.Dock = DockStyle.Fill;
                        this.lblWarning.Visible = false;
                    }
                }
                else
                {
                    if (this.pnLockBits.Controls.Count > 1)
                        this.pnLockBits.Controls.RemoveAt(1);
                    this.lblWarning.Visible = true;
                    this.txtlBits.Clear(); this.txtlBits.Clear();
                    this.txtlBits.Clear();
                }
                this.btnCalcLocks.Text = "Calculate device LockBits" +
                        " -- " + deviceInfo.GetDevice();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
