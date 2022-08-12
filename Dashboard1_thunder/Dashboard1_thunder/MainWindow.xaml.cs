using System;
using System.IO;
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

namespace Dashboard1_thunder
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String _pilot = "Ines Garcia";
        int _numPilot = 23;
        String _bestLap = "00:00:00.00";
        String _lastLap = "00.00.00.00";
        String _currentLap = "00:00:00.00";
        int _battery = 90;
        int _position = 1;
        int _thisLap = 10;
        int _totalLap = 20;
        int _revolution = 2500;
        int _engine = 2;
        int _speed = 25;
        int _weather = 35;
        int _trackTemperature = 45;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int latitude = 0;
            int longitude = 0;
            try
            {
                var reader = new StreamReader(File.OpenRead(@"E:\archivoPistas\CoordenadasPista.csv"));
                List<string> listA = new List<string>();
                List<string> listB = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    listA.Add(values[0]);
                    listB.Add(values[1]);

                }

                foreach (var coloumn1 in listA)
                {
                    latitude++;
                }
                foreach (var coloumn2 in listB)
                {
                    longitude++;
                }
            }
            catch
            {
                Console.WriteLine("No se encuentra el archivo");
            }
            n_lat.Content = $"#lat: {latitude}";
            n_lng.Content = $"#lng: {longitude}";
        }
    }
}
