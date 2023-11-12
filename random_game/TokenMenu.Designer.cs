namespace random_game
{
    partial class TokenMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TokenMenu));
            this.btnClickADS = new System.Windows.Forms.Button();
            this.btnGiftCode = new System.Windows.Forms.Button();
            this.txtTokensCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClickADS
            // 
            this.btnClickADS.Location = new System.Drawing.Point(33, 62);
            this.btnClickADS.Name = "btnClickADS";
            this.btnClickADS.Size = new System.Drawing.Size(194, 44);
            this.btnClickADS.TabIndex = 1;
            this.btnClickADS.Text = "View ads +100 Token";
            this.btnClickADS.UseVisualStyleBackColor = true;
            this.btnClickADS.Click += new System.EventHandler(this.btnClickADS_Click);
            // 
            // btnGiftCode
            // 
            this.btnGiftCode.Location = new System.Drawing.Point(283, 62);
            this.btnGiftCode.Name = "btnGiftCode";
            this.btnGiftCode.Size = new System.Drawing.Size(194, 44);
            this.btnGiftCode.TabIndex = 2;
            this.btnGiftCode.Text = "Enter Gift Code";
            this.btnGiftCode.UseVisualStyleBackColor = true;
            this.btnGiftCode.Click += new System.EventHandler(this.btnGiftCode_Click);
            // 
            // txtTokensCount
            // 
            this.txtTokensCount.Image = ((System.Drawing.Image)(resources.GetObject("txtTokensCount.Image")));
            this.txtTokensCount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txtTokensCount.Location = new System.Drawing.Point(179, -2);
            this.txtTokensCount.Name = "txtTokensCount";
            this.txtTokensCount.Size = new System.Drawing.Size(155, 61);
            this.txtTokensCount.TabIndex = 0;
            this.txtTokensCount.Text = "Token: ";
            this.txtTokensCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tokenMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 133);
            this.Controls.Add(this.btnGiftCode);
            this.Controls.Add(this.btnClickADS);
            this.Controls.Add(this.txtTokensCount);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TokenMenu";
            this.Text = "tokenMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.tokenMenu_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txtTokensCount;
        private System.Windows.Forms.Button btnClickADS;
        private System.Windows.Forms.Button btnGiftCode;
    }
}