using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Sibrtye
        {
            public double gverdi1;
            public double gverdi2;
            public double gverdi3;
            public string Naxva()
            {
                return "პირველი და მეორე გვერდი: " + gverdi1.ToString() + " " + gverdi2.ToString();
            }

        }

        class Samkutxedi : Sibrtye
        {
            public string tipi;

            public double Perimetri()
            {
                return gverdi1 + gverdi2 + gverdi3;
            }

            public string TipisNaxva()
            {
                return "სამკუთხედის სახე: " + tipi.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Samkutxedi samkutxedi = new Samkutxedi();

            samkutxedi.gverdi1 = double.Parse(textBox1.Text);
            samkutxedi.gverdi2 = double.Parse(textBox2.Text);
            samkutxedi.gverdi3 = double.Parse(textBox3.Text);
            samkutxedi.tipi = " ტოლგვერდა ";

            label1.Text = samkutxedi.TipisNaxva();
            label2.Text = samkutxedi.Naxva();
            double result = samkutxedi.Perimetri();
            label3.Text = "პერიმეტრი: " + result.ToString();
        }
    }
}
