using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Primefactors.ViewModels
{
    class PrimeViewModel : ViewModelBase
    {
        private int _factorise;
        public int Factorise
        {
            get
            {
                return _factorise;
            }
            set
            {
                _factorise = value;
                OnPropertyChanged(nameof(Factorise));
            }
        }

        private int _primeFactors;
        public int PrimeFactors
        {
            get
            {
                return _primeFactors;
            }
            set
            {
                _primeFactors = value;
                OnPropertyChanged(nameof(PrimeFactors));
            }
        }

        public ICommand SubmitCommand { get; }

        public ICommand CancelCommand { get; }

    }
}
