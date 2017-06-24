namespace JashukProjekt
{
    partial class SizeOfAssetsForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.means = new System.Windows.Forms.NumericUpDown();
            this.total = new System.Windows.Forms.NumericUpDown();
            this.assets = new System.Windows.Forms.NumericUpDown();
            this.fund = new System.Windows.Forms.NumericUpDown();
            this.totaLinneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.totaLinneBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.means)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.total)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fund)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totaLinneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totaLinneBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Average cost of turnover means:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Noncurrent Assets:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Average cost of general productive fund:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "total actual size of assets";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // means
            // 
            this.means.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.totaLinneBindingSource, "TotalAnother", true));
            this.means.DecimalPlaces = 2;
            this.means.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.means.Location = new System.Drawing.Point(80, 47);
            this.means.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.means.Name = "means";
            this.means.Size = new System.Drawing.Size(121, 20);
            this.means.TabIndex = 9;
            this.means.ThousandsSeparator = true;
            this.means.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.means.ValueChanged += new System.EventHandler(this.means_ValueChanged);
            this.means.Click += new System.EventHandler(this.means_Click);
            // 
            // total
            // 
            this.total.DecimalPlaces = 2;
            this.total.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.total.Location = new System.Drawing.Point(80, 251);
            this.total.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(121, 20);
            this.total.TabIndex = 10;
            this.total.ThousandsSeparator = true;
            // 
            // assets
            // 
            this.assets.DecimalPlaces = 2;
            this.assets.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.assets.Location = new System.Drawing.Point(80, 98);
            this.assets.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.assets.Name = "assets";
            this.assets.Size = new System.Drawing.Size(121, 20);
            this.assets.TabIndex = 11;
            this.assets.ThousandsSeparator = true;
            this.assets.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // fund
            // 
            this.fund.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.totaLinneBindingSource1, "TotalFun", true));
            this.fund.DecimalPlaces = 2;
            this.fund.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.fund.Location = new System.Drawing.Point(80, 158);
            this.fund.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.fund.Name = "fund";
            this.fund.Size = new System.Drawing.Size(121, 20);
            this.fund.TabIndex = 12;
            this.fund.ThousandsSeparator = true;
            this.fund.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fund.ValueChanged += new System.EventHandler(this.fund_ValueChanged);
            this.fund.Click += new System.EventHandler(this.fund_Click);
            // 
            // totaLinneBindingSource
            // 
            this.totaLinneBindingSource.DataSource = typeof(JashukProjekt.Dane.TotaLinne);
            // 
            // totaLinneBindingSource1
            // 
            this.totaLinneBindingSource1.DataSource = typeof(JashukProjekt.Dane.TotaLinne);
            // 
            // SizeOfAssetsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 352);
            this.Controls.Add(this.fund);
            this.Controls.Add(this.assets);
            this.Controls.Add(this.total);
            this.Controls.Add(this.means);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SizeOfAssetsForm";
            this.Text = "Total actual size of assets";
            ((System.ComponentModel.ISupportInitialize)(this.means)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.total)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fund)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totaLinneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totaLinneBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown means;
        private System.Windows.Forms.NumericUpDown total;
        private System.Windows.Forms.NumericUpDown assets;
        private System.Windows.Forms.NumericUpDown fund;
        private System.Windows.Forms.BindingSource totaLinneBindingSource;
        private System.Windows.Forms.BindingSource totaLinneBindingSource1;
    }
}