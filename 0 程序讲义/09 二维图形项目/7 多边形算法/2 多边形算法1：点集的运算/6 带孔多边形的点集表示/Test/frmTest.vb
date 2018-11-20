﻿Public Class frmTest
    Dim polygon As clsPolygon
    Dim Points As clsPoints

    Private Sub btnCreate_Click(sender As System.Object, e As System.EventArgs) Handles btnCreate.Click
        polygon = New clsPolygon()
        Points = New clsPoints(polygon)
        Dim g As Graphics = picCanvas.CreateGraphics()
        polygon.Draw(g)
        Points.Draw(g)
        g.Flush()
    End Sub

    Private Sub picCanvas_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseDown
        Dim p As PointF = e.Location
        If polygon.Inside(p) Then
            Text = "Inside"
        Else
            Text = "Outside"
        End If
    End Sub

End Class
