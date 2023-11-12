using System;
using System.Drawing;
using System.Windows.Forms;

namespace random_game {
    public partial class WatchAds : Form {
        private bool _timeStatus;
        private bool _muteStatus;
        public event Action<int> ActivateStatus;
        private const int maxNVideoAds = 4;

        public WatchAds() {
            InitializeComponent();

            adsPlayer.URL = getLinkAds();
            adsPlayer.stretchToFit = true;
            adsPlayer.Size = Size;
            adsPlayer.uiMode = "none";

            _muteStatus = false;
            _timeStatus = false;
            countdownTimer.Interval = 1000;
            var tick = 29;
            countdownTimer.Tick += (sender, args) => {
                if (tick <= 0) {
                    countdownTimer.Stop();
                    _timeStatus = true;
                    btnClose.Location = new Point(307, 12);
                    btnClose.Text = @"There were rewards available";
                    SizeF textSize = TextRenderer.MeasureText(btnClose.Text, btnClose.Font);
                    btnClose.Size = new Size((int)textSize.Width + 20, (int)textSize.Height + 10);
                } else {
                    btnClose.Text = @"Left " + tick + @" second";
                    SizeF textSize = TextRenderer.MeasureText(btnClose.Text, btnClose.Font);
                    btnClose.Size = new Size((int)textSize.Width + 20, (int)textSize.Height + 10);
                    tick--;
                }
            };
            countdownTimer.Start();
        }

        private void btnClose_Click(object sender, EventArgs e) {
            if (_timeStatus) {
                ActivateStatus?.Invoke(0);
                adsPlayer.Ctlcontrols.stop();
                Close();
            } else {
                var d = MessageBox.Show(@"If you exit, you will have no reward", @"Do you want to exit?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (d != DialogResult.Yes) return;
                adsPlayer.Ctlcontrols.stop();
                Close();
            }
        }

        private static int randomVideo() {
            var random = new Random();
            return random.Next(0, maxNVideoAds - 1);
        }

        private static string getLinkAds() {
            var x = randomVideo();
            var result = @".\Resources\VideoADS";
            result += x.ToString();
            result += ".mp4";
            return result;
        }

        private void btnMute_Click(object sender, EventArgs e) {
            if (!_muteStatus) {
                adsPlayer.settings.volume = 0;
                _muteStatus = true;
            } else {
                adsPlayer.settings.volume = 100;
                _muteStatus = false;
            }
        }
    }
}