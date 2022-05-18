using System;
using System.Windows.Forms;

namespace Financial_Advisor
{
    public partial class Efficiency : Form
    {
        public Efficiency()
        {
            InitializeComponent();
        }

        private void btn_HP_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
            this.Close();
        }

        private void btn_ARTR_Click(object sender, EventArgs e)
        {
            this.Hide();
            accountsReceivableTurnoverRatio accounts = new accountsReceivableTurnoverRatio();
            accounts.ShowDialog();
            this.Close();
        }

        private void btn_ARD_Click(object sender, EventArgs e)
        {
            this.Hide();
            accountsReceivableDays receivableDays = new accountsReceivableDays();
            receivableDays.ShowDialog();
            this.Close();
        }

        private void btn_ATR_Click(object sender, EventArgs e)
        {
            this.Hide();
            assetTurnoverRatio asset = new assetTurnoverRatio();
            asset.ShowDialog();
            this.Close();
        }

        private void btn_ITR_Click(object sender, EventArgs e)
        {
            this.Hide();
            inventoryTurnoverRatio inventory = new inventoryTurnoverRatio();
            inventory.ShowDialog();
            this.Close();
        }

        private void btn_ITD_Click(object sender, EventArgs e)
        {
            this.Hide();
            inventoryTurnoverDays turnoverDays = new inventoryTurnoverDays();
            turnoverDays.ShowDialog();
            this.Close();
        }
    }
}
