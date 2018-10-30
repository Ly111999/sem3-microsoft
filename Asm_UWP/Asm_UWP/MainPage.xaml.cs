using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Asm_UWP.Model;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Asm_UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public static ObservableCollection<ApiManager.RootObject> listArticle { get; set; }
        public MainPage()
        {
            this.InitializeComponent();
            listArticle = new ObservableCollection<ApiManager.RootObject>();
            this.DataContext = this;
        }

        private async void MainPage_OnLoaded(object sender, RoutedEventArgs e)
        {
            List<ApiManager.RootObject> articles = await ApiManager.GetArticle();
            for (int i = 0; i < articles.Count; i++)
            {
                string deleteHtml = RemoveHtmlTag(articles[i].content.rendered);
                for (int j = 0; j < deleteHtml.Length; j++)
                {
                    var splitContent = deleteHtml.Split('.');
                    var showContent = splitContent[0] + "." + splitContent[1] + "." + splitContent[2] + ".";
                    articles[i].content.rendered = showContent;

                }
                listArticle.Add(articles[i]);
            }

            GridViewShow.ItemsSource = listArticle;

        }
        private static string RemoveHtmlTag(string value)
        {
            var regex1 = Regex.Replace(value, @"<[^>]+>|&nbsp;", "").Trim();
            var regex2 = Regex.Replace(regex1, @"\s{2,}", " ");
            return regex2;
        }
    }
}
