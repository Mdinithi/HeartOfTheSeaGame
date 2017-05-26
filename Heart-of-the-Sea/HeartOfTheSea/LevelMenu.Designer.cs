namespace HeartOfTheSea
{
    partial class LevelMenu
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
            this.button_easy = new System.Windows.Forms.Button();
            this.button_medium = new System.Windows.Forms.Button();
            this.button_hard = new System.Windows.Forms.Button();
            this.label_LevelMenu = new System.Windows.Forms.Label();
            this.button_backLMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_easy
            // 
            this.button_easy.AutoSize = true;
            this.button_easy.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_easy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_easy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_easy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.button_easy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_easy.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_easy.ForeColor = System.Drawing.SystemColors.Info;
            this.button_easy.Location = new System.Drawing.Point(328, 162);
            this.button_easy.Name = "button_easy";
            this.button_easy.Size = new System.Drawing.Size(150, 50);
            this.button_easy.TabIndex = 0;
            this.button_easy.Text = "Easy";
            this.button_easy.UseVisualStyleBackColor = false;
            this.button_easy.Click += new System.EventHandler(this.button_easy_Click);
            // 
            // button_medium
            // 
            this.button_medium.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_medium.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_medium.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.button_medium.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_medium.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_medium.ForeColor = System.Drawing.SystemColors.Info;
            this.button_medium.Location = new System.Drawing.Point(328, 236);
            this.button_medium.Name = "button_medium";
            this.button_medium.Size = new System.Drawing.Size(150, 50);
            this.button_medium.TabIndex = 1;
            this.button_medium.Text = "Medium";
            this.button_medium.UseVisualStyleBackColor = false;
            this.button_medium.Click += new System.EventHandler(this.button_medium_Click);
            // 
            // button_hard
            // 
            this.button_hard.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_hard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_hard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.button_hard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_hard.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_hard.ForeColor = System.Drawing.SystemColors.Info;
            this.button_hard.Location = new System.Drawing.Point(328, 309);
            this.button_hard.Name = "button_hard";
            this.button_hard.Size = new System.Drawing.Size(150, 50);
            this.button_hard.TabIndex = 2;
            this.button_hard.Text = "Hard";
            this.button_hard.UseVisualStyleBackColor = false;
            this.button_hard.Click += new System.EventHandler(this.button_hard_Click);
            // 
            // label_LevelMenu
            // 
            this.label_LevelMenu.AutoSize = true;
            this.label_LevelMenu.BackColor = System.Drawing.Color.Transparent;
            this.label_LevelMenu.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LevelMenu.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label_LevelMenu.Location = new System.Drawing.Point(37, 48);
            this.label_LevelMenu.Name = "label_LevelMenu";
            this.label_LevelMenu.Size = new System.Drawing.Size(385, 57);
            this.label_LevelMenu.TabIndex = 3;
            this.label_LevelMenu.Text = "Select a Level to play";
            this.label_LevelMenu.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_backLMenu
            // 
            this.button_backLMenu.BackColor = System.Drawing.Color.Orchid;
            this.button_backLMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_backLMenu.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_backLMenu.Location = new System.Drawing.Point(82, 430);
            this.button_backLMenu.Name = "button_backLMenu";
            this.button_backLMenu.Size = new System.Drawing.Size(100, 30);
            this.button_backLMenu.TabIndex = 4;
            this.button_backLMenu.Text = "Back";
            this.button_backLMenu.UseVisualStyleBackColor = false;
            this.button_backLMenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // LevelMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HeartOfTheSea.Properties.Resources.moana_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(770, 503);
            this.Controls.Add(this.button_backLMenu);
            this.Controls.Add(this.label_LevelMenu);
            this.Controls.Add(this.button_hard);
            this.Controls.Add(this.button_medium);
            this.Controls.Add(this.button_easy);
            this.Name = "LevelMenu";
            this.Text = "LevelMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_easy;
        private System.Windows.Forms.Button button_medium;
        private System.Windows.Forms.Button button_hard;
        private System.Windows.Forms.Label label_LevelMenu;
        private System.Windows.Forms.Button button_backLMenu;
    }
}