' Program Name: Burger Specials
' Developer:    Carlos Davalos
' Date:         June 21, 2022
' Purpose:      This application displays two burger meals (Prime Beef
'               and Veggie). The user can select a burger meal.
Public Class frmBurgerSpecials
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblConfirmation.Click

    End Sub

    Private Sub btnPrime_Click(sender As Object, e As EventArgs) Handles btnPrime.Click
        ' This code is executed when the user clicks the Prime Beef button. It displays the
        ' Prime beef picture, hides the veggie picture, and enables the select meal button.

        picPrimeBeef.Visible = True
        picVeggie.Visible = False
        btnSelect.Enabled = True

    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        ' This code is executed when the user clicks the Select Meal button. it disables the
        ' Prime beef button, the Select Meal button, and the Veggie button. It hides the
        ' Instructions label, displays the Confirmation label, and enables the Exit Window button.

        btnPrime.Enabled = False
        btnSelect.Enabled = False
        btnVeggie.Enabled = False
        lblInstructions.Visible = False
        lblConfirmation.Visible = True
        btnExit.Enabled = True

    End Sub

    Private Sub btnVeggie_Click(sender As Object, e As EventArgs) Handles btnVeggie.Click
        ' This code is executed when the user clicks the Veggie button. It displays the
        ' veggie picture, hides the prime beef picture, and enables the Select Meal button.

        picVeggie.Visible = True
        picPrimeBeef.Visible = False
        btnSelect.Enabled = True

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' This code is executed when the user clicks the Exit Window button.
        ' It closes the window and terminates the program execution.
        Close()

    End Sub
End Class
