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
            _updateTokenTxt(_tokenCount.ToString());
        }

        private void _updateTokenTxt(string s) {
            var text = @"Tokens: " + s;
            txtTokensCount.Text = text;
        }

        private void btnGiftCode_Click(object sender, EventArgs e) {
            var giftCodeForm = new EnterGiftCode();

            giftCodeForm.TokenCountUpdated += (newTokenCount) => {
                _tokenCount += newTokenCount;
                _updateTokenTxt(_tokenCount.ToString());
            };
            giftCodeForm.ShowDialog();

        }

        private void btnClickADS_Click(object sender, EventArgs e) {
            var watch = new WatchAds();
            watch.ActivateStatus += (timeStatus) => {
                if (timeStatus != 0) return;
                _tokenCount += 100;
                _updateTokenTxt(_tokenCount.ToString());
            };
            Hide();
            watch.ShowDialog();
            watch.Close();
            Show();
        }

        private void tokenMenu_FormClosed(object sender, FormClosedEventArgs e) {
            _mainGame.token = _tokenCount;
        }
    }
}