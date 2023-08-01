<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDriverlessUberCar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbHeading = New System.Windows.Forms.Label()
        Me.picUber = New System.Windows.Forms.PictureBox()
        Me.lblNumberOfMiles = New System.Windows.Forms.Label()
        Me.txtNumberOfMiles = New System.Windows.Forms.TextBox()
        Me.lblTotalLabel = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.btnCost = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblCostHeading = New System.Windows.Forms.Label()
        Me.lblFlatFee = New System.Windows.Forms.Label()
        CType(Me.picUber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbHeading
        '
        Me.lbHeading.AutoSize = True
        Me.lbHeading.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHeading.Location = New System.Drawing.Point(9, 9)
        Me.lbHeading.Name = "lbHeading"
        Me.lbHeading.Size = New System.Drawing.Size(380, 41)
        Me.lbHeading.TabIndex = 0
        Me.lbHeading.Text = "Driverless Uber Car"
        '
        'picUber
        '
        Me.picUber.Image = Global.Driverless_Uber_Car.My.Resources.Resources.Driverless_Uber_cars
        Me.picUber.Location = New System.Drawing.Point(-4, 240)
        Me.picUber.Name = "picUber"
        Me.picUber.Size = New System.Drawing.Size(407, 206)
        Me.picUber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picUber.TabIndex = 1
        Me.picUber.TabStop = False
        '
        'lblNumberOfMiles
        '
        Me.lblNumberOfMiles.AutoSize = True
        Me.lblNumberOfMiles.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOfMiles.Location = New System.Drawing.Point(12, 106)
        Me.lblNumberOfMiles.Name = "lblNumberOfMiles"
        Me.lblNumberOfMiles.Size = New System.Drawing.Size(208, 30)
        Me.lblNumberOfMiles.TabIndex = 2
        Me.lblNumberOfMiles.Text = "Number of Miles"
        '
        'txtNumberOfMiles
        '
        Me.txtNumberOfMiles.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumberOfMiles.Location = New System.Drawing.Point(258, 103)
        Me.txtNumberOfMiles.Name = "txtNumberOfMiles"
        Me.txtNumberOfMiles.Size = New System.Drawing.Size(100, 37)
        Me.txtNumberOfMiles.TabIndex = 3
        Me.txtNumberOfMiles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTotalLabel
        '
        Me.lblTotalLabel.AutoSize = True
        Me.lblTotalLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalLabel.Location = New System.Drawing.Point(4, 152)
        Me.lblTotalLabel.Name = "lblTotalLabel"
        Me.lblTotalLabel.Size = New System.Drawing.Size(284, 30)
        Me.lblTotalLabel.TabIndex = 4
        Me.lblTotalLabel.Text = "Total Cost of Uber Ride"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(297, 152)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(98, 30)
        Me.lblTotalCost.TabIndex = 5
        Me.lblTotalCost.Text = "$888.88"
        '
        'btnCost
        '
        Me.btnCost.BackColor = System.Drawing.Color.Aquamarine
        Me.btnCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCost.Location = New System.Drawing.Point(3, 195)
        Me.btnCost.Name = "btnCost"
        Me.btnCost.Size = New System.Drawing.Size(155, 39)
        Me.btnCost.TabIndex = 6
        Me.btnCost.Text = "Display Fare"
        Me.btnCost.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Aquamarine
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(164, 195)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(111, 39)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Aquamarine
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(285, 195)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(111, 39)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblCostHeading
        '
        Me.lblCostHeading.AutoSize = True
        Me.lblCostHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostHeading.Location = New System.Drawing.Point(12, 59)
        Me.lblCostHeading.Name = "lblCostHeading"
        Me.lblCostHeading.Size = New System.Drawing.Size(177, 29)
        Me.lblCostHeading.TabIndex = 9
        Me.lblCostHeading.Text = "$X.XX per Mile"
        '
        'lblFlatFee
        '
        Me.lblFlatFee.AutoSize = True
        Me.lblFlatFee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFlatFee.Location = New System.Drawing.Point(218, 59)
        Me.lblFlatFee.Name = "lblFlatFee"
        Me.lblFlatFee.Size = New System.Drawing.Size(178, 29)
        Me.lblFlatFee.TabIndex = 10
        Me.lblFlatFee.Text = "$X.XX Flat Fee"
        '
        'frmDriverlessUberCar
        '
        Me.AcceptButton = Me.btnCost
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(398, 444)
        Me.Controls.Add(Me.lblFlatFee)
        Me.Controls.Add(Me.lblCostHeading)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCost)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.lblTotalLabel)
        Me.Controls.Add(Me.txtNumberOfMiles)
        Me.Controls.Add(Me.lblNumberOfMiles)
        Me.Controls.Add(Me.picUber)
        Me.Controls.Add(Me.lbHeading)
        Me.Name = "frmDriverlessUberCar"
        Me.Text = "Driverless Uber Car"
        CType(Me.picUber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbHeading As Label
    Friend WithEvents picUber As PictureBox
    Friend WithEvents lblNumberOfMiles As Label
    Friend WithEvents txtNumberOfMiles As TextBox
    Friend WithEvents lblTotalLabel As Label
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents btnCost As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblCostHeading As Label
    Friend WithEvents lblFlatFee As Label
End Class
