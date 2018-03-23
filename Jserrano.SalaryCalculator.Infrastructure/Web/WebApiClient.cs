using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jserrano.SalaryCalculator.Infrastructure.Web
{
    using System.Net.Http;

    public class WebApiClient<T> 
    {
        public static async Task<IEnumerable<T>> GetModelFromApi(string apiUrl)
        {
            IEnumerable<T> employees = new List<T>();
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsStringAsync();
                    employees = Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<T>>(data);
                }
            }
            return employees;
        }
    }
}
