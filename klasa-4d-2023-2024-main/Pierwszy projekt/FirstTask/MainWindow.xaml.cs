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
using System.Xml.Schema;

namespace FirstTask
{
  

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        public string Username { get; set; }
        public string Age { get; set; }
        public int ammountOfLetters = 0;
        public int ammountOfNumbers = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        private bool CheckIsNumber(string Age)
        {
                foreach (var letter in Age)
                {
                    if (letter < 48 || letter > 58)
                    {
                        ammountOfLetters = ammountOfLetters + 1;
                        if (ammountOfLetters != 0)
                        {
                           
                           
                            return false;
                            break;
                        }
                    }
                }
                return true;
           
        }
        private bool CheckIsWord(string Age)
        {
            foreach (var number in Age)
            {
                if (number<41||number>64)
                {
                    ammountOfNumbers = ammountOfNumbers + 1;
                    if (ammountOfLetters != 0)
                    {
                   

                        return false;
                        break;
                    }
                }
            }
            return true;

        }
        private bool CheckIsAdult(string Age)
        {
            int intAge= Int32.Parse(Age);
            if(intAge >=18)
            {
                return true;
            }
            return false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
            
        {   if (Age==null|| Username==null)
            {
                textBlockResult.Text = "Nie uzupełniono wszystkich danych";
                textBlockResult.Foreground = Brushes.DarkRed;
            }
            else 
            {
                if(CheckIsNumber(Age)==false) 
                {
                    textBlockResult.Text = "Wiek nie jest liczba";
                    textBlockResult.Foreground = Brushes.Red;
                }
                else
                {
                    if(CheckIsWord(Username) == true)
                    {
                        textBlockResult.Text = "Imie nie może mieć liczb";
                        textBlockResult.Foreground = Brushes.Yellow;
                    }
                    else
                    {
                        if (CheckIsAdult(Age) == true)
                        {
                            textBlockResult.Text = "imie " + Username + "Wiek " + Age + " penoletni";
                            textBlockResult.Foreground = Brushes.Green;
                        }
                        else
                        {
                            textBlockResult.Text = "imie " + Username + "Wiek " + Age +"niepełnoletni";
                            textBlockResult.Foreground = Brushes.Green;

                        }
                    }
                }
                
            
            
            
            
            }
     

            

                       
        
        }
    }
}
