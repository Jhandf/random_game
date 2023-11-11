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
        public event Action<int> activateStatus;

        public WatchADS() {
            InitializeComponent();

            //adsPlayer.URL = regexLinkADS(0);
            adsPlayer.URL = @".\Resources\roll.mp4";

            timeStatus = false;
            countdownTimer.Interval = 1000;
            var tick = 29;
            countdownTimer.Tick += (sender, args) => {
                if (tick <= 0) {
                    countdownTimer.Stop();
                    timeStatus = true;
                    btnClose.Text = "There were rewards available";
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
                this.Close();
            }
            else {
                DialogResult d = MessageBox.Show("If you exit, you will have no reward", "Do you want to exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (d == DialogResult.Yes) {
                    this.Close();
                }
            }
        }

        private string regexLinkADS(int x) {
            string result = @".\Resources\VideoADS";
            result += x;
            return result;
        }
    }
}
