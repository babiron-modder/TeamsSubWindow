using Microsoft.Web.WebView2.WinForms;
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Nodes;
using static System.Net.Mime.MediaTypeNames;

namespace TeamsSubWindow_001
{
    public partial class Main : Form
    {
        public class Setting
        {
            public string? version { get; set; }
            public List<Tab>? tab { get; set; }
        }
        public class Tab
        {
            public string? title { get; set; }
            public string? id { get; set; }
            public string? url { get; set; }

        }


        private async void tabReload()
        {
            try
            {
                tabControl_main.Enabled = false;

                // タブの初期化
                tabControl_main.TabPages.Clear();

                Setting? tab_setting = null;

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
                    TabPage temp_page = new TabPage();
                    WebView2 temp_webview = new WebView2();
                    var env = await Microsoft.Web.WebView2.Core.CoreWebView2Environment.CreateAsync(null, "cache." + i.id);
                    await temp_webview.EnsureCoreWebView2Async(env);
                    if (i.url != null)
                    {
                        temp_webview.Source = new Uri(i.url);
                    }
                    if (i.title != null)
                    {
                        temp_page.Text = i.title;
                    }
                    temp_webview.Dock = DockStyle.Fill;
                    temp_page.Controls.Add(temp_webview);
                    tabControl_main.TabPages.Add(temp_page);
                }
            }
            catch
            {
                // 何もしない
            }

            tabControl_main.Enabled = true;

        }

        public Main()
        {
            InitializeComponent();
            tabReload();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void タブ一覧tToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabSetting tabSetting = new TabSetting();
            tabSetting.ShowDialog();
            tabReload();

        }

    }
}