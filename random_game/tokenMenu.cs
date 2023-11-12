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

        private int tokenCount;

        public tokenMenu() {
            InitializeComponent();
        }

        private MainGame mainGame = null;

        public tokenMenu(Form mG) {
            mainGame = mG as MainGame;
            InitializeComponent();
            tokenCount = mainGame.publicToken;
            txtTokensCount.Text = mainGame.publicToken.ToString();
        }

        private void btnGiftCode_Click(object sender, EventArgs e) {

            EnterGiftCode giftCodeForm = new EnterGiftCode();

            giftCodeForm.tokenCountUpdated += (newTokenCount) => {
                tokenCount += newTokenCount;
                txtTokensCount.Text = tokenCount.ToString();
            };

            giftCodeForm.ShowDialog();
        }

        private void btnClickADS_Click(object sender, EventArgs e) {
            WatchADS watch = new WatchADS();

            watch.activateStatus += (timeStatus) => {
                if (timeStatus == 0) {
                    tokenCount += 100;
                    txtTokensCount.Text = tokenCount.ToString();
                }
            };

            watch.ShowDialog();
        }

        private void tokenMenu_FormClosed(object sender, FormClosedEventArgs e) {
            mainGame.publicToken = tokenCount;
            Console.WriteLine(tokenCount);
        }
    }
}
