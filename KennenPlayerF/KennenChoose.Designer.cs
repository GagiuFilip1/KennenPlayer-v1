namespace KennenPlayerF
{
    partial class KennenChoose
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KennenChoose));
            this.windows7Theme1 = new Telerik.WinControls.Themes.Windows7Theme();
            this.butonu = new System.Windows.Forms.Button();
            this.Pls = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // butonu
            // 
            this.butonu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butonu.BackgroundImage = global::KennenPlayerF.Properties.Resources.Untitled_1;
            this.butonu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butonu.Location = new System.Drawing.Point(12, 311);
            this.butonu.Name = "butonu";
            this.butonu.Size = new System.Drawing.Size(178, 133);
            this.butonu.TabIndex = 0;
            this.butonu.UseVisualStyleBackColor = true;
            this.butonu.Click += new System.EventHandler(this.butonu_Click);
            // 
            // Pls
            // 
            this.Pls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Pls.BackgroundImage = global::KennenPlayerF.Properties.Resources.unnamesd;
            this.Pls.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pls.Location = new System.Drawing.Point(422, 311);
            this.Pls.Name = "Pls";
            this.Pls.Size = new System.Drawing.Size(178, 133);
            this.Pls.TabIndex = 1;
            this.Pls.UseVisualStyleBackColor = true;
            this.Pls.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox1.Image = global::KennenPlayerF.Properties.Resources.choose;
            this.pictureBox1.Location = new System.Drawing.Point(196, 365);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // KennenChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KennenPlayerF.Properties.Resources.GOD_DAMN_POSTER;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(612, 456);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Pls);
            this.Controls.Add(this.butonu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KennenChoose";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "KennenPlayer";
            this.ThemeName = "Windows7";
            this.Load += new System.EventHandler(this.RadForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.Windows7Theme windows7Theme1;
        private System.Windows.Forms.Button butonu;
        private System.Windows.Forms.Button Pls;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}