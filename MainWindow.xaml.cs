using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Zegar
{
    public partial class MainWindow : Window
    {
        private readonly DispatcherTimer czasomierz;
        private readonly CultureInfo Polska = new CultureInfo("pl-PL");
        public MainWindow()
        {
            InitializeComponent();

            OdswiezCzas();

            czasomierz = new DispatcherTimer();
            czasomierz.Interval = TimeSpan.FromSeconds(1);
            czasomierz.Tick += Czasomierz_Tykniecie;
            czasomierz.Start();
        }

        private void Czasomierz_Tykniecie(object? sender, EventArgs e)
        {
            OdswiezCzas();
        }

        private void OdswiezCzas()
        {
            DateTime teraz = DateTime.Now;
            
            TekstGodzina.Text = teraz.ToString("HH:mm:ss");
            TekstData.Text = teraz.ToString("dddd d MMMM yyyy", Polska);
        }
    }
}