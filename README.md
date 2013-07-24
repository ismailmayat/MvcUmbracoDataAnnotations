MvcUmbracoDataAnnotations
=========================

Umbraco mvc annotations for localised attributes in umbraco mvc via the umbraco dictionary.

In mvc you can do things like

[Display("Email Address")]
[Required]
public string EmailAddress {get; set;}

With these attributes you pass in some text or you can use a .net resource. In that case you give it assembly and key

[Required(ErrorMessage="Name required.", ErrorMessageResourceType=typeof(CustomDataAnnotationsResources)]

So I have extended the Core MVC attributes namely Display,Range,RegularExpression and Required.  What I have also done is fork the DataAnnotations (http://dataannotationsextensions.org
)

So they they also can make use of the Umbraco dictionary my fork of that is here https://github.com/ismailmayat/DataAnnotationsExtensions

Usage
=====
Add references to 
DataAnnotationsExtensions.ClientValidation
DataAnnotationsExtensions
MvcUmbracoDataAnnotations

Then in your model you can do things like

[UmbracoDisplayLocalised("Email")] //display label in view using umbraco dictionary key
[Email("InvalidEmail")] //use email validator found in DataAnnotationsExtensions and use umbraco dictioanry key for invalid text
[UmbracoLocalisedRequired("InvalidEmail")] //use umbraco dictionary for error message for required field
public string EmailAddress {get; set;}