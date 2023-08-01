' Program:  Driverless Uber Car
' Author:   Carlos Davalos
' Date:     June 25th, 2022
' Purpose:  This application calculates and displays the total cost of an uber ride
' '         for a certain number of miles plus a flat fee.

Option Strict On

Public Class frmDriverlessUberCar

    ' Cost per mile = use in multiple procedures
    Const _cdecPricePerMile As Decimal = 1.8D
    Const _cdecFlatRate As Decimal = 2.8D 'Flat Rate fee

    Private Sub btnCost_Click(sender As Object, e As EventArgs) Handles btnCost.Click
        ' This event handler is executed when the user clicks the
        ' Display Fare button. It calculates and displays the cost of a
        ' Uber Ride (number of miles times the cost of each mile plus a Flat Rate Fee/)

        Dim strNumberOfMiles As String
        Dim intNumberOfMiles As Integer
        Dim decTotalCost As Decimal
        Dim decAfterFlatRatePrice As Decimal



        strNumberOfMiles = txtNumberOfMiles.Text
        intNumberOfMiles = Convert.ToInt32(strNumberOfMiles)
        decTotalCost = intNumberOfMiles * _cdecPricePerMile
        decAfterFlatRatePrice = decTotalCost + _cdecFlatRate
        lblTotalCost.Text = decAfterFlatRatePrice.ToString("C")


    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' This event handler is executed when the user clicks the
        ' Clear button. It clears the number of miles text box 
        ' and the Text property of the Total Cost label.
        ' Then, it sets the focus on the txtNumberofMiles Textbox object.

        txtNumberOfMiles.Clear()
        lblTotalCost.Text = ""
        txtNumberOfMiles.Focus()

    End Sub

    Private Sub frmDriverlessUberCar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This event handler is executed when the form is loaded.
        ' It displays the cost heading, clears the Text proper of the
        ' Total Cost label, and sets the focus on the
        ' txtNumberOfMiles Textbox object.

        lblFlatFee.Text = _cdecFlatRate.ToString("C") & " Flat Rate"
        lblCostHeading.Text = _cdecPricePerMile.ToString("C") & " per Mile"
        lblTotalCost.Text = ""
        txtNumberOfMiles.Focus()


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the window and terminate the application.

        Close()

    End Sub
End Class

