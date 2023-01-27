using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fuses
{
    public partial class ATmega328p : UserControl
    {
        public ATmega328p(TextBox tbxExt = null, TextBox tbxHigh = null,
            TextBox tbxLow = null)
        {
            InitializeComponent();
            PopulateRegisters();
            RegisterEvents();
            this._txtExt = tbxExt;
            this._txtHigh = tbxHigh;
            this._txtLow = tbxLow;
            InitializeRegisters();
        }

        #region variables
        private SQLiteConnection conn;
        private SQLiteCommand command;
        private SQLiteDataReader reader;
        private TextBox _txtExt;
        private TextBox _txtHigh;
        private TextBox _txtLow;
        private string txteFuse = "07";
        private string txtHFuse = "D9";
        private string txtLFuse = "62";
        #endregion

        #region initialize and display registers
        private void InitializeRegisters()
        {
            DisplayExtFuse();
            DisplayHighFuse();
            DisplayLowFuse();
        }
        #endregion

        #region database

        private string dbconn = "Data Source=" + Application.StartupPath +
                    @"\devices\fuses_locks\ATmega328P.db";

        private void GetConnection()
        {
            conn = new SQLiteConnection(dbconn);
        }

        private void ReadDb(string sql)
        {
            try
            {
                GetConnection();
                conn.Open();
                command = new SQLiteCommand(conn);
                command.CommandText = sql;
                reader = command.ExecuteReader();
                //this.dgviewfuses.DataSource = dt;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                //throw new Exception(e.Message);
            }

        }
        #endregion

        #region calculate fuses
        private void ExtendedFuse()
        {
            try
            {
                ReadDb("select name, caption from EXTENDED");
                reader.Read();
                this.lblExt.Text = reader.GetString(0);
                this.ttp.SetToolTip(this.lblExt, reader.GetString(1) + 
                    "\nExtended Bit 2-0");
                reader.Close();
                conn.Close();

                ReadDb("select name from ENUM_BODLEVEL");
                while (reader.Read())
                {
                    this.cbbExt.Items.Add(reader.GetString(0));
                }
                this.cbbExt.SelectedIndex = 3;
                reader.Close();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void HighFuse()
        {
            try
            {
                ReadDb("select name, caption from HIGH");
                int index = 1;
                string tlp = string.Empty;
                while (reader.Read())
                {
                    tlp = reader.GetString(1);
                    switch (index)
                    {
                        case 1:
                            this.lblHigh1.Text = reader.GetString(0);
                            this.ttp.SetToolTip(this.lblHigh1, tlp + 
                                "\nHigh Bit 7");
                            this.ttp.SetToolTip(this.cbxHigh1, tlp);
                            break;
                        case 2:
                            this.lblHigh2.Text = reader.GetString(0);
                            this.ttp.SetToolTip(this.lblHigh2, tlp +
                                "\nHigh Bit 6");
                            this.ttp.SetToolTip(this.cbxHigh2, tlp);
                            break;
                        case 3:
                            this.lblHigh3.Text = reader.GetString(0);
                            this.ttp.SetToolTip(this.lblHigh3, tlp +
                                "\nHigh Bit 5");
                            this.ttp.SetToolTip(this.cbxHigh3, tlp);
                            break;
                        case 4:
                            this.lblHigh4.Text = reader.GetString(0);
                            this.ttp.SetToolTip(this.lblHigh4, tlp +
                                "\nHigh Bit 4");
                            this.ttp.SetToolTip(this.cbxHigh4, tlp);
                            break;
                        case 5:
                            this.lblHigh5.Text = reader.GetString(0);
                            this.ttp.SetToolTip(this.lblHigh5, tlp +
                                "\nHigh Bit 3");
                            this.ttp.SetToolTip(this.cbxHigh5, tlp);
                            break;
                        case 6:
                            this.lblHigh6.Text = reader.GetString(0);
                            this.ttp.SetToolTip(this.lblHigh6, tlp +
                                "\nHigh Bit 2-1");
                            break;
                        case 7:
                            this.lblHigh7.Text = reader.GetString(0);
                            this.ttp.SetToolTip(this.lblHigh7, tlp +
                                "\nHigh Bit 0");
                            this.ttp.SetToolTip(this.cbxHigh7, tlp);
                            break;
                    }
                    index++;
                }
                reader.Close();
                conn.Close();

                //populate bootsz 
                ReadDb("select name from ENUM_BOOTSZ");
                while (reader.Read())
                {
                    this.cbbBs.Items.Add(reader.GetString(0));
                }
                this.cbbBs.SelectedIndex = 3;
                this.ttp.SetToolTip(this.cbbBs, this.cbbBs.SelectedItem.ToString());
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LowFuse()
        {
            try
            {
                ReadDb("select name, caption from LOW");
                int index = 1;
                string tlp = string.Empty;
                while (reader.Read())
                {
                    tlp = reader.GetString(1);
                    switch (index)
                    {      
                        case 1:
                            this.lblLow1.Text = reader.GetString(0);
                            this.ttp.SetToolTip(this.lblLow1, tlp +
                                "\nLow Bit 7");
                            this.ttp.SetToolTip(this.cbxLow1, tlp);
                            break;
                        case 2:
                            this.lblLow2.Text = reader.GetString(0);
                            this.ttp.SetToolTip(this.lblLow2, tlp +
                                "\nHigh Bit 6");
                            this.ttp.SetToolTip(this.cbxLow2, tlp);
                            break;
                        case 3:
                            this.lblLow3.Text = reader.GetString(0);
                            this.ttp.SetToolTip(this.lblLow3, tlp +
                                "\nHigh Bit 5-0");
                            break;
                    }
                    index++;
                }
                reader.Close();
                conn.Close();

                //populate bootsz 
                ReadDb("select name from ENUM_SUT_CKSEL");
                while (reader.Read())
                {
                    this.cbbSc.Items.Add(reader.GetString(0));
                }
                this.cbbSc.SelectedIndex = 5;
                this.ttp.SetToolTip(this.cbbSc, this.cbbSc.SelectedItem.ToString());
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// populate panel with registers
        /// </summary>
        private void PopulateRegisters()
        {
            ExtendedFuse();
            HighFuse();
            LowFuse();
        }
        #endregion

        #region display fuses
        [STAThread]
        public void DisplayExtFuse()
        {
            _txtExt.Invoke(new EventHandler(delegate
            {
                this._txtExt.Text = txteFuse;
            }));
        }

        [STAThread]
        public void DisplayHighFuse()
        {
            _txtExt.Invoke(new EventHandler(delegate
            {
                this._txtHigh.Text = this.txtHFuse;
            }));
        }

        [STAThread]
        public void DisplayLowFuse()
        {
            _txtExt.Invoke(new EventHandler(delegate
            {
                this._txtLow.Text = this.txtLFuse;
            }));
        }
        #endregion

        #region combo boxes events
        private void cbbExt_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ReadDb("select caption, value from ENUM_BODLEVEL where name='" +
                    this.cbbExt.SelectedItem.ToString() + "'");
                reader.Read();
                this.ttp.Show(reader.GetString(0), this.cbbExt, 1000);
                this.txteFuse = reader.GetString(1);
                reader.Close();
                conn.Close();
                DisplayExtFuse();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbbBs_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ReadDb("select caption, value from ENUM_BOOTSZ where name='" +
                    this.cbbBs.SelectedItem.ToString() + "'");
                reader.Read();
                this.ttp.Show(reader.GetString(0), this.cbbBs, 1000);
                char bit = (char)(Convert.ToByte(reader.GetString(1), 16) << 1);
                char cv = (char)((Convert.ToByte(txtHFuse, 16) & 0xF9) | bit);
                this.txtHFuse = Convert.ToString(cv, 16).PadLeft(2, '0');
                reader.Close();
                conn.Close();
                DisplayHighFuse();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbbSc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ReadDb("select caption, value from ENUM_SUT_CKSEL where name='" +
                    this.cbbSc.SelectedItem.ToString() + "'");
                reader.Read();
                this.ttp.Show(reader.GetString(0), this.cbbSc, 1000);
                char bit = (char)(Convert.ToByte(reader.GetString(1), 16));
                char cv = (char)((Convert.ToByte(txtLFuse, 16) & 0xC0) | bit);
                this.txtLFuse = Convert.ToString(cv, 16).PadLeft(2, '0');
                reader.Close();
                conn.Close();
                DisplayLowFuse();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        /*private void cbbSc_DropDownClosed(object sender, EventArgs e)
        {
            ttp.Hide(cbbSc);
        }
        private void cbbSc_DrawItem(object sender, DrawItemEventArgs e)
        {
            ReadDb("select name,caption from ENUM_SUT_CKSEL where name='" +
                      this.cbbSc.SelectedItem.ToString() + "'");
            reader.Read();
            string text = reader.GetString(1);

            if (e.Index < 0) { return; }
            e.DrawBackground();
            using (SolidBrush br = new SolidBrush(e.ForeColor))
            { e.Graphics.DrawString(reader.GetString(0), e.Font, br, e.Bounds); }
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            { ttp.Show(text, cbbSc, e.Bounds.Right, e.Bounds.Bottom, 1000); }
            e.DrawFocusRectangle();
            reader.Close();
            conn.Close();
        }*/
        
        private void RegisterEvents()
        {
            this.cbbExt.SelectedIndexChanged += cbbExt_SelectedIndexChanged;
            this.cbbBs.SelectedIndexChanged += cbbBs_SelectedIndexChanged;
            /*cbbSc.DrawMode = DrawMode.OwnerDrawFixed;
            cbbSc.DrawItem += cbbSc_DrawItem;
            cbbSc.DropDownClosed += cbbSc_DropDownClosed;*/
            this.cbbSc.SelectedIndexChanged += cbbSc_SelectedIndexChanged;
        }
        #endregion

        #region high bits

        private string BitSet(string sql, string fuse, bool ck)
        {
            try
            {
                ReadDb(sql);
                reader.Read();
                char bit = (char)(Convert.ToByte(reader.GetString(0), 16));
                char clfuse = (char)(Convert.ToByte(fuse, 16));
                reader.Close();
                conn.Close();
                char fbit;

                if (ck)
                    fbit = (char)(~bit & clfuse);
                else
                    fbit = (char)(bit | clfuse);
                return Convert.ToString(fbit, 16).PadLeft(2, '0');
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "00";
            }
        }

        private void cbxHigh1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "select mask from HIGH where name='" +
                    this.lblHigh1.Text + "'";
                this.txtHFuse = BitSet(sql, txtHFuse, this.cbxHigh1.Checked);
                DisplayHighFuse();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbxHigh2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "select mask from HIGH where name='" +
                    this.lblHigh2.Text + "'";
                this.txtHFuse = BitSet(sql, txtHFuse, this.cbxHigh2.Checked);
                DisplayHighFuse();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbxHigh3_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "select mask from HIGH where name='" +
                    this.lblHigh3.Text + "'";
                this.txtHFuse = BitSet(sql, txtHFuse, this.cbxHigh3.Checked);
                DisplayHighFuse();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbxHigh4_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "select mask from HIGH where name='" +
                    this.lblHigh4.Text + "'";
                this.txtHFuse = BitSet(sql, txtHFuse, this.cbxHigh4.Checked);
                DisplayHighFuse();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbxHigh5_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "select mask from HIGH where name='" +
                    this.lblHigh5.Text + "'";
                this.txtHFuse = BitSet(sql, txtHFuse, this.cbxHigh5.Checked);
                DisplayHighFuse();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbxHigh7_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "select mask from HIGH where name='" +
                    this.lblHigh7.Text + "'";
                this.txtHFuse = BitSet(sql, txtHFuse, this.cbxHigh7.Checked);
                DisplayHighFuse();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region low bits
        private void cbxLow1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "select mask from LOW where name='" +
                    this.lblLow1.Text + "'";
                this.txtLFuse = BitSet(sql, txtLFuse, this.cbxLow1.Checked);
                DisplayLowFuse();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbxLow2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "select mask from LOW where name='" +
                    this.lblLow2.Text + "'";
                this.txtLFuse = BitSet(sql, txtLFuse, this.cbxLow2.Checked);
                DisplayLowFuse();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        #endregion
    }
}
