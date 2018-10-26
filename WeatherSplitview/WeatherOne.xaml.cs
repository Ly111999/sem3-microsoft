using System;
using System.Collections.Generic;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace WeatherSplitview
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class WeatherOne : Page
    {
        public WeatherOne()
        {
            this.InitializeComponent();
            Get_Click();
        }

        private async void Get_Click()
        {
            var position = await LocationData.GetPosition();
            var lat = position.Coordinate.Latitude;
            var lon = position.Coordinate.Longitude;

            RootObject myWeather = await APIManager.GetWeatherOne(lat, lon);

            string icon = String.Format("ms-appx:///Assets/Weather/{0}.png", myWeather.weather[0].icon); // lấy theo tương đối

            ResultImage.Source = new BitmapImage(new Uri(icon, UriKind.Absolute)); // lấy ra icon theo vị trí tuyệt đối 
            TempleText.Text = ((double)myWeather.main.temp).ToString();
            Description.Text = myWeather.weather[0].description;
            LocationText.Text = myWeather.name;
        }
    }
}
