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
using System.Windows.Threading;

namespace DataSender
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        int _ejeX = 0;
        int _ejeY = 0;
        int _ejeZ = 0;
        String _lat = "0.000000";
        String _lng = "0.000000";
        int _lap = 0;
        int _bateriaPorcentage = 0;
        int _temperatura = 0;
        public MainWindow()
        {
            InitializeComponent();

            //Tiempo
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();

        }

        //Funcion de tiempo real
        void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Content = DateTime.Now.ToLongTimeString();
            instance.Content = DateTime.Now.ToString("HH:mm:ss.fff");


        }


        //Funciones cambio de angulo
        private void CambioAnguloX(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            _ejeX = Convert.ToInt32(e.NewValue);
            ejeX.Content = String.Format("{0}°", _ejeX);
        }

        private void CambioAnguloY(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            _ejeY = Convert.ToInt32(e.NewValue);
            ejeY.Content = String.Format("{0}°", _ejeY);
        }

        private void CambioAnguloZ(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            _ejeZ = Convert.ToInt32(e.NewValue);
            ejeZ.Content = String.Format("{0}°", _ejeZ);
        }


        //Funcion de cambio de coordenadas
        private void CambioCoords(object sender, RoutedEventArgs e)
        {
            _lat = lat.Text;
            _lng = lng.Text; 
        }

        //Cambio de Vuelta
        private void CambioLap(object sender, RoutedEventArgs e)
        {
            _lap = Convert.ToInt32(lap.Text);
        }

        //Cambio estado de bateria
        private void EstadoBateria(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            _bateriaPorcentage = Convert.ToInt32(e.NewValue);
            batery.Content = String.Format("{0}%", _bateriaPorcentage);
        }

        private void CambioTemperatura(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            _temperatura = Convert.ToInt32(e.NewValue);
            temperatura.Content = String.Format("{0}°C", _temperatura);
            temperatureBar.Value = _temperatura;
        }
    }
}
