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
        private static readonly string[] strGift = new string[]
            { "9T96KJNE2LVM", "NTQP2KPEJMUH", "VA97KJNF24UV", "ZT8MLL8GCYKM", "WA845MQHUHKH", "3BRLL59ZCZKD" };

        private bool[] _activate = new bool[strGift.Length];

        public event Action<int> tokenCountUpdated;

        public EnterGiftCode() {
            InitializeComponent();
            for (int i = 0; i < strGift.Length; i++)
                _activate[i] = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e) {
            var newTokenCount = 100;
            for (int i = 0; i <= strGift.Length; i++)
                if (strGift[i] == txtGiftCode.Text && !_activate[i]) {
                    _activate[i] = true;
                    tokenCountUpdated?.Invoke(newTokenCount);
                    txtGiftCode.Text = "";
                    txtGiftCode.Focus();
                }
        }
    }
}