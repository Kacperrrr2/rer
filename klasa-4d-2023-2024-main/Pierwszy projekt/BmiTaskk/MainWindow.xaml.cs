using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace BmiTaskk
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string HeightStr { get; set; }
        public string WeightStr { get; set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private bool Validation(string HeightStr , string WeightStr,out string message,out string color)
        {
            if (HeightStr == null || WeightStr == null)
            {
                message = "Nie uzupełniono wszystkich danych";
                color="DarkRed";
                return false;
            }
            if (!float.TryParse(HeightStr,out _))
            {
                message = "Nie uzupełniono wszystkich danych";
                color = "DarkRed";
                return true;
            }

            message = null;
            color = null;
            return true;

 
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //walidacja
            if (HeightStr == null || WeightStr == null)
            {
                textBlockResult.Text = "Nie uzupełniono wszystkich danych";
                textBlockResult.Foreground = Brushes.DarkRed;
                return;
            }
            
            if (!float.TryParse(HeightStr, out float height))
            {
                textBlockResult.Text = "Wysokość nie jest liczba";
                return;
            }

            if (!float.TryParse(WeightStr, out float weight))
            {
                textBlockResult.Text =" Wzorst nie jest liczba";
                return;
            }
            if (height < 1)
            {
                textBlockResult.Text = "Podany wzrost jest niepoprawny";
                return;
            }

            if (weight < 1)
            {
                textBlockResult.Text = "Podana waga jest niepoprawna";
                return;
            }

            //bmi

            float bmi = weight / (height/100*height/100);
            textBlockResultBmi.Text="Twoje BMI: "+ bmi.ToString();
            
            if (bmi < 16) 
            {
                textBlockResult.Text = "Wygłodzenie";
                                textBlockResult.Foreground = Brushes.DarkRed;
                return;
            }

            if (bmi >= 16 && bmi<=16.99)
            {
                textBlockResult.Text = "Wychudzenie";
                textBlockResult.Foreground = Brushes.DarkRed;
                return;
            }

            if (bmi >= 17 && bmi<= 18.49)
            {
                textBlockResult.Text = "Niedowaga";
                textBlockResult.Foreground = Brushes.Red;
                return;
            }

            if (bmi >=18.5 && bmi<=24.49)
            {
                textBlockResult.Text = "niedowaga";
                textBlockResult.Foreground = Brushes.Orange;
                return;
            }

            if (bmi >= 25 && bmi <= 29.99)
            {
                textBlockResult.Text = "Waga prawidłowa";
                textBlockResult.Foreground = Brushes.Green;
                return;
            }

            if (bmi >= 30 && bmi <= 34.99)
            {
                textBlockResult.Text = "Nadwaga";
                textBlockResult.Foreground = Brushes.Orange;

                return;
            }

            if (bmi >= 30 && bmi <= 34.99)
            {
                textBlockResult.Text = "I stopień otyłości";
                textBlockResult.Foreground = Brushes.LightPink;

                return;
            }

            if (bmi >= 35 && bmi <= 39.99)
            {
                textBlockResult.Text = "II stopień otyłości";
                textBlockResult.Foreground = Brushes.Red;
                return;
            }
            if (bmi >= 40)
            {
                textBlockResult.Text = "Skrajna otyłość";
                textBlockResult.Foreground = Brushes.DarkRed;
                return;
            }

        }
    }
}
