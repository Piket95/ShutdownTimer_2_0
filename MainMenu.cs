using System;
using System.Windows.Forms;

namespace ShutdownTimer_2_0
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnCountdown_Click(object sender, EventArgs e)
        {
            Timer timer = new Timer(this);
            timer.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
