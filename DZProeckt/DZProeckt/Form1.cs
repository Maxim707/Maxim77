using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZProeckt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random random1;
        Random random2;
        string number1;
        int number;
        int numberLetter;

        private void buttonAnswer_Click(object sender, EventArgs e)
        {
            random1 = new Random();
            random2 = new Random();
            number = random1.Next(1, 9 + 1);
            numberLetter = random2.Next(1, 26 + 1);

            switch (numberLetter)
            {
                case 1:
                    number1 = "A";
                    break;

                case 2:
                    number1 = "b";
                    break;

                case 3:
                    number1 = "c";
                    break;

                case 4:
                    number1 = "D";
                    break;

                case 5:
                    number1 = "e";
                    break;

                case 6:
                    number1 = "F";
                    break;

                case 7:
                    number1 = "G";
                    break;

                case 8:
                    number1 = "H";
                    break;

                case 9:
                    number1 = "i";
                    break;

                case 10:
                    number1 = "J";
                    break;

                case 11:
                    number1 = "K";
                    break;

                case 12:
                    number1 = "l";
                    break;

                case 13:
                    number1 = "m";
                    break;

                case 14:
                    number1 = "N";
                    break;

                case 15:
                    number1 = "O";
                    break;

                case 16:
                    number1 = "P";
                    break;

                case 17:
                    number1 = "q";
                    break;

                case 18:
                    number1 = "R";
                    break;

                case 19:
                    number1 = "s";
                    break;

                case 20:
                    number1 = "T";
                    break;

                case 21:
                    number1 = "U";
                    break;

                case 22:
                    number1 = "V";
                    break;

                case 23:
                    number1 = "w";
                    break;

                case 24:
                    number1 = "X";
                    break;

                case 25:
                    number1 = "y";
                    break;

                case 26:
                    number1 = "Z";
                    break;
            }

        }
    }
}
