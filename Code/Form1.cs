using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kanchon_sMediaPlayer
{
    public partial class FormMediaPlayerform : Form
    {
        public FormMediaPlayerform()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1120, 720);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnclose_MouseHover(object sender, EventArgs e)
        {
            //this.btnclose.BackColor = Color.Black;
        }

        private void btnclose_MouseLeave(object sender, EventArgs e)
        {
            //this.btnclose.BackColor = Color.Transparent;
        }
    }
}
