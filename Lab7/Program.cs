using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        private static bool isRunning = true;
        static async Task Main(string[] args)
        {
            using(HttpClient client = new HttpClient())
            {
                double lat = 0;
                double lon = 0;
                var latStr = "";
                var lonStr = "";
                var apiString = $"https://nominatim.openstreetmap.org/reverse?format=geojson&lat={lat}&lon={lon}";
                client.DefaultRequestHeaders.Add("User-Agent", "C# App");
                do
                {
                    
                
                    Console.WriteLine("Input lat");
                do
                {
                    latStr = Console.ReadLine();
                    double.TryParse(latStr, out lat);
                } while (!double.TryParse(latStr, out lat));
                Console.WriteLine("Input lon");
                do
                {
                        lonStr = Console.ReadLine();
                        double.TryParse(lonStr, out lon);
                    } while (!double.TryParse(lonStr, out lon));
                    
                    
                    HttpResponseMessage pointsResponse = await client.GetAsync(apiString);
                    
                    if (pointsResponse.IsSuccessStatusCode)
                    {
                        try
                        {
                            Root root = await pointsResponse.Content.ReadFromJsonAsync<Root>();
                            if (root != null)
                                foreach (var reature in root.Features)
                                {
                                    Console.WriteLine(reature.Properties.Address.Country);
                                    Console.WriteLine(reature.Properties.Address.City);
                                    Console.WriteLine(reature.Properties.Address.Road);
                                    Console.WriteLine(reature.Properties.Address.HouseNumber);
                                }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                            throw;
                        }
                        
                    }
                    else
                    {
                        string resp = await pointsResponse.Content.ReadAsStringAsync();
                        Console.WriteLine(resp);
                    }
                    
                    Console.WriteLine("Choose command: again or exit ?");
                    var command = Console.ReadLine();
                    if (command == "exit")
                    {
                        isRunning = false;
                        Console.WriteLine("Bye!");
                    }
                    else if (command == "again")
                    {
                        Console.WriteLine("OK!");
                    }
                } while (isRunning);
            }
        }
    }
}




