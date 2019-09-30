using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCEP.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PrincipalPage : ContentPage
	{
		public PrincipalPage ()
		{
			InitializeComponent ();
		}

        private void ButtonSoapPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pages.SoapPage());
        }

        private void ButtonRestPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pages.RestPage());
        }

        private void ButtonNugetPage1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pages.NugetPage1());
        }

        private void ButtonNugetPage2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pages.NugetPage2());
        }
    }
}