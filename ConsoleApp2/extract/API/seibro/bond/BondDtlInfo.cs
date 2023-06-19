using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGIO_DOTNET.extract.API.seibro.bond
{
    internal class BondDtlInfo : SeibroAPI
    {
        static string returnURLFormat = "{0}&apiId={1}&params=ISIN:{2}";

        public BondDtlInfo()
        {
            ApiID = "getBondStatInfo";
        }

        public BondDtlInfo(string isin)
        {
            ApiID = "getBondStatInfo";

            Params = isin;
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
