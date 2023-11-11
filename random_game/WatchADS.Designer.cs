namespace random_game {
    partial class WatchADS {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WatchADS));
            this.btnClose = new System.Windows.Forms.Button();
            this.adsPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.countdownTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.adsPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(506, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 26);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Left 30 second";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // adsPlayer
            // 
            this.adsPlayer.Enabled = true;
            this.adsPlayer.Location = new System.Drawing.Point(0, 0);
            this.adsPlayer.Name = "adsPlayer";
            this.adsPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("adsPlayer.OcxState")));
            this.adsPlayer.Size = new System.Drawing.Size(640, 480);
            this.adsPlayer.TabIndex = 1;
            // 
            // WatchADS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.adsPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WatchADS";
            this.Text = "WatchADS";
            ((System.ComponentModel.ISupportInitialize)(this.adsPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private AxWMPLib.AxWindowsMediaPlayer adsPlayer;
        private System.Windows.Forms.Timer countdownTimer;
    }
}