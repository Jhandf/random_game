using System;
using System.Windows.Forms;
using AxWMPLib;
using random_game.Properties;

namespace random_game {
    public partial class StartMenu : Form {
        public static AxWindowsMediaPlayer player = new AxWindowsMediaPlayer();

        public StartMenu() {
            InitializeComponent();
            axWindowsMediaPlayer1.URL = @".\Resources\creepy-devil-dance-166764.wav";
            axWindowsMediaPlayer1.Hide();
        }

        private void StartMenu_Load(object sender, EventArgs e) {
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.settings.volume = Program.volume;
        }

        private void btnStart_Click(object sender, EventArgs e) {
            var start = new MainGame();
            Hide();
            start.ShowDialog();
            start.Close();
            Show();
        }

        private void btnOption_Click(object sender, EventArgs e) {
            var start = new OptionMenu();
            player = axWindowsMediaPlayer1; // Set the MediaPlayer property in OptionMenu
            Hide();
            start.ShowDialog();
            start.Close();
            Show();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnStart_MouseHover(object sender, EventArgs e) {
            bnt_Start.Image = Resources.start_hover;
        }

        private void btnOption_MouseHover(object sender, EventArgs e) {
            bnt_Option.Image = Resources.backgroundmusic_hover;
        }

        private void btnExit_MouseHover(object sender, EventArgs e) {
            bnt_Exit.Image = Resources.exit_hover;
        }

        private void btnStart_MouseLeave(object sender, EventArgs e) {
            bnt_Start.Image = Resources.start_normal;
        }

        private void btnOption_MouseLeave(object sender, EventArgs e) {
            bnt_Option.Image = Resources.backgroundmusic;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e) {
            bnt_Exit.Image = Resources.exit_normal;
        }
    }
}