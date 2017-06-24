using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JashukProjekt.Dane;

namespace JashukProjekt
{
    public partial class TotalProf : Form
    {
        private TotaLinne inne = new TotaLinne();
        public TotalProf()
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
            double Balance = Convert.ToDouble(balance.Value);//переводим из строчной в цифры
            double Funds = Convert.ToDouble(inne.TotalFun);//переводим из строчной в цифры
            double Capital = Convert.ToDouble(inne.TotalAnother);//переводим из строчной в цифры
            if (Funds + Capital != 0)
            {
                double Answer = Balance/(Funds+Capital);
                total.Text = Convert.ToString(Math.Round(Answer, 2));//вывод в форме total c округлением до двух знаков после запятой
            }
            else
            {
                Bled bled= new Bled();
                bled.Show();
            }
        }

        private void funds_ValueChanged(object sender, EventArgs e)
        {
            AverValOfPrinOccupFunds fun = new AverValOfPrinOccupFunds();
            fun.Show();
            funds.Value = fun.total.Value;
        }

        private  void funds_Click(object sender, EventArgs e)
        {
            AverValOfPrinOccupFunds fun = new AverValOfPrinOccupFunds();
            fun.Show();
            funds.Value = fun.total.Value;
        }

        private void capital_ValueChanged(object sender, EventArgs e)
        {
            AverValOfWorkCap cap = new AverValOfWorkCap();
            cap.Show();
            funds.Value = cap.total.Value;
        }

        private void capital_Click(object sender, EventArgs e)
        {
            AverValOfWorkCap cap = new AverValOfWorkCap();
            cap.Show();
            funds.Value = cap.total.Value;
        }
    }
}
