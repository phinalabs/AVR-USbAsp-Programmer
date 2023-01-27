using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibMsg
{
    public partial class MsgBox : Form
    {
        public MsgBox()
        {
            InitializeComponent();
            AppEvents();
        }

        #region Show message window
        /// <summary>
        /// show message box window.
        /// </summary>
        /// <param name="message">message to display.</param>
        /// <param name="header">heading.</param>
        /// <returns></returns>
        public bool show(String message, String header = "")
        {
            try
            {
                this.lblHeader.Text = "XSoft - " + header;
                this.lblMessage.Text = message;
                this.ShowDialog();
                return true;
            }
            catch (Exception ex){
                return false;
            }
        }
        #endregion

        #region exit Message box
        /// <summary>
        /// closes the message box window.
        /// </summary>
        private void CloseMsgBox()
        {
            this.Close();
        }
        #endregion

        #region move application
        /* move the app on the screen*/
        private Point mouseOffSet;
        private void onMouseDown(object sender, MouseEventArgs e)
        {
            mouseOffSet = new Point(-e.X, -e.Y);
            this.Opacity = 0.35;
        }
        private void onMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Point mousepos = Control.MousePosition;
                mousepos.Offset(mouseOffSet.X, mouseOffSet.Y);
                this.Location = mousepos;
                this.Opacity = 0.45;
            }
        }
        private void onMouseUp(object sender, MouseEventArgs e)
        {
            this.Opacity = 0.80;
        }
        #endregion

        #region events
        private void AppEvents()
        {
            try
            {
                this.MouseDown += new MouseEventHandler(onMouseDown);
                this.MouseMove += new MouseEventHandler(onMouseMove);
                this.MouseUp += new MouseEventHandler(onMouseUp);
            }
            catch (Exception ex)
            {
            }
        }
        #endregion

        private void linkOk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CloseMsgBox();
        }

        private void linkCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CloseMsgBox();
        }
    }
}
