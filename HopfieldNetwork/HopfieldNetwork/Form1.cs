using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace HopfieldNetwork
{
    public partial class Form1 : Form
    {
        #region variables
        Boolean button1On = true;
        Boolean button2On = true;
        Boolean button3On = true;
        Boolean button4On = true;
        Boolean button5On = true;
        Boolean button6On = true;
        Boolean button7On = true;
        Boolean button8On = true;
        Boolean button9On = true;
        int[] pattern = new int[9];
        int[] wt1 = { 0, 0, 2, -2, -2, -2, 2, 0, 2 };
        int[] wt2 = { 0, 0, 0, 0, 0, 0, 0, 2, 0 };
        int[] wt3 = { 2, 0, 0, -2, -2, -2, 2, 0, 2 };
        int[] wt4 = { 2, 0, -2, 0, 2, 2, -2, 0, -2 };
        int[] wt5 = { 2, 0, -2, 2, 0, 2, -2, 0, -2 };
        int[] wt6 = { 2, 0, -2, 2, 2, 0, -2, 0, -2 };
        int[] wt7 = { 2, 0, 2, -2, -2, -2, 0, 0, 2 };
        int[] wt8 = { 0, 2, 0, 0, 0, 0, 0, 0, 0 };
        int[] wt9 = { 2, 0, 2, -2, -2, -2, 2, 0, 0 };
        #endregion

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (button1On == true)
            {
                button1On = false;
                button1.BackColor = Color.Black;
            }
            else
            {
                button1On = true;
                button1.BackColor = Color.White;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2On == true)
            {
                button2On = false;
                button2.BackColor = Color.Black;
            }
            else
            {
                button2On = true;
                button2.BackColor = Color.White;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3On == true)
            {
                button3On = false;
                button3.BackColor = Color.Black;
            }
            else
            {
                button3On = true;
                button3.BackColor = Color.White;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4On == true)
            {
                button4On = false;
                button4.BackColor = Color.Black;
            }
            else
            {
                button4On = true;
                button4.BackColor = Color.White;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5On == true)
            {
                button5On = false;
                button5.BackColor = Color.Black;
            }
            else
            {
                button5On = true;
                button5.BackColor = Color.White;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6On == true)
            {
                button6On = false;
                button6.BackColor = Color.Black;
            }
            else
            {
                button6On = true;
                button6.BackColor = Color.White;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7On == true)
            {
                button7On = false;
                button7.BackColor = Color.Black;
            }
            else
            {
                button7On = true;
                button7.BackColor = Color.White;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8On == true)
            {
                button8On = false;
                button8.BackColor = Color.Black;
            }
            else
            {
                button8On = true;
                button8.BackColor = Color.White;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9On == true)
            {
                button9On = false;
                button9.BackColor = Color.Black;
            }
            else
            {
                button9On = true;
                button9.BackColor = Color.White;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            #region pattern
            if (button1.BackColor == Color.Black)
            {
                pattern[0] = 1;
            }
            else
            {
                pattern[0] = -1;
            }

            if (button2.BackColor == Color.Black)
            {
                pattern[1] = 1;
            }
            else
            {
                pattern[1] = -1;
            }

            if (button3.BackColor == Color.Black)
            {
                pattern[2] = 1;
            }
            else
            {
                pattern[2] = -1;
            }

            if (button4.BackColor == Color.Black)
            {
                pattern[3] = 1;
            }
            else
            {
                pattern[3] = -1;
            }

            if (button5.BackColor == Color.Black)
            {
                pattern[4] = 1;
            }
            else
            {
                pattern[4] = -1;
            }


            if (button6.BackColor == Color.Black)
            {
                pattern[5] = 1;
            }
            else
            {
                pattern[5] = -1;
            }

            if (button7.BackColor == Color.Black)
            {
                pattern[6] = 1;
            }
            else
            {
                pattern[6] = -1;
            }

            if (button8.BackColor == Color.Black)
            {
                pattern[7] = 1;
            }
            else
            {
                pattern[7] = -1;
            }

            if (button9.BackColor == Color.Black)
            {
                pattern[8] = 1;
            }
            else
            {
                pattern[8] = -1;
            }
            #endregion
            Network h1 = new Network(wt1, wt2, wt3, wt4, wt5, wt6, wt7, wt8, wt9);
            int[] copy = pattern;
            Boolean unstable = false;
            h1.Activation(pattern);
            for (int i = 0; i < 9; i++)
            {
                if (h1.output[i] == pattern[i])
                {
                    Console.WriteLine("\nPattern: " + pattern[i] + "\tOutput: " + h1.output[i] + "\tCOMPONENT MATCHES");
                }
                else
                {
                    Console.WriteLine("\nPattern: " + pattern[i] + "\tOutput: " + h1.output[i] + "\tDISCREPANCY OCCURRED");
                    unstable = true;
                }
            }

            while (unstable)
            {
                for(int i = 0; i < pattern.Length; i++)
                {
                    if (h1.output[i] != copy[i])
                    {
                        copy = h1.output;
                        h1.Activation(copy);
                        for (int a = 0; a < 9; a++)
                        {
                            if (h1.output[a] == copy[a])
                            {
                                Console.WriteLine("\nPattern: " + copy[a] + "\tOutput: " + h1.output[a] + "\tCOMPONENT MATCHES");
                            }
                            else
                            {
                                Console.WriteLine("\nPattern: " + copy[a] + "\tOutput: " + h1.output[a] + "\tDISCREPANCY OCCURRED");
                                unstable = true;
                            }
                        }
                        unstable = false;
                        break;
                    }
                    unstable = true;
                }
            }

            #region output
            if (h1.output[0] == 1)
            {
                button10.BackColor = Color.Black;
            }
            else
            {
                button10.BackColor = Color.White;
            }

            if (h1.output[1] == 1)
            {
                button11.BackColor = Color.Black;
            }
            else
            {
                button11.BackColor = Color.White;
            }

            if (h1.output[2] == 1)
            {
                button12.BackColor = Color.Black;
            }
            else
            {
                button12.BackColor = Color.White;
            }

            if (h1.output[3] == 1)
            {
                button13.BackColor = Color.Black;
            }
            else
            {
                button13.BackColor = Color.White;
            }

            if (h1.output[4] == 1)
            {
                button14.BackColor = Color.Black;
            }
            else
            {
                button14.BackColor = Color.White;
            }

            if (h1.output[5] == 1)
            {
                button15.BackColor = Color.Black;
            }
            else
            {
                button15.BackColor = Color.White;
            }

            if (h1.output[6] == 1)
            {
                button16.BackColor = Color.Black;
            }
            else
            {
                button16.BackColor = Color.White;
            }

            if (h1.output[7] == 1)
            {
                button17.BackColor = Color.Black;
            }
            else
            {
                button17.BackColor = Color.White;
            }
                
            if (h1.output[8] == 1)
            {
                button18.BackColor = Color.Black;
            }
            else
            {
                button18.BackColor = Color.White;
            }
            #endregion
        }

        private void button20_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;
            button1On = true;
            button2On = true;
            button3On = true;
            button4On = true;
            button5On = true;
            button6On = true;
            button7On = true;
            button8On = true;
            button9On = true;
        }
        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }


    }
}
