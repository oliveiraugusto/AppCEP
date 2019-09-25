using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AppCEP.Class
{
    public class RestCorreios
    {
        public async Task<JsonCEP> BuscaCEP(string cep)
        {
            try
            {
                var cliente = new HttpClient();
                var json = await cliente.GetStringAsync($"https://viacep.com.br/ws/{cep}/json/");
                var dados = JsonConvert.DeserializeObject<JsonCEP>(json);
                return dados;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }

}