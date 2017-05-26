using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeartOfTheSea
{
    public partial class PauseForm : Form
    {
        Level1MatchingGame game;
        public PauseForm()
        {
            InitializeComponent();
        }

        private void button_resume_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button_Mainmenu_Click(object sender, EventArgs e)
        {
            //game = new Level1MatchingGame();
            //game.Hide();

            //LevelMenu lm1 = new LevelMenu();
            //lm1.ShowDialog();
            //this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
