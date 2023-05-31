// See https://aka.ms/new-console-template for more information
using RestSharp.Authenticators;
using RestSharp;
using System.Threading;

Console.WriteLine("Hello, World!");

string url = "http://seibro.or.kr/OpenPlatform/callOpenAPI.jsp";
string key = "2eae9f793f9c774cab31dda30f744d3310d55500369297339b27bba9c2f7ab63";
string info = "getBondOptionXrcInfo";

string isin = "KR6225693573";
string ERLY_RED_DT = "20180824";


string finURL = url + "?key=" + key + "&apiId=" + info + "&params=ISIN:" + isin + ",ERLY_RED_DT:" + ERLY_RED_DT;

Console.WriteLine(finURL);

var options = new RestClientOptions(finURL);
var client = new RestClient(options);
var request = new RestRequest();
// The cancellation token comes from the caller. You can still make a call without it.
var response = await client.GetAsync(request);
Console.WriteLine(response.Content);
Console.ReadLine();