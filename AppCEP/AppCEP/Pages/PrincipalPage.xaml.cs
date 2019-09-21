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
            var resposta = servico.BuscaCEP(entryCEP.Text);

            Label labelResultado = new Label
            {
                Text = string.Format("{0}", resposta.ToString())
            };
            StackLayout stackLayout = new StackLayout();
            stackLayout.Children.Add(labelResultado);
            Content = stackLayout;

        }
    }
}