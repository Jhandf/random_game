﻿using System;
using System.Windows.Forms;
using random_game.Properties;

namespace random_game {
    public partial class OptionMenu : Form {
        public OptionMenu() {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e) {
            label1.Text = trackBar1.Value + @"%";
            Program.volume = trackBar1.Value;
            StartMenu.player.settings.volume = trackBar1.Value;

            pictureBox1.Image = trackBar1.Value == 0 ? Resources.sound_off : Resources.sound_on;
        }

        private void OptionMenu_Load(object sender, EventArgs e) {
            trackBar1.Value = Program.volume;
            label1.Text = Program.volume + @"%";
            if (Program.volume == 0)
                pictureBox1.Image = Resources.sound_off;
        }


        private void pictureBox1_Click(object sender, EventArgs e) {
            if (trackBar1.Value != 0) {
                Program.prevVolumeValue = trackBar1.Value;
                trackBar1.Value = 0;
                Program.volume = 0;
                label1.Text = @"0%";
                pictureBox1.Image = Resources.sound_off;
            } else {
                trackBar1.Value = Program.prevVolumeValue;
                Program.volume = Program.prevVolumeValue;
                label1.Text = Program.prevVolumeValue + @"%";
                pictureBox1.Image = Resources.sound_on;
            }
        }
    }
}