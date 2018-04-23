Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports DXWebApplication1.Models
Imports System.Web.Services
Imports System.Threading

Namespace DXWebApplication1.Controllers
    Public Class HomeController
        Inherits Controller

        Private _Products As IEnumerable(Of Product)
        Public ReadOnly Property Products() As IEnumerable(Of Product)
            Get
                If _Products Is Nothing Then
                    _Products = GetData()
                End If
                Return _Products
            End Get
        End Property
        Public Function Index() As ActionResult
            Return View()
        End Function

        Public Function GetFilteredData(ByVal str As String, ByVal seltokens As String) As JsonResult

            Dim selectedTokens As New List(Of Integer)()
            Dim dummyInt As Integer = Nothing
            If Not String.IsNullOrEmpty(seltokens) Then
                selectedTokens = seltokens.Split(","c).Where(Function(ff) Int32.TryParse(ff, dummyInt)).Select(Function(ff) Int32.Parse(ff)).ToList()
            End If
            If Not String.IsNullOrEmpty(str) Then
				Return Json(Products.Where(Function(p) (Not selectedTokens.Contains(p.ProductID)) AndAlso p.ProductName.ToLower().Contains(str.ToLower())).Take(10).ToArray(), JsonRequestBehavior.AllowGet)
			Else
                Return Nothing
            End If
        End Function

        Private Function GetData() As IEnumerable(Of Product)
            Dim returnList = New List(Of Product) From { _
                New Product(10010, "Toys"), _
                New Product(10020, "Books"), _
                New Product(10030, "Cars"), _
                New Product(10040, "Cars2"), _
                New Product(10050, "Cars3"), _
                New Product(10060, "Trucks"), _
                New Product(10070, "Bikes"), _
                New Product(20000, "Pets"), _
                New Product(20002, "Dogs"), _
                New Product(20004, "Cats"), _
                New Product(20006, "Fish") _
            }
            For i As Integer = 0 To 9999
                returnList.Add(New Product(i, "John Doe" & i))
                i += 1
                returnList.Add(New Product(i, "Jane Doe" & i))
                i += 1
                returnList.Add(New Product(i, "Michael Doe" & i))
                i += 1
                returnList.Add(New Product(i, "Lana Doe" & i))
            Next i
            Return returnList
        End Function
    End Class
End Namespace