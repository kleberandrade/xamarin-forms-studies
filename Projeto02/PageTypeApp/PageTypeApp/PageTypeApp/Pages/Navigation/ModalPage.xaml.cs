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
	public partial class ModalPage : ContentPage
	{
		public ModalPage ()
		{
			InitializeComponent ();
		}

        private void CloseModal(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
	}
}