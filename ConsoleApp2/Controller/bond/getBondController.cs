using EGIO_DOTNET.API.seibro.bond;
using EGIO_DOTNET.DB;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace EGIO_DOTNET.Controller.bond
{
    internal class GetBondController : Controller
    {
        public GetBondController() { }
        public override async void Fn_Contol()
        {
            Bondinfo bondinfo1 = new("20230531");

            BondDtlInfo bondinfo2 = new();

            RestClient restClient = bondinfo1.Fn_RestClient();

            RestRequest request = new RestRequest();
            RestResponse response = await restClient.GetAsync(request);

            XmlDocument xml = new XmlDocument();
            xml.LoadXml(response.Content);

            XmlNodeList xmlNodeList = xml.GetElementsByTagName("ISIN");

            foreach (XmlNode xmlNode in xmlNodeList)
            {
                bondinfo2.Params = xmlNode.Attributes["value"].Value;
                RestClient restclient = bondinfo2.Fn_RestClient();
                response = restclient.Get(request);
                //Console.WriteLine(response.Content);
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(response.Content);
                XmlNodeList xmlNodeList1 = xmlDocument.GetElementsByTagName("result");



                //xmlDocument.LoadXml(xmlNodeList1[0].Value) ;

                mysql mysql1 = new();
                mysql1.insertXMLTest(xmlNodeList1);

                //Console.WriteLine(xmlDocument);
                Console.WriteLine("\n\n\n");
            }
        }
    }
}
