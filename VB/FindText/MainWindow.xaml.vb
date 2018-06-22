Imports System.Windows
Imports System.Windows.Input
Imports DevExpress.Xpf.DocumentViewer

Namespace FindText
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
            viewer.OpenDocument("..\..\Demo.pdf")
        End Sub

        Private Sub viewer_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
            If e.Key = Key.F3 Then
                Dim parameters As TextSearchParameter = New TextSearchParameter With { _
                    .IsCaseSensitive = True, _
                    .WholeWord = True, _
                    .Text = "Viewer" _
                }
                viewer.FindText(parameters)
            End If
        End Sub
    End Class
End Namespace
