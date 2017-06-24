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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StartForm main = new StartForm();
            this.Hide();
            main.ShowDialog();
            this.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedIndex == 0)
            {
                ProfitOfCircAssets prof = new ProfitOfCircAssets();
                prof.ShowDialog();
            }
            if (comboBox1.SelectedIndex == 1)
            {
                ProfitOfInvest profit = new ProfitOfInvest();
                profit.ShowDialog();
            }
            if (comboBox1.SelectedIndex == 2)
            {
                ReturnOnAssets ret = new ReturnOnAssets();
                ret.ShowDialog();
            }
            if (comboBox1.SelectedIndex == 3)
            {
                ProfitOfImplem implem = new ProfitOfImplem();
                implem.ShowDialog();
            }
            if (comboBox1.SelectedIndex == 4)
            {
                TotalProf totalP = new TotalProf();
                totalP.ShowDialog();
            }
            if (comboBox1.SelectedIndex == 5)
            {
                ProfOfBus bus = new ProfOfBus();
                bus.ShowDialog();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                BalanceForme balance = new BalanceForme();
                balance.ShowDialog();
            }
            if (comboBox2.SelectedIndex == 1)
            {
                SizeOfAssetsForm size = new SizeOfAssetsForm();
                size.ShowDialog();
            }
            if (comboBox2.SelectedIndex == 2)
            {
                AverValOfPrinOccupFunds aver = new AverValOfPrinOccupFunds();
                aver.ShowDialog();
            }
            if (comboBox2.SelectedIndex == 3)
            {
                AverValOfWorkCap work = new AverValOfWorkCap();
                work.ShowDialog();
            }
        }

        private void Personnel_Click(object sender, EventArgs e)
        {
            Personell personnel = new Personell();
            personnel.Show();
        }
    }
}
