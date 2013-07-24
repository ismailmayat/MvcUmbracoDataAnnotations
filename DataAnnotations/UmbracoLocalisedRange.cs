using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Web.Mvc;

namespace MvcUmbracoDataAnnotations.DataAnnotations
{
    public class UmbracoLocalisedRange : RangeAttribute 
    {
        public UmbracoLocalisedRange(int minimum, int maximum, string umbracoDictionaryKey)
            : base(minimum, maximum)
        {
            this.ErrorMessage = Helper.GetDictionaryItem(umbracoDictionaryKey);
        }

        public UmbracoLocalisedRange(double minimum, double maximum, string umbracoDictionaryKey)
            : base(minimum, maximum)
        {
            this.ErrorMessage = Helper.GetDictionaryItem(umbracoDictionaryKey);
        }

        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            yield return new ModelClientValidationRule
            {
                ErrorMessage = this.ErrorMessage,
                ValidationType = "range"
            };
        }
    }
}
