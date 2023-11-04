using System.Windows.Forms;

namespace random_game {
    public partial class StartMenu : Form {
        public StartMenu() {
            InitializeComponent();
        }

        private void bnt_Start_Click(object sender, System.EventArgs e)
        {
            MainGame start = new MainGame();
            this.Hide();
            start.ShowDialog();
            start.Close();
            this.Show();
        }

        private void bnt_Option_Click(object sender, System.EventArgs e)
        {
            OptionMenu start = new OptionMenu();
            this.Hide();
            start.ShowDialog();
            start.Close();
            this.Show();
        }

        private void bnt_Exit_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void bnt_Start_MouseHover(object sender, System.EventArgs e)
        {
            bnt_Start.Image = Properties.Resources.start_hover;
        }

        private void bnt_Option_MouseHover(object sender, System.EventArgs e)
        {
            bnt_Option.Image = Properties.Resources.backgroundmusic_hover;
        }

        private void bnt_Exit_MouseHover(object sender, System.EventArgs e)
        {
            bnt_Exit.Image = Properties.Resources.exit_hover;
        }

        private void bnt_Start_MouseLeave(object sender, System.EventArgs e)
        {
            bnt_Start.Image = Properties.Resources.start_normal;
        }

        private void bnt_Option_MouseLeave(object sender, System.EventArgs e)
        {
            bnt_Option.Image = Properties.Resources.backgroundmusic;
        }

        private void bnt_Exit_MouseLeave(object sender, System.EventArgs e)
        {
            bnt_Exit.Image = Properties.Resources.exit_normal;
        }
    }
}