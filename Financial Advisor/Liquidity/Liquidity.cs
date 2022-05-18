using System;
using System.Windows.Forms;

namespace Financial_Advisor
{
    public partial class Liquidity : Form
    {
        public Liquidity()
        {
            InitializeComponent();
        }

        private void btn_HP_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
            this.Close();
        }

        private void btn_cr_Click(object sender, EventArgs e)
        {
            this.Hide();
            currentRatio current = new currentRatio();
            current.ShowDialog();
            this.Close();
        }

        private void btn_qr_Click(object sender, EventArgs e)
        {
            this.Hide();
            quickRatio quick = new quickRatio();
            quick.ShowDialog();
            this.Close();
        }

        private void btn_cashr_Click(object sender, EventArgs e)
        {
            this.Hide();
            cashRatio cash = new cashRatio();
            cash.ShowDialog();
            this.Close();
        }

        private void btn_dir_Click(object sender, EventArgs e)
        {
            this.Hide();
            defensiveIntervalRatio defensive = new defensiveIntervalRatio();
            defensive.ShowDialog();
            this.Close();
        }

        private void btn_tier_Click(object sender, EventArgs e)
        {
            this.Hide();
            timesInterestEarnedRatio times = new timesInterestEarnedRatio();
            times.ShowDialog();
            this.Close();
        }

        private void btn_tiecbr_Click(object sender, EventArgs e)
        {
            this.Hide();
            timesInterestEarned_CashBasis_Ratio timesInterest = new timesInterestEarned_CashBasis_Ratio();
            timesInterest.ShowDialog();
            this.Close();
        }

        private void btn_ctocr_Click(object sender, EventArgs e)
        {
            this.Hide();
            capexToOperatingCashRatio capex = new capexToOperatingCashRatio();
            capex.ShowDialog();
            this.Close();
        }

        private void btn_ocfr_Click(object sender, EventArgs e)
        {
            this.Hide();
            operatingCashFlowRatio operating = new operatingCashFlowRatio();
            operating.ShowDialog();
            this.Close();
        }
    }
}
