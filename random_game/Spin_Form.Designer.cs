namespace random_game {
    partial class SpinForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpinForm));
            this.rollAnimation = new AxWMPLib.AxWindowsMediaPlayer();
            this.roll1 = new System.Windows.Forms.PictureBox();
            this.roll2 = new System.Windows.Forms.PictureBox();
            this.roll3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.rollAnimation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roll1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roll2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roll3)).BeginInit();
            this.SuspendLayout();
            // 
            // rollAnimation
            // 
            this.rollAnimation.Enabled = true;
            this.rollAnimation.Location = new System.Drawing.Point(2, 0);
            this.rollAnimation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rollAnimation.Name = "rollAnimation";
            this.rollAnimation.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("rollAnimation.OcxState")));
            this.rollAnimation.Size = new System.Drawing.Size(0, 0);
            this.rollAnimation.TabIndex = 0;
            // 
            // roll1
            // 
            this.roll1.BackColor = System.Drawing.Color.Transparent;
            this.roll1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.roll1.Location = new System.Drawing.Point(69, 0);
            this.roll1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roll1.Name = "roll1";
            this.roll1.Size = new System.Drawing.Size(508, 356);
            this.roll1.TabIndex = 1;
            this.roll1.TabStop = false;
            this.roll1.Click += new System.EventHandler(this.roll_Click);
            // 
            // roll2
            // 
            this.roll2.BackColor = System.Drawing.Color.Transparent;
            this.roll2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.roll2.Location = new System.Drawing.Point(69, 0);
            this.roll2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roll2.Name = "roll2";
            this.roll2.Size = new System.Drawing.Size(508, 356);
            this.roll2.TabIndex = 2;
            this.roll2.TabStop = false;
            this.roll2.Click += new System.EventHandler(this.roll_Click);
            // 
            // roll3
            // 
            this.roll3.BackColor = System.Drawing.Color.Transparent;
            this.roll3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.roll3.Location = new System.Drawing.Point(69, 0);
            this.roll3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roll3.Name = "roll3";
            this.roll3.Size = new System.Drawing.Size(508, 356);
            this.roll3.TabIndex = 3;
            this.roll3.TabStop = false;
            this.roll3.Click += new System.EventHandler(this.roll_Click);
            // 
            // SpinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(559, 441);
            this.Controls.Add(this.rollAnimation);
            this.Controls.Add(this.roll3);
            this.Controls.Add(this.roll2);
            this.Controls.Add(this.roll1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SpinForm";
            this.Text = "Spin_Form";
            ((System.ComponentModel.ISupportInitialize)(this.rollAnimation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roll1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roll2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roll3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer rollAnimation;
        private System.Windows.Forms.PictureBox roll1;
        private System.Windows.Forms.PictureBox roll2;
        private System.Windows.Forms.PictureBox roll3;
    }
}