namespace ClickerGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            _cookieIMG = new PictureBox();
            label1 = new Label();
            _cookieAmount = new Label();
            _plusOneToClick = new Button();
            _plusOneToAutoClick = new Button();
            _donateBackOne = new Button();
            _donateBackThree = new Button();
            _donateBackTwo = new Button();
            _donateButtonLabelOne = new Label();
            _donateButtonLabelTwo = new Label();
            _donateButtonLabelThree = new Label();
            ((System.ComponentModel.ISupportInitialize)_cookieIMG).BeginInit();
            SuspendLayout();
            // 
            // _cookieIMG
            // 
            _cookieIMG.BackgroundImageLayout = ImageLayout.Center;
            _cookieIMG.Image = (Image)resources.GetObject("_cookieIMG.Image");
            _cookieIMG.Location = new Point(124, 100);
            _cookieIMG.Name = "_cookieIMG";
            _cookieIMG.Size = new Size(128, 128);
            _cookieIMG.SizeMode = PictureBoxSizeMode.StretchImage;
            _cookieIMG.TabIndex = 0;
            _cookieIMG.TabStop = false;
            _cookieIMG.Click += _cookieIMG_Click;
            _cookieIMG.MouseClick += CookieIMG_MouseClick;
            _cookieIMG.MouseDown += CookieIMG_MouseDown;
            _cookieIMG.MouseEnter += CookieIMG_MouseEnter;
            _cookieIMG.MouseLeave += CookieIMG_MouseLeave;
            _cookieIMG.MouseUp += CookieIMG_MouseUP;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(135, 9);
            label1.Name = "label1";
            label1.Size = new Size(107, 35);
            label1.TabIndex = 1;
            label1.Text = "Cookies";
            // 
            // _cookieAmount
            // 
            _cookieAmount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            _cookieAmount.Location = new Point(140, 44);
            _cookieAmount.Name = "_cookieAmount";
            _cookieAmount.Size = new Size(102, 25);
            _cookieAmount.TabIndex = 2;
            _cookieAmount.Text = "X";
            _cookieAmount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // _plusOneToClick
            // 
            _plusOneToClick.BackColor = Color.LightCoral;
            _plusOneToClick.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            _plusOneToClick.ForeColor = SystemColors.ButtonHighlight;
            _plusOneToClick.Location = new Point(12, 458);
            _plusOneToClick.Name = "_plusOneToClick";
            _plusOneToClick.Size = new Size(358, 83);
            _plusOneToClick.TabIndex = 3;
            _plusOneToClick.Text = "+1 к клику\r\nPrice (+10)";
            _plusOneToClick.UseVisualStyleBackColor = false;
            _plusOneToClick.Click += _plusOneToClick_Click;
            // 
            // _plusOneToAutoClick
            // 
            _plusOneToAutoClick.BackColor = Color.ForestGreen;
            _plusOneToAutoClick.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            _plusOneToAutoClick.ForeColor = SystemColors.ButtonHighlight;
            _plusOneToAutoClick.Location = new Point(12, 377);
            _plusOneToAutoClick.Name = "_plusOneToAutoClick";
            _plusOneToAutoClick.Size = new Size(358, 75);
            _plusOneToAutoClick.TabIndex = 3;
            _plusOneToAutoClick.Text = "+1 к авто-клику \r\n Price (+50)";
            _plusOneToAutoClick.UseVisualStyleBackColor = false;
            _plusOneToAutoClick.Click += PlusOneToAutoClick_Click;
            // 
            // _donateBackOne
            // 
            _donateBackOne.BackColor = Color.PeachPuff;
            _donateBackOne.BackgroundImageLayout = ImageLayout.None;
            _donateBackOne.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            _donateBackOne.ForeColor = SystemColors.ButtonHighlight;
            _donateBackOne.Location = new Point(12, 307);
            _donateBackOne.Name = "_donateBackOne";
            _donateBackOne.Size = new Size(101, 64);
            _donateBackOne.TabIndex = 3;
            _donateBackOne.Text = "Beige";
            _donateBackOne.UseVisualStyleBackColor = false;
            _donateBackOne.Click += _donateBackOne_Click;
            // 
            // _donateBackThree
            // 
            _donateBackThree.BackColor = Color.Turquoise;
            _donateBackThree.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            _donateBackThree.ForeColor = SystemColors.Control;
            _donateBackThree.Location = new Point(268, 307);
            _donateBackThree.Name = "_donateBackThree";
            _donateBackThree.Size = new Size(102, 64);
            _donateBackThree.TabIndex = 3;
            _donateBackThree.Text = "Turquoise";
            _donateBackThree.UseVisualStyleBackColor = false;
            _donateBackThree.Click += _donateBackThree_Click;
            // 
            // _donateBackTwo
            // 
            _donateBackTwo.BackColor = Color.YellowGreen;
            _donateBackTwo.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            _donateBackTwo.ForeColor = SystemColors.ButtonHighlight;
            _donateBackTwo.Location = new Point(131, 306);
            _donateBackTwo.Name = "_donateBackTwo";
            _donateBackTwo.Size = new Size(116, 64);
            _donateBackTwo.TabIndex = 3;
            _donateBackTwo.Text = "YellowGreen";
            _donateBackTwo.UseVisualStyleBackColor = false;
            _donateBackTwo.Click += _donateBackTwo_Click;
            // 
            // _donateButtonLabelOne
            // 
            _donateButtonLabelOne.AutoSize = true;
            _donateButtonLabelOne.BackColor = Color.LightSalmon;
            _donateButtonLabelOne.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            _donateButtonLabelOne.ForeColor = SystemColors.ControlLightLight;
            _donateButtonLabelOne.Location = new Point(15, 288);
            _donateButtonLabelOne.Name = "_donateButtonLabelOne";
            _donateButtonLabelOne.Size = new Size(94, 20);
            _donateButtonLabelOne.TabIndex = 4;
            _donateButtonLabelOne.Text = "125 Cookies";
            // 
            // _donateButtonLabelTwo
            // 
            _donateButtonLabelTwo.AutoSize = true;
            _donateButtonLabelTwo.BackColor = Color.LightSalmon;
            _donateButtonLabelTwo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            _donateButtonLabelTwo.ForeColor = SystemColors.ControlLightLight;
            _donateButtonLabelTwo.Location = new Point(140, 288);
            _donateButtonLabelTwo.Name = "_donateButtonLabelTwo";
            _donateButtonLabelTwo.Size = new Size(94, 20);
            _donateButtonLabelTwo.TabIndex = 4;
            _donateButtonLabelTwo.Text = "255 Cookies";
            // 
            // _donateButtonLabelThree
            // 
            _donateButtonLabelThree.AutoSize = true;
            _donateButtonLabelThree.BackColor = Color.LightSalmon;
            _donateButtonLabelThree.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            _donateButtonLabelThree.ForeColor = SystemColors.ControlLightLight;
            _donateButtonLabelThree.Location = new Point(272, 291);
            _donateButtonLabelThree.Name = "_donateButtonLabelThree";
            _donateButtonLabelThree.Size = new Size(94, 20);
            _donateButtonLabelThree.TabIndex = 4;
            _donateButtonLabelThree.Text = "455 Cookies";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(382, 553);
            Controls.Add(_donateButtonLabelThree);
            Controls.Add(_donateButtonLabelTwo);
            Controls.Add(_donateButtonLabelOne);
            Controls.Add(_donateBackTwo);
            Controls.Add(_donateBackThree);
            Controls.Add(_donateBackOne);
            Controls.Add(_plusOneToAutoClick);
            Controls.Add(_plusOneToClick);
            Controls.Add(_cookieAmount);
            Controls.Add(label1);
            Controls.Add(_cookieIMG);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Cookei Clicker Game ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)_cookieIMG).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox _cookieIMG;
        private Label label1;
        private Label _cookieAmount;
        private Button _plusOneToClick;
        private Button _plusOneToAutoClick;
        private Button _donateBackOne;
        private Button _donateBackThree;
        private Button _donateBackTwo;
        private Label _donateButtonLabelOne;
        private Label _donateButtonLabelTwo;
        private Label _donateButtonLabelThree;
    }
}