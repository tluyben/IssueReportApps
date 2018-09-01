using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace WPFListViewApp
{
    public class ListViewApp : Xamarin.Forms.Application
    {

        public ListViewApp()
        {
            StackLayout l1 = new StackLayout
            {
                Orientation = StackOrientation.Horizontal
            };

            ListView listView = new ListView
            {
                WidthRequest = 100,
                ItemsSource = new List<string> { "Item 1", "Item 2", "Item 3", "Item 4" }
            };
            listView.ItemTapped += (object sender, ItemTappedEventArgs e) => Console.WriteLine("Item tapped : " + e.Item);
            listView.ItemSelected += (object sender, SelectedItemChangedEventArgs e) => Console.WriteLine("Item selected : " + e.SelectedItem);

            l1.Children.Add(listView);

            Button clear = new Button
            {
                Text = "Clear List"
            };

            l1.Children.Add(clear);

            clear.Clicked += (s, e) =>
            {
                listView.ItemsSource = new List<string> { "Item 5", "Item 6", "Item 7", "Item 8" }; 
            };

            MainPage = new ContentPage
            {
                Content = l1
            };
        }
    }
}
