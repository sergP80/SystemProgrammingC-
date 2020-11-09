namespace GuiFunctionCalculator
{
    partial class fmFuncCalc
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
            this.txbX = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txbZ = new System.Windows.Forms.TextBox();
            this.lbX = new System.Windows.Forms.Label();
            this.lbZ = new System.Windows.Forms.Label();
            this.lbY = new System.Windows.Forms.Label();
            this.txbY = new System.Windows.Forms.TextBox();
            this.cbxAutoCalc = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txbX
            // 
            this.txbX.Location = new System.Drawing.Point(45, 66);
            this.txbX.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txbX.Name = "txbX";
            this.txbX.Size = new System.Drawing.Size(226, 34);
            this.txbX.TabIndex = 0;
            this.txbX.TextChanged += new System.EventHandler(this.txbX_TextChanged);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(45, 243);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(503, 42);
            this.btnCalc.TabIndex = 1;
            this.btnCalc.Text = "Обчислити значення функції";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txbZ
            // 
            this.txbZ.Location = new System.Drawing.Point(45, 146);
            this.txbZ.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txbZ.Name = "txbZ";
            this.txbZ.ReadOnly = true;
            this.txbZ.Size = new System.Drawing.Size(503, 34);
            this.txbZ.TabIndex = 3;
            // 
            // lbX
            // 
            this.lbX.AutoSize = true;
            this.lbX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbX.Location = new System.Drawing.Point(4, 66);
            this.lbX.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(31, 29);
            this.lbX.TabIndex = 4;
            this.lbX.Text = "X";
            // 
            // lbZ
            // 
            this.lbZ.AutoSize = true;
            this.lbZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbZ.Location = new System.Drawing.Point(14, 146);
            this.lbZ.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbZ.Name = "lbZ";
            this.lbZ.Size = new System.Drawing.Size(28, 29);
            this.lbZ.TabIndex = 6;
            this.lbZ.Text = "Z";
            // 
            // lbY
            // 
            this.lbY.AutoSize = true;
            this.lbY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbY.Location = new System.Drawing.Point(281, 66);
            this.lbY.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbY.Name = "lbY";
            this.lbY.Size = new System.Drawing.Size(30, 29);
            this.lbY.TabIndex = 7;
            this.lbY.Text = "Y";
            // 
            // txbY
            // 
            this.txbY.Location = new System.Drawing.Point(322, 66);
            this.txbY.Margin = new System.Windows.Forms.Padding(5);
            this.txbY.Name = "txbY";
            this.txbY.Size = new System.Drawing.Size(226, 34);
            this.txbY.TabIndex = 2;
            this.txbY.TextChanged += new System.EventHandler(this.txbX_TextChanged);
            // 
            // cbxAutoCalc
            // 
            this.cbxAutoCalc.AutoSize = true;
            this.cbxAutoCalc.Location = new System.Drawing.Point(45, 202);
            this.cbxAutoCalc.Name = "cbxAutoCalc";
            this.cbxAutoCalc.Size = new System.Drawing.Size(338, 33);
            this.cbxAutoCalc.TabIndex = 8;
            this.cbxAutoCalc.Text = "Автоматичне обчислення";
            this.cbxAutoCalc.UseVisualStyleBackColor = true;
            this.cbxAutoCalc.CheckedChanged += new System.EventHandler(this.cbxAutoCalc_CheckedChanged);
            // 
            // fmFuncCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 299);
            this.Controls.Add(this.cbxAutoCalc);
            this.Controls.Add(this.lbY);
            this.Controls.Add(this.lbZ);
            this.Controls.Add(this.lbX);
            this.Controls.Add(this.txbZ);
            this.Controls.Add(this.txbY);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txbX);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "fmFuncCalc";
            this.Text = "Функціональній калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbX;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txbZ;
        private System.Windows.Forms.Label lbX;
        private System.Windows.Forms.Label lbZ;
        private System.Windows.Forms.Label lbY;
        private System.Windows.Forms.TextBox txbY;
        private System.Windows.Forms.CheckBox cbxAutoCalc;
    }
}

