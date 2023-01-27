using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace Cmdp
{
    public class Cmd
    {

        #region constructor
        public Cmd(RichTextBox rtb = null)
        {
            this._displayWindow = rtb;
        }
        public Cmd()
        {
        }
        #endregion

        public void SetDisplayWindow(RichTextBox rtb){
            this._displayWindow = rtb;
        }

        #region variables
        private RichTextBox _displayWindow;

        /////////////////////////////////
        public string avrdef = string.Empty;
        public string shell = "cmd";
        public string outputResult = string.Empty;
        private delegate void showOutput();
        ProcessStartInfo procStartInfo;
        Process proc = new System.Diagnostics.Process();
        private string _hexFile = string.Empty;
        private string _eepFile = string.Empty;
        private string avrdudePathShort = @"/c  util\avrdude  -C  util\avrdude.conf  -c  USBasp  -p  ";
        private string avrdudePathShortLong = string.Format(
            @"/c  ""{0}\util\avrdude"" -C  ""{0}\util\avrdude.conf -c USBasp -p""  ", 
            Application.StartupPath);
        #endregion

        #region return avrdude path
        private string AvrdudePath()
        {
            if (Application.StartupPath.Contains(' ')) return avrdudePathShortLong;
            else return avrdudePathShort;
        }
        #endregion

        #region command processor
        ////////////////////////////////////////////////////
            /// <summary>
            /// Executes a shell command synchronously.
            /// </summary>
            /// <param name="command">string command</param>
            /// <returns>string, as output of the command.</returns>
            public void ExecuteCommandSync()
            {
                try
                {
                    outputResult = "";
                    // create the ProcessStartInfo using "cmd" as the program to be run,
                    // and "/c " as the parameters.
                    // Incidentally, /c tells cmd that we want it to execute the command that follows,
                    // and then exit.
                    procStartInfo = new System.Diagnostics.ProcessStartInfo(shell, avrdef);

                    // The following commands are needed to redirect the standard output.
                    // This means that it will be redirected to the Process.StandardOutput StreamReader.
                    procStartInfo.RedirectStandardOutput = true;
                    procStartInfo.RedirectStandardInput = true;
                    procStartInfo.RedirectStandardError = true;
                    procStartInfo.UseShellExecute = false;
                    // Do not create the black window.
                    procStartInfo.CreateNoWindow = true;
                    // Now we create a process, assign its ProcessStartInfo and start it
                    proc.StartInfo = procStartInfo;
                    proc.Start();
                    // Get the output into a string
                    string result = string.Empty;// proc.StandardOutput.ReadToEnd();
                    proc.WaitForExit();
                    outputResult = proc.StandardError.ReadToEnd();
                    DisplayData();
                }
                catch (Exception objException)
                {
                    MessageBox.Show(objException.Message);
                }
            }

            /// <summary>
            /// Execute the command Asynchronously.
            /// </summary>
            /// <param name="command">string command.</param>
            public void ExecuteCommandAsync()
            {
                try
                {
                    // Asynchronously start the Thread to process the Execute command request.
                    Thread objThread = new Thread(ExecuteCommandSync);
                    //Make the thread as background thread.
                    objThread.IsBackground = true;
                    //Set the Priority of the thread.
                    objThread.Priority = ThreadPriority.AboveNormal;
                    //Start the thread.
                    objThread.Start();
                    // rtxtMessage.AppendText( outputResult);
                }
                catch (ThreadStartException objException)
                {
                    MessageBox.Show(objException.Message);
                }
                catch (ThreadAbortException objException)
                {
                    MessageBox.Show(objException.Message);
                }
                catch (Exception objException)
                {
                    MessageBox.Show(objException.Message);
                }
            }
        #endregion

        #region display data

            /// <summary>
            /// 
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>

            [STAThread]
            public void DisplayData()
            {
                _displayWindow.Invoke(new EventHandler(delegate
                {
                    _displayWindow.Text = string.Empty;
                    outputResult = outputResult.Replace("USBasp", "wfisp");
                    outputResult = outputResult.Replace("usbasp", "wfisp");
                    outputResult = outputResult.Replace("avrdude", "-");

                    if(outputResult.Contains("0x16c0")) outputResult = "Atmel isp programmer - usbasp not found.";
                    //outputResult = outputResult.Replace(@"could not find USB device ""nanoboard"" with vid=0x16c0 pid=0x5dc",
                    //"nanoboard programmer not found.");
                    outputResult = outputResult.Replace("-: warning: cannot set sck period. please check for" +
                                                                                " nanoboard firmware update.", "");
                    // _displayWindow.SelectionFont = new Font(_displayWindow.SelectionFont, FontStyle.Bold);
                    //_displayWindow.SelectionColor = MessageColor[(int)type];
                    _displayWindow.AppendText(outputResult.Trim());
                    _displayWindow.ScrollToCaret();
                    if (!outputResult.Contains("Expected") && outputResult.Contains("ready"))
                    {
                        
                    }
                    if (outputResult.Contains("Expected signature"))
                    {
                        
                    }
                    outputResult = "";
                }));
            }
        #endregion

        #region SetFiles
            public String HexFile
            {
                get { return _hexFile; }
                set { _hexFile = value; }
            }
            public String EepFile
            {
                get { return _eepFile; }
                set { _eepFile = value; }
            }
        #endregion

        #region avrdude
        /// <summary>
        /// erase device
        /// </summary>
        /// <param name="device"></param>
        public void EraseDevice(String device)
        {
            try
            {
                outputResult  = "erasing memory ...............";
                DisplayData();
                avrdef = avrdudePathShort + device + " -e -q";
                ExecuteCommandAsync();
            }
            catch (Exception ex)
            {
                outputResult = "target device not selected.";
                DisplayData();
            }      
        }
        /// <summary>
        /// connect device
        /// </summary>
        /// <param name="device"></param>
        public void ConnectDevice(string device)
        {
            try
            {
                //MessageBox.Show(avrdudePathShort);
                outputResult = "connecting ...............";
                DisplayData();
                avrdef = avrdudePathShort + device + " -F";
                ExecuteCommandAsync();
            }
            catch (Exception ex)
            {
                outputResult = "target device not selected.";
                DisplayData();
            }
        }
        /// <summary>
        /// write flash memory
        /// </summary>
        /// <param name="device"></param>
        public void WriteMemory(string device, string memory, string filename)
        {
            try
            {
                outputResult = "Writing " +  memory + "................";
                DisplayData();
                bool is328 = false;
                if (device.ToLower().Equals("atmega328"))
                {
                   // device = "atmega328p"; is328 = true;
                }
                avrdef = avrdudePathShort + device +
                    " -U " + memory + ":w:" + "\"" + filename + "\":i";

               // if (is328) 
                avrdef += " -F";
                ExecuteCommandAsync();
            }
            catch (Exception ex)
            {
                outputResult = "Could not write" + memory +  "memory.\n" + ex.Message;
                DisplayData();
            }
        }
        /// <summary>
        /// display error message
        /// </summary>
        /// <param name="error"></param>
        public void ErrorMessage(string error)
        {
            outputResult = error;
            DisplayData();
        }
        /// <summary>
        /// read memory
        /// </summary>
        /// <param name="device"></param>
        /// <param name="memory"></param>
        /// <param name="filename"></param>
        public void ReadMemory(string device, string memory, string filename)
        {
            try
            {
                outputResult = "Reading " +memory + "................";
                DisplayData();
                //avrdude -C avrdude.conf  -p ATMEGA32 -c nanoboard -U flash:r:"read.hex":i
                avrdef = avrdudePathShort + device +
                               "  -U " + memory + ":r:" + "\"" + filename+ "\":i";
                ExecuteCommandAsync();
            }
            catch (Exception ex)
            {
                outputResult = "Could not read" + memory + " memory.\n" + ex.Message;
                DisplayData();
            }
        }

        /// <summary>
        /// verify memory
        /// </summary>
        /// <param name="device"></param>
        /// <param name="memory"></param>
        public void VerifyMemory(string device, string memory, string filename)
        {
            try
            {
                outputResult = "Verifying " + memory + "  contents ................";
                DisplayData();
                avrdef = avrdudePathShort + device +
                            "  -U " + memory + ":v:" + "\"" + filename + "\":i";
                ExecuteCommandAsync();
            }
            catch (Exception ex)
            {
                outputResult = "Could not verify " + memory + "memory.\n" + ex.Message;
                DisplayData();
            }
        }
        /// <summary>
        /// program fuses
        /// </summary>
        /// <param name="device">device</param>
        /// <param name="efuse">extended fuse</param>
        /// <param name="hfuse">high fuse</param>
        /// <param name="lfuse">low fuse</param>
        public void ProgramFuses(string device, string efuse, string hfuse, string lfuse)
        {
            try
            {
                outputResult = "Writing fuses ................";
                DisplayData();
                string efusepg = "";
                if(!(device.ToLower().Equals("atmega32")))
                    efusepg = "  -U efuse:w:" + efuse + ":m"; 
                avrdef = avrdudePathShort + device +
                    " -u -e " +
                    efusepg + 
                    "  -U hfuse:w:" + hfuse + ":m" + 
                    "  -U lfuse:w:" + lfuse + ":m" +
                    "  -q -F";
                ExecuteCommandAsync();
            }
            catch (Exception ex)
            {
                outputResult = "Failed to write device fuses.\n" + ex.Message;
                DisplayData();
            }
        }
        /// <summary>
        /// program lock bits
        /// </summary>
        /// <param name="device">device</param>
        /// <param name="lbyte">lock bits</param>
        public void ProgramLockBits(string device, string lbyte)
        {
            try
            {
                outputResult = "Writing lock bits ................";
                DisplayData();
                avrdef = avrdudePathShort + device +
                    " -u " +
                    "  -U lock:w:" + lbyte + ":m" +
                    "  -q -F";
                ExecuteCommandAsync();
            }
            catch (Exception ex)
            {
                outputResult = "Failed to write device lock byte.\n" + ex.Message;
                DisplayData();
            }
        }
        /// <summary>
        /// Read lock bits.
        /// </summary>
        /// <param name="device"></param>
        public void ReadLockBits(String device)
        {
            try
            {
                outputResult = "Reading lock bits ................";
                DisplayData();
                avrdef = avrdudePathShort + device +
                    "  -U lock:r:" + "lb.xs:h" +
                    "  -q -F";
                ExecuteCommandSync();
                //ExecuteCommandAsync();
            }
            catch (Exception ex)
            {
                outputResult = "Failed to write device lock byte.\n" + ex.Message;
                DisplayData();
            }
        }
        /// <summary>
        /// read fuse bits.
        /// </summary>
        /// <param name="device"></param>
        public void ReadFuseBits(String device)
        {
            try
            {
                outputResult = "Reading fuse bits ................";
                DisplayData();
                avrdef = avrdudePathShort + device +
                    "  -U efuse:r:" + "ef.xs:h " +
                    "  -q -F";
                ExecuteCommandSync();
                avrdef = avrdudePathShort + device +
                    "  -U hfuse:r:" + "hf.xs:h  -U lfuse:r:" + "lf.xs:h" +
                    "  -q -F";
                ExecuteCommandSync();
                //ExecuteCommandAsync();
            }
            catch (Exception ex)
            {
                outputResult = "Failed to write device lock byte.\n" + ex.Message;
                DisplayData();
            }
        }
     #endregion
    }
}
