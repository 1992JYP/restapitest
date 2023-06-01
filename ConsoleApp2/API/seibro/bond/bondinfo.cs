using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGIO_DOTNET.API.seibro.bond
{
    internal class Bondinfo : SeibroAPI
    {
        public string Tetstest;
        public Bondinfo()
        {
            ApiID = "getBondOptionXrcInfo";

            Params = null;

            Tetstest = "154771131354564";
        }
    }
}
