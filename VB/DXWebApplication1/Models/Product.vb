Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace DXWebApplication1.Models
    Public Class Product
        Public Property ProductID() As Integer
        Public Property ProductName() As String
        Public Sub New(ByVal id As Integer, ByVal name As String)
            ProductID = id
            ProductName = name
        End Sub
    End Class
End Namespace
