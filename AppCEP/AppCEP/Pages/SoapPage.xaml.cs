using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using AppCEP.Interfaces;
using AppCEP.Class;

namespace AppCEP.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SoapPage : ContentPage
	{
		public SoapPage ()
		{
			InitializeComponent ();
		}

        private void ButtonBuscarCEPSoap_Clicked(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(entryBuscarCEPSoap.Text))
            {
                var servico = DependencyService.Get<ICorreios>();
                servico.BuscaCEP(entryBuscarCEPSoap.Text);

                labelResultadoSoap.Text = string.Format("Endereço: {0}\n" +
                                                        "Bairro: {1}\n" +
                                                        "Cidade: {2}\n" +
                                                        "UF: {3}",
                                                        XmlCEP.end,
                                                        XmlCEP.bairro,
                                                        XmlCEP.cidade,
                                                        XmlCEP.uf);
            }
            else
            {
                DisplayAlert("Ops...", "Não deixe os campos em branco", "OK");
            }
        }

        private void ButtonLimparSoap_Clicked(object sender, EventArgs e)
        {

        }
    }
}