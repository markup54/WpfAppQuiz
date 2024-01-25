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

namespace WpfAppQuiz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Pytanie> PytanieList { get; set; }
        public int Aktualne {get;set;}
        public MainWindow()
        {
            InitializeComponent();
            przygotujPytania();
            Aktualne = 0;
            wyswietlPytanie();
        }
        private void wyswietlPytanie()
        {
            tresc_txt.Text = PytanieList[Aktualne].TrescPytania;
        }
        private void przygotujPytania()
        {
            PytanieList = new List<Pytanie>();
            PytanieList.Add(new Pytanie("Czy programista zdaje egzamin inf04?", true));
            PytanieList.Add(new Pytanie("Czy programista zdaje egzamin inf02?", false));
            PytanieList.Add(new Pytanie("Czy programista powinien znać się na sieciach komputerowych?", true));
        }

        private void Button_Click_Nastepne(object sender, RoutedEventArgs e)
        {
            Aktualne++;
            wyswietlPytanie();
        }
    }
}
