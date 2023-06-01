using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGIO_DOTNET.DB
{
    internal interface IDBConn
    {
        void connect();
        void disconnect();
        void open();
        void close();
    }
}
