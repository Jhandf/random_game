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

        string strGiftCode = "TTT";
        string strGift1 = "TS";
        public event Action<int> tokenCountUpdated;

        public EnterGiftCode() {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e) {
            var newTokenCount = 100; // Thay thế giá trị mới tùy theo logic của bạn
            if (strGiftCode == txtGiftCode.Text || strGift1 == txtGiftCode.Text) {
                tokenCountUpdated?.Invoke(newTokenCount);
                txtGiftCode.Text = "";
                txtGiftCode.Focus();
            }
        }

    }
}
