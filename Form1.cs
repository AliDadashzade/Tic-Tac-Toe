using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void scoreO()
        {
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O" || button4.Text == "O" && button5.Text == "O" && button6.Text == "O" || button7.Text == "O" && button8.Text == "O" && button9.Text == "O" || button1.Text == "O" && button4.Text == "O" && button7.Text == "O" || button2.Text == "O" && button5.Text == "O" && button8.Text == "O" || button3.Text == "O" && button6.Text == "O" && button9.Text == "O" || button1.Text == "O" && button5.Text == "O" && button9.Text == "O" || button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                resetbtn();
                btnactive();
                MessageBox.Show("Player1 Win");
            }
        }
        private void scoreX()
        {

            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X" || button4.Text == "X" && button5.Text == "X" && button6.Text == "X" || button7.Text == "X" && button8.Text == "X" && button9.Text == "X" || button1.Text == "X" && button4.Text == "X" && button7.Text == "X" || button2.Text == "X" && button5.Text == "X" && button8.Text == "X" || button3.Text == "X" && button6.Text == "X" && button9.Text == "X" || button1.Text == "X" && button5.Text == "X" && button9.Text == "X" || button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                resetbtn();
                btnactive();
                MessageBox.Show("Player2 Win");
            }
        }

        private void btnactive()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }
        private void resetbtn()
        {
            button1.Text = " ";
            button2.Text = " ";
            button3.Text = " ";
            button4.Text = " ";
            button5.Text = " ";
            button6.Text = " ";
            button7.Text = " ";
            button8.Text = " ";
            button9.Text = " ";
        }   
        private void p1turn()
        {
            LblP1.Enabled = true;
            LblP1.Visible= true;
            LblP2.Enabled = false;
            LblP2.Visible = false;
        }
        private void p2turn()
        {
            LblP1.Enabled = false;
            LblP1.Visible = false;
            LblP2.Enabled = true;
            LblP2.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LblP1.Enabled = true;
            LblP1.Visible = true;
            LblP2.Enabled = false;
            LblP2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            if (LblP1.Visible == true)
            {
                button1.Text = "O";
                p2turn();
                scoreO();
            }
            else if(LblP1.Visible == false)
            {
                button1.Text = "X";
                p1turn();
                scoreX();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            if (LblP1.Visible == true)
            {
                button2.Text = "O";
                p2turn();
                scoreO();
            }
            else if (LblP1.Visible == false)
            {
                button2.Text = "X";
                p1turn();
                scoreX();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            if (LblP1.Visible == true)
            {
                button3.Text = "O";
                p2turn();
                scoreO();
            }
            else if (LblP1.Visible == false)
            {
                button3.Text = "X";
                p1turn();
                scoreX();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            if (LblP1.Visible == true)
            {
                button4.Text = "O";
                p2turn();
                scoreO();
            }
            else if (LblP1.Visible == false)
            {
                button4.Text = "X";
                p1turn();
                scoreX();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            if (LblP1.Visible == true)
            {
                button5.Text = "O";
                p2turn();
                scoreO();
            }
            else if (LblP1.Visible == false)
            {
                button5.Text = "X";
                p1turn();
                scoreX();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Enabled = false;
            if (LblP1.Visible == true)
            {
                button6.Text = "O";
                p2turn();
                scoreO();
            }
            else if (LblP1.Visible == false)
            {
                button6.Text = "X";
                p1turn();
                scoreX();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Enabled = false;
            if (LblP1.Visible == true)
            {
                button7.Text = "O";
                p2turn();
                scoreO();
            }
            else if (LblP1.Visible == false)
            {
                button7.Text = "X";
                p1turn();
                scoreX();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Enabled = false;
            if (LblP1.Visible == true)
            {
                button8.Text = "O";
                p2turn();
                scoreO();
            }
            else if (LblP1.Visible == false)
            {
                button8.Text = "X";
                p1turn();
                scoreX();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Enabled = false;
            if (LblP1.Visible == true)
            {
                button9.Text = "O";
                p2turn();
                scoreO();
            }
            else if (LblP1.Visible == false)
            {
                button9.Text = "X";
                p1turn();
                scoreX();
            }
        }
        
        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}
