using System;
using System.Windows.Forms;

namespace Financial_Advisor
{
    public partial class priceToEarningsRatio : Form
    {
        public priceToEarningsRatio()
        {
            InitializeComponent();
            label5.Visible = false;
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
            this.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Valuation valuation = new Valuation();
            valuation.ShowDialog();
            this.Close();
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            try
            {
                float share = float.Parse(txt_share.Text);
                float earnings = float.Parse(txt_earnings.Text);
                label5.Text = $"{share / earnings}";
                label5.Visible = true;
            }
            catch
            {
                MessageBox.Show("Please Enter Correct Values");
                txt_share.Text = txt_earnings.Text = "";
            }
        }

        private void txt_percentage_Click(object sender, EventArgs e)
        {
            try
            {
                float share = float.Parse(txt_share.Text);
                float earnings = float.Parse(txt_earnings.Text);
                label5.Text = $"{(share / earnings) * 100}%";
                label5.Visible = true;
            }
            catch
            {
                MessageBox.Show("Please Enter Correct Values");
                txt_share.Text = txt_earnings.Text = "";
            }
        }

        private void priceToEarningsRatio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_calc_Click(sender, e);
        }
    }
}
