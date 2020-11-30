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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbSettings = new System.Windows.Forms.GroupBox();
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbMethods = new System.Windows.Forms.GroupBox();
            this.rbMidleRect = new System.Windows.Forms.RadioButton();
            this.rbRightRect = new System.Windows.Forms.RadioButton();
            this.rbLeftRecMethod = new System.Windows.Forms.RadioButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbStart = new System.Windows.Forms.ToolStripButton();
            this.tsbCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbPreferences = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tstxValue = new System.Windows.Forms.ToolStripTextBox();
            this.mainOptionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.gbSettings.SuspendLayout();
            this.gbMethods.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainOptionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(502, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateToolStripMenuItem,
            this.cancelToolStripMenuItem,
            this.toolStripSeparator4,
            this.optionsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(56, 32);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.Image = global::GuiIntegrals.Properties.Resources.Run_16x;
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(248, 32);
            this.calculateToolStripMenuItem.Text = "&Calculate";
            this.calculateToolStripMenuItem.Click += new System.EventHandler(this.calculateToolStripMenuItem_Click);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Image = global::GuiIntegrals.Properties.Resources.Stop_16x;
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.cancelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(248, 32);
            this.cancelToolStripMenuItem.Text = "Cancel";
            this.cancelToolStripMenuItem.Visible = false;
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(245, 6);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Image = global::GuiIntegrals.Properties.Resources.SettingsOutline_16x;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(248, 32);
            this.optionsToolStripMenuItem.Text = "&Options...";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(245, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::GuiIntegrals.Properties.Resources.Close_red_16x;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(248, 32);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // gbSettings
            // 
            this.gbSettings.Controls.Add(this.label1);
            this.gbSettings.Controls.Add(this.txbExpression);
            this.gbSettings.Controls.Add(this.mtxbTolerance);
            this.gbSettings.Controls.Add(this.lbTolerance);
            this.gbSettings.Controls.Add(this.txbSteps);
            this.gbSettings.Controls.Add(this.lbSteps);
            this.gbSettings.Controls.Add(this.txbRightX);
            this.gbSettings.Controls.Add(this.txbLeftX);
            this.gbSettings.Controls.Add(this.lbRightX);
            this.gbSettings.Controls.Add(this.lbLeftX);
            this.gbSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbSettings.Location = new System.Drawing.Point(12, 66);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(232, 235);
            this.gbSettings.TabIndex = 7;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Expression";
            // 
            // txbExpression
            // 
            this.txbExpression.Location = new System.Drawing.Point(6, 49);
            this.txbExpression.Name = "txbExpression";
            this.txbExpression.ReadOnly = true;
            this.txbExpression.Size = new System.Drawing.Size(220, 28);
            this.txbExpression.TabIndex = 15;
            // 
            // mtxbTolerance
            // 
            this.mtxbTolerance.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mainOptionsBindingSource, "Tolerance", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.mtxbTolerance.Location = new System.Drawing.Point(108, 192);
            this.mtxbTolerance.Name = "mtxbTolerance";
            this.mtxbTolerance.ReadOnly = true;
            this.mtxbTolerance.Size = new System.Drawing.Size(118, 28);
            this.mtxbTolerance.TabIndex = 14;
            // 
            // lbTolerance
            // 
            this.lbTolerance.AutoSize = true;
            this.lbTolerance.Location = new System.Drawing.Point(9, 196);
            this.lbTolerance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTolerance.Name = "lbTolerance";
            this.lbTolerance.Size = new System.Drawing.Size(96, 24);
            this.lbTolerance.TabIndex = 13;
            this.lbTolerance.Text = "Tolerance";
            // 
            // txbSteps
            // 
            this.txbSteps.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mainOptionsBindingSource, "Steps", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txbSteps.Location = new System.Drawing.Point(108, 158);
            this.txbSteps.Name = "txbSteps";
            this.txbSteps.ReadOnly = true;
            this.txbSteps.Size = new System.Drawing.Size(118, 28);
            this.txbSteps.TabIndex = 12;
            // 
            // lbSteps
            // 
            this.lbSteps.AutoSize = true;
            this.lbSteps.Location = new System.Drawing.Point(9, 162);
            this.lbSteps.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSteps.Name = "lbSteps";
            this.lbSteps.Size = new System.Drawing.Size(57, 24);
            this.lbSteps.TabIndex = 11;
            this.lbSteps.Text = "Steps";
            // 
            // txbRightX
            // 
            this.txbRightX.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mainOptionsBindingSource, "EndX", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txbRightX.Location = new System.Drawing.Point(108, 124);
            this.txbRightX.Name = "txbRightX";
            this.txbRightX.ReadOnly = true;
            this.txbRightX.Size = new System.Drawing.Size(118, 28);
            this.txbRightX.TabIndex = 10;
            // 
            // txbLeftX
            // 
            this.txbLeftX.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mainOptionsBindingSource, "StartX", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txbLeftX.Location = new System.Drawing.Point(108, 89);
            this.txbLeftX.Name = "txbLeftX";
            this.txbLeftX.ReadOnly = true;
            this.txbLeftX.Size = new System.Drawing.Size(118, 28);
            this.txbLeftX.TabIndex = 9;
            // 
            // lbRightX
            // 
            this.lbRightX.AutoSize = true;
            this.lbRightX.Location = new System.Drawing.Point(9, 128);
            this.lbRightX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRightX.Name = "lbRightX";
            this.lbRightX.Size = new System.Drawing.Size(72, 24);
            this.lbRightX.TabIndex = 8;
            this.lbRightX.Text = "Right X";
            // 
            // lbLeftX
            // 
            this.lbLeftX.AutoSize = true;
            this.lbLeftX.Location = new System.Drawing.Point(9, 93);
            this.lbLeftX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLeftX.Name = "lbLeftX";
            this.lbLeftX.Size = new System.Drawing.Size(58, 24);
            this.lbLeftX.TabIndex = 7;
            this.lbLeftX.Text = "Left X";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // gbMethods
            // 
            this.gbMethods.Controls.Add(this.rbMidleRect);
            this.gbMethods.Controls.Add(this.rbRightRect);
            this.gbMethods.Controls.Add(this.rbLeftRecMethod);
            this.gbMethods.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbMethods.Location = new System.Drawing.Point(250, 66);
            this.gbMethods.Name = "gbMethods";
            this.gbMethods.Size = new System.Drawing.Size(176, 129);
            this.gbMethods.TabIndex = 9;
            this.gbMethods.TabStop = false;
            this.gbMethods.Text = "Methods";
            // 
            // rbMidleRect
            // 
            this.rbMidleRect.AutoSize = true;
            this.rbMidleRect.Location = new System.Drawing.Point(12, 99);
            this.rbMidleRect.Name = "rbMidleRect";
            this.rbMidleRect.Size = new System.Drawing.Size(104, 24);
            this.rbMidleRect.TabIndex = 2;
            this.rbMidleRect.Tag = "2";
            this.rbMidleRect.Text = "Midle rect";
            this.rbMidleRect.UseVisualStyleBackColor = true;
            this.rbMidleRect.Click += new System.EventHandler(this.rbMidleRect_Click);
            // 
            // rbRightRect
            // 
            this.rbRightRect.AutoSize = true;
            this.rbRightRect.Location = new System.Drawing.Point(12, 64);
            this.rbRightRect.Name = "rbRightRect";
            this.rbRightRect.Size = new System.Drawing.Size(103, 24);
            this.rbRightRect.TabIndex = 1;
            this.rbRightRect.Tag = "1";
            this.rbRightRect.Text = "Right rect";
            this.rbRightRect.UseVisualStyleBackColor = true;
            this.rbRightRect.Click += new System.EventHandler(this.rbRightRect_Click);
            // 
            // rbLeftRecMethod
            // 
            this.rbLeftRecMethod.AutoSize = true;
            this.rbLeftRecMethod.Checked = true;
            this.rbLeftRecMethod.Location = new System.Drawing.Point(12, 29);
            this.rbLeftRecMethod.Name = "rbLeftRecMethod";
            this.rbLeftRecMethod.Size = new System.Drawing.Size(93, 24);
            this.rbLeftRecMethod.TabIndex = 0;
            this.rbLeftRecMethod.TabStop = true;
            this.rbLeftRecMethod.Tag = "0";
            this.rbLeftRecMethod.Text = "Left rect";
            this.rbLeftRecMethod.UseVisualStyleBackColor = true;
            this.rbLeftRecMethod.Click += new System.EventHandler(this.rbLeftRecMethod_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbStart,
            this.tsbCancel,
            this.toolStripSeparator2,
            this.tsbExit,
            this.toolStripSeparator6,
            this.tsbPreferences,
            this.toolStripSeparator3,
            this.tsProgressBar1,
            this.toolStripSeparator5,
            this.tstxValue});
            this.toolStrip1.Location = new System.Drawing.Point(0, 38);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(502, 27);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbStart
            // 
            this.tsbStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbStart.Image = global::GuiIntegrals.Properties.Resources.Run_16x;
            this.tsbStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStart.Name = "tsbStart";
            this.tsbStart.Size = new System.Drawing.Size(29, 24);
            this.tsbStart.Text = "Start calculation";
            this.tsbStart.Click += new System.EventHandler(this.tsbStart_Click);
            // 
            // tsbCancel
            // 
            this.tsbCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCancel.Image = global::GuiIntegrals.Properties.Resources.Stop_16x;
            this.tsbCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancel.Name = "tsbCancel";
            this.tsbCancel.Size = new System.Drawing.Size(29, 24);
            this.tsbCancel.Text = "Cancel calculation";
            this.tsbCancel.Visible = false;
            this.tsbCancel.Click += new System.EventHandler(this.tsbCancel_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbExit
            // 
            this.tsbExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExit.Image = global::GuiIntegrals.Properties.Resources.Close_red_16x;
            this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(29, 24);
            this.tsbExit.Text = "Exit";
            this.tsbExit.Click += new System.EventHandler(this.tsbExit_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbPreferences
            // 
            this.tsbPreferences.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPreferences.Image = global::GuiIntegrals.Properties.Resources.SettingsOutline_16x;
            this.tsbPreferences.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPreferences.Name = "tsbPreferences";
            this.tsbPreferences.Size = new System.Drawing.Size(29, 24);
            this.tsbPreferences.Text = "toolStripButton1";
            this.tsbPreferences.Click += new System.EventHandler(this.tsbPreferences_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // tsProgressBar1
            // 
            this.tsProgressBar1.Name = "tsProgressBar1";
            this.tsProgressBar1.Size = new System.Drawing.Size(100, 24);
            this.tsProgressBar1.Step = 1;
            this.tsProgressBar1.Visible = false;
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            this.toolStripSeparator5.Visible = false;
            // 
            // tstxValue
            // 
            this.tstxValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstxValue.Name = "tstxValue";
            this.tstxValue.ReadOnly = true;
            this.tstxValue.Size = new System.Drawing.Size(100, 27);
            // 
            // mainOptionsBindingSource
            // 
            this.mainOptionsBindingSource.DataSource = typeof(NumericIntegral.IntegrateOptions);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 373);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gbMethods);
            this.Controls.Add(this.gbSettings);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Обчислення інтегралів";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            this.gbMethods.ResumeLayout(false);
            this.gbMethods.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainOptionsBindingSource)).EndInit();
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbMethods;
        private System.Windows.Forms.RadioButton rbLeftRecMethod;
        private System.Windows.Forms.RadioButton rbRightRect;
        private System.Windows.Forms.RadioButton rbMidleRect;
        private System.Windows.Forms.Label lbTolerance;
        private System.Windows.Forms.MaskedTextBox mtxbTolerance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbExpression;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbStart;
        private System.Windows.Forms.ToolStripButton tsbCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripProgressBar tsProgressBar1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripTextBox tstxValue;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tsbPreferences;
        private System.Windows.Forms.BindingSource mainOptionsBindingSource;
    }
}

