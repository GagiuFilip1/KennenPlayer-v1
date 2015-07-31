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

namespace KennenPlayerF
{
    public partial class KennenBox : Telerik.WinControls.UI.RadForm
    {
        public KennenBox()
        {
            InitializeComponent();
        }
        private string CurrentPath = "/";
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox3.Hide();
            Vlc.playlist.play();
            Vlc.playlist.items.clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Vlc.playlist.togglePause();
        }
        private void Invisible()
        {
            Upload.FlatAppearance.BorderSize = 0;
            Logout.FlatAppearance.BorderSize = 0;
            Upload.FlatStyle = FlatStyle.Flat;
            Logout.FlatStyle = FlatStyle.Flat;
            Upload.FlatAppearance.MouseOverBackColor = BackColor;
            Logout.FlatAppearance.MouseOverBackColor = BackColor;
            Upload.FlatAppearance.MouseDownBackColor = BackColor;
            Logout.FlatAppearance.MouseDownBackColor = BackColor;
        }
        private void RadForm3_Load(object sender, EventArgs e)
        {
            pictureBox3.Show();
            Invisible();
            if (string.IsNullOrEmpty(Properties.Settings.Default.AccessToken))
            {
                this.GetAccessToken();
                Invisible();
            }
            else
            {
                this.GetFiles();
                Invisible();
            }
        }
        private void GetAccessToken()
        {
            Invisible();
            var login = new DropboxLogin("yxk0rl5wlff50vc", "rqcvwt7pmmqubpp");
            login.Owner = this;
            login.ShowDialog();
            if (login.IsSuccessfully)
            {
                Properties.Settings.Default.AccessToken = login.AccessToken.Value;
                Properties.Settings.Default.Save();
                this.Hide();
                RadForm F6 = new KennenBox();
                F6.ShowDialog();
                this.Close();
            }
            else
            {
                this.Close();
                this.Hide();
            }
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

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
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

                    Vlc.playlist.items.clear();
                    textBox1.Text = (string.Format("https://api-content.dropbox.com/1/files/auto/{0}?access_token={1}", file["path"], Properties.Settings.Default.AccessToken));
                    Vlc.playlist.add((textBox1.Text.Trim().Replace(" ", "%20")));
                }
            }
            this.GetFiles();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RadForm F4 = new KennenManager();
            this.Hide();
            F4.ShowDialog();
            this.Close();
        }

        private void Vlc_Enter(object sender, EventArgs e)
        {
           
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            RadForm A1 = new KennenChoose();
            this.Hide();
            Properties.Settings.Default.Reset();
            A1.ShowDialog();
            this.Close();
        }
    }
}
