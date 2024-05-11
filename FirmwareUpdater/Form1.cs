using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Diagnostics;

namespace FirmwareUpdater
{
    public partial class UpdateDisplay : Form
    {
        string location = "";
        string datapath = "";
        string syspath = "";
        ListBox lst = new ListBox();
        public UpdateDisplay()
        {
            InitializeComponent();
        }

        private void UpdateDisplay_Load(object sender, EventArgs e)
        {
            if (Directory.Exists(Path.GetTempPath() + "\\windload") == false)
            {
                Directory.CreateDirectory(Path.GetTempPath() + "\\windload");
            }
            File.WriteAllText(Path.GetTempPath() + "\\windload\\chkdta.bat", Properties.Resources.chkdta);
            Process p = new Process();
            p.StartInfo.FileName = Path.GetTempPath() + "\\windload\\chkdta.bat";
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.StartInfo.CreateNoWindow = true;
            p.Start();
            datapath = File.ReadAllText("C:\\temporaryfolder\\path.txt");
            Directory.Delete("C:\\temporaryfolder", true);
            if (datapath =="")
            {
                Close();
            }
            datapath = datapath.Replace(";", "");
            datapath = datapath.Substring(0, datapath.Length - 2);
            syspath = File.ReadAllText(datapath + "\\Windowed\\locator.txt");
            finishTimer.Enabled = true;
        }

        private void FinishTimer_Tick(object sender, EventArgs e)
        {
            File.Copy(syspath + "\\Windowed OS.exe", syspath + "\\Windowed OS.exe.backup", true);
            File.Copy(datapath + "\\Windowed\\dload.exe", syspath + "\\Windowed OS.exe", true);
            File.WriteAllText(datapath + "\\Windowed\\updated.txt", "Update has finished successfully", System.Text.Encoding.ASCII);
            Process.Start(syspath + "\\Windowed OS.exe");
            this.Close();
        }

    }
}
