using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace IsoFM.Common
{
    public class ConsumirApi<TClass> where TClass : class
    {
        public TClass Response(string endereco, string metodo)
        {
            TClass tClass = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(endereco);

                //HTTP GET
                var responseTask = client.GetAsync(metodo);
                responseTask.Wait();

                var result = responseTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<TClass>();
                    readTask.Wait();

                    tClass = readTask.Result;
                }

            }

            return tClass;
        }

        public List<TClass> ResponseList(string endereco, string metodo)
        {
            List<TClass> list = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(endereco);

                //HTTP GET
                var responseTask = client.GetAsync(metodo);
                responseTask.Wait();

                var result = responseTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<TClass>>();
                    readTask.Wait();

                    list = readTask.Result;
                }

            }

            return list;
        }

    }
}
