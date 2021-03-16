using System;
using System.Drawing;

namespace SharpTransition
{
	internal class ManagedType_RectangleF : IManagedType
	{
		public Type getManagedType() => typeof(RectangleF);

		public object copy(object o)
		{
			RectangleF rectF = (RectangleF)o;
			return rectF;
		}

		public object getIntermediateValue(object start, object end, double percentage)
		{
			RectangleF startRectF = (RectangleF)start;
			RectangleF endRectF = (RectangleF)end;

			float startXF = startRectF.X;
			float startYF = startRectF.Y;
			float startWidthF = startRectF.Width;
			float startHeightF = startRectF.Height;

			float endXF = endRectF.X;
			float endYF = endRectF.Y;
			float endWidthF = endRectF.Width;
			float endHeightF = endRectF.Height;

			float newXF = Utility.interpolate(startXF, endXF, percentage);
			float newYF = Utility.interpolate(startYF, endYF, percentage);
			float newWidthF = Utility.interpolate(startWidthF, endWidthF, percentage);
			float newHeightF = Utility.interpolate(startHeightF, endHeightF, percentage);

			return new RectangleF(newXF, newYF, newWidthF, newHeightF);
		}
	}
}
