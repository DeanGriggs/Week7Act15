namespace Lucky_Number_ACT15
{
    partial class Form2
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
            this.LBL_num = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBL_num
            // 
            this.LBL_num.AutoSize = true;
            this.LBL_num.BackColor = System.Drawing.Color.Transparent;
            this.LBL_num.Font = new System.Drawing.Font("Broadway", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBL_num.Location = new System.Drawing.Point(177, 264);
            this.LBL_num.Name = "LBL_num";
            this.LBL_num.Size = new System.Drawing.Size(376, 109);
            this.LBL_num.TabIndex = 0;
            this.LBL_num.Text = "label1";
            this.LBL_num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Honey Script", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(94, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 63);
            this.label2.TabIndex = 1;
            this.label2.Text = "Your Lucky Number Is:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lucky_Number_ACT15.Properties.Resources.Untitled;
            this.ClientSize = new System.Drawing.Size(555, 502);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LBL_num);
            this.MaximumSize = new System.Drawing.Size(571, 541);
            this.MinimumSize = new System.Drawing.Size(571, 541);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LBL_num;
        private Label label2;
    }
}