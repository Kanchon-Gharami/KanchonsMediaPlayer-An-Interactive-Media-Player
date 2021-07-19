namespace Kanchon_sMediaPlayer
{
    partial class Songs
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Songs));
            this.panel1 = new System.Windows.Forms.Panel();
            this.trackbarvolume = new System.Windows.Forms.TrackBar();
            this.btnspeaker = new System.Windows.Forms.Button();
            this.btnplay = new System.Windows.Forms.Button();
            this.btnpause = new System.Windows.Forms.Button();
            this.btnmute = new System.Windows.Forms.Button();
            this.btnalbum = new System.Windows.Forms.Button();
            this.btnsettings = new System.Windows.Forms.Button();
            this.btnfastforward = new System.Windows.Forms.Button();
            this.btnfastreverse = new System.Windows.Forms.Button();
            this.btnprevious = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxmusicname = new System.Windows.Forms.TextBox();
            this.lvlfinishtimer = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.KanchonsMediaPlayer = new System.Windows.Forms.Label();
            this.panelbanner = new System.Windows.Forms.Panel();
            this.btnplayalbum = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnplaysong = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picboxbanner = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lvlstarttimer = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panelcontant = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.listsongs = new System.Windows.Forms.ListBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.KanchonSongPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarvolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelbanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxbanner)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panelcontant.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KanchonSongPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 620);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 100);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // trackbarvolume
            // 
            this.trackbarvolume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackbarvolume.Location = new System.Drawing.Point(0, 0);
            this.trackbarvolume.Name = "trackbarvolume";
            this.trackbarvolume.Size = new System.Drawing.Size(147, 56);
            this.trackbarvolume.TabIndex = 16;
            this.trackbarvolume.Scroll += new System.EventHandler(this.trackbarvolume_Scroll);
            // 
            // btnspeaker
            // 
            this.btnspeaker.FlatAppearance.BorderSize = 0;
            this.btnspeaker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnspeaker.ForeColor = System.Drawing.Color.White;
            this.btnspeaker.Image = ((System.Drawing.Image)(resources.GetObject("btnspeaker.Image")));
            this.btnspeaker.Location = new System.Drawing.Point(18, 3);
            this.btnspeaker.Name = "btnspeaker";
            this.btnspeaker.Size = new System.Drawing.Size(24, 24);
            this.btnspeaker.TabIndex = 13;
            this.btnspeaker.UseVisualStyleBackColor = true;
            this.btnspeaker.Click += new System.EventHandler(this.btnspeaker_Click);
            // 
            // btnplay
            // 
            this.btnplay.FlatAppearance.BorderSize = 0;
            this.btnplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnplay.ForeColor = System.Drawing.Color.White;
            this.btnplay.Image = ((System.Drawing.Image)(resources.GetObject("btnplay.Image")));
            this.btnplay.Location = new System.Drawing.Point(50, 14);
            this.btnplay.Name = "btnplay";
            this.btnplay.Size = new System.Drawing.Size(49, 45);
            this.btnplay.TabIndex = 6;
            this.btnplay.UseVisualStyleBackColor = true;
            this.btnplay.Click += new System.EventHandler(this.btnplay_Click);
            // 
            // btnpause
            // 
            this.btnpause.FlatAppearance.BorderSize = 0;
            this.btnpause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpause.ForeColor = System.Drawing.Color.White;
            this.btnpause.Image = ((System.Drawing.Image)(resources.GetObject("btnpause.Image")));
            this.btnpause.Location = new System.Drawing.Point(50, 14);
            this.btnpause.Name = "btnpause";
            this.btnpause.Size = new System.Drawing.Size(49, 45);
            this.btnpause.TabIndex = 15;
            this.btnpause.UseVisualStyleBackColor = true;
            this.btnpause.Click += new System.EventHandler(this.btnpause_Click);
            // 
            // btnmute
            // 
            this.btnmute.FlatAppearance.BorderSize = 0;
            this.btnmute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmute.ForeColor = System.Drawing.Color.White;
            this.btnmute.Image = ((System.Drawing.Image)(resources.GetObject("btnmute.Image")));
            this.btnmute.Location = new System.Drawing.Point(20, 3);
            this.btnmute.Name = "btnmute";
            this.btnmute.Size = new System.Drawing.Size(24, 24);
            this.btnmute.TabIndex = 14;
            this.btnmute.UseVisualStyleBackColor = true;
            this.btnmute.Click += new System.EventHandler(this.btnmute_Click);
            // 
            // btnalbum
            // 
            this.btnalbum.FlatAppearance.BorderSize = 0;
            this.btnalbum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnalbum.ForeColor = System.Drawing.Color.White;
            this.btnalbum.Image = ((System.Drawing.Image)(resources.GetObject("btnalbum.Image")));
            this.btnalbum.Location = new System.Drawing.Point(177, 20);
            this.btnalbum.Name = "btnalbum";
            this.btnalbum.Size = new System.Drawing.Size(34, 34);
            this.btnalbum.TabIndex = 12;
            this.btnalbum.UseVisualStyleBackColor = true;
            this.btnalbum.Click += new System.EventHandler(this.btnfullscreen_Click);
            // 
            // btnsettings
            // 
            this.btnsettings.FlatAppearance.BorderSize = 0;
            this.btnsettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsettings.ForeColor = System.Drawing.Color.White;
            this.btnsettings.Image = ((System.Drawing.Image)(resources.GetObject("btnsettings.Image")));
            this.btnsettings.Location = new System.Drawing.Point(297, 20);
            this.btnsettings.Name = "btnsettings";
            this.btnsettings.Size = new System.Drawing.Size(34, 34);
            this.btnsettings.TabIndex = 11;
            this.btnsettings.UseVisualStyleBackColor = true;
            // 
            // btnfastforward
            // 
            this.btnfastforward.FlatAppearance.BorderSize = 0;
            this.btnfastforward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfastforward.ForeColor = System.Drawing.Color.White;
            this.btnfastforward.Image = ((System.Drawing.Image)(resources.GetObject("btnfastforward.Image")));
            this.btnfastforward.Location = new System.Drawing.Point(257, 20);
            this.btnfastforward.Name = "btnfastforward";
            this.btnfastforward.Size = new System.Drawing.Size(34, 34);
            this.btnfastforward.TabIndex = 10;
            this.btnfastforward.UseVisualStyleBackColor = true;
            this.btnfastforward.Click += new System.EventHandler(this.btnfastforward_Click);
            // 
            // btnfastreverse
            // 
            this.btnfastreverse.FlatAppearance.BorderSize = 0;
            this.btnfastreverse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfastreverse.ForeColor = System.Drawing.Color.White;
            this.btnfastreverse.Image = ((System.Drawing.Image)(resources.GetObject("btnfastreverse.Image")));
            this.btnfastreverse.Location = new System.Drawing.Point(217, 20);
            this.btnfastreverse.Name = "btnfastreverse";
            this.btnfastreverse.Size = new System.Drawing.Size(34, 34);
            this.btnfastreverse.TabIndex = 9;
            this.btnfastreverse.UseVisualStyleBackColor = true;
            this.btnfastreverse.Click += new System.EventHandler(this.btnfastreverse_Click);
            // 
            // btnprevious
            // 
            this.btnprevious.FlatAppearance.BorderSize = 0;
            this.btnprevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprevious.ForeColor = System.Drawing.Color.White;
            this.btnprevious.Image = ((System.Drawing.Image)(resources.GetObject("btnprevious.Image")));
            this.btnprevious.Location = new System.Drawing.Point(25, 15);
            this.btnprevious.Name = "btnprevious";
            this.btnprevious.Size = new System.Drawing.Size(26, 45);
            this.btnprevious.TabIndex = 8;
            this.btnprevious.UseVisualStyleBackColor = true;
            // 
            // btnnext
            // 
            this.btnnext.FlatAppearance.BorderSize = 0;
            this.btnnext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnext.ForeColor = System.Drawing.Color.White;
            this.btnnext.Image = ((System.Drawing.Image)(resources.GetObject("btnnext.Image")));
            this.btnnext.Location = new System.Drawing.Point(99, 14);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(22, 45);
            this.btnnext.TabIndex = 7;
            this.btnnext.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Papyrus", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "enjoy";
            // 
            // txtboxmusicname
            // 
            this.txtboxmusicname.BackColor = System.Drawing.Color.Black;
            this.txtboxmusicname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxmusicname.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtboxmusicname.Font = new System.Drawing.Font("Papyrus", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxmusicname.ForeColor = System.Drawing.Color.White;
            this.txtboxmusicname.Location = new System.Drawing.Point(0, 0);
            this.txtboxmusicname.Multiline = true;
            this.txtboxmusicname.Name = "txtboxmusicname";
            this.txtboxmusicname.Size = new System.Drawing.Size(165, 29);
            this.txtboxmusicname.TabIndex = 4;
            this.txtboxmusicname.Text = "music name";
            // 
            // lvlfinishtimer
            // 
            this.lvlfinishtimer.AutoSize = true;
            this.lvlfinishtimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvlfinishtimer.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlfinishtimer.ForeColor = System.Drawing.Color.White;
            this.lvlfinishtimer.Location = new System.Drawing.Point(0, 0);
            this.lvlfinishtimer.Name = "lvlfinishtimer";
            this.lvlfinishtimer.Padding = new System.Windows.Forms.Padding(10, 15, 0, 0);
            this.lvlfinishtimer.Size = new System.Drawing.Size(47, 35);
            this.lvlfinishtimer.TabIndex = 3;
            this.lvlfinishtimer.Text = "0.00";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(118, 100);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(96)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(52, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(96)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Just Play And Enjoy";
            // 
            // KanchonsMediaPlayer
            // 
            this.KanchonsMediaPlayer.AutoSize = true;
            this.KanchonsMediaPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(96)))));
            this.KanchonsMediaPlayer.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KanchonsMediaPlayer.ForeColor = System.Drawing.Color.White;
            this.KanchonsMediaPlayer.Location = new System.Drawing.Point(46, 105);
            this.KanchonsMediaPlayer.Name = "KanchonsMediaPlayer";
            this.KanchonsMediaPlayer.Size = new System.Drawing.Size(184, 34);
            this.KanchonsMediaPlayer.TabIndex = 1;
            this.KanchonsMediaPlayer.Text = "Music Player";
            // 
            // panelbanner
            // 
            this.panelbanner.Controls.Add(this.btnplayalbum);
            this.panelbanner.Controls.Add(this.pictureBox3);
            this.panelbanner.Controls.Add(this.btnplaysong);
            this.panelbanner.Controls.Add(this.pictureBox2);
            this.panelbanner.Controls.Add(this.pictureBox1);
            this.panelbanner.Controls.Add(this.label1);
            this.panelbanner.Controls.Add(this.KanchonsMediaPlayer);
            this.panelbanner.Controls.Add(this.picboxbanner);
            this.panelbanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelbanner.Location = new System.Drawing.Point(0, 0);
            this.panelbanner.Name = "panelbanner";
            this.panelbanner.Size = new System.Drawing.Size(875, 220);
            this.panelbanner.TabIndex = 2;
            // 
            // btnplayalbum
            // 
            this.btnplayalbum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(96)))));
            this.btnplayalbum.FlatAppearance.BorderSize = 0;
            this.btnplayalbum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnplayalbum.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplayalbum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(84)))));
            this.btnplayalbum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnplayalbum.Location = new System.Drawing.Point(182, 142);
            this.btnplayalbum.Name = "btnplayalbum";
            this.btnplayalbum.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnplayalbum.Size = new System.Drawing.Size(130, 32);
            this.btnplayalbum.TabIndex = 8;
            this.btnplayalbum.Text = "Play Album";
            this.btnplayalbum.UseVisualStyleBackColor = false;
            this.btnplayalbum.Click += new System.EventHandler(this.btnplayalbum_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(96)))));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(179, 138);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(139, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // btnplaysong
            // 
            this.btnplaysong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(96)))));
            this.btnplaysong.FlatAppearance.BorderSize = 0;
            this.btnplaysong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnplaysong.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplaysong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(84)))));
            this.btnplaysong.Image = ((System.Drawing.Image)(resources.GetObject("btnplaysong.Image")));
            this.btnplaysong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnplaysong.Location = new System.Drawing.Point(41, 142);
            this.btnplaysong.Name = "btnplaysong";
            this.btnplaysong.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnplaysong.Size = new System.Drawing.Size(130, 32);
            this.btnplaysong.TabIndex = 6;
            this.btnplaysong.Text = "Play Song";
            this.btnplaysong.UseVisualStyleBackColor = false;
            this.btnplaysong.Click += new System.EventHandler(this.btnplaysong_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(96)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(38, 138);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(135, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // picboxbanner
            // 
            this.picboxbanner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picboxbanner.Image = ((System.Drawing.Image)(resources.GetObject("picboxbanner.Image")));
            this.picboxbanner.Location = new System.Drawing.Point(0, 0);
            this.picboxbanner.Name = "picboxbanner";
            this.picboxbanner.Size = new System.Drawing.Size(875, 220);
            this.picboxbanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxbanner.TabIndex = 0;
            this.picboxbanner.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(118, 100);
            this.panel2.TabIndex = 16;
            // 
            // lvlstarttimer
            // 
            this.lvlstarttimer.AutoSize = true;
            this.lvlstarttimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvlstarttimer.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlstarttimer.ForeColor = System.Drawing.Color.White;
            this.lvlstarttimer.Location = new System.Drawing.Point(0, 0);
            this.lvlstarttimer.Name = "lvlstarttimer";
            this.lvlstarttimer.Padding = new System.Windows.Forms.Padding(20, 15, 0, 0);
            this.lvlstarttimer.Size = new System.Drawing.Size(57, 35);
            this.lvlstarttimer.TabIndex = 17;
            this.lvlstarttimer.Text = "0.00";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel12);
            this.panel4.Controls.Add(this.panel11);
            this.panel4.Controls.Add(this.panel10);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(118, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(757, 38);
            this.panel4.TabIndex = 17;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(118, 38);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(165, 62);
            this.panel5.TabIndex = 18;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtboxmusicname);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(165, 62);
            this.panel6.TabIndex = 19;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnpause);
            this.panel7.Controls.Add(this.btnfastforward);
            this.panel7.Controls.Add(this.btnplay);
            this.panel7.Controls.Add(this.btnfastreverse);
            this.panel7.Controls.Add(this.btnprevious);
            this.panel7.Controls.Add(this.btnalbum);
            this.panel7.Controls.Add(this.btnsettings);
            this.panel7.Controls.Add(this.btnnext);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(283, 38);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(592, 62);
            this.panel7.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.trackbarvolume);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(728, 38);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(147, 62);
            this.panel8.TabIndex = 19;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnspeaker);
            this.panel9.Controls.Add(this.btnmute);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(674, 38);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(54, 62);
            this.panel9.TabIndex = 20;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.lvlstarttimer);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(69, 38);
            this.panel10.TabIndex = 0;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.lvlfinishtimer);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel11.Location = new System.Drawing.Point(661, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(96, 38);
            this.panel11.TabIndex = 1;
            // 
            // panel12
            // 
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(69, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(592, 38);
            this.panel12.TabIndex = 2;
            // 
            // panelcontant
            // 
            this.panelcontant.Controls.Add(this.panel13);
            this.panelcontant.Controls.Add(this.panel3);
            this.panelcontant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontant.Location = new System.Drawing.Point(0, 220);
            this.panelcontant.Name = "panelcontant";
            this.panelcontant.Size = new System.Drawing.Size(875, 400);
            this.panelcontant.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.panel15);
            this.panel3.Controls.Add(this.panel14);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(658, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(217, 400);
            this.panel3.TabIndex = 0;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.pictureBox5);
            this.panel13.Controls.Add(this.KanchonSongPlayer);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(658, 400);
            this.panel13.TabIndex = 1;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Transparent;
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(0, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(217, 15);
            this.panel14.TabIndex = 0;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.Transparent;
            this.panel15.Controls.Add(this.listsongs);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel15.Location = new System.Drawing.Point(16, 15);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(201, 385);
            this.panel15.TabIndex = 1;
            // 
            // listsongs
            // 
            this.listsongs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.listsongs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listsongs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listsongs.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listsongs.ForeColor = System.Drawing.Color.White;
            this.listsongs.FormattingEnabled = true;
            this.listsongs.ItemHeight = 21;
            this.listsongs.Location = new System.Drawing.Point(0, 0);
            this.listsongs.Name = "listsongs";
            this.listsongs.Size = new System.Drawing.Size(201, 385);
            this.listsongs.TabIndex = 0;
            this.listsongs.SelectedIndexChanged += new System.EventHandler(this.listsongs_SelectedIndexChanged);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox5.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.ErrorImage")));
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.InitialImage")));
            this.pictureBox5.Location = new System.Drawing.Point(0, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(658, 400);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // KanchonSongPlayer
            // 
            this.KanchonSongPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KanchonSongPlayer.Enabled = true;
            this.KanchonSongPlayer.Location = new System.Drawing.Point(0, 0);
            this.KanchonSongPlayer.Name = "KanchonSongPlayer";
            this.KanchonSongPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("KanchonSongPlayer.OcxState")));
            this.KanchonSongPlayer.Size = new System.Drawing.Size(658, 400);
            this.KanchonSongPlayer.TabIndex = 0;
            this.KanchonSongPlayer.Enter += new System.EventHandler(this.KanchonSongPlayer_Enter);
            // 
            // Songs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelcontant);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelbanner);
            this.Name = "Songs";
            this.Size = new System.Drawing.Size(875, 720);
            this.Load += new System.EventHandler(this.Songs_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackbarvolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelbanner.ResumeLayout(false);
            this.panelbanner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxbanner)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panelcontant.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KanchonSongPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar trackbarvolume;
        private System.Windows.Forms.Button btnspeaker;
        private System.Windows.Forms.Button btnplay;
        private System.Windows.Forms.Button btnpause;
        private System.Windows.Forms.Button btnmute;
        private System.Windows.Forms.Button btnalbum;
        private System.Windows.Forms.Button btnsettings;
        private System.Windows.Forms.Button btnfastforward;
        private System.Windows.Forms.Button btnfastreverse;
        private System.Windows.Forms.Button btnprevious;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxmusicname;
        private System.Windows.Forms.Label lvlfinishtimer;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label KanchonsMediaPlayer;
        private System.Windows.Forms.Panel panelbanner;
        private System.Windows.Forms.Button btnplayalbum;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnplaysong;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picboxbanner;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lvlstarttimer;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panelcontant;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.ListBox listsongs;
        private System.Windows.Forms.Panel panel14;
        private AxWMPLib.AxWindowsMediaPlayer KanchonSongPlayer;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}
