using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        double a;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void recur(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);

            tota1.Text = resultado_recur(a).ToString();
        }

        private void iter(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);

            tota1.Text = resultado_iter(a).ToString();
        }

        private double resultado_iter(double n) {

            double r = n;

            for (double i = n - 1; i > 0; i--)
            {
                r = r * (i);
            }

            return r;
        
        }

        private double resultado_recur(double n)
        {

            if (n <= 1) return n = 1;

            return n * resultado_recur(n-1) ;
        }
    }
}
