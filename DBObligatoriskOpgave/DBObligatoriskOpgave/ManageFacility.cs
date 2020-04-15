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
                    var response = client.PostAsJsonAsync("api/Facilities/", facilityObj).Result;

                }

                catch (Exception)
                {
                    throw;
                }

            }

        }

        public static async void DeleteFacility(int id)
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
                    var response = client.DeleteAsync("api/Facilities/" + id).Result;
                    Console.WriteLine("Your facility has now been deleted");
                }

                catch (Exception)
                {
                    throw;
                }

            }

        }

        public static async void UpdateFacility(int id, Facility facilityObj)
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
                    var response = client.PutAsJsonAsync("api/Facilities/" + id, facilityObj).Result;
                    Console.WriteLine("Your facility is now updated");
                }

                catch (Exception)
                {
                    throw;
                }

            }

        }

    }
}
