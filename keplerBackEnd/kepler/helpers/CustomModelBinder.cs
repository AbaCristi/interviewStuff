using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;

namespace kepler.helpers
{
	public class CustomModelBinder : DefaultModelBinder
	{
		protected override System.ComponentModel.PropertyDescriptorCollection GetModelProperties(ControllerContext controllerContext, ModelBindingContext bindingContext)
		
			{
			var toReturn = base.GetModelProperties(controllerContext, bindingContext);

			var additional = new List<PropertyDescriptor>();

			foreach (var p in this.GetTypeDescriptor(controllerContext, bindingContext).GetProperties().Cast<PropertyDescriptor>())
			{
				foreach (var attr in p.Attributes.OfType<CustomBindAttribute>())
				{
					additional.Add(new CustomBindAttribute.CustomBindPropertyDescriptor(attr.Alias, p));

					if (bindingContext.PropertyMetadata.ContainsKey(p.Name))
						bindingContext.PropertyMetadata.Add(attr.Alias,
							  bindingContext.PropertyMetadata[p.Name]);
				}
			}

			return new PropertyDescriptorCollection
			  (toReturn.Cast<PropertyDescriptor>().Concat(additional).ToArray());
		}
	}
}