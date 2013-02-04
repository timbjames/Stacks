using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Http;

namespace ConsoleApp
{
    class Program
    {

        static void Main(string[] args)
        {
            //DoShit();
            PostAsAsyncJson();
            Console.ReadLine();
        }

        static void PostAsAsyncJson()
        {
            
            var gizmo = new Product() { Name = "Gizmo", Price = 100, Category = "Widget" };
            //Uri gizmoUri = null;

            HttpResponseMessage response = new HttpResponseMessage();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://timjames.me/");

            response = client.PostAsJsonAsync("api/products", gizmo).Result;

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("\nSuccess");
            }
            else
            {
                Console.WriteLine("\nFailed");
            }

        }

        static async void DoShit()
        {
            try
            {
                // Create a New HttpClient object.
                HttpClient client = new HttpClient();

                HttpResponseMessage response = new HttpResponseMessage();
                response = await client.GetAsync("http://simulcast2.kfsnet.co.uk");
                //response.EnsureSuccessStatusCode();

                if (response.IsSuccessStatusCode)
                {

                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Above three lines can be replaced with new helper method in following line 
                    // string body = await client.GetStringAsync(uri);

                    Console.WriteLine(responseBody);
                }
                else
                {
                    Console.WriteLine("\nIsSuccessStatusCode == false");
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
        }
                
    }

    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
    }
}
