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
			Animate(this, null);
		}

		private static int transitionTime = 25000;
		private ITransitionType linear = new TransitionType_Linear(transitionTime);
		private ITransitionType linearHalf = new TransitionType_Linear(transitionTime / 2);

		private void Animate(object sender, EventArgs e)
		{
			Transition t1 = new Transition(linear);
			Transition t2 = new Transition(linear);
			Transition t3 = new Transition(linear);
			Transition t4 = new Transition(linear);
			Transition t5 = new Transition(linear);
			Transition t6 = new Transition(linear);
			Transition t7 = new Transition(linear);
			Transition t8 = new Transition(linear);
			Transition t9 = new Transition(linear);
			Transition t10 = new Transition(linear);

			t1.add(this, "BackColor", Color.Red);
			t2.add(this, "BackColor", Color.Blue);
			t3.add(this, "BackColor", Color.Green);
			t4.add(this, "BackColor", Color.Black);
			t5.add(this, "BackColor", Color.White);
			t6.add(this, "BackColor", Color.Aqua);
			t7.add(this, "BackColor", Color.Fuchsia);
			t8.add(this, "BackColor", Color.Coral);
			t9.add(this, "BackColor", Color.Purple);
			t10.add(this, "BackColor", Color.Red);

			Transition.runChain(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);

			Transition t = new Transition(linearHalf);
			t.add(this, "Size", new Size(250, 250));
			t.TransitionCompletedEvent += (sender_, e_) =>
			{
				Transition.run(this, "Location", new Point(960 - (Width / 2), 540 - (Height / 2)), new TransitionType_Linear(transitionTime / 2));
			};
			t.run();
		}
	}
}
