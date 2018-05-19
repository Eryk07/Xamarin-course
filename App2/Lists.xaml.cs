using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App2.Models;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Lists : ContentPage
	{
		public Lists ()
		{
			InitializeComponent ();


            listView.ItemsSource = new List<Contact>
            {
               
                new Contact {Name="Eri",ImageUrl="http://lorempixel.com/100/100/people/1", Status="No elo"},
               
                new Contact {Name="Madzia",ImageUrl="http://lorempixel.com/100/100/people/2", Status="Hajo :("}
                
            };
            
		}
	}
}