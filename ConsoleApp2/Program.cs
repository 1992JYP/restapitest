// See https://aka.ms/new-console-template for more information
using RestSharp;
using EGIO_DOTNET.API.seibro.bond;
using EGIO_DOTNET.API.seibro;
using EGIO_DOTNET.API;
using System.Xml;
using System.Xml.Serialization;

Console.WriteLine("Hello, World!");

string url = "http://seibro.or.kr/OpenPlatform/callOpenAPI.jsp";
string key = "2eae9f793f9c774cab31dda30f744d3310d55500369297339b27bba9c2f7ab63";
string info = "getBondIssuInfo";

string isin = "KR6225693573";
string ERLY_RED_DT = "20230530";


// 조기상환정보

//string finURL = url + "?key=" + key + "&apiId=" + info + "&params=ISIN:" + isin + ",ERLY_RED_DT:" + ERLY_RED_DT;

string finURL = url + "?key=" + key + "&apiId=" + info + "&params=ISSU_DT:" + ERLY_RED_DT;

Console.WriteLine(finURL);

var options = new RestClientOptions(finURL);
options.MaxTimeout = 1000;
var client = new RestClient(options);
var request = new RestRequest();
// The cancellation token comes from the caller. You can still make a call without it.
var response = await client.GetAsync(request);
Console.WriteLine(response.Content+"\n\n\n\n\n\n");

XmlDocument xml = new XmlDocument();
xml.LoadXml(response.Content);

XmlNodeList xmlNodeList = xml.GetElementsByTagName("result");

int i = 0;
foreach (XmlNode xmlNode in xmlNodeList)
{
    Console.WriteLine(i++);
    Console.WriteLine(xmlNode.ChildNodes[0].Attributes["value"].Value);
}

Bondinfo bondinfo = new();

Console.WriteLine(bondinfo.Tetstest);

Console.ReadLine();