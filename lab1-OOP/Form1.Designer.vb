<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAverageUnitsShipped
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
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.lblday = New System.Windows.Forms.Label()
        Me.txtinput = New System.Windows.Forms.TextBox()
        Me.lstUnits = New System.Windows.Forms.ListBox()
        Me.txtAverage = New System.Windows.Forms.TextBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblUnits
        '
        Me.lblUnits.AutoSize = True
        Me.lblUnits.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblUnits.Location = New System.Drawing.Point(183, 50)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(50, 20)
        Me.lblUnits.TabIndex = 0
        Me.lblUnits.Text = "Units:"
        '
        'lblday
        '
        Me.lblday.AutoSize = True
        Me.lblday.Location = New System.Drawing.Point(433, 53)
        Me.lblday.Name = "lblday"
        Me.lblday.Size = New System.Drawing.Size(41, 20)
        Me.lblday.TabIndex = 1
        Me.lblday.Text = "Day:"
        '
        'txtinput
        '
        Me.txtinput.Location = New System.Drawing.Point(277, 47)
        Me.txtinput.Name = "txtinput"
        Me.txtinput.Size = New System.Drawing.Size(117, 26)
        Me.txtinput.TabIndex = 2
        '
        'lstUnits
        '
        Me.lstUnits.FormattingEnabled = True
        Me.lstUnits.ItemHeight = 20
        Me.lstUnits.Location = New System.Drawing.Point(198, 106)
        Me.lstUnits.Name = "lstUnits"
        Me.lstUnits.Size = New System.Drawing.Size(292, 184)
        Me.lstUnits.TabIndex = 3
        '
        'txtAverage
        '
        Me.txtAverage.Location = New System.Drawing.Point(198, 305)
        Me.txtAverage.Name = "txtAverage"
        Me.txtAverage.ReadOnly = True
        Me.txtAverage.Size = New System.Drawing.Size(292, 26)
        Me.txtAverage.TabIndex = 4
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(117, 365)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(123, 47)
        Me.btnEnter.TabIndex = 5
        Me.btnEnter.Text = "&Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(290, 365)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(123, 47)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(470, 365)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(123, 47)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmAverageUnitsShipped
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.txtAverage)
        Me.Controls.Add(Me.lstUnits)
        Me.Controls.Add(Me.txtinput)
        Me.Controls.Add(Me.lblday)
        Me.Controls.Add(Me.lblUnits)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAverageUnitsShipped"
        Me.Text = "Average Units Shipped"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUnits As Label
    Friend WithEvents lblday As Label
    Friend WithEvents txtinput As TextBox
    Friend WithEvents lstUnits As ListBox
    Friend WithEvents txtAverage As TextBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
End Class
