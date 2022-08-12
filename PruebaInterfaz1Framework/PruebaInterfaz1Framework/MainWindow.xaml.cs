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
using System.IO;
using System.IO.Ports;

namespace PruebaInterfaz1Framework
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static SerialPort serialP = new SerialPort();

        public MainWindow()
        {
            InitializeComponent();

            try { 
            serialP.PortName = "COM3";
            serialP.BaudRate = 9600;

            //serialP.ReadTimeout = 500;
            //serialP.WriteTimeout = 500;

            serialP.Open();
            }
            catch { }
        }

        private void changeStateL1(object sender, RoutedEventArgs e)
        {
            string estado = Convert.ToString(estadoL1.Content);
            if (estado == "Off")
            {
                estado = "On";
                estadoL1.Background = Brushes.Lime;
            }
            else
            {
                estado = "Off";
                estadoL1.Background = Brushes.Red;
            }
            estadoL1.Content = estado;
        }

        private void changeStateL2(object sender, RoutedEventArgs e)
        {
            string estado = Convert.ToString(estadoL2.Content);
            if (estado == "Off")
            {
                serialP.Write("On");
                estado = "On";
                estadoL2.Background = Brushes.Lime;
            }
            else
            {
                serialP.Write("Off");
                estado = "Off";
                estadoL2.Background = Brushes.Red;

            }
            estadoL2.Content = estado;
    }

        private void changeStateL3(object sender, RoutedEventArgs e)
        {
            string estado = Convert.ToString(estadoL3.Content);
            if (estado == "Off")
            {
                estado = "On";
                estadoL3.Background = Brushes.Lime;
            }
            else
            {
                estado = "Off";
                estadoL3.Background = Brushes.Red;
            }
            estadoL3.Content = estado;
    }
        private void CambioPuerto(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                int indice = Puertos.SelectedIndex;
                serialP.PortName = Puertos.Items[indice].ToString();
            }
            catch { }
        }
        private void CambioBaudios(object sender, SelectionChangedEventArgs e)
        {
            try {
            int indice = frecuenciaBaudios.SelectedIndex;
            serialP.BaudRate = Int32.Parse(frecuenciaBaudios.Items[indice].ToString());
            } catch { }
        }
    }
}
