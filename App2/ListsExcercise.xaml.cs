using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App2.Models;

namespace App2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListsExcercise : ContentPage
	{
        void Handle_TextChanged(object sender,Xamarin.Forms.TextChangedEventArgs e)
        {
            listView.ItemsSource = SearchService.GetSearches(e.NewTextValue);
        }
        void Handle_Refreshing(object sender, System.EventArgs e)
        {
            listView.ItemsSource = SearchService.GetSearches();

            listView.EndRefresh();
        }
        public ListsExcercise ()
		{
			InitializeComponent ();

            listView.ItemsSource = SearchService.GetSearches();
		}
	}
}