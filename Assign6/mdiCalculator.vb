Imports System.ComponentModel
Imports System.Math
Public Class mdiCalculator
    '-----------------------------------------------------------------------------------------------------
    '-                                          File Name : mdiCalculator                                - 
    '-                                          Part of Project: Assign6                                 -
    '-----------------------------------------------------------------------------------------------------
    '-                                          Written By: Tyler Miller                                 -
    '-                                          Written On: 02/20/2016                                   -
    '-----------------------------------------------------------------------------------------------------
    '- File Purpose:                                                                                     -
    '- This file is an MDI child form. It will be called when the user chooses the new button on the menu-
    '- bar of the parent form. It is a calculator that performs calculations of geometric shapes.        - 
    '-----------------------------------------------------------------------------------------------------
    '- Global Variable Dictionary (alphabetically):                                                      -
    '- CUBED   - a constant string that is used for reference purposes.                                  -
    '- SQUARED - a constant string that is used for reference purposes.                                  -
    '- STD     - a constant string that is used for reference purposes.                                  -
    '- strAnswerType - a string that holds the conversion answer type for a given formula.               -
    '- txtLostFocus - a textbox that is used for reference purposes.                                     -
    '-----------------------------------------------------------------------------------------------------
    'Declaring Constant Strings used through the program
    Public Const SQUARED As String = "SQUARED"
    Public Const CUBED As String = "CUBED"
    Public Const STD As String = "STD"
    'Declaring gloabal variables used throughout this form
    Dim txtLostFocus As TextBox
    Dim strAnswerType As String = ""

    Private Sub lstShape_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstShape.SelectedIndexChanged
        '----------------------------------------------------------------------------------------------------
        '-                               Subprogram Name: lstShape_SelectedIndexChanged                     -
        '----------------------------------------------------------------------------------------------------
        '-                               Written By: Tyler Miller                                           -
        '-                               Written On: 02/21/2016                                             -
        '----------------------------------------------------------------------------------------------------
        '- Subprogram Purpose:                                                                              -
        '-                                                                                                  -
        '- This subroutine is called when the user clicks an item in the lstShape list box. It will see what-
        '- shape the user wants to calculate and display that picture along with the appropriate input text -
        '- boxes                                                                                            -
        '----------------------------------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                                                       -
        '- sender – Identifies which particular control raised the                                          –
        '-          click event                                                                             - 
        '- e – Holds the EventArgs object sent to the routine                                               -
        '----------------------------------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                                                      -
        '- strShape - A string value that stores the information from the lstShape box for future use       -
        '----------------------------------------------------------------------------------------------------
        resetCalc()

        If lstShape.SelectedItem <> Nothing Then
            Dim strShape As String = lstShape.SelectedItem.ToString
            showFormula()
            Try
                If strShape = "2D - Rectangle" Then
                    picMathImage.Image = Image.FromFile("GeometryDrawings\rectangle.jpg")
                    txtLength.Show()
                    txtWidth.Show()
                    lblLength.Show()
                    lblWidth.Show()
                ElseIf strShape = "2D - Square" Then
                    picMathImage.Image = Image.FromFile("GeometryDrawings\square.jpg")
                    txtLength.Show()
                    lblLength.Show()
                ElseIf strShape = "2D - Right Triangle" Then
                    picMathImage.Image = Image.FromFile("GeometryDrawings\triangle.jpg")
                    txtBase.Show()
                    lblBase.Show()
                    txtHeight.Show()
                    lblHeight.Show()
                ElseIf strShape = "2D - Circle" Or strShape = "3D - Sphere" Then
                    If strShape = "2D - Circle" Then
                        picMathImage.Image = Image.FromFile("GeometryDrawings\circle.jpg")
                    Else
                        picMathImage.Image = Image.FromFile("GeometryDrawings\sphere.jpg")
                    End If
                    txtRadius.Show()
                    lblRadius.Show()
                ElseIf strShape = "3D - Cube" Then
                    picMathImage.Image = Image.FromFile("GeometryDrawings\cube.jpg")
                    txtLength.Show()
                    txtWidth.Show()
                    txtHeight.Show()
                    lblLength.Show()
                    lblWidth.Show()
                    lblHeight.Show()
                ElseIf strShape = "3D - Cylinder" Or strShape = "3D - Cone" Then
                    If strShape = "3D - Cylinder" Then
                        picMathImage.Image = Image.FromFile("GeometryDrawings\cylinder.jpg")
                    Else
                        picMathImage.Image = Image.FromFile("GeometryDrawings\cone.jpg")
                    End If
                    txtRadius.Show()
                    lblRadius.Show()
                    txtHeight.Show()
                    lblHeight.Show()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub showFormula()
        '----------------------------------------------------------------------------------------------------
        '-                               Subprogram Name: showFormula()                                     -
        '----------------------------------------------------------------------------------------------------
        '-                               Written By: Tyler Miller                                           -
        '-                               Written On: 02/21/2016                                             -
        '----------------------------------------------------------------------------------------------------
        '- Subprogram Purpose:                                                                              -
        '-                                                                                                  -
        '- This subroutine is called whenever the lstShape listbox selected index is changed. It will see   -
        '- what the user has selected and then determine which formulas to show in the lstFormula list box  -
        '----------------------------------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                                                       -
        '- (None)                                                                                           -
        '----------------------------------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                                                      -
        '- strShape - A string value that stores the information from the lstShape box for future use       -
        '----------------------------------------------------------------------------------------------------
        Dim strShape As String = lstShape.SelectedItem.ToString

        lstFormula.Items.Clear()

        If strShape.Contains("Circle") Then
            lstFormula.Items.Add("Circumference")
            lstFormula.Items.Add("Area")
            lstFormula.SelectedItem = "Circumference"
        ElseIf strShape.StartsWith("3D") Then
            lstFormula.Items.Add("Volume")
            lstFormula.Items.Add("Surface Area")
            lstFormula.SelectedItem = "Volume"
        Else
            lstFormula.Items.Add("Perimeter")
            lstFormula.Items.Add("Area")
            lstFormula.SelectedItem = "Perimeter"
        End If
    End Sub

    Private Sub cmdCalculate_Click(sender As Object, e As EventArgs) Handles cmdCalculate.Click
        '----------------------------------------------------------------------------------------------------
        '-                               Subprogram Name: cmdCalculate_Click()                              -
        '----------------------------------------------------------------------------------------------------
        '-                               Written By: Tyler Miller                                           -
        '-                               Written On: 02/21/2016                                             -
        '----------------------------------------------------------------------------------------------------
        '- Subprogram Purpose:                                                                              -
        '-                                                                                                  -
        '- This subroutine is called whenever the user clicks on the "Calculate" button. It will look at    -
        '- what formula and shape is selected and perform the correct calculations and put them in the list -
        '- box.                                                                                             -
        '----------------------------------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                                                       -
        '- sender – Identifies which particular control raised the                                          –
        '-          click event                                                                             - 
        '- e – Holds the EventArgs object sent to the routine                                               -
        '----------------------------------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                                                      -
        '- strSelectedShape - a string that contains the name of the selected shape                         -
        '- strSelectedFormual - a string that contains the name of the selected formula                     -
        '- dblAnswer - a double that holds the final answer value
        '----------------------------------------------------------------------------------------------------

        If lstShape.SelectedIndex > -1 AndAlso lstFormula.SelectedIndex > -1 Then
            Try
                Dim selectedShape As String = lstShape.SelectedItem.ToString
                Dim selectedFormula As String = lstFormula.SelectedItem.ToString
                Dim answer As Double = 0
                Select Case selectedShape
                    'Performing the calculations for whatever shape and formula is selected
                    Case "2D - Rectangle"
                        If selectedFormula = "Perimeter" Then
                            answer = (2 * CDbl(txtLength.Text)) + (2 * CDbl(txtWidth.Text))
                        ElseIf selectedFormula = "Area" Then
                            answer = CDbl(txtLength.Text) * CDbl(txtWidth.Text)
                        End If
                    Case "2D - Square"
                        If selectedFormula = "Perimeter" Then
                            answer = (4 * CDbl(txtLength.Text))
                        ElseIf selectedFormula = "Area" Then
                            answer = (CDbl(txtLength.Text) ^ 2)
                        End If
                    Case "2D - Right Triangle"
                        If selectedFormula = "Perimeter" Then
                            answer = (CDbl(txtHeight.Text) + CDbl(txtBase.Text) +
                                Sqrt(CDbl(txtHeight.Text) ^ 2 + CDbl(txtBase.Text) ^ 2))
                        ElseIf selectedFormula = "Area" Then
                            answer = (0.5 * CDbl(txtBase.Text) * CDbl(txtHeight.Text))
                        End If
                    Case "2D - Circle"
                        If selectedFormula = "Circumference" Then
                            answer = (2 * PI * CDbl(txtRadius.Text))
                        ElseIf selectedFormula = "Area" Then
                            answer = (PI * CDbl(txtRadius.Text) ^ 2)
                        End If
                    Case "3D - Cube"
                        If selectedFormula = "Volume" Then
                            answer = (CDbl(txtHeight.Text) * CDbl(txtWidth.Text) * CDbl(txtLength.Text))
                        ElseIf selectedFormula = "Surface Area" Then
                            answer = ((2 * CDbl(txtWidth.Text) * CDbl(txtLength.Text)) +
                                (2 * CDbl(txtLength.Text) * CDbl(txtWidth.Text)) +
                                (2 * CDbl(txtWidth.Text) * CDbl(txtHeight.Text)))
                        End If
                    Case "3D - Sphere"
                        If selectedFormula = "Volume" Then
                            answer = ((4 / 3) * PI * (CDbl(txtRadius.Text) ^ 3))
                        ElseIf selectedFormula = "Surface Area" Then
                            answer = (4 * PI * (CDbl(txtRadius.Text) ^ 2))
                        End If
                    Case "3D - Cylinder"
                        If selectedFormula = "Volume" Then
                            answer = (PI * ((CDbl(txtRadius.Text) ^ 2) * CDbl(txtHeight.Text)))
                        ElseIf selectedFormula = "Surface Area" Then
                            answer = ((2 * PI * CDbl(txtRadius.Text) * (CDbl(txtHeight.Text))) +
                                (2 * PI * (CDbl(txtRadius.Text) ^ 2)))
                        End If
                    Case "3D - Cone"
                        If selectedFormula = "Volume" Then
                            answer = ((1 / 3) * PI * (CDbl(txtRadius.Text) ^ 2) * CDbl(txtHeight.Text))
                        ElseIf selectedFormula = "Surface Area" Then
                            answer = (PI * CDbl(txtRadius.Text)) * (CDbl(txtRadius.Text) +
                                Sqrt(CDbl(txtRadius.Text) ^ 2 + CDbl(txtHeight.Text) ^ 2))
                        End If
                End Select

                'Showing the final answer in the answer text box
                lblFinalAnswer.Show()
                txtAnswer.Text = answer
            Catch ex As Exception
                MessageBox.Show("Please provide valid input for all visable variable text boxes!", "Attention!")
            End Try
        Else
            MessageBox.Show("Please select a shape and/or formula!", "Attention!")
        End If

    End Sub

    Private Sub resetCalc()
        '----------------------------------------------------------------------------------------------------
        '-                               Subprogram Name: resetCalc()                                       -
        '----------------------------------------------------------------------------------------------------
        '-                               Written By: Tyler Miller                                           -
        '-                               Written On: 02/21/2016                                             -
        '----------------------------------------------------------------------------------------------------
        '- Subprogram Purpose:                                                                              -
        '-                                                                                                  -
        '- This subroutine is called to reset the calculator values and states to its cleared, original     -
        '- state. All text boxes are cleared and hidden and the image holder is cleared.                    -
        '----------------------------------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                                                       -
        '- (None)                                                                                           -
        '----------------------------------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                                                      -
        '- (None)                                                                                           -
        '----------------------------------------------------------------------------------------------------
        grpConvertAnswer.Hide()
        lblFinalAnswer.Hide()
        txtLostFocus = Nothing

        'Clearing all textboxes
        For Each control In Me.Controls
            If TypeOf control Is TextBox Then
                If control Is txtAnswer Then
                    control.Text = 0
                Else
                    control.text = ""
                End If
            End If
        Next

        'Hiding all of the input textboxes and their labels
        txtBase.Hide()
        lblBase.Hide()

        txtHeight.Hide()
        lblHeight.Hide()

        txtLength.Hide()
        lblLength.Hide()

        txtRadius.Hide()
        lblRadius.Hide()

        txtWidth.Hide()
        lblWidth.Hide()

        picMathImage.Image = Nothing
    End Sub
    Private Sub addToTextBox(ByVal strInput As String)
        '----------------------------------------------------------------------------------------------------
        '-                               Subprogram Name: addToTextBox()                                    -
        '----------------------------------------------------------------------------------------------------
        '-                               Written By: Tyler Miller                                           -
        '-                               Written On: 02/21/2016                                             -
        '----------------------------------------------------------------------------------------------------
        '- Subprogram Purpose:                                                                              -
        '-                                                                                                  -
        '- This subroutine is called to add a button clicked value into the selected textbox. If the user   -
        '- selects the desired textbox, and then button presses the number on the form, the respective      -
        '- number will appear in the textbox.                                                               -
        '----------------------------------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                                                       -
        '- strInput - a string variable that holds the input to put into the selected textbox               -
        '----------------------------------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                                                      -
        '- (None)                                                                                           -
        '----------------------------------------------------------------------------------------------------
        If Not txtLostFocus Is Nothing Then
            If Not (txtLostFocus.Text.Contains(".") And strInput = ".") Then
                If txtLostFocus.Text <> "" Then
                    txtLostFocus.Text &= strInput
                    txtLostFocus.SelectionStart = txtLostFocus.Text.Length + 1
                Else
                    txtLostFocus.Text = strInput
                    txtLostFocus.SelectionStart = txtLostFocus.Text.Length + 1
                End If
            End If
        Else
            If Not lstShape.SelectedIndex = -1 Then
                MessageBox.Show("Please select a variable textbox!", "Attention!")
            End If
        End If
    End Sub

    Private Sub txtRadius_LostFocus(sender As Object, e As EventArgs) Handles txtRadius.LostFocus
        '----------------------------------------------------------------------------------------------------
        '-                               Subprogram Name: txtRadius_LostFocus()                             -
        '----------------------------------------------------------------------------------------------------
        '-                               Written By: Tyler Miller                                           -
        '-                               Written On: 02/21/2016                                             -
        '----------------------------------------------------------------------------------------------------
        '- Subprogram Purpose:                                                                              -
        '-                                                                                                  -
        '- This subroutine is called when the txtRadius textbox loses focus. It assignes the txtLostFocus   -
        '- to that value so when the user uses a number button to input a number into the textbox, it will  -
        '- know to put it in the correct textbox.                                                           -
        '----------------------------------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                                                       -
        '- sender – Identifies which particular control raised the                                          –
        '-          click event                                                                             - 
        '- e – Holds the EventArgs object sent to the routine                                               -
        '----------------------------------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                                                      -
        '- (None)                                                                                           -
        '----------------------------------------------------------------------------------------------------
        txtLostFocus = txtRadius
    End Sub

    Private Sub txtLength_LostFocus(sender As Object, e As EventArgs) Handles txtLength.LostFocus
        '----------------------------------------------------------------------------------------------------
        '-                               Subprogram Name: txtLength_LostFocus()                             -
        '----------------------------------------------------------------------------------------------------
        '-                               Written By: Tyler Miller                                           -
        '-                               Written On: 02/21/2016                                             -
        '----------------------------------------------------------------------------------------------------
        '- Subprogram Purpose:                                                                              -
        '-                                                                                                  -
        '- This subroutine is called when the txtLength textbox loses focus. It assignes the txtLostFocus   -
        '- to that value so when the user uses a number button to input a number into the textbox, it will  -
        '- know to put it in the correct textbox.                                                           -
        '----------------------------------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                                                       -
        '- sender – Identifies which particular control raised the                                          –
        '-          click event                                                                             - 
        '- e – Holds the EventArgs object sent to the routine                                               -
        '----------------------------------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                                                      -
        '- (None)                                                                                           -
        '----------------------------------------------------------------------------------------------------
        txtLostFocus = txtLength
    End Sub
    Private Sub txtWidth_LostFocus(sender As Object, e As EventArgs) Handles txtWidth.LostFocus
        '----------------------------------------------------------------------------------------------------
        '-                               Subprogram Name: txtWidth_LostFocus()                              -
        '----------------------------------------------------------------------------------------------------
        '-                               Written By: Tyler Miller                                           -
        '-                               Written On: 02/21/2016                                             -
        '----------------------------------------------------------------------------------------------------
        '- Subprogram Purpose:                                                                              -
        '-                                                                                                  -
        '- This subroutine is called when the txtWidth  textbox loses focus. It assignes the txtLostFocus   -
        '- to that value so when the user uses a number button to input a number into the textbox, it will  -
        '- know to put it in the correct textbox.                                                           -
        '----------------------------------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                                                       -
        '- sender – Identifies which particular control raised the                                          –
        '-          click event                                                                             - 
        '- e – Holds the EventArgs object sent to the routine                                               -
        '----------------------------------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                                                      -
        '- (None)                                                                                           -
        '----------------------------------------------------------------------------------------------------
        txtLostFocus = txtWidth
    End Sub
    Private Sub txtBase_LostFocus(sender As Object, e As EventArgs) Handles txtBase.LostFocus
        '----------------------------------------------------------------------------------------------------
        '-                               Subprogram Name: txtBase_LostFocus()                               -
        '----------------------------------------------------------------------------------------------------
        '-                               Written By: Tyler Miller                                           -
        '-                               Written On: 02/21/2016                                             -
        '----------------------------------------------------------------------------------------------------
        '- Subprogram Purpose:                                                                              -
        '-                                                                                                  -
        '- This subroutine is called when the txtBase textbox loses focus. It assignes the txtLostFocus     -
        '- to that value so when the user uses a number button to input a number into the textbox, it will  -
        '- know to put it in the correct textbox.                                                           -
        '----------------------------------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                                                       -
        '- sender – Identifies which particular control raised the                                          –
        '-          click event                                                                             - 
        '- e – Holds the EventArgs object sent to the routine                                               -
        '----------------------------------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                                                      -
        '- (None)                                                                                           -
        '----------------------------------------------------------------------------------------------------
        txtLostFocus = txtBase
    End Sub
    Private Sub txtHeight_LostFocus(sender As Object, e As EventArgs) Handles txtHeight.LostFocus
        '----------------------------------------------------------------------------------------------------
        '-                               Subprogram Name: txtHeight_LostFocus()                             -
        '----------------------------------------------------------------------------------------------------
        '-                               Written By: Tyler Miller                                           -
        '-                               Written On: 02/21/2016                                             -
        '----------------------------------------------------------------------------------------------------
        '- Subprogram Purpose:                                                                              -
        '-                                                                                                  -
        '- This subroutine is called when the txtHeight textbox loses focus. It assignes the txtLostFocus   -
        '- to that value so when the user uses a number button to input a number into the textbox, it will  -
        '- know to put it in the correct textbox.                                                           -
        '----------------------------------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                                                       -
        '- sender – Identifies which particular control raised the                                          –
        '-          click event                                                                             - 
        '- e – Holds the EventArgs object sent to the routine                                               -
        '----------------------------------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                                                      -
        '- (None)                                                                                           -
        '----------------------------------------------------------------------------------------------------
        txtLostFocus = txtHeight
    End Sub

    Private Sub cmd1_Click(sender As Object, e As EventArgs) Handles cmd1.Click
        '----------------------------------------------------------------------------------------------------
        '-                               Subprogram Name: cmd1_Click()                                      -
        '----------------------------------------------------------------------------------------------------
        '-                               Written By: Tyler Miller                                           -
        '-                               Written On: 02/21/2016                                             -
        '----------------------------------------------------------------------------------------------------
        '- Subprogram Purpose:                                                                              -
        '-                                                                                                  -
        '- This subroutine is called when the user clicks the '1' button on the mdiCalculator form. It will -
        '- call the addToTextBox function which will add the selected number to the desired textbox.        -
        '----------------------------------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                                                       -
        '- sender – Identifies which particular control raised the                                          –
        '-          click event                                                                             - 
        '- e – Holds the EventArgs object sent to the routine                                               -
        '----------------------------------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                                                      -
        '- (None)                                                                                           -
        '----------------------------------------------------------------------------------------------------
        addToTextBox(1)
    End Sub

    Private Sub cmd2_Click(sender As Object, e As EventArgs) Handles cmd2.Click
        '----------------------------------------------------------------------------------------------------
        '-                               Subprogram Name: cmd2_Click()                                      -
        '----------------------------------------------------------------------------------------------------
        '-                               Written By: Tyler Miller                                           -
        '-                               Written On: 02/21/2016                                             -
        '----------------------------------------------------------------------------------------------------
        '- Subprogram Purpose:                                                                              -
        '-                                                                                                  -
        '- This subroutine is called when the user clicks the '2' button on the mdiCalculator form. It will -
        '- call the addToTextBox function which will add the selected number to the desired textbox.        -
        '----------------------------------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                                                       -
        '- sender – Identifies which particular control raised the                                          –
        '-          click event                                                                             - 
        '- e – Holds the EventArgs object sent to the routine                                               -
        '----------------------------------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                                                      -
        '- (None)                                                                                           -
        '----------------------------------------------------------------------------------------------------
        addToTextBox(2)
    End Sub

    Private Sub cmd3_Click(sender As Object, e As EventArgs) Handles cmd3.Click
        '----------------------------------------------------------------------------------------------------
        '-                               Subprogram Name: cmd3_Click()                                      -
        '----------------------------------------------------------------------------------------------------
        '-                               Written By: Tyler Miller                                           -
        '-                               Written On: 02/21/2016                                             -
        '----------------------------------------------------------------------------------------------------
        '- Subprogram Purpose:                                                                              -
        '-                                                                                                  -
        '- This subroutine is called when the user clicks the '3' button on the mdiCalculator form. It will -
        '- call the addToTextBox function which will add the selected number to the desired textbox.        -
        '----------------------------------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                                                       -
        '- sender – Identifies which particular control raised the                                          –
        '-          click event                                                                             - 
        '- e – Holds the EventArgs object sent to the routine                                               -
        '----------------------------------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                                                      -
        '- (None)                                                                                           -
        '----------------------------------------------------------------------------------------------------
        addToTextBox(3)
    End Sub

    Private Sub cmd4_Click(sender As Object, e As EventArgs) Handles cmd4.Click
        '----------------------------------------------------------------------------------------------------
        '-                               Subprogram Name: cmd4_Click()                                      -
        '----------------------------------------------------------------------------------------------------
        '-                               Written By: Tyler Miller                                           -
        '-                               Written On: 02/21/2016                                             -
        '----------------------------------------------------------------------------------------------------
        '- Subprogram Purpose:                                                                              -
        '-                                                                                                  -
        '- This subroutine is called when the user clicks the '4' button on the mdiCalculator form. It will -
        '- call the addToTextBox function which will add the selected number to the desired textbox.        -
        '----------------------------------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                                                       -
        '- sender – Identifies which particular control raised the                                          –
        '-          click event                                                                             - 
        '- e – Holds the EventArgs object sent to the routine                                               -
        '----------------------------------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                                                      -
        '- (None)                                                                                           -
        '----------------------------------------------------------------------------------------------------
        addToTextBox(4)
    End Sub

    Private Sub cmd5_Click(sender As Object, e As EventArgs) Handles cmd5.Click
        '----------------------------------------------------------------------------------------------------
        '-                               Subprogram Name: cmd5_Click()                                      -
        '----------------------------------------------------------------------------------------------------
        '-                               Written By: Tyler Miller                                           -
        '-                               Written On: 02/21/2016                                             -
        '----------------------------------------------------------------------------------------------------
        '- Subprogram Purpose:                                                                              -
        '-                                                                                                  -
        '- This subroutine is called when the user clicks the '5' button on the mdiCalculator form. It will -
        '- call the addToTextBox function which will add the selected number to the desired textbox.        -
        '----------------------------------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                                                       -
        '- sender – Identifies which particular control raised the                                          –
        '-          click event                                                                             - 
        '- e – Holds the EventArgs object sent to the routine                                               -
        '----------------------------------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                                                      -
        '- (None)                                                                                           -
        '----------------------------------------------------------------------------------------------------
        addToTextBox(5)
    End Sub

    Private Sub cmd6_Click(sender As Object, e As EventArgs) Handles cmd6.Click
        '----------------------------------------------------------------------------------------------------
        '-                               Subprogram Name: cmd6_Click()                                      -
        '----------------------------------------------------------------------------------------------------
        '-                               Written By: Tyler Miller                                           -
        '-                               Written On: 02/21/2016                                             -
        '----------------------------------------------------------------------------------------------------
        '- Subprogram Purpose:                                                                              -
        '-                                                                                                  -
        '- This subroutine is called when the user clicks the '6' button on the mdiCalculator form. It will -
        '- call the addToTextBox function which will add the selected number to the desired textbox.        -
        '----------------------------------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                                                       -
        '- sender – Identifies which particular control raised the                                          –
        '-          click event                                                                             - 
        '- e – Holds the EventArgs object sent to the routine                                               -
        '----------------------------------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                                                      -
        '- (None)                                                                                           -
        '----------------------------------------------------------------------------------------------------
        addToTextBox(6)
    End Sub

    Private Sub cmd7_Click(sender As Object, e As EventArgs) Handles cmd7.Click
        '----------------------------------------------------------------------------------------------------
        '-                               Subprogram Name: cmd7_Click()                                      -
        '----------------------------------------------------------------------------------------------------
        '-                               Written By: Tyler Miller                                           -
        '-                               Written On: 02/21/2016                                             -
        '----------------------------------------------------------------------------------------------------
        '- Subprogram Purpose:                                                                              -
        '-                                                                                                  -
        '- This subroutine is called when the user clicks the '7' button on the mdiCalculator form. It will -
        '- call the addToTextBox function which will add the selected number to the desired textbox.        -
        '----------------------------------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                                                       -
        '- sender – Identifies which particular control raised the                                          –
        '-          click event                                                                             - 
        '- e – Holds the EventArgs object sent to the routine                                               -
        '----------------------------------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                                                      -
        '- (None)                                                                                           -
        '----------------------------------------------------------------------------------------------------
        addToTextBox(7)
    End Sub

    Private Sub cmd8_Click(sender As Object, e As EventArgs) Handles cmd8.Click
        '----------------------------------------------------------------------------------------------------
        '-                               Subprogram Name: cmd8_Click()                                      -
        '----------------------------------------------------------------------------------------------------
        '-                               Written By: Tyler Miller                                           -
        '-                               Written On: 02/21/2016                                             -
        '----------------------------------------------------------------------------------------------------
        '- Subprogram Purpose:                                                                              -
        '-                                                                                                  -
        '- This subroutine is called when the user clicks the '8' button on the mdiCalculator form. It will -
        '- call the addToTextBox function which will add the selected number to the desired textbox.        -
        '----------------------------------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                                                       -
        '- sender – Identifies which particular control raised the                                          –
        '-          click event                                                                             - 
        '- e – Holds the EventArgs object sent to the routine                                               -
        '----------------------------------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                                                      -
        '- (None)                                                                                           -
        '----------------------------------------------------------------------------------------------------
        addToTextBox(8)
    End Sub

    Private Sub cmd9_Click(sender As Object, e As EventArgs) Handles cmd9.Click
        '----------------------------------------------------------------------------------------------------
        '-                               Subprogram Name: cmd9_Click()                                      -
        '----------------------------------------------------------------------------------------------------
        '-                               Written By: Tyler Miller                                           -
        '-                               Written On: 02/21/2016                                             -
        '----------------------------------------------------------------------------------------------------
        '- Subprogram Purpose:                                                                              -
        '-                                                                                                  -
        '- This subroutine is called when the user clicks the '9' button on the mdiCalculator form. It will -
        '- call the addToTextBox function which will add the selected number to the desired textbox.        -
        '----------------------------------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                                                       -
        '- sender – Identifies which particular control raised the                                          –
        '-          click event                                                                             - 
        '- e – Holds the EventArgs object sent to the routine                                               -
        '----------------------------------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                                                      -
        '- (None)                                                                                           -
        '----------------------------------------------------------------------------------------------------
        addToTextBox(9)
    End Sub

    Private Sub cmd0_Click(sender As Object, e As EventArgs) Handles cmd0.Click
        '----------------------------------------------------------------------------------------------------
        '-                               Subprogram Name: cmd0_Click()                                      -
        '----------------------------------------------------------------------------------------------------
        '-                               Written By: Tyler Miller                                           -
        '-                               Written On: 02/21/2016                                             -
        '----------------------------------------------------------------------------------------------------
        '- Subprogram Purpose:                                                                              -
        '-                                                                                                  -
        '- This subroutine is called when the user clicks the '0' button on the mdiCalculator form. It will -
        '- call the addToTextBox function which will add the selected number to the desired textbox.        -
        '----------------------------------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                                                       -
        '- sender – Identifies which particular control raised the                                          –
        '-          click event                                                                             - 
        '- e – Holds the EventArgs object sent to the routine                                               -
        '----------------------------------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                                                      -
        '- (None)                                                                                           -
        '----------------------------------------------------------------------------------------------------
        addToTextBox(0)
    End Sub

    Private Sub cmdDecimal_Click(sender As Object, e As EventArgs) Handles cmdDecimal.Click
        '----------------------------------------------------------------------------------------------------
        '-                               Subprogram Name: cmdDecimal_Click()                                -
        '----------------------------------------------------------------------------------------------------
        '-                               Written By: Tyler Miller                                           -
        '-                               Written On: 02/21/2016                                             -
        '----------------------------------------------------------------------------------------------------
        '- Subprogram Purpose:                                                                              -
        '-                                                                                                  -
        '- This subroutine is called when the user clicks the '.' button on the mdiCalculator form. It will -
        '- call the addToTextBox function which will add the selected number to the desired textbox.        -
        '----------------------------------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                                                       -
        '- sender – Identifies which particular control raised the                                          –
        '-          click event                                                                             - 
        '- e – Holds the EventArgs object sent to the routine                                               -
        '----------------------------------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                                                      -
        '- (None)                                                                                           -
        '----------------------------------------------------------------------------------------------------
        addToTextBox(".")
    End Sub

    Private Sub cmdClearAll_Click(sender As Object, e As EventArgs) Handles cmdClearAll.Click
        '----------------------------------------------------------------------------------------------------
        '-                               Subprogram Name: cmdClearAll_Click()                               -
        '----------------------------------------------------------------------------------------------------
        '-                               Written By: Tyler Miller                                           -
        '-                               Written On: 02/21/2016                                             -
        '----------------------------------------------------------------------------------------------------
        '- Subprogram Purpose:                                                                              -
        '-                                                                                                  -
        '- This subroutine is called when the user clicks the 'C' button on the mdiCalculator form. It will -
        '- call the resetCalc() function and clear the selected items from the Formula and Shape lstBoxes   -
        '----------------------------------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                                                       -
        '- sender – Identifies which particular control raised the                                          –
        '-          click event                                                                             - 
        '- e – Holds the EventArgs object sent to the routine                                               -
        '----------------------------------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                                                      -
        '- (None)                                                                                           -
        '----------------------------------------------------------------------------------------------------
        resetCalc()
        lstFormula.ClearSelected()
        lstShape.ClearSelected()
    End Sub

    Private Sub cmdClearEntry_Click(sender As Object, e As EventArgs) Handles cmdClearEntry.Click
        '----------------------------------------------------------------------------------------------------
        '-                               Subprogram Name: cmdClearEntry_Click()                             -
        '----------------------------------------------------------------------------------------------------
        '-                               Written By: Tyler Miller                                           -
        '-                               Written On: 02/21/2016                                             -
        '----------------------------------------------------------------------------------------------------
        '- Subprogram Purpose:                                                                              -
        '-                                                                                                  -
        '- This subroutine is called when the user clicks the 'CE' button on the mdiCalculator form. It will-
        '- reset the currently selected textbox and clear all the inputted information.                     -
        '----------------------------------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                                                       -
        '- sender – Identifies which particular control raised the                                          –
        '-          click event                                                                             - 
        '- e – Holds the EventArgs object sent to the routine                                               -
        '----------------------------------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                                                      -
        '- (None)                                                                                           -
        '----------------------------------------------------------------------------------------------------
        Try
            txtLostFocus.Text = ""
        Catch ex As Exception
            MessageBox.Show("There is no entry to clear!", "Attention!")
        End Try
    End Sub



    Private Sub mdiCalculator_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        '----------------------------------------------------------------------------------------------------
        '-                               Subprogram Name: mdiCalculator_Closing_Click()                     -
        '----------------------------------------------------------------------------------------------------
        '-                               Written By: Tyler Miller                                           -
        '-                               Written On: 02/21/2016                                             -
        '----------------------------------------------------------------------------------------------------
        '- Subprogram Purpose:                                                                              -
        '-                                                                                                  -
        '- This subroutine is called when the form is closing. It will check to see if there is an answer   -
        '- in the txtAnswer text box. If there is, it will prompt the user if they really would like to quit-
        '----------------------------------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                                                       -
        '- sender – Identifies which particular control raised the                                          –
        '-          click event                                                                             - 
        '- e – Holds the EventArgs object sent to the routine                                               -
        '----------------------------------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                                                      -
        '- (None)                                                                                           -
        '----------------------------------------------------------------------------------------------------
        Dim blnDirty As Boolean = False

        If txtAnswer.Text <> "0" Then
            blnDirty = True
        End If

        'Bring closing form to forefront
        Me.Activate()
        GlobalCount.intFormCount = (GlobalCount.intFormCount - 1)

        If blnDirty = True Then
            Dim result As DialogResult
            result = MessageBox.Show("Are you sure you want to quit '" & Me.Text & "'?",
                                     "Attention!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.No Then
                e.Cancel = True
                GlobalCount.intFormCount = (GlobalCount.intFormCount + 1)
            End If
        End If

    End Sub

    Private Sub txtBase_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBase.KeyPress
        '----------------------------------------------------------------------------------------------------
        '-                               Subprogram Name: txtBase_KeyPress                                  -
        '----------------------------------------------------------------------------------------------------
        '-                               Written By: Tyler Miller                                           -
        '-                               Written On: 02/21/2016                                             -
        '----------------------------------------------------------------------------------------------------
        '- Subprogram Purpose:                                                                              -
        '-                                                                                                  -
        '- This subroutine is called whenever the user inputs a keypboard press into this textbox. It will  -
        '- check to see if the input is valid, and will allow it if it passes the desired conditions.       -
        '----------------------------------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                                                       -
        '- sender – Identifies which particular control raised the                                          –
        '-          click event                                                                             - 
        '- e – Holds the KeyPressEventArgs object sent to the routine                                       -
        '----------------------------------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                                                      -
        '- strText - string variable that holds the text that already exists in the textbox                 -
        '----------------------------------------------------------------------------------------------------
        Dim strText As String = ActiveControl.Text
        If Not strText.Contains(".") Then
            If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Asc(e.KeyChar) = 8 Then
                e.Handled = True
            End If
        Else
            If Not Char.IsNumber(e.KeyChar) AndAlso Not Asc(e.KeyChar) = 8 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtHeight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHeight.KeyPress
        '----------------------------------------------------------------------------------------------------
        '-                               Subprogram Name: txtHeight_KeyPress                                -
        '----------------------------------------------------------------------------------------------------
        '-                               Written By: Tyler Miller                                           -
        '-                               Written On: 02/21/2016                                             -
        '----------------------------------------------------------------------------------------------------
        '- Subprogram Purpose:                                                                              -
        '-                                                                                                  -
        '- This subroutine is called whenever the user inputs a keypboard press into this textbox. It will  -
        '- check to see if the input is valid, and will allow it if it passes the desired conditions.       -
        '----------------------------------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                                                       -
        '- sender – Identifies which particular control raised the                                          –
        '-          click event                                                                             - 
        '- e – Holds the KeyPressEventArgs object sent to the routine                                       -
        '----------------------------------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                                                      -
        '- strText - string variable that holds the text that already exists in the textbox                 -
        '----------------------------------------------------------------------------------------------------
        Dim strText As String = ActiveControl.Text
        If Not strText.Contains(".") Then
            If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Asc(e.KeyChar) = 8 Then
                e.Handled = True
            End If
        Else
            If Not Char.IsNumber(e.KeyChar) AndAlso Not Asc(e.KeyChar) = 8 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtLength_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLength.KeyPress
        '----------------------------------------------------------------------------------------------------
        '-                               Subprogram Name: txtLength_KeyPress                                -
        '----------------------------------------------------------------------------------------------------
        '-                               Written By: Tyler Miller                                           -
        '-                               Written On: 02/21/2016                                             -
        '----------------------------------------------------------------------------------------------------
        '- Subprogram Purpose:                                                                              -
        '-                                                                                                  -
        '- This subroutine is called whenever the user inputs a keypboard press into this textbox. It will  -
        '- check to see if the input is valid, and will allow it if it passes the desired conditions.       -
        '----------------------------------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                                                       -
        '- sender – Identifies which particular control raised the                                          –
        '-          click event                                                                             - 
        '- e – Holds the KeyPressEventArgs object sent to the routine                                       -
        '----------------------------------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                                                      -
        '- strText - string variable that holds the text that already exists in the textbox                 -
        '----------------------------------------------------------------------------------------------------
        Dim strText As String = ActiveControl.Text
        If Not strText.Contains(".") Then
            If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Asc(e.KeyChar) = 8 Then
                e.Handled = True
            End If
        Else
            If Not Char.IsNumber(e.KeyChar) AndAlso Not Asc(e.KeyChar) = 8 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtRadius_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRadius.KeyPress
        '----------------------------------------------------------------------------------------------------
        '-                               Subprogram Name: txtRadius_KeyPress                                -
        '----------------------------------------------------------------------------------------------------
        '-                               Written By: Tyler Miller                                           -
        '-                               Written On: 02/21/2016                                             -
        '----------------------------------------------------------------------------------------------------
        '- Subprogram Purpose:                                                                              -
        '-                                                                                                  -
        '- This subroutine is called whenever the user inputs a keypboard press into this textbox. It will  -
        '- check to see if the input is valid, and will allow it if it passes the desired conditions.       -
        '----------------------------------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                                                       -
        '- sender – Identifies which particular control raised the                                          –
        '-          click event                                                                             - 
        '- e – Holds the KeyPressEventArgs object sent to the routine                                       -
        '----------------------------------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                                                      -
        '- strText - string variable that holds the text that already exists in the textbox                 -
        '----------------------------------------------------------------------------------------------------
        Dim strText As String = ActiveControl.Text
        If Not strText.Contains(".") Then
            If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Asc(e.KeyChar) = 8 Then
                e.Handled = True
            End If
        Else
            If Not Char.IsNumber(e.KeyChar) AndAlso Not Asc(e.KeyChar) = 8 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtWidth_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtWidth.KeyPress
        '----------------------------------------------------------------------------------------------------
        '-                               Subprogram Name: txtWidth_KeyPress                                 -
        '----------------------------------------------------------------------------------------------------
        '-                               Written By: Tyler Miller                                           -
        '-                               Written On: 02/21/2016                                             -
        '----------------------------------------------------------------------------------------------------
        '- Subprogram Purpose:                                                                              -
        '-                                                                                                  -
        '- This subroutine is called whenever the user inputs a keypboard press into this textbox. It will  -
        '- check to see if the input is valid, and will allow it if it passes the desired conditions.       -
        '----------------------------------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                                                       -
        '- sender – Identifies which particular control raised the                                          –
        '-          click event                                                                             - 
        '- e – Holds the KeyPressEventArgs object sent to the routine                                       -
        '----------------------------------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                                                      -
        '- strText - string variable that holds the text that already exists in the textbox                 -
        '----------------------------------------------------------------------------------------------------
        Dim strText As String = ActiveControl.Text
        If Not strText.Contains(".") Then
            If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Asc(e.KeyChar) = 8 Then
                e.Handled = True
            End If
        Else
            If Not Char.IsNumber(e.KeyChar) AndAlso Not Asc(e.KeyChar) = 8 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub lstFormula_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstFormula.SelectedIndexChanged
        '----------------------------------------------------------------------------------------------------
        '-                               Subprogram Name: lstFormula_SelectedIndexChanged                   -
        '----------------------------------------------------------------------------------------------------
        '-                               Written By: Tyler Miller                                           -
        '-                               Written On: 02/21/2016                                             -
        '----------------------------------------------------------------------------------------------------
        '- Subprogram Purpose:                                                                              -
        '-                                                                                                  -
        '- This subroutine is called whenever the user selects a different formula from the lstFormual list -
        '- box. It will show the conversions and also make sure they are labels properly, according to the  -
        '- formula and shape.                                                                               -
        '----------------------------------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                                                       -
        '- sender – Identifies which particular control raised the                                          –
        '-          click event                                                                             - 
        '- e – Holds the EventArgs object sent to the routine                                               -
        '----------------------------------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                                                      -
        '- formula - string variable that holds the text from the selected lstFormula list box.             -
        '----------------------------------------------------------------------------------------------------
        txtAnswer.Text = "0"
        lblFinalAnswer.Hide()

        If lstFormula.SelectedIndex >= 0 Then
            Dim formula As String = lstFormula.SelectedItem.ToString
            grpConvertAnswer.Show()
            optInches.Checked = True
            Select Case formula
                Case "Perimeter"
                    optionStandard()
                Case "Area"
                    optionSquared()
                Case "Circumference"
                    optionStandard()
                Case "Volume"
                    optionCubed()
                Case "Surface Area"
                    optionSquared()
            End Select
        End If
    End Sub

    Private Sub optionSquared()
        '----------------------------------------------------------------------------------------------------
        '-                               Subprogram Name: optionSquared()                                   -
        '----------------------------------------------------------------------------------------------------
        '-                               Written By: Tyler Miller                                           -
        '-                               Written On: 02/21/2016                                             -
        '----------------------------------------------------------------------------------------------------
        '- Subprogram Purpose:                                                                              -
        '-                                                                                                  -
        '- This subroutine is called if the selected formula has a squared output. This sub will make sure  -
        '- the radio buttons for the conversions are properly labled and it will also set a value to a strng-
        '- variable that will tell the program how to convert the final answer.                             -
        '----------------------------------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                                                       -
        '- sender – Identifies which particular control raised the                                          –
        '-          click event                                                                             - 
        '- e – Holds the EventArgs object sent to the routine                                               -
        '----------------------------------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                                                      -
        '- (None)                                                                                           -
        '----------------------------------------------------------------------------------------------------
        optInches.Text = "sq.in."
        optCentimeters.Text = "sq.cm."
        strAnswerType = SQUARED
    End Sub

    Private Sub optionCubed()
        '----------------------------------------------------------------------------------------------------
        '-                               Subprogram Name: optionCubed()                                     -
        '----------------------------------------------------------------------------------------------------
        '-                               Written By: Tyler Miller                                           -
        '-                               Written On: 02/21/2016                                             -
        '----------------------------------------------------------------------------------------------------
        '- Subprogram Purpose:                                                                              -
        '-                                                                                                  -
        '- This subroutine is called if the selected formula has a cubed output. This sub will make sure    -  
        '- the radio buttons for the conversions are properly labled and it will also set a value to a strng-
        '- variable that will tell the program how to convert the final answer.                             -
        '----------------------------------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                                                       -
        '- sender – Identifies which particular control raised the                                          –
        '-          click event                                                                             - 
        '- e – Holds the EventArgs object sent to the routine                                               -
        '----------------------------------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                                                      -
        '- (None)                                                                                           -
        '----------------------------------------------------------------------------------------------------
        optInches.Text = "cu.in."
        optCentimeters.Text = "cu.cm."
        strAnswerType = CUBED
    End Sub

    Private Sub optionStandard()
        '----------------------------------------------------------------------------------------------------
        '-                               Subprogram Name: optionStandard()                                   -
        '----------------------------------------------------------------------------------------------------
        '-                               Written By: Tyler Miller                                           -
        '-                               Written On: 02/21/2016                                             -
        '----------------------------------------------------------------------------------------------------
        '- Subprogram Purpose:                                                                              -
        '-                                                                                                  -
        '- This subroutine is called if the selected formula has a standard output. This sub will make sure -  
        '- the radio buttons for the conversions are properly labled and it will also set a value to a strng-
        '- variable that will tell the program how to convert the final answer.                             -
        '----------------------------------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                                                       -
        '- sender – Identifies which particular control raised the                                          –
        '-          click event                                                                             - 
        '- e – Holds the EventArgs object sent to the routine                                               -
        '----------------------------------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                                                      -
        '- (None)                                                                                           -
        '----------------------------------------------------------------------------------------------------
        optInches.Text = "in."
        optCentimeters.Text = "cm."
        strAnswerType = STD
    End Sub

    Private Sub optInches_CheckedChanged(sender As Object, e As EventArgs) Handles optInches.CheckedChanged
        '----------------------------------------------------------------------------------------------------
        '-                               Subprogram Name: optInches_CheckChanged                            -
        '----------------------------------------------------------------------------------------------------
        '-                               Written By: Tyler Miller                                           -
        '-                               Written On: 02/21/2016                                             -
        '----------------------------------------------------------------------------------------------------
        '- Subprogram Purpose:                                                                              -
        '-                                                                                                  -
        '- This subroutine is called when the inches radio button is checked. It will convert the final     -  
        '- answer value to inches and display the output in the txtAnswer textbox.                          -
        '----------------------------------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                                                       -
        '- sender – Identifies which particular control raised the                                          –
        '-          click event                                                                             - 
        '- e – Holds the EventArgs object sent to the routine                                               -
        '----------------------------------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                                                      -
        '- dblAnswer - a double value that stores the txtAnswer calculation for conversion                  -
        '----------------------------------------------------------------------------------------------------
        If optInches.Checked = True Then
            If lstFormula.SelectedIndex >= 0 Then
                If txtAnswer.Text <> Nothing Or txtAnswer.Text <> "" Then
                    Dim dblAnswer As Double = CDbl(txtAnswer.Text)
                    Select Case strAnswerType
                        Case STD
                            txtAnswer.Text = dblAnswer * 0.393701
                        Case SQUARED
                            txtAnswer.Text = dblAnswer * 0.155
                        Case CUBED
                            txtAnswer.Text = dblAnswer * 0.0610237
                    End Select
                End If
            End If
        End If

    End Sub

    Private Sub optCentimeters_CheckedChanged(sender As Object, e As EventArgs) Handles optCentimeters.CheckedChanged
        '----------------------------------------------------------------------------------------------------
        '-                               Subprogram Name: optCentimeters_CheckChanged                       -
        '----------------------------------------------------------------------------------------------------
        '-                               Written By: Tyler Miller                                           -
        '-                               Written On: 02/21/2016                                             -
        '----------------------------------------------------------------------------------------------------
        '- Subprogram Purpose:                                                                              -
        '-                                                                                                  -
        '- This subroutine is called when the centimeter radio button is checked. It will convert the final -  
        '- answer value to inches and display the output in the txtAnswer textbox.                          -
        '----------------------------------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                                                       -
        '- sender – Identifies which particular control raised the                                          –
        '-          click event                                                                             - 
        '- e – Holds the EventArgs object sent to the routine                                               -
        '----------------------------------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                                                      -
        '- dblAnswer - a double value that stores the txtAnswer calculation for conversion                  -
        '----------------------------------------------------------------------------------------------------
        If optCentimeters.Checked = True Then
            If lstFormula.SelectedIndex >= 0 Then
                If txtAnswer.Text <> Nothing Or txtAnswer.Text <> "" Then
                    Dim dblAnswer As Double = CDbl(txtAnswer.Text)
                    Select Case strAnswerType
                        Case STD
                            'Convert in to cm
                            txtAnswer.Text = dblAnswer * 2.54
                        Case SQUARED
                            'Convert sq.in. to sq.cm.
                            txtAnswer.Text = dblAnswer * 6.4516
                        Case CUBED
                            'Convert cu.in. to cu.cm.
                            txtAnswer.Text = dblAnswer * 16.3871
                    End Select
                End If
            End If
        End If
    End Sub
End Class