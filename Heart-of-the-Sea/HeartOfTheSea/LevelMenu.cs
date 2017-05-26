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
    public partial class LevelMenu : Form
    {
        private Level1MatchingGame levelOneEasy;

        public LevelMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_easy_Click(object sender, EventArgs e)
        {
            this.Hide();
            levelOneEasy = new Level1MatchingGame();
            levelOneEasy.ShowDialog();
            this.Close();
        }

        private void button_medium_Click(object sender, EventArgs e)
        {

        }

        private void button_hard_Click(object sender, EventArgs e)
        {

        }
    }
}
