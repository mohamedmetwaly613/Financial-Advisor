namespace Financial_Advisor
{
    partial class Valuation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_pter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ebitda = new System.Windows.Forms.Button();
            this.btn_ebit = new System.Windows.Forms.Button();
            this.btn_revenue = new System.Windows.Forms.Button();
            this.btn_HP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(280, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Multiples Valuation Ratios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(138, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Price Ratios";
            // 
            // btn_pter
            // 
            this.btn_pter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pter.Location = new System.Drawing.Point(142, 158);
            this.btn_pter.Name = "btn_pter";
            this.btn_pter.Size = new System.Drawing.Size(100, 36);
            this.btn_pter.TabIndex = 0;
            this.btn_pter.Text = "Price-to-Earnings Ratio";
            this.btn_pter.UseVisualStyleBackColor = true;
            this.btn_pter.Click += new System.EventHandler(this.btn_pter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(533, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enterprise Value Ratios";
            // 
            // btn_ebitda
            // 
            this.btn_ebitda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ebitda.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ebitda.Location = new System.Drawing.Point(590, 158);
            this.btn_ebitda.Name = "btn_ebitda";
            this.btn_ebitda.Size = new System.Drawing.Size(96, 49);
            this.btn_ebitda.TabIndex = 1;
            this.btn_ebitda.Text = "EV/EBITDA Ratio";
            this.btn_ebitda.UseVisualStyleBackColor = true;
            this.btn_ebitda.Click += new System.EventHandler(this.btn_ebitda_Click);
            // 
            // btn_ebit
            // 
            this.btn_ebit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ebit.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ebit.Location = new System.Drawing.Point(590, 230);
            this.btn_ebit.Name = "btn_ebit";
            this.btn_ebit.Size = new System.Drawing.Size(96, 40);
            this.btn_ebit.TabIndex = 2;
            this.btn_ebit.Text = "EV/EBIT Ratio";
            this.btn_ebit.UseVisualStyleBackColor = true;
            this.btn_ebit.Click += new System.EventHandler(this.btn_ebit_Click);
            // 
            // btn_revenue
            // 
            this.btn_revenue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_revenue.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_revenue.Location = new System.Drawing.Point(590, 299);
            this.btn_revenue.Name = "btn_revenue";
            this.btn_revenue.Size = new System.Drawing.Size(96, 47);
            this.btn_revenue.TabIndex = 3;
            this.btn_revenue.Text = "EV/Revenue Ratio";
            this.btn_revenue.UseVisualStyleBackColor = true;
            this.btn_revenue.Click += new System.EventHandler(this.btn_revenue_Click);
            // 
            // btn_HP
            // 
            this.btn_HP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_HP.Location = new System.Drawing.Point(12, 12);
            this.btn_HP.Name = "btn_HP";
            this.btn_HP.Size = new System.Drawing.Size(101, 29);
            this.btn_HP.TabIndex = 4;
            this.btn_HP.Text = "Home";
            this.btn_HP.UseVisualStyleBackColor = true;
            this.btn_HP.Click += new System.EventHandler(this.btn_HP_Click);
            // 
            // Valuation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(783, 395);
            this.Controls.Add(this.btn_HP);
            this.Controls.Add(this.btn_revenue);
            this.Controls.Add(this.btn_ebit);
            this.Controls.Add(this.btn_ebitda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_pter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Valuation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Valuation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_pter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ebitda;
        private System.Windows.Forms.Button btn_ebit;
        private System.Windows.Forms.Button btn_revenue;
        private System.Windows.Forms.Button btn_HP;
    }
}