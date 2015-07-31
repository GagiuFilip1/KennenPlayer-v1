using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nemiro.OAuth;
using Nemiro.OAuth.LoginForms;
using Telerik.WinControls.UI;
using System.IO;
using System.Net;

namespace KennenPlayerF
{
    public partial class KennenManager : Telerik.WinControls.UI.RadForm
    {
        public KennenManager()
        {
            InitializeComponent();
        }
        private string CurrentPath = "/";
        private void Invisible()
        {
            butonu.FlatAppearance.BorderSize = 1;
            Pls.FlatAppearance.BorderSize = 1;
            Back.FlatAppearance.BorderSize = 0;
            Down.FlatAppearance.BorderSize = 1;
            Back.FlatStyle = FlatStyle.Flat;
            Down.FlatStyle = FlatStyle.Flat;
            Back.FlatAppearance.MouseOverBackColor = BackColor;
            Down.FlatAppearance.MouseOverBackColor = BackColor;
            Back.FlatAppearance.MouseDownBackColor = BackColor;
            Down.FlatAppearance.MouseDownBackColor = BackColor;
        }
        private void RadForm4_Load(object sender, EventArgs e)
        {
            BackColor = Color.Transparent;
            Invisible();
            if (string.IsNullOrEmpty(Properties.Settings.Default.AccessToken))
            {
                this.GetAccessToken();
            }
            else
            {
                this.GetFiles();
            }
        }
        private void GetAccessToken()
        {
            // no need
        }
        private void GetFiles()
        {
            OAuthUtility.GetAsync("https://api.dropbox.com/1/metadata/auto/",
                new HttpParameterCollection
                {
                    {
                        "path", this.CurrentPath
                    },
                    
                    {
                        "access_token", Properties.Settings.Default.AccessToken
                    }
                },
                callback: GetFiles_Result
                );
        }
        private void GetFiles_Result(RequestResult result)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<RequestResult>(GetFiles_Result), result);
                return;
            }

            if (result.StatusCode == 200)
            {
                listBox1.Items.Clear();
                listBox1.DisplayMember = "path";
                foreach (UniValue file in result["contents"])
                {
                    listBox1.Items.Add(file);
                }
                if (this.CurrentPath != "/")
                {
                    listBox1.Items.Insert(0, UniValue.ParseJson("{path: '..'}"));
                }
            }
            else
            {
                MessageBox.Show("Sorry man");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) { return; }
            UniValue file = (UniValue)listBox1.SelectedItem;

            if (file["path"] == "..")
            {
                if (this.CurrentPath != "/")
                {
                    this.CurrentPath = Path.GetDirectoryName(this.CurrentPath).Replace("\\", "/");
                }
            }
            else
            {
                if (file["is_dir"] == 1)
                {
                    this.CurrentPath = file["path"].ToString();
                }
                else
                {
                    saveFileDialog1.FileName = Path.GetFileName(file["path"].ToString());
                    if (saveFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                    {
                        return;
                    }
                    var web = new WebClient();
                    web.DownloadProgressChanged += DownloadProgressChanged;
                    web.DownloadFileAsync(new Uri(string.Format("https://api-content.dropbox.com/1/files/auto/{0}?access_token={1}", file["path"], Properties.Settings.Default.AccessToken)), saveFileDialog1.FileName);
                    
                }
            }
            this.GetFiles();
        }
        private void DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            radProgressBar1.Value1 = e.ProgressPercentage;
            radProgressBar1.Value2 = e.ProgressPercentage;

        }
    }
}
