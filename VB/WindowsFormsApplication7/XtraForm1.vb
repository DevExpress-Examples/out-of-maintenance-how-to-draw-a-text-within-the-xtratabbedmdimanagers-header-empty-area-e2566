Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors

Namespace WindowsFormsApplication7
	Partial Public Class XtraForm1
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim child As New XtraForm()
			child.Text = "ChildForm 1"
			child.MdiParent = Me
			child.Show()

			Dim child2 As New XtraForm()
			child2.Text = "ChildForm 2"
			child2.MdiParent = Me
			child2.Show()

			child.BringToFront()
		End Sub
	End Class
End Namespace