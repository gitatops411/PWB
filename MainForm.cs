using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PWB
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Allocate column widths according to screen size

            DataGrid.Width  = Screen.PrimaryScreen.Bounds.Width;
            DataGrid.Columns[0].Width = (int) (DataGrid.Width * .33); // 33%
            DataGrid.Columns[3].Width = (int) (DataGrid.Width * .13); // 13%
            DataGrid.Columns[4].Width = (int) (DataGrid.Width * .28); // 28%
            DataGrid.Columns[1].Width = (int) (DataGrid.Width * .13); // 13%
            DataGrid.Columns[2].Width = (int) (DataGrid.Width * .13); // 13%
            LogErrorMessage("Pick Waves Batch Monitor Started");
            RefreshTimer_Tick(sender, e);
        }

        public static void LogErrorMessage(string ErrorMessage)
        {
            DateTime tempdate = DateTime.Now;

            using(StreamWriter logfile = File.AppendText("pwb.log"))
            {
                logfile.WriteLine($"{tempdate.ToString("yyyy.MMM.dd")} - {tempdate.ToString("H:mm:ss.fff")}");
                logfile.WriteLine($"{ErrorMessage}");
                logfile.WriteLine($"-------------------------------------------------");
            }
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {

            DateTime temptime = DateTime.Now;
            int hour    = temptime.Hour;
            int minute  = temptime.Minute;
            string ampm = "am";

            RefreshTimer.Enabled = false;

            // Prepare the date string to be easier on the eyes
            if(hour >= 12)
            {
                ampm = "pm";
                hour -= 12;
            }
            string datestr = String.Format("{0}:{1:D2} {2}", hour, minute, ampm);

            // Let's grab some data, trap connectivity issues (if any), and handle errors gracefully
            try
            {
                this.HJSPickWaveBatchesTableAdapter.Fill(this.Dataset.view_HJS_Pick_Wave_Batches);
                NetworkErrorMsg.Visible = NetworkRetrySecs.Visible = false;
                ClockDisplay.Text = datestr;
                this.RefreshTimer.Interval = 20000; // 20 seconds
            }

            catch(Exception ex)
            {
                NetworkErrorMsg.Text = "The network connection was lost or interrupted.";
                LogErrorMessage(NetworkErrorMsg.Text);
                NetworkErrorMsg.Text = "\r\n" + NetworkErrorMsg.Text + "\r\nA new connection attempt will occur in\r\n       seconds";
                NetworkErrorMsg.Visible = NetworkRetrySecs.Visible = true;

                for(int i = 30; i > 0; i--)
                {
                    NetworkRetrySecs.Text = i.ToString();
                    Refresh();
                    Thread.Sleep(1000);
                }
                NetworkRetrySecs.Visible = false;
                NetworkErrorMsg.Text = "\r\n\r\n... attempting to reconnect to the network ...";
                Refresh();
                this.RefreshTimer.Interval = 500; // .5 second delay before we try again
            }
            RefreshTimer.Enabled = true;
        }        
        private void ClockDisplay_Click(object sender, EventArgs e)
        {
            LogErrorMessage("Pick Waves Batch Monitor Terminated");
            Application.Exit();
        }
    }
}
