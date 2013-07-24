using System;
using System.Collections.Generic;
using System.Text;

namespace MvcUmbracoDataAnnotations
{
    public static class Helper
    {
        public static string GetDictionaryItem(string key)
        {
            string errorMessage = umbraco.library.GetDictionaryItem(key);
            if (string.IsNullOrEmpty(errorMessage))
            {
                errorMessage = key + " is missing";
            }
            return errorMessage;
        }
    }
}
