using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Cmdp;
using LibMsg;

namespace XView
{
    public partial class XView : UserControl
    {
        public XView(RichTextBox _rtb = null)
        {
            InitializeComponent();
            try
            {
                init();
                this.command = new Cmd(_rtb);
            }
            catch (Exception ex) { }
        }

        #region variables
        /*settings instance*/
        private static Properties.Settings mySettings = Properties.Settings.Default;
        private static string sPrevFile = "";
        private static string sCurFile;
        private Cmd command;
        private MsgBox messageBox = new MsgBox();

        #endregion

        #region initialize
        private void init()
        {
            try
            {
                this.toolTips();
                TxtHexPath.Text = xviewhelper.defaultSourceFolder;
                TxtHexName.Text = Properties.Settings.Default.hfName;
                TxtHexTarget.Text = Properties.Settings.Default.tfName;
                xviewhelper.sourceFolder = xviewhelper.defaultSourceFolder;
                sCurFile = TxtHexName.Text;
                cbxBoard.SelectedIndex = 0;
                //xviewhelper.copyHex();
            }
            catch (Exception ex) {
                MessageBox.Show("Failed to initialize Arduino programmer");
            }
        }
        #endregion

        #region tooltips
        /*tooltips extra*/
        private void toolTips()
        {
            TxtHexName.MouseEnter += new EventHandler(SketchFileTtp);
            TxtHexPath.MouseEnter += new EventHandler(ScFileTtp);
            TxtHexTarget.MouseEnter += new EventHandler(TgFileTtp);
        }

        //tooltip for sketch file
        private void SketchFileTtp(object sender, EventArgs e)
        {
            this.ttp.SetToolTip(TxtHexName, "Name of  the arduino sketch." + "\n\n" + TxtHexName.Text);
        }
        /*source path textbox tooltip*/
        private void ScFileTtp(object sender, EventArgs e)
        {
            this.ttp.SetToolTip(TxtHexPath, "Path for arduino compiled files." + "\n\n" + TxtHexPath.Text);
        }
        /*target folder textbox*/
        private void TgFileTtp(object sender, EventArgs e)
        {
            this.ttp.SetToolTip(TxtHexTarget, "Target folder where the compiled file(s) will be copied to." + "\n\n" + TxtHexTarget.Text);
        }

        #endregion

        #region select source and target folder
        /*source folder button*/
        private void BtnSfolder_Click(object sender, EventArgs e)
        {
            fbd.ShowNewFolderButton = false;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                TxtHexPath.Text = fbd.SelectedPath;
            }
        }
        /*Target source file folder*/
        private void BtnTfolder_Click(object sender, EventArgs e)
        {
            fbd.ShowNewFolderButton = true;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                TxtHexTarget.Text = fbd.SelectedPath;
                xviewhelper.getTargetFolder = TxtHexTarget.Text;
                mySettings.tfName = TxtHexTarget.Text;
            }
        }
        /*check if the sketch file is new/changed from previous one.*/
        #endregion

        #region files/sketch fetch processes
        private void CheckNewSketch()
        {
            if (!sPrevFile.Equals(sCurFile))
            {
                xviewhelper.sourceFolder = xviewhelper.defaultSourceFolder; //update source folder and swap names.
                sPrevFile = sCurFile;
                sCurFile = TxtHexName.Text.Trim();
            }
        }

        /*find and save sketch*/
        private bool LoadSketch()
        {
            bool sketch = false;
            try
            {
                command.outputResult = "fetching  file(s) ......";
                command.DisplayData();
                
                /*check if the sketch and folders are available.*/
                if (!string.IsNullOrEmpty(TxtHexName.Text) && !string.IsNullOrEmpty(TxtHexPath.Text)
                   && !string.IsNullOrEmpty(TxtHexTarget.Text))
                {
                    CheckNewSketch(); //check new sketch copy.
                    mySettings.hfName = TxtHexName.Text;    //save hex name.
                    xviewhelper.getTargetFolder = TxtHexTarget.Text;
                    mySettings.tfName = TxtHexTarget.Text;
                    mySettings.Save();
                    /*perform file transfer*/
                    if (CbxHex.Checked)//.hex file copy.
                    {
                        xviewhelper.getHexName = TxtHexName.Text.Trim() + ".cpp.hex";
                        xviewhelper.TraverseTree(xviewhelper.sourceFolder); //search folder with the file.
                    }
                    if (CbxElf.Checked)//.elf file copy
                    {
                        xviewhelper.getHexName = TxtHexName.Text.Trim() + ".cpp.elf";
                        xviewhelper.TraverseTree(xviewhelper.sourceFolder); //search folder with the file.
                    }
                    if (CbxCpp.Checked)//.cpp file copy
                    {
                        xviewhelper.getHexName = TxtHexName.Text.Trim() + ".cpp";
                        xviewhelper.TraverseTree(xviewhelper.sourceFolder); //search folder with the file.
                    }
                    if (xviewhelper.sourceFolder.Contains("build"))
                    {
                        command.outputResult = "File(s) update/load completed successfully";
                        sketch = true;
                    }
                    else
                    {
                        command.outputResult = "Cannot find the specified file(s). Make sure:\n\nThe sketch is open and compiled. " +
                            "\nOr your temporary directory folder is clean.";
                        sketch =  false;
                    }
                }
                else
                {
                    command.outputResult = "Please check that skecth file and folders are filled.";
                    sketch = false;
                }
                command.DisplayData();
                return sketch;
            }
            catch (Exception ex)
            {
                command.outputResult = "The specified sketch has been closed. \n" +
                    "Please reopen the sketch and compile. ";
                command.DisplayData();
                xviewhelper.sourceFolder = xviewhelper.defaultSourceFolder;
                return false;
            }
        }
        /*load arduino compiled files and save to the target folder.*/
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            LoadSketch();
        }

        #endregion

        #region arduino processes
        /*open the Arduino Development Enviroment*/
        private void getArduLink()
        {
            if (opfd.ShowDialog() == DialogResult.OK)
            {
                mySettings.arduLink = opfd.FileName;
                mySettings.Save();
            }
        }
        /*reload the aduino link*/
        private void BtnArduLoad_Click(object sender, EventArgs e)
        {
            getArduLink();
        }
        /*open dialog window*/
        private void BtnOpenArdu_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(string.IsNullOrWhiteSpace(mySettings.arduLink)))
                {
                    Process.Start(mySettings.arduLink);
                }
                else
                {
                    getArduLink();
                }
            }
            /*incase anything happens load the IDE again*/
            catch (Exception ex)
            {
                if (MessageBox.Show("Failed to load Arduino IDE.", "ILoada", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
                    == DialogResult.Yes)
                {
                    getArduLink();
                }
            }
        }
        private void CbxAll_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxAll.Checked)
            {
                CbxHex.Checked = true;
                CbxElf.Checked = true;
                CbxCpp.Checked = true;
            }
        }

        #region program device
        /// <summary>
        /// return the device board.
        /// </summary>
        /// <returns></returns>
        private string deviceBoard()
        {
            switch (cbxBoard.SelectedIndex)
            {
                case 0: return "ATmega328P";
                case 1: return "ATmega168";
                case 2: return "ATmega2560";
                case 3: return "ATmega1280";
            }
            return "";
        }
        /// <summary>
        /// program arduino devoce
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnArdProg_Click(object sender, EventArgs e)
        {
            try
            {
                bool sketch = LoadSketch();
                if (!TxtHexName.Text.Equals("") && !TxtHexTarget.Text.Equals("")
                    && sketch)
                    command.WriteMemory(deviceBoard(), "flash",
                        TxtHexTarget.Text + "/" + TxtHexName.Text + ".cpp.hex");
                else
                {
                    command.outputResult = "Cannot find hex path. please save/update.";
                    command.DisplayData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #endregion
    }
}
