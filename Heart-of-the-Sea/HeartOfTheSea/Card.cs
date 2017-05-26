using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeartOfTheSea
{
    public class Card : PictureBox
    {
        public Card(int tag)
        {
            this.Tag = tag;
        }
        public Card(int x, int y, int tag)
        {
            this.Width = 129;
            this.Height = 121;
            this.BackColor = Color.White;
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(x, y);
            this.Tag = tag;
            this.SizeMode = PictureBoxSizeMode.CenterImage;

        }
    }
}
