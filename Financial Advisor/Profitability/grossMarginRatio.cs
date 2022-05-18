﻿using System;
using System.Windows.Forms;

namespace Financial_Advisor
{
    public partial class grossMarginRatio : Form
    {
        public grossMarginRatio()
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
                float revenue = float.Parse(txt_revenue.Text);
                float cogs = float.Parse(txt_cogs.Text);
                float revenue1 = float.Parse(txt_revenue1.Text);
                label5.Text = $"{(revenue - cogs) / revenue1}";
                label5.Visible = true;
            }
            catch
            {
                MessageBox.Show("Please Enter Correct Values");
                txt_revenue.Text = txt_cogs.Text = txt_revenue1.Text = "";
            }
        }
        private void txt_percentage_Click(object sender, EventArgs e)
        {
            try
            {
                float revenue = float.Parse(txt_revenue.Text);
                float cogs = float.Parse(txt_cogs.Text);
                float revenue1 = float.Parse(txt_revenue1.Text);
                label5.Text = $"{((revenue - cogs) / revenue1) * 100}%";
                label5.Visible = true;
            }
            catch
            {
                MessageBox.Show("Please Enter Correct Values");
                txt_revenue.Text = txt_cogs.Text = txt_revenue1.Text = "";
            }
        }
        private void grossMarginRatio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_calc_Click(sender, e);
        }
    }
}
