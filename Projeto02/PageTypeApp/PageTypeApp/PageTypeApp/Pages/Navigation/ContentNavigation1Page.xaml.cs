using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PageTypeApp.Pages.Navigation
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContentNavigation1Page : ContentPage
	{
		public ContentNavigation1Page ()
		{
			InitializeComponent ();
		}

        public void OnChangePage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContentNavigation2Page());
        }

        public void OnChangeMasterPage(object sender, EventArgs e)
        {
            App.Current.MainPage = new Master.MasterContentPage();
        }
    }
}