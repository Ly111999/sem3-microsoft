using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using WeatherApp.Model;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace WeatherApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            collection = new ObservableCollection<List>();
            this.DataContext = this;
        }

        public ObservableCollection<List> collection { get; set; }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var position = await LocationData.GetPosition();
            var lon = position.Coordinate.Longitude;
            var lat = position.Coordinate.Latitude;

            Debug.WriteLine(lat);
            Debug.WriteLine(lon);

            RootObject forecast = await APIWeather.GetWeather(lat, lon);
            for (int i = 0; i < forecast.list.Count; i++)
            {
                collection.Add(forecast.list[i]);
            }

            ForeCasGridView.ItemsSource = collection;

        }
    }
}
