using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace ComboBoxWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window,INotifyPropertyChanged
    {

        public ObservableCollection<string> ItemsList { get; set; }
        public string NewPosition { get; set; }
        public ObservableCollection<OwnColor> OwnColorsCollection{ get; set; } 
        #region informowanie bindowania

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
        public MainWindow()
        {
            OwnColorsCollection = new ObservableCollection<OwnColor>();
            OwnColorsCollection.Add(new OwnColor()
            {
                NameOfColor_Pol = "zielony",
                NameOfColor_Eng = "green"
            });
            OwnColorsCollection.Add(new OwnColor()
            {
                NameOfColor_Pol = "czerwony",
                NameOfColor_Eng = "red"
            });
            OwnColorsCollection.Add(new OwnColor()
            {
                NameOfColor_Pol = "fioletowy",
                NameOfColor_Eng = "purple"
            });

            InitializeComponent();
            ItemsList = new ObservableCollection<string>();
            OnPropertyChanged(nameof(ItemsList));
            ItemsList.Add("dodanie");
            ItemsList.Add("dodanei 2");
            ItemsList.Add("dodanie 3");



        }

        private void Button_new_item_combo(object sender, RoutedEventArgs e)
        {
            ItemsList.Add(NewPosition);
            OnPropertyChanged(nameof(ItemsList));
        }
    }
}
