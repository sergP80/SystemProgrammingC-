namespace GuiIntegrals
{
    partial class Preferences
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
            this.gbGeneral = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbExpression = new System.Windows.Forms.TextBox();
            this.mtxbTolerance = new System.Windows.Forms.MaskedTextBox();
            this.lbTolerance = new System.Windows.Forms.Label();
            this.txbSteps = new System.Windows.Forms.TextBox();
            this.lbSteps = new System.Windows.Forms.Label();
            this.txbRightX = new System.Windows.Forms.TextBox();
            this.txbLeftX = new System.Windows.Forms.TextBox();
            this.lbRightX = new System.Windows.Forms.Label();
            this.lbLeftX = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.optionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbGeneral.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbGeneral
            // 
            this.gbGeneral.Controls.Add(this.label1);
            this.gbGeneral.Controls.Add(this.txbExpression);
            this.gbGeneral.Controls.Add(this.mtxbTolerance);
            this.gbGeneral.Controls.Add(this.lbTolerance);
            this.gbGeneral.Controls.Add(this.txbSteps);
            this.gbGeneral.Controls.Add(this.lbSteps);
            this.gbGeneral.Controls.Add(this.txbRightX);
            this.gbGeneral.Controls.Add(this.txbLeftX);
            this.gbGeneral.Controls.Add(this.lbRightX);
            this.gbGeneral.Controls.Add(this.lbLeftX);
            this.gbGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbGeneral.Location = new System.Drawing.Point(31, 36);
            this.gbGeneral.Margin = new System.Windows.Forms.Padding(4);
            this.gbGeneral.Name = "gbGeneral";
            this.gbGeneral.Padding = new System.Windows.Forms.Padding(4);
            this.gbGeneral.Size = new System.Drawing.Size(348, 342);
            this.gbGeneral.TabIndex = 8;
            this.gbGeneral.TabStop = false;
            this.gbGeneral.Text = "General";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Expression";
            // 
            // txbExpression
            // 
            this.txbExpression.Location = new System.Drawing.Point(9, 64);
            this.txbExpression.Margin = new System.Windows.Forms.Padding(4);
            this.txbExpression.Name = "txbExpression";
            this.txbExpression.Size = new System.Drawing.Size(328, 28);
            this.txbExpression.TabIndex = 15;
            this.txbExpression.Text = "pi*x*x/(x*x-3)";
            this.txbExpression.TextChanged += new System.EventHandler(this.txbExpression_TextChanged);
            // 
            // mtxbTolerance
            // 
            this.mtxbTolerance.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.optionsBindingSource, "Tolerance", true));
            this.mtxbTolerance.Location = new System.Drawing.Point(162, 291);
            this.mtxbTolerance.Margin = new System.Windows.Forms.Padding(4);
            this.mtxbTolerance.Mask = "1e-###";
            this.mtxbTolerance.Name = "mtxbTolerance";
            this.mtxbTolerance.Size = new System.Drawing.Size(175, 28);
            this.mtxbTolerance.TabIndex = 14;
            this.mtxbTolerance.Text = "3";
            // 
            // lbTolerance
            // 
            this.lbTolerance.AutoSize = true;
            this.lbTolerance.Location = new System.Drawing.Point(14, 297);
            this.lbTolerance.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbTolerance.Name = "lbTolerance";
            this.lbTolerance.Size = new System.Drawing.Size(96, 24);
            this.lbTolerance.TabIndex = 13;
            this.lbTolerance.Text = "Tolerance";
            // 
            // txbSteps
            // 
            this.txbSteps.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.optionsBindingSource, "Steps", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txbSteps.Location = new System.Drawing.Point(162, 238);
            this.txbSteps.Margin = new System.Windows.Forms.Padding(4);
            this.txbSteps.Name = "txbSteps";
            this.txbSteps.Size = new System.Drawing.Size(175, 28);
            this.txbSteps.TabIndex = 12;
            this.txbSteps.Text = "100";
            // 
            // lbSteps
            // 
            this.lbSteps.AutoSize = true;
            this.lbSteps.Location = new System.Drawing.Point(14, 244);
            this.lbSteps.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbSteps.Name = "lbSteps";
            this.lbSteps.Size = new System.Drawing.Size(57, 24);
            this.lbSteps.TabIndex = 11;
            this.lbSteps.Text = "Steps";
            // 
            // txbRightX
            // 
            this.txbRightX.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.optionsBindingSource, "EndX", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txbRightX.Location = new System.Drawing.Point(162, 184);
            this.txbRightX.Margin = new System.Windows.Forms.Padding(4);
            this.txbRightX.Name = "txbRightX";
            this.txbRightX.Size = new System.Drawing.Size(175, 28);
            this.txbRightX.TabIndex = 10;
            this.txbRightX.Text = "1";
            // 
            // txbLeftX
            // 
            this.txbLeftX.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.optionsBindingSource, "StartX", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txbLeftX.Location = new System.Drawing.Point(162, 129);
            this.txbLeftX.Margin = new System.Windows.Forms.Padding(4);
            this.txbLeftX.Name = "txbLeftX";
            this.txbLeftX.Size = new System.Drawing.Size(175, 28);
            this.txbLeftX.TabIndex = 9;
            this.txbLeftX.Text = "0";
            // 
            // lbRightX
            // 
            this.lbRightX.AutoSize = true;
            this.lbRightX.Location = new System.Drawing.Point(14, 191);
            this.lbRightX.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbRightX.Name = "lbRightX";
            this.lbRightX.Size = new System.Drawing.Size(72, 24);
            this.lbRightX.TabIndex = 8;
            this.lbRightX.Text = "Right X";
            // 
            // lbLeftX
            // 
            this.lbLeftX.AutoSize = true;
            this.lbLeftX.Location = new System.Drawing.Point(14, 136);
            this.lbLeftX.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbLeftX.Name = "lbLeftX";
            this.lbLeftX.Size = new System.Drawing.Size(58, 24);
            this.lbLeftX.TabIndex = 7;
            this.lbLeftX.Text = "Left X";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Location = new System.Drawing.Point(12, 401);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 64);
            this.panel1.TabIndex = 9;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Image = global::GuiIntegrals.Properties.Resources.StatusNo_16x;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(281, 14);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 38);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Enabled = false;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOk.Image = global::GuiIntegrals.Properties.Resources.StatusOK_16x;
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.Location = new System.Drawing.Point(28, 14);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(101, 38);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // optionsBindingSource
            // 
            this.optionsBindingSource.DataSource = typeof(NumericIntegral.IntegrateOptions);
            // 
            // Preferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 477);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbGeneral);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Preferences";
            this.Text = "Preferences";
            this.Load += new System.EventHandler(this.Preferences_Load);
            this.gbGeneral.ResumeLayout(false);
            this.gbGeneral.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.optionsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGeneral;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbExpression;
        private System.Windows.Forms.MaskedTextBox mtxbTolerance;
        private System.Windows.Forms.Label lbTolerance;
        private System.Windows.Forms.TextBox txbSteps;
        private System.Windows.Forms.Label lbSteps;
        private System.Windows.Forms.TextBox txbRightX;
        private System.Windows.Forms.TextBox txbLeftX;
        private System.Windows.Forms.Label lbRightX;
        private System.Windows.Forms.Label lbLeftX;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.BindingSource optionsBindingSource;
    }
}