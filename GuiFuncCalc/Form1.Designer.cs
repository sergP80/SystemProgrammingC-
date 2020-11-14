namespace GuiFuncCalc
{
    partial class fmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMain));
            this.txbX1 = new System.Windows.Forms.TextBox();
            this.lbX1 = new System.Windows.Forms.Label();
            this.lbX2 = new System.Windows.Forms.Label();
            this.txbX2 = new System.Windows.Forms.TextBox();
            this.txbY = new System.Windows.Forms.TextBox();
            this.lbY = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbX1
            // 
            this.txbX1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbX1.Location = new System.Drawing.Point(64, 19);
            this.txbX1.Name = "txbX1";
            this.txbX1.PlaceholderText = "Enter X1";
            this.txbX1.Size = new System.Drawing.Size(237, 34);
            this.txbX1.TabIndex = 0;
            // 
            // lbX1
            // 
            this.lbX1.AutoSize = true;
            this.lbX1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbX1.Location = new System.Drawing.Point(21, 19);
            this.lbX1.Name = "lbX1";
            this.lbX1.Size = new System.Drawing.Size(37, 28);
            this.lbX1.TabIndex = 1;
            this.lbX1.Text = "X1";
            // 
            // lbX2
            // 
            this.lbX2.AutoSize = true;
            this.lbX2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbX2.Location = new System.Drawing.Point(21, 82);
            this.lbX2.Name = "lbX2";
            this.lbX2.Size = new System.Drawing.Size(37, 28);
            this.lbX2.TabIndex = 1;
            this.lbX2.Text = "X2";
            // 
            // txbX2
            // 
            this.txbX2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbX2.Location = new System.Drawing.Point(64, 82);
            this.txbX2.Name = "txbX2";
            this.txbX2.PlaceholderText = "Enter X2";
            this.txbX2.Size = new System.Drawing.Size(237, 34);
            this.txbX2.TabIndex = 0;
            // 
            // txbY
            // 
            this.txbY.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbY.Location = new System.Drawing.Point(64, 145);
            this.txbY.Name = "txbY";
            this.txbY.ReadOnly = true;
            this.txbY.Size = new System.Drawing.Size(237, 34);
            this.txbY.TabIndex = 0;
            // 
            // lbY
            // 
            this.lbY.AutoSize = true;
            this.lbY.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbY.Location = new System.Drawing.Point(21, 145);
            this.lbY.Name = "lbY";
            this.lbY.Size = new System.Drawing.Size(24, 28);
            this.lbY.TabIndex = 1;
            this.lbY.Text = "Y";
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalc.Location = new System.Drawing.Point(323, 22);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(94, 36);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "Calc";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(323, 83);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 36);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(323, 146);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 36);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 253);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lbY);
            this.Controls.Add(this.txbY);
            this.Controls.Add(this.txbX2);
            this.Controls.Add(this.lbX2);
            this.Controls.Add(this.lbX1);
            this.Controls.Add(this.txbX1);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(1779, 1165);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "fmMain";
            this.Text = "Func calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fmMain_FormClosing);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbX1;
        private System.Windows.Forms.Label lbX1;
        private System.Windows.Forms.Label lbX2;
        private System.Windows.Forms.TextBox txbX2;
        private System.Windows.Forms.TextBox txbY;
        private System.Windows.Forms.Label lbY;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

