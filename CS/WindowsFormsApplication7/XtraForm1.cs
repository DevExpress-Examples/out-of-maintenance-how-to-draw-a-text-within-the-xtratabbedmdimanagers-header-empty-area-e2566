using System;
using DevExpress.XtraEditors;

namespace WindowsFormsApplication7
{
	public partial class XtraForm1 : XtraForm
	{
		public XtraForm1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			XtraForm child = new XtraForm();
			child.Text = "ChildForm 1";
			child.MdiParent = this;
			child.Show();

			XtraForm child2 = new XtraForm();
			child2.Text = "ChildForm 2";
			child2.MdiParent = this;
			child2.Show();

			child.BringToFront();
		}
	}
}