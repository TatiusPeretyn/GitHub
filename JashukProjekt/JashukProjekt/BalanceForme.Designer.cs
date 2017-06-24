namespace JashukProjekt
{
    partial class BalanceForme
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
            this.PrimePrice = new System.Windows.Forms.NumericUpDown();
            this.AdminCharges = new System.Windows.Forms.NumericUpDown();
            this.CommercialCharges = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.total = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.GeneralProfit = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.PrimePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminCharges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommercialCharges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.total)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralProfit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(64, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "prime price of commodities:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(71, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "administrative charges:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(81, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "commercial charges:";
            // 
            // PrimePrice
            // 
            this.PrimePrice.DecimalPlaces = 2;
            this.PrimePrice.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.PrimePrice.Location = new System.Drawing.Point(84, 96);
            this.PrimePrice.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.PrimePrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PrimePrice.Name = "PrimePrice";
            this.PrimePrice.Size = new System.Drawing.Size(120, 20);
            this.PrimePrice.TabIndex = 6;
            this.PrimePrice.ThousandsSeparator = true;
            this.PrimePrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AdminCharges
            // 
            this.AdminCharges.DecimalPlaces = 2;
            this.AdminCharges.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.AdminCharges.Location = new System.Drawing.Point(84, 148);
            this.AdminCharges.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.AdminCharges.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AdminCharges.Name = "AdminCharges";
            this.AdminCharges.Size = new System.Drawing.Size(120, 20);
            this.AdminCharges.TabIndex = 7;
            this.AdminCharges.ThousandsSeparator = true;
            this.AdminCharges.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CommercialCharges
            // 
            this.CommercialCharges.DecimalPlaces = 2;
            this.CommercialCharges.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.CommercialCharges.Location = new System.Drawing.Point(84, 201);
            this.CommercialCharges.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.CommercialCharges.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CommercialCharges.Name = "CommercialCharges";
            this.CommercialCharges.Size = new System.Drawing.Size(119, 20);
            this.CommercialCharges.TabIndex = 8;
            this.CommercialCharges.ThousandsSeparator = true;
            this.CommercialCharges.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Balance";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 320);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 20);
            this.button2.TabIndex = 11;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // total
            // 
            this.total.DecimalPlaces = 2;
            this.total.Location = new System.Drawing.Point(84, 272);
            this.total.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(119, 20);
            this.total.TabIndex = 12;
            this.total.ThousandsSeparator = true;
            this.total.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(81, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "general profit yield:";
            // 
            // GeneralProfit
            // 
            this.GeneralProfit.DecimalPlaces = 2;
            this.GeneralProfit.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.GeneralProfit.Location = new System.Drawing.Point(84, 43);
            this.GeneralProfit.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.GeneralProfit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.GeneralProfit.Name = "GeneralProfit";
            this.GeneralProfit.Size = new System.Drawing.Size(120, 20);
            this.GeneralProfit.TabIndex = 14;
            this.GeneralProfit.ThousandsSeparator = true;
            this.GeneralProfit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BalanceForme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 352);
            this.Controls.Add(this.GeneralProfit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.total);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CommercialCharges);
            this.Controls.Add(this.AdminCharges);
            this.Controls.Add(this.PrimePrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BalanceForme";
            this.Text = "Balance";
            ((System.ComponentModel.ISupportInitialize)(this.PrimePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminCharges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommercialCharges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.total)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralProfit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown PrimePrice;
        private System.Windows.Forms.NumericUpDown AdminCharges;
        private System.Windows.Forms.NumericUpDown CommercialCharges;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown total;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown GeneralProfit;
    }
}