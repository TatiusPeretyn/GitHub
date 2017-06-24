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
    public partial class AverValOfPrinOccupFunds : Form
    {
        private TotaLinne inne = new TotaLinne();
        public AverValOfPrinOccupFunds()
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
            double Reven = Convert.ToDouble(reven.Value);//переводим из строчной в цифры
            double Aver = Convert.ToDouble(aver.Value);//переводим из строчной в цифры

            if ( Aver != 0)
            {
                double Answer = Reven / Aver;
                inne.TotalFun = Answer;
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
