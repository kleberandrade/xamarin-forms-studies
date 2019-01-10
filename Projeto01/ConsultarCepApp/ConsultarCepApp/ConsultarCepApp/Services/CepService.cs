using ConsultarCepApp.Services.Models;
using Newtonsoft.Json;
using System.Net;

namespace ConsultarCepApp.Services
{
    public class CepService
    {
        private static string URL = "http://viacep.com.br/ws/{0}/json";

        public static Address FindAddressByCep(string cep)
        {
            string urlAddress = string.Format(URL, cep);

            WebClient webClient = new WebClient();
            string result = webClient.DownloadString(urlAddress);

            Address address = JsonConvert.DeserializeObject<Address>(result);
            return address;
        }
    }
}
