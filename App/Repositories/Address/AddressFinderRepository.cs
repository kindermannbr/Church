using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Church.App.Repositories.Address
{
    public class AddressFinderRepository : IAddressFinderRepository
    {
        public async Task FindAddress(string cep)
        {

            using (HttpClient httpClient = new HttpClient())
            {
                var response = await httpClient.GetStringAsync($"https://viacep.com.br/ws/{cep}/json/");
                var address = JsonConvert.DeserializeObject<Domains.Address>(response);

                Console.WriteLine(address.Bairro);                
            }
        }
    }
}
