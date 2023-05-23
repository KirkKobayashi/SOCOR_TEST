using System.Text.RegularExpressions;

namespace TruckScale.UI.HelperClass
{
    public static class Extensions
    {
        public static string ParseWeight(this string strWeight  )
        {
            var str =  Regex.Replace(strWeight, @"[^\d]", "");
            return str;
        }
    }
}
