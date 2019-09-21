using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace AppCEP.Droid
{
    //Theme precisa receber nossa Style e precisa ser setado como MainLaucher true
    //(Não esqueça de tirar o Main Laucher do MainActivity)
    [Activity(Theme = "@style/MeuTema.Splash", MainLauncher = true)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Create your application here
        }

        //Criamos o metodo OnResume, que vai chamar a Task(Tarefa) de mostrar nossa tela
        // e depois entrar definitivamente no App
        protected override void OnResume()
        {
            base.OnResume();

            //A task chama no nosso metodo StartUp
            Task start = new Task(StartUp);

            //e depois executa
            start.Start();
        }

        //Esse metodo não deixa o usuario pressionar Voltar enquanto o splash é executado
        //não precisa mais que deixar o metodo explicito aqui
        public override void OnBackPressed() { }

        //nosso metodo Startup vai dar um Delay (uma espera) de 5 segundos...
        // depois ele ja chama a Main Activity e voltamos para o App (a MainPage do Nosso App)
        async void StartUp()
        {
            await Task.Delay(5);
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }
    }
}