﻿Public MustInherit Class clsElem
    Protected CommonPen, SelectedPen As Pen

    Public MustOverride Sub Draw(g As Graphics, Optional isSelectElem As Boolean = False)
    Public MustOverride Function SelectByPoint(p As PointF) As Boolean

    Public Sub New()
        CommonPen = New Pen(Color.Blue, 1)
        SelectedPen = New Pen(Color.Red, 1)
    End Sub
End Class

Public Class clsElems
    Public Elems As List(Of clsElem)           ' 图形对象的集合
    Public Selection As clsSelection          ' 当前选集对象

    Event Redraw()
    ' 选集发生了变化（或增加或减少，或一个或多个图形对象）
    Event SelectionChanged()

    Public Sub New()
        elems = New List(Of clsElem)
        Selection = New clsSelection
    End Sub
    Public Sub Append(e As clsElem)
        elems.Add(e)
        RaiseEvent Redraw()
    End Sub

    Public Sub Draw(ByVal g As Graphics)
        For i = 0 To elems.Count - 1
            If Selection.Contains(Elems(i)) Then
                Elems(i).Draw(g, True)
            Else
                Elems(i).Draw(g)
            End If
        Next
    End Sub

    Public Function Count() As Integer
        Return elems.Count
    End Function
    Public Function Item(index As Integer) As clsElem
        Return elems(index)
    End Function

    ' 在点选过程中，改变了选集，并激发“选集改变”事件
    Public Sub SelectByPoint(p As PointF)
        Dim Change As Boolean = False
        For i = 0 To Elems.Count - 1
            If Elems(i).SelectByPoint(p) = True Then
                Selection.DoSelect(Elems(i)) : change = True
            End If
        Next
        If Change = True Then
            RaiseEvent SelectionChanged()
        End If
    End Sub
End Class
