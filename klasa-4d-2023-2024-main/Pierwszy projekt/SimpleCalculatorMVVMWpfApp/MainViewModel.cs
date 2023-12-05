using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UtilsWpf;


namespace SimpleCalculatorMVVMWpfApp
{
    public class MainViewModel: ObserverVM
    {

        private int firstNumber;
        public int FirstNumber
        {
            get { return firstNumber; }
            set
            {
                firstNumber = value;
                OnPropertyChanged(nameof(FirstNumber));
            }
        }

        private int secondNumber;
        public int SecondNumber
        {
            get { return secondNumber; }
            set
            {
                secondNumber = value;
                OnPropertyChanged(nameof(SecondNumber));
            }
        }
        public ICommand Addcommand { get; set; }

        public ICommand Subcommand { get; set; }

        public MainViewModel()
        {
            Addcommand = new RelayCommand<object>(Add);
            Subcommand = new RelayCommand<object>((object o) =>
                       {
                       int sub = FirstNumber - SecondNumber;
                       Result = "Wynik dodawania " + sub.ToString();
                       });
        }
        private void Add(object o)
        {
            int sum = FirstNumber + SecondNumber;
            Result = "Wynik dodawania " + sum;
        }
        private string result;
        public string Result
        {
            get { return result; }
            set
            {
                result = value;
                OnPropertyChanged(nameof(Result));
            }
        }
    }
}
