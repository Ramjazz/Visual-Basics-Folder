﻿'Arjun Hariharan, Period 6, diceGame
Public Class Form1
    Private total As Integer = 1000
    Private Sub formLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()
        Dim risk As Integer = Val(Me.txtEnter.Text)
    End Sub

    Private Sub enterTheDungeon(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        Dim risk As Integer = Val(Me.txtEnter.Text)
        Dim diceTotal As Integer
        Dim dice1, dice2 As Integer
        dice1 = Int(6 * Rnd() + 1)
        dice2 = Int(6 * Rnd() + 1)
        Call checkRisk(risk, diceTotal, dice1, dice2)
    End Sub

    Private Sub checking(ByVal dice1 As Integer, ByVal dice2 As Integer, ByRef diceTotal As Integer, ByRef risk As Integer)
        diceTotal = dice1 + dice2
        If diceTotal Mod 2 = 0 Then
            total -= risk
            Me.lblResponse.Text = "Your new total is " & total
        Else
            risk *= 2
            total += risk
            Me.lblResponse.Text = "Your new total is " & total
        End If
    End Sub
    Private Sub checkingImage(ByRef dice1 As Integer, ByRef dice2 As Integer)
        If dice1 = 1 Then
            Me.picPIC1.Image = My.Resources.die1
        ElseIf dice1 = 2 Then
            Me.picPIC1.Image = My.Resources.die2
        ElseIf dice1 = 3 Then
            Me.picPIC1.Image = My.Resources.die3
        ElseIf dice1 = 4 Then
            Me.picPIC1.Image = My.Resources.die4
        ElseIf dice1 = 5 Then
            Me.picPIC1.Image = My.Resources.die5
        ElseIf dice1 = 6 Then
            Me.picPIC1.Image = My.Resources.die6
        End If

        If dice2 = 1 Then
            Me.picPIC2.Image = My.Resources.die1
        ElseIf dice2 = 2 Then
            Me.picPIC2.Image = My.Resources.die2
        ElseIf dice2 = 3 Then
            Me.picPIC2.Image = My.Resources.die3
        ElseIf dice2 = 4 Then
            Me.picPIC2.Image = My.Resources.die4
        ElseIf dice2 = 5 Then
            Me.picPIC2.Image = My.Resources.die5
        ElseIf dice2 = 6 Then
            Me.picPIC2.Image = My.Resources.die6
        End If
    End Sub

    Private Sub changeText(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEnter.TextChanged
        Me.lblResponse.Text = ""
        Me.picPIC1.Image = Nothing
        Me.picPIC2.Image = Nothing
    End Sub
    Private Sub checkRisk(ByVal risk As Integer, ByRef diceTotal As Integer, ByVal dice1 As Integer, ByVal dice2 As Integer)
        If risk > total Or risk < 0 Then
            MessageBox.Show("Enter a risk less than the amount you have", "ERROR 404")
            Me.lblResponse.Text = "Your total is " & total
        Else
            Call checkingImage(dice1, dice2)
            Call checking(dice1, dice2, diceTotal, risk)
        End If
    End Sub
End Class
