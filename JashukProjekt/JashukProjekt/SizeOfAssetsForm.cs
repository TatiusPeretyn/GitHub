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
    public partial class SizeOfAssetsForm : Form
    {
        private TotaLinne inne = new TotaLinne();
        public SizeOfAssetsForm()
        {
            InitializeComponent();
            total.Controls[0].Visible = false;//убираем стрелки в форме total
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Means = Convert.ToDouble(means.Value);//переводим из строчной в цифры
            double Assets = Convert.ToDouble(inne.TotalAnother);//переводим из строчной в цифры
            double Fund = Convert.ToDouble(inne.TotalFun);//переводим из строчной в цифры
            double Answer = Means+Assets+Fund;
            total.Text = Convert.ToString(Math.Round(Answer, 2));//вывод в форме total c округлением до двух знаков после запятой
        }

        private void fund_ValueChanged(object sender, EventArgs e)
        {
            AverValOfPrinOccupFunds fun = new AverValOfPrinOccupFunds();
            fun.Show();
            fund.Value = fun.total.Value;
        }

        private void fund_Click(object sender, EventArgs e)
        {
            AverValOfPrinOccupFunds fun = new AverValOfPrinOccupFunds();
            fun.Show();
            fund.Value = fun.total.Value;
        }

        private void means_ValueChanged(object sender, EventArgs e)
        {
            AverValOfWorkCap cap = new AverValOfWorkCap();
            cap.Show();
            means.Value = cap.total.Value;
            // assets.Value = inne.TotalAnother;
        }

        private void means_Click(object sender, EventArgs e)
        {
            AverValOfWorkCap cap = new AverValOfWorkCap();
            cap.Show();
            means.Value = cap.total.Value;
            // assets.Value = inne.TotalAnother;
        }
    }
}
