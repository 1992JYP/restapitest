﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGIO_DOTNET.API.seibro.bond
{
    internal class bondinfo
    {
        int EE;
        public bondinfo()
        {
            EE = 3;
        }

        public int getEnum()
        {
            return EE;
        }
    }
}