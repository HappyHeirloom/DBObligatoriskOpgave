using DBObligatoriskOpgaveWS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DBObligatoriskOpgave
{
    class ManageFacility
    {
        const string serverUrl = "http://localhost:62376";


        public static async void ReadFacilities()
        {
            HttpClientHandler handler = new HttpClientHandler();
            handler.UseDefaultCredentials = true;
            using (var client = new HttpClient(handler))
            {
                client.BaseAddress = new Uri(serverUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                List<Hotel> facilitiesList = new List<Hotel>();

                try
                {
                    var response = client.GetAsync("api/Facilities").Result;
                    var facilities = response.Content.ReadAsAsync<IEnumerable<Facility>>().Result;

                    if (response.IsSuccessStatusCode)
                    {
                        foreach (var item in facilities)
                        {
                            Console.WriteLine(item);
                        }
                    }

                }

                catch (Exception)
                {
                    throw;
                }
            }
        }

        public static async void CreateFacility(Facility facilityObj)
        {
            HttpClientHandler handler = new HttpClientHandler();
            handler.UseDefaultCredentials = true;
            using (var client = new HttpClient(handler))
            {
                client.BaseAddress = new Uri(serverUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {

                }

                catch (Exception)
                {
                    throw;
                }

            }

        }

        public static async void UpdateFacility(int id, string Facility)
        {
            HttpClientHandler handler = new HttpClientHandler();
            handler.UseDefaultCredentials = true;
            using (var client = new HttpClient(handler))
            {
                client.BaseAddress = new Uri(serverUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {

                }

                catch (Exception)
                {
                    throw;
                }

            }

        }

    }
}
