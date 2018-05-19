using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ImageExcercise : ContentPage
	{
        private int i = 1;
		public ImageExcercise ()
		{
			InitializeComponent ();
            
		}


        private void Handle_Clicked_Right (object source, EventArgs e)
        {
            if (i == 10)
                i = 1;
            else
                i++;
            string myString = i.ToString();
            label.Text = myString;
            image.Source = "http://lorempixel.com/1920/1080/city/" + myString;
        }

        private void Handle_Clicked_Left (object source, EventArgs e)
        {
            if (i == 1)
                i = 10;
            else
                i--;
            string myString = i.ToString();
            label.Text = myString;
            image.Source = "http://lorempixel.com/1920/1080/city/" + myString;

        }



        
       
	}
}