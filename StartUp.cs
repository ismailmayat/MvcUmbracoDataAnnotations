using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;
using DataAnnotationsExtensions.ClientValidation;
using MvcUmbracoDataAnnotations.DataAnnotations;
using Umbraco.Core;

namespace MvcUmbracoDataAnnotations
{
    public class StartUp:IApplicationEventHandler
    {
        public void OnApplicationInitialized(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {
          
        }

        public void OnApplicationStarted(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {
            //http://stackoverflow.com/questions/16323591/define-regular-expression-validation-for-custom-datatype-in-mvc4 need this else js validator wont fire
            DataAnnotationsModelValidatorProvider.RegisterAdapter(typeof(UmbracoLocalisedRegularExpression), typeof(RegularExpressionAttributeAdapter));
            DataAnnotationsModelValidatorProviderExtensions.RegisterValidationExtensions();
        }

        public void OnApplicationStarting(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {
         
        }
    }
}
