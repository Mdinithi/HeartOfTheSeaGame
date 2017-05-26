namespace HeartOfTheSea
{
    partial class PauseForm
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
            this.button_resume = new System.Windows.Forms.Button();
            this.button_Mainmenu = new System.Windows.Forms.Button();
            this.label_pause = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_resume
            // 
            this.button_resume.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_resume.Location = new System.Drawing.Point(140, 134);
            this.button_resume.Name = "button_resume";
            this.button_resume.Size = new System.Drawing.Size(120, 40);
            this.button_resume.TabIndex = 0;
            this.button_resume.Text = "Resume";
            this.button_resume.UseVisualStyleBackColor = true;
            this.button_resume.Click += new System.EventHandler(this.button_resume_Click);
            // 
            // button_Mainmenu
            // 
            this.button_Mainmenu.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Mainmenu.Location = new System.Drawing.Point(140, 223);
            this.button_Mainmenu.Name = "button_Mainmenu";
            this.button_Mainmenu.Size = new System.Drawing.Size(120, 40);
            this.button_Mainmenu.TabIndex = 1;
            this.button_Mainmenu.Text = "Main Menu";
            this.button_Mainmenu.UseVisualStyleBackColor = true;
            this.button_Mainmenu.Click += new System.EventHandler(this.button_Mainmenu_Click);
            // 
            // label_pause
            // 
            this.label_pause.AutoSize = true;
            this.label_pause.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pause.Location = new System.Drawing.Point(65, 31);
            this.label_pause.Name = "label_pause";
            this.label_pause.Size = new System.Drawing.Size(262, 39);
            this.label_pause.TabIndex = 2;
            this.label_pause.Text = "Your Game is paused!";
            this.label_pause.Click += new System.EventHandler(this.label1_Click);
            // 
            // PauseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImage = global::HeartOfTheSea.Properties.Resources.m;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(442, 361);
            this.ControlBox = false;
            this.Controls.Add(this.label_pause);
            this.Controls.Add(this.button_Mainmenu);
            this.Controls.Add(this.button_resume);
            this.DoubleBuffered = true;
            this.Name = "PauseForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PauseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_resume;
        private System.Windows.Forms.Button button_Mainmenu;
        private System.Windows.Forms.Label label_pause;
    }
}