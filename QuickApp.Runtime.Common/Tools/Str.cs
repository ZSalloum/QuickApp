using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickApp.Runtime.Common.Tools
{
    public static class Str
    {
        public static String NoNull(String str)
        {
            if (str == null)
            {
                return String.Empty;
            }

            return str;
        }
    }
}
