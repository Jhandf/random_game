using System;
using System.Collections.Generic;
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
            for (var i = 0; i < buttons.Length; i++) {
                _buttons[i] = buttons[i];
                _initialColors[i] = buttons[i].BackColor;
            }
        }

        private void timer_Tick(object sender, EventArgs e) {
            var rolls = updateRolls();
            var rollInt = new int[3];
            rollInt[0] = int.Parse(rolls[0].ToString());
            rollInt[1] = int.Parse(rolls[2].ToString());
            rollInt[2] = int.Parse(rolls[4].ToString());

            updateRollTxt(rolls);
            highlightBtn(rollInt);
            updateScoreTxt(calcScore(rollInt).ToString());

            _totalTicks--;
            _rollTimer.Interval += 1;
            if (_totalTicks > 0) return;
            if (rollInt[0] == rollInt[1] && rollInt[1] == rollInt[2]) {
                blinkBtn(rollInt[0] - 1);
            }

            _rollTimer.Stop();
            _totalTicks = 100;
            _rollTimer.Interval = 10;
            _finishRoll = true;
        }

        private void btn_Click(object sender, EventArgs e) {
            var btn = (Button)sender;
            var currentNumber = int.Parse(btn.Text);

            if (getTokenCount() != 0 && _finishRoll == false) {
                updateTokenTxt((getTokenCount() - 1).ToString());
                setBtnTxt(btn, (currentNumber + 1).ToString());
            } else if (_finishRoll) {
                resetBtns();
                _finishRoll = false;
                updateTokenTxt(@"2");
                setBtnTxt(btn, @"1");
            }
        }

        private void btnSpin_Click(object sender, EventArgs e) {
            if (_finishRoll) return;
            _rollTimer.Start();
        }

        private void updateRollTxt(string s) {
            btnSpin.Text = s;
        }

        private static void setBtnTxt(Control btn, string s) {
            btn.Text = s;
        }

        private void updateTokenTxt(string s) {
            var text = @"Tokens: " + s;
            txtTokensCount.Text = text;
        }

        private int getTokenCount() {
            var rePattern = new Regex(@"(?<=:\s)*\d+");
            return int.Parse(rePattern.Match(txtTokensCount.Text).Value);
        }

        private void updateScoreTxt(string s) {
            var text = @"Your score: " + s;
            txtScore.Text = text;
        }

        private static string updateRolls() {
            var rnd = new Random();
            var randomNumber1 = rnd.Next(1, 6);
            var randomNumber2 = rnd.Next(1, 6);
            var randomNumber3 = rnd.Next(1, 6);
            return randomNumber1 + @" " + randomNumber2 + @" " + randomNumber3;
        }

        private void resetBtns() {
            for (var i = 0; i < _buttons.Length; i++) {
                _buttons[i].Text = @"0";
                setBtnColor(_buttons[i], _initialColors[i]);
            }
        }

        private int calcScore(IReadOnlyList<int> scores) {
            var score = 0;
            for (var i = 0; i < _buttons.Length; i++) {
                if (scores[0] == i + 1 && scores[1] == i + 1 && scores[2] == i + 1) {
                    score += int.Parse(_buttons[i].Text) * 3;
                } else if (scores[0] == i + 1 && scores[1] == i + 1) {
                    score += int.Parse(_buttons[i].Text) * 2;
                } else if (scores[0] == i + 1 && scores[2] == i + 1) {
                    score += int.Parse(_buttons[i].Text) * 2;
                } else if (scores[1] == i + 1 && scores[2] == i + 1) {
                    score += int.Parse(_buttons[i].Text) * 2;
                } else if (scores[0] == i + 1) {
                    score += int.Parse(_buttons[i].Text);
                } else if (scores[1] == i + 1) {
                    score += int.Parse(_buttons[i].Text);
                } else if (scores[2] == i + 1) {
                    score += int.Parse(_buttons[i].Text);
                }
            }

            return score;
        }

        private static void setBtnColor(Control btn, Color color) {
            btn.BackColor = color;
        }

        private void highlightBtn(IReadOnlyList<int> index) {
            for (var i = 0; i < _buttons.Length; i++) {
                if (i != index[0] - 1 && i != index[1] - 1 && i != index[2] - 1) {
                    setBtnColor(_buttons[i], Color.Gray);
                } else {
                    setBtnColor(_buttons[i], _initialColors[i]);
                }
            }
        }

        private void blinkBtn(int index) {
            var blinkTimer = new Timer();
            blinkTimer.Interval = 500;
            var ticks = 10;
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