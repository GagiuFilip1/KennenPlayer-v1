namespace KennenPlayerF
{
    partial class KennenManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KennenManager));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.butonu = new System.Windows.Forms.Button();
            this.Pls = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Down = new System.Windows.Forms.Button();
            this.radProgressBar1 = new Telerik.WinControls.UI.RadProgressBar();
            this.windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.radProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(-1, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(274, 342);
            this.listBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(279, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 20);
            this.textBox1.TabIndex = 1;
            // 
            // butonu
            // 
            this.butonu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butonu.BackgroundImage = global::KennenPlayerF.Properties.Resources._230_blue_clouds_2560x1600_digital_art_wallpaper1;
            this.butonu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butonu.Location = new System.Drawing.Point(470, 12);
            this.butonu.Name = "butonu";
            this.butonu.Size = new System.Drawing.Size(104, 23);
            this.butonu.TabIndex = 2;
            this.butonu.Text = "Create Folder";
            this.butonu.UseVisualStyleBackColor = true;
            // 
            // Pls
            // 
            this.Pls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Pls.BackgroundImage = global::KennenPlayerF.Properties.Resources._230_blue_clouds_2560x1600_digital_art_wallpaper1;
            this.Pls.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pls.Location = new System.Drawing.Point(470, 41);
            this.Pls.Name = "Pls";
            this.Pls.Size = new System.Drawing.Size(104, 23);
            this.Pls.TabIndex = 3;
            this.Pls.Text = "Upload";
            this.Pls.UseVisualStyleBackColor = true;
            // 
            // Back
            // 
            this.Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Back.BackgroundImage = global::KennenPlayerF.Properties.Resources.back_button_300x120;
            this.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Back.Location = new System.Drawing.Point(474, 305);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(100, 37);
            this.Back.TabIndex = 4;
            this.Back.UseVisualStyleBackColor = true;
            // 
            // Down
            // 
            this.Down.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Down.BackgroundImage = global::KennenPlayerF.Properties.Resources._230_blue_clouds_2560x1600_digital_art_wallpaper;
            this.Down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Down.Location = new System.Drawing.Point(279, 103);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(97, 26);
            this.Down.TabIndex = 5;
            this.Down.Text = "Download";
            this.Down.UseVisualStyleBackColor = true;
            this.Down.Click += new System.EventHandler(this.button1_Click);
            // 
            // radProgressBar1
            // 
            this.radProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radProgressBar1.Location = new System.Drawing.Point(376, 104);
            this.radProgressBar1.Name = "radProgressBar1";
            this.radProgressBar1.Size = new System.Drawing.Size(198, 24);
            this.radProgressBar1.TabIndex = 6;
            this.radProgressBar1.ThemeName = "Windows8";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // KennenManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KennenPlayerF.Properties.Resources._230_blue_clouds_2560x1600_digital_art_wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(581, 341);
            this.Controls.Add(this.radProgressBar1);
            this.Controls.Add(this.Down);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Pls);
            this.Controls.Add(this.butonu);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KennenManager";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "KennenPlayer";
            this.ThemeName = "Windows7";
            this.Load += new System.EventHandler(this.RadForm4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button butonu;
        private System.Windows.Forms.Button Pls;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Down;
        private Telerik.WinControls.UI.RadProgressBar radProgressBar1;
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
