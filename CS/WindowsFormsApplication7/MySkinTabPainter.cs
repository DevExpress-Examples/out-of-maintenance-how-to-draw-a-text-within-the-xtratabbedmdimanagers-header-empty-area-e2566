using System.Drawing;
using DevExpress.XtraTab;
using DevExpress.XtraTab.Drawing;

namespace MyCustomXtraTabbedMdiManager
{
	public class MySkinTabPainter : SkinTabPainter
	{
		public MySkinTabPainter(DevExpress.XtraTab.IXtraTab tabControl)
			: base(tabControl)
		{
		}

		protected override void DrawHeader(TabDrawArgs e)
		{
			base.DrawHeader(e);
			if ( ((MyXtraTabbedMdiManager)e.ViewInfo.Properties).HeaderLocation != TabHeaderLocation.Top || e.ViewInfo.IsMultiLine || !e.ViewInfo.IsShowHeader )
				return;

			string textToDraw = "Sample text, sample text, sample text";
			Font drawFont = e.ViewInfo.PaintAppearance.GetFont();
			Brush drawBrush = e.ViewInfo.PaintAppearance.GetForeBrush(e.Cache);

			Rectangle emptySpaceBounds = e.Bounds;
			if ( e.ViewInfo.HeaderInfo.AllPages.Count > 0 )
				emptySpaceBounds.X = e.ViewInfo.HeaderInfo.AllPages.LastPage.Bounds.Right;
			emptySpaceBounds.Width -= emptySpaceBounds.X + e.ViewInfo.HeaderInfo.ButtonsBounds.Width;
			emptySpaceBounds.Height -= e.ViewInfo.PageBounds.Height;
			emptySpaceBounds.Inflate(-1, -1);

			StringFormat format = new StringFormat(StringFormatFlags.NoWrap);
			format.Alignment = StringAlignment.Far;
			format.LineAlignment = StringAlignment.Center;
			format.Trimming = StringTrimming.EllipsisCharacter;
			e.Cache.DrawString(textToDraw, drawFont, drawBrush, emptySpaceBounds, format);
		}
	}
}
