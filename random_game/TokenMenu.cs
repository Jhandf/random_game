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
    public partial class TokenMenu : Form {

        private int tokenCount;

        public TokenMenu() {
            InitializeComponent();
        }

        private readonly MainGame _mainGame;

        public TokenMenu(Form mG) {
            _mainGame = mG as MainGame;
            InitializeComponent();
            tokenCount = _mainGame._token;
            txtTokensCount.Text = _mainGame._token.ToString();
        }

        private void btnGiftCode_Click(object sender, EventArgs e) {

            var giftCodeForm = new EnterGiftCode();

            giftCodeForm.tokenCountUpdated += (newTokenCount) => {
                tokenCount += newTokenCount;
                txtTokensCount.Text = tokenCount.ToString();
            };

            giftCodeForm.ShowDialog();
        }

        private void btnClickADS_Click(object sender, EventArgs e) {
            var watch = new WatchADS();

            watch.activateStatus += (timeStatus) => {
                if (timeStatus != 0) return;
                tokenCount += 100;
                txtTokensCount.Text = tokenCount.ToString();
            };

            watch.ShowDialog();
        }

        private void tokenMenu_FormClosed(object sender, FormClosedEventArgs e) {
            _mainGame._token = tokenCount;
        }
    }
}
