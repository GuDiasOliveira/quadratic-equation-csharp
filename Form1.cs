using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuadraticEquation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BCalc_Click(object sender, EventArgs e)
        {
            double a, b, c;
            bool valid = double.TryParse(TxtA.Text, out a);
            valid &= double.TryParse(TxtB.Text, out b);
            valid &= double.TryParse(TxtC.Text, out c);
            if (valid)
            {
                QuadraticEquation eq = new QuadraticEquation
                {
                    A = a,
                    B = b,
                    C = c
                };
                Complex[] solve = eq.SolveComplex();
                //double[] solve = eq.SolveReal();
                StringBuilder res = new StringBuilder();

                if (solve.Length > 0)
                {
                    if (a != 0)
                        res.Append("Δ = ").Append(eq.Delta);
                    if (solve.Length == 1)
                    {
                        res.Append("     X = ").Append(solve[0]);
                    }
                    else
                    {
                        res.Append("     X' = ").Append(solve[0]);
                        res.Append("     X'' = ").Append(solve[1]);
                    }

                    LblRes.Text = res.ToString();
                }
                else
                {
                    LblRes.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Insert valid numbers!");
            }
        }
    }
}
