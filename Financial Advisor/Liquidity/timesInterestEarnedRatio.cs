using System;
using System.Windows.Forms;

namespace Financial_Advisor
{
    public partial class timesInterestEarnedRatio : Form
    {
        public timesInterestEarnedRatio()
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
            Liquidity liquidity = new Liquidity();
            liquidity.ShowDialog();
            this.Close();
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            try
            {
                float earnings = float.Parse(txt_earnings.Text);
                float interest = float.Parse(txt_interest.Text);
                label5.Text = $"{earnings / interest}";
                label5.Visible = true;
            }
            catch
            {
                MessageBox.Show("Please Enter Correct Values");
                txt_earnings.Text = txt_interest.Text = "";
            }
        }

        private void txt_percentage_Click(object sender, EventArgs e)
        {
            try
            {
                float earnings = float.Parse(txt_earnings.Text);
                float interest = float.Parse(txt_interest.Text);
                label5.Text = $"{(earnings / interest) * 100}%";
                label5.Visible = true;
            }
            catch
            {
                MessageBox.Show("Please Enter Correct Values");
                txt_earnings.Text = txt_interest.Text = "";
            }
        }
        private void timesInterestEarnedRatio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_calc_Click(sender, e);
        }
    }
}
