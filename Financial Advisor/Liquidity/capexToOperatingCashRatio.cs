using System;
using System.Windows.Forms;

namespace Financial_Advisor
{
    public partial class capexToOperatingCashRatio : Form
    {
        public capexToOperatingCashRatio()
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
                float cash = float.Parse(txt_cash.Text);
                float capital = float.Parse(txt_capital.Text);
                label5.Text = $"{cash / capital}";
                label5.Visible = true;
            }
            catch
            {
                MessageBox.Show("Please Enter Correct Values");
                txt_cash.Text = txt_capital.Text = "";
            }
        }

        private void txt_percentage_Click(object sender, EventArgs e)
        {
            try
            {
                float cash = float.Parse(txt_cash.Text);
                float capital = float.Parse(txt_capital.Text);
                label5.Text = $"{(cash / capital) * 100}%";
                label5.Visible = true;
            }
            catch
            {
                MessageBox.Show("Please Enter Correct Values");
                txt_cash.Text = txt_capital.Text = "";
            }
        }

        private void capexToOperatingCashRatio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_calc_Click(sender, e);
        }
    }
}
