using System;
using System.Windows.Forms;

namespace Financial_Advisor
{
    public partial class Profitability : Form
    {
        public Profitability()
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

        private void btn_ROE_Click(object sender, EventArgs e)
        {
            this.Hide();
            returnOnEquity returnOnEqulity = new returnOnEquity();
            returnOnEqulity.ShowDialog();
            this.Close();
        }
        private void btn_ROA_Click(object sender, EventArgs e)
        {
            this.Hide();
            returnOnAssets returnOnAssets = new returnOnAssets();
            returnOnAssets.ShowDialog();
            this.Close();
        }

        private void btn_ROCE_Click(object sender, EventArgs e)
        {
            this.Hide();
            returnOnCapitalEmployed returnOnCapital = new returnOnCapitalEmployed();
            returnOnCapital.ShowDialog();
            this.Close();
        }

        private void btn_GMR_Click(object sender, EventArgs e)
        {
            this.Hide();
            grossMarginRatio grossMargin = new grossMarginRatio();
            grossMargin.ShowDialog();
            this.Close();
        }

        private void btn_OPM_Click(object sender, EventArgs e)
        {
            this.Hide();
            operatingProfitMargin operatingProfit = new operatingProfitMargin();
            operatingProfit.ShowDialog();
            this.Close();
        }

        private void btn_NPM_Click(object sender, EventArgs e)
        {
            this.Hide();
            netProfitMargin netProfit = new netProfitMargin();
            netProfit.ShowDialog();
            this.Close();
        }
    }
}