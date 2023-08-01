' Program Name: Karaoke Music Night
' Author:       Carlos Davalos
' Date:         July 13, 2022
' Purpose:      The Karaoke Music Night app computes either the customized evening cost of an open
'               microphone costing $2.99 per song or renting a private karaoke room for $8.99 an hour.

Option Strict On

Public Class frmKaraoke
    Private _decSinging As Decimal = 2.99D
    Private _decPrivate As Decimal = 8.99D
    Private Sub cboRental_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRental.SelectedIndexChanged
        'This event handler allows the user to enter the Rental Choice and then call subprocedures to place on the panel.
        Dim intRentalChoice As Integer

        intRentalChoice = cboRental.SelectedIndex
        Select Case intRentalChoice
            Case 0
                SingingKaraoke()
            Case 1
                PrivateKaraoke()
        End Select
        ' Make items visible in the window
        lblHourly.Visible = True
        txtAmount.Visible = True
        BtnTotalCost.Visible = True
        btnClear.Visible = True
        lblTotalCost.Visible = True
        'Clear the label
        lblTotalCost.Text = ""
        ' Set focus on number in text box
        txtAmount.Focus()
    End Sub

    Private Sub BtnTotalCost_Click(sender As Object, e As EventArgs) Handles BtnTotalCost.Click
        ' This button event handler determines the cost of Karaoke rental and
        ' displays the amount, and the cost of the rental.
        Dim decHourRent As Decimal
        Dim blnNumberAmountisValid As Boolean = False
        Dim intRentalChoice As Integer
        Dim decTotalCost As Decimal

        blnNumberAmountisValid = ValidateNumberAmount()

        If (blnNumberAmountisValid) Then
            decHourRent = Convert.ToDecimal(txtAmount.Text)
            intRentalChoice = cboRental.SelectedIndex
            Select Case intRentalChoice
                Case 0
                    decTotalCost = decHourRent * _decSinging
                Case 1
                    decTotalCost = decHourRent * _decPrivate
            End Select
            ' Display the cost of karaoke Music Night
            lblTotalCost.Text = "Total Cost of Karaoke Night: " & decTotalCost.ToString("C")
        End If
    End Sub
    Private Function ValidateNumberAmount() As Boolean
        ' This function validates the value entered for a karaoke song/ hourly rental
        Dim decHourRent As Decimal
        Dim blnValidityCheck As Boolean = False
        Dim strNumberAmountMessage As String = "Enter a Positive Number"
        Dim strMessageBoxHeading As String = "Error"

        Try
            decHourRent = Convert.ToDecimal(txtAmount.Text)
            If decHourRent >= 1 Then
                blnValidityCheck = True
            Else
                MsgBox(strNumberAmountMessage, , strMessageBoxHeading)
                txtAmount.Focus()
                txtAmount.Clear()
            End If
        Catch Exception As FormatException
            MsgBox(strNumberAmountMessage, , strMessageBoxHeading)
            txtAmount.Focus()
            txtAmount.Clear()
        Catch Exception As OverflowException
            MsgBox(strNumberAmountMessage, , strMessageBoxHeading)
            txtAmount.Focus()
            txtAmount.Clear()
        Catch Exception As SystemException
            MsgBox(strNumberAmountMessage, , strMessageBoxHeading)
            txtAmount.Focus()
            txtAmount.Clear()
        End Try
        Return blnValidityCheck
    End Function
    Private Sub SingingKaraoke()

        lblPerSong.Visible = True
        lblHourly.Visible = False

    End Sub
    Private Sub PrivateKaraoke()

        lblPerSong.Visible = False
        lblHourly.Visible = True

    End Sub
    Private Sub frmKaraoke_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Hold the splash screen for 3 seconds
        Threading.Thread.Sleep(3000)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' This event handler clears the form and resets the form for reuse when the user clicks the Clear button.
        cboRental.Text = "Select Rental"
        txtAmount.Clear()
        lblHourly.Text = ""
        lblTotalCost.Text = ""
        lblHourly.Visible = False
        lblPerSong.Visible = False
        txtAmount.Visible = False
        BtnTotalCost.Visible = False
        btnClear.Visible = False
    End Sub
End Class
