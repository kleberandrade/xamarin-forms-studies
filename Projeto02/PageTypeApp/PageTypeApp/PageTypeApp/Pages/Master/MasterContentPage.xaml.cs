using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PageTypeApp.Pages.Master
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MasterContentPage : MasterDetailPage
	{
		public MasterContentPage ()
		{
			InitializeComponent ();
		}

        private void ChangePage1(object sender, EventArgs e)
        {
            Detail = new Navigation.ContentNavigation1Page();
            IsPresented = false;
        }

        private void ChangePage2(object sender, EventArgs e)
        {
            Detail = new Navigation.ContentNavigation2Page();
            IsPresented = false;
        }

        private void ChangePage3(object sender, EventArgs e)
        {
            Detail = new InternalContentPage();
            IsPresented = false;
        }

    }
}