using System;
using System.Windows.Forms;

namespace Financial_Advisor
{
    public partial class debtToEquityRatio : Form
    {
        public debtToEquityRatio()
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
            Leverage leverage = new Leverage();
            leverage.ShowDialog();
            this.Close();
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            try
            {
                float _short = float.Parse(txt_short.Text);
                float _long = float.Parse(txt_long.Text);
                float _fixed = float.Parse(txt_fixed.Text);
                float shareholder = float.Parse(txt_shareholder.Text);
                label5.Text = $"{(_short + _long + _fixed) / shareholder}";
                label5.Visible = true;
            }
            catch
            {
                MessageBox.Show("Please Enter Correct Values");
                txt_short.Text = txt_long.Text = txt_fixed.Text = txt_shareholder.Text= "";
            }
        }

        private void txt_percentage_Click(object sender, EventArgs e)
        {
            try
            {
                float _short = float.Parse(txt_short.Text);
                float _long = float.Parse(txt_long.Text);
                float _fixed = float.Parse(txt_fixed.Text);
                float shareholder = float.Parse(txt_shareholder.Text);
                label5.Text = $"{((_short + _long + _fixed) / shareholder) * 100}%";
                label5.Visible = true;
            }
            catch
            {
                MessageBox.Show("Please Enter Correct Values");
                txt_short.Text = txt_long.Text = txt_fixed.Text = txt_shareholder.Text = "";
            }
        }
        private void debtToEquityRatio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_calc_Click(sender, e);
        }
    }
}
