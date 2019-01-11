using LayoutApp.Absolute;
using LayoutApp.Grid;
using LayoutApp.Relative;
using LayoutApp.Scroll;
using LayoutApp.Stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LayoutApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void GoAbsolutePage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AbsolutePage());
        }

        private void GoGridPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GridPage());
        }

        private void GoRelativePage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RelativePage());
        }

        private void GoStackPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StackPage());
        }

        private void GoScrollPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ScrollPage());
        }
    }
}
