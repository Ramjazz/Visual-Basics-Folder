'Arjun Hariharan, Period 6, addMoney
Public Class Form1

    Private Sub addCoins(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        Dim quarters, dimes, nickels, pennies As Single
        quarters = Val(Me.txtQuarters.Text)
        dimes = Val(Me.txtDimes.Text)
        nickels = Val(Me.txtNickels.Text)
        pennies = Val(Me.txtPennies.Text)

        Me.lblResponse.Text = FormatCurrency(calculateMoney(quarters, dimes, nickels, pennies))

    End Sub

    Private Function calculateMoney(ByVal q As Single, ByVal d As Single, ByVal n As Single, ByVal p As Single) As Single
        q *= 0.25
        d *= 0.1
        n *= 0.05
        p *= 0.01

        Return q + d + n + p
    End Function

    Private Sub changeText(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDimes.TextChanged, txtNickels.TextChanged, txtPennies.TextChanged, txtQuarters.TextChanged
        Me.lblResponse.Text = ""
    End Sub
End Class
