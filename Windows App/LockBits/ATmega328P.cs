using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LockBits
{
    public partial class ATmega328P : UserControl
    {
        public ATmega328P(TextBox lbit = null)
        {
            InitializeComponent();
            this._lbit = lbit;
            InitLockBits();
            DisplayLockBit();
        }

        #region variables
        private TextBox _lbit;
        private string lockbit = "3F";
        private SQLiteConnection conn;
        private SQLiteCommand command;
        private SQLiteDataReader reader;
        private string l1val;
        private string l2val;
        private string l3val;
        private string selBit;
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
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        #endregion

        #region populate Lockbits
        private void PopulateLockLabels()
        {
            ReadDb("select name,caption,vals from LOCKBIT");
            int index = 1;
            while (reader.Read())
            {
                switch (index)
                {
                    case 1:
                        InitLabel(this.lblLock1, reader.GetString(0),
                            reader.GetString(1) + "\nBit 0-1");
                        this.l1val = reader.GetString(2);
                        //MessageBox.Show(l1val);
                        break;
                    case 2:
                        InitLabel(this.lblLock2, reader.GetString(0),
                            reader.GetString(1) + "\nBit 2-3");
                        this.l2val = reader.GetString(2);
                        //MessageBox.Show(l2val);
                        break;
                    case 3:
                        InitLabel(this.lblLock3, reader.GetString(0),
                            reader.GetString(1) + "\nBit 4-5");
                        this.l3val = reader.GetString(2);
                        //MessageBox.Show(l3val);
                        break;
                }
                index++;
            }
            reader.Close();
            conn.Close();
        }

        private void InitLabel(Label lbl, string lbltext, string ttp)
        {
            lbl.Text = lbltext;
            this.ttp.SetToolTip(lbl, ttp);
        }

        private void Cbbhelper(string db, ComboBox cbb)
        {
            ReadDb("select name from " + db);
            while (reader.Read())
                cbb.Items.Add(reader.GetString(0));
            cbb.SelectedIndex = (cbb.Items.Count - 1);
            reader.Close();
            conn.Close();
        }
        private void PopulateCbb()
        {
            Cbbhelper(l1val, this.cbbLock1);
            Cbbhelper(l2val, this.cbbLock2);
            Cbbhelper(l3val, this.cbbLock3);
        }
        
        private void InitLockBits()
        {
            PopulateLockLabels();
            PopulateCbb();
            RegisterEvents();
        }
        #endregion

        #region display lock bit
        [STAThread]
        public void DisplayLockBit()
        {
            _lbit.Invoke(new EventHandler(delegate
            {
                this._lbit.Text = lockbit;
            }));
        }
        #endregion

        #region comboboxes events
        private void CbbEventHelper(string db, ComboBox cbb)
        {
            try
            {
                ReadDb("select caption,value from " + db + " where name='" +
                    cbb.SelectedItem.ToString() + "'");
                reader.Read();
                this.ttp.Show(reader.GetString(0), cbb, 1000);
                selBit = reader.GetString(1);
                //MessageBox.Show(selBit);
                reader.Close();
                conn.Close();
            }catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        private void cbbLock1_SelectedIndexChanged (object sender, EventArgs e)
        {
            CbbEventHelper(l1val, this.cbbLock1);
            char bit = (char)(Convert.ToByte(lockbit, 16) & 0xFC);
            char cv = (char)((Convert.ToByte(selBit, 16)) | bit);
            this.lockbit = Convert.ToString(cv, 16).PadLeft(2, '0');
            DisplayLockBit();
        }

        private void cbbLock2_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbbEventHelper(l2val, this.cbbLock2);
            char bit = (char)(Convert.ToByte(lockbit, 16) & 0xF3);
            char cv = (char)(((Convert.ToByte(selBit, 16)) << 2) | bit);
            this.lockbit = Convert.ToString(cv, 16).PadLeft(2, '0');
            DisplayLockBit();
        }

        private void cbbLock3_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbbEventHelper(l3val, this.cbbLock3);
            char bit = (char)(Convert.ToByte(lockbit, 16) & 0xCF);
            char cv = (char)(((Convert.ToByte(selBit, 16)) << 4) | bit);
            this.lockbit = Convert.ToString(cv, 16).PadLeft(2, '0');
            DisplayLockBit();
        }

        private void RegisterEvents()
        {
            this.cbbLock1.SelectedIndexChanged += cbbLock1_SelectedIndexChanged;
            this.cbbLock2.SelectedIndexChanged += cbbLock2_SelectedIndexChanged;
            this.cbbLock3.SelectedIndexChanged += cbbLock3_SelectedIndexChanged;
        }
        #endregion
    }
}
