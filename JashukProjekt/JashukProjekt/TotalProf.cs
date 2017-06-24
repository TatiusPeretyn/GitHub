///<summary>
///słowo kluczowe using, które informuje kompilator, że w programie będziemy korzystali z klas znajdujących się w danej przestrzeni nazw (np. System)</summary>
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
    /// <summary>
    /// Słówko class jest poprzedzone modyfikatorem dostępu np. public</summary>
    public partial class TotalProf : Form
    {

        private TotaLinne inne = new TotaLinne();
        /// <summary>
        /// Konstruktor w którym opisane usunięcie strzałki w NumericUpDown</summary>
        public TotalProf()
        {
            InitializeComponent();
            total.Controls[0].Visible = false;
        }
        /// <summary>
        /// ///metoda która opisuje dzialanie programu po kliknięciu na button2_Click</summary>
        private void button2_Click(object sender, EventArgs e)
        {
            /// <value>
            /// zamykanie poprzez naciśnięcie</value>
            Close();
        }
        /// <summary>
        /// ///metoda która opisuje dzialanie programu po kliknięciu na button2_Click</summary>
        private void button1_Click(object sender, EventArgs e)
        {
            /// <value>
            /// Balance,Fonds,Capital przekształcany na postać cyfrową</value>
            double Balance = Convert.ToDouble(balance.Value);
            double Funds = Convert.ToDouble(inne.TotalFun);
            double Capital = Convert.ToDouble(inne.TotalAnother);
            /// <value>
            /// warunek jeżeli sum nie ruwno się zero wyświetli odpowiedz zaokrągleną do dwóch miejsc po przecinku, w innym przypadku będzie wyświetlony błąd</value>
            if (Funds + Capital != 0)///
            {
                double Answer = Balance/(Funds+Capital);
                total.Text = Convert.ToString(Math.Round(Answer, 2));
            }
            else///
            {
                Bled bled= new Bled();
                bled.Show();
            }
        }
        /// <summary>
        /// ///metody który opisują stworzenie nowych klasy,wyświetlenie tych klasów,w pól funds klasy TotalProf podstawiamy znaczenie wyniku stworzonej klasy  </summary>
        private void funds_ValueChanged(object sender, EventArgs e)
        {                                                          
            AverValOfPrinOccupFunds fun = new AverValOfPrinOccupFunds();
            fun.Show();
            funds.Value = fun.total.Value;
        }
        
        private void funds_Click(object sender, EventArgs e)
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
