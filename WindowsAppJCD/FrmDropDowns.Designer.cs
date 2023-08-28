namespace WindowsAppJCD
{
    partial class FrmDropDowns
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDropDowns));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cmbCountries = new System.Windows.Forms.ComboBox();
            this.cmbStates = new System.Windows.Forms.ComboBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button2 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nudRed = new System.Windows.Forms.NumericUpDown();
            this.nudBlue = new System.Windows.Forms.NumericUpDown();
            this.nudGreen = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "C",
            "C++",
            "VB",
            "Java",
            "Oracle",
            ".Net",
            "ASP.Net",
            "HTML",
            "CSS"});
            this.comboBox1.Location = new System.Drawing.Point(48, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(265, 44);
            this.comboBox1.TabIndex = 0;
            // 
            // cmbCountries
            // 
            this.cmbCountries.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCountries.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCountries.FormattingEnabled = true;
            this.cmbCountries.Location = new System.Drawing.Point(459, 300);
            this.cmbCountries.Name = "cmbCountries";
            this.cmbCountries.Size = new System.Drawing.Size(426, 44);
            this.cmbCountries.TabIndex = 1;
            this.cmbCountries.SelectedIndexChanged += new System.EventHandler(this.cmbCountries_SelectedIndexChanged);
            // 
            // cmbStates
            // 
            this.cmbStates.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbStates.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbStates.FormattingEnabled = true;
            this.cmbStates.Location = new System.Drawing.Point(459, 377);
            this.cmbStates.Name = "cmbStates";
            this.cmbStates.Size = new System.Drawing.Size(426, 44);
            this.cmbStates.TabIndex = 2;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "C",
            "C++",
            "HTML",
            "CSS",
            "JS",
            "Bootstrap",
            "jQuery"});
            this.checkedListBox1.Location = new System.Drawing.Point(34, 331);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(289, 328);
            this.checkedListBox1.TabIndex = 3;
            this.toolTip1.SetToolTip(this.checkedListBox1, "Select A course");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(401, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(331, 72);
            this.button1.TabIndex = 4;
            this.button1.Text = "Display Checked Items";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(405, 557);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(411, 615);
            this.maskedTextBox1.Mask = "0000000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(222, 41);
            this.maskedTextBox1.TabIndex = 6;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(3, 3);
            this.monthCalendar1.Location = new System.Drawing.Point(915, 18);
            this.monthCalendar1.MaxSelectionCount = 20;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
            this.toolTip1.SetToolTip(this.monthCalendar1, "select travelinf dates");
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(933, 495);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 57);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Develop By SIRCL";
            this.notifyIcon1.BalloonTipTitle = "About...";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "JCD APP";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(120, 52);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // nudRed
            // 
            this.nudRed.Location = new System.Drawing.Point(401, 18);
            this.nudRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRed.Name = "nudRed";
            this.nudRed.Size = new System.Drawing.Size(327, 41);
            this.nudRed.TabIndex = 10;
            this.nudRed.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // nudBlue
            // 
            this.nudBlue.Location = new System.Drawing.Point(401, 136);
            this.nudBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudBlue.Name = "nudBlue";
            this.nudBlue.Size = new System.Drawing.Size(327, 41);
            this.nudBlue.TabIndex = 11;
            this.nudBlue.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // nudGreen
            // 
            this.nudGreen.Location = new System.Drawing.Point(401, 80);
            this.nudGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudGreen.Name = "nudGreen";
            this.nudGreen.Size = new System.Drawing.Size(327, 41);
            this.nudGreen.TabIndex = 12;
            this.nudGreen.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsAppJCD.Properties.Resources.kpl_logo_black;
            this.pictureBox1.Location = new System.Drawing.Point(48, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(214, 210);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 54);
            this.button3.TabIndex = 14;
            this.button3.Text = "button3";
            this.toolTip1.SetToolTip(this.button3, "change logo");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmDropDowns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1780, 671);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nudGreen);
            this.Controls.Add(this.nudBlue);
            this.Controls.Add(this.nudRed);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.cmbStates);
            this.Controls.Add(this.cmbCountries);
            this.Controls.Add(this.comboBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "FrmDropDowns";
            this.Text = "FrmDropDowns";
            this.Load += new System.EventHandler(this.FrmDropDowns_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cmbCountries;
        private System.Windows.Forms.ComboBox cmbStates;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown nudRed;
        private System.Windows.Forms.NumericUpDown nudBlue;
        private System.Windows.Forms.NumericUpDown nudGreen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}