﻿using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Stamo_sAsyncAwait
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            string url = "https://softuni.bg";

            using (HttpClient client = new HttpClient())
            {
                var result = await client.GetAsync(url);

                if (result.IsSuccessStatusCode)
                {
                    string content = await result.Content.ReadAsStringAsync();
                    Console.WriteLine(content);
                }
            }
        }
    }
}
