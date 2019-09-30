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
	public partial class NugetPage1 : ContentPage
	{
		public NugetPage1 ()
		{
			InitializeComponent ();
		}

        private void ButtonBuscarCEPNuget1_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(entryBuscarCEPNuget1.Text))
            {
                try
                {
                    var resultado = ViaCEP.ViaCEPClient.Search(entryBuscarCEPNuget1.Text);
                    labelResultadoNuget1.Text = string.Format("Endereço: {0}\n" +
                                                              "Bairro: {1}\n" +
                                                              "Cidade: {2}\n" +
                                                              "UF: {3}",
                                                              resultado.Street,
                                                              resultado.Neighborhood,
                                                              resultado.City,
                                                              resultado.StateInitials);
                }
                catch (Exception ex)
                {
                    DisplayAlert("Ops...", "Houve um erro ao acessar os dados\n"+ex.Message,"OK");
                }
            }
            else
            {
                DisplayAlert("Ops...", "Não deixe os campos em branco", "OK");
            }
            
        }

        private void ButtonLimparNuget1_Clicked(object sender, EventArgs e)
        {
            entryBuscarCEPNuget1.Text = "";
            labelResultadoNuget1.Text = "";
        }
    }
}