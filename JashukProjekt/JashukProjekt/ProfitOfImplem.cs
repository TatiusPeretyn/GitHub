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
    public partial class ProfitOfImplem : Form
    {
        public ProfitOfImplem()
        {
            InitializeComponent();
            total.Controls[0].Visible = false;//убираем стрелки в форме total
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Profit = Convert.ToDouble(profit.Value);//переводим из строчной в цифры
            double Cost = Convert.ToDouble(cost.Value);//переводим из строчной в цифры
            double Reven = Convert.ToDouble(reven.Value);//переводим из строчной в цифры

            if ((Cost+Reven) != 0)
            {
                double Answer = Profit / (Cost + Reven);
                total.Text = Convert.ToString(Math.Round(Answer, 2));//вывод в форме total c округлением до двух знаков после запятой
            }
            else
            {
                Bled bled = new Bled();
                bled.Show();
            }
        }
    }
}
