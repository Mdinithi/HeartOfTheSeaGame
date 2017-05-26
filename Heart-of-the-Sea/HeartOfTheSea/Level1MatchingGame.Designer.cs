namespace HeartOfTheSea
{
    partial class Level1MatchingGame
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
            this.lblScoreName = new System.Windows.Forms.Label();
            this.button_pause = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.button_pause)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScoreName
            // 
            this.lblScoreName.AutoSize = true;
            this.lblScoreName.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreName.ForeColor = System.Drawing.Color.Red;
            this.lblScoreName.Location = new System.Drawing.Point(617, 85);
            this.lblScoreName.Name = "lblScoreName";
            this.lblScoreName.Size = new System.Drawing.Size(122, 36);
            this.lblScoreName.TabIndex = 4;
            this.lblScoreName.Text = "Score";
            // 
            // button_pause
            // 
            this.button_pause.BackColor = System.Drawing.Color.Transparent;
            this.button_pause.BackgroundImage = global::HeartOfTheSea.Properties.Resources.pauseIcon;
            this.button_pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_pause.Location = new System.Drawing.Point(748, 2);
            this.button_pause.Name = "button_pause";
            this.button_pause.Size = new System.Drawing.Size(38, 36);
            this.button_pause.TabIndex = 6;
            this.button_pause.TabStop = false;
            this.button_pause.Click += new System.EventHandler(this.button_pause_Click_1);
            // 
            // Level1MatchingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HeartOfTheSea.Properties.Resources.moana_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(788, 501);
            this.Controls.Add(this.button_pause);
            this.Controls.Add(this.lblScoreName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Level1MatchingGame";
            this.Text = "HearOfTheSea";
            ((System.ComponentModel.ISupportInitialize)(this.button_pause)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblScoreName;
        private System.Windows.Forms.PictureBox button_pause;
    }
}

