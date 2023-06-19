using Google.Protobuf.WellKnownTypes;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.RepresentationModel;

namespace EGIO_DOTNET.extract.Crawler.seibro
{
    internal class absplan
    {
        public static string baseURL = "https://kind.krx.co.kr/disclosure/details.do";
        public static HttpClient httpClient = new HttpClient()
        {
            BaseAddress = new Uri(baseURL)
        };
        public static string yamlData = @"

        ";

        public absplan()
        {
            var httpRequest = (HttpWebRequest)WebRequest.Create(baseURL);

            httpRequest.Accept = "application/json";
            httpRequest.ContentType = "application/json";
            httpRequest.Method = "POST";
            httpRequest.UserAgent = "Mozilla/4.0 (compatible; MSIE 5.01; Windows NT 5.0)";

            using (var sw = new StreamWriter(httpRequest.GetRequestStream()))
            {
                sw.Write("method=searchDetailsSub&currentPageSize=100&pageIndex=1&orderMode=1&orderStat=D&forward=details_sub&repIsuSrtCd=&fromDate=2023-01-28&toDate=2023-02-28");
            }

            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();

            StringBuilder sb = new StringBuilder();

            using(var sr  =new StreamReader(httpResponse.GetResponseStream()))
            {
                sb.AppendLine(sr.ReadToEnd());
            }
            httpResponse.Close();

            Console.WriteLine(sb.ToString());
        }


        public string Fn_returnUrl()
        {
            string finURL = string.Format("https://seibro.or.kr/websquare/engine/proworks/callServletService.jsp");
            return finURL;
        }

        //public RestClient Fn_RestClient()
        //{

        //    //HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(Fn_returnUrl());
        //    //httpWebRequest.Method = "POST";
        //    //Stream requestStream = null;


        //    //RestClientOptions restClientOptions = new(Fn_returnUrl(),);
        //    //restClientOptions.MaxTimeout = 1000;
        //    //RestClient restClient = new(restClientOptions,Configure);

        //    //return restClient;
        //}
    }
}
