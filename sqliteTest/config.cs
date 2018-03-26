using System;
using System.Collections.Generic;
using System.Text;

namespace sqliteTest
{
    class config
    {
        public static string DatabaseFile = "";
        public static string DataSource
        {
            get
            {
                return string.Format("data source={0}", DatabaseFile);
            }
        }
    }
}
