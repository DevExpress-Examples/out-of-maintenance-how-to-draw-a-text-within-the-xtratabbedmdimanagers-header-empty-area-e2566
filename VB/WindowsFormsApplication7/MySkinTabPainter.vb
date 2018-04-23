Imports Microsoft.VisualBasic
Imports System.Drawing
Imports DevExpress.XtraTab
Imports DevExpress.XtraTab.Drawing

Namespace MyCustomXtraTabbedMdiManager
	Public Class MySkinTabPainter
		Inherits SkinTabPainter
		Public Sub New(ByVal tabControl As DevExpress.XtraTab.IXtraTab)
			MyBase.New(tabControl)
		End Sub

		Protected Overrides Sub DrawHeader(ByVal e As TabDrawArgs)
			MyBase.DrawHeader(e)
			If (CType(e.ViewInfo.Properties, MyXtraTabbedMdiManager)).HeaderLocation <> TabHeaderLocation.Top OrElse e.ViewInfo.IsMultiLine OrElse (Not e.ViewInfo.IsShowHeader) Then
				Return
			End If

			Dim textToDraw As String = "Sample text, sample text, sample text"
			Dim drawFont As Font = e.ViewInfo.PaintAppearance.GetFont()
			Dim drawBrush As Brush = e.ViewInfo.PaintAppearance.GetForeBrush(e.Cache)

			Dim emptySpaceBounds As Rectangle = e.Bounds
			If e.ViewInfo.HeaderInfo.AllPages.Count > 0 Then
				emptySpaceBounds.X = e.ViewInfo.HeaderInfo.AllPages.LastPage.Bounds.Right
			End If
			emptySpaceBounds.Width -= emptySpaceBounds.X + e.ViewInfo.HeaderInfo.ButtonsBounds.Width
			emptySpaceBounds.Height -= e.ViewInfo.PageBounds.Height
			emptySpaceBounds.Inflate(-1, -1)

			Dim format As New StringFormat(StringFormatFlags.NoWrap)
			format.Alignment = StringAlignment.Far
			format.LineAlignment = StringAlignment.Center
			format.Trimming = StringTrimming.EllipsisCharacter
			e.Cache.DrawString(textToDraw, drawFont, drawBrush, emptySpaceBounds, format)
		End Sub
	End Class
End Namespace
