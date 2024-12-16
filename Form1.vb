Imports System.Windows.Forms

Public Class Form1

    Dim computerName As String = Environment.MachineName
    Dim COMMANDOUT As String = "{}"

    Public Function LOGOUTPUT() As String
        OUTPUT.Text = COMMANDOUT
        Console.WriteLine(COMMANDOUT)
    End Function
    Public Function CMDNAMEOUT(s As String) As String
        COMMANDNAME.Text = s
    End Function

    Public Sub COMPUTECOMMAND(value)
        If value.StartsWith("ALERTBOX ") Then
            CMDNAMEOUT("ALERTBOX")
            Dim alertMessage As String = value.Substring(9) ' Extract the message after "ALERTBOX "

            COMMANDOUT = "MSGBOX::STRING > " & alertMessage
            LOGOUTPUT() 'Logs to Console+O/P Label

            MessageBox.Show(alertMessage)
        End If
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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class