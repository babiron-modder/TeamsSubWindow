namespace TeamsSubWindow_001
{
    partial class Main
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
            menuStrip1 = new MenuStrip();
            設定SToolStripMenuItem = new ToolStripMenuItem();
            タブ一覧tToolStripMenuItem = new ToolStripMenuItem();
            tabControl_main = new TabControl();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { 設定SToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(774, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // 設定SToolStripMenuItem
            // 
            設定SToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { タブ一覧tToolStripMenuItem });
            設定SToolStripMenuItem.Name = "設定SToolStripMenuItem";
            設定SToolStripMenuItem.Size = new Size(56, 20);
            設定SToolStripMenuItem.Text = "設定(&s)";
            // 
            // タブ一覧tToolStripMenuItem
            // 
            タブ一覧tToolStripMenuItem.Name = "タブ一覧tToolStripMenuItem";
            タブ一覧tToolStripMenuItem.Size = new Size(180, 22);
            タブ一覧tToolStripMenuItem.Text = "タブ一覧設定(&t)";
            タブ一覧tToolStripMenuItem.Click += タブ一覧tToolStripMenuItem_Click;
            // 
            // tabControl_main
            // 
            tabControl_main.Dock = DockStyle.Fill;
            tabControl_main.Location = new Point(0, 24);
            tabControl_main.Name = "tabControl_main";
            tabControl_main.SelectedIndex = 0;
            tabControl_main.Size = new Size(774, 464);
            tabControl_main.TabIndex = 1;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 488);
            Controls.Add(tabControl_main);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "MultiProfileWebView";
            Load += Main_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 設定SToolStripMenuItem;
        private TabControl tabControl_main;
        private ToolStripMenuItem タブ一覧tToolStripMenuItem;
    }
}