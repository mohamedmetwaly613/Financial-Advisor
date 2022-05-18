using System;
using System.Windows.Forms;

namespace Financial_Advisor
{
    public partial class timesInterestEarned_CashBasis_Ratio : Form
    {
        public timesInterestEarned_CashBasis_Ratio()
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
                float adjusted = float.Parse(txt_adjusted.Text);
                float interest = float.Parse(txt_interest.Text);
                label5.Text = $"{adjusted / interest}";
                label5.Visible = true;
            }
            catch
            {
                MessageBox.Show("Please Enter Correct Values");
                txt_adjusted.Text = txt_interest.Text = "";
            }
        }

        private void txt_percentage_Click(object sender, EventArgs e)
        {
            try
            {
                float adjusted = float.Parse(txt_adjusted.Text);
                float interest = float.Parse(txt_interest.Text);
                label5.Text = $"{(adjusted / interest) * 100}%";
                label5.Visible = true;
            }
            catch
            {
                MessageBox.Show("Please Enter Correct Values");
                txt_adjusted.Text = txt_interest.Text = "";
            }
        }

        private void timesInterestEarned_CashBasis_Ratio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_calc_Click(sender, e);
        }
    }
}
