// See https://aka.ms/new-console-template for more information
using RestSharp.Authenticators;
using RestSharp;
using System.Threading;
using ConsoleApp2.seibro.bond;

Console.WriteLine("Hello, World!");

string url = "http://seibro.or.kr/OpenPlatform/callOpenAPI.jsp";

string info = "getBondOptionXrcInfo";

string isin = "KR6225693573";
string ERLY_RED_DT = "20230530";


// 조기상환정보

//string finURL = url + "?key=" + key + "&apiId=" + info + "&params=ISIN:" + isin + ",ERLY_RED_DT:" + ERLY_RED_DT;

string finURL = url + "?key=" + key + "&apiId=" + info + "&params=ERLY_RED_DT:" + ERLY_RED_DT;

Console.WriteLine(finURL);

var options = new RestClientOptions(finURL);
options.MaxTimeout = 1000;
var client = new RestClient(options);
var request = new RestRequest();
// The cancellation token comes from the caller. You can still make a call without it.
var response = await client.GetAsync(request);
Console.WriteLine(response.Content);
bondinfo bondinfo = new bondinfo();
Console.WriteLine(bondinfo.getEnum());
Console.ReadLine();