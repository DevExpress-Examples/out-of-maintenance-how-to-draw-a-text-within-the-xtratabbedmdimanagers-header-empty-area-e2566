Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraTab
Imports DevExpress.XtraTab.Drawing
Imports DevExpress.XtraTab.Registrator

Namespace MyCustomXtraTabbedMdiManager
	Public Class MySkinViewInfoRegistrator
		Inherits SkinViewInfoRegistrator
		Public Sub New()
		End Sub

		Public Overrides Function CreatePainter(ByVal tabControl As IXtraTab) As BaseTabPainter
			Return New MySkinTabPainter(tabControl)
		End Function
	End Class
End Namespace
