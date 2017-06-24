namespace JashukProjekt
{
    partial class AverValOfPrinOccupFunds
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
            this.reven = new System.Windows.Forms.NumericUpDown();
            this.aver = new System.Windows.Forms.NumericUpDown();
            this.total = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reven)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.total)).BeginInit();
            this.SuspendLayout();
            // 
            // reven
            // 
            this.reven.DecimalPlaces = 2;
            this.reven.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.reven.Location = new System.Drawing.Point(152, 28);
            this.reven.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.reven.Name = "reven";
            this.reven.Size = new System.Drawing.Size(120, 20);
            this.reven.TabIndex = 0;
            this.reven.ThousandsSeparator = true;
            // 
            // aver
            // 
            this.aver.DecimalPlaces = 2;
            this.aver.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.aver.Location = new System.Drawing.Point(152, 85);
            this.aver.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.aver.Name = "aver";
            this.aver.Size = new System.Drawing.Size(120, 20);
            this.aver.TabIndex = 1;
            this.aver.ThousandsSeparator = true;
            // 
            // total
            // 
            this.total.DecimalPlaces = 2;
            this.total.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.total.Location = new System.Drawing.Point(87, 236);
            this.total.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(120, 20);
            this.total.TabIndex = 2;
            this.total.ThousandsSeparator = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Revenue:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Average annual value of occupation funds:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Value";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AverValOfPrinOccupFunds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 352);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.total);
            this.Controls.Add(this.aver);
            this.Controls.Add(this.reven);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AverValOfPrinOccupFunds";
            this.Text = "Averaged value of principal occupational funds";
            ((System.ComponentModel.ISupportInitialize)(this.reven)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.total)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown reven;
        private System.Windows.Forms.NumericUpDown aver;
        private System.Windows.Forms.NumericUpDown total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}