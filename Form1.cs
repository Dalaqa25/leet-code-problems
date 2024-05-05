using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memkvidreobitoba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Oriricxvi
        {
            public int ricxvi1, ricvxi2;

            public Oriricxvi(int par1, int par2)
            {
                ricxvi1 = par1;
                ricvxi2 = par2;
            }

            public int udidesi()
            {
                if (ricxvi1 > ricvxi2) return ricxvi1;
                else
                    return ricvxi2;
            }

            public int umciresi()
            {
                if (ricxvi1 < ricvxi2)
                {
                    return ricxvi1;
                }
                else
                {
                    return ricvxi2;
                }
            }
        }

        class Samiricxvi : Oriricxvi
        {
            private int cvladi3;
            public Samiricxvi(int par1, int par2, int par3) : base(par1, par2)
            {
                cvladi3 = par3;
            }

            public int max()
            {
                if (ricxvi1 > ricvxi2 && ricxvi1 > cvladi3)
                {
                    return ricxvi1;
                }
                else if (ricvxi2 > ricxvi1 && ricvxi2 > cvladi3)
                {
                    return ricvxi2;
                }
                else
                {
                    return cvladi3;
                }
            }

            public int min()
            {
                if (ricxvi1 < ricvxi2 && ricxvi1 < cvladi3)
                {
                    return ricxvi1;
                }
                else if (ricvxi2 < ricxvi1 && ricvxi2 < cvladi3)
                {
                    return ricvxi2;
                }
                else
                {
                    return cvladi3;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int par1 = int.Parse(textBox1.Text);
            int par2 = int.Parse(textBox2.Text);
            int par3 = int.Parse(textBox3.Text);

            Samiricxvi samiricxvi = new Samiricxvi(par1, par2, par3);

            int result = samiricxvi.max();
            int result2 = samiricxvi.min();

            label1.Text = "უდუდესი: " + result.ToString();
            label2.Text = "უმცირესი: " + result2.ToString();
        }
    }
}
