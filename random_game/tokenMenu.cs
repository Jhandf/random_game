using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace random_game {
    public partial class tokenMenu : Form {

        MainGame game = new MainGame();
        private int tokenCount;

        public tokenMenu() {
            InitializeComponent();
            tokenCount = MainGame._initialTokenCount;
            txtTokensCount.Text = game._updateTokenTxt(tokenCount.ToString());
        }

        private void btnGiftCode_Click(object sender, EventArgs e) {

            EnterGiftCode giftCodeForm = new EnterGiftCode();

            giftCodeForm.tokenCountUpdated += (newTokenCount) => {
                tokenCount += newTokenCount;
                MainGame._initialTokenCount = tokenCount;
                txtTokensCount.Text = game._updateTokenTxt(tokenCount.ToString());
            };

            giftCodeForm.ShowDialog();
        }

        private void btnClickADS_Click(object sender, EventArgs e) {
            WatchADS watch = new WatchADS();

            watch.activateStatus += (timeStatus) => {
                if (timeStatus == 0) {
                    MainGame._initialTokenCount = tokenCount = game.getTokenCount() + 100;
                    txtTokensCount.Text = game._updateTokenTxt(tokenCount.ToString());
                }
            };

            watch.ShowDialog();
        }
    }
}
