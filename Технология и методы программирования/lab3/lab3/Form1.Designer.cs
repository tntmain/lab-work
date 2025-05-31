namespace lab3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mENUITEMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.окнаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuAboutAuthor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.StatusPath = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusWindowsCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolOpen = new System.Windows.Forms.ToolStripButton();
            this.ToolCloseAll = new System.Windows.Forms.ToolStripButton();
            this.ToolAboutAuthor = new System.Windows.Forms.ToolStripButton();
            this.ToolAboutProgram = new System.Windows.Forms.ToolStripButton();
            this.MenuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCloseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.обАвтореToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAboutProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENUITEMToolStripMenuItem,
            this.окнаToolStripMenuItem,
            this.MenuAboutAuthor});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(674, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mENUITEMToolStripMenuItem
            // 
            this.mENUITEMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuOpen,
            this.MenuQuit});
            this.mENUITEMToolStripMenuItem.Name = "mENUITEMToolStripMenuItem";
            this.mENUITEMToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.mENUITEMToolStripMenuItem.Text = "Файл";
            this.mENUITEMToolStripMenuItem.Click += new System.EventHandler(this.mENUITEMToolStripMenuItem_Click);
            // 
            // окнаToolStripMenuItem
            // 
            this.окнаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCascade,
            this.MenuVertical,
            this.MenuHorizontal,
            this.toolStripSeparator1,
            this.MenuCloseAll});
            this.окнаToolStripMenuItem.Name = "окнаToolStripMenuItem";
            this.окнаToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.окнаToolStripMenuItem.Text = "Окна";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(155, 6);
            // 
            // MenuAboutAuthor
            // 
            this.MenuAboutAuthor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обАвтореToolStripMenuItem,
            this.MenuAboutProgram});
            this.MenuAboutAuthor.Name = "MenuAboutAuthor";
            this.MenuAboutAuthor.Size = new System.Drawing.Size(65, 20);
            this.MenuAboutAuthor.Text = "Справка";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolOpen,
            this.toolStripSeparator2,
            this.ToolCloseAll,
            this.toolStripSeparator3,
            this.ToolAboutAuthor,
            this.ToolAboutProgram});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(674, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusPath,
            this.StatusWindowsCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 309);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(674, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.splitter1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 260);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Файлы изображений";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 16);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(125, 241);
            this.listBox1.TabIndex = 1;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(128, 16);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 241);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // StatusPath
            // 
            this.StatusPath.Name = "StatusPath";
            this.StatusPath.Size = new System.Drawing.Size(509, 17);
            this.StatusPath.Spring = true;
            this.StatusPath.Text = "Готов";
            this.StatusPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StatusWindowsCount
            // 
            this.StatusWindowsCount.AutoSize = false;
            this.StatusWindowsCount.Name = "StatusWindowsCount";
            this.StatusWindowsCount.Size = new System.Drawing.Size(150, 17);
            this.StatusWindowsCount.Text = "Открыто окон: 0";
            this.StatusWindowsCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ToolOpen
            // 
            this.ToolOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolOpen.Image = global::lab3.Properties.Resources._52;
            this.ToolOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolOpen.Name = "ToolOpen";
            this.ToolOpen.Size = new System.Drawing.Size(23, 22);
            this.ToolOpen.Text = "toolStripButton1";
            this.ToolOpen.Click += new System.EventHandler(this.MenuOpen_Click);
            // 
            // ToolCloseAll
            // 
            this.ToolCloseAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolCloseAll.Image = global::lab3.Properties.Resources._59;
            this.ToolCloseAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolCloseAll.Name = "ToolCloseAll";
            this.ToolCloseAll.Size = new System.Drawing.Size(23, 22);
            this.ToolCloseAll.Text = "toolStripButton2";
            // 
            // ToolAboutAuthor
            // 
            this.ToolAboutAuthor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolAboutAuthor.Image = global::lab3.Properties.Resources._6;
            this.ToolAboutAuthor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolAboutAuthor.Name = "ToolAboutAuthor";
            this.ToolAboutAuthor.Size = new System.Drawing.Size(23, 22);
            this.ToolAboutAuthor.Text = "toolStripButton3";
            // 
            // ToolAboutProgram
            // 
            this.ToolAboutProgram.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolAboutProgram.Image = global::lab3.Properties.Resources._9;
            this.ToolAboutProgram.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolAboutProgram.Name = "ToolAboutProgram";
            this.ToolAboutProgram.Size = new System.Drawing.Size(23, 22);
            this.ToolAboutProgram.Text = "toolStripButton4";
            // 
            // MenuOpen
            // 
            this.MenuOpen.Image = global::lab3.Properties.Resources._52;
            this.MenuOpen.Name = "MenuOpen";
            this.MenuOpen.Size = new System.Drawing.Size(180, 22);
            this.MenuOpen.Text = "Открыть папку";
            this.MenuOpen.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // MenuQuit
            // 
            this.MenuQuit.Image = global::lab3.Properties.Resources._53;
            this.MenuQuit.Name = "MenuQuit";
            this.MenuQuit.Size = new System.Drawing.Size(180, 22);
            this.MenuQuit.Text = "Выход";
            // 
            // MenuCascade
            // 
            this.MenuCascade.Image = global::lab3.Properties.Resources._49;
            this.MenuCascade.Name = "MenuCascade";
            this.MenuCascade.Size = new System.Drawing.Size(158, 22);
            this.MenuCascade.Text = "Каскадом";
            // 
            // MenuVertical
            // 
            this.MenuVertical.Image = global::lab3.Properties.Resources._48;
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(158, 22);
            this.MenuVertical.Text = "Вертикально";
            // 
            // MenuHorizontal
            // 
            this.MenuHorizontal.Image = global::lab3.Properties.Resources._48;
            this.MenuHorizontal.Name = "MenuHorizontal";
            this.MenuHorizontal.Size = new System.Drawing.Size(158, 22);
            this.MenuHorizontal.Text = "Горизонтально";
            // 
            // MenuCloseAll
            // 
            this.MenuCloseAll.Image = global::lab3.Properties.Resources._33;
            this.MenuCloseAll.Name = "MenuCloseAll";
            this.MenuCloseAll.Size = new System.Drawing.Size(158, 22);
            this.MenuCloseAll.Text = "Закрыть все";
            // 
            // обАвтореToolStripMenuItem
            // 
            this.обАвтореToolStripMenuItem.Image = global::lab3.Properties.Resources._29;
            this.обАвтореToolStripMenuItem.Name = "обАвтореToolStripMenuItem";
            this.обАвтореToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.обАвтореToolStripMenuItem.Text = "Об авторе";
            // 
            // MenuAboutProgram
            // 
            this.MenuAboutProgram.Image = global::lab3.Properties.Resources._20;
            this.MenuAboutProgram.Name = "MenuAboutProgram";
            this.MenuAboutProgram.Size = new System.Drawing.Size(149, 22);
            this.MenuAboutProgram.Text = "О программе";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 331);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Обозреватель изображений Михеев Д.С БИ-2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripMenuItem mENUITEMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuOpen;
        private System.Windows.Forms.ToolStripMenuItem окнаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuAboutAuthor;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuQuit;
        private System.Windows.Forms.ToolStripMenuItem MenuCascade;
        private System.Windows.Forms.ToolStripMenuItem MenuVertical;
        private System.Windows.Forms.ToolStripMenuItem MenuHorizontal;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuCloseAll;
        private System.Windows.Forms.ToolStripMenuItem обАвтореToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuAboutProgram;
        private System.Windows.Forms.ToolStripButton ToolOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton ToolCloseAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton ToolAboutAuthor;
        private System.Windows.Forms.ToolStripButton ToolAboutProgram;
        private System.Windows.Forms.ToolStripStatusLabel StatusPath;
        private System.Windows.Forms.ToolStripStatusLabel StatusWindowsCount;
    }
}

