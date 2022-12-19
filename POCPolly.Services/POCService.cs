using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace POCPolly.Services
{
    public class POCService : IPOCService
    {
        private HttpClient _client;

        public POCService(HttpClient client)
        {
            this._client = client;
        }

        public void Teste()
        {
            var resultado = _client.GetFromJsonAsync<dynamic>(
            "https://dummyjson.com/products/12131231231231231/hee").Result;
            string jsonResultado = JsonSerializer.Serialize(resultado);
            Console.WriteLine("Tentando dnv");
        }
    }
}
