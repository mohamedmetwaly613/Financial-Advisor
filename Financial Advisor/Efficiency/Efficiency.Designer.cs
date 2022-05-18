namespace Financial_Advisor
{
    partial class Efficiency
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
            this.lbl_ER = new System.Windows.Forms.Label();
            this.btn_HP = new System.Windows.Forms.Button();
            this.btn_ARTR = new System.Windows.Forms.Button();
            this.btn_ATR = new System.Windows.Forms.Button();
            this.btn_ITD = new System.Windows.Forms.Button();
            this.btn_ARD = new System.Windows.Forms.Button();
            this.btn_ITR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_ER
            // 
            this.lbl_ER.AutoSize = true;
            this.lbl_ER.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ER.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_ER.Location = new System.Drawing.Point(293, 50);
            this.lbl_ER.Name = "lbl_ER";
            this.lbl_ER.Size = new System.Drawing.Size(191, 31);
            this.lbl_ER.TabIndex = 0;
            this.lbl_ER.Text = "Efficiency Ratio";
            // 
            // btn_HP
            // 
            this.btn_HP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_HP.Location = new System.Drawing.Point(12, 12);
            this.btn_HP.Name = "btn_HP";
            this.btn_HP.Size = new System.Drawing.Size(101, 29);
            this.btn_HP.TabIndex = 5;
            this.btn_HP.Text = "Home";
            this.btn_HP.UseVisualStyleBackColor = true;
            this.btn_HP.Click += new System.EventHandler(this.btn_HP_Click);
            // 
            // btn_ARTR
            // 
            this.btn_ARTR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ARTR.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ARTR.Location = new System.Drawing.Point(94, 151);
            this.btn_ARTR.Name = "btn_ARTR";
            this.btn_ARTR.Size = new System.Drawing.Size(146, 52);
            this.btn_ARTR.TabIndex = 0;
            this.btn_ARTR.Text = "Accounts Receivable Turnover Ratio";
            this.btn_ARTR.UseVisualStyleBackColor = true;
            this.btn_ARTR.Click += new System.EventHandler(this.btn_ARTR_Click);
            // 
            // btn_ATR
            // 
            this.btn_ATR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ATR.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ATR.Location = new System.Drawing.Point(318, 226);
            this.btn_ATR.Name = "btn_ATR";
            this.btn_ATR.Size = new System.Drawing.Size(146, 52);
            this.btn_ATR.TabIndex = 2;
            this.btn_ATR.Text = "Asset Turnover Ratio";
            this.btn_ATR.UseVisualStyleBackColor = true;
            this.btn_ATR.Click += new System.EventHandler(this.btn_ATR_Click);
            // 
            // btn_ITD
            // 
            this.btn_ITD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ITD.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ITD.Location = new System.Drawing.Point(554, 299);
            this.btn_ITD.Name = "btn_ITD";
            this.btn_ITD.Size = new System.Drawing.Size(146, 52);
            this.btn_ITD.TabIndex = 4;
            this.btn_ITD.Text = "Inventory Turnover Days";
            this.btn_ITD.UseVisualStyleBackColor = true;
            this.btn_ITD.Click += new System.EventHandler(this.btn_ITD_Click);
            // 
            // btn_ARD
            // 
            this.btn_ARD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ARD.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ARD.Location = new System.Drawing.Point(94, 299);
            this.btn_ARD.Name = "btn_ARD";
            this.btn_ARD.Size = new System.Drawing.Size(146, 52);
            this.btn_ARD.TabIndex = 1;
            this.btn_ARD.Text = "Accounts Receivable Days";
            this.btn_ARD.UseVisualStyleBackColor = true;
            this.btn_ARD.Click += new System.EventHandler(this.btn_ARD_Click);
            // 
            // btn_ITR
            // 
            this.btn_ITR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ITR.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ITR.Location = new System.Drawing.Point(554, 151);
            this.btn_ITR.Name = "btn_ITR";
            this.btn_ITR.Size = new System.Drawing.Size(146, 52);
            this.btn_ITR.TabIndex = 3;
            this.btn_ITR.Text = "Inventory Turnover Ratio";
            this.btn_ITR.UseVisualStyleBackColor = true;
            this.btn_ITR.Click += new System.EventHandler(this.btn_ITR_Click);
            // 
            // Efficiency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ITR);
            this.Controls.Add(this.btn_ARD);
            this.Controls.Add(this.btn_ITD);
            this.Controls.Add(this.btn_ATR);
            this.Controls.Add(this.btn_ARTR);
            this.Controls.Add(this.btn_HP);
            this.Controls.Add(this.lbl_ER);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Efficiency";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Efficiency";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ER;
        private System.Windows.Forms.Button btn_HP;
        private System.Windows.Forms.Button btn_ARTR;
        private System.Windows.Forms.Button btn_ATR;
        private System.Windows.Forms.Button btn_ITD;
        private System.Windows.Forms.Button btn_ARD;
        private System.Windows.Forms.Button btn_ITR;
    }
}