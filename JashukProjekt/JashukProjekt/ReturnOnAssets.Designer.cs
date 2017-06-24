namespace JashukProjekt
{
    partial class ReturnOnAssets
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.profit = new System.Windows.Forms.NumericUpDown();
            this.assets = new System.Windows.Forms.NumericUpDown();
            this.total = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.profit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.total)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Net Profit:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total assets:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Profit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // profit
            // 
            this.profit.DecimalPlaces = 2;
            this.profit.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.profit.Location = new System.Drawing.Point(187, 11);
            this.profit.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.profit.Name = "profit";
            this.profit.Size = new System.Drawing.Size(85, 20);
            this.profit.TabIndex = 4;
            this.profit.ThousandsSeparator = true;
            // 
            // assets
            // 
            this.assets.DecimalPlaces = 2;
            this.assets.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.assets.Location = new System.Drawing.Point(187, 50);
            this.assets.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.assets.Name = "assets";
            this.assets.Size = new System.Drawing.Size(85, 20);
            this.assets.TabIndex = 5;
            this.assets.ThousandsSeparator = true;
            // 
            // total
            // 
            this.total.DecimalPlaces = 2;
            this.total.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.total.Location = new System.Drawing.Point(85, 182);
            this.total.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(120, 20);
            this.total.TabIndex = 6;
            this.total.ThousandsSeparator = true;
            // 
            // ReturnOnAssets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 357);
            this.Controls.Add(this.total);
            this.Controls.Add(this.assets);
            this.Controls.Add(this.profit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReturnOnAssets";
            this.Text = "Profitability on assets";
            ((System.ComponentModel.ISupportInitialize)(this.profit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.total)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown profit;
        private System.Windows.Forms.NumericUpDown assets;
        private System.Windows.Forms.NumericUpDown total;
    }
}