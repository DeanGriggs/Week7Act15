namespace Lucky_Number_ACT15
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TB_age = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.CB_Day = new System.Windows.Forms.ComboBox();
            this.CB_month = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TB_age
            // 
            this.TB_age.Location = new System.Drawing.Point(28, 58);
            this.TB_age.Name = "TB_age";
            this.TB_age.Size = new System.Drawing.Size(149, 23);
            this.TB_age.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Year You Were Born:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Birthday Month:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Current Day:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "What\'s My Lucky Number?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CB_Day
            // 
            this.CB_Day.FormattingEnabled = true;
            this.CB_Day.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.CB_Day.Location = new System.Drawing.Point(28, 174);
            this.CB_Day.Name = "CB_Day";
            this.CB_Day.Size = new System.Drawing.Size(149, 23);
            this.CB_Day.TabIndex = 7;
            // 
            // CB_month
            // 
            this.CB_month.FormattingEnabled = true;
            this.CB_month.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "Jun",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.CB_month.Location = new System.Drawing.Point(28, 114);
            this.CB_month.Name = "CB_month";
            this.CB_month.Size = new System.Drawing.Size(149, 23);
            this.CB_month.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 310);
            this.Controls.Add(this.CB_month);
            this.Controls.Add(this.CB_Day);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_age);
            this.MaximumSize = new System.Drawing.Size(236, 349);
            this.MinimumSize = new System.Drawing.Size(236, 349);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lucky Number";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TB_age;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private ComboBox CB_Day;
        private ComboBox CB_month;
    }
}