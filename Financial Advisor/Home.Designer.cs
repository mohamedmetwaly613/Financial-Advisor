namespace Financial_Advisor
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_profitability = new System.Windows.Forms.Button();
            this.btn_leverage = new System.Windows.Forms.Button();
            this.btn_efficiency = new System.Windows.Forms.Button();
            this.btn_liquidity = new System.Windows.Forms.Button();
            this.btn_valuation = new System.Windows.Forms.Button();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_profitability
            // 
            this.btn_profitability.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_profitability.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_profitability.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_profitability.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_profitability.Location = new System.Drawing.Point(56, 207);
            this.btn_profitability.Name = "btn_profitability";
            this.btn_profitability.Size = new System.Drawing.Size(155, 71);
            this.btn_profitability.TabIndex = 0;
            this.btn_profitability.Text = "Profitability";
            this.btn_profitability.UseVisualStyleBackColor = true;
            this.btn_profitability.Click += new System.EventHandler(this.btn_profitability_Click);
            // 
            // btn_leverage
            // 
            this.btn_leverage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_leverage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_leverage.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_leverage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_leverage.Location = new System.Drawing.Point(406, 207);
            this.btn_leverage.Name = "btn_leverage";
            this.btn_leverage.Size = new System.Drawing.Size(139, 71);
            this.btn_leverage.TabIndex = 1;
            this.btn_leverage.Text = "Leverage";
            this.btn_leverage.UseVisualStyleBackColor = true;
            this.btn_leverage.Click += new System.EventHandler(this.btn_leverage_Click);
            // 
            // btn_efficiency
            // 
            this.btn_efficiency.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_efficiency.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_efficiency.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_efficiency.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_efficiency.Location = new System.Drawing.Point(745, 207);
            this.btn_efficiency.Name = "btn_efficiency";
            this.btn_efficiency.Size = new System.Drawing.Size(138, 71);
            this.btn_efficiency.TabIndex = 2;
            this.btn_efficiency.Text = "Efficiency";
            this.btn_efficiency.UseVisualStyleBackColor = true;
            this.btn_efficiency.Click += new System.EventHandler(this.btn_efficiency_Click);
            // 
            // btn_liquidity
            // 
            this.btn_liquidity.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_liquidity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_liquidity.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_liquidity.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_liquidity.Location = new System.Drawing.Point(228, 305);
            this.btn_liquidity.Name = "btn_liquidity";
            this.btn_liquidity.Size = new System.Drawing.Size(155, 66);
            this.btn_liquidity.TabIndex = 3;
            this.btn_liquidity.Text = "Liquidity";
            this.btn_liquidity.UseVisualStyleBackColor = true;
            this.btn_liquidity.Click += new System.EventHandler(this.btn_liquidity_Click);
            // 
            // btn_valuation
            // 
            this.btn_valuation.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_valuation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_valuation.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_valuation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_valuation.Location = new System.Drawing.Point(573, 307);
            this.btn_valuation.Name = "btn_valuation";
            this.btn_valuation.Size = new System.Drawing.Size(143, 64);
            this.btn_valuation.TabIndex = 4;
            this.btn_valuation.Text = "Valuation";
            this.btn_valuation.UseVisualStyleBackColor = true;
            this.btn_valuation.Click += new System.EventHandler(this.btn_valuation_Click);
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Microsoft JhengHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_welcome.Location = new System.Drawing.Point(281, 87);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(417, 36);
            this.lbl_welcome.TabIndex = 5;
            this.lbl_welcome.Text = "Welcome to Financial Advisor";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(926, 492);
            this.Controls.Add(this.lbl_welcome);
            this.Controls.Add(this.btn_valuation);
            this.Controls.Add(this.btn_liquidity);
            this.Controls.Add(this.btn_efficiency);
            this.Controls.Add(this.btn_leverage);
            this.Controls.Add(this.btn_profitability);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Financial Advisor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_profitability;
        private System.Windows.Forms.Button btn_leverage;
        private System.Windows.Forms.Button btn_efficiency;
        private System.Windows.Forms.Button btn_liquidity;
        private System.Windows.Forms.Button btn_valuation;
        private System.Windows.Forms.Label lbl_welcome;
    }
}

