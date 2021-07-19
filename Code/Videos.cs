using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Kanchon_sMediaPlayer
{
    public partial class Videos : UserControl
    {
        public Videos()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            btnmute.BringToFront();
        }

        private void btnplay_Click(object sender, EventArgs e)
        {
            btnpause.BringToFront();
        }

        private void btnpause_Click(object sender, EventArgs e)
        {
            btnplay.BringToFront();
        }

        private void btnmute_Click(object sender, EventArgs e)
        {
            btnspeaker.BringToFront();
        }

        private void trackbarvolume_Scroll(object sender, EventArgs e)
        {

        }

        private void listFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            vediofile file = listFile.SelectedItem as vediofile;
            if (file != null)
            {
                KanchonMediaPlayer.URL = file.path;   //Path
                KanchonMediaPlayer.Ctlcontrols.play();


            }
        }

        private void btnplaysong_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = true, ValidateNames = true, Filter = "MP4|*.mp4|WMV|*.wmv|WAV|*.wav|MP3|*.mp3|MKV|*.mkv" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    List<vediofile> files = new List<vediofile>();
                    foreach (string filename in ofd.FileNames)
                    {
                        FileInfo fi = new FileInfo(filename);
                        files.Add(new vediofile() { FileName = Path.GetFileNameWithoutExtension(fi.FullName), path = fi.FullName });
                    }
                    listFile.DataSource = files;
                    //listFile.ValueMember = "Path";
                    //listFile.DisplayMember = "FileName";

                }
            }
        }

        private void contant_Paint(object sender, PaintEventArgs e)
        {
            listFile.ValueMember = "Path";
            listFile.DisplayMember = "FileName";
        }

        private void btnplay_Click_1(object sender, EventArgs e)
        {
            KanchonMediaPlayer.Ctlcontrols.play();
            btnpause.BringToFront();
        }

        private void btnpause_Click_1(object sender, EventArgs e)
        {
            KanchonMediaPlayer.Ctlcontrols.pause();
            btnplay.BringToFront();
        }

        private void btnspeaker_Click(object sender, EventArgs e)
        {
            KanchonMediaPlayer.settings.mute = true;
            btnmute.BringToFront();
        }

        private void btnfastforward_Click(object sender, EventArgs e)
        {
            KanchonMediaPlayer.Ctlcontrols.fastForward();
        }

        private void btnfastreverse_Click(object sender, EventArgs e)
        {
            KanchonMediaPlayer.Ctlcontrols.fastReverse();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            KanchonMediaPlayer.Ctlcontrols.next();
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            KanchonMediaPlayer.Ctlcontrols.previous();
        }

        private void btnfullscreen_Click(object sender, EventArgs e)
        {

        }

        private void btnmute_Click_1(object sender, EventArgs e)
        {
            KanchonMediaPlayer.settings.volume = 100;
            btnspeaker.BringToFront();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void trackbarvolume_Scroll_1(object sender, EventArgs e)
        {
            KanchonMediaPlayer.settings.playCount = trackbarvolume.Value;
            //volvalue.Text = trackbarvolume.Value.ToString();
        }

        private void KanchonMediaPlayer_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
