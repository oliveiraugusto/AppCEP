using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using Xamarin.Forms;

[assembly:Dependency(typeof(AppCEP.Droid.CorreiosBuscaCEP))]
namespace AppCEP.Droid
{
    public class CorreiosBuscaCEP : ICorreios
    {
        public void BuscaCEP(string cep)
        {
            var correios = new WSCorreios.AtendeClienteService();
            var busca = correios.consultaCEP(cep);
            AppCEP.Class.CEP.end = busca.end;
            AppCEP.Class.CEP.bairro = busca.bairro;
            AppCEP.Class.CEP.cidade = busca.cidade;
            AppCEP.Class.CEP.uf = busca.uf;
        }
    }
}