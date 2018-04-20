using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace kepler.helpers
{
	[AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
	public class CustomBindAttribute : Attribute
	{
		public CustomBindAttribute(string alias)
		{
			Alias = alias;
		}

		public string Alias { get; private set; }

		public override object TypeId
		{
			get { return Alias; }
		}

		internal sealed class CustomBindPropertyDescriptor : PropertyDescriptor
		{
			public PropertyDescriptor MainName { get; private set; }

			public CustomBindPropertyDescriptor(string alias, PropertyDescriptor inner)
				: base(alias, null)
			{
				MainName = inner;
			}

			public override bool CanResetValue(object component)
			{
				return MainName.CanResetValue(component);
			}

			public override Type ComponentType
			{
				get { return MainName.ComponentType; }
			}

			public override object GetValue(object component)
			{
				return MainName.GetValue(component);
			}

			public override bool IsReadOnly
			{
				get { return MainName.IsReadOnly; }
			}

			public override Type PropertyType
			{
				get { return MainName.PropertyType; }
			}

			public override void ResetValue(object component)
			{
				MainName.ResetValue(component);
			}

			public override void SetValue(object component, object value)
			{
				MainName.SetValue(component, value);
			}

			public override bool ShouldSerializeValue(object component)
			{
				return MainName.ShouldSerializeValue(component);
			}
		}
	}
}