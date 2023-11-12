using System;
using System.Windows.Forms;

namespace random_game {
    public partial class TokenMenu : Form {
        private int _tokenCount;

        public TokenMenu() {
            InitializeComponent();
        }

        private readonly MainGame _mainGame;

        public TokenMenu(Form mG) {
            _mainGame = mG as MainGame;
            InitializeComponent();
            if (_mainGame == null) return;
            _tokenCount = _mainGame.token;
            txtTokensCount.Text = _mainGame.token.ToString();
        }

        private void btnGiftCode_Click(object sender, EventArgs e) {
            var giftCodeForm = new EnterGiftCode();

            giftCodeForm.TokenCountUpdated += (newTokenCount) => {
                _tokenCount += newTokenCount;
                txtTokensCount.Text = _tokenCount.ToString();
            };

            giftCodeForm.ShowDialog();
        }

        private void btnClickADS_Click(object sender, EventArgs e) {
            var watch = new WatchAds();

            watch.ActivateStatus += (timeStatus) => {
                if (timeStatus != 0) return;
                _tokenCount += 100;
                txtTokensCount.Text = _tokenCount.ToString();
            };

            watch.ShowDialog();
        }

        private void tokenMenu_FormClosed(object sender, FormClosedEventArgs e) {
            _mainGame.token = _tokenCount;
        }
    }
}