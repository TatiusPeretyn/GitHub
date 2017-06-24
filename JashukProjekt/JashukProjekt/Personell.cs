using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JashukProjekt
{
    public partial class Personell : Form
    {
        public Personell()
        {
            InitializeComponent();
            total.Controls[0].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            double N1 = Convert.ToDouble(n1.Value);
            double N2 = Convert.ToDouble(n2.Value);
            double N3 = Convert.ToDouble(n3.Value);
            double N4 = Convert.ToDouble(n4.Value);
            double N5 = Convert.ToDouble(n5.Value);
            double N6 = Convert.ToDouble(n6.Value);
            double N7 = Convert.ToDouble(n7.Value);
            double N8 = Convert.ToDouble(n8.Value);
            double N9 = Convert.ToDouble(n9.Value);
            double N10 = Convert.ToDouble(n10.Value);
            double Answer = N1+N2+N3+N4+N5+N6+N7+N8+N9+N10;
            total.Text = Convert.ToString(Math.Round(Answer, 2));
        }
    }
}