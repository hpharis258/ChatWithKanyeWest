// Console Kanye Rest 
using System.Net;
using System.Text.Json;
using System.Text.Json.Nodes;

string Url = "https://api.kanye.rest/";
while (true)
{
    Console.WriteLine("Input Text and Press Enter to Talk With Kanye West!");
    Console.ReadLine();
    Console.WriteLine();
    var request = WebRequest.Create(Url);
    request.Method= "GET";
    using var Webresponse = request.GetResponse();
    using var webStream = Webresponse.GetResponseStream();
    
    using var reader = new StreamReader(webStream);
    var data = reader.ReadToEnd();
    using JsonDocument quote = JsonDocument.Parse(data);
    //Console.WriteLine(data);
    JsonElement root = quote.RootElement;
    Console.WriteLine("Kanye: ");
    Console.WriteLine(root.GetProperty("quote"));
    Console.WriteLine(" ");
}