namespace JashukProjekt
{
    partial class ProfitOfInvest
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
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.netProf = new System.Windows.Forms.NumericUpDown();
            this.passive = new System.Windows.Forms.NumericUpDown();
            this.funds = new System.Windows.Forms.NumericUpDown();
            this.total = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.netProf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.total)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Net Profit:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Average level of long-term passives:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Average level of the personal funds:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(95, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Profit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // netProf
            // 
            this.netProf.DecimalPlaces = 2;
            this.netProf.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.netProf.Location = new System.Drawing.Point(100, 39);
            this.netProf.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.netProf.Name = "netProf";
            this.netProf.Size = new System.Drawing.Size(91, 20);
            this.netProf.TabIndex = 5;
            this.netProf.ThousandsSeparator = true;
            // 
            // passive
            // 
            this.passive.DecimalPlaces = 2;
            this.passive.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.passive.Location = new System.Drawing.Point(100, 93);
            this.passive.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.passive.Name = "passive";
            this.passive.Size = new System.Drawing.Size(91, 20);
            this.passive.TabIndex = 6;
            this.passive.ThousandsSeparator = true;
            // 
            // funds
            // 
            this.funds.DecimalPlaces = 2;
            this.funds.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.funds.Location = new System.Drawing.Point(100, 148);
            this.funds.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.funds.Name = "funds";
            this.funds.Size = new System.Drawing.Size(91, 20);
            this.funds.TabIndex = 7;
            this.funds.ThousandsSeparator = true;
            // 
            // total
            // 
            this.total.DecimalPlaces = 2;
            this.total.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.total.Location = new System.Drawing.Point(95, 262);
            this.total.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(91, 20);
            this.total.TabIndex = 8;
            this.total.ThousandsSeparator = true;
            // 
            // ProfitOfInvest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 352);
            this.Controls.Add(this.total);
            this.Controls.Add(this.funds);
            this.Controls.Add(this.passive);
            this.Controls.Add(this.netProf);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProfitOfInvest";
            this.Text = "Profitability of investment";
            ((System.ComponentModel.ISupportInitialize)(this.netProf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.total)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown netProf;
        private System.Windows.Forms.NumericUpDown passive;
        private System.Windows.Forms.NumericUpDown funds;
        private System.Windows.Forms.NumericUpDown total;
    }
}