using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeartOfTheSea
{
    public class DeploymentScreen
    {
        private List<Point> _mousePoints = new List<Point>();
        private Random _random = new Random();
        private Card card1;
        private Card card2;
        private Card card3;
        private Card card4;
        private Card card5;
        private Card card6;
        private Card card7;
        private Card card8;
        private Card dupCard1;
        private Card dupCard2;
        private Card dupCard3;
        private Card dupCard4;
        private Card dupCard5;
        private Card dupCard6;
        private Card dupCard7;
        private Card dupCard8;
        private Card _firstClicked = null;
        private Card _secondClicked = null;
        private Label _scoreValue;
        Timer flipTimer;
        Timer flipTimer2;
        int _score = 0;
        int _count = 0;
        private Form _windowsForm;

        public Card FirstClicked
        {
            get
            {
                return _firstClicked;
            }

            set
            {
                _firstClicked = value;
            }
        }

        public Card SecondClicked
        {
            get
            {
                return _secondClicked;
            }

            set
            {
                _secondClicked = value;
            }
        }

        public int Score
        {
            get
            {
                return _score;
            }

            set
            {
                _score = value;
            }
        }

        public DeploymentScreen()
        {
            _windowsForm = new Form();
        }
        public DeploymentScreen(Form windowsForm)
        {
            _windowsForm = windowsForm;
        }
        public void AddControls()
        {
            AddCards();
            AddPanel();
            AddTimer();
            AddLabel();
        }

        public void AddCards()
        {
            card1 = new Card(3, 3, 1);
            card1.Click += new System.EventHandler(this.card1_Click);
            card2 = new Card(265, 3, 2);
            card2.Click += new System.EventHandler(this.card2_Click);
            card3 = new Card(3, 128, 3);
            card3.Click += new System.EventHandler(this.card3_Click);
            card4 = new Card(265, 128, 4);
            card4.Click += new System.EventHandler(this.card4_Click);
            card5 = new Card(3, 253, 5);
            card5.Click += new System.EventHandler(this.card5_Click);
            card6 = new Card(265, 253, 6);
            card6.Click += new System.EventHandler(this.card6_Click);
            card7 = new Card(3, 378, 7);
            card7.Click += new System.EventHandler(this.card7_Click);
            card8 = new Card(265, 378, 8);
            card8.Click += new System.EventHandler(this.card8_Click);
            dupCard1 = new Card(134, 3, 1);
            dupCard1.Click += new System.EventHandler(this.dupCard1_Click);
            dupCard2 = new Card(396, 3, 2);
            dupCard2.Click += new System.EventHandler(this.dupCard2_Click);
            dupCard3 = new Card(134, 128, 3);
            dupCard3.Click += new System.EventHandler(this.dupCard3_Click);
            dupCard4 = new Card(396, 128, 4);
            dupCard4.Click += new System.EventHandler(this.dupCard4_Click);
            dupCard5 = new Card(134, 253, 5);
            dupCard5.Click += new System.EventHandler(this.dupCard5_Click);
            dupCard6 = new Card(396, 253, 6);
            dupCard6.Click += new System.EventHandler(this.dupCard6_Click);
            dupCard7 = new Card(134, 378, 7);
            dupCard7.Click += new System.EventHandler(this.dupCard7_Click);
            dupCard8 = new Card(396, 378, 8);
            dupCard8.Click += new System.EventHandler(this.dupCard8_Click);

        }

        public void AddPanel()
        {
            Panel panelPicBox = new Panel();
            panelPicBox.Width = 526;
            panelPicBox.Height = 503;
            panelPicBox.BackColor = Color.Transparent;

            panelPicBox.Controls.Add(card1);
            panelPicBox.Controls.Add(card2);
            panelPicBox.Controls.Add(card3);
            panelPicBox.Controls.Add(card4);
            panelPicBox.Controls.Add(card5);
            panelPicBox.Controls.Add(card6);
            panelPicBox.Controls.Add(card7);
            panelPicBox.Controls.Add(card8);
            panelPicBox.Controls.Add(dupCard1);
            panelPicBox.Controls.Add(dupCard2);
            panelPicBox.Controls.Add(dupCard3);
            panelPicBox.Controls.Add(dupCard4);
            panelPicBox.Controls.Add(dupCard5);
            panelPicBox.Controls.Add(dupCard6);
            panelPicBox.Controls.Add(dupCard7);
            panelPicBox.Controls.Add(dupCard8);
            _windowsForm.Controls.Add(panelPicBox);

            foreach (PictureBox control in panelPicBox.Controls)
            {
                _mousePoints.Add(control.Location);
            }
            foreach (PictureBox control in panelPicBox.Controls)
            {
                int next = _random.Next(_mousePoints.Count);
                Point newPoint = _mousePoints[next];
                control.Location = newPoint;
                _mousePoints.Remove(newPoint);
                control.Image = Properties.Resources.heartLevel1;
            }


        }

        public void AddTimer()
        {
            flipTimer = new Timer();
            flipTimer.Interval = 300;
            flipTimer.Tick += new System.EventHandler(flipTimer_Tick);
            flipTimer2 = new Timer();
            flipTimer2.Interval = 500;
            flipTimer2.Tick += new System.EventHandler(flipTimer2_Tick);
            flipTimer.Tag = _windowsForm;
            flipTimer2.Tag = _windowsForm;

        }

        public void AddLabel()
        {
            _scoreValue = new Label();
            _scoreValue.Location = new System.Drawing.Point(745, 89);
            _scoreValue.Width = 35;
            _scoreValue.Height = 30;
            _scoreValue.Text = "0";
            _scoreValue.Font = new System.Drawing.Font("Ravie", 15.7F);
            _scoreValue.AutoSize = true;
            _windowsForm.Controls.Add(_scoreValue);
        }


        private void card1_Click(object sender, EventArgs e)
        {
            card1.Image = Properties.Resources.card1;
            CheckCards(card1);
        }

        private void dupCard1_Click(object sender, EventArgs e)
        {
            dupCard1.Image = Properties.Resources.card1;
            CheckCards(dupCard1);
        }

        private void card2_Click(object sender, EventArgs e)
        {
            card2.Image = Properties.Resources.card2;
            CheckCards(card2);
        }

        private void dupCard2_Click(object sender, EventArgs e)
        {
            dupCard2.Image = Properties.Resources.card2;
            CheckCards(dupCard2);
        }

        private void card3_Click(object sender, EventArgs e)
        {
            card3.Image = Properties.Resources.card3;
            CheckCards(card3);
        }

        private void dupCard3_Click(object sender, EventArgs e)
        {
            dupCard3.Image = Properties.Resources.card3;
            CheckCards(dupCard3);
        }

        private void card4_Click(object sender, EventArgs e)
        {
            card4.Image = Properties.Resources.card4;
            CheckCards(card4);
        }

        private void dupCard4_Click(object sender, EventArgs e)
        {
            dupCard4.Image = Properties.Resources.card4;
            CheckCards(dupCard4);
        }

        private void card5_Click(object sender, EventArgs e)
        {
            card5.Image = Properties.Resources.card5;
            CheckCards(card5);
        }

        private void dupCard5_Click(object sender, EventArgs e)
        {
            dupCard5.Image = Properties.Resources.card5;
            CheckCards(dupCard5);
        }

        private void card6_Click(object sender, EventArgs e)
        {
            card6.Image = Properties.Resources.card6;
            CheckCards(card6);
        }

        private void dupCard6_Click(object sender, EventArgs e)
        {
            dupCard6.Image = Properties.Resources.card6;
            CheckCards(dupCard6);
        }

        private void card7_Click(object sender, EventArgs e)
        {
            card7.Image = Properties.Resources.card7;
            CheckCards(card7);
        }

        private void dupCard7_Click(object sender, EventArgs e)
        {
            dupCard7.Image = Properties.Resources.card7;
            CheckCards(dupCard7);
        }

        private void card8_Click(object sender, EventArgs e)
        {
            card8.Image = Properties.Resources.card8;
            CheckCards(card8);
        }

        private void dupCard8_Click(object sender, EventArgs e)
        {
            dupCard8.Image = Properties.Resources.card8;
            CheckCards(dupCard8);
        }
        public void CheckCards(Card cardClicked)
        {
            if (FirstClicked == null)
            {
                _firstClicked = cardClicked;
            }
            else if (SecondClicked == null)
            {
                _secondClicked = cardClicked;
                if (_firstClicked.Tag != _secondClicked.Tag)
                {

                    if (Convert.ToInt32(_firstClicked.Tag) == Convert.ToInt32(_secondClicked.Tag))
                    {
                        flipTimer2.Enabled = true;
                        flipTimer2.Start();
                    }
                    else
                    {
                        flipTimer.Enabled = true;
                        flipTimer.Start();

                    }
                }
                else
                {
                    _secondClicked = null;
                }

            }
        }
        private void flipTimer_Tick(object sender, EventArgs e)
        {
            ExecuteTimer1();
        }

        private void flipTimer2_Tick(object sender, EventArgs e)
        {
            ExecuteTimer2();
        }

        public void ExecuteTimer1()
        {
            flipTimer.Stop();
            _firstClicked.Image = Properties.Resources.heartLevel1;
            _secondClicked.Image = Properties.Resources.heartLevel1;
            _firstClicked = null;
            _secondClicked = null;
        }

        public void ExecuteTimer2()
        {
            flipTimer2.Stop();
            if (_firstClicked != null && _secondClicked != null)
            {
                _firstClicked.Visible = false;
                _secondClicked.Visible = false;
                _firstClicked = null;
                _secondClicked = null;
                _score = _score + 10;
                _scoreValue.Text = Score.ToString();
                _count++;
                if (_count == 8)
                {
                    _windowsForm.Hide();
                    _windowsForm.Close();
                    LevelWin levelDone = new LevelWin();
                    levelDone.ShowDialog();
                }
            }
        }

        public bool FirstClickedVisible
        {
            get
            {
                return _firstClicked.Visible == true;
            }
        }

        public bool SecondClickedVisible
        {
            get
            {
                return _secondClicked.Visible == true;
            }
        }

        public void Test()
        {
            //this is test
        }
    }
}
