<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmKaraoke
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.BtnTotalCost = New System.Windows.Forms.Button()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.lblHourly = New System.Windows.Forms.Label()
        Me.cboRental = New System.Windows.Forms.ComboBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblPerSong = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.lblPerSong)
        Me.Panel1.Controls.Add(Me.lblTotalCost)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.BtnTotalCost)
        Me.Panel1.Controls.Add(Me.txtAmount)
        Me.Panel1.Controls.Add(Me.lblHourly)
        Me.Panel1.Controls.Add(Me.cboRental)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Location = New System.Drawing.Point(251, 3)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(408, 348)
        Me.Panel1.TabIndex = 0
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(26, 282)
        Me.lblTotalCost.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(337, 24)
        Me.lblTotalCost.TabIndex = 6
        Me.lblTotalCost.Text = "Total Cost of Karaoke Night - $XXX.XX"
        Me.lblTotalCost.Visible = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.White
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(235, 206)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(125, 31)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = False
        Me.btnClear.Visible = False
        '
        'BtnTotalCost
        '
        Me.BtnTotalCost.BackColor = System.Drawing.Color.White
        Me.BtnTotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTotalCost.ForeColor = System.Drawing.Color.Black
        Me.BtnTotalCost.Location = New System.Drawing.Point(61, 207)
        Me.BtnTotalCost.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnTotalCost.Name = "BtnTotalCost"
        Me.BtnTotalCost.Size = New System.Drawing.Size(125, 31)
        Me.BtnTotalCost.TabIndex = 4
        Me.BtnTotalCost.Text = "Total Cost"
        Me.BtnTotalCost.UseVisualStyleBackColor = False
        Me.BtnTotalCost.Visible = False
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(165, 161)
        Me.txtAmount.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(57, 29)
        Me.txtAmount.TabIndex = 3
        Me.txtAmount.Visible = False
        '
        'lblHourly
        '
        Me.lblHourly.AutoSize = True
        Me.lblHourly.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHourly.Location = New System.Drawing.Point(57, 123)
        Me.lblHourly.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHourly.Name = "lblHourly"
        Me.lblHourly.Size = New System.Drawing.Size(278, 24)
        Me.lblHourly.TabIndex = 2
        Me.lblHourly.Text = "Hourly Rental of Karaoke Room:"
        Me.lblHourly.Visible = False
        '
        'cboRental
        '
        Me.cboRental.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRental.FormattingEnabled = True
        Me.cboRental.Items.AddRange(New Object() {"Singing Karaoke per song ($2.99 per song)", "Private Karaoke Room ($8.99 per hour)"})
        Me.cboRental.Location = New System.Drawing.Point(29, 39)
        Me.cboRental.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboRental.Name = "cboRental"
        Me.cboRental.Size = New System.Drawing.Size(331, 32)
        Me.cboRental.TabIndex = 1
        Me.cboRental.Text = "Select Rental:"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Stencil", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblTitle.Location = New System.Drawing.Point(13, 3)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(375, 35)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Karaoke Music Knight"
        '
        'lblPerSong
        '
        Me.lblPerSong.AutoSize = True
        Me.lblPerSong.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerSong.Location = New System.Drawing.Point(43, 90)
        Me.lblPerSong.Name = "lblPerSong"
        Me.lblPerSong.Size = New System.Drawing.Size(302, 24)
        Me.lblPerSong.TabIndex = 7
        Me.lblPerSong.Text = "Per Song Rental of Karaoke Room:"
        '
        'frmKaraoke
        '
        Me.AcceptButton = Me.BtnTotalCost
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Karaoke_Music_Night.My.Resources.Resources.karaoke
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(659, 352)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmKaraoke"
        Me.Text = "Karaoke Music Night"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents lblHourly As Label
    Friend WithEvents cboRental As ComboBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents BtnTotalCost As Button
    Friend WithEvents lblPerSong As Label
End Class
