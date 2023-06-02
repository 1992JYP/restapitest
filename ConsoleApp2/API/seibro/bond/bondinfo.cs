using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGIO_DOTNET.API.seibro.bond
{
    internal class Bondinfo : SeibroAPI
    {
        public string? Tetstest;
        static string returnURLFormat = "{0}&apiId={1}&params=ISSU_DT:{2}";
        public Bondinfo(string date)
        {
            ApiID = "getBondIssuInfo";

            Params = date;

        }
        public Bondinfo(string date, string Params)
        {

        }

        public string Fn_returnUrl()
        {
            string finURL = string.Format(returnURLFormat, Fn_SettingUrl(), ApiID, Params);
            return finURL;
        }

        public override RestClient Fn_RestClient()
        {
            RestClientOptions restClientOptions = new(Fn_returnUrl());
            restClientOptions.MaxTimeout = 1000;
            RestClient restClient = new(restClientOptions);

            return restClient;
        }
    }
}
