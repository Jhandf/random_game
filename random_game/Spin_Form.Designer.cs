namespace random_game {
    partial class Spin_Form {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Spin_Form));
            this.Roll_animation = new AxWMPLib.AxWindowsMediaPlayer();
            this.roll_1 = new System.Windows.Forms.PictureBox();
            this.roll_2 = new System.Windows.Forms.PictureBox();
            this.roll_3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Roll_animation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roll_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roll_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roll_3)).BeginInit();
            this.SuspendLayout();
            // 
            // Roll_animation
            // 
            this.Roll_animation.Enabled = true;
            this.Roll_animation.Location = new System.Drawing.Point(-3, 0);
            this.Roll_animation.Name = "Roll_animation";
            this.Roll_animation.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Roll_animation.OcxState")));
            this.Roll_animation.Size = new System.Drawing.Size(499, 356);
            this.Roll_animation.TabIndex = 0;
            // 
            // roll_1
            // 
            this.roll_1.BackColor = System.Drawing.Color.Transparent;
            this.roll_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.roll_1.Location = new System.Drawing.Point(70, 0);
            this.roll_1.Name = "roll_1";
            this.roll_1.Size = new System.Drawing.Size(508, 356);
            this.roll_1.TabIndex = 1;
            this.roll_1.TabStop = false;
            this.roll_1.Click += new System.EventHandler(this.roll_Click);
            // 
            // roll_2
            // 
            this.roll_2.BackColor = System.Drawing.Color.Transparent;
            this.roll_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.roll_2.Location = new System.Drawing.Point(70, 0);
            this.roll_2.Name = "roll_2";
            this.roll_2.Size = new System.Drawing.Size(508, 356);
            this.roll_2.TabIndex = 2;
            this.roll_2.TabStop = false;
            this.roll_2.Click += new System.EventHandler(this.roll_Click);
            // 
            // roll_3
            // 
            this.roll_3.BackColor = System.Drawing.Color.Transparent;
            this.roll_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.roll_3.Location = new System.Drawing.Point(70, 0);
            this.roll_3.Name = "roll_3";
            this.roll_3.Size = new System.Drawing.Size(508, 356);
            this.roll_3.TabIndex = 3;
            this.roll_3.TabStop = false;
            this.roll_3.Click += new System.EventHandler(this.roll_Click);
            // 
            // Spin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(497, 353);
            this.Controls.Add(this.Roll_animation);
            this.Controls.Add(this.roll_3);
            this.Controls.Add(this.roll_2);
            this.Controls.Add(this.roll_1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "Spin_Form";
            this.Text = "Spin_Form";
            ((System.ComponentModel.ISupportInitialize)(this.Roll_animation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roll_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roll_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roll_3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer Roll_animation;
        private System.Windows.Forms.PictureBox roll_1;
        private System.Windows.Forms.PictureBox roll_2;
        private System.Windows.Forms.PictureBox roll_3;
    }
}