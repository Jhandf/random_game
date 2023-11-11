using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace random_game {
    public partial class WatchADS : Form {
        private bool timeStatus;
        private bool muteStatus;
        public event Action<int> activateStatus;
        private static readonly int maxNVideoADS = 4;

        public WatchADS() {
            InitializeComponent();

            adsPlayer.URL = getLinkADS();
            adsPlayer.stretchToFit = true;
            adsPlayer.Size = Size;
            adsPlayer.uiMode = "none";

            muteStatus = false;
            timeStatus = false;
            countdownTimer.Interval = 1000;
            var tick = 29;
            countdownTimer.Tick += (sender, args) => {
                if (tick <= 0) {
                    countdownTimer.Stop();
                    timeStatus = true;
                    btnClose.Location = new Point(307, 12);
                    btnClose.Text = "There were rewards available";
                    SizeF textSize = TextRenderer.MeasureText(btnClose.Text, btnClose.Font);
                    btnClose.Size = new Size((int)textSize.Width + 20, (int)textSize.Height + 10);
                }
                else {
                    btnClose.Text = "Left " + tick + " second";
                    SizeF textSize = TextRenderer.MeasureText(btnClose.Text, btnClose.Font);
                    btnClose.Size = new Size((int)textSize.Width + 20, (int)textSize.Height + 10);
                    tick--;
                }
            };
            countdownTimer.Start();
        }

        private void btnClose_Click(object sender, EventArgs e) {
            if (timeStatus) {
                activateStatus?.Invoke(0);
                adsPlayer.Ctlcontrols.stop();
                this.Close();
            }
            else {
                DialogResult d = MessageBox.Show("If you exit, you will have no reward", "Do you want to exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (d == DialogResult.Yes) {
                    adsPlayer.Ctlcontrols.stop();
                    this.Close();
                }
            }
        }

        int randomVideo() {
            var random = new Random();
            return random.Next(0, maxNVideoADS - 1);
        }

        private string getLinkADS() {
            var x = randomVideo();
            var result = @".\Resources\VideoADS";
            result += x.ToString();
            result += ".mp4";
            return result;
        }

        private void btnMute_Click(object sender, EventArgs e) {
            if (!muteStatus) {
                adsPlayer.settings.volume = 0;
                muteStatus = true;
            }
            else {
                adsPlayer.settings.volume = 100;
                muteStatus = false;
            }
        }
    }
}
