
using Timer = System.Windows.Forms.Timer;

namespace ClickerGame
{
    public partial class Form1 : Form
    {
        private int _cookieAmountValue;

        private int _cookieIMG_orginal_width;
        private int _cookieIMG_orginal_height;
        private int _cookieIMG_orginal_left;
        private int _cookieIMG_orginal_top;

        private int _plusOnePrice = 10;
        private int _plusOneLevel = 0;
        private int _plusOneIncome = 1;

        private int _autoClickPrice = 50;
        private int _autoClickLevel = 0;
        private int _autoClickIncome = 2;
        private Timer _autoClickTimer;

        private bool _alreadyBoughtSkinOne;
        private bool _alreadyBoughtSkinTwo;
        private bool _alreadyBoughtSkinThree;


        private void Form1_Load(object sender, EventArgs e)
        {
            _cookieAmount.Text = _cookieAmountValue.ToString();
            _cookieIMG_orginal_width = _cookieIMG.Width;
            _cookieIMG_orginal_height = _cookieIMG.Height;
            _cookieIMG_orginal_left = _cookieIMG.Left;
            _cookieIMG_orginal_top = _cookieIMG.Top;

            _plusOneToClick.Text = $"+ {_plusOneIncome} к клику \n Price (+{_plusOnePrice})";

            _plusOneToAutoClick.Click += PlusOneToAutoClick_Click;



        }
        private void ChangeCookieImageSize(int value)
        {
            _cookieIMG.Width += value;
            _cookieIMG.Height += value;

            _cookieIMG.Left = _cookieIMG_orginal_left - (_cookieIMG.Width - _cookieIMG_orginal_width) / 2;
            _cookieIMG.Top = _cookieIMG_orginal_top - (_cookieIMG.Height - _cookieIMG_orginal_height) / 2;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void CookieIMG_MouseEnter(object sender, EventArgs e)
        {
            ChangeCookieImageSize(64);

        }


        private void CookieIMG_MouseLeave(object sender, EventArgs e)
        {
            ChangeCookieImageSize(-64);
        }

        private void _cookieIMG_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Showing label +1 
        /// And incrementing +1 to label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CookieIMG_MouseClick(object sender, MouseEventArgs e)
        {
            Label clickEffect = new Label();
            clickEffect.Text = "+" + _plusOneIncome;
            clickEffect.Font = new Font("Arial", 15, FontStyle.Bold);
            clickEffect.AutoSize = true;
            clickEffect.Enabled = false;

            Point cursorLocation = _cookieIMG.PointToScreen(e.Location);
            clickEffect.Location = PointToClient(cursorLocation);

            Controls.Add(clickEffect);
            clickEffect.BringToFront();

            Timer? fadeTimer = new Timer();
            fadeTimer.Interval = 10;
            fadeTimer.Tick += fadeTimer_Tick;
            fadeTimer.Start();

            void fadeTimer_Tick(object? sender, EventArgs e)
            {
                //RGBA
                if (clickEffect.ForeColor.A > 0)
                {
                    int newAlpha = Math.Max(clickEffect.ForeColor.A - 10, 0);
                    clickEffect.ForeColor = Color.FromArgb(newAlpha, clickEffect.ForeColor);
                }
                else
                {
                    Controls.Remove(clickEffect);
                    fadeTimer.Stop();
                }
            }

            _cookieAmountValue += _plusOneIncome;
            _cookieAmount.Text = _cookieAmountValue.ToString();
        }



        private void CookieIMG_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeCookieImageSize(-32);
        }

        private void CookieIMG_MouseUP(object sender, MouseEventArgs e)
        {
            ChangeCookieImageSize(32);
        }

        private void _plusOneToClick_Click(object sender, EventArgs e)
        {
            if (_cookieAmountValue >= _plusOnePrice)
            {
                _cookieAmountValue -= _plusOnePrice;
                _plusOnePrice = (int)(_plusOnePrice * 1.25);
                _plusOneIncome++;
                _plusOneLevel++;
                _plusOneToClick.Text = $"+ {_plusOneIncome} к клику \n Price (+{_plusOnePrice})";
                _cookieAmount.Text = _cookieAmountValue.ToString();
            }
            else
            {
                _plusOneToClick.Text = $"Недостаточно средств {_plusOnePrice - _cookieAmountValue} кликов";
                _cookieAmount.Text = _cookieAmountValue.ToString();


            }
        }

        private void PlusOneToAutoClick_Click(object sender, EventArgs e)
        {
            if (_cookieAmountValue >= _autoClickPrice)
            {
                _cookieAmountValue -= _autoClickPrice;
                _autoClickPrice = (int)(_autoClickPrice * 1.3);
                _autoClickIncome++;
                _autoClickLevel++;

                // Update the text and price of the "+1 к авто-клику" button
                _plusOneToAutoClick.Text = $"+ {_autoClickIncome} к авто-клику\nPrice (+{_autoClickPrice})";

                // Start the auto-click timer if it's not already running
                if (_autoClickTimer == null)
                {
                    _autoClickTimer = new Timer();
                    _autoClickTimer.Interval = 1000;
                    _autoClickTimer.Tick += AutoClickTimer_Tick;
                    _autoClickTimer.Start();
                }

            }

        }

        private void AutoClickTimer_Tick(object sender, EventArgs e)
        {
            _cookieAmountValue += _autoClickIncome;
            _cookieAmount.Text = _cookieAmountValue.ToString();
        }

        private void _donateBackOne_Click(object sender, EventArgs e)
        {
            if (!_alreadyBoughtSkinOne)
            {
                if (_cookieAmountValue >= 125)
                {
                    _cookieAmountValue -= 125;
                    this.BackColor = Color.Beige;
                    _donateButtonLabelOne.Text = "Owned";
                    _alreadyBoughtSkinOne = true;
                }
            }
            else
            {
                this.BackColor = Color.Beige;
            }
        }

        private void _donateBackTwo_Click(object sender, EventArgs e)
        {
            if (!_alreadyBoughtSkinTwo)
            {
                if (_cookieAmountValue >= 255)
                {
                    _cookieAmountValue -= 255;
                    this.BackColor = Color.YellowGreen;
                    _donateButtonLabelTwo.Text = "Owned";
                    _alreadyBoughtSkinTwo = true;
                }
            }
            else
            {
                this.BackColor = Color.YellowGreen;
            }
        }

        private void _donateBackThree_Click(object sender, EventArgs e)
        {
            if (!_alreadyBoughtSkinThree)
            {
                if (_cookieAmountValue >= 455)
                {
                    _cookieAmountValue -= 455;
                    this.BackColor = Color.Turquoise;
                    _donateButtonLabelThree.Text = "Owned";
                    _alreadyBoughtSkinThree = true;
                }
            }
            else
            {
                this.BackColor = Color.Turquoise;
            }
        }
    }
}