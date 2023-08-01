' Program Name: Latte Selection
' Developer:    Carlos Davalos
' Date:         June 21, 2022
' Purpose:      This application displays two latte flavors (pumpkin spice
'               and mocha). The user can select a latte flavor.

Public Class frmLatteSelection
    Private Sub BtnPumpkin_Click(sender As Object, e As EventArgs) Handles BtnPumpkin.Click
        ' This code is executed when the user clicks the Pumpkin Spice Button.
        ' It displays the pumpkin picture, hides the mocha picture, and enables the Select Latte Button.

        picPumpkin.Visible = True
        picMocha.Visible = False
        BtnSelect.Enabled = True ' Enable button

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' This code is executed when the user click the Exit Window Button.
        ' It closes the window and terminates the program execution.

        Close()

    End Sub

    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click
        ' This code is executed when the user clciks the Select button. It disables the
        ' pumpkin spice button, the select button, and the Mocha button. It hides the
        ' Instructions Label, displays the Confirmation Label, and enables the Exit Window button.


        BtnPumpkin.Enabled = False
        BtnSelect.Enabled = False
        btnMocha.Enabled = False
        lblInstructions.Visible = False
        lblConfirmation.Visible = True
        btnExit.Enabled = True

    End Sub

    Private Sub btnMocha_Click(sender As Object, e As EventArgs) Handles btnMocha.Click
        ' This code is executed when the user clicks the Mocha button.
        ' It displays the mocha pictures, hides the pumpkin picture, and enables the select button.

        picMocha.Visible = True
        picPumpkin.Visible = False
        BtnSelect.Enabled = True

    End Sub
End Class
