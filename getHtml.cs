using System;
using RestSharp;
using System.IO;

namespace Program
{
    class getHtml
    {
        static void Main()
        {
            Console.Write("Digite a url:");
            string url = Console.ReadLine();   
            var client = new RestClient(url);
            client.Timeout = 5000;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            string urlReplace = url.Replace("www.","");
            string[] urlChange =urlReplace.Split('/');
            string fileName = (urlChange[2]+".html");           
            System.IO.File.WriteAllText(fileName, response.Content);
            Console.WriteLine("Finish.");
            Console.Write("Press <Enter> to exit... ");
            while (Console.ReadKey().Key != ConsoleKey.Enter){}
        }
    }
}