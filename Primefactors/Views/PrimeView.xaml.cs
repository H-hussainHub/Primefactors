using Primefactors.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Primefactors.Views
{
    /// <summary>
    /// Interaction logic for PrimeView.xaml
    /// </summary>
    public partial class PrimeView : UserControl
    {
        public PrimeView()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);
        }


        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            EratosthenesViewModel eratosthenes = new EratosthenesViewModel();

           
            string entered = Factorise.Text;
            int toFactorise;
            bool ok = int.TryParse(entered, out toFactorise);
            if (ok && toFactorise >= 2)
                {
                    StringBuilder factorList = new StringBuilder();

                    foreach (int factor in GetPrimeFactors(toFactorise, eratosthenes))
                    {
                        if (factorList.Length == 0)
                            factorList.Append(" ");
                        else
                            factorList.Append(", ");
                            factorList.Append(factor);
                    }


                    PrimeFactors.Text = factorList.ToString();
                }
            

        }

        // search factorisation algorithm
        private static IEnumerable<int> GetPrimeFactors(int value, EratosthenesViewModel eratosthenes)
        {
            List<int> factors = new List<int>();

            foreach (int prime in eratosthenes)
            {
                while (value % prime == 0)
                {
                    value /= prime;
                    factors.Add(prime);
                }

                if (value == 1)
                    break;
            }

            return factors;
        }
    }
}
