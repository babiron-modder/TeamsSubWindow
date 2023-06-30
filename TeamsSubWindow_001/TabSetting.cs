using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TeamsSubWindow_001.Main;

namespace TeamsSubWindow_001
{
    public partial class TabSetting : Form
    {
        public TabSetting()
        {
            InitializeComponent();
        }

        private Setting? tab_setting = null;
        private bool is_changed = false;

        private void TabSetting_Load(object sender, EventArgs e)
        {
            try
            {
                listBox_main.Items.Clear();

                // ファイル読み込み
                using (var sr = new StreamReader("setting.json"))
                {
                    var tmp_text = sr.ReadToEnd();

                    tab_setting = JsonSerializer.Deserialize<Setting>(tmp_text);

                }
                if (tab_setting == null) return;
                if (tab_setting.tab == null) return;

                foreach (var i in tab_setting.tab)
                {
                    if (i.title != null)
                    {
                        listBox_main.Items.Add(i.title);
                    }
                    else
                    {
                        listBox_main.Items.Add("");
                    }
                }
            }
            catch
            {
                // 何もしない
            }
            if (listBox_main.Items.Count > 0)
            {
                listBox_main.SelectedIndex = 0;
            }
        }

        private void listBox_main_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tab_setting == null) return;
            if (tab_setting.tab == null) return;

            var tmpchanged = is_changed;

            if (listBox_main.SelectedIndex != -1)
            {
                textBox_title.Text = tab_setting.tab[listBox_main.SelectedIndex].title;
                textBox_id.Text = tab_setting.tab[listBox_main.SelectedIndex].id;
                textBox_url.Text = tab_setting.tab[listBox_main.SelectedIndex].url;
            }

            is_changed = tmpchanged;
        }

        private void TabSetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tab_setting != null)
            {
                if (tab_setting.tab != null)
                {
                    if (listBox_main.SelectedIndex != -1)
                    {
                        if(textBox_title.Text != tab_setting.tab[listBox_main.SelectedIndex].title)
                        {
                            tab_setting.tab[listBox_main.SelectedIndex].title = textBox_title.Text;
                            is_changed = true;
                        }
                        if (textBox_id.Text != tab_setting.tab[listBox_main.SelectedIndex].id)
                        {
                            tab_setting.tab[listBox_main.SelectedIndex].id = textBox_id.Text;
                            is_changed = true;
                        }
                        if (textBox_url.Text != tab_setting.tab[listBox_main.SelectedIndex].url)
                        {
                            tab_setting.tab[listBox_main.SelectedIndex].title = textBox_url.Text;
                            is_changed = true;
                        }

                    }
                }
            }
            if (is_changed)
            {
                DialogResult result = MessageBox.Show("ファイルを上書きしますか？",
                                                    "質問",
                                                    MessageBoxButtons.YesNoCancel,
                                                    MessageBoxIcon.Exclamation,
                                                    MessageBoxDefaultButton.Button2);
                if (result == DialogResult.No)
                {
                    return;
                }
                if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return;
                }

                try
                {
                    if (tab_setting == null)
                    {
                        return;
                    }

                    var options = new JsonSerializerOptions { WriteIndented = true };
                    string jsonString = JsonSerializer.Serialize(tab_setting, options);

                    using (var sw = new StreamWriter("setting.json"))
                    {
                        sw.WriteLine(jsonString);
                    }
                }
                catch
                {
                    // 何もしない
                }
            }
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            if (tab_setting == null) return;
            if (tab_setting.tab == null) return;

            if (listBox_main.SelectedIndex != -1)
            {
                tab_setting.tab[listBox_main.SelectedIndex].title = textBox_title.Text;
                tab_setting.tab[listBox_main.SelectedIndex].id = textBox_id.Text;
                tab_setting.tab[listBox_main.SelectedIndex].url = textBox_url.Text;
                is_changed = true;
            }
        }
    }
}
