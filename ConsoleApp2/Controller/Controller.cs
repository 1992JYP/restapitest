﻿using EGIO_DOTNET.extract.API.seibro.bond;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace EGIO_DOTNET.Controller
{
    internal class Controller
    {
        public Controller() { }
        public virtual async void Fn_Contol()
        {
            Bondinfo bondinfo1 = new("20230531");

            RestClient restClient = bondinfo1.Fn_RestClient();

            RestRequest request = new RestRequest();
            RestResponse response = await restClient.GetAsync(request);
            Console.WriteLine(response.Content + "\n\n\n");

            XmlDocument xml = new XmlDocument();
            xml.LoadXml(response.Content);

            XmlNodeList xmlNodeList = xml.GetElementsByTagName("ISIN");

            foreach (XmlNode xmlNode in xmlNodeList)
            {
                Console.WriteLine(xmlNode.Attributes["value"].Value);
            }
        }
    }
}
