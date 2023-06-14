'Name: Yustina Bouls
'course code: NETD-2202-10


Option Strict On
Public Class frmAverageUnitsShipped
    'Variables
    Private Const MINIMUM_LIMIT As Integer = 0 'minimum limit of entering a number
    Private Const MAXIMUM_LIMIT As Integer = 1000 'maximum limit of entering a number
    Private Const NUMBER_OF_DAYS = 7

    Dim units As Integer = 0
    Dim counter As Integer = 1


    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtAverage.TextChanged

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() 'this is how we make clicking on exit button close the design
    End Sub

    Private Sub BtnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim input As String
        Dim numbInt As Integer
        Dim unitAverage As Double

        input = txtinput.Text ' this is converting the input to be known as an input that can be recognized in the textbox, that's why we put ".text" 
        If IsNumeric(input) Then
            numbInt = CInt(input)
            If (numbInt.ToString = input) Then
                If numbInt >= MINIMUM_LIMIT And numbInt <= MAXIMUM_LIMIT Then 'here we're informing that the number to be added has limits which are not less than 0 and not biggre than 1000
                    units += numbInt
                    lstUnits.Items.Add(input) 'here this code makes what've I put in the textbox will be added to the listbox
                    txtinput.Clear() ' and this that we don't have to clear the textbox everytime we're inputting new number 

                    ' PROCESS
                    If counter = NUMBER_OF_DAYS Then 'when we reach the number 7 of days

                        btnEnter.Enabled = False 'the button enter will be disabled to click on
                        txtAverage.ReadOnly = True 'you can't input anything in the textbox that shows you the average
                        txtinput.Enabled = False ' it will not permit you to input any other number cause the limit is 7
                        lstUnits.Enabled = False ' you can't add any thing inside the listbox
                        unitAverage = units / NUMBER_OF_DAYS ' this is the calculations or the formula

                        txtAverage.Text = "Average per day: " + Math.Round(unitAverage, 2).ToString
                    Else
                        counter += 1 ' if the number of days or the input number didn't reach number didn't reach number 7 that means that it will count every time the number you added to be adding the number of days
                        lblday.Text = "Day " + counter.ToString
                    End If
                Else

                    txtAverage.Text = "Must be between " & MINIMUM_LIMIT & " and " & MAXIMUM_LIMIT & "." ' this is an error msg you got 
                    txtinput.Clear() ' this clear the textbox after every time you inputed a number so you won't have to clear it every time you input a new number
                End If
            Else
                txtAverage.Text = "Please enter a whole number" 'this is an error message you got
                txtinput.Clear()
            End If
        Else
            txtAverage.Text = "Please enter a valid number" 'this an error message you got
            txtinput.Clear()
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click 'when you click on the button reset
        txtinput.Clear() ' the textbox will be cleared for you to input numbers
        txtAverage.Clear() ' the average txtbox will be clear
        lstUnits.Items.Clear() 'listbox will be clear
        btnEnter.Enabled = True 'button enter will work after you input your number
        txtinput.Enabled = True 'the textbox where you input the number will be working
        units = 0
        counter = 0 'the counter will be 0 again 
        lblday.Text = "Day 1" 'number of days will be 1 again 
    End Sub

    Private Sub lstUnits_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstUnits.SelectedIndexChanged

    End Sub

    Private Sub txtinput_TextChanged(sender As Object, e As EventArgs) Handles txtinput.TextChanged

    End Sub
End Class
