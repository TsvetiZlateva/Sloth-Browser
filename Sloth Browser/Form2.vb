﻿Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Settings.SE = "Google" Then
            RadioButton1.Checked = True
        ElseIf My.Settings.SE = "Bing" Then
            RadioButton2.Checked = True
        ElseIf My.Settings.SE = "Yahoo" Then
            RadioButton3.Checked = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            My.Settings.SE = "Google"

            My.Settings.Save()
            My.Settings.Reload()

            Me.Close()

        ElseIf RadioButton2.Checked = True Then
            My.Settings.SE = "Bing"

            My.Settings.Save()
            My.Settings.Reload()

            Me.Close()

        ElseIf RadioButton3.Checked = True Then
            My.Settings.SE = "Yahoo"

            My.Settings.Save()
            My.Settings.Reload()

            Me.Close()
        End If
    End Sub
End Class