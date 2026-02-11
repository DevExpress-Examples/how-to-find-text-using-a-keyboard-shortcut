Imports System.Windows
Imports System.Windows.Input
Imports DevExpress.Xpf.DocumentViewer

Namespace FindText

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.viewer.OpenDocument("..\..\Demo.pdf")
        End Sub

        Private Sub viewer_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
            If e.Key = Key.F3 Then
                Dim parameters As TextSearchParameter = New TextSearchParameter With {.IsCaseSensitive = True, .WholeWord = True, .Text = "Viewer"}
                Me.viewer.FindText(parameters)
            End If
        End Sub
    End Class
End Namespace
