namespace forms_calculator
{
    public partial class Form1 : Form
    {
        char _islem;
        bool _clearScreen;
        int _firstNumber;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rakam1button_Click(object sender, EventArgs e)
        {
            if (_clearScreen) ekranLabel.Text = ""; _clearScreen = false;
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "1";
        }

        private void rakam2button_Click(object sender, EventArgs e)
        {
            if (_clearScreen) ekranLabel.Text = ""; _clearScreen = false;
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "2";
        }

        private void rakam3button_Click_1(object sender, EventArgs e)
        {
            if (_clearScreen) ekranLabel.Text = ""; _clearScreen = false;
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "3";
        }

        private void rakam4button_Click(object sender, EventArgs e)
        {
            if (_clearScreen) ekranLabel.Text = ""; _clearScreen = false;
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "4";
        }

        private void rakam5button_Click(object sender, EventArgs e)
        {
            if (_clearScreen) ekranLabel.Text = ""; _clearScreen = false;
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "5";
        }

        private void rakam6button_Click(object sender, EventArgs e)
        {
            if (_clearScreen) ekranLabel.Text = ""; _clearScreen = false;
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "6";
        }

        private void rakam7button_Click(object sender, EventArgs e)
        {
            if (_clearScreen) ekranLabel.Text = ""; _clearScreen = false;
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "7";
        }

        private void rakam8button_Click(object sender, EventArgs e)
        {
            if (_clearScreen) ekranLabel.Text = ""; _clearScreen = false;
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "8";
        }

        private void rakam9button_Click(object sender, EventArgs e)
        {
            if (_clearScreen) ekranLabel.Text = ""; _clearScreen = false;
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "9";
        }

        private void rakam0button_Click(object sender, EventArgs e)
        {
            if (_clearScreen) ekranLabel.Text = ""; _clearScreen = false;
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "0";
        }

        private void artibutton_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _firstNumber = Convert.ToInt32(ekranLabel.Text);
            _clearScreen = true;
        }

        private void eksibutton_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _firstNumber = Convert.ToInt32(ekranLabel.Text);
            _clearScreen = true;
        }

        private void carpbutton_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _firstNumber = Convert.ToInt32(ekranLabel.Text);
            _clearScreen = true;
        }

        private void bolbutton_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _firstNumber = Convert.ToInt32(ekranLabel.Text);
            _clearScreen = true;
        }

        private void esitbutton_Click(object sender, EventArgs e)
        {
            int secondNumber = Convert.ToInt32(ekranLabel.Text);
            int sonuc;

            switch (_islem)
            {
                case '+':
                    sonuc = _firstNumber + secondNumber;
                    break;

                case '-':
                    sonuc = _firstNumber - secondNumber;
                    break;

                case '/':
                    sonuc = _firstNumber / secondNumber;
                    break;

                case '*':
                    sonuc = _firstNumber * secondNumber;
                    break;

                default:
                    sonuc = 0;
                    break;
            }
            ekranLabel.Text = Convert.ToString(sonuc);
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            ekranLabel.Text = "0";
        }
    }
}