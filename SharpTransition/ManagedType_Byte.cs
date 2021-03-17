using System;

namespace SharpTransition
{
	internal class ManagedType_Byte : IManagedType
	{
		public Type getManagedType() => typeof(byte);

		public object copy(object o)
		{
			byte b = (byte)o;
			return b;
		}

		public object getIntermediateValue(object start, object end, double percentage)
		{
			byte startB = (byte)start;
			byte endB = (byte)end;
			return Utility.interpolate(startB, endB, percentage);
		}
	}
}
