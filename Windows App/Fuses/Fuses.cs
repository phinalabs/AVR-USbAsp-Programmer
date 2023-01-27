using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Xml;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using Cmdp;
using DeviceInfo;
using LibMsg;

namespace Fuses
{
    public partial class Fuses : UserControl
    {
        public Fuses(RichTextBox rtxt)
        {
            try
            {
                InitializeComponent();
                this._displayWindow = rtxt;
                cmdProcessor = new Cmd(_displayWindow);
                deviceInfo = new DevInfo();
                msgBox = new MsgBox();
            }
            catch (Exception ex)
            {
            }
        }

        #region  variables
        private RichTextBox _displayWindow;
        private Cmd cmdProcessor;
        private DevInfo deviceInfo;
        private MsgBox msgBox;
        #endregion

        #region write fuses
        private void linkWrite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WriteFuses();
        }
        /// <summary>
        /// write device fuses bits.
        /// </summary>
        private void WriteFuses()
        {
            try
            {
                //  if (!string.IsNullOrEmpty(this.txtefuse.Text.Trim()) && !string.IsNullOrEmpty(this.txthfuse.Text.Trim()) &&
                //  !string.IsNullOrEmpty(this.txtlfuse.Text.Trim()))
                //   {
                if (!Regex.Match(this.txtefuse.Text.Trim(), @"[0-9a-fA-F][0-9a-fA-F]").Success)
                {
                    msgBox.show("Cannot verify extended fuse byte.", "Extended Fuse");
                    //return;
                }
                if (!Regex.Match(this.txthfuse.Text.Trim(), @"[0-9a-fA-F][0-9a-fA-F]").Success)
                {
                    msgBox.show("Cannot verify high fuse byte.", "High Fuse");
                    //return;
                }
                if (!Regex.Match(this.txtlfuse.Text.Trim(), @"[0-9a-fA-F][0-9a-fA-F]").Success)
                {
                    msgBox.show("Cannot verify low fuse byte.", "Low Fuse");
                    //return;
                }

                //char x = (char)(Convert.ToByte(this.txtefuse.Text, 16) & 0x07);
                //this.txtefuse.Text = Convert.ToString(x, 16).PadLeft(2, '0');

                cmdProcessor.ProgramFuses(deviceInfo.GetDevice(),
                                                                "0x" + this.txtefuse.Text.Trim().ToLower(),
                                                                "0x" + this.txthfuse.Text.Trim().ToLower(),
                                                                "0x" + this.txtlfuse.Text.Trim().ToLower()
                                                                 );
                /* }
                 else
                     cmdProcessor.ErrorMessage("Failed to write fuses.");*/
            }
            catch (Exception ex)
            {
                msgBox.show(ex.Message, "Fuses");
            }
        }

        #endregion

        #region read fuses
        private void linkRead_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cmdProcessor.ReadFuseBits(deviceInfo.GetDevice());
            ReadFuseBytes();
        }
        /// <summary>
        /// read fuse bytes.
        /// </summary>
        private void ReadFuseBytes()
        {
            try
            {
                if (File.Exists("ef.xs")) /*check extended fuse byte file.*/
                {
                    this.txtefuse.Text = File.ReadAllText("ef.xs").Substring(2).Trim();
                    if (this.txtefuse.Text.Length <= 1)
                        this.txtefuse.Text = this.txtefuse.Text.PadLeft(2, '0').Trim();
                    File.Delete("ef.xs");
                }
                if (File.Exists("hf.xs"))/*check high fuse byte file.*/
                {
                    this.txthfuse.Text = File.ReadAllText("hf.xs").Substring(2).Trim();
                    File.Delete("hf.xs");
                }
                if (File.Exists("lf.xs")) /*check low fuse byte file.*/
                {
                    this.txtlfuse.Text = File.ReadAllText("lf.xs").Substring(2).Trim();
                    File.Delete("lf.xs");
                }
            }
            catch (Exception ex)
            {
                cmdProcessor.ErrorMessage("Failed to read Lock byte.\n" + ex.Message);
            }
        }

        #endregion

        #region calculate fuses
        private void BtnFusesCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (deviceInfo.GetDevice().Equals("ATmega328P"))
                {
                    if (!(pnFusesCalc.Controls.Count > 1))
                    {
                        ATmega328p atmega328p = new ATmega328p(
                                           this.txtefuse,
                                           this.txthfuse,
                                           this.txtlfuse);
                        this.pnFusesCalc.Controls.Add(atmega328p);
                        atmega328p.Dock = DockStyle.Fill;
                        this.lblFuseWarning.Visible = false;
                    }
                }
                else
                {
                    if (pnFusesCalc.Controls.Count > 1)
                        this.pnFusesCalc.Controls.RemoveAt(1);
                    this.lblFuseWarning.Visible = true;
                    this.txtefuse.Clear(); this.txthfuse.Clear();
                    this.txtlfuse.Clear();
                }
                this.BtnFusesCalculate.Text = "Calculate device fuses" +
                        " -- " + deviceInfo.GetDevice();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
