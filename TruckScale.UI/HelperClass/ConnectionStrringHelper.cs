﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckScale.UI.HelperClass
{
    public static class ConStringHelper
    {
        public static string Get(string dbname)
        {
            return ConfigurationManager.ConnectionStrings[dbname].ToString();
        }
    }
}
