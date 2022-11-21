namespace MP3Player
{
    public partial class Form1 : Form
    {
        private Mp3player mp3Player = new Mp3player();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_openfile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Mp3 Files|*.mp3";

                if (ofd.ShowDialog() == DialogResult.OK)
                    mp3Player.OpenFile(ofd.FileName);
            }
        }

        private void btn_play_Click(object sender, EventArgs e)
          => mp3Player.Play();

        private void btn_stop_Click(object sender, EventArgs e)
            => mp3Player.Stop();

        private void btn_exit_Click(object sender, EventArgs e)
            => Application.Exit();

        private void btn_minimize_Click(object sender, EventArgs e)
            => this.WindowState = FormWindowState.Minimized;
    }
}