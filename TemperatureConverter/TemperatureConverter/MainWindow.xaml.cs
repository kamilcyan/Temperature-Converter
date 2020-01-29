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

namespace TemperatureConverter
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        EnteringTemperature entering = new EnteringTemperature();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CelciusButton_Click(object sender, RoutedEventArgs e)
        {
            entering.InitializeComponent();
        }

        private void KelvinButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FahrenheitButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
