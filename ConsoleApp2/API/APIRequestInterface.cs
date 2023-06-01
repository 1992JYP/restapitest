using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGIO_DOTNET.API
{
    internal interface APIRequestinterface
    {
        string baseUrl { get; }
        string apiID { get; }
        string apiKey { get; }
        string fn_SettingUrl();        
    }
}
