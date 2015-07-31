using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace KennenPlayerF
{
    public partial class KennenChoose : Telerik.WinControls.UI.RadForm
    {
        public KennenChoose()
        {
            InitializeComponent();
        }

        private void invisible()
        {
            butonu.FlatAppearance.BorderSize = 0;
            Pls.FlatAppearance.BorderSize = 0;
            butonu.FlatStyle = FlatStyle.Flat;
            Pls.FlatStyle = FlatStyle.Flat;
            butonu.FlatAppearance.MouseOverBackColor = BackColor;
            Pls.FlatAppearance.MouseOverBackColor = BackColor;
            butonu.FlatAppearance.MouseDownBackColor = BackColor;
            Pls.FlatAppearance.MouseDownBackColor = BackColor;
            butonu.FlatAppearance.BorderColor = Color.DarkRed;
            Pls.FlatAppearance.BorderColor = Color.DarkRed;
        }
        private void RadForm1_Load(object sender, EventArgs e)
        {
            BackColor = Color.Transparent;
            invisible();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RadForm F2 = new Settiings();
            this.Hide();
            F2.ShowDialog();
            this.Close();
        }

        private void butonu_Click(object sender, EventArgs e)
        {
            RadForm F1 = new KennenStandard();
            this.Hide();
            F1.ShowDialog();
            this.Close();
        }
    }
}
