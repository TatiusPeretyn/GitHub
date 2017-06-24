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
    public partial class ProfitOfInvest : Form
    {
        public ProfitOfInvest()
        {
            InitializeComponent();
            total.Controls[0].Visible = false;//убираем стрелки в форме total
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double NetProfit = Convert.ToDouble(netProf.Value);//переводим из строчной в цифры
            double Passive = Convert.ToDouble(passive.Value);//переводим из строчной в цифры
            double Funds = Convert.ToDouble(funds.Value);//переводим из строчной в цифры

            if((Passive + Funds)!=0)
            {
                double Answer = NetProfit / (Passive + Funds);
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
