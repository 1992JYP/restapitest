using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGIO_DOTNET.API.seibro.bond
{
    internal class BondDtlInfo : SeibroAPI
    {
        public BondDtlInfo() { }

        public BondDtlInfo(string date)
        {

        }

        public override RestClient Fn_RestClient()
        {
            throw new NotImplementedException();
        }
    }
}
