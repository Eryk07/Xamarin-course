using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App2.Models;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Lists2 : ContentPage
    {
        
        
         void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
           listView.ItemsSource= GetContacts(e.NewTextValue);
        }

        IEnumerable<Contact> GetContacts(string searchText=null)
        {
            var contacts= new List<Contact> {
                    new Contact { Name = "Eri", ImageUrl = "http://lorempixel.com/100/100/people/1", Status = "No elo" },
                    new Contact { Name = "Madzia", ImageUrl = "http://lorempixel.com/100/100/people/2", Status = "Hajo :(" }
                };

            if(String.IsNullOrWhiteSpace(searchText))
            return contacts;

            return contacts.Where(c => c.Name.StartsWith(searchText));
        }
        void Handle_Refreshing (object sender, System.EventArgs e)
        {
            listView.ItemsSource = GetContacts();

            listView.EndRefresh();
        }

        public Lists2()
        {
            InitializeComponent();

           
            listView.ItemsSource = GetContacts();
        }
    }
}