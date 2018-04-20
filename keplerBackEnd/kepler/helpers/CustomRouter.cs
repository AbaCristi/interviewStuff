using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace kepler.helpers
{
	public class CustomRouter : RouteBase
	{
		public override RouteData GetRouteData(HttpContextBase httpContext)
		{
			RouteData result = null;
		 
			string requestUrl = httpContext.Request.AppRelativeCurrentExecutionFilePath;
			string[] sections = requestUrl.Split('/');

			if (sections.Count() > 4 && sections[1].ToLower()=="ex4" && sections[2].ToLower()=="products" && sections[3].ToLower()=="search")
				
			{
				var searchString = "";
				
					result = new RouteData(this, new MvcRouteHandler());
					result.Values.Add("controller", "Products");
					result.Values.Add("action", "Search");
				
				for (int i = 4; i < sections.Length; i=i+2)
				{
					searchString = searchString + sections[i] + "=" + sections[i + 1] + "|";

				}
				result.Values.Add("search", searchString);
				
			}
			else
			{
				//I can prepare a default route        
				result = new RouteData(this, new MvcRouteHandler());
				result.Values.Add("controller", "Ex4");
				result.Values.Add("action", "Index");
			}
			return result;
		
		}
		public override VirtualPathData GetVirtualPath(RequestContext requestContext, RouteValueDictionary values)
		{			
			return null;
		}
	}
}