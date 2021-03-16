using System;
using System.Drawing;

namespace SharpTransition
{
	internal class ManagedType_Point : IManagedType
	{
		public Type getManagedType() => typeof(Point);

		public object copy(object o)
		{
			Point pt = (Point)o;
			return pt;
		}

		public object getIntermediateValue(object start, object end, double percentage)
		{
			Point startPt = (Point)start;
			Point endPt = (Point)end;

			int startX = startPt.X;
			int startY = startPt.Y;

			int endX = endPt.X;
			int endY = endPt.Y;

			int newX = Utility.interpolate(startX, endX, percentage);
			int newY = Utility.interpolate(startY, endY, percentage);

			return new Point(newX, newY);
		}
	}
}
