using System;
using System.Windows.Forms;

namespace Financial_Advisor
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private void btn_profitability_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profitability profitability = new Profitability();
            profitability.ShowDialog();
            this.Close();
        }
        private void btn_leverage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Leverage leverage = new Leverage();
            leverage.ShowDialog();
            this.Close();
        }

        private void btn_efficiency_Click(object sender, EventArgs e)
        {
            this.Hide();
            Efficiency efficiency = new Efficiency();
            efficiency.ShowDialog();
            this.Close();
        }

        private void btn_liquidity_Click(object sender, EventArgs e)
        {
            this.Hide();
            Liquidity liquidity = new Liquidity();
            liquidity.ShowDialog();
            this.Close ();
        }
        private void btn_valuation_Click(object sender, EventArgs e)
        {
            this.Hide();
            Valuation valuation = new Valuation();
            valuation.ShowDialog();
            this.Close();
        }
    }
}