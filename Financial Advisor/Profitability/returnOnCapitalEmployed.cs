using System;
using System.Windows.Forms;

namespace Financial_Advisor
{
    public partial class returnOnCapitalEmployed : Form
    {
        public returnOnCapitalEmployed()
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
            Profitability profitability = new Profitability();
            profitability.ShowDialog();
            this.Close();
        }
        private void btn_calc_Click(object sender, EventArgs e)
        {
            try
            {
                float ebit = float.Parse(txt_ebit.Text);
                float assets = float.Parse(txt_assets.Text);
                float liabilities = float.Parse(txt_liabilities.Text);
                label5.Text = $"{ebit / (assets - liabilities)}";
                label5.Visible = true;
            }
            catch
            {
                MessageBox.Show("Please Enter Correct Values");
                txt_ebit.Text = txt_assets.Text = txt_liabilities.Text = "";
            }
        }

        private void txt_percentage_Click(object sender, EventArgs e)
        {
            try
            {
                float ebit = float.Parse(txt_ebit.Text);
                float assets = float.Parse(txt_assets.Text);
                float liabilities = float.Parse(txt_liabilities.Text);
                label5.Text = $"{(ebit / (assets - liabilities)) * 100}%";
                label5.Visible = true;
            }
            catch
            {
                MessageBox.Show("Please Enter Correct Values");
                txt_ebit.Text = txt_assets.Text = txt_liabilities.Text = "";
            }
        }
        private void returnOnCapitalEmployed_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_calc_Click(sender, e);
        }
    }
}
