namespace Kanchon_sMediaPlayer
{
    partial class FormMediaPlayerform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMediaPlayerform));
            this.menupanel = new System.Windows.Forms.Panel();
            this.btnlocalfiles = new System.Windows.Forms.Button();
            this.btnalbums = new System.Windows.Forms.Button();
            this.btnvideos = new System.Windows.Forms.Button();
            this.btnsongs = new System.Windows.Forms.Button();
            this.btnmedia = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnsettings = new System.Windows.Forms.Button();
            this.btnactivity = new System.Windows.Forms.Button();
            this.btnhome = new System.Windows.Forms.Button();
            this.panellevel = new System.Windows.Forms.Panel();
            this.lvlmenu = new System.Windows.Forms.Label();
            this.panelsearchbar = new System.Windows.Forms.Panel();
            this.textBoxsearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.paneltopbar = new System.Windows.Forms.Panel();
            this.btnminimize = new System.Windows.Forms.Button();
            this.btnmaximize = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.songs1 = new Kanchon_sMediaPlayer.Songs();
            this.videos1 = new Kanchon_sMediaPlayer.Videos();
            this.menupanel.SuspendLayout();
            this.panellevel.SuspendLayout();
            this.panelsearchbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.paneltopbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menupanel
            // 
            this.menupanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.menupanel.Controls.Add(this.btnlocalfiles);
            this.menupanel.Controls.Add(this.btnalbums);
            this.menupanel.Controls.Add(this.btnvideos);
            this.menupanel.Controls.Add(this.btnsongs);
            this.menupanel.Controls.Add(this.btnmedia);
            this.menupanel.Controls.Add(this.panel1);
            this.menupanel.Controls.Add(this.btnsettings);
            this.menupanel.Controls.Add(this.btnactivity);
            this.menupanel.Controls.Add(this.btnhome);
            this.menupanel.Controls.Add(this.panellevel);
            this.menupanel.Controls.Add(this.panelsearchbar);
            this.menupanel.Controls.Add(this.paneltopbar);
            this.menupanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menupanel.Location = new System.Drawing.Point(0, 0);
            this.menupanel.Name = "menupanel";
            this.menupanel.Size = new System.Drawing.Size(245, 720);
            this.menupanel.TabIndex = 0;
            // 
            // btnlocalfiles
            // 
            this.btnlocalfiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnlocalfiles.FlatAppearance.BorderSize = 0;
            this.btnlocalfiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlocalfiles.ForeColor = System.Drawing.Color.White;
            this.btnlocalfiles.Image = ((System.Drawing.Image)(resources.GetObject("btnlocalfiles.Image")));
            this.btnlocalfiles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlocalfiles.Location = new System.Drawing.Point(0, 558);
            this.btnlocalfiles.Name = "btnlocalfiles";
            this.btnlocalfiles.Padding = new System.Windows.Forms.Padding(35, 0, 20, 0);
            this.btnlocalfiles.Size = new System.Drawing.Size(245, 51);
            this.btnlocalfiles.TabIndex = 10;
            this.btnlocalfiles.Text = "Local Files";
            this.btnlocalfiles.UseVisualStyleBackColor = true;
            // 
            // btnalbums
            // 
            this.btnalbums.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnalbums.FlatAppearance.BorderSize = 0;
            this.btnalbums.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnalbums.ForeColor = System.Drawing.Color.White;
            this.btnalbums.Image = ((System.Drawing.Image)(resources.GetObject("btnalbums.Image")));
            this.btnalbums.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnalbums.Location = new System.Drawing.Point(0, 507);
            this.btnalbums.Name = "btnalbums";
            this.btnalbums.Padding = new System.Windows.Forms.Padding(35, 0, 20, 0);
            this.btnalbums.Size = new System.Drawing.Size(245, 51);
            this.btnalbums.TabIndex = 9;
            this.btnalbums.Text = "Albums";
            this.btnalbums.UseVisualStyleBackColor = true;
            // 
            // btnvideos
            // 
            this.btnvideos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnvideos.FlatAppearance.BorderSize = 0;
            this.btnvideos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvideos.ForeColor = System.Drawing.Color.White;
            this.btnvideos.Image = ((System.Drawing.Image)(resources.GetObject("btnvideos.Image")));
            this.btnvideos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnvideos.Location = new System.Drawing.Point(0, 456);
            this.btnvideos.Name = "btnvideos";
            this.btnvideos.Padding = new System.Windows.Forms.Padding(35, 0, 20, 0);
            this.btnvideos.Size = new System.Drawing.Size(245, 51);
            this.btnvideos.TabIndex = 8;
            this.btnvideos.Text = "Videos";
            this.btnvideos.UseVisualStyleBackColor = true;
            // 
            // btnsongs
            // 
            this.btnsongs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnsongs.FlatAppearance.BorderSize = 0;
            this.btnsongs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsongs.ForeColor = System.Drawing.Color.White;
            this.btnsongs.Image = ((System.Drawing.Image)(resources.GetObject("btnsongs.Image")));
            this.btnsongs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsongs.Location = new System.Drawing.Point(0, 405);
            this.btnsongs.Name = "btnsongs";
            this.btnsongs.Padding = new System.Windows.Forms.Padding(35, 0, 20, 0);
            this.btnsongs.Size = new System.Drawing.Size(245, 51);
            this.btnsongs.TabIndex = 7;
            this.btnsongs.Text = "Songs";
            this.btnsongs.UseVisualStyleBackColor = true;
            // 
            // btnmedia
            // 
            this.btnmedia.AutoSize = true;
            this.btnmedia.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmedia.ForeColor = System.Drawing.Color.White;
            this.btnmedia.Location = new System.Drawing.Point(11, 367);
            this.btnmedia.Name = "btnmedia";
            this.btnmedia.Size = new System.Drawing.Size(72, 19);
            this.btnmedia.TabIndex = 1;
            this.btnmedia.Text = "MEDIAS";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 342);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 63);
            this.panel1.TabIndex = 6;
            // 
            // btnsettings
            // 
            this.btnsettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnsettings.FlatAppearance.BorderSize = 0;
            this.btnsettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsettings.ForeColor = System.Drawing.Color.White;
            this.btnsettings.Image = ((System.Drawing.Image)(resources.GetObject("btnsettings.Image")));
            this.btnsettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsettings.Location = new System.Drawing.Point(0, 291);
            this.btnsettings.Name = "btnsettings";
            this.btnsettings.Padding = new System.Windows.Forms.Padding(35, 0, 20, 0);
            this.btnsettings.Size = new System.Drawing.Size(245, 51);
            this.btnsettings.TabIndex = 5;
            this.btnsettings.Text = "Settings";
            this.btnsettings.UseVisualStyleBackColor = true;
            // 
            // btnactivity
            // 
            this.btnactivity.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnactivity.FlatAppearance.BorderSize = 0;
            this.btnactivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnactivity.ForeColor = System.Drawing.Color.White;
            this.btnactivity.Image = ((System.Drawing.Image)(resources.GetObject("btnactivity.Image")));
            this.btnactivity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnactivity.Location = new System.Drawing.Point(0, 240);
            this.btnactivity.Name = "btnactivity";
            this.btnactivity.Padding = new System.Windows.Forms.Padding(35, 0, 20, 0);
            this.btnactivity.Size = new System.Drawing.Size(245, 51);
            this.btnactivity.TabIndex = 4;
            this.btnactivity.Text = "Activity";
            this.btnactivity.UseVisualStyleBackColor = true;
            // 
            // btnhome
            // 
            this.btnhome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnhome.FlatAppearance.BorderSize = 0;
            this.btnhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhome.ForeColor = System.Drawing.Color.White;
            this.btnhome.Image = ((System.Drawing.Image)(resources.GetObject("btnhome.Image")));
            this.btnhome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhome.Location = new System.Drawing.Point(0, 189);
            this.btnhome.Name = "btnhome";
            this.btnhome.Padding = new System.Windows.Forms.Padding(35, 0, 20, 0);
            this.btnhome.Size = new System.Drawing.Size(245, 51);
            this.btnhome.TabIndex = 3;
            this.btnhome.Text = "Home";
            this.btnhome.UseVisualStyleBackColor = true;
            // 
            // panellevel
            // 
            this.panellevel.Controls.Add(this.lvlmenu);
            this.panellevel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panellevel.Location = new System.Drawing.Point(0, 126);
            this.panellevel.Name = "panellevel";
            this.panellevel.Size = new System.Drawing.Size(245, 63);
            this.panellevel.TabIndex = 2;
            // 
            // lvlmenu
            // 
            this.lvlmenu.AutoSize = true;
            this.lvlmenu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlmenu.ForeColor = System.Drawing.Color.White;
            this.lvlmenu.Location = new System.Drawing.Point(11, 28);
            this.lvlmenu.Name = "lvlmenu";
            this.lvlmenu.Size = new System.Drawing.Size(55, 19);
            this.lvlmenu.TabIndex = 0;
            this.lvlmenu.Text = "MAIN";
            // 
            // panelsearchbar
            // 
            this.panelsearchbar.Controls.Add(this.textBoxsearch);
            this.panelsearchbar.Controls.Add(this.pictureBox1);
            this.panelsearchbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelsearchbar.Location = new System.Drawing.Point(0, 50);
            this.panelsearchbar.Name = "panelsearchbar";
            this.panelsearchbar.Size = new System.Drawing.Size(245, 76);
            this.panelsearchbar.TabIndex = 1;
            // 
            // textBoxsearch
            // 
            this.textBoxsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.textBoxsearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxsearch.ForeColor = System.Drawing.Color.White;
            this.textBoxsearch.Location = new System.Drawing.Point(62, 27);
            this.textBoxsearch.Name = "textBoxsearch";
            this.textBoxsearch.Size = new System.Drawing.Size(128, 25);
            this.textBoxsearch.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // paneltopbar
            // 
            this.paneltopbar.Controls.Add(this.btnminimize);
            this.paneltopbar.Controls.Add(this.btnmaximize);
            this.paneltopbar.Controls.Add(this.btnclose);
            this.paneltopbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltopbar.Location = new System.Drawing.Point(0, 0);
            this.paneltopbar.Name = "paneltopbar";
            this.paneltopbar.Size = new System.Drawing.Size(245, 50);
            this.paneltopbar.TabIndex = 0;
            // 
            // btnminimize
            // 
            this.btnminimize.BackColor = System.Drawing.Color.Transparent;
            this.btnminimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnminimize.BackgroundImage")));
            this.btnminimize.FlatAppearance.BorderSize = 0;
            this.btnminimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnminimize.Location = new System.Drawing.Point(57, 12);
            this.btnminimize.Name = "btnminimize";
            this.btnminimize.Size = new System.Drawing.Size(22, 22);
            this.btnminimize.TabIndex = 2;
            this.btnminimize.UseVisualStyleBackColor = false;
            this.btnminimize.Click += new System.EventHandler(this.btnminimize_Click);
            // 
            // btnmaximize
            // 
            this.btnmaximize.BackColor = System.Drawing.Color.Transparent;
            this.btnmaximize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnmaximize.BackgroundImage")));
            this.btnmaximize.FlatAppearance.BorderSize = 0;
            this.btnmaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmaximize.Location = new System.Drawing.Point(36, 12);
            this.btnmaximize.Name = "btnmaximize";
            this.btnmaximize.Size = new System.Drawing.Size(22, 22);
            this.btnmaximize.TabIndex = 1;
            this.btnmaximize.UseVisualStyleBackColor = false;
            this.btnmaximize.Click += new System.EventHandler(this.btnmaximize_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Transparent;
            this.btnclose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnclose.BackgroundImage")));
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Location = new System.Drawing.Point(13, 12);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(22, 22);
            this.btnclose.TabIndex = 0;
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            this.btnclose.MouseLeave += new System.EventHandler(this.btnclose_MouseLeave);
            this.btnclose.MouseHover += new System.EventHandler(this.btnclose_MouseHover);
            // 
            // songs1
            // 
            this.songs1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.songs1.Location = new System.Drawing.Point(245, 0);
            this.songs1.Margin = new System.Windows.Forms.Padding(4);
            this.songs1.Name = "songs1";
            this.songs1.Size = new System.Drawing.Size(875, 720);
            this.songs1.TabIndex = 1;
            // 
            // videos1
            // 
            this.videos1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videos1.Location = new System.Drawing.Point(245, 0);
            this.videos1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.videos1.Name = "videos1";
            this.videos1.Size = new System.Drawing.Size(875, 720);
            this.videos1.TabIndex = 2;
            // 
            // FormMediaPlayerform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 720);
            this.Controls.Add(this.videos1);
            this.Controls.Add(this.songs1);
            this.Controls.Add(this.menupanel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMediaPlayerform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kanchon\'s Media Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menupanel.ResumeLayout(false);
            this.menupanel.PerformLayout();
            this.panellevel.ResumeLayout(false);
            this.panellevel.PerformLayout();
            this.panelsearchbar.ResumeLayout(false);
            this.panelsearchbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.paneltopbar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menupanel;
        private System.Windows.Forms.Panel panelsearchbar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel paneltopbar;
        private System.Windows.Forms.TextBox textBoxsearch;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnminimize;
        private System.Windows.Forms.Button btnmaximize;
        private System.Windows.Forms.Panel panellevel;
        private System.Windows.Forms.Label lvlmenu;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Button btnactivity;
        private System.Windows.Forms.Label btnmedia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnsettings;
        private System.Windows.Forms.Button btnlocalfiles;
        private System.Windows.Forms.Button btnalbums;
        private System.Windows.Forms.Button btnvideos;
        private System.Windows.Forms.Button btnsongs;
        private Songs songs1;
        private Videos videos1;
    }
}

