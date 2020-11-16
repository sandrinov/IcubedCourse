using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstWebApp.Data
{
    public class FactoryDataManager
    {
        private static IDataManager dm;

        public static IDataManager GetDataManager()
        {
            if (dm == null)
            {
                // if........

                dm = new SqlDataManager();
            }
            return dm;
        }
    }
}