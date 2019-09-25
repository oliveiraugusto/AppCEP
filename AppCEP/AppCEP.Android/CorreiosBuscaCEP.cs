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

using AppCEP.Interfaces;
using AppCEP.Class;
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
            XmlCEP.end = busca.end;
            XmlCEP.bairro = busca.bairro;
            XmlCEP.cidade = busca.cidade;
            XmlCEP.uf = busca.uf;
        }
    }
}