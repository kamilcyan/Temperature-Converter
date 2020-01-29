using System;
using System.Collections.Generic;
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

namespace TemperatureConverter
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();
        }

      
        public double number;

        private void EnterButton_Click(object sender, RoutedEventArgs e)
        {
            

            
            if (FahrenheitText.Text != "Fahrenheit")
            {
                Fahrenheit();
            }
            else if (CelciusText.Text != "Celcius")
            {
                Celcius();
            }
            else if (KelvinText.Text != "Kelvin")
            {
                Kelvin();
            }
            else
            {
                KelvinText.Text = "ERROR";
                CelciusText.Text = "ERROR";
                FahrenheitText.Text = "ERROR";
            }
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            KelvinText.Text = "Kelvin";
            CelciusText.Text = "Celcius";
            FahrenheitText.Text = "Fahrenheit";
        }

        

        public int Kelvin()
        {
            number = double.Parse(KelvinText.Text);
            CelciusText.Text = (number - 273).ToString();
            FahrenheitText.Text = ((number * 1.8) - 459.67).ToString();
            return 0;
        }

        public int Fahrenheit()
        {
            float i = 5 / 9;
            number = float.Parse(FahrenheitText.Text);
            CelciusText.Text = ((number - 32) / 1.8).ToString();
            KelvinText.Text = ((number + 460) * i).ToString();
            return 0;
        }
        public int Celcius()
        {
            number = double.Parse(CelciusText.Text);
            FahrenheitText.Text = (32 + 1.8 * number).ToString(); ;
            KelvinText.Text = (number + 273).ToString();
            return 0;
        }
    }
}
