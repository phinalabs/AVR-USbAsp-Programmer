using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Cmdp;
using DeviceInfo;

namespace Memory
{
    public partial class Memory : UserControl
    {
        public Memory(RichTextBox rtxt = null)
        {
            InitializeComponent();
            ShowTooltips();
            this._displayWindow = rtxt;
            cmdProcessor = new Cmd(_displayWindow);
            deviceInfo = new DevInfo();
            events();
        }

        #region  variables
        private RichTextBox _displayWindow;
        Cmd cmdProcessor;
        DevInfo deviceInfo;
        #endregion

        #region tooltips
        private void ShowTooltips()
        {
            this.ttpMem.SetToolTip(this.txtFlashFile, this.txtFlashFile.Text);
            this.ttpMem.SetToolTip(this.txtEepFile, this.txtEepFile.Text);
        }
        #endregion

        #region open files
        private void btnFlashFile_Click(object sender, EventArgs e)
        {
            try
            {
                ofd.Filter = "Hex |*.hex";
                ofd.Title = "Open hex file";
                ofd.ShowDialog();
                this.txtFlashFile.Text = ofd.FileName;
                cmdProcessor.HexFile = ofd.FileName;
                ofd.FileName = "";
            }
            catch (Exception ex)
            {
            }
        }

        private void BtnEepFile_Click(object sender, EventArgs e)
        {
            try
            {
                ofd.Filter = "eep|*.eep";
                ofd.Title = "Open eeprom file";
                ofd.ShowDialog();
                this.txtEepFile.Text = ofd.FileName;
                cmdProcessor.EepFile = ofd.FileName;
                ofd.FileName = "";
            }
            catch (Exception ex) { }
        }

        private void linkWriteFlash_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtFlashFile.Text.Trim()))
                cmdProcessor.WriteMemory(deviceInfo.GetDevice(), "flash", cmdProcessor.HexFile);
            else
                cmdProcessor.ErrorMessage("Hex file not found");
        }
        /// <summary>
        /// erase device
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkErase_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                cmdProcessor.EraseDevice(deviceInfo.GetDevice());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// write eeprom
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkWriteEep_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtEepFile.Text.Trim()))
                cmdProcessor.WriteMemory(deviceInfo.GetDevice(), "eeprom", cmdProcessor.EepFile);
            else
                cmdProcessor.ErrorMessage("eep file not found");
        }
        /// <summary>
        /// read flash memory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkReadFlash_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                sfd.Filter = "hex|*.hex";
                sfd.Title = "Save Flash File";
                sfd.ShowDialog();
                if (!string.IsNullOrEmpty(sfd.FileName))
                    cmdProcessor.ReadMemory(deviceInfo.GetDevice(), "flash", sfd.FileName);
                else
                    cmdProcessor.ErrorMessage("Could not read flash memory");
                sfd.FileName = "";
            }
            catch (Exception ex)
            {
                cmdProcessor.ErrorMessage(ex.Message);
            }
        }
        /// <summary>
        /// read eeprom
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkReadEep_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                sfd.Filter = "eep|*.eep";
                sfd.Title = "Save Eeeprom File";
                sfd.ShowDialog();
                if (!string.IsNullOrEmpty(sfd.FileName))
                    cmdProcessor.ReadMemory(deviceInfo.GetDevice(), "eeprom", sfd.FileName);
                else
                    cmdProcessor.ErrorMessage("Could not read eeprom memory");
                sfd.FileName = "";
            }
            catch (Exception ex)
            {
                cmdProcessor.ErrorMessage(ex.Message);
            }
        }
        /// <summary>
        /// verify flash contents
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkVerifyFlash_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ofd.Filter = "Hex |*.hex";
            ofd.Title = "Open hex file";
            ofd.ShowDialog();
            if (!string.IsNullOrEmpty(this.ofd.FileName))
                cmdProcessor.VerifyMemory(deviceInfo.GetDevice(), "flash", ofd.FileName);
            else
                cmdProcessor.ErrorMessage("could not verify flash contents.");
            ofd.FileName = string.Empty;
        }
        /// <summary>
        /// verify flash contents
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkVerifyEep_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ofd.Filter = "Eep |*.eep";
            ofd.Title = "Open Eeprom file";
            ofd.ShowDialog();
            if (!string.IsNullOrEmpty(this.ofd.FileName))
                cmdProcessor.VerifyMemory(deviceInfo.GetDevice(), "eeprom", ofd.FileName);
            else
                cmdProcessor.ErrorMessage("could not verify eeprom contents.");
            ofd.FileName = string.Empty;
        }
        #endregion

        #region tooltips
        private void txtHex_MouseEnter(object sender, EventArgs e)
        {
            this.ttpMem.Show(this.txtFlashFile.Text, this.txtFlashFile);
        }

        private void txtEeprom_MouseEnter(object sender, EventArgs e)
        {
            this.ttpMem.Show(this.txtEepFile.Text, this.txtEepFile);
        }

        private void events()
        {
            this.txtFlashFile.MouseHover += new EventHandler(txtHex_MouseEnter);
            this.txtEepFile.MouseHover += new EventHandler(txtEeprom_MouseEnter);
        }
        #endregion
    }
}
