using System;
using System.Windows.Forms;

namespace Financial_Advisor
{
    public partial class equityRatio : Form
    {
        public equityRatio()
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
                float shareholder = float.Parse(txt_shareholder.Text);
                float assets = float.Parse(txt_assets.Text);
                label5.Text = $"{shareholder / assets}";
                label5.Visible = true;
            }
            catch
            {
                MessageBox.Show("Please Enter Correct Values");
                txt_shareholder.Text = txt_assets.Text = "";
            }
        }
        private void txt_percentage_Click(object sendr, EventArgs e)
        {
            try
            {
                float shareholder = float.Parse(txt_shareholder.Text);
                float assets = float.Parse(txt_assets.Text);
                label5.Text = $"{(shareholder / assets) * 100}%";
                label5.Visible = true;
            }
            catch
            {
                MessageBox.Show("Please Enter Correct Values");
                txt_shareholder.Text = txt_assets.Text = "";
            }
        }

        private void equityRatio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_calc_Click(sender, e);
        }
    }
}
