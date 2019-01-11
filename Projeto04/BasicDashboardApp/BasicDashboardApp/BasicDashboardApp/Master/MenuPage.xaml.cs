using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasicDashboardApp.Master
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuPage : MasterDetailPage
	{
		public MenuPage ()
		{
			InitializeComponent ();
		}

        private void GoProfile1Page(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pages.Profile1Page());
            IsPresented = false;
        }

        private void GoAboutPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pages.AboutPage());
            IsPresented = false;
        }
    }
}