using kepler.helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace kepler.Models
{
	[ModelBinder(typeof(CustomModelBinder))]
	public class Input
	{[CustomBind("val")]
		public int Value { set; get; }

		public string Name {set;get;}
	}
}