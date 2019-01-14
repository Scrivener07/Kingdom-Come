using System;
using System.ComponentModel;
using System.Diagnostics;

namespace Sharp.ComponentModel
{
	/// <summary>
	/// Classes which inherit ObjectComponent<T> act as components of the parameter type.
	/// </summary>
	/// <typeparam name="T">The type which is the owner.</typeparam>
	[DebuggerStepThrough]
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public abstract class ObjectComponent<T> where T : class
	{
		protected readonly T Owner;


		public ObjectComponent(T owner)
		{
			if (owner == null)
			{
				throw new ArgumentNullException("owner", string.Format("Cannot initialize '{0}' with null '{1}'.", GetType().Name, owner.GetType().Name));
			}
			else
			{
				Owner = owner;
			}
		}


	}
}
