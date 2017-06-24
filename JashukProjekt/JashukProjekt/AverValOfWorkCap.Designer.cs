namespace JashukProjekt
{
    partial class AverValOfWorkCap
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.NumericUpDown();
            this.end = new System.Windows.Forms.NumericUpDown();
            this.total = new System.Windows.Forms.NumericUpDown();
            this.totaLinneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.end)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.total)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totaLinneBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Value";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // start
            // 
            this.start.DecimalPlaces = 2;
            this.start.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.start.Location = new System.Drawing.Point(95, 45);
            this.start.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(99, 20);
            this.start.TabIndex = 2;
            this.start.ThousandsSeparator = true;
            // 
            // end
            // 
            this.end.DecimalPlaces = 2;
            this.end.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.end.Location = new System.Drawing.Point(95, 91);
            this.end.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(99, 20);
            this.end.TabIndex = 3;
            this.end.ThousandsSeparator = true;
            // 
            // total
            // 
            this.total.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.totaLinneBindingSource, "TotalAnother", true));
            this.total.DecimalPlaces = 2;
            this.total.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.total.Location = new System.Drawing.Point(95, 230);
            this.total.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(99, 20);
            this.total.TabIndex = 4;
            this.total.ThousandsSeparator = true;
            // 
            // totaLinneBindingSource
            // 
            this.totaLinneBindingSource.DataSource = typeof(JashukProjekt.Dane.TotaLinne);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "working capital at the start of period:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "working capital in the end of period:";
            // 
            // AverValOfWorkCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 352);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.total);
            this.Controls.Add(this.end);
            this.Controls.Add(this.start);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AverValOfWorkCap";
            this.Text = "Averaged value of working capital";
            ((System.ComponentModel.ISupportInitialize)(this.start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.end)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.total)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totaLinneBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown start;
        private System.Windows.Forms.NumericUpDown end;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource totaLinneBindingSource;
        public System.Windows.Forms.NumericUpDown total;
    }
}