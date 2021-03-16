using System;
using System.Drawing;

namespace SharpTransition
{
	internal class ManagedType_Size : IManagedType
	{
		public Type getManagedType() => typeof(Size);

		public object copy(object o)
		{
			Size sz = (Size)o;
			return sz;
		}

		public object getIntermediateValue(object start, object end, double percentage)
		{
			Size startSz = (Size)start;
			Size endSz = (Size)end;

			int startWidth = startSz.Width;
			int startHeight = startSz.Height;

			int endWidth = endSz.Width;
			int endHeight = endSz.Height;

			int newWidth = Utility.interpolate(startWidth, endWidth, percentage);
			int newHeight = Utility.interpolate(startHeight, endHeight, percentage);

			return new Size(newWidth, newHeight);
		}
	}
}
