Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraTab.Registrator
Imports DevExpress.XtraTabbedMdi

Namespace MyCustomXtraTabbedMdiManager
	Public Class MyXtraTabbedMdiManager
		Inherits XtraTabbedMdiManager
		Public Sub New(ByVal container As System.ComponentModel.IContainer)
			MyBase.New(container)
		End Sub
		Public Sub New()
		End Sub

		Protected Overrides Function GetView() As BaseViewInfoRegistrator
			Dim view As BaseViewInfoRegistrator = MyBase.GetView()
			If TypeOf view Is SkinViewInfoRegistrator Then
				view = New MySkinViewInfoRegistrator()
			End If

			Return view
		End Function
	End Class
End Namespace
