namespace TeamsSubWindow_001
{
    partial class TabSetting
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
            listBox_main = new ListBox();
            panel_left_bg = new Panel();
            splitter1 = new Splitter();
            panel_right_bg = new Panel();
            textBox_url = new TextBox();
            label3 = new Label();
            textBox_id = new TextBox();
            label2 = new Label();
            textBox_title = new TextBox();
            label1 = new Label();
            panel_left_bg.SuspendLayout();
            panel_right_bg.SuspendLayout();
            SuspendLayout();
            // 
            // listBox_main
            // 
            listBox_main.Dock = DockStyle.Fill;
            listBox_main.FormattingEnabled = true;
            listBox_main.ItemHeight = 15;
            listBox_main.Location = new Point(0, 0);
            listBox_main.Name = "listBox_main";
            listBox_main.Size = new Size(200, 367);
            listBox_main.TabIndex = 0;
            listBox_main.SelectedIndexChanged += listBox_main_SelectedIndexChanged;
            // 
            // panel_left_bg
            // 
            panel_left_bg.Controls.Add(listBox_main);
            panel_left_bg.Dock = DockStyle.Left;
            panel_left_bg.Location = new Point(0, 0);
            panel_left_bg.Name = "panel_left_bg";
            panel_left_bg.Size = new Size(200, 367);
            panel_left_bg.TabIndex = 1;
            // 
            // splitter1
            // 
            splitter1.BackColor = Color.FromArgb(224, 224, 224);
            splitter1.Location = new Point(200, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(10, 367);
            splitter1.TabIndex = 2;
            splitter1.TabStop = false;
            // 
            // panel_right_bg
            // 
            panel_right_bg.Controls.Add(textBox_url);
            panel_right_bg.Controls.Add(label3);
            panel_right_bg.Controls.Add(textBox_id);
            panel_right_bg.Controls.Add(label2);
            panel_right_bg.Controls.Add(textBox_title);
            panel_right_bg.Controls.Add(label1);
            panel_right_bg.Dock = DockStyle.Fill;
            panel_right_bg.Location = new Point(210, 0);
            panel_right_bg.Name = "panel_right_bg";
            panel_right_bg.Size = new Size(380, 367);
            panel_right_bg.TabIndex = 3;
            // 
            // textBox_url
            // 
            textBox_url.Location = new Point(69, 86);
            textBox_url.Name = "textBox_url";
            textBox_url.Size = new Size(274, 23);
            textBox_url.TabIndex = 1;
            textBox_url.Leave += textBox_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 89);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 0;
            label3.Text = "url：";
            // 
            // textBox_id
            // 
            textBox_id.Location = new Point(69, 57);
            textBox_id.Name = "textBox_id";
            textBox_id.Size = new Size(274, 23);
            textBox_id.TabIndex = 1;
            textBox_id.Leave += textBox_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 60);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 0;
            label2.Text = "id：";
            // 
            // textBox_title
            // 
            textBox_title.Location = new Point(69, 26);
            textBox_title.Name = "textBox_title";
            textBox_title.Size = new Size(274, 23);
            textBox_title.TabIndex = 1;
            textBox_title.Leave += textBox_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 29);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "title：";
            // 
            // TabSetting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 367);
            Controls.Add(panel_right_bg);
            Controls.Add(splitter1);
            Controls.Add(panel_left_bg);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "TabSetting";
            Text = "TabSetting";
            FormClosing += TabSetting_FormClosing;
            Load += TabSetting_Load;
            panel_left_bg.ResumeLayout(false);
            panel_right_bg.ResumeLayout(false);
            panel_right_bg.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox_main;
        private Panel panel_left_bg;
        private Splitter splitter1;
        private Panel panel_right_bg;
        private TextBox textBox_title;
        private Label label1;
        private TextBox textBox_url;
        private Label label3;
        private TextBox textBox_id;
        private Label label2;
    }
}