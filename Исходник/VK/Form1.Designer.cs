﻿namespace VK
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.InfoLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.NameFileCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.StatusLoadCount = new MetroFramework.Controls.MetroLabel();
            this.StatusLoad = new MetroFramework.Controls.MetroLabel();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.GroupComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.CountTextBox = new MetroFramework.Controls.MetroTextBox();
            this.IDTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.LoadCastomButton1 = new MetroFramework.Controls.MetroButton();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.backgroundWorkerDownLoad = new System.ComponentModel.BackgroundWorker();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.fdgfdgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.metroContextMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            resources.ApplyResources(this.notifyIcon1, "notifyIcon1");
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.White;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.listBox1, "listBox1");
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseClick);
            // 
            // metroLabel2
            // 
            resources.ApplyResources(this.metroLabel2, "metroLabel2");
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Name = "metroLabel2";
            // 
            // metroLabel3
            // 
            resources.ApplyResources(this.metroLabel3, "metroLabel3");
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Name = "metroLabel3";
            // 
            // metroTabControl1
            // 
            resources.ApplyResources(this.metroTabControl1, "metroTabControl1");
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.metroTabControl1.Multiline = true;
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroLabel3);
            this.metroTabPage1.Controls.Add(this.listBox1);
            this.metroTabPage1.Controls.Add(this.metroCheckBox1);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            resources.ApplyResources(this.metroTabPage1, "metroTabPage1");
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroCheckBox1
            // 
            resources.ApplyResources(this.metroCheckBox1, "metroCheckBox1");
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.UseSelectable = true;
            this.metroCheckBox1.CheckedChanged += new System.EventHandler(this.metroCheckBox1_CheckedChanged);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.InfoLabel7);
            this.metroTabPage2.Controls.Add(this.metroButton5);
            this.metroTabPage2.Controls.Add(this.NameFileCheckBox);
            this.metroTabPage2.Controls.Add(this.StatusLoadCount);
            this.metroTabPage2.Controls.Add(this.StatusLoad);
            this.metroTabPage2.Controls.Add(this.metroButton4);
            this.metroTabPage2.Controls.Add(this.metroProgressBar1);
            this.metroTabPage2.Controls.Add(this.metroButton3);
            this.metroTabPage2.Controls.Add(this.metroButton1);
            this.metroTabPage2.Controls.Add(this.metroLabel6);
            this.metroTabPage2.Controls.Add(this.GroupComboBox1);
            this.metroTabPage2.Controls.Add(this.metroLabel5);
            this.metroTabPage2.Controls.Add(this.CountTextBox);
            this.metroTabPage2.Controls.Add(this.IDTextBox);
            this.metroTabPage2.Controls.Add(this.metroLabel4);
            this.metroTabPage2.Controls.Add(this.metroLabel1);
            this.metroTabPage2.Controls.Add(this.LoadCastomButton1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.metroTabPage2, "metroTabPage2");
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // InfoLabel7
            // 
            resources.ApplyResources(this.InfoLabel7, "InfoLabel7");
            this.InfoLabel7.Name = "InfoLabel7";
            // 
            // metroButton5
            // 
            resources.ApplyResources(this.metroButton5, "metroButton5");
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.UseSelectable = true;
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // NameFileCheckBox
            // 
            resources.ApplyResources(this.NameFileCheckBox, "NameFileCheckBox");
            this.NameFileCheckBox.Name = "NameFileCheckBox";
            this.NameFileCheckBox.UseSelectable = true;
            // 
            // StatusLoadCount
            // 
            resources.ApplyResources(this.StatusLoadCount, "StatusLoadCount");
            this.StatusLoadCount.Name = "StatusLoadCount";
            // 
            // StatusLoad
            // 
            resources.ApplyResources(this.StatusLoad, "StatusLoad");
            this.StatusLoad.Name = "StatusLoad";
            // 
            // metroButton4
            // 
            resources.ApplyResources(this.metroButton4, "metroButton4");
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // metroProgressBar1
            // 
            resources.ApplyResources(this.metroProgressBar1, "metroProgressBar1");
            this.metroProgressBar1.Name = "metroProgressBar1";
            // 
            // metroButton3
            // 
            resources.ApplyResources(this.metroButton3, "metroButton3");
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton1
            // 
            resources.ApplyResources(this.metroButton1, "metroButton1");
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel6
            // 
            resources.ApplyResources(this.metroLabel6, "metroLabel6");
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Name = "metroLabel6";
            // 
            // GroupComboBox1
            // 
            this.GroupComboBox1.FormattingEnabled = true;
            resources.ApplyResources(this.GroupComboBox1, "GroupComboBox1");
            this.GroupComboBox1.Items.AddRange(new object[] {
            resources.GetString("GroupComboBox1.Items"),
            resources.GetString("GroupComboBox1.Items1"),
            resources.GetString("GroupComboBox1.Items2"),
            resources.GetString("GroupComboBox1.Items3")});
            this.GroupComboBox1.Name = "GroupComboBox1";
            this.GroupComboBox1.UseSelectable = true;
            // 
            // metroLabel5
            // 
            resources.ApplyResources(this.metroLabel5, "metroLabel5");
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Name = "metroLabel5";
            // 
            // CountTextBox
            // 
            this.CountTextBox.Lines = new string[0];
            resources.ApplyResources(this.CountTextBox, "CountTextBox");
            this.CountTextBox.MaxLength = 3;
            this.CountTextBox.Name = "CountTextBox";
            this.CountTextBox.PasswordChar = '\0';
            this.CountTextBox.PromptText = "Не более 100";
            this.CountTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CountTextBox.SelectedText = "";
            this.CountTextBox.Style = MetroFramework.MetroColorStyle.White;
            this.CountTextBox.UseSelectable = true;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Lines = new string[0];
            resources.ApplyResources(this.IDTextBox, "IDTextBox");
            this.IDTextBox.MaxLength = 30;
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.PasswordChar = '\0';
            this.IDTextBox.PromptText = "ID группы";
            this.IDTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.IDTextBox.SelectedText = "";
            this.IDTextBox.UseSelectable = true;
            // 
            // metroLabel4
            // 
            resources.ApplyResources(this.metroLabel4, "metroLabel4");
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Name = "metroLabel4";
            // 
            // metroLabel1
            // 
            resources.ApplyResources(this.metroLabel1, "metroLabel1");
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Name = "metroLabel1";
            // 
            // LoadCastomButton1
            // 
            resources.ApplyResources(this.LoadCastomButton1, "LoadCastomButton1");
            this.LoadCastomButton1.Name = "LoadCastomButton1";
            this.LoadCastomButton1.UseSelectable = true;
            this.LoadCastomButton1.Click += new System.EventHandler(this.LoadCastomButton1_Click);
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.metroTextBox1);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.metroTabPage3, "metroTabPage3");
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // axWindowsMediaPlayer1
            // 
            resources.ApplyResources(this.axWindowsMediaPlayer1, "axWindowsMediaPlayer1");
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroButton2.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroButton2.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton2.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.metroButton2.ForeColor = System.Drawing.Color.YellowGreen;
            resources.ApplyResources(this.metroButton2, "metroButton2");
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // backgroundWorkerDownLoad
            // 
            this.backgroundWorkerDownLoad.WorkerReportsProgress = true;
            this.backgroundWorkerDownLoad.WorkerSupportsCancellation = true;
            this.backgroundWorkerDownLoad.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerDownLoad_DoWork);
            this.backgroundWorkerDownLoad.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerDownLoad_RunWorkerCompleted);
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fdgfdgToolStripMenuItem});
            this.metroContextMenu1.Name = "metroContextMenu1";
            resources.ApplyResources(this.metroContextMenu1, "metroContextMenu1");
            // 
            // fdgfdgToolStripMenuItem
            // 
            this.fdgfdgToolStripMenuItem.Name = "fdgfdgToolStripMenuItem";
            resources.ApplyResources(this.fdgfdgToolStripMenuItem, "fdgfdgToolStripMenuItem");
            this.fdgfdgToolStripMenuItem.Click += new System.EventHandler(this.fdgfdgToolStripMenuItem_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::VK.Properties.Settings.Default, "ND", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.metroTextBox1.Lines = new string[] {
        "Вы пишите код? Вы рисуете? Играете?",
        "Тогда почему бы не включить прекрасную музыку на фон?",
        "",
        "Ограничения на кол-во постов - не более 100. Это ограничение VK.",
        "",
        "Музыка скачивается в папку Music.",
        "Она находится в той же директории, что и программа.",
        "",
        "",
        "Как запускать с параметром?",
        "Макет: \"Путь до программы\" \"Айди группы с -\" \"Кол-во постов загружать (Не более 1" +
            "00)\"",
        "Пример: \"D:\\VK\\R1.exe\" -74779558 80",
        "Вы можете создать ярлык к программе и в его свойствах, после пути к файлу и допис" +
            "ать id группы кол-во постов.",
        "Если вы указали id, обязательно нужно указывать, какое кол-во постов загружать.",
        "",
        "Нашли баг? Пиши автору.",
        "",
        "Автор: vk.com/id208497682",
        "",
        "Обновление искать на github.com/egor2998067/Perception-of-music",
        "",
        "Для работы программы у Вас должен быть установлен windows media player."};
            resources.ApplyResources(this.metroTextBox1, "metroTextBox1");
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Multiline = true;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ReadOnly = true;
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.Text = global::VK.Properties.Settings.Default.ND;
            this.metroTextBox1.UseSelectable = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.metroTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.metroContextMenu1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroButton LoadCastomButton1;
        private MetroFramework.Controls.MetroTextBox IDTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroComboBox GroupComboBox1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox CountTextBox;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroLabel StatusLoad;
        private System.ComponentModel.BackgroundWorker backgroundWorkerDownLoad;
        private MetroFramework.Controls.MetroLabel StatusLoadCount;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroCheckBox NameFileCheckBox;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem fdgfdgToolStripMenuItem;
        private MetroFramework.Controls.MetroButton metroButton5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MetroFramework.Controls.MetroLabel InfoLabel7;
    }
}

