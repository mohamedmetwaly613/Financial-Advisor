using System;
using System.Windows.Forms;

namespace Financial_Advisor
{
    public partial class accountsReceivableTurnoverRatio : Form
    {
        public accountsReceivableTurnoverRatio()
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
                float net = float.Parse(txt_net.Text);
                float average = float.Parse(txt_average.Text);
                label5.Text = $"{net / average}";
                label5.Visible = true;
            }
            catch
            {
                MessageBox.Show("Please Enter Correct Values");
                txt_net.Text = txt_average.Text = "";
            }
        }

        private void txt_percentage_Click(object sender, EventArgs e)
        {
            try
            {
                float net = float.Parse(txt_net.Text);
                float average = float.Parse(txt_average.Text);
                label5.Text = $"{(net / average) * 100}%";
                label5.Visible = true;
            }
            catch
            {
                MessageBox.Show("Please Enter Correct Values");
                txt_net.Text = txt_average.Text = "";
            }
        }

        private void accountsReceivableTurnoverRatio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_calc_Click(sender, e);
        }
    }
}
