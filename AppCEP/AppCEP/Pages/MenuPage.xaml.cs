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
	public partial class MenuPage : MasterDetailPage
	{
		public MenuPage ()
		{
			InitializeComponent ();
            Detail = new NavigationPage(new PrincipalPage());
        }

        private void AdministradorPage_Tapped(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new LoginPage());
            IsPresented = false; // fecha o menu
        }

        private void FaleConoscoPage_Tapped(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pages.Menu.ContatoPage());
            IsPresented = false;
        }

        private void SobrePage_Tapped(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pages.Menu.SobrePage());
            IsPresented = false;
        }

        private void PrincipalPage_Tapped(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new PrincipalPage());
        }
    }
}