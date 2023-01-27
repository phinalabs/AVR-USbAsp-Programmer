using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Home
{
    public partial class Home : UserControl
    {
        public Home()
        {
            try
            {
                InitializeComponent();
                //LoadBgImage();
                PopulateList();
            }
            catch (Exception ex) { }
        }

        #region variables
        private string appPath = Application.StartupPath;
        //private Graphics sevenSeg;
        #endregion

        #region background image
        private void LoadBgImage()
        {
            try
            {
                //this.pnbg.BackgroundImage = Image.FromFile(appPath + @"\imgs\board.png");
                //this.pnbg.BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "bg");
            }
        }
        #endregion

        #region email/website  links
        private void linkEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start("OUTLOOK.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region support links

        private void linkSupport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //this.pnSupport.Visible = !this.pnSupport.Visible;
           // if(this.linkSupport.Text.EndsWith(">>")) this.linkSupport.Text = "Support  <<";
            //else  this.linkSupport.Text = "Support  >>";
            Process.Start("http://learn.warefab.com");
        }

        private void linkLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(
                File.ReadAllText(Application.StartupPath + @"\Licenses\License.txt",
                Encoding.ASCII), "License");
        }

        #endregion

         #region populate list
        private void PopulateList()
        {
            ListViewItem objList;
            char asc;
            for (int x =0; x <= 255; x++)
            {
                objList = new ListViewItem();
                if (x >= 32 && x<=126) objList.ForeColor = Color.White;
                //DEC
                objList.Text = x.ToString().PadLeft(3, '0');
                //HEX
                objList.SubItems.Add(
                    (Convert.ToString(x, 16).PadLeft(2, '0')).ToUpper());
                //ASCII
               asc = Convert.ToChar(x);
                if (asc == ' ') 
                    objList.SubItems.Add("SPACE");
                else
                    objList.SubItems.Add(asc.ToString());
                //BIN
                objList.SubItems.Add(
                    (Convert.ToString(x, 2).PadLeft(8, '0')));
                lstView.Items.Add(objList);
                
            }
        }
        
        #endregion

        #region get and copy list item(s) to clipboard

       //decimal copy
        private void decTsm_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(CopyItemToClipboard(itemsList.Dec),
                TextDataFormat.Text);    
        }

        //enum to hold list item objects
        enum itemsList{ 
            Dec, Hex, Ascii, Bin, All};
        
        //copy item to clipboard
        private string CopyItemToClipboard(itemsList il)
        {
            string[] data = GetListSelection().Split(',');
            switch (il)
            {
                case itemsList.Dec:
                    return data[0];
                case itemsList.Hex:
                    return data[1];
                case itemsList.Ascii:
                    return data[2];
                case itemsList.Bin:
                    return data[3];
                case itemsList.All:
                    return GetListSelection();
            }
            return string.Empty;
        }

        //get selected list
        private string GetListSelection()
        {
            try
            {
                string items = string.Empty;
                ListView.SelectedListViewItemCollection ls = lstView.SelectedItems;
                items =  ls[0].Text;
                for (int index = 1; index < ls[0].SubItems.Count; index++)
                {
                    items += "," + ls[0].SubItems[index].Text;
                }
                return items;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }
        }

        //copy everything to clipboard
        private void copyAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(CopyItemToClipboard(itemsList.All),
                TextDataFormat.Text);
        }

        //copy hex to clipboard
        private void hexTsm_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(CopyItemToClipboard(itemsList.Hex),
                TextDataFormat.Text); 
        }

        //copy ascii to clipboard
        private void asciiTsm_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(CopyItemToClipboard(itemsList.Ascii), 
                TextDataFormat.Text); 
        }

        //copy to binary
        private void binTsm_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(CopyItemToClipboard(itemsList.Bin), 
                TextDataFormat.Text);
        }
        #endregion
    }
}
