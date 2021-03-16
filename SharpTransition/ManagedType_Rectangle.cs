using System;
using System.Drawing;

namespace SharpTransition
{
	internal class ManagedType_Rectangle : IManagedType
	{
		public Type getManagedType() => typeof(Rectangle);

		public object copy(object o)
		{
			Rectangle rect = (Rectangle)o;
			return rect;
		}

		public object getIntermediateValue(object start, object end, double percentage)
		{
			Rectangle startRect = (Rectangle)start;
			Rectangle endRect = (Rectangle)end;

			int startX = startRect.X;
			int startY = startRect.Y;
			int startWidth = startRect.Width;
			int startHeight = startRect.Height;

			int endX = endRect.X;
			int endY = endRect.Y;
			int endWidth = endRect.Width;
			int endHeight = endRect.Height;

			int newX = Utility.interpolate(startX, endX, percentage);
			int newY = Utility.interpolate(startY, endY, percentage);
			int newWidth = Utility.interpolate(startWidth, endWidth, percentage);
			int newHeight = Utility.interpolate(startHeight, endHeight, percentage);

			return new Rectangle(newX, newY, newWidth, newHeight);
		}
	}
}
