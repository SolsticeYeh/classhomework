using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

//“空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 上有介绍

namespace hwk
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        public class Card
        {
            public string Name { get; set; }
        }

        public ObservableCollection<Card> mcarobservableCollection = new ObservableCollection<Card>();
        private void add_Click(object sender, RoutedEventArgs e)
        {
            if (he.Text != "") 
            {
                mcarobservableCollection.Add(new Card { Name = he.Text });
                mListView.ItemsSource = mcarobservableCollection;
            }

        }

        private async void mListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            await new MessageDialog(((Card)e.ClickedItem).Name).ShowAsync();
        }

    }
}
