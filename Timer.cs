using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ShutdownTimer_2_0
{
    public partial class Timer : Form
    {
        private Form origin;
        private int hours = 0;
        private int minutes = 0;
        private int seconds = 0;

        public Timer(Form origin)
        {
            InitializeComponent();
            this.origin = origin;

            for (int i = 0; i <= 59; i++)
            {
                String number = i.ToString();

                if (i < 10)
                {
                    number = "0" + number;
                }

                if (i <= 23)
                {
                    this.cboHours.Items.Add(number);
                }

                this.cboMinutes.Items.Add(number);
                this.cboSeconds.Items.Add(number);
            }

            cboHours.SelectedIndex = 0;
            cboMinutes.SelectedIndex = 0;
            cboSeconds.SelectedIndex = 0;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            origin.Show();
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.hours = int.Parse(cboHours.Text);
            this.minutes = int.Parse(cboMinutes.Text);
            this.seconds = int.Parse(cboSeconds.Text);

            if (this.hours > 23 || this.minutes > 59 || this.seconds > 59)
            {
                MessageBox.Show("Die eingebenen Zeiten haben nicht das korrekte Format. Bitte geben Sie valide Werte ein!",
                    "Falsche Werte in der Auswahl!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
            else
            {
                btnConfirm.Enabled = false;
                cboHours.Enabled = false;
                cboMinutes.Enabled = false;
                cboSeconds.Enabled = false;
                btnChange.Enabled = true;
                btnStart.Enabled = true;

                updateTimeLabels();
            }

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            btnConfirm.Enabled = true;
            cboHours.Enabled = true;
            cboMinutes.Enabled = true;
            cboSeconds.Enabled = true;
            btnChange.Enabled = false;
            btnStart.Enabled = false;
            btnAbort.Enabled = false;

            this.hours = 0;
            this.minutes = 0;
            this.seconds = 0;

            updateTimeLabels();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(seconds > 0)
            {
                seconds--;
            }
            else if (seconds == 0 && minutes > 0)
            {
                seconds = 59;
                minutes--;
            }
            else if(seconds == 0 && minutes == 0 && hours > 0)
            {
                seconds = 59;
                minutes = 59;
                hours--;
            }
            else
            {

                //Process.Start("Shutdown", "-s -t 10");

                ProcessStartInfo psi = new ProcessStartInfo("shutdown", "-s -t 10");
                psi.CreateNoWindow = true;
                psi.UseShellExecute = false;
                Process.Start(psi);

                timer1.Stop();
                return;
            }

            updateTimeLabels();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();

            btnStart.Enabled = false;
            btnAbort.Enabled = false;
            btnPause.Enabled = true;
        }

        private void updateTimeLabels()
        {
            _ = this.hours < 10 ? lblHours.Text = "0" + this.hours : lblHours.Text = this.hours.ToString();
            _ = this.minutes < 10 ? lblMinutes.Text = "0" + this.minutes : lblMinutes.Text = this.minutes.ToString();
            _ = this.seconds < 10 ? lblSeconds.Text = "0" + this.seconds : lblSeconds.Text = this.seconds.ToString();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            btnPause.Enabled = false;
            btnStart.Enabled = true;
            btnAbort.Enabled = true;
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            btnChange_Click(null, null);
        }
    }
}
