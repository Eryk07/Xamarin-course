using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ImagePage : ContentPage
	{
		public ImagePage ()
		{
			InitializeComponent ();
            //Uri imageSource;
            // imageSource = new Uri("C:/Users/errry/Pictures/ford.jpg");
            // image.Source = ImageSource.FromUri(imageSource);
            image.Source = ImageSource.FromResource("App2.Images.ja.jpg");
          // var embeddedImage = new Image { Source = ImageSource.FromResource("App2.tat.jpg") };

           

        }

        

}
}