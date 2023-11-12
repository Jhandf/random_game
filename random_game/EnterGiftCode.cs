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
    public partial class EnterGiftCode : Form {
        private static readonly string[] strGift = { "9T96KJNE2LVM", "NTQP2KPEJMUH", "VA97KJNF24UV", "ZT8MLL8GCYKM", "WA845MQHUHKH", "3BRLL59ZCZKD" };

        private readonly bool[] _activate = new bool[strGift.Length];

        public event Action<int> TokenCountUpdated;

        public EnterGiftCode() {
            InitializeComponent();
            for (var i = 0; i < strGift.Length; i++)
                _activate[i] = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e) {
            for (int i = 0; i < strGift.Length; i++) {
                if (strGift[i] == txtGiftCode.Text) {
                    if (!_activate[i]) {
                        _activate[i] = true;
                        MessageBox.Show(@"Gift Code is valid.", @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TokenCountUpdated?.Invoke(100);
                        txtGiftCode.Text = "";
                        txtGiftCode.Focus();
                        return;
                    }

                    MessageBox.Show(@"Gift Code has already been used.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtGiftCode.Text = "";
                    txtGiftCode.Focus();
                    return;
                }
            }
            MessageBox.Show(@"Gift Code is not valid.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtGiftCode.Text = "";
            txtGiftCode.Focus();

        }
    }
}