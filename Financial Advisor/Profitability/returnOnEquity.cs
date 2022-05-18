using System;
using System.Windows.Forms;

namespace Financial_Advisor
{
    public partial class returnOnEquity : Form
    {
        public returnOnEquity()
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
                float net = float.Parse(txt_net.Text);
                float shareholders = float.Parse(txt_shareholders.Text);
                label5.Text = $"{net / shareholders}";
                label5.Visible = true;
            }
            catch
            {
                MessageBox.Show("Please Enter Correct Values");
                txt_net.Text = txt_shareholders.Text = "";
            }
        }

        private void txt_percentage_Click(object sendr, EventArgs e)
        {
            try
            {
                float net = float.Parse(txt_net.Text);
                float shareholders = float.Parse(txt_shareholders.Text);
                label5.Text = $"{(net / shareholders) * 100}%";
                label5.Visible = true;
            }
            catch
            {
                MessageBox.Show("Please Enter Correct Values");
                txt_net.Text = txt_shareholders.Text = "";
            }
        }
        private void returnOnEqulity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_calc_Click(sender, e);
        }
    }
}