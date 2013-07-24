using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MvcUmbracoDataAnnotations.DataAnnotations
{
    public class UmbracoLocalisedRequired: RequiredAttribute, IClientValidatable
    {
        public UmbracoLocalisedRequired(string umbracoDictionaryKey)
        {
            this.ErrorMessage = Helper.GetDictionaryItem(umbracoDictionaryKey);
        }

        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            yield return new ModelClientValidationRule
            {
                ErrorMessage = this.ErrorMessage,
                ValidationType = "required"
            };
        }
    }
}
