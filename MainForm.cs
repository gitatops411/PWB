using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
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
            RefreshTimer_Tick(sender, e);
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {

            DateTime temptime = DateTime.Now;
            int hour    = temptime.Hour;
            int minute  = temptime.Minute;
            string ampm = "am";

            RefreshTimer.Enabled = false;
            if(hour >= 12)
            {
                ampm = "pm";
                hour -= 12;
            }
            string datestr = String.Format("{0}:{1:D2} {2}", hour, minute, ampm);

            try
            {
                this.HJSPickWaveBatchesTableAdapter.Fill(this.Dataset.view_HJS_Pick_Wave_Batches);
                NetworkErrorMsg.Visible = NetworkRetrySecs.Visible = false;
                ClockDisplay.Text = datestr;
                this.RefreshTimer.Interval = 20000; /* 20 seconds */
            }

            catch(Exception ex)
            {
                NetworkErrorMsg.Text = "\r\nThe network connection was lost or interrupted.\r\nA new connection attempt will occur in\r\n       seconds";
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
                this.RefreshTimer.Interval = 500; /*   1/2 second   */
            }
            RefreshTimer.Enabled = true;
        }        
        private void ClockDisplay_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
