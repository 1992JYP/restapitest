using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGIO_DOTNET.extract.API.seibro
{
    internal abstract class SeibroAPI : IAPIRequest
    {
        public string? BaseUrl { get; set; }
        public string? ApiID { get; set; }
        public string? ApiKey { get; set; }
        public string? Params { get; set; }

        private string baseURLKEY = "{0}?key={1}";
        public SeibroAPI()
        {
            BaseUrl = "http://seibro.or.kr/OpenPlatform/callOpenAPI.jsp";
            ApiKey = Environment.GetEnvironmentVariable("SEIBRO", EnvironmentVariableTarget.Machine);
            //ApiID = "getBondOptionXrcInfo";
        }
        public string Fn_SettingUrl()
        {
            return string.Format(baseURLKEY, BaseUrl, ApiKey);
        }
        public abstract RestClient Fn_RestClient();
    }
}

