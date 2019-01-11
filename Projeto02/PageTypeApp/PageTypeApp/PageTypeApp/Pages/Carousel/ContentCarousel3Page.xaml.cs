using PageTypeApp.Pages.Tabbed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PageTypeApp.Pages.Carousel
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContentCarousel3Page : ContentPage
	{
		public ContentCarousel3Page ()
		{
			InitializeComponent ();
		}

        public void OnChangePage(object sender, EventArgs e)
        {
            //App.Current.MainPage = new NavigationPage(new Navigation.ContentNavigation1Page());
            App.Current.MainPage = new ContentTabPage();
        }

    }
}