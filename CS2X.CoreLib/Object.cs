using System.Runtime.CompilerServices;

namespace System
{
	public class Object
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Type GetType();

		public virtual string ToString()
		{
			return GetType().FullName;
		}
	}
}
