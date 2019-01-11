using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PageTypeApp.Pages.Tabbed
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContentTabPage : TabbedPage
    {
		public ContentTabPage()
		{
			InitializeComponent ();
		}
	}
}