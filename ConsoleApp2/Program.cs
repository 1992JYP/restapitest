// See https://aka.ms/new-console-template for more information
using RestSharp;
using EGIO_DOTNET.API.seibro.bond;
using System.Xml;

Bondinfo bondinfo1 = new("20230531");

RestClient restClient = bondinfo1.Fn_RestClient();

Console.WriteLine(bondinfo1.Fn_returnUrl());

RestRequest request = new RestRequest();
RestResponse response = await restClient.GetAsync(request);
Console.WriteLine(response.Content+"\n\n\n\n\n\n");

XmlDocument xml = new XmlDocument();
xml.LoadXml(response.Content);

XmlNodeList xmlNodeList = xml.GetElementsByTagName("ISIN");

int i = 0;
foreach (XmlNode xmlNode in xmlNodeList)
{
    Console.WriteLine(i++);
    Console.WriteLine(xmlNode.Attributes["value"].Value);
}

Console.ReadLine();