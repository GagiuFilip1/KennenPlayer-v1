using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace KennenPlayerF
{
    public partial class KennenStandard : Telerik.WinControls.UI.RadForm
    {
        public KennenStandard()
        {
            InitializeComponent();
        }

        private void Invisible()
        {
            checkBox1.FlatAppearance.BorderSize = 1;
            Back.FlatAppearance.BorderSize = 0;
            Back.FlatStyle = FlatStyle.Flat;
            checkBox1.FlatStyle = FlatStyle.Flat;
            Back.FlatAppearance.MouseOverBackColor = BackColor;
            checkBox1.FlatAppearance.MouseDownBackColor = BackColor;
            Back.FlatAppearance.MouseDownBackColor = BackColor;
            checkBox1.FlatAppearance.MouseDownBackColor = BackColor;
        }
        private void start()
        {
        }
        private void RadForm2_Load(object sender, EventArgs e)
        {
            BackColor = Color.Transparent;
            pictureBox3.Hide();
            Invisible();
           
        }

        private void Back_Click(object sender, EventArgs e)
        {
            KennenChoose F3 = new KennenChoose();
            this.Hide();
            F3.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            Vlc.playlist.play();
          Vlc.playlist.items.clear();
          pictureBox3.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Vlc.playlist.togglePause();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFile = new OpenFileDialog();
            OpenFile.Filter = "Videos *(.webm;.mkv;.flv;.vob;.ogv;.ogg;.drc;.mng;.avi;.mov;.qt;.wmv;.yuv;.rm;.rmvb;.asf;.mp4;.m4p;.m4v;.mpg;.mpeg;.svi;.3gp;.3g2;.mxf;.roq;.nsv |*.webm;*.mkv;*.flv;*.vob;*.ogv;*.ogg;*.drc;*.mng;*.avi;*.mov;*.qt;*.wmv;*.yuv;*.rm;*.rmvb;*.asf;*.mp4;*.m4p;*.m4v;*.mpg;*.mpeg;*.svi;*.3gp;*.3g2;*.mxf;*.roq;*.nsv ";
            OpenFile.Multiselect = true;
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                Vlc.playlist.add("file:///" + OpenFile.FileName, OpenFile.SafeFileName, null);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Vlc.subtitle.track = -1;
            Vlc.video.subtitle = -1;
        }
    }
}
