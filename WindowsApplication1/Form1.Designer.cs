namespace CustomTimer
{
    partial class MainWindow
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
					System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
					this.ChkLoop = new System.Windows.Forms.CheckBox();
					this.PBar = new System.Windows.Forms.ProgressBar();
					this.Tooltip = new System.Windows.Forms.ToolTip(this.components);
					this.BtnMulti = new System.Windows.Forms.Button();
					this.ChkNotifiy = new System.Windows.Forms.CheckBox();
					this.CboDuration = new System.Windows.Forms.ComboBox();
					this.TimeLeftGroup = new System.Windows.Forms.GroupBox();
					this.label14 = new System.Windows.Forms.Label();
					this.label13 = new System.Windows.Forms.Label();
					this.label12 = new System.Windows.Forms.Label();
					this.label11 = new System.Windows.Forms.Label();
					this.label16 = new System.Windows.Forms.Label();
					this.label15 = new System.Windows.Forms.Label();
					this.LblHours = new System.Windows.Forms.Label();
					this.LblMinutes = new System.Windows.Forms.Label();
					this.LblSeconds = new System.Windows.Forms.Label();
					this.LblDays = new System.Windows.Forms.Label();
					this.ElapsedTimeGroup = new System.Windows.Forms.GroupBox();
					this.LblElapsed = new System.Windows.Forms.Label();
					this.TotalTimeGroup = new System.Windows.Forms.GroupBox();
					this.LblTotal = new System.Windows.Forms.Label();
					this.label6 = new System.Windows.Forms.Label();
					this.Information = new System.Windows.Forms.Label();
					this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
					this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
					this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
					this.MenuItemToggleVisible = new System.Windows.Forms.ToolStripMenuItem();
					this.groupBox1 = new System.Windows.Forms.GroupBox();
					this.label1 = new System.Windows.Forms.Label();
					this.pictureBox1 = new System.Windows.Forms.PictureBox();
					this.panel1 = new System.Windows.Forms.Panel();
					this.LblHideMe = new System.Windows.Forms.Label();
					this.groupBox2 = new System.Windows.Forms.GroupBox();
					this.label3 = new System.Windows.Forms.Label();
					this.label2 = new System.Windows.Forms.Label();
					this.groupBox3 = new System.Windows.Forms.GroupBox();
					this.BtnReset = new System.Windows.Forms.Button();
					this.SecondTimer = new System.Windows.Forms.Timer(this.components);
					this.TimeLeftGroup.SuspendLayout();
					this.ElapsedTimeGroup.SuspendLayout();
					this.TotalTimeGroup.SuspendLayout();
					this.contextMenuStrip1.SuspendLayout();
					this.groupBox1.SuspendLayout();
					((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
					this.panel1.SuspendLayout();
					this.groupBox2.SuspendLayout();
					this.groupBox3.SuspendLayout();
					this.SuspendLayout();
					// 
					// ChkLoop
					// 
					this.ChkLoop.AutoSize = true;
					this.ChkLoop.Location = new System.Drawing.Point(10, 42);
					this.ChkLoop.Name = "ChkLoop";
					this.ChkLoop.Size = new System.Drawing.Size(132, 17);
					this.ChkLoop.TabIndex = 2;
					this.ChkLoop.Text = "Loop until I say \"Stop\"";
					this.Tooltip.SetToolTip(this.ChkLoop, "When the time is reached, automatically starts from 0 again.");
					this.ChkLoop.UseVisualStyleBackColor = true;
					// 
					// PBar
					// 
					this.PBar.Location = new System.Drawing.Point(7, 262);
					this.PBar.Name = "PBar";
					this.PBar.Size = new System.Drawing.Size(280, 23);
					this.PBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
					this.PBar.TabIndex = 3;
					// 
					// BtnMulti
					// 
					this.BtnMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
					this.BtnMulti.Location = new System.Drawing.Point(7, 19);
					this.BtnMulti.Name = "BtnMulti";
					this.BtnMulti.Size = new System.Drawing.Size(157, 26);
					this.BtnMulti.TabIndex = 10;
					this.BtnMulti.Text = "Start";
					this.Tooltip.SetToolTip(this.BtnMulti, "Starts or pauses the timer (or hit enter)");
					this.BtnMulti.UseVisualStyleBackColor = true;
					this.BtnMulti.Click += new System.EventHandler(this.BtnMulti_Click);
					// 
					// ChkNotifiy
					// 
					this.ChkNotifiy.AutoSize = true;
					this.ChkNotifiy.Checked = true;
					this.ChkNotifiy.CheckState = System.Windows.Forms.CheckState.Checked;
					this.ChkNotifiy.Location = new System.Drawing.Point(11, 19);
					this.ChkNotifiy.Name = "ChkNotifiy";
					this.ChkNotifiy.Size = new System.Drawing.Size(183, 17);
					this.ChkNotifiy.TabIndex = 11;
					this.ChkNotifiy.Text = "Alert me from the notification area";
					this.Tooltip.SetToolTip(this.ChkNotifiy, "Pops up a balloon from the program icon in the system tray when timer is up. ");
					this.ChkNotifiy.UseVisualStyleBackColor = true;
					// 
					// CboDuration
					// 
					this.CboDuration.FormattingEnabled = true;
					this.CboDuration.Items.AddRange(new object[] {
            ":30",
            "1:00",
            "5:00",
            "10:00",
            "15:00",
            "30:00",
            "45:00",
            "1:00:00",
            "1:30:00",
            "2:00:00"});
					this.CboDuration.Location = new System.Drawing.Point(170, 13);
					this.CboDuration.Name = "CboDuration";
					this.CboDuration.Size = new System.Drawing.Size(103, 21);
					this.CboDuration.TabIndex = 18;
					this.CboDuration.Text = "5:00";
					this.Tooltip.SetToolTip(this.CboDuration, "Type any time here, or use a preset.");
					// 
					// TimeLeftGroup
					// 
					this.TimeLeftGroup.Controls.Add(this.label14);
					this.TimeLeftGroup.Controls.Add(this.label13);
					this.TimeLeftGroup.Controls.Add(this.label12);
					this.TimeLeftGroup.Controls.Add(this.label11);
					this.TimeLeftGroup.Controls.Add(this.label16);
					this.TimeLeftGroup.Controls.Add(this.label15);
					this.TimeLeftGroup.Controls.Add(this.LblHours);
					this.TimeLeftGroup.Controls.Add(this.LblMinutes);
					this.TimeLeftGroup.Controls.Add(this.LblSeconds);
					this.TimeLeftGroup.Controls.Add(this.LblDays);
					this.TimeLeftGroup.Enabled = false;
					this.TimeLeftGroup.Location = new System.Drawing.Point(7, 294);
					this.TimeLeftGroup.Name = "TimeLeftGroup";
					this.TimeLeftGroup.Size = new System.Drawing.Size(194, 82);
					this.TimeLeftGroup.TabIndex = 22;
					this.TimeLeftGroup.TabStop = false;
					this.TimeLeftGroup.Text = "Time Left";
					this.Tooltip.SetToolTip(this.TimeLeftGroup, "Time remaining in countdown");
					// 
					// label14
					// 
					this.label14.AutoSize = true;
					this.label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
					this.label14.Location = new System.Drawing.Point(155, 57);
					this.label14.Name = "label14";
					this.label14.Size = new System.Drawing.Size(26, 13);
					this.label14.TabIndex = 22;
					this.label14.Text = "Sec";
					this.Tooltip.SetToolTip(this.label14, "Time remaining in countdown");
					// 
					// label13
					// 
					this.label13.AutoSize = true;
					this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
					this.label13.Location = new System.Drawing.Point(116, 57);
					this.label13.Name = "label13";
					this.label13.Size = new System.Drawing.Size(24, 13);
					this.label13.TabIndex = 22;
					this.label13.Text = "Min";
					this.Tooltip.SetToolTip(this.label13, "Time remaining in countdown");
					// 
					// label12
					// 
					this.label12.AutoSize = true;
					this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
					this.label12.Location = new System.Drawing.Point(69, 57);
					this.label12.Name = "label12";
					this.label12.Size = new System.Drawing.Size(35, 13);
					this.label12.TabIndex = 22;
					this.label12.Text = "Hours";
					this.Tooltip.SetToolTip(this.label12, "Time remaining in countdown");
					// 
					// label11
					// 
					this.label11.AutoSize = true;
					this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
					this.label11.Location = new System.Drawing.Point(13, 57);
					this.label11.Name = "label11";
					this.label11.Size = new System.Drawing.Size(31, 13);
					this.label11.TabIndex = 22;
					this.label11.Text = "Days";
					this.Tooltip.SetToolTip(this.label11, "Time remaining in countdown");
					// 
					// label16
					// 
					this.label16.BackColor = System.Drawing.Color.Transparent;
					this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
					this.label16.Location = new System.Drawing.Point(141, 21);
					this.label16.Margin = new System.Windows.Forms.Padding(0);
					this.label16.Name = "label16";
					this.label16.Size = new System.Drawing.Size(14, 29);
					this.label16.TabIndex = 21;
					this.label16.Text = ":";
					this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
					// 
					// label15
					// 
					this.label15.BackColor = System.Drawing.Color.Transparent;
					this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
					this.label15.Location = new System.Drawing.Point(97, 21);
					this.label15.Margin = new System.Windows.Forms.Padding(0);
					this.label15.Name = "label15";
					this.label15.Size = new System.Drawing.Size(14, 29);
					this.label15.TabIndex = 21;
					this.label15.Text = ":";
					this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
					// 
					// LblHours
					// 
					this.LblHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
					this.LblHours.Location = new System.Drawing.Point(61, 21);
					this.LblHours.Margin = new System.Windows.Forms.Padding(0);
					this.LblHours.Name = "LblHours";
					this.LblHours.Size = new System.Drawing.Size(42, 29);
					this.LblHours.TabIndex = 21;
					this.LblHours.Text = "0";
					this.LblHours.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					this.Tooltip.SetToolTip(this.LblHours, "Time remaining in countdown");
					// 
					// LblMinutes
					// 
					this.LblMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
					this.LblMinutes.Location = new System.Drawing.Point(107, 21);
					this.LblMinutes.Margin = new System.Windows.Forms.Padding(0);
					this.LblMinutes.Name = "LblMinutes";
					this.LblMinutes.Size = new System.Drawing.Size(42, 29);
					this.LblMinutes.TabIndex = 21;
					this.LblMinutes.Text = "00";
					this.LblMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
					this.Tooltip.SetToolTip(this.LblMinutes, "Time remaining in countdown");
					// 
					// LblSeconds
					// 
					this.LblSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
					this.LblSeconds.Location = new System.Drawing.Point(148, 21);
					this.LblSeconds.Margin = new System.Windows.Forms.Padding(0);
					this.LblSeconds.Name = "LblSeconds";
					this.LblSeconds.Size = new System.Drawing.Size(42, 29);
					this.LblSeconds.TabIndex = 21;
					this.LblSeconds.Text = "00";
					this.LblSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
					this.Tooltip.SetToolTip(this.LblSeconds, "Time remaining in countdown");
					// 
					// LblDays
					// 
					this.LblDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
					this.LblDays.Location = new System.Drawing.Point(3, 21);
					this.LblDays.Margin = new System.Windows.Forms.Padding(0);
					this.LblDays.Name = "LblDays";
					this.LblDays.Size = new System.Drawing.Size(53, 29);
					this.LblDays.TabIndex = 21;
					this.LblDays.Text = "0";
					this.LblDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
					this.Tooltip.SetToolTip(this.LblDays, "Time remaining in countdown");
					// 
					// ElapsedTimeGroup
					// 
					this.ElapsedTimeGroup.Controls.Add(this.LblElapsed);
					this.ElapsedTimeGroup.Enabled = false;
					this.ElapsedTimeGroup.Location = new System.Drawing.Point(207, 294);
					this.ElapsedTimeGroup.Name = "ElapsedTimeGroup";
					this.ElapsedTimeGroup.Size = new System.Drawing.Size(80, 38);
					this.ElapsedTimeGroup.TabIndex = 22;
					this.ElapsedTimeGroup.TabStop = false;
					this.ElapsedTimeGroup.Text = "Elapsed";
					this.Tooltip.SetToolTip(this.ElapsedTimeGroup, "How much time has passed since the counter was started");
					// 
					// LblElapsed
					// 
					this.LblElapsed.AutoSize = true;
					this.LblElapsed.Location = new System.Drawing.Point(6, 16);
					this.LblElapsed.Name = "LblElapsed";
					this.LblElapsed.Size = new System.Drawing.Size(43, 13);
					this.LblElapsed.TabIndex = 0;
					this.LblElapsed.Text = "0:00:00";
					this.Tooltip.SetToolTip(this.LblElapsed, "How much time has passed since the counter was started");
					// 
					// TotalTimeGroup
					// 
					this.TotalTimeGroup.Controls.Add(this.LblTotal);
					this.TotalTimeGroup.Controls.Add(this.label6);
					this.TotalTimeGroup.Enabled = false;
					this.TotalTimeGroup.Location = new System.Drawing.Point(207, 338);
					this.TotalTimeGroup.Name = "TotalTimeGroup";
					this.TotalTimeGroup.Size = new System.Drawing.Size(80, 38);
					this.TotalTimeGroup.TabIndex = 22;
					this.TotalTimeGroup.TabStop = false;
					this.TotalTimeGroup.Text = "Total Time";
					this.Tooltip.SetToolTip(this.TotalTimeGroup, "Duration of countdown specified");
					// 
					// LblTotal
					// 
					this.LblTotal.AutoSize = true;
					this.LblTotal.Location = new System.Drawing.Point(6, 16);
					this.LblTotal.Name = "LblTotal";
					this.LblTotal.Size = new System.Drawing.Size(43, 13);
					this.LblTotal.TabIndex = 0;
					this.LblTotal.Text = "0:00:00";
					this.Tooltip.SetToolTip(this.LblTotal, "Duration of countdown specified");
					// 
					// label6
					// 
					this.label6.AutoSize = true;
					this.label6.Location = new System.Drawing.Point(6, 48);
					this.label6.Name = "label6";
					this.label6.Size = new System.Drawing.Size(35, 13);
					this.label6.TabIndex = 0;
					this.label6.Text = "label5";
					// 
					// Information
					// 
					this.Information.AutoSize = true;
					this.Information.BackColor = System.Drawing.Color.Transparent;
					this.Information.Location = new System.Drawing.Point(0, 2);
					this.Information.MaximumSize = new System.Drawing.Size(230, 0);
					this.Information.Name = "Information";
					this.Information.Size = new System.Drawing.Size(124, 13);
					this.Information.TabIndex = 5;
					this.Information.Text = "CustomTimer is loading...";
					this.Information.UseMnemonic = false;
					// 
					// notifyIcon1
					// 
					this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
					this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
					this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
					this.notifyIcon1.Text = "CustomTimer";
					this.notifyIcon1.Visible = true;
					this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
					this.notifyIcon1.BalloonTipClicked += new System.EventHandler(this.notifyIcon1_BalloonTipClicked);
					// 
					// contextMenuStrip1
					// 
					this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.MenuItemToggleVisible});
					this.contextMenuStrip1.Name = "contextMenuStrip1";
					this.contextMenuStrip1.Size = new System.Drawing.Size(191, 48);
					// 
					// exitToolStripMenuItem
					// 
					this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
					this.exitToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
					this.exitToolStripMenuItem.Text = "E&xit";
					this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
					// 
					// MenuItemToggleVisible
					// 
					this.MenuItemToggleVisible.Name = "MenuItemToggleVisible";
					this.MenuItemToggleVisible.Size = new System.Drawing.Size(190, 22);
					this.MenuItemToggleVisible.Text = "&Hide Program Window";
					this.MenuItemToggleVisible.Click += new System.EventHandler(this.hideCustomTimerToolStripMenuItem_Click);
					// 
					// groupBox1
					// 
					this.groupBox1.Controls.Add(this.ChkNotifiy);
					this.groupBox1.Controls.Add(this.ChkLoop);
					this.groupBox1.Location = new System.Drawing.Point(7, 132);
					this.groupBox1.Name = "groupBox1";
					this.groupBox1.Size = new System.Drawing.Size(280, 67);
					this.groupBox1.TabIndex = 12;
					this.groupBox1.TabStop = false;
					this.groupBox1.Text = "When it\'s over...";
					// 
					// label1
					// 
					this.label1.AutoSize = true;
					this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
					this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
					this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
					this.label1.Location = new System.Drawing.Point(4, 382);
					this.label1.Name = "label1";
					this.label1.Size = new System.Drawing.Size(99, 13);
					this.label1.TabIndex = 13;
					this.label1.Text = "About CustomTimer";
					this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
					this.label1.Click += new System.EventHandler(this.label1_Click_1);
					// 
					// pictureBox1
					// 
					this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
					this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
					this.pictureBox1.Location = new System.Drawing.Point(-8, 7);
					this.pictureBox1.Name = "pictureBox1";
					this.pictureBox1.Size = new System.Drawing.Size(52, 52);
					this.pictureBox1.TabIndex = 14;
					this.pictureBox1.TabStop = false;
					// 
					// panel1
					// 
					this.panel1.AutoScroll = true;
					this.panel1.Controls.Add(this.Information);
					this.panel1.Location = new System.Drawing.Point(39, 2);
					this.panel1.Name = "panel1";
					this.panel1.Size = new System.Drawing.Size(248, 66);
					this.panel1.TabIndex = 17;
					// 
					// LblHideMe
					// 
					this.LblHideMe.AutoSize = true;
					this.LblHideMe.Cursor = System.Windows.Forms.Cursors.Hand;
					this.LblHideMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
					this.LblHideMe.Location = new System.Drawing.Point(119, 382);
					this.LblHideMe.Name = "LblHideMe";
					this.LblHideMe.Size = new System.Drawing.Size(168, 13);
					this.LblHideMe.TabIndex = 18;
					this.LblHideMe.Text = "Hide (Minimize to notification area)";
					this.LblHideMe.TextAlign = System.Drawing.ContentAlignment.TopRight;
					this.LblHideMe.Click += new System.EventHandler(this.hideCustomTimerToolStripMenuItem_Click);
					// 
					// groupBox2
					// 
					this.groupBox2.Controls.Add(this.CboDuration);
					this.groupBox2.Controls.Add(this.label3);
					this.groupBox2.Controls.Add(this.label2);
					this.groupBox2.Location = new System.Drawing.Point(7, 68);
					this.groupBox2.Name = "groupBox2";
					this.groupBox2.Size = new System.Drawing.Size(280, 58);
					this.groupBox2.TabIndex = 19;
					this.groupBox2.TabStop = false;
					this.groupBox2.Text = "Duration ";
					// 
					// label3
					// 
					this.label3.AutoSize = true;
					this.label3.Location = new System.Drawing.Point(7, 36);
					this.label3.Name = "label3";
					this.label3.Size = new System.Drawing.Size(235, 13);
					this.label3.TabIndex = 17;
					this.label3.Text = "(Example: \"1:15:00\" or \"1 hour and 15 minutes\")";
					// 
					// label2
					// 
					this.label2.AutoSize = true;
					this.label2.Location = new System.Drawing.Point(7, 16);
					this.label2.Name = "label2";
					this.label2.Size = new System.Drawing.Size(142, 13);
					this.label2.TabIndex = 16;
					this.label2.Text = "Set timer to count down from";
					// 
					// groupBox3
					// 
					this.groupBox3.Controls.Add(this.BtnReset);
					this.groupBox3.Controls.Add(this.BtnMulti);
					this.groupBox3.Location = new System.Drawing.Point(7, 205);
					this.groupBox3.Name = "groupBox3";
					this.groupBox3.Size = new System.Drawing.Size(280, 51);
					this.groupBox3.TabIndex = 20;
					this.groupBox3.TabStop = false;
					this.groupBox3.Text = "Start / Pause / Reset";
					// 
					// BtnReset
					// 
					this.BtnReset.Enabled = false;
					this.BtnReset.Location = new System.Drawing.Point(170, 19);
					this.BtnReset.Name = "BtnReset";
					this.BtnReset.Size = new System.Drawing.Size(103, 26);
					this.BtnReset.TabIndex = 11;
					this.BtnReset.Text = "Stop & Reset";
					this.BtnReset.UseMnemonic = false;
					this.BtnReset.UseVisualStyleBackColor = true;
					this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
					// 
					// SecondTimer
					// 
					this.SecondTimer.Interval = 1000;
					this.SecondTimer.Tick += new System.EventHandler(this.SecondTimer_Tick);
					// 
					// MainWindow
					// 
					this.AcceptButton = this.BtnMulti;
					this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
					this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
					this.BackColor = System.Drawing.SystemColors.Control;
					this.ClientSize = new System.Drawing.Size(296, 402);
					this.Controls.Add(this.TimeLeftGroup);
					this.Controls.Add(this.TotalTimeGroup);
					this.Controls.Add(this.groupBox2);
					this.Controls.Add(this.ElapsedTimeGroup);
					this.Controls.Add(this.groupBox3);
					this.Controls.Add(this.LblHideMe);
					this.Controls.Add(this.panel1);
					this.Controls.Add(this.groupBox1);
					this.Controls.Add(this.pictureBox1);
					this.Controls.Add(this.label1);
					this.Controls.Add(this.PBar);
					this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
					this.MaximizeBox = false;
					this.MaximumSize = new System.Drawing.Size(304, 436);
					this.MinimumSize = new System.Drawing.Size(304, 436);
					this.Name = "MainWindow";
					this.Text = "CustomTimer";
					this.TransparencyKey = System.Drawing.Color.Fuchsia;
					this.VisibleChanged += new System.EventHandler(this.MainWindow_VisibleChanged);
					this.Load += new System.EventHandler(this.Form1_Load);
					this.TimeLeftGroup.ResumeLayout(false);
					this.TimeLeftGroup.PerformLayout();
					this.ElapsedTimeGroup.ResumeLayout(false);
					this.ElapsedTimeGroup.PerformLayout();
					this.TotalTimeGroup.ResumeLayout(false);
					this.TotalTimeGroup.PerformLayout();
					this.contextMenuStrip1.ResumeLayout(false);
					this.groupBox1.ResumeLayout(false);
					this.groupBox1.PerformLayout();
					((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
					this.panel1.ResumeLayout(false);
					this.panel1.PerformLayout();
					this.groupBox2.ResumeLayout(false);
					this.groupBox2.PerformLayout();
					this.groupBox3.ResumeLayout(false);
					this.ResumeLayout(false);
					this.PerformLayout();

        }

        #endregion

			private System.Windows.Forms.CheckBox ChkLoop;
        private System.Windows.Forms.ProgressBar PBar;
        private System.Windows.Forms.ToolTip Tooltip;
        private System.Windows.Forms.Label Information;
        private System.Windows.Forms.Button BtnMulti;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.CheckBox ChkNotifiy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemToggleVisible;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblHideMe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.ComboBox CboDuration;
        private System.Windows.Forms.Timer SecondTimer;
        private System.Windows.Forms.Label LblDays;
        private System.Windows.Forms.GroupBox TimeLeftGroup;
        private System.Windows.Forms.GroupBox ElapsedTimeGroup;
        private System.Windows.Forms.Label LblElapsed;
        private System.Windows.Forms.GroupBox TotalTimeGroup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LblHours;
        private System.Windows.Forms.Label LblMinutes;
        private System.Windows.Forms.Label LblSeconds;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
			private System.Windows.Forms.Label label16;
    }
}

