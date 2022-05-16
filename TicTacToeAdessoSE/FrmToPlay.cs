using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeAdessoSE
{
    public partial class FrmToPlay : Form
    {
        public FrmToPlay()
        {
            InitializeComponent();
        }

        Boolean checker;
        int xscor;
        int oscor;
        void EnabelFalse()
        {
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
        }

        void score()
        {
            /*___________________________Player 1 _______________________________________*/

            if (btn1.Text == "x" && btn2.Text == "x" && btn3.Text == "x")
            {
                btn1.BackColor = System.Drawing.Color.GreenYellow;
                btn2.BackColor = System.Drawing.Color.GreenYellow;
                btn3.BackColor = System.Drawing.Color.GreenYellow;

                MessageBox.Show("The winner is Player X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                xscor = int.Parse(lblPlayer1.Text);
                lblPlayer1.Text = Convert.ToString(xscor + 1);
                EnabelFalse();
            }
            if (btn1.Text == "x" && btn5.Text == "x" && btn9.Text == "x")
            {
                btn1.BackColor = System.Drawing.Color.GreenYellow;
                btn5.BackColor = System.Drawing.Color.GreenYellow;
                btn9.BackColor = System.Drawing.Color.GreenYellow;

                MessageBox.Show("The winner is Player X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                xscor = int.Parse(lblPlayer1.Text);
                lblPlayer1.Text = Convert.ToString(xscor + 1);
                EnabelFalse();
            }
            if (btn1.Text == "x" && btn4.Text == "x" && btn7.Text == "x")
            {
                btn1.BackColor = System.Drawing.Color.GreenYellow;
                btn4.BackColor = System.Drawing.Color.GreenYellow;
                btn7.BackColor = System.Drawing.Color.GreenYellow;

                MessageBox.Show("The winner is Player X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                xscor = int.Parse(lblPlayer1.Text);
                lblPlayer1.Text = Convert.ToString(xscor + 1);
                EnabelFalse();
            }
            if (btn2.Text == "x" && btn5.Text == "x" && btn8.Text == "x")
            {
                btn2.BackColor = System.Drawing.Color.GreenYellow;
                btn5.BackColor = System.Drawing.Color.GreenYellow;
                btn8.BackColor = System.Drawing.Color.GreenYellow;

                MessageBox.Show("The winner is Player X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                xscor = int.Parse(lblPlayer1.Text);
                lblPlayer1.Text = Convert.ToString(xscor + 1);
                EnabelFalse();
            }
            if (btn3.Text == "x" && btn6.Text == "x" && btn9.Text == "x")
            {
                btn3.BackColor = System.Drawing.Color.GreenYellow;
                btn6.BackColor = System.Drawing.Color.GreenYellow;
                btn9.BackColor = System.Drawing.Color.GreenYellow;

                MessageBox.Show("The winner is Player X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                xscor = int.Parse(lblPlayer1.Text);
                lblPlayer1.Text = Convert.ToString(xscor + 1);
                EnabelFalse();
            }
            if (btn3.Text == "x" && btn5.Text == "x" && btn7.Text == "x")
            {
                btn3.BackColor = System.Drawing.Color.GreenYellow;
                btn5.BackColor = System.Drawing.Color.GreenYellow;
                btn7.BackColor = System.Drawing.Color.GreenYellow;

                MessageBox.Show("The winner is Player X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                xscor = int.Parse(lblPlayer1.Text);
                lblPlayer1.Text = Convert.ToString(xscor + 1);
                EnabelFalse();
            }
            if (btn4.Text == "x" && btn5.Text == "x" && btn6.Text == "x")
            {
                btn4.BackColor = System.Drawing.Color.GreenYellow;
                btn5.BackColor = System.Drawing.Color.GreenYellow;
                btn6.BackColor = System.Drawing.Color.GreenYellow;

                MessageBox.Show("The winner is Player X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                xscor = int.Parse(lblPlayer1.Text);
                lblPlayer1.Text = Convert.ToString(xscor + 1);
                EnabelFalse();
            }
            if (btn7.Text == "x" && btn8.Text == "x" && btn9.Text == "x")
            {
                btn7.BackColor = System.Drawing.Color.GreenYellow;
                btn8.BackColor = System.Drawing.Color.GreenYellow;
                btn9.BackColor = System.Drawing.Color.GreenYellow;

                MessageBox.Show("The winner is Player X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                xscor = int.Parse(lblPlayer1.Text);
                lblPlayer1.Text = Convert.ToString(xscor + 1);
                EnabelFalse();
            }

            /*___________________________Player 2 _______________________________________*/

            if (btn1.Text == "o" && btn2.Text == "o" && btn3.Text == "o")
            {
                btn1.BackColor = System.Drawing.Color.SteelBlue;
                btn2.BackColor = System.Drawing.Color.SteelBlue;
                btn3.BackColor = System.Drawing.Color.SteelBlue;

                MessageBox.Show("The winner is Player O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                oscor = int.Parse(lblPlayer2.Text);
                lblPlayer2.Text = Convert.ToString(oscor + 1);
                EnabelFalse();
            }
            if (btn1.Text == "o" && btn5.Text == "o" && btn9.Text == "o")
            {
                btn1.BackColor = System.Drawing.Color.SteelBlue;
                btn5.BackColor = System.Drawing.Color.SteelBlue;
                btn9.BackColor = System.Drawing.Color.SteelBlue;

                MessageBox.Show("The winner is Player O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                oscor = int.Parse(lblPlayer2.Text);
                lblPlayer2.Text = Convert.ToString(oscor + 1);
                EnabelFalse();
            }
            if (btn1.Text == "o" && btn4.Text == "o" && btn7.Text == "o")
            {
                btn1.BackColor = System.Drawing.Color.SteelBlue;
                btn4.BackColor = System.Drawing.Color.SteelBlue;
                btn7.BackColor = System.Drawing.Color.SteelBlue;

                MessageBox.Show("The winner is Player O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                oscor = int.Parse(lblPlayer2.Text);
                lblPlayer2.Text = Convert.ToString(oscor + 1);
                EnabelFalse();
            }
            if (btn2.Text == "o" && btn5.Text == "o" && btn8.Text == "o")
            {
                btn2.BackColor = System.Drawing.Color.SteelBlue;
                btn5.BackColor = System.Drawing.Color.SteelBlue;
                btn8.BackColor = System.Drawing.Color.SteelBlue;

                MessageBox.Show("The winner is Player O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                oscor = int.Parse(lblPlayer2.Text);
                lblPlayer2.Text = Convert.ToString(oscor + 1);
                EnabelFalse();
            }
            if (btn3.Text == "o" && btn6.Text == "o" && btn9.Text == "o")
            {
                btn3.BackColor = System.Drawing.Color.SteelBlue;
                btn6.BackColor = System.Drawing.Color.SteelBlue;
                btn9.BackColor = System.Drawing.Color.SteelBlue;

                MessageBox.Show("The winner is Player O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                oscor = int.Parse(lblPlayer2.Text);
                lblPlayer2.Text = Convert.ToString(oscor + 1);
                EnabelFalse();
            }
            if (btn3.Text == "o" && btn5.Text == "o" && btn7.Text == "o")
            {
                btn3.BackColor = System.Drawing.Color.SteelBlue;
                btn5.BackColor = System.Drawing.Color.SteelBlue;
                btn7.BackColor = System.Drawing.Color.SteelBlue;

                MessageBox.Show("The winner is Player O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                oscor = int.Parse(lblPlayer2.Text);
                lblPlayer2.Text = Convert.ToString(oscor + 1);
                EnabelFalse();
            }
            if (btn4.Text == "o" && btn5.Text == "o" && btn6.Text == "o")
            {
                btn4.BackColor = System.Drawing.Color.SteelBlue;
                btn5.BackColor = System.Drawing.Color.SteelBlue;
                btn6.BackColor = System.Drawing.Color.SteelBlue;

                MessageBox.Show("The winner is Player O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                oscor = int.Parse(lblPlayer2.Text);
                lblPlayer2.Text = Convert.ToString(oscor + 1);
                EnabelFalse();
            }
            if (btn7.Text == "o" && btn8.Text == "o" && btn9.Text == "o")
            {
                btn7.BackColor = System.Drawing.Color.SteelBlue;
                btn8.BackColor = System.Drawing.Color.SteelBlue;
                btn9.BackColor = System.Drawing.Color.SteelBlue;

                MessageBox.Show("The winner is Player O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                oscor = int.Parse(lblPlayer2.Text);
                lblPlayer2.Text = Convert.ToString(oscor + 1);
                EnabelFalse();
            }

            /*_________________tie event____________________________*/

            if(btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" &&
                btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" &&
                btn9.Text != "")
            {
                MessageBox.Show("Nobody won", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EnabelFalse();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMain f = new FrmMain();
            f.Show();
            this.Hide();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn1.Text = "x";
                checker = true;
            }
            else
            {
                btn1.Text = "o";
                checker = false;
            }
            score();
            btn1.Enabled = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn2.Text = "x";
                checker = true;
            }
            else
            {
                btn2.Text = "o";
                checker = false;
            }
            score();
            btn2.Enabled = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn3.Text = "x";
                checker = true;
            }
            else
            {
                btn3.Text = "o";
                checker = false;
            }
            score();
            btn3.Enabled = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn4.Text = "x";
                checker = true;
            }
            else
            {
                btn4.Text = "o";
                checker = false;
            }
            score();
            btn4.Enabled = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn5.Text = "x";
                checker = true;
            }
            else
            {
                btn5.Text = "o";
                checker = false;
            }
            score();
            btn5.Enabled = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn6.Text = "x";
                checker = true;
            }
            else
            {
                btn6.Text = "o";
                checker = false;
            }
            score();
            btn6.Enabled = false;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn7.Text = "x";
                checker = true;
            }
            else
            {
                btn7.Text = "o";
                checker = false;
            }
            score();
            btn7.Enabled = false;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn8.Text = "x";
                checker = true;
            }
            else
            {
                btn8.Text = "o";
                checker = false;
            }
            score();
            btn8.Enabled = false;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn9.Text = "x";
                checker = true;
            }
            else
            {
                btn9.Text = "o";
                checker = false;
            }
            score();
            btn9.Enabled = false;
        }

        private void initialize()
        {
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";

            btn1.BackColor = Color.Linen;
            btn2.BackColor = Color.Linen;
            btn3.BackColor = Color.Linen;
            btn4.BackColor = Color.Linen;
            btn5.BackColor = Color.Linen;
            btn6.BackColor = Color.Linen;
            btn7.BackColor = Color.Linen;
            btn8.BackColor = Color.Linen;
            btn9.BackColor = Color.Linen;
        }
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            try
            {
                initialize();
                lblPlayer1.Text = "0";
                lblPlayer2.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            initialize();
        }
    }
}
