using System;
using System.Windows.Forms;

namespace Financial_Advisor
{
    public partial class inventoryTurnoverDays : Form
    {
        public inventoryTurnoverDays()
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
                float inventory = float.Parse(txt_inventory.Text);
                label5.Text = $"{number / inventory}";
                label5.Visible = true;
            }
            catch
            {
                MessageBox.Show("Please Enter Correct Values");
                txt_number.Text = txt_inventory.Text = "";
            }
        }

        private void txt_percentage_Click(object sender, EventArgs e)
        {
            try
            {
                float number = float.Parse(txt_number.Text);
                float inventory = float.Parse(txt_inventory.Text);
                label5.Text = $"{(number / inventory) * 100}%";
                label5.Visible = true;
            }
            catch
            {
                MessageBox.Show("Please Enter Correct Values");
                txt_number.Text = txt_inventory.Text = "";
            }
        }

        private void inventoryTurnoverDays_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_calc_Click(sender, e);
        }
    }
}
