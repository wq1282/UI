﻿Imports OpenTK.Graphics.OpenGL
Imports OpenTK

Public Class frmTest
    Private points As List(Of Vector2)

    Private Sub frmTest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        points = New List(Of Vector2)
        points.Add(New Vector2(0.5, 0.5))
        points.Add(New Vector2(-0.5, 0.5))
        points.Add(New Vector2(-0.5, -0.5))
        points.Add(New Vector2(0.5, -0.5))
    End Sub

    Private Sub Draw()
        GL.ClearColor(Color.SkyBlue)
        GL.Clear(ClearBufferMask.ColorBufferBit)
        GL.Begin(PrimitiveType.Lines)
        For i = 0 To points.Count - 2
            GL.Vertex2(points(i))
            GL.Vertex2(points(i + 1))
        Next
        GL.Vertex2(points(points.Count - 1))
        GL.Vertex2(points(0))
        GL.End()
        GL.Flush()
    End Sub

    Private Sub btnDraw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDraw1.Click, btnDraw2.Click
        If sender Is btnDraw1 Then
            glCtrl1.MakeCurrent()
        Else
            glCtrl2.MakeCurrent()
        End If
        Draw()
        If sender Is btnDraw1 Then
            glCtrl1.SwapBuffers()
        Else
            glCtrl2.SwapBuffers()
        End If
    End Sub

End Class
