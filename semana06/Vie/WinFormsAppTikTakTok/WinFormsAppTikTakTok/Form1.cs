namespace WinFormsAppTikTakTok
{
    public partial class Form1 : Form
    {
        bool checker = false;
        int plus = 0;
        int plusBlas = 0;
        public Form1()
        {
            InitializeComponent();
        }

        public void enabledFalse()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;

        }

        public void Score()
        {
            #region PlayerX
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                button1.BackColor = Color.Yellow;
                button2.BackColor = Color.Yellow;
                button3.BackColor = Color.Yellow;
                MessageBox.Show("Player X win!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plus = Convert.ToInt32(labelScorePlayerX.Text);
                labelScorePlayerX.Text = Convert.ToString(plus + 1);
                enabledFalse();
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                button4.BackColor = Color.Yellow;
                button5.BackColor = Color.Yellow;
                button6.BackColor = Color.Yellow;
                MessageBox.Show("Player X win!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plus = Convert.ToInt32(labelScorePlayerX.Text);
                labelScorePlayerX.Text = Convert.ToString(plus + 1);
                enabledFalse();
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                button7.BackColor = Color.Yellow;
                button8.BackColor = Color.Yellow;
                button9.BackColor = Color.Yellow;
                MessageBox.Show("Player X win!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plus = Convert.ToInt32(labelScorePlayerX.Text);
                labelScorePlayerX.Text = Convert.ToString(plus + 1);
                enabledFalse();
            }
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                button1.BackColor = Color.Yellow;
                button4.BackColor = Color.Yellow;
                button7.BackColor = Color.Yellow;
                MessageBox.Show("Player X win!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plus = Convert.ToInt32(labelScorePlayerX.Text);
                labelScorePlayerX.Text = Convert.ToString(plus + 1);
                enabledFalse();
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                button2.BackColor = Color.Yellow;
                button5.BackColor = Color.Yellow;
                button8.BackColor = Color.Yellow;
                MessageBox.Show("Player X win!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plus = Convert.ToInt32(labelScorePlayerX.Text);
                labelScorePlayerX.Text = Convert.ToString(plus + 1);
                enabledFalse();
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                button3.BackColor = Color.Yellow;
                button6.BackColor = Color.Yellow;
                button9.BackColor = Color.Yellow;
                MessageBox.Show("Player X win!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plus = Convert.ToInt32(labelScorePlayerX.Text);
                labelScorePlayerX.Text = Convert.ToString(plus + 1);
                enabledFalse();
            }
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                button1.BackColor = Color.Yellow;
                button5.BackColor = Color.Yellow;
                button9.BackColor = Color.Yellow;
                MessageBox.Show("Player X win!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plus = Convert.ToInt32(labelScorePlayerX.Text);
                labelScorePlayerX.Text = Convert.ToString(plus + 1);
                enabledFalse();
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                button3.BackColor = Color.Yellow;
                button5.BackColor = Color.Yellow;
                button7.BackColor = Color.Yellow;
                MessageBox.Show("Player X win!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plus = Convert.ToInt32(labelScorePlayerX.Text);
                labelScorePlayerX.Text = Convert.ToString(plus + 1);
                enabledFalse();
            }
            #endregion

            #region Player0
            if (button1.Text == "0" && button2.Text == "0" && button3.Text == "0")
            {
                button1.BackColor = Color.YellowGreen;
                button2.BackColor = Color.YellowGreen;
                button3.BackColor = Color.YellowGreen;
                MessageBox.Show("Player 0 win!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plus = Convert.ToInt32(labelScorePlayer0.Text);
                labelScorePlayer0.Text = Convert.ToString(plus + 1);
                enabledFalse();
            }
            if (button4.Text == "0" && button5.Text == "0" && button6.Text == "0")
            {
                button4.BackColor = Color.YellowGreen;
                button5.BackColor = Color.YellowGreen;
                button6.BackColor = Color.YellowGreen;
                MessageBox.Show("Player 0 win!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plus = Convert.ToInt32(labelScorePlayer0.Text);
                labelScorePlayer0.Text = Convert.ToString(plus + 1);
                enabledFalse();
            }
            if (button7.Text == "0" && button8.Text == "0" && button9.Text == "0")
            {
                button7.BackColor = Color.YellowGreen;
                button8.BackColor = Color.YellowGreen;
                button9.BackColor = Color.YellowGreen;
                MessageBox.Show("Player 0 win!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plus = Convert.ToInt32(labelScorePlayer0.Text);
                labelScorePlayer0.Text = Convert.ToString(plus + 1);
                enabledFalse();
            }
            if (button1.Text == "0" && button4.Text == "0" && button7.Text == "0")
            {
                button1.BackColor = Color.YellowGreen;
                button4.BackColor = Color.YellowGreen;
                button7.BackColor = Color.YellowGreen;
                MessageBox.Show("Player 0 win!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plus = Convert.ToInt32(labelScorePlayer0.Text);
                labelScorePlayer0.Text = Convert.ToString(plus + 1);
                enabledFalse();
            }
            if (button2.Text == "0" && button5.Text == "0" && button8.Text == "0")
            {
                button2.BackColor = Color.YellowGreen;
                button5.BackColor = Color.YellowGreen;
                button8.BackColor = Color.YellowGreen;
                MessageBox.Show("Player 0 win!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plus = Convert.ToInt32(labelScorePlayer0.Text);
                labelScorePlayer0.Text = Convert.ToString(plus + 1);
                enabledFalse();
            }
            if (button3.Text == "0" && button6.Text == "0" && button9.Text == "0")
            {
                button3.BackColor = Color.YellowGreen;
                button6.BackColor = Color.YellowGreen;
                button9.BackColor = Color.YellowGreen;
                MessageBox.Show("Player 0 win!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plus = Convert.ToInt32(labelScorePlayer0.Text);
                labelScorePlayer0.Text = Convert.ToString(plus + 1);
                enabledFalse();
            }
            if (button1.Text == "0" && button5.Text == "0" && button9.Text == "0")
            {
                button1.BackColor = Color.YellowGreen;
                button5.BackColor = Color.YellowGreen;
                button9.BackColor = Color.YellowGreen;
                MessageBox.Show("Player 0 win!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plus = Convert.ToInt32(labelScorePlayer0.Text);
                labelScorePlayer0.Text = Convert.ToString(plus + 1);
                enabledFalse();
            }
            if (button3.Text == "0" && button5.Text == "0" && button7.Text == "0")
            {
                button3.BackColor = Color.YellowGreen;
                button5.BackColor = Color.YellowGreen;
                button7.BackColor = Color.YellowGreen;
                MessageBox.Show("Player 0 win!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plus = Convert.ToInt32(labelScorePlayer0.Text);
                labelScorePlayer0.Text = Convert.ToString(plus + 1);
                enabledFalse();
            }
            #endregion
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!checker)
            {
                button1.Text = "X";
                checker = true;
            }
            else
            {
                button1.Text = "0";
                checker = false;
            }
            Score();
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!checker)
            {
                button2.Text = "X";
                checker = true;
            }
            else
            {
                button2.Text = "0";
                checker = false;
            }
            Score();
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!checker)
            {
                button3.Text = "X";
                checker = true;
            }
            else
            {
                button3.Text = "0";
                checker = false;
            }
            Score();
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!checker)
            {
                button4.Text = "X";
                checker = true;
            }
            else
            {
                button4.Text = "0";
                checker = false;
            }
            Score();
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!checker)
            {
                button5.Text = "X";
                checker = true;
            }
            else
            {
                button5.Text = "0";
                checker = false;
            }
            Score();
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!checker)
            {
                button6.Text = "X";
                checker = true;
            }
            else
            {
                button6.Text = "0";
                checker = false;
            }
            Score();
            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!checker)
            {
                button7.Text = "X";
                checker = true;
            }
            else
            {
                button7.Text = "0";
                checker = false;
            }
            Score();
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!checker)
            {
                button8.Text = "X";
                checker = true;
            }
            else
            {
                button8.Text = "0";
                checker = false;
            }
            Score();
            button8.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!checker)
            {
                button9.Text = "X";
                checker = true;
            }
            else
            {
                button9.Text = "0";
                checker = false;
            }
            Score();
            button9.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Estas seguro de querer salir del sistema", "Juego de tres en raya", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            InicializaPanel();
            checker = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            InicializaPanel();
            checker = false;
            labelScorePlayerX.Text = "0";
            labelScorePlayer0.Text = "0";
        }

        void InicializaPanel()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;
        }

        private void labelScorePlayerX_Click(object sender, EventArgs e)
        {

        }
    }
}
