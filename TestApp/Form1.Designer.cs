
namespace TestApp
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnShrink = new System.Windows.Forms.Button();
			this.btnGrow = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnShrink
			// 
			this.btnShrink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnShrink.Location = new System.Drawing.Point(12, 12);
			this.btnShrink.Name = "btnShrink";
			this.btnShrink.Size = new System.Drawing.Size(776, 51);
			this.btnShrink.TabIndex = 0;
			this.btnShrink.Text = "Shrink";
			this.btnShrink.UseVisualStyleBackColor = true;
			this.btnShrink.Click += new System.EventHandler(this.btnShrink_Click);
			// 
			// btnGrow
			// 
			this.btnGrow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGrow.Enabled = false;
			this.btnGrow.Location = new System.Drawing.Point(12, 69);
			this.btnGrow.Name = "btnGrow";
			this.btnGrow.Size = new System.Drawing.Size(776, 51);
			this.btnGrow.TabIndex = 1;
			this.btnGrow.Text = "Grow";
			this.btnGrow.UseVisualStyleBackColor = true;
			this.btnGrow.Click += new System.EventHandler(this.btnGrow_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 132);
			this.Controls.Add(this.btnGrow);
			this.Controls.Add(this.btnShrink);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnShrink;
		private System.Windows.Forms.Button btnGrow;
	}
}

