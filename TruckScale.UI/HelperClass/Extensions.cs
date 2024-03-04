using System.Text.RegularExpressions;
using TruckScale.Library.Data.Models;

namespace TruckScale.UI.HelperClass
{
    public static class Extensions
    {
        public static string ParseWeight(this string strWeight)
        {
            var str =  Regex.Replace(strWeight, @"[^\d]", "");
            return str;
        }

        public static void SetTextBoxSource<T>(List<T> list, TextBox textBox) where T : ModelBase
        {
            if (list != null)
            {
                var autosource = new AutoCompleteStringCollection();
                foreach (var model in list)
                {
                    autosource.Add(model.Name);
                }

                textBox.AutoCompleteCustomSource = autosource;
                textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            }
        }
    }
}
