using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DeviceInfo
{
    public partial class package : Form
    {
        public package()
        {
            InitializeComponent();
        }

        #region show package
        public void ShowPackage(string packagePath, string package, string device)
        {
            this.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + @"\" + packagePath +
                    package + ".gif");
            this.Text = device + "  --  " + package;
            this.Show();
        }
        #endregion
    }
}
