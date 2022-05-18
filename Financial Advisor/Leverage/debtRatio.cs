using System;
using System.Windows.Forms;

namespace Financial_Advisor
{
    public partial class debtRatio : Form
    {
        public debtRatio()
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
                float stdept = float.Parse(txt_stdept.Text);
                float ltdept = float.Parse(txt_ltdept.Text);
                float assets = float.Parse(txt_assets.Text);
                label5.Text = $"{(stdept + ltdept) / assets}";
                label5.Visible = true;
            }
            catch
            {
                MessageBox.Show("Please Enter Correct Values");
                txt_assets.Text = txt_stdept.Text = txt_ltdept.Text = "";
            }
        }

        private void txt_percentage_Click(object sender, EventArgs e)
        {
            try
            {
                float stdept = float.Parse(txt_stdept.Text);
                float ltdept = float.Parse(txt_ltdept.Text);
                float assets = float.Parse(txt_assets.Text);
                label5.Text = $"{((stdept + ltdept) / assets) * 100}%";
                label5.Visible = true;
            }
            catch
            {
                MessageBox.Show("Please Enter Correct Values");
                txt_assets.Text = txt_stdept.Text = txt_ltdept.Text = "";
            }
        }
        private void debtRatio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_calc_Click(sender, e);
        }
    }
}