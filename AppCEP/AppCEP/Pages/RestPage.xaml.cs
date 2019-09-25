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
    public partial class RestPage : ContentPage
    {
        public RestPage()
        {
            InitializeComponent();
        }

        private async void ButtonBuscarCEPRest_Clicked(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(entryBuscarCEPRest.Text))
            {
                var servico = new Class.RestCorreios();
                var resultado = await servico.BuscaCEP(entryBuscarCEPRest.Text);
                labelResultadoRest.Text = string.Format("Endereço: {0}\nBairro: {1}\nCidade: {2}\nUF: {3}",
                                                                    resultado.logradouro,
                                                                    resultado.bairro,
                                                                    resultado.localidade,
                                                                    resultado.uf);
            }
            else
            {
                await DisplayAlert("Ops...", "Não deixe os campos em branco", "OK");
            }
        }

        private void ButtonLimparRest_Clicked(object sender, EventArgs e)
        {

        }
    }
}