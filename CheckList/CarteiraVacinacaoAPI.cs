using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CheckList
{
    public class PeticaoAPI
    {
        protected readonly HttpClient Client;

        public PeticaoAPI()
        {
            this.Client = new HttpClient();
            this.Client.MaxResponseContentBufferSize = 256000;
        }

        public async Task<IList<CarteiraVacinacao>> GetCarts()
        {
            var uri = new Uri("https://listgrid.azurewebsites.net/api/carts");

            var response = await Client.GetAsync(uri);

            if (!response.StatusCode.Equals(HttpStatusCode.OK))
            {
                return null;
            }

            return JsonConvert.DeserializeObject<IList<CarteiraVacinacao>>(response.Content.ReadAsStringAsync().Result);
        }
    }
}
