using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace random_game {
    public partial class Spin_Form : Form {
        private const int PictureBoxWidth = 120; // Độ rộng mong muốn của mỗi pictureBox
        private const int PictureBoxHeight = 120; // Độ cao mong muốn của mỗi pictureBox
        private int pictureBoxCount = 3;
        public Spin_Form() {
            InitializeComponent();
            InitializeMediaPlayer();
            Hide_All();
        }
        public int[] RollInt {
            get; private set;
        }
        private void InitializeMediaPlayer() {
            Roll_animation.URL = @".\Resources\\roll.mp4";
            Roll_animation.PlayStateChange += AxWindowsMediaPlayer1_PlayStateChange;
            Roll_animation.ClickEvent += Roll_animation_ClickEvent;
            Roll_animation.uiMode = "none";
        }
        private void Hide_All() {
            roll_1.Hide();
            roll_2.Hide();
            roll_3.Hide();
        }
        private void Show_All() {
            roll_1.Show();
            roll_2.Show();
            roll_3.Show();
            int spacing = 10;
            // Tính toán tổng độ rộng của tất cả pictureBox và khoảng cách giữa chúng
            int totalWidth = (PictureBoxWidth + spacing) * pictureBoxCount - spacing;
            // Tính toán vị trí bắt đầu của hàng ngang để đảm bảo nó giữa form
            int startX = (this.ClientSize.Width - totalWidth) / 2;
            // Tính toán vị trí y bắt đầu để đảm bảo nó giữa form
            int startY = (this.ClientSize.Height - PictureBoxHeight) / 2;
            // Cấu hình kích thước và vị trí của từng pictureBox
            roll_1.Size = new Size(PictureBoxWidth, PictureBoxHeight);
            roll_1.Location = new Point(startX, startY);
            roll_2.Size = new Size(PictureBoxWidth, PictureBoxHeight);
            roll_2.Location = new Point(startX + PictureBoxWidth + spacing, startY);
            roll_3.Size = new Size(PictureBoxWidth, PictureBoxHeight);
            roll_3.Location = new Point(startX + 2 * (PictureBoxWidth + spacing), startY);
        }
        private void AxWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e) {
            if (Roll_animation.playState == WMPLib.WMPPlayState.wmppsMediaEnded || Roll_animation.playState == WMPLib.WMPPlayState.wmppsStopped) {
                Roll_animation.Hide();
                RollInt = MainGame.rollInt;
                LoadImageIntoPictureBox();
                Show_All();

            }

        }
        private void LoadImageIntoPictureBox() {
            string[] Array_URL = {
                @".\Resources\wanderer.png", @".\Resources\neuvillete.png",
                @".\Resources\zongli.png", @".\Resources\raiden.png",
                @".\Resources\nilou.png", @".\Resources\kokomi.png"
            };

            LoadImageIntoPictureBoxHelper(Array_URL[0], roll_1);
            LoadImageIntoPictureBoxHelper(Array_URL[1], roll_2);
            LoadImageIntoPictureBoxHelper(Array_URL[2], roll_3);
        }
        private void LoadImageIntoPictureBoxHelper(string imagePath, PictureBox pictureBox) {
            // Kiểm tra xem tập tin hình ảnh có tồn tại không
            if (System.IO.File.Exists(imagePath)) {
                // Tạo một đối tượng hình ảnh từ đường dẫn
                Image image = Image.FromFile(imagePath);
                // Đặt hình ảnh cho PictureBox
                pictureBox.Image = image;
                // Cấu hình PictureBox để hiển thị hình ảnh theo tỷ lệ
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                // Cập nhật kích thước của PictureBox theo kích thước của hình ảnh
                pictureBox.Size = image.Size;
                // Cập nhật tên tập tin hình ảnh nếu bạn muốn
                pictureBox.Tag = imagePath;
            }
            else {
                MessageBox.Show("File not found: " + imagePath);
            }
        }

        private void roll_Click(object sender, EventArgs e) {
            Close();
        }
        private void Roll_animation_ClickEvent(object sender, AxWMPLib._WMPOCXEvents_ClickEvent e) {
            Roll_animation.Ctlcontrols.stop();
        }
    }
}
