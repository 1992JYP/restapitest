using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;

namespace EGIO_DOTNET.DB
{
    public class DatabaseConfig
    {
            public string Host { get; set; } = "";
            public int Port { get; set; } = 0;
            public string Username { get; set; } = "";
            public string Password { get; set; } = "";
            public string Database { get; set; } = "";
    }
}
