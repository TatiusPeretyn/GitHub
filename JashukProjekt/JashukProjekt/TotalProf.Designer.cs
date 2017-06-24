namespace JashukProjekt
{
    partial class TotalProf
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.balance = new System.Windows.Forms.NumericUpDown();
            this.funds = new System.Windows.Forms.NumericUpDown();
            this.capital = new System.Windows.Forms.NumericUpDown();
            this.total = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.balance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capital)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.total)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Total";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Balance income:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Averaged value of principal occupational funds:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Averaged value of working capital:";
            // 
            // balance
            // 
            this.balance.DecimalPlaces = 2;
            this.balance.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.balance.Location = new System.Drawing.Point(181, 21);
            this.balance.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(91, 20);
            this.balance.TabIndex = 5;
            this.balance.ThousandsSeparator = true;
            // 
            // funds
            // 
            this.funds.DecimalPlaces = 2;
            this.funds.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.funds.Location = new System.Drawing.Point(181, 82);
            this.funds.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.funds.Name = "funds";
            this.funds.Size = new System.Drawing.Size(91, 20);
            this.funds.TabIndex = 6;
            this.funds.ThousandsSeparator = true;
            // 
            // capital
            // 
            this.capital.DecimalPlaces = 2;
            this.capital.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.capital.Location = new System.Drawing.Point(181, 132);
            this.capital.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.capital.Name = "capital";
            this.capital.Size = new System.Drawing.Size(91, 20);
            this.capital.TabIndex = 7;
            this.capital.ThousandsSeparator = true;
            // 
            // total
            // 
            this.total.DecimalPlaces = 2;
            this.total.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.total.Location = new System.Drawing.Point(96, 238);
            this.total.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(91, 20);
            this.total.TabIndex = 8;
            this.total.ThousandsSeparator = true;
            // 
            // TotalProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.total);
            this.Controls.Add(this.capital);
            this.Controls.Add(this.funds);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TotalProf";
            this.Text = "Total Profitability";
            ((System.ComponentModel.ISupportInitialize)(this.balance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capital)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.total)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown balance;
        private System.Windows.Forms.NumericUpDown funds;
        private System.Windows.Forms.NumericUpDown capital;
        private System.Windows.Forms.NumericUpDown total;
    }
}