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
    public partial class SizeOfAssetsForm : Form
    {
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
            double Assets = Convert.ToDouble(assets.Value);//переводим из строчной в цифры
            double Fund = Convert.ToDouble(fund.Value);//переводим из строчной в цифры
            double Answer = Means+Assets+Fund;
            total.Text = Convert.ToString(Math.Round(Answer, 2));//вывод в форме total c округлением до двух знаков после запятой
        }
    }
}
