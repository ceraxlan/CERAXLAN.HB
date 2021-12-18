using CERAXLAN.HB.ConsoleApp.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CERAXLAN.HB.ConsoleApp.Commands
{
    public abstract class BaseCommand
    {
        public abstract RestType GetRestType();
        public abstract object GetRequest();

        public abstract void Valid(List<string> request);

        public abstract string ActionMetod { get; }

        HttpClient httpClient = new HttpClient();
        public virtual void Execute()
        {
            
            string url = Helper.EndPointAddress + this.ActionMetod;
            var restType = this.GetRestType();
            Task<HttpResponseMessage> response;
            string result;
            switch (restType)
            {
                case RestType.Get:
                    {
                        url += this.GetRequest();
                        response = httpClient.GetAsync(url);
                        result = response.Result.Content.ReadAsStringAsync().Result;
                        Console.WriteLine($"Called to {url} address");
                        Console.WriteLine($"Result : {result}");
                    }
                   
                    break;
                case RestType.Post:
                    {
                        var json = JsonConvert.SerializeObject(this.GetRequest());
                        response = httpClient.PostAsync(url, new StringContent(json, Encoding.UTF8, "application/json"));
                        result = response.Result.Content.ReadAsStringAsync().Result;
                        Console.WriteLine($"Called to {url} address");
                        Console.WriteLine($"Result : {result}");
                    }
                     
                    break;            
            }                             
        }
    }
}
