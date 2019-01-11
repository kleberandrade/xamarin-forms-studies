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
	public partial class InternalContentPage : ContentPage
	{
		public InternalContentPage()
		{
			InitializeComponent ();
		}
	}
}