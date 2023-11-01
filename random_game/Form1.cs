using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace random_game {
    public partial class Form1 : Form {
        private readonly Timer _rollTimer = new Timer();
        private int _totalTicks = 100;
        private bool _finishRoll;
        private readonly Button[] _buttons = new Button[6];
        private readonly Color[] _initialColors = new Color[6];

        public Form1() {
            InitializeComponent();

            _rollTimer.Interval = 10;
            _rollTimer.Tick += timer_Tick;

            Button[] buttons = { btn1, btn2, btn3, btn4, btn5, btn6 };
            for (int i = 0; i < buttons.Length; i++) {
                _buttons[i] = buttons[i];
                _initialColors[i] = buttons[i].BackColor;
            }
        }

        private void timer_Tick(object sender, EventArgs e) {
            var rolls = updateRolls();
            for (int i = 0; i < _buttons.Length; i++) {
                if (i != int.Parse(rolls[0].ToString()) - 1 && i != int.Parse(rolls[2].ToString()) - 1 &&
                    i != int.Parse(rolls[4].ToString()) - 1) {
                    setBtnColor(_buttons[i], Color.Gray);
                } else {
                    setBtnColor(_buttons[i], _initialColors[i]);
                }
            }
            Regex rePattern = new Regex(@"(?<=:\s)*\d+");
            txtScore.Text = rePattern.Replace(txtScore.Text, calcScore(rolls).ToString());
            _totalTicks--;
            _rollTimer.Interval += 1;
            if (_totalTicks <= 0) {
                for (int i = 0; i < _buttons.Length; i++) {
                    if (i == int.Parse(rolls[0].ToString()) - 1 && i == int.Parse(rolls[2].ToString()) - 1 &&
                        i == int.Parse(rolls[4].ToString()) - 1) {
                        blinkBtn(i);
                    }
                }
                _rollTimer.Stop();
                _totalTicks = 100;
                _rollTimer.Interval = 10;
                _finishRoll = true;
            }
        }

        private void btn_Click(object sender, EventArgs e) {
            Button btn = (Button)sender;
            int currentNumber = int.Parse(btn.Text);

            Regex rePattern = new Regex(@"(?<=:\s)*\d+");
            if (rePattern.Match(txtTokensCount.Text).Value != @"0" && _finishRoll == false) {
                txtTokensCount.Text = rePattern.Replace(txtTokensCount.Text, (int.Parse(rePattern.Match(txtTokensCount.Text).Value) - 1).ToString());
                btn.Text = (currentNumber + 1).ToString();
            } else if (_finishRoll) {
                resetBtns();
                _finishRoll = false;
                txtTokensCount.Text = rePattern.Replace(txtTokensCount.Text, @"2");
                btn.Text = @"1";
            }
        }

        private void btnSpin_Click(object sender, EventArgs e) {
            if (_finishRoll) {
                return;
            }
            _rollTimer.Start();
        }

        private string updateRolls() {
            Random rnd = new Random();
            int randomNumber1 = rnd.Next(1, 6);
            int randomNumber2 = rnd.Next(1, 6);
            int randomNumber3 = rnd.Next(1, 6);
            btnSpin.Text = randomNumber1 + @" " + randomNumber2 + @" " + randomNumber3;
            return btnSpin.Text;
        }

        private void resetBtns() {
            for (int i = 0; i < _buttons.Length; i++) {
                _buttons[i].Text = @"0";
                setBtnColor(_buttons[i], _initialColors[i]);
            }
        }

        private int calcScore(string rolls) {
            int[] numbers = { int.Parse(rolls[0].ToString()), int.Parse(rolls[2].ToString()), int.Parse(rolls[4].ToString()) };
            int score = 0;
            for (int i = 0; i < _buttons.Length; i++) {
                if (numbers[0] == i + 1 && numbers[1] == i + 1 && numbers[2] == i + 1) {
                    score += int.Parse(_buttons[i].Text) * 3;
                } else if (numbers[0] == i + 1 && numbers[1] == i + 1) {
                    score += int.Parse(_buttons[i].Text) * 2;
                } else if (numbers[0] == i + 1 && numbers[2] == i + 1) {
                    score += int.Parse(_buttons[i].Text) * 2;
                } else if (numbers[1] == i + 1 && numbers[2] == i + 1) {
                    score += int.Parse(_buttons[i].Text) * 2;
                } else if (numbers[0] == i + 1) {
                    score += int.Parse(_buttons[i].Text);
                } else if (numbers[1] == i + 1) {
                    score += int.Parse(_buttons[i].Text);
                } else if (numbers[2] == i + 1) {
                    score += int.Parse(_buttons[i].Text);
                }
            }
            return score;
        }

        private void setBtnColor(Button btn, Color color) {
            btn.BackColor = color;
        }

        private void blinkBtn(int index) {
            Timer blinkTimer = new Timer();
            blinkTimer.Interval = 500;
            int ticks = 10;
            blinkTimer.Tick += (sender, args) => {
                if (ticks <= 0) {
                    blinkTimer.Stop();
                    setBtnColor(_buttons[index], _initialColors[index]);
                } else {
                    setBtnColor(_buttons[index],
                        _buttons[index].BackColor == Color.Gray ? _initialColors[index] : Color.Gray);
                    ticks--;
                }
            };
            blinkTimer.Start();
        }
    }
}