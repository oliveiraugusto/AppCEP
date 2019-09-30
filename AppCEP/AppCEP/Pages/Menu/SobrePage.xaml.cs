using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCEP.Pages.Menu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SobrePage : ContentPage
	{
		public SobrePage ()
		{
			InitializeComponent ();
            labelSobre.Text = "O aplicativo AppCEP visa demonstrar os conceitos de Desenvolvimento Mobile utilizando-se dos conceitos de Programação Orientada a Objetos, Plataforma .Net, C#, Banco de Dados e muitas outras.\n" +
                              "Essas Tecnologias são vistas pelos alunos do Curso Tecnico em Informatica do Senac Botucatu";
		}

        private void ButtonVisiteSenacBotucatu_Clicked(object sender, EventArgs e)
        {
            string url = "http://www.sp.senac.br/botucatu";

            //Exemplo usando o navegador do Device            
            //Device.OpenUri(new Uri(url));

            //Usando uma WebView
            var navegador = new WebView();
            navegador.Source = url;

            NavigationPage.SetHasNavigationBar(this, false); // esconde a barra (NavigationBar) para o ususario ver o Site

            Content = navegador;
        }
    }
}