using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Web.Mvc;

namespace MvcUmbracoDataAnnotations.DataAnnotations
{
    public class UmbracoLocalisedRegularExpression:RegularExpressionAttribute, IClientValidatable
    {
        public UmbracoLocalisedRegularExpression(string pattern,string umbracoDictionaryKey) : base(pattern)
        {
            this.ErrorMessage = Helper.GetDictionaryItem(umbracoDictionaryKey);
        }

        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            yield return new ModelClientValidationRule
            {
                ErrorMessage = this.ErrorMessage,
                ValidationType = "regularexpression"
            };
        }
    }
}
