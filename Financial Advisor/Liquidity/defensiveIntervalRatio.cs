using System;
using System.Windows.Forms;

namespace Financial_Advisor
{
    public partial class defensiveIntervalRatio : Form
    {
        public defensiveIntervalRatio()
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
                float assets = float.Parse(txt_assets.Text);
                float expenditures = float.Parse(txt_expenditures.Text);
                label5.Text = $"{assets / expenditures}";
                label5.Visible = true;
            }
            catch
            {
                MessageBox.Show("Please Enter Correct Values");
                txt_assets.Text = txt_expenditures.Text = "";
            }
        }

        private void txt_percentage_Click(object sender, EventArgs e)
        {
            try
            {
                float assets = float.Parse(txt_assets.Text);
                float expenditures = float.Parse(txt_expenditures.Text);
                label5.Text = $"{(assets / expenditures) * 100}%";
                label5.Visible = true;
            }
            catch
            {
                MessageBox.Show("Please Enter Correct Values");
                txt_assets.Text = txt_expenditures.Text = "";
            }
        }

        private void defensiveIntervalRatio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_calc_Click(sender, e);
        }
    }
}
