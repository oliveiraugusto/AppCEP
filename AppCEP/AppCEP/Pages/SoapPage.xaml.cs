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
	public partial class SoapPage : ContentPage
	{
		public SoapPage ()
		{
			InitializeComponent ();
		}

        protected virtual void OnAppaeatring()
        {
            entryBuscar.Focus();
        }

        private void ButtonBuscar_Clicked(object sender, EventArgs e)
        {
            var servico = DependencyService.Get<ICorreios>();

            servico.BuscaCEP(entryBuscar.Text);


            labelResultado.Text = string.Format("Endereço: {0}\nBairro: {1}\nCidade: {2}\nUF: {3}",
                                                            Class.CEP.end,
                                                            Class.CEP.bairro,
                                                            Class.CEP.cidade,
                                                            Class.CEP.uf);
        }

        private void ButtonLimpar_Clicked(object sender, EventArgs e)
        {

        }
    }
}