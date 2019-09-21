using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using AppCEP.Class;

namespace AppCEP.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PrincipalPage : ContentPage
	{
		public PrincipalPage ()
		{
			InitializeComponent();            
		}

        private void ButtonBuscarCEP_Clicked(object sender, EventArgs e)
        {
            var servico = DependencyService.Get<ICorreios>();
            servico.BuscaCEP(entryCEP.Text);

            labelResultado.Text = string.Format("Endereço: {0}\nBairro: {1}\nCidade: {2}\nUF: {3}",
                                                            CEP.end, CEP.bairro, CEP.cidade, CEP.uf);
        }

        private void ButtonLimpar_Clicked(object sender, EventArgs e)
        {
            labelResultado.Text = "";
            entryCEP.Text = "";
            entryCEP.Focus();
        }
    }
}