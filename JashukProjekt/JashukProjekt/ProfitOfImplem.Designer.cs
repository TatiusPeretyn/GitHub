namespace JashukProjekt
{
    partial class ProfitOfImplem
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
            this.profit = new System.Windows.Forms.NumericUpDown();
            this.cost = new System.Windows.Forms.NumericUpDown();
            this.reven = new System.Windows.Forms.NumericUpDown();
            this.total = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reven)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.total)).BeginInit();
            this.SuspendLayout();
            // 
            // profit
            // 
            this.profit.DecimalPlaces = 2;
            this.profit.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.profit.Location = new System.Drawing.Point(176, 12);
            this.profit.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.profit.Name = "profit";
            this.profit.Size = new System.Drawing.Size(96, 20);
            this.profit.TabIndex = 0;
            this.profit.ThousandsSeparator = true;
            // 
            // cost
            // 
            this.cost.DecimalPlaces = 2;
            this.cost.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.cost.Location = new System.Drawing.Point(176, 57);
            this.cost.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(96, 20);
            this.cost.TabIndex = 1;
            this.cost.ThousandsSeparator = true;
            // 
            // reven
            // 
            this.reven.DecimalPlaces = 2;
            this.reven.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.reven.Location = new System.Drawing.Point(176, 105);
            this.reven.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.reven.Name = "reven";
            this.reven.Size = new System.Drawing.Size(96, 20);
            this.reven.TabIndex = 2;
            this.reven.ThousandsSeparator = true;
            // 
            // total
            // 
            this.total.DecimalPlaces = 2;
            this.total.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.total.Location = new System.Drawing.Point(90, 249);
            this.total.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(96, 20);
            this.total.TabIndex = 3;
            this.total.ThousandsSeparator = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Trading profit:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Production cost:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total amount of revenue:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Profit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ProfitOfImplem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 356);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.total);
            this.Controls.Add(this.reven);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.profit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProfitOfImplem";
            this.Text = "Profitability of implementation";
            ((System.ComponentModel.ISupportInitialize)(this.profit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reven)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.total)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown profit;
        private System.Windows.Forms.NumericUpDown cost;
        private System.Windows.Forms.NumericUpDown reven;
        private System.Windows.Forms.NumericUpDown total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}