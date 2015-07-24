namespace Calculator
{
    partial class Form1
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
            this.txtBxIntToFactor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxFactors = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFactor = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageFactor = new System.Windows.Forms.TabPage();
            this.tabPagePrimes = new System.Windows.Forms.TabPage();
            this.btnPrimesStart = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.txtBxPrimes = new System.Windows.Forms.TextBox();
            this.chkBxLiveUpdate = new System.Windows.Forms.CheckBox();
            this.numUDMaxValue = new System.Windows.Forms.NumericUpDown();
            this.lblMaxValue = new System.Windows.Forms.Label();
            this.numUDStartingValue = new System.Windows.Forms.NumericUpDown();
            this.lblStartingValue = new System.Windows.Forms.Label();
            this.numUDMaxTime = new System.Windows.Forms.NumericUpDown();
            this.lblRunTime = new System.Windows.Forms.Label();
            this.numUDNumOfPrimes = new System.Windows.Forms.NumericUpDown();
            this.lblNumOfPrimes = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPageFactor.SuspendLayout();
            this.tabPagePrimes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDMaxValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDStartingValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDMaxTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDNumOfPrimes)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBxIntToFactor
            // 
            this.txtBxIntToFactor.Location = new System.Drawing.Point(100, 10);
            this.txtBxIntToFactor.Name = "txtBxIntToFactor";
            this.txtBxIntToFactor.Size = new System.Drawing.Size(100, 20);
            this.txtBxIntToFactor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Integer to Factor:";
            // 
            // txtBxFactors
            // 
            this.txtBxFactors.Location = new System.Drawing.Point(9, 42);
            this.txtBxFactors.Multiline = true;
            this.txtBxFactors.Name = "txtBxFactors";
            this.txtBxFactors.Size = new System.Drawing.Size(288, 243);
            this.txtBxFactors.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prime Factorization:";
            // 
            // btnFactor
            // 
            this.btnFactor.Location = new System.Drawing.Point(206, 8);
            this.btnFactor.Name = "btnFactor";
            this.btnFactor.Size = new System.Drawing.Size(75, 23);
            this.btnFactor.TabIndex = 1;
            this.btnFactor.Text = "Factor";
            this.btnFactor.UseVisualStyleBackColor = true;
            this.btnFactor.Click += new System.EventHandler(this.btnFactor_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageFactor);
            this.tabControl1.Controls.Add(this.tabPagePrimes);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(309, 317);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPageFactor
            // 
            this.tabPageFactor.Controls.Add(this.txtBxFactors);
            this.tabPageFactor.Controls.Add(this.btnFactor);
            this.tabPageFactor.Controls.Add(this.label2);
            this.tabPageFactor.Controls.Add(this.txtBxIntToFactor);
            this.tabPageFactor.Controls.Add(this.label1);
            this.tabPageFactor.Location = new System.Drawing.Point(4, 22);
            this.tabPageFactor.Name = "tabPageFactor";
            this.tabPageFactor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFactor.Size = new System.Drawing.Size(301, 291);
            this.tabPageFactor.TabIndex = 0;
            this.tabPageFactor.Text = "Factor";
            this.tabPageFactor.UseVisualStyleBackColor = true;
            // 
            // tabPagePrimes
            // 
            this.tabPagePrimes.Controls.Add(this.btnPrimesStart);
            this.tabPagePrimes.Controls.Add(this.btnExport);
            this.tabPagePrimes.Controls.Add(this.txtBxPrimes);
            this.tabPagePrimes.Controls.Add(this.chkBxLiveUpdate);
            this.tabPagePrimes.Controls.Add(this.numUDMaxValue);
            this.tabPagePrimes.Controls.Add(this.lblMaxValue);
            this.tabPagePrimes.Controls.Add(this.numUDStartingValue);
            this.tabPagePrimes.Controls.Add(this.lblStartingValue);
            this.tabPagePrimes.Controls.Add(this.numUDMaxTime);
            this.tabPagePrimes.Controls.Add(this.lblRunTime);
            this.tabPagePrimes.Controls.Add(this.numUDNumOfPrimes);
            this.tabPagePrimes.Controls.Add(this.lblNumOfPrimes);
            this.tabPagePrimes.Location = new System.Drawing.Point(4, 22);
            this.tabPagePrimes.Name = "tabPagePrimes";
            this.tabPagePrimes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrimes.Size = new System.Drawing.Size(301, 291);
            this.tabPagePrimes.TabIndex = 1;
            this.tabPagePrimes.Text = "Find Primes";
            this.tabPagePrimes.UseVisualStyleBackColor = true;
            // 
            // btnPrimesStart
            // 
            this.btnPrimesStart.Location = new System.Drawing.Point(139, 262);
            this.btnPrimesStart.Name = "btnPrimesStart";
            this.btnPrimesStart.Size = new System.Drawing.Size(75, 23);
            this.btnPrimesStart.TabIndex = 6;
            this.btnPrimesStart.Text = "Start";
            this.btnPrimesStart.UseVisualStyleBackColor = true;
            this.btnPrimesStart.Click += new System.EventHandler(this.btnPrimesStart_Click);
            // 
            // btnExport
            // 
            this.btnExport.Enabled = false;
            this.btnExport.Location = new System.Drawing.Point(220, 262);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // txtBxPrimes
            // 
            this.txtBxPrimes.Location = new System.Drawing.Point(7, 192);
            this.txtBxPrimes.Multiline = true;
            this.txtBxPrimes.Name = "txtBxPrimes";
            this.txtBxPrimes.Size = new System.Drawing.Size(288, 64);
            this.txtBxPrimes.TabIndex = 10;
            // 
            // chkBxLiveUpdate
            // 
            this.chkBxLiveUpdate.AutoSize = true;
            this.chkBxLiveUpdate.Location = new System.Drawing.Point(7, 168);
            this.chkBxLiveUpdate.Name = "chkBxLiveUpdate";
            this.chkBxLiveUpdate.Size = new System.Drawing.Size(90, 17);
            this.chkBxLiveUpdate.TabIndex = 5;
            this.chkBxLiveUpdate.Text = "Live Update?";
            this.chkBxLiveUpdate.UseVisualStyleBackColor = true;
            // 
            // numUDMaxValue
            // 
            this.numUDMaxValue.Location = new System.Drawing.Point(6, 142);
            this.numUDMaxValue.Maximum = new decimal(new int[] {
            -1,
            2147483647,
            0,
            0});
            this.numUDMaxValue.Name = "numUDMaxValue";
            this.numUDMaxValue.Size = new System.Drawing.Size(136, 20);
            this.numUDMaxValue.TabIndex = 4;
            this.numUDMaxValue.Value = new decimal(new int[] {
            -1,
            2147483647,
            0,
            0});
            // 
            // lblMaxValue
            // 
            this.lblMaxValue.AutoSize = true;
            this.lblMaxValue.Location = new System.Drawing.Point(3, 126);
            this.lblMaxValue.Name = "lblMaxValue";
            this.lblMaxValue.Size = new System.Drawing.Size(84, 13);
            this.lblMaxValue.TabIndex = 6;
            this.lblMaxValue.Text = "Maximum Value:";
            // 
            // numUDStartingValue
            // 
            this.numUDStartingValue.Location = new System.Drawing.Point(7, 103);
            this.numUDStartingValue.Maximum = new decimal(new int[] {
            -1,
            2147483647,
            0,
            0});
            this.numUDStartingValue.Name = "numUDStartingValue";
            this.numUDStartingValue.Size = new System.Drawing.Size(135, 20);
            this.numUDStartingValue.TabIndex = 3;
            // 
            // lblStartingValue
            // 
            this.lblStartingValue.AutoSize = true;
            this.lblStartingValue.Location = new System.Drawing.Point(3, 86);
            this.lblStartingValue.Name = "lblStartingValue";
            this.lblStartingValue.Size = new System.Drawing.Size(76, 13);
            this.lblStartingValue.TabIndex = 4;
            this.lblStartingValue.Text = "Starting Value:";
            // 
            // numUDMaxTime
            // 
            this.numUDMaxTime.Location = new System.Drawing.Point(7, 63);
            this.numUDMaxTime.Name = "numUDMaxTime";
            this.numUDMaxTime.Size = new System.Drawing.Size(50, 20);
            this.numUDMaxTime.TabIndex = 2;
            this.numUDMaxTime.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblRunTime
            // 
            this.lblRunTime.AutoSize = true;
            this.lblRunTime.Location = new System.Drawing.Point(3, 47);
            this.lblRunTime.Name = "lblRunTime";
            this.lblRunTime.Size = new System.Drawing.Size(224, 13);
            this.lblRunTime.TabIndex = 2;
            this.lblRunTime.Text = "Amount of Time to look for Primes (in minutes):";
            // 
            // numUDNumOfPrimes
            // 
            this.numUDNumOfPrimes.Location = new System.Drawing.Point(6, 19);
            this.numUDNumOfPrimes.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numUDNumOfPrimes.Name = "numUDNumOfPrimes";
            this.numUDNumOfPrimes.Size = new System.Drawing.Size(81, 20);
            this.numUDNumOfPrimes.TabIndex = 1;
            this.numUDNumOfPrimes.Value = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            // 
            // lblNumOfPrimes
            // 
            this.lblNumOfPrimes.AutoSize = true;
            this.lblNumOfPrimes.Location = new System.Drawing.Point(4, 3);
            this.lblNumOfPrimes.Name = "lblNumOfPrimes";
            this.lblNumOfPrimes.Size = new System.Drawing.Size(93, 13);
            this.lblNumOfPrimes.TabIndex = 0;
            this.lblNumOfPrimes.Text = "Number of Primes:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btnRead);
            this.tabPage1.Controls.Add(this.btnWrite);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(301, 291);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "CSVDataAdapter";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(88, 6);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 0;
            this.btnWrite.Text = "Write!";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(6, 6);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = "Read!";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 347);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Factor";
            this.tabControl1.ResumeLayout(false);
            this.tabPageFactor.ResumeLayout(false);
            this.tabPageFactor.PerformLayout();
            this.tabPagePrimes.ResumeLayout(false);
            this.tabPagePrimes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDMaxValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDStartingValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDMaxTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDNumOfPrimes)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxIntToFactor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxFactors;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFactor;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageFactor;
        private System.Windows.Forms.TabPage tabPagePrimes;
        private System.Windows.Forms.Label lblNumOfPrimes;
        private System.Windows.Forms.NumericUpDown numUDNumOfPrimes;
        private System.Windows.Forms.NumericUpDown numUDMaxValue;
        private System.Windows.Forms.Label lblMaxValue;
        private System.Windows.Forms.NumericUpDown numUDStartingValue;
        private System.Windows.Forms.Label lblStartingValue;
        private System.Windows.Forms.NumericUpDown numUDMaxTime;
        private System.Windows.Forms.Label lblRunTime;
        private System.Windows.Forms.Button btnPrimesStart;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.TextBox txtBxPrimes;
        private System.Windows.Forms.CheckBox chkBxLiveUpdate;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

