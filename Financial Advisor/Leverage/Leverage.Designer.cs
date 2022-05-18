namespace Financial_Advisor
{
    partial class Leverage
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
            this.btn_home = new System.Windows.Forms.Button();
            this.lbl_LR = new System.Windows.Forms.Label();
            this.btn_DTER = new System.Windows.Forms.Button();
            this.btn_ER = new System.Windows.Forms.Button();
            this.btn_Dr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_home
            // 
            this.btn_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_home.Location = new System.Drawing.Point(12, 12);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(101, 29);
            this.btn_home.TabIndex = 3;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // lbl_LR
            // 
            this.lbl_LR.AutoSize = true;
            this.lbl_LR.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LR.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_LR.Location = new System.Drawing.Point(298, 49);
            this.lbl_LR.Name = "lbl_LR";
            this.lbl_LR.Size = new System.Drawing.Size(186, 31);
            this.lbl_LR.TabIndex = 12;
            this.lbl_LR.Text = "Leverage Ratio";
            // 
            // btn_DTER
            // 
            this.btn_DTER.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DTER.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DTER.Location = new System.Drawing.Point(20, 192);
            this.btn_DTER.Name = "btn_DTER";
            this.btn_DTER.Size = new System.Drawing.Size(159, 51);
            this.btn_DTER.TabIndex = 0;
            this.btn_DTER.Text = "Debt-to-Equity Ratio";
            this.btn_DTER.UseVisualStyleBackColor = true;
            this.btn_DTER.Click += new System.EventHandler(this.btn_DTER_Click);
            // 
            // btn_ER
            // 
            this.btn_ER.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ER.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ER.Location = new System.Drawing.Point(304, 192);
            this.btn_ER.Name = "btn_ER";
            this.btn_ER.Size = new System.Drawing.Size(159, 51);
            this.btn_ER.TabIndex = 1;
            this.btn_ER.Text = "Equity Ratio";
            this.btn_ER.UseVisualStyleBackColor = true;
            this.btn_ER.Click += new System.EventHandler(this.btn_ER_Click);
            // 
            // btn_Dr
            // 
            this.btn_Dr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Dr.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dr.Location = new System.Drawing.Point(587, 192);
            this.btn_Dr.Name = "btn_Dr";
            this.btn_Dr.Size = new System.Drawing.Size(159, 51);
            this.btn_Dr.TabIndex = 2;
            this.btn_Dr.Text = "Debt Ratio";
            this.btn_Dr.UseVisualStyleBackColor = true;
            this.btn_Dr.Click += new System.EventHandler(this.btn_Dr_Click);
            // 
            // Leverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 374);
            this.Controls.Add(this.btn_Dr);
            this.Controls.Add(this.btn_ER);
            this.Controls.Add(this.btn_DTER);
            this.Controls.Add(this.lbl_LR);
            this.Controls.Add(this.btn_home);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Leverage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leverage Ratio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Label lbl_LR;
        private System.Windows.Forms.Button btn_DTER;
        private System.Windows.Forms.Button btn_ER;
        private System.Windows.Forms.Button btn_Dr;
    }
}