﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3_0_Consloe_RINEX_TOOLS_1
{
    public class O_Data
    {
        List<string> Datas;
        public O_Data(string path)
        {
            this.Datas = Function.LoadingData.Loading_O_Data(path);

        }



    }
}
