using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PCComm;

namespace Terminal
{
    public partial class Terminal : UserControl
    {
        CommunicationManager comm = new CommunicationManager();
        string transType = string.Empty;

        public Terminal()
        {
            InitializeComponent();
            InitializeSerial();
        }

        #region vars
        Boolean serSettings;
        #endregion

        #region serial settings
        private void btnSettings_Click(object sender, EventArgs e)
        {
            serSettings = false;
            if (this.btnSettings.Text.Equals("+"))
            {
                this.btnSettings.Text = "-";
                this.pnSettings.Visible = true;
                serSettings = false;
                //this.pnDisplayWindow.Enabled = false;
            }
            else
            {
                this.btnSettings.Text = "+";
                this.pnSettings.Visible = false;
                serSettings  = true;
              //  this.pnDisplayWindow.Enabled = true;
            }
            this.btnSend.Enabled = serSettings;
            this.btnOpen.Enabled = serSettings;
        }
        #endregion

        #region initialize  
        private void InitializeSerial()
        {
            try
            {
                LoadValues();
                SetDefaults();
                SetControlState();
               // OpenPort();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region port operations
        /// <summary>
        /// open port
        /// </summary>
        private void OpenPort()
        {
            try
            {
                comm.Parity = this.cboParity.Text;
                comm.StopBits = this.cboStop.Text;
                comm.DataBits = this.cboData.Text;
                comm.BaudRate = this.cboBaud.Text;
                comm.DisplayWindow = this.rtxtDisplayWindow;
                comm.PortName = cboPort.SelectedItem.ToString();
                comm.OpenPort();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Method to initialize serial port
        /// values to standard defaults
        /// </summary>
        private void SetDefaults()
        {
            try
            {
                cboPort.SelectedIndex = 0;
                cboBaud.SelectedIndex = 5;
                cboParity.SelectedIndex = 0;
                cboStop.SelectedIndex = 1;
                cboData.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
            }
        }

        /// <summary>
        /// methos to load our serial
        /// port option values
        /// </summary>
        private void LoadValues()
        {
            comm.SetPortNameValues(cboPort);
            comm.SetParityValues(cboParity);
            comm.SetStopBitValues(cboStop);
        }

        /// <summary>
        /// method to set the state of controls
        /// when the form first loads
        /// </summary>
        private void SetControlState()
        {
            rdoText.Checked = true;
            //cmdSend.Enabled = false;
           // cmdClose.Enabled = false;
        }
        /// <summary>
        /// send data to serial
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            comm.WriteData(this.txtData.Text.Trim());
        }
        /// <summary>
        /// if transmission type changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoHex_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoHex.Checked == true)
            {
                comm.CurrentTransmissionType = PCComm.CommunicationManager.TransmissionType.Hex;
            }
            else
            {
                comm.CurrentTransmissionType = PCComm.CommunicationManager.TransmissionType.Text;
            }
        }
        /// <summary>
        /// open port
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenPort();
        }
        #endregion
    }
}
