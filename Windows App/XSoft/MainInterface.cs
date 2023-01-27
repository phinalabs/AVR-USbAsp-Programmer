using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Home;
using DeviceInfo;
using Memory;
using Fuses;
using LockBits;
using Terminal;
using XView;
using Cmdp;

namespace XSoft
{
    public partial class MainInterface : Form
    {
        public MainInterface()
        {
            InitializeComponent();
            CreateControls();
            AppEvents();
            cmdProcessor = new Cmd(this.rTxtInfo);
        }


        #region variables
        private Control CtrlHome;
        private Control CtrlDevInfo;
        private Control CtrlMemory;
        private Control CtrlFuses;
        private Control CtrlLockBits;
        private Control CtrlTerminal;
        private Control CtrlXView;
        private Cmd cmdProcessor;
        private Color selectColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))),
                ((int)(((byte)(224)))), ((int)(((byte)(224)))));
        private enum Ctrls
        {
            devInfo, home, memory, fuses, lockbits, terminal, xview
        };
        #endregion

        #region control box
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region application load
        private void MainInterface_Load(object sender, EventArgs e)
        {
            this.cbxDevices.SelectedIndex = PreviousDeviceIndex;
            SetDeviceInfo();
            //this.lblVersion.Text = "XSoft\n Build" + Application.ProductVersion;
            ActiveSelection(this.btnHome);
        }
        #endregion

        #region get or set previous device
        private int PreviousDeviceIndex{
            get { return Properties.Settings.Default.selectedDeviceIndex; }
            set
            {
                Properties.Settings.Default.selectedDeviceIndex = value;
                Properties.Settings.Default.Save();
            }
      }

        private void SetDeviceInfo()
        {
            DeviceInfo.Properties.Settings.Default.device = this.cbxDevices.SelectedItem.ToString();
            DeviceInfo.Properties.Settings.Default.Save();
        }

        private void cbxDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            PreviousDeviceIndex = this.cbxDevices.SelectedIndex;
            SetDeviceInfo();
        }
        #endregion

        #region create controls
        private void CreateControls()
        {
            try
            { 
                //home
                CtrlHome = new Home.Home();
                this.pnControls.Controls.Add(CtrlHome);
                CtrlHome.Dock = DockStyle.Fill;
                CtrlHome.Visible = true;
                //Device info
                CtrlDevInfo = new DeviceInfo.DevInfo();
                this.pnControls.Controls.Add(CtrlDevInfo);
                CtrlDevInfo.Dock = DockStyle.Fill;
                CtrlDevInfo.Visible = false;
                //flash/eeprom
                CtrlMemory = new Memory.Memory(this.rTxtInfo);
                this.pnControls.Controls.Add(CtrlMemory);
                CtrlMemory.Dock = DockStyle.Fill;
                CtrlMemory.Visible = false;
                //fuses
                CtrlFuses = new Fuses.Fuses(this.rTxtInfo);
                this.pnControls.Controls.Add(CtrlFuses);
                CtrlFuses.Dock = DockStyle.Fill;
                CtrlFuses.Visible = false;
                //lock bits
                CtrlLockBits = new LockBits.LockBits(this.rTxtInfo);
                this.pnControls.Controls.Add(CtrlLockBits);
                CtrlLockBits.Dock = DockStyle.Fill;
                CtrlLockBits.Visible = false;
                //terminal
                CtrlTerminal = new Terminal.Terminal();
                this.pnControls.Controls.Add(CtrlTerminal);
                CtrlTerminal.Dock = DockStyle.Fill;
                CtrlTerminal.Visible = false;
                //xview
                CtrlXView = new XView.XView(this.rTxtInfo);
                this.pnControls.Controls.Add(CtrlXView);
                CtrlXView.Dock = DockStyle.Fill;
                CtrlXView.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }      
        }
        #endregion

        #region move application
        /* move the app on the screen*/
        private Point mouseOffSet;
        private void onMouseDown(object sender, MouseEventArgs e)
        {
            mouseOffSet = new Point(-e.X, -e.Y);
            this.Opacity = 0.65;
        }
        private void onMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Point mousepos = Control.MousePosition;
                mousepos.Offset(mouseOffSet.X, mouseOffSet.Y);
                this.Location = mousepos;
                this.Opacity = 0.65;
            }
        }
         private void onMouseUp(object sender, MouseEventArgs e)
        {
            this.Opacity = 0.95;
        }
        /*end*/
        #endregion

        #region events
        private void AppEvents()
        {
            //move app events
            this.SpcMain.Panel1.MouseDown += new MouseEventHandler(onMouseDown);
            this.SpcMain.Panel1.MouseMove += new MouseEventHandler(onMouseMove);
            this.SpcMain.Panel1.MouseUp += new MouseEventHandler(onMouseUp);
        }
        #endregion

        #region conrols selection
        private void ControlSelection(Control ctrl, Boolean visible = true){
            if (!ctrl.Visible)
            {
                CtrlHome.Visible = false;
                CtrlDevInfo.Visible = false;
                CtrlMemory.Visible = false;
                CtrlFuses.Visible = false;
                CtrlLockBits.Visible = false;
                CtrlTerminal.Visible = false;
                CtrlXView.Visible = false;
                ctrl.Visible = true;
                this.rTxtInfo.Clear();
            }
        }

        private void ActiveSelection(Button btn)
        {
            if (!(btn.BackColor == selectColor))
            {
                this.btnHome.BackColor = Color.Gray;
                this.btnDevInfo.BackColor = Color.Gray;
                this.btnMemory.BackColor = Color.Gray;
                this.btnFuses.BackColor = Color.Gray;
                this.btnLockBits.BackColor = Color.Gray;
                this.btnTerminal.BackColor = Color.Gray;
                this.btnXView.BackColor = Color.Gray;
                btn.BackColor = selectColor;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ControlSelection(this.CtrlHome);
            ActiveSelection(this.btnHome);
        }

        private void btnDevInfo_Click(object sender, EventArgs e)
        {
            ControlSelection(this.CtrlDevInfo);
            SetDeviceInfo();
            ActiveSelection(this.btnDevInfo);
        }

        private void btnMemory_Click(object sender, EventArgs e)
        {
            ControlSelection(this.CtrlMemory);
            ActiveSelection(this.btnMemory);
        }

        private void btnFuses_Click(object sender, EventArgs e)
        {
            ControlSelection(this.CtrlFuses);
            ActiveSelection(this.btnFuses);
        }

        private void btnLockBits_Click(object sender, EventArgs e)
        {
            ControlSelection(this.CtrlLockBits);
            ActiveSelection(this.btnLockBits);
        }

        private void btnTerminal_Click(object sender, EventArgs e)
        {
            ControlSelection(this.CtrlTerminal);
            ActiveSelection(this.btnTerminal);
        }

        private void btnXView_Click(object sender, EventArgs e)
        {
            ControlSelection(this.CtrlXView);
            ActiveSelection(this.btnXView);
        }

        #endregion

        #region connect device
        private void btnConnect_Click(object sender, EventArgs e)
        {
            cmdProcessor.ConnectDevice(this.cbxDevices.SelectedItem.ToString());
        }
        #endregion
    }
}
