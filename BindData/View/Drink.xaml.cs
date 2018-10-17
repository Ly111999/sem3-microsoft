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
using Windows.UI.Xaml.Navigation;
using BindData.Models;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace BindData.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Drink : Page
    {
        public List<Models.Drink> Drinks;
        public Drink()
        {
            this.InitializeComponent();
            Drinks = ManagerDrink.GetDrinks();
        }

        private void GridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var drink = (Models.Drink)e.ClickedItem;
            ResultTextBlock.Text = "You selected " + drink.Name;

        }
    }
}
