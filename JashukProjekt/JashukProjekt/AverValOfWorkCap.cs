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
    public partial class AverValOfWorkCap : Form
    {
        private TotaLinne inne = new TotaLinne();
        public AverValOfWorkCap()
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
            double Start = Convert.ToDouble(start.Value);//переводим из строчной в цифры
            double End = Convert.ToDouble(end.Value);//переводим из строчной в цифры
            double Answer = (Start+End)/2;
            inne.TotalAnother = Answer;
            total.Text = Convert.ToString(Math.Round(Answer, 2));//вывод в форме total c округлением до двух знаков после запятой
        }
    }
}
