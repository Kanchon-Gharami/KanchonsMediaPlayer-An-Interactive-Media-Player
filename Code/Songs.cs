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
    public partial class Songs : UserControl
    {
        public Songs()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnmute_Click(object sender, EventArgs e)
        {
            KanchonSongPlayer.settings.volume = 100;
            btnspeaker.BringToFront();
        }

        private void btnspeaker_Click(object sender, EventArgs e)
        {
            KanchonSongPlayer.settings.mute = true;
            btnmute.BringToFront();
        }

        private void Songs_Load(object sender, EventArgs e)
        {

        }

        private void listsongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            vediofile file = listsongs.SelectedItem as vediofile;
            if (file != null)
            {
                KanchonSongPlayer.URL = file.path;   //Path
                KanchonSongPlayer.Ctlcontrols.play();


            }
        }

        private void KanchonSongPlayer_Enter(object sender, EventArgs e)
        {

        }

        private void trackbarvolume_Scroll(object sender, EventArgs e)
        {
            KanchonSongPlayer.settings.playCount = trackbarvolume.Value;
        }

        private void btnplay_Click(object sender, EventArgs e)
        {
            KanchonSongPlayer.Ctlcontrols.play();
            btnpause.BringToFront();
        }

        private void btnpause_Click(object sender, EventArgs e)
        {
            KanchonSongPlayer.Ctlcontrols.pause();
            btnplay.BringToFront();
        }

        private void btnfastreverse_Click(object sender, EventArgs e)
        {
            KanchonSongPlayer.Ctlcontrols.fastReverse();
        }

        private void btnfastforward_Click(object sender, EventArgs e)
        {
            KanchonSongPlayer.Ctlcontrols.fastForward();
        }

        private void btnfullscreen_Click(object sender, EventArgs e)
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
                    listsongs.DataSource = files;
                    //listFile.ValueMember = "Path";
                    //listFile.DisplayMember = "FileName";

                }
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
                    listsongs.DataSource = files;
                    //listFile.ValueMember = "Path";
                    //listFile.DisplayMember = "FileName";

                }
            }
        }

        private void btnplayalbum_Click(object sender, EventArgs e)
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
                    listsongs.DataSource = files;
                    //listFile.ValueMember = "Path";
                    //listFile.DisplayMember = "FileName";

                }
            }
        }
    }
}
