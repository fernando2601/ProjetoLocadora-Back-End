using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ApiAprender
{
    public static class ConsumirApi
    {
        public static string apiBasicUri { get; set; }


        // In my case this is https://localhost:44324/api/cliente/Cadastrar

        public static async Task Post<T>(string url, T contentValue)
        {
            try
            {
                var client = new HttpClient();
                client.Timeout = TimeSpan.FromMinutes(3);

                client.BaseAddress = new Uri("https://localhost:44324/api/");
                var content = new StringContent(JsonConvert.SerializeObject(contentValue), Encoding.UTF8, "application/json");
                var result = await client.PostAsync(url, content);
                result.EnsureSuccessStatusCode();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public static async Task Put<T>(string url, T stringValue)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiBasicUri);
                var content = new StringContent(JsonConvert.SerializeObject(stringValue), Encoding.UTF8, "application/json");
                var result = await client.PutAsync(url, content);
                result.EnsureSuccessStatusCode();
            }
        }

        public static async Task<T> Get<T>(string url)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiBasicUri);
                var result = await client.GetAsync(url);
                result.EnsureSuccessStatusCode();
                string resultContentString = await result.Content.ReadAsStringAsync();
                T resultContent = JsonConvert.DeserializeObject<T>(resultContentString);
                return resultContent;
            }
        }
        public class Cliente
        {

            [JsonProperty("id")]
            public int Id { get; set; }
            [JsonProperty("nome")]
            public string Nome { get; set; }
            [JsonProperty("sobrenome")]
            public string Sobrenome { get; set; }
            [JsonProperty("endereco")]
            public string Endereco { get; set; }
            [JsonProperty("renda")]
            public string Renda { get; set; }
            [JsonProperty("cpf")]
            public string Cpf { get; set; }

        }
    }
}