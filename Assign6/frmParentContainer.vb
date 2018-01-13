Imports System.ComponentModel

'Declaring public counter variable accessible through all forms
Public Module GlobalCount
    Public intFormCount As Integer = 0
End Module

Public Class frmParentContainer
    '-----------------------------------------------------------------------------------------------------
    '-                                          File Name : frmParentContainer                           - 
    '-                                          Part of Project: Assign6                                 -
    '-----------------------------------------------------------------------------------------------------
    '-                                          Written By: Tyler Miller                                 -
    '-                                          Written On: 02/20/2016                                   -
    '-----------------------------------------------------------------------------------------------------
    '- File Purpose:                                                                                     -
    '- This file is the main parent form that loads when the user starts the application. It has the     -
    '- various button commands and handles that are associated with the main MDI parent form.            - 
    '-----------------------------------------------------------------------------------------------------
    '- Program Purpose:                                                                                  -
    '-                                                                                                   -
    '- This program is designed to be an MDI form that allows for multiple instances of a calculator to  -
    '- run and function from within it during its execution. If any of the forms have a calculated answer-
    '- the program will promt the user upon exit, asking if they are sure they'd like to quit. The calc  -
    '- has predefined calculations for various geometric shapes.                                         - 
    '-----------------------------------------------------------------------------------------------------
    '- Global Variable Dictionary (alphabetically):                                                      -
    '- intFormCount - integer that holds the number of forms that are open during the programs runtime   –
    '-----------------------------------------------------------------------------------------------------
    Private Sub mnuNew_Click(sender As Object, e As EventArgs) Handles mnuNew.Click
        '----------------------------------------------------------------------------------------------------
        '-                               Subprogram Name: mnuNew_Click                                      -
        '----------------------------------------------------------------------------------------------------
        '-                               Written By: Tyler Miller                                           -
        '-                               Written On: 02/21/2016                                             -
        '----------------------------------------------------------------------------------------------------
        '- Subprogram Purpose:                                                                              -
        '-                                                                                                  -
        '- This subroutine is called when the user clicks the new button in the File dropdown menu in the   -
        '- menu control. It will create a new window/form and a new instance of the calculator application  -
        '----------------------------------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                                                       -
        '- sender – Identifies which particular control raised the                                          –
        '-          click event                                                                             - 
        '- e – Holds the EventArgs object sent to the routine                                               -
        '----------------------------------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                                                      -
        '- calcChildForm - a form that will be a new instance of the calculator application.                -
        '----------------------------------------------------------------------------------------------------
        Dim calcChildForm As New mdiCalculator

        GlobalCount.intFormCount += 1
        calcChildForm.Text = "Calculator " & GlobalCount.intFormCount

        'Attaching the child to the parent
        calcChildForm.MdiParent = Me

        'Shwo the child form
        calcChildForm.Show()
    End Sub

    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        '----------------------------------------------------------------------------------------------------
        '-                               Subprogram Name: mnuAbout_Click                                    -
        '----------------------------------------------------------------------------------------------------
        '-                               Written By: Tyler Miller                                           -
        '-                               Written On: 02/21/2016                                             -
        '----------------------------------------------------------------------------------------------------
        '- Subprogram Purpose:                                                                              -
        '-                                                                                                  -
        '- This subroutine is called when the user clicks the About button in the Help dropdown menu in the -
        '- menu control. It will show a standard about box with a descprition of the program.               -
        '----------------------------------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                                                       -
        '- sender – Identifies which particular control raised the                                          –
        '-          click event                                                                             - 
        '- e – Holds the EventArgs object sent to the routine                                               -
        '----------------------------------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                                                      -
        '- (None)                                                                                           -
        '----------------------------------------------------------------------------------------------------
        frmAbout.ShowDialog()
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        '----------------------------------------------------------------------------------------------------
        '-                               Subprogram Name: mnuExit_Click                                     -
        '----------------------------------------------------------------------------------------------------
        '-                               Written By: Tyler Miller                                           -
        '-                               Written On: 02/21/2016                                             -
        '----------------------------------------------------------------------------------------------------
        '- Subprogram Purpose:                                                                              -
        '-                                                                                                  -
        '- This subroutine is called when the user clicks the Exit button in the File dropdown menu in the  -
        '- menu control. It will execute all children form's closing procedures and then close the parent   -
        '- form.                                                                                            -
        '----------------------------------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                                                       -
        '- sender – Identifies which particular control raised the                                          –
        '-          click event                                                                             - 
        '- e – Holds the EventArgs object sent to the routine                                               -
        '----------------------------------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                                                      -
        '- (None)                                                                                           -
        '----------------------------------------------------------------------------------------------------
        Me.Close()
    End Sub

    Private Sub mnuCascade_Click(sender As Object, e As EventArgs) Handles mnuCascade.Click
        '----------------------------------------------------------------------------------------------------
        '-                               Subprogram Name: mnuCascade_Click                                  -
        '----------------------------------------------------------------------------------------------------
        '-                               Written By: Tyler Miller                                           -
        '-                               Written On: 02/21/2016                                             -
        '----------------------------------------------------------------------------------------------------
        '- Subprogram Purpose:                                                                              -
        '-                                                                                                  -
        '- This subroutine is called when the user clicks the Cascade button in the Window dropdown menu in -
        '- the menu control. It will cascade all currently opened forms within the parent form.             -
        '----------------------------------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                                                       -
        '- sender – Identifies which particular control raised the                                          –
        '-          click event                                                                             - 
        '- e – Holds the EventArgs object sent to the routine                                               -
        '----------------------------------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                                                      -
        '- (None)                                                                                           -
        '----------------------------------------------------------------------------------------------------
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub mnuVertical_Click(sender As Object, e As EventArgs) Handles mnuVertical.Click
        '----------------------------------------------------------------------------------------------------
        '-                               Subprogram Name: mnuVertical_Click                                 -
        '----------------------------------------------------------------------------------------------------
        '-                               Written By: Tyler Miller                                           -
        '-                               Written On: 02/21/2016                                             -
        '----------------------------------------------------------------------------------------------------
        '- Subprogram Purpose:                                                                              -
        '-                                                                                                  -
        '- This subroutine is called when the user clicks the Vertical btn from the Tile menu in            -
        '- the menu control. It will virtically align all currently opened forms within the parent form.    -
        '----------------------------------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                                                       -
        '- sender – Identifies which particular control raised the                                          –
        '-          click event                                                                             - 
        '- e – Holds the EventArgs object sent to the routine                                               -
        '----------------------------------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                                                      -
        '- (None)                                                                                           -
        '----------------------------------------------------------------------------------------------------
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub mnuHorizontal_Click(sender As Object, e As EventArgs) Handles mnuHorizontal.Click
        '----------------------------------------------------------------------------------------------------
        '-                               Subprogram Name: mnuHorizontal_Click                               -
        '----------------------------------------------------------------------------------------------------
        '-                               Written By: Tyler Miller                                           -
        '-                               Written On: 02/21/2016                                             -
        '----------------------------------------------------------------------------------------------------
        '- Subprogram Purpose:                                                                              -
        '-                                                                                                  -
        '- This subroutine is called when the user clicks the Horizontal button from the Tile menu in       -
        '- the menu control. It will virtically align all currently opened forms within the parent form.    -
        '----------------------------------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                                                       -
        '- sender – Identifies which particular control raised the                                          –
        '-          click event                                                                             - 
        '- e – Holds the EventArgs object sent to the routine                                               -
        '----------------------------------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                                                      -
        '- (None)                                                                                           -
        '----------------------------------------------------------------------------------------------------
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub frmParentContainer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '------------------------------------------------------------------------------
        '-                Subprogram Name: frmParentContainer_Load                    -
        '------------------------------------------------------------------------------
        '-                Written By: Tyler Miller                                    -
        '-                Written On: 2/20/2016                                       -   
        '------------------------------------------------------------------------------
        '- Subprogram Purpose:                                                        -
        '-                                                                            -
        '- This subroutine is called as the program is loaded. This will adjust the   -
        '- form to fit in the center of the screen.                                   -
        '------------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                                 -
        '- sender – Identifies which particular control raised the                    –
        '-          click event                                                       - 
        '- e – Holds the EventArgs object sent to the routine                         -
        '------------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                                -
        '- X,Y,mainScreen - These variables are used to to find the width and height  -
        '-   of the screen and then position the screen in the center.                -
        '------------------------------------------------------------------------------
        'Centering Form to Screen
        Dim mainScreen As Screen = Screen.FromPoint(Me.Location)
        Dim X As Integer = (mainScreen.WorkingArea.Width - Me.Width) / 2 + mainScreen.WorkingArea.Left
        Dim Y As Integer = (mainScreen.WorkingArea.Height - Me.Height) / 2 + mainScreen.WorkingArea.Top

        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New System.Drawing.Point(X, Y)
    End Sub
End Class
