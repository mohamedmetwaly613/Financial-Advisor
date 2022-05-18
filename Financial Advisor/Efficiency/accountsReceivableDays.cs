using System;
using System.Windows.Forms;

namespace Financial_Advisor
{
    public partial class accountsReceivableDays : Form
    {
        public accountsReceivableDays()
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
            Efficiency efficiency = new Efficiency();
            efficiency.ShowDialog();
            this.Close();
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            try
            {
                float number = float.Parse(txt_number.Text);
                float account = float.Parse(txt_account.Text);
                label5.Text = $"{number / account}";
                label5.Visible = true;
            }
            catch
            {
                MessageBox.Show("Please Enter Correct Values");
                txt_number.Text = txt_account.Text = "";
            }
        }

        private void txt_percentage_Click(object sender, EventArgs e)
        {
            try
            {
                float number = float.Parse(txt_number.Text);
                float account = float.Parse(txt_account.Text);
                label5.Text = $"{(number / account) * 100}%";
                label5.Visible = true;
            }
            catch
            {
                MessageBox.Show("Please Enter Correct Values");
                txt_number.Text = txt_account.Text = "";
            }
        }

        private void accountsReceivableDays_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_calc_Click(sender, e);
        }
    }
}
