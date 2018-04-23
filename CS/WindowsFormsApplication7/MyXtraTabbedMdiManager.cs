using DevExpress.XtraTab.Registrator;
using DevExpress.XtraTabbedMdi;

namespace MyCustomXtraTabbedMdiManager
{
	public class MyXtraTabbedMdiManager : XtraTabbedMdiManager
	{
		public MyXtraTabbedMdiManager(System.ComponentModel.IContainer container)
			: base(container)
		{
		}
		public MyXtraTabbedMdiManager()
		{
		}

		protected override BaseViewInfoRegistrator GetView()
		{
			BaseViewInfoRegistrator view = base.GetView();
			if ( view is SkinViewInfoRegistrator )
				view = new MySkinViewInfoRegistrator();

			return view;
		}
	}
}
