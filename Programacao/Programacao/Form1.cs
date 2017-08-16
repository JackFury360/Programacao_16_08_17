using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacao
{
    public partial class Form1 : Form
    {
        public Random rnd = new Random();
        public int result;
        public int max = 5;
        public int buttonsClicked;

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            result = rnd.Next(0, max);

            if (result == 0)
            {
                button3.Text = "Mina";
                button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = false;
            }

            else
            {
                button3.Text = "Livre";
                buttonsClicked += 1;
            }

            button3.Enabled = false;

            if (buttonsClicked == 6)
            {
                button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = true;
                button1.Text = "Local 1";
                button2.Text = "Local 2";
                button3.Text = "Local 3";
                button4.Text = "Local 4";
                button5.Text = "Local 5";
                button6.Text = "Local 6";
                buttonsClicked = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result = rnd.Next(0, max);

            if (result == 0)
            {
                button1.Text = "Mina";
                button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = false;
            }

            else
            {
                button1.Text = "Livre";
                buttonsClicked += 1;
            }


            button1.Enabled = false;

            if (buttonsClicked == 6)
            {
                button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = true;
                button1.Text = "Local 1";
                button2.Text = "Local 2";
                button3.Text = "Local 3";
                button4.Text = "Local 4";
                button5.Text = "Local 5";
                button6.Text = "Local 6";
                buttonsClicked = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            result = rnd.Next(0, max);

            if (result == 0)
            {
                button2.Text = "Mina";
                button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = false;
            }

            else
            {
                button2.Text = "Livre";
                buttonsClicked += 1;
            }

            button2.Enabled = false;

            if (buttonsClicked == 6)
            {
                button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = true;
                button1.Text = "Local 1";
                button2.Text = "Local 2";
                button3.Text = "Local 3";
                button4.Text = "Local 4";
                button5.Text = "Local 5";
                button6.Text = "Local 6";
                buttonsClicked = 0;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            result = rnd.Next(0, max);

            if (result == 0)
            {
                button6.Text = "Mina";
                button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = false;
            }

            else
            {
                button6.Text = "Livre";
                buttonsClicked += 1;
            }

            button6.Enabled = false;

            if (buttonsClicked == 6)
            {
                button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = true;
                button1.Text = "Local 1";
                button2.Text = "Local 2";
                button3.Text = "Local 3";
                button4.Text = "Local 4";
                button5.Text = "Local 5";
                button6.Text = "Local 6";
                buttonsClicked = 0;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            result = rnd.Next(0, max);

            if (result == 0)
            {
                button5.Text = "Mina";
                button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = false;
            }

            else
            {
                button5.Text = "Livre";
                buttonsClicked += 1;
            }

            button5.Enabled = false;

            if (buttonsClicked == 6)
            {
                button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = true;
                button1.Text = "Local 1";
                button2.Text = "Local 2";
                button3.Text = "Local 3";
                button4.Text = "Local 4";
                button5.Text = "Local 5";
                button6.Text = "Local 6";
                buttonsClicked = 0;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            result = rnd.Next(0, max);

            if (result == 0)
            {
                button4.Text = "Mina";
                button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = false;
            }
            else
            {
                button4.Text = "Livre";
                buttonsClicked += 1;
            }

            button4.Enabled = false;

            if (buttonsClicked == 6)
            {
                button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = true;
                button1.Text = "Local 1";
                button2.Text = "Local 2";
                button3.Text = "Local 3";
                button4.Text = "Local 4";
                button5.Text = "Local 5";
                button6.Text = "Local 6";

            }

        }
    }
}
