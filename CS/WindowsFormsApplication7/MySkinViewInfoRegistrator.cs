using DevExpress.XtraTab;
using DevExpress.XtraTab.Drawing;
using DevExpress.XtraTab.Registrator;

namespace MyCustomXtraTabbedMdiManager
{
	public class MySkinViewInfoRegistrator : SkinViewInfoRegistrator
	{
		public MySkinViewInfoRegistrator()
		{
		}

		public override BaseTabPainter CreatePainter(IXtraTab tabControl)
		{
			return new MySkinTabPainter(tabControl);
		}
	}
}
