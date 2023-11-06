using System.ComponentModel;

namespace random_game {
    partial class StartMenu {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bnt_Exit = new System.Windows.Forms.PictureBox();
            this.bnt_Option = new System.Windows.Forms.PictureBox();
            this.bnt_Start = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_Option)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_Start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::random_game.Properties.Resources.menu;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.bnt_Exit);
            this.panel1.Controls.Add(this.bnt_Option);
            this.panel1.Controls.Add(this.bnt_Start);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(110, 56);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 526);
            this.panel1.TabIndex = 0;
            //
            // bnt_Exit
            //
            this.bnt_Exit.Image = global::random_game.Properties.Resources.exit_normal;
            this.bnt_Exit.Location = new System.Drawing.Point(80, 230);
            this.bnt_Exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bnt_Exit.Name = "bnt_Exit";
            this.bnt_Exit.Size = new System.Drawing.Size(195, 69);
            this.bnt_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bnt_Exit.TabIndex = 3;
            this.bnt_Exit.TabStop = false;
            this.bnt_Exit.Click += new System.EventHandler(this.bnt_Exit_Click);
            this.bnt_Exit.MouseLeave += new System.EventHandler(this.bnt_Exit_MouseLeave);
            this.bnt_Exit.MouseHover += new System.EventHandler(this.bnt_Exit_MouseHover);
            //
            // bnt_Option
            //
            this.bnt_Option.Image = global::random_game.Properties.Resources.backgroundmusic;
            this.bnt_Option.Location = new System.Drawing.Point(69, 432);
            this.bnt_Option.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bnt_Option.Name = "bnt_Option";
            this.bnt_Option.Size = new System.Drawing.Size(220, 66);
            this.bnt_Option.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bnt_Option.TabIndex = 2;
            this.bnt_Option.TabStop = false;
            this.bnt_Option.Click += new System.EventHandler(this.bnt_Option_Click);
            this.bnt_Option.MouseLeave += new System.EventHandler(this.bnt_Option_MouseLeave);
            this.bnt_Option.MouseHover += new System.EventHandler(this.bnt_Option_MouseHover);
            //
            // bnt_Start
            //
            this.bnt_Start.Image = global::random_game.Properties.Resources.start_normal;
            this.bnt_Start.Location = new System.Drawing.Point(80, 115);
            this.bnt_Start.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bnt_Start.Name = "bnt_Start";
            this.bnt_Start.Size = new System.Drawing.Size(195, 86);
            this.bnt_Start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bnt_Start.TabIndex = 1;
            this.bnt_Start.TabStop = false;
            this.bnt_Start.Click += new System.EventHandler(this.bnt_Start_Click);
            this.bnt_Start.MouseLeave += new System.EventHandler(this.bnt_Start_MouseLeave);
            this.bnt_Start.MouseHover += new System.EventHandler(this.bnt_Start_MouseHover);
            //
            // flowLayoutPanel1
            //
            this.flowLayoutPanel1.Location = new System.Drawing.Point(513, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(11, 10);
            this.flowLayoutPanel1.TabIndex = 0;
            //
            // axWindowsMediaPlayer1
            //
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 83);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            //
            // StartMenu
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(586, 640);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "StartMenu";
            this.Text = "StartMenu";
            this.Load += new System.EventHandler(this.StartMenu_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bnt_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_Option)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_Start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox bnt_Start;
        private System.Windows.Forms.PictureBox bnt_Option;
        private System.Windows.Forms.PictureBox bnt_Exit;
        private System.Windows.Forms.Panel panel1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}