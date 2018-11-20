﻿Imports System.Windows.Media.Media3D
Imports System.Math
Class MainWindow

    Dim points As Point3DCollection
    Dim pindex As Int32Collection

    Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        points = New Point3DCollection()
        points.Add(New Point3D(0, 0, 0))
        points.Add(New Point3D(-1, 0, 0))
        points.Add(New Point3D(0, 1, 0))
        points.Add(New Point3D(1, 0, 0))
        pindex = New Int32Collection
        pindex.Add(2) : pindex.Add(1) : pindex.Add(0)
    End Sub

    Private Sub btn1_Click(sender As Object, e As RoutedEventArgs) Handles btn1.Click
        my3D.Positions = points
        my3D.TriangleIndices = pindex
    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs) Handles btn2.Click
        pindex.Add(3) : pindex.Add(2) : pindex.Add(0)
        my3D.Positions = points
        my3D.TriangleIndices = pindex
    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        Dim radius As Single = 10
        Static jd As Single = 30, wd As Single = 40
        wd += 5
        Dim p As Point3D
        p.X = radius * Cos(wd / 180 * PI) * Cos(jd / 180 * PI)
        p.Y = radius * Cos(wd / 180 * PI) * Sin(jd / 180 * PI)
        p.Z = radius * Sin(wd / 180 * PI)
        myCamera.Position = p
        p.X = -p.X : p.Y = -p.Y : p.Z = -p.Z
        myCamera.LookDirection = p
    End Sub
End Class
