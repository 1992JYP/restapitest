using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGIO_DOTNET.extract.API
{
    internal interface IAPIRequest
    {
        string? BaseUrl { get; }
        string? ApiID { get; }
        string? ApiKey { get; }
        string? Params { get; }
        string? Fn_SettingUrl();
    }
}
