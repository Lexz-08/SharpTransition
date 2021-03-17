using SharpTransition;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TestApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			Focus();
		}

		private static int transitionTime = 1000;
		private ITransitionType linear = new TransitionType_Linear(transitionTime);

		private void Animate()
		{
			Point originalLocation = Location;

			Transition shrink = new Transition(linear);
			shrink.add(this, "Size", new Size(250, Height));

			shrink.TransitionCompletedEvent += (sender, e) =>
			{
				btnShrink.Enabled = false;
				btnGrow.Enabled = true;
			};

			shrink.run();
		}
		private void Reset()
		{
			Point originalLocation = Location;

			Transition grow = new Transition(linear);
			grow.add(this, "Size", new Size(816, Height));

			grow.TransitionCompletedEvent += (sender, e) =>
			{
				btnShrink.Enabled = true;
				btnGrow.Enabled = false;
			};

			grow.run();
		}

		private void btnShrink_Click(object sender, EventArgs e) => Animate();
		private void btnGrow_Click(object sender, EventArgs e) => Reset();
	}
}
