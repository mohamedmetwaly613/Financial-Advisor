using System;
using System.Windows.Forms;

namespace Financial_Advisor
{
    public partial class Leverage : Form
    {
        public Leverage()
        {
            InitializeComponent();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
            this.Close();
        }

        private void btn_DTER_Click(object sender, EventArgs e)
        {
            this.Hide();
            debtToEquityRatio debtToEquity = new debtToEquityRatio();
            debtToEquity.ShowDialog();
            this.Close();
        }

        private void btn_ER_Click(object sender, EventArgs e)
        {
            this.Hide();
            equityRatio equity = new equityRatio();
            equity.ShowDialog();
            this.Close();
        }

        private void btn_Dr_Click(object sender, EventArgs e)
        {
            this.Hide();
            debtRatio debt = new debtRatio();
            debt.ShowDialog();
            this.Close();
        }
    }
}
