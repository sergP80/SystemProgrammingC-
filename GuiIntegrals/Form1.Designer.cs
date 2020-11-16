namespace GuiIntegrals
{
    partial class mainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.txbSteps = new System.Windows.Forms.TextBox();
            this.lbSteps = new System.Windows.Forms.Label();
            this.txbRightX = new System.Windows.Forms.TextBox();
            this.txbLeftX = new System.Windows.Forms.TextBox();
            this.lbRightX = new System.Windows.Forms.Label();
            this.lbLeftX = new System.Windows.Forms.Label();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.txbValue = new System.Windows.Forms.TextBox();
            this.lbValue = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.gbSettings.SuspendLayout();
            this.gbResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(502, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateToolStripMenuItem,
            this.cancelToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 25);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.calculateToolStripMenuItem.Text = "&Calculate";
            this.calculateToolStripMenuItem.Click += new System.EventHandler(this.calculateToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(196, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // gbSettings
            // 
            this.gbSettings.Controls.Add(this.txbSteps);
            this.gbSettings.Controls.Add(this.lbSteps);
            this.gbSettings.Controls.Add(this.txbRightX);
            this.gbSettings.Controls.Add(this.txbLeftX);
            this.gbSettings.Controls.Add(this.lbRightX);
            this.gbSettings.Controls.Add(this.lbLeftX);
            this.gbSettings.Location = new System.Drawing.Point(12, 46);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(232, 150);
            this.gbSettings.TabIndex = 7;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Settings";
            // 
            // txbSteps
            // 
            this.txbSteps.Location = new System.Drawing.Point(90, 104);
            this.txbSteps.Name = "txbSteps";
            this.txbSteps.Size = new System.Drawing.Size(100, 26);
            this.txbSteps.TabIndex = 12;
            this.txbSteps.Text = "10";
            // 
            // lbSteps
            // 
            this.lbSteps.AutoSize = true;
            this.lbSteps.Location = new System.Drawing.Point(7, 107);
            this.lbSteps.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSteps.Name = "lbSteps";
            this.lbSteps.Size = new System.Drawing.Size(51, 20);
            this.lbSteps.TabIndex = 11;
            this.lbSteps.Text = "Steps";
            // 
            // txbRightX
            // 
            this.txbRightX.Location = new System.Drawing.Point(90, 59);
            this.txbRightX.Name = "txbRightX";
            this.txbRightX.Size = new System.Drawing.Size(100, 26);
            this.txbRightX.TabIndex = 10;
            this.txbRightX.Text = "1";
            // 
            // txbLeftX
            // 
            this.txbLeftX.Location = new System.Drawing.Point(90, 24);
            this.txbLeftX.Name = "txbLeftX";
            this.txbLeftX.Size = new System.Drawing.Size(100, 26);
            this.txbLeftX.TabIndex = 9;
            this.txbLeftX.Text = "0";
            // 
            // lbRightX
            // 
            this.lbRightX.AutoSize = true;
            this.lbRightX.Location = new System.Drawing.Point(7, 62);
            this.lbRightX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRightX.Name = "lbRightX";
            this.lbRightX.Size = new System.Drawing.Size(62, 20);
            this.lbRightX.TabIndex = 8;
            this.lbRightX.Text = "Right X";
            // 
            // lbLeftX
            // 
            this.lbLeftX.AutoSize = true;
            this.lbLeftX.Location = new System.Drawing.Point(7, 27);
            this.lbLeftX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLeftX.Name = "lbLeftX";
            this.lbLeftX.Size = new System.Drawing.Size(52, 20);
            this.lbLeftX.TabIndex = 7;
            this.lbLeftX.Text = "Left X";
            // 
            // gbResult
            // 
            this.gbResult.Controls.Add(this.progressBar1);
            this.gbResult.Controls.Add(this.txbValue);
            this.gbResult.Controls.Add(this.lbValue);
            this.gbResult.Location = new System.Drawing.Point(257, 46);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(232, 150);
            this.gbResult.TabIndex = 8;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "Result";
            // 
            // txbValue
            // 
            this.txbValue.Location = new System.Drawing.Point(64, 24);
            this.txbValue.Name = "txbValue";
            this.txbValue.ReadOnly = true;
            this.txbValue.Size = new System.Drawing.Size(156, 26);
            this.txbValue.TabIndex = 9;
            // 
            // lbValue
            // 
            this.lbValue.AutoSize = true;
            this.lbValue.Location = new System.Drawing.Point(7, 27);
            this.lbValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbValue.Name = "lbValue";
            this.lbValue.Size = new System.Drawing.Size(50, 20);
            this.lbValue.TabIndex = 7;
            this.lbValue.Text = "Value";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 75);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(214, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 10;
            this.progressBar1.Visible = false;
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.cancelToolStripMenuItem.Text = "Cancel";
            this.cancelToolStripMenuItem.Visible = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 306);
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.gbSettings);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "mainForm";
            this.Text = "Обчислення інтегралів";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            this.gbResult.ResumeLayout(false);
            this.gbResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.TextBox txbSteps;
        private System.Windows.Forms.Label lbSteps;
        private System.Windows.Forms.TextBox txbRightX;
        private System.Windows.Forms.TextBox txbLeftX;
        private System.Windows.Forms.Label lbRightX;
        private System.Windows.Forms.Label lbLeftX;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.TextBox txbValue;
        private System.Windows.Forms.Label lbValue;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
    }
}

