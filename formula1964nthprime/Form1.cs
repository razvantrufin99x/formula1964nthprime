﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formula1964nthprime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        //formula for primes ?
        //c.p. willans , 1964




        public int Factorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }

       

        public double doublewillansnthprimeformula1964(int x)
        {
            int n = x;
            double c = 0;
            double nthprime = 0;

            for (int i = 1; i <= Math.Pow(n, 2); i++)
            {


                for (int j = 1; j <= i; j++)
                {
                    c += Math.Pow((Math.Cos(Math.PI) * ((Factorial(j - 1) + 1) / j)), 2);
                }

                nthprime += Math.Pow((n / c), (1 / n));

            }
            return 1 + nthprime; // aprox is : return 1 + nthprime/3 + 1
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                this.textBox1.Text += i.ToString() + ": \r\t";
                this.textBox1.Text += doublewillansnthprimeformula1964(i).ToString();
                this.textBox1.Text += i.ToString() + ": \r\t";
                this.textBox1.Text += (doublewillansnthprimeformula1964(i)/3+1).ToString();
                this.textBox1.Text += "\r\n";
            }

          
        }
    }
}
