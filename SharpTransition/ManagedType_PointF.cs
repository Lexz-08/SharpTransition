using System;
using System.Drawing;

namespace SharpTransition
{
	internal class ManagedType_PointF : IManagedType
	{
		public Type getManagedType() => typeof(PointF);

		public object copy(object o)
		{
			PointF ptF = (PointF)o;
			return ptF;
		}

		public object getIntermediateValue(object start, object end, double percentage)
		{
			PointF startPTF = (PointF)start;
			PointF endPTF = (PointF)end;

			float startXF = startPTF.X;
			float startYF = startPTF.Y;

			float endXF = endPTF.X;
			float endYF = endPTF.Y;

			float newXF = Utility.interpolate(startXF, endXF, percentage);
			float newYF = Utility.interpolate(startYF, endYF, percentage);

			return new PointF(newXF, newYF);
		}
	}
}
