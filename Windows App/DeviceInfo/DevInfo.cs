using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Xml;
using System.Threading;
using System.IO;

namespace DeviceInfo
{
    public partial class DevInfo : UserControl
    {
        public DevInfo()
        {
            
            try
            {
                InitializeComponent();
            }
            catch (Exception ex) {
                MessageBox.Show("Error Found while initializing program.", "XSoft");
            }
        }

        #region Variables
        private string[] model = null;
        private string[] specs = null;
        private string modelData = string.Empty;
        private string specsData = string.Empty;
        private string[] pinsData = null;
        private string defaultPackage = Application.StartupPath + @"\imgs\pkg.png";
        String packagePath = string.Empty;
        private Int16 packageIndex = 0;
        private string[] colsBuffer = null;
        private string[] tinyMega = new String[] { "Status", "Flash(kb)", "EEPROM(bytes)", "RAM(bytes)", "picoPower",
        "I/O pins", "UART/USART", "SPI/TWI by USI", "SPI", "TWI(12C compliant)", "8 bit Timers", "16-bit Timers",
        "PWM(channel", "10-bit A/D(channel)", "Analog Gain Stage", "DebugWire/OCD", "JTAG/OCD", "Vcc Range(V)", 
        "Clock Speed(Mhz)", "Package", "Pb-free, Green", "Temp, Range" };
        private string[] atxmega = new string[] {"Status", "Flash(kb)", "Boot code(bytes)", "EEPROM(bytes)", "SRAM(bytes)",
        "picoPower", "DMA(channels)", "Event(channels) :",  "I/O", "16-bit Timers", "PWM(channel)", "RTC 16-bit",
        "RTC 32-bit", "SPI", "TWI(12C)", "USART", "12-bit A/D(channel)", "12-bit DAC(channel)", "Analog Comparator",
        "Interrupts", "Interrupts External", "JTAG", "PDI", "Vcc (V) Range", "Clock Speed(Mhz)", "Package", "Temp.Range"};
        #endregion

        #region show device information
        public string GetDevice()
        {
            return Properties.Settings.Default.device;
        }
        #endregion

        #region initialize listview
        private void InitSpecsView()
        {
            try
            {
                foreach (string column in colsBuffer)
                {
                    this.SpecsView.Columns.Add(column);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region read device information
        private void linkRead_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DevSpecsInit();
        }

        private void DevSpecsInit()
        {
            this.pnSpecs.Visible = true;
            this.pnPinConfig.Visible = false;
            this.SpecsView.Items.Clear();
            this.lblDevSpecs.Text = string.Empty;
            this.lblDevice.Text = GetDevice();
            GetLinks();
            //   ExecuteXmlAsync();
            DeviceSpecs();
        }
        #endregion

        #region get device datasheet and info websites
        /// <summary>
        /// get device datasheet and information links.
        /// </summary>
        ///
        private void GetLinks()
        {
            this.linkDatasheet.Text = String.Format(@"www.atmel.com/devices/{0}.aspx?tab=documents",
                GetDevice());
            this.linkAtmel.Text = string.Format(@"www.atmel.com/dyn/products/product_card.asp?PN={0}",
                GetDevice());
        }
        #endregion

        #region atmel website
        private void linkAtmel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(linkAtmel.Text);
        }
        #endregion

        #region device specifications
        private void DeviceSpecs()
        {
            try
            {
                XmlReader reader = XmlReader.Create(Application.StartupPath + @"\devices\devices.xml");
                String device = GetDevice();
                if (device.StartsWith("ATmega") || device.StartsWith("ATtiny")) colsBuffer = tinyMega;
                else colsBuffer = atxmega;
                while (reader.Read())
                {
                    if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "device"))
                    {
                        if (reader.HasAttributes && reader.GetAttribute("name").ToUpper().Equals(device.ToUpper()))
                        {
                            modelData = reader.GetAttribute("model");
                            model = modelData.Split(';');
                            this.lblDevSpecs.Text = ("Architecture : " + model[0] + "                       Family : " + model[1]);
                            specsData = reader.GetAttribute("specs");
                            specs = specsData.Split(';');
                            this.SpecsView.Items.Clear();
                            for (int index = 0; index < colsBuffer.Length; index++)
                            {
                                if (string.IsNullOrEmpty(specs[index])) specs[index] = "none";
                                this.SpecsView.Items.Add(colsBuffer[index] + " : " + specs[index]);
                                this.SpecsView.Items.Add("\n");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "XSoft");
            }
        }
        #endregion

        #region get datasheet
        private void linkDatasheet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(this.linkDatasheet.Text);
        }
        #endregion

        #region executeXmlAsync
        [STAThread]
        private void ExecuteXmlAsync()
        {
            Thread xmlThread = new Thread(DeviceSpecs);
            xmlThread.IsBackground = false;
            xmlThread.Priority = ThreadPriority.AboveNormal;
            xmlThread.Start();
        }
        #endregion

        #region pin configuration
        private void linkPinConfig_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                this.pnSpecs.Visible = false;
                this.pnPinConfig.Visible = true;
                // this.SpecsView.Items.Clear();
                this.lblDevSpecs.Text = string.Empty;
                this.lblDevice.Text = GetDevice();
                //GetLinks();
                GetPinConfig(GetDevice());
            }
            catch (Exception ex) { };
        }
        /// <summary>
        /// get pin configuration data.
        /// </summary>
        /// <param name="device"></param>
        private void GetPinConfig(string device)
        {
            try
            {
                
                pinsData = null;
                this.lblPackage.Text = "Package";
                packagePath = defaultPackage;
                this.pbxPackage.Image = Image.FromFile(packagePath);
                //if (device.StartsWith("ATmega") || device.StartsWith("ATtiny")) colsBuffer = tinyMega;
                // else colsBuffer = atxmega;
                XmlReader reader = XmlReader.Create(Application.StartupPath + @"\devices\pins.xml");
                while (reader.Read())
                {
                    if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "device"))
                    {
                        if (reader.HasAttributes && reader.GetAttribute("name").ToUpper().Equals(device.ToUpper()))
                        {
                            modelData = reader.GetAttribute("model");
                            model = modelData.Split(';');
                            this.lblDevSpecs.Text = ("Architecture : " + model[0] + "               Family : " + model[1]);
                            pinsData = reader.GetAttribute("pins").Split(';');
                            packagePath = reader.GetAttribute("path");
                            packageIndex = 0;
                            //this.SpecsView.Items.Clear();
                            //for (int index = 0; index < pinsData.Length; index++)
                            //{
                            this.lblPackage.Text = pinsData[packageIndex];
                            GetPackageImage(packageIndex);
                            //if (string.IsNullOrEmpty(specs[index])) specs[index] = "none";
                            //this.SpecsView.Items.Add((index +1) + "  :  " + pinsData[index]);
                            //this.SpecsView.Items.Add("\n"); 
                            // }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "XSoft");
            }
            finally
            {
                if (pinsData[0].Equals(string.Empty) || 
                    this.lblPackage.Text.Equals("package"))
                    this.pbxPackage.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
        #endregion

        #region navigate/show packages

        private void GetPackageImage(Int16 index)
        {
            try
            {
                this.pbxPackage.Image = Image.FromFile(Application.StartupPath + @"\" + packagePath +
                    pinsData[packageIndex] + ".gif");
                this.pbxPackage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex) { }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            try
            {
                if (packageIndex != 0) packageIndex--;
                this.lblPackage.Text = pinsData[packageIndex];
                GetPackageImage(packageIndex);
            }
            catch (Exception ex) { }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                if (packageIndex != pinsData.Length - 1) packageIndex++;
                this.lblPackage.Text = pinsData[packageIndex];
                GetPackageImage(packageIndex);
            }
            catch (Exception ex) { }
        }

        #endregion

        #region show enlarged image
        private void pbxPackage_Click(object sender, EventArgs e)
        {
            try
            {
                package pk = new package();
                pk.ShowPackage(packagePath, pinsData[packageIndex], GetDevice());
            }
            catch (Exception ex) { }
        }
        #endregion
    }
}
