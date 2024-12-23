Imports System.Windows.Forms

Public Class Form1

    ' DuckVM
    ' By: UltimateQuack, 2024
    ' Please check my GitHub to more info!

    ''' <summary>
    ''' VARIABLES, ETC.
    ''' </summary>

    ' Eviroment vars system
    ' https://stackoverflow.com/a/13726946/26411616
    Dim ENV_VARS As New Dictionary(Of String, Integer)()

    Dim computerName As String = Environment.MachineName
    Dim COMMANDOUT As String = "{}"

    Public Function LOGOUTPUT(DUAL As String) As String
        If DUAL = Not "false" Then
            OUTPUT.Text = COMMANDOUT
            Console.WriteLine(COMMANDOUT)
            ' system that shows an dialog, user type and then the var gets defined to the result
        End If

    End Function
    Public Function CMDNAMEOUT(s As String) As String
        COMMANDNAME.Text = s
    End Function

    Public Sub COMPUTECOMMAND(value)
        ' COMMAND: ALERTBOX
        ' DOES: Display an message, using MessageBox.Show
        If value.StartsWith("ALERTBOX ") Then
            CMDNAMEOUT("ALERTBOX")
            Dim alertMessage As String = value.Substring(9) ' Extract the message after "ALERTBOX "

            COMMANDOUT = "MSGBOX::STRING > " & alertMessage
            LOGOUTPUT("false") 'Logs to Console+O/P Label

            MessageBox.Show(alertMessage)
        End If

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ' "META"-LIKE COMMANDS, NORMALLY MODIFYING THE DUCKVM ITSELF


        If value.StartsWith("DUCKVM_QUIT") Then

            ' COMMAND: DUCKVM_QUIT
            ' DOES: Quit current DuckVM instance

            CMDNAMEOUT("DUCKVM_QUIT")

            COMMANDOUT = "DUCKVM_QUIT"
            LOGOUTPUT("false") 'Logs to Console+O/P Label

            Application.Exit()
        End If


        '''If value.StartsWith("CREATEVAR ") Then
        ' COMMAND: CREATEVAR
        ' DOES: Create an variable with NULL (vbNull) value WIP
        '''Dim VAR_VALUE As String = value.Substring(10)
        '''CMDNAMEOUT("CREATEVAR")
        '''COMMANDOUT = "CREATEVAR::VAR > " & VAR_VALUE
        '''LOGOUTPUT("false") 'Logs to Console+O/P Label
        '''ENV_VARS(VAR_VALUE) = vbNull ' define as null first
        '''End If
        '''If value.StartsWith("EDITVAR ") Then
        ' COMMAND: CREATEVAR
        ' DOES: Create an variable with NULL (vbNull) value WIP
        '''Dim VAR_VALUE As String = value.Substring(8)
        '''CMDNAMEOUT("EDITVAR")
        '''COMMANDOUT = "EDITVAR::VAR > " & VAR_VALUE
        '''LOGOUTPUT("1") 'Logs to Console+O/P Label
        '''ENV_VARS(VAR_VALUE) = vbNull ' define as null first
        '''End If

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    End Sub


    Public Sub SUBMIT()
        'If e.KeyCode = Keys.Enter Then
        Dim userInput As String = TextBox1.Text

        COMPUTECOMMAND(userInput)
        INPUT.Text = "> [" & computerName & "]:" & userInput
        'TextBox1.Text = ""  ' Clear the textbox
        'End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Focus()
    End Sub

    Private Sub ENTER_Click(sender As Object, e As EventArgs) Handles ENTER.Click
        SUBMIT()
    End Sub

End Class