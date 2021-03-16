using System;
using System.Drawing;

namespace SharpTransition
{
	internal class ManagedType_SizeF : IManagedType
	{
		public Type getManagedType() => typeof(SizeF);

		public object copy(object o)
		{
			SizeF szF = (SizeF)o;
			return szF;
		}

		public object getIntermediateValue(object start, object end, double percentage)
		{
			SizeF startSZF = (SizeF)start;
			SizeF endSZF = (SizeF)end;

			float startWidthF = startSZF.Width;
			float startHeightF = startSZF.Height;

			float endWidthF = endSZF.Width;
			float endHeightF = endSZF.Height;

			float newWidthF = Utility.interpolate(startWidthF, endWidthF, percentage);
			float newHeightF = Utility.interpolate(startHeightF, endHeightF, percentage);

			return new SizeF(newWidthF, newHeightF);
		}
	}
}
