using Canducci.Zip;
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
	public partial class NugetPage2 : ContentPage
	{
		public NugetPage2 ()
		{
			InitializeComponent ();
		}

        private async void ButtonBuscarCEPNuget2_Clicked(object sender, EventArgs e)
        {
            try
            {
                var cep = new Canducci.Zip.ZipCodeLoad();
                var dados = await cep.FindAsync(entryBuscarCEPNuget2.Text);

                labelResultadoNuget2.Text = string.Format("Endereço: {0}\n" +
                                                          "Bairro: {1}\n" +
                                                          "Cidade: {2}\n" +
                                                          "UF: {3}",
                                                          dados.Result.Address,
                                                          dados.Result.District,
                                                          dados.Result.City,
                                                          dados.Result.Uf);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}