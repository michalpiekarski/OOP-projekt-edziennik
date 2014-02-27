using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Dziennik_elektroniczny.Formularze
{
    public partial class backgroundWorker : Form
    {
        string b1Text = "";
        string b2Text = "";
        bool hardWorkIsRunning = false;
        public backgroundWorker()
        {
            InitializeComponent();
        }

        private void DoSomeWork(object sender, DoWorkEventArgs e)
        {
            HardWork();
        }

        private void WorkCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pb.Value = 100;
            pb.Visible = false;
            MessageBox.Show("Background work completed", "Completed", MessageBoxButtons.OK);
            button1.Text = b1Text;
            button1.Enabled = true;
        }

        private void RunBW(object sender, EventArgs e)
        {
            b1Text = button1.Text;
            button1.Text = "Running background worker...";
            button1.Enabled = false;
            pb.Value = 0;
            pb.Visible = true;
            bw.RunWorkerAsync();
            while (bw.IsBusy)
            {
                pb.Increment(1);
                Application.DoEvents();
            }
        }

        private void RunTask(object sender, EventArgs e)
        {
            b2Text = button2.Text;
            button2.Text = "Doing some hard work...";
            button2.Enabled = false;
            pb.Value = 0;
            pb.Visible = true;
            HardWork();
            while (hardWorkIsRunning)
            {
                pb.Increment(1);
                Application.DoEvents();
            }
            pb.Value = 100;
            pb.Visible = false;
            MessageBox.Show("HARD work completed", "Completed", MessageBoxButtons.OK);
            button2.Text = b2Text;
            button2.Enabled = true;
        }
        private void HardWork()
        {
            hardWorkIsRunning = true;
            Thread.Sleep(5000);
            hardWorkIsRunning = false;
        }
    }
}
