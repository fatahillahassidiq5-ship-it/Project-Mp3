using System.Drawing.Drawing2D;
using System.Security.Cryptography.X509Certificates;

namespace MyMp3Player
{
    public partial class Form1 : Form
    {
        Mp3Player mp3Player = new Mp3Player();

        List<string> playlistPaths = new List<string>();

        bool isPlaying = false;
        bool drag = false;
        Point start_point = new Point(0, 0);
        public Form1()
        {
            InitializeComponent();

            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, btnPlay.Width, btnPlay.Height);
            btnPlay.Region = new Region(path);
        }


        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (playlistBox.Items.Count == 0)
            {
                MessageBox.Show("Playlist Kosong! oh noo tetapi saya tahu bagaiana cara memperbaikinya tekan tombol folder dan pilih file mana yang ingin di putar");
                return;
            }
            if (isPlaying)
            {
                mp3Player.Pause();
                timer1.Stop();
                isPlaying = false;
            }
            else
            {
                if (playlistBox.SelectedIndex == -1) playlistBox.SelectedIndex = 0;

                if (trackBar.Value == 0) PlaySelectedSong();
                else
                {
                    mp3Player.Play();
                    timer1.Start();
                }
                isPlaying = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Music Files|*.mp3; *.wav";
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in ofd.FileNames)
                {
                    playlistPaths.Add(file);
                    playlistBox.Items.Add(Path.GetFileName(file));
                }
                if (playlistPaths.Count > 0 && !isPlaying)
                {
                    playlistBox.SelectedIndex = playlistBox.Items.Count - ofd.FileName.Length;
                    PlaySelectedSong();
                }
            }
        }

        private void PlaySelectedSong()
        {
            if (playlistBox.SelectedIndex != -1)
            {
                string filetoPlay = playlistPaths[playlistBox.SelectedIndex];

                mp3Player.Open(filetoPlay);
                mp3Player.Play();

                isPlaying = true;
                timer1.Start();

                int lenghtInSeconds = mp3Player.GetLenght();
                trackBar.Maximum = lenghtInSeconds;
                trackBar.Value = 0;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mp3Player.Stop();
            timer1.Stop();
            isPlaying = false;
            trackBar.Value = 0;
            lblDuration.Text = "00:00 / 00:00";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                int currentPos = mp3Player.GetPosition();
                int totalLen = trackBar.Maximum;

                if (currentPos <= totalLen)
                {
                    trackBar.Value = currentPos;
                }

                string currentStr = TimeSpan.FromSeconds(currentPos).ToString(@"mm\:ss");
                string totalStr = TimeSpan.FromSeconds(totalLen).ToString(@"mm\:ss");
                lblDuration.Text = $"{currentStr} / {totalStr}";

                if (currentPos >= totalLen && totalLen > 0)
                {
                    mp3Player.Stop();
                    trackBar.Value = 0;
                }
            }
        }
        private void playlistBox_DoubleClick(object sender, EventArgs e)
        {
            PlaySelectedSong();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GetLength(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblDuration_Click(object sender, EventArgs e)
        {

        }
    }
}
