using System;
using System.Windows.Forms;

namespace Financial_Advisor
{
    public partial class Valuation : Form
    {
        public Valuation()
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

        private void btn_pter_Click(object sender, EventArgs e)
        {
            this.Hide();
            priceToEarningsRatio price = new priceToEarningsRatio();
            price.ShowDialog();
            this.Close();
        }

        private void btn_ebitda_Click(object sender, EventArgs e)
        {
            this.Hide();
            evEbitdaRatio ev = new evEbitdaRatio();
            ev.ShowDialog();
            this.Close();
        }

        private void btn_ebit_Click(object sender, EventArgs e)
        {
            this.Hide();
            evEbitRatio evEbit = new evEbitRatio();
            evEbit.ShowDialog();
            this.Close();
        }

        private void btn_revenue_Click(object sender, EventArgs e)
        {
            this.Hide();
            evRevenueRatio evRevenue = new evRevenueRatio();
            evRevenue.ShowDialog();
            this.Close();
        }
    }
}
