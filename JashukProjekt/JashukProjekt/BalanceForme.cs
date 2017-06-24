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
    public partial class BalanceForme : Form
    {
        public BalanceForme()
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
            double GProfit = Convert.ToDouble(GeneralProfit.Value);//переводим из строчной в цифры
            double PPrice = Convert.ToDouble(PrimePrice.Value);//переводим из строчной в цифры
            double ACharges = Convert.ToDouble(AdminCharges.Value);//переводим из строчной в цифры
            double CCharges = Convert.ToInt32(CommercialCharges.Value);//переводим из строчной в цифры
            double Answer = GProfit - PPrice - ACharges - CCharges;
            total.Text = Convert.ToString(Math.Round(Answer, 2));//вывод в форме total c округлением до двух знаков после запятой
        }
    }
}
