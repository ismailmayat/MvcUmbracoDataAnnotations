using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MvcUmbracoDataAnnotations.DataAnnotations
{
    /// <summary>
    /// last post on http://stackoverflow.com/questions/4872309/asp-net-mvc-3-localization-with-displayattribute-and-custom-resource-provider
    /// suggested how to do custom display
    /// </summary>
    public class UmbracoDisplayLocalised: DisplayNameAttribute
    {
        private string DisplayNameKey { get; set; }   
        private string ResourceSetName { get; set; }   

        public UmbracoDisplayLocalised(string displayNameKey)
            : base(displayNameKey)
        {
            this.DisplayNameKey = displayNameKey;
        }


        public UmbracoDisplayLocalised(string displayNameKey, string resourceSetName)
            : base(displayNameKey)
        {
            this.DisplayNameKey = displayNameKey;
            this.ResourceSetName = resourceSetName;
        }

        public override string DisplayName
        {
            get
            {
              return Helper.GetDictionaryItem(this.DisplayNameKey);
            }
        }
    }
}
