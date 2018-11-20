﻿Public Class clsButtonMatrix
    Private Const Width As Integer = 30
    Private Const dx As Integer = 10, dy As Integer = 10
    Private Buttons As List(Of Button)

    Sub New(ByVal Container As frmTest, ByVal Row As Integer, ByVal Col As Integer)
        Buttons = New List(Of Button)
        For k = 0 To Row * Col - 1
            Dim i As Integer = Fix(k / Col), j As Integer = k Mod Col
            Dim Button1 As New Button
            Button1.Name = "Button " & i & " " & j
            Button1.Size = New System.Drawing.Size(30, 30)
            Button1.Location = New System.Drawing.Point(dy + j * (dy + Width), dx + i * (dx + Width))
            AddHandler Button1.Click, AddressOf Buttons_Click
            Buttons.Add(Button1)
        Next
        AppendContainer(Container)
    End Sub

    Private Sub AppendContainer(ByVal Container As frmTest)
        For i = 0 To Buttons.Count - 1
            Container.Controls.Add(Buttons(i))
        Next
    End Sub

    Private Sub Buttons_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim words() As String = sender.Name.ToString.Split(" ")
        Dim i As Integer = words(1), j As Integer = words(2)
        MsgBox(i & " " & j)
    End Sub


End Class
