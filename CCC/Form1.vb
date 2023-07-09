Imports MySql.Data.MySqlClient
Public Class Form1
    ' zone declare
    Private con As MySqlConnection = New MySqlConnection("server= localhost; database=databasecc; uid = root; pwd=;")
    Dim requete As String
    Dim desNumeros() As Char = {">", " ", "<", "'", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "@", ".", "&", "(", "-", "_", ")", "=", "~", "#", "{", "[", "|", "`", "\", "^", "]", "}", "*", ",", ";", ":", "!", "$", "^", "§", "/", ".", "?", "%", "µ", "¨"}

    '        global var for the next movr
    Public userid As Integer
    Public username As String
    Public userrights As Integer

    ' function hash 

    Public Function SHA512(ByVal hach As String) As String
        Dim ObjImplSerCry As New Security.Cryptography.SHA512CryptoServiceProvider
        Dim bytestring() As Byte = System.Text.Encoding.ASCII.GetBytes(hach)
        bytestring = ObjImplSerCry.ComputeHash(bytestring)
        Dim finalstring As String = Nothing
        For Each bt As Byte In bytestring
            finalstring &= bt.ToString()
        Next
        Return finalstring
    End Function

    Function validEmail(ByVal s As String) As Boolean
        Try
            Dim a As New System.Net.Mail.MailAddress(s)
        Catch
            Return False
        End Try
        Return True
    End Function
    'Sign in ******************************************************************
    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        ErrorProvider1.Clear()
        Timer1.Start()
        If Not String.IsNullOrWhiteSpace(Textbox1.Text) AndAlso Not String.IsNullOrWhiteSpace(Textbox2.Text) AndAlso Not String.IsNullOrWhiteSpace(Textbox3.Text) AndAlso Not String.IsNullOrWhiteSpace(Textbox4.Text) AndAlso Not String.IsNullOrWhiteSpace(Textbox5.Text) AndAlso CheckBoxcreate.Checked = True AndAlso validEmail(Textbox3.Text) AndAlso Not Textbox5.Text.Length < 8 AndAlso Not Textbox4.Text.Length < 8 AndAlso Textbox5.Text = Textbox4.Text Then

            ' requete = "SELECT * FROM utilisateurs WHERE email=" + Textbox3.Text
            ' Dim cmd As New MySqlCommand(requete, con)
            con = New MySqlConnection
            con.ConnectionString = "server= localhost; database=databasecc; uid = root; pwd=;"
            Dim command1 As MySqlCommand
            Dim reader1 As MySqlDataReader
            Dim count1 As Integer
            count1 = 0
            Try
                con.Open()
                Dim query1 As String
                query1 = "SELECT email FROM `utilisateurs` WHERE email='" & Textbox3.Text & "'"
                command1 = New MySqlCommand(query1, con)
                reader1 = command1.ExecuteReader
                While reader1.Read
                    count1 = count1 + 1
                End While
                If Not count1 = 0 Then
                    ErrorProvider1.SetError(Textbox3, "this Email is already used !")
                    con.Close()
                End If
                con.Close()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try

            If count1 = 0 Then
                requete = "INSERT INTO `utilisateurs`(`id`, `firstname`, `pwd`, `droits`, `lastname`, `email`) VALUES ('','" & Textbox2.Text & "','" & SHA512(Textbox4.Text) & "','0','" & Textbox1.Text & "','" & Textbox3.Text & "')"
                exe_mysql(requete)
                MessageBox.Show("Your Account is Created successfully, Go and Login")
                ErrorProvider1.Clear()
                Timer1.Stop()
            End If
        End If
    End Sub

    Private Sub GunaLinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GunaLinkLabel2.LinkClicked
        Me.Close()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Textbox1.Text = "" Then
            ErrorProvider1.SetError(Textbox1, "empty field")
        End If

        If Textbox2.Text = "" Then
            ErrorProvider1.SetError(Textbox2, "empty field")
        End If

        If Textbox3.Text = "" Then
            ErrorProvider1.SetError(Textbox3, "empty field")
        ElseIf Not validEmail(Textbox3.Text) Then
            ErrorProvider1.SetError(Textbox3, "Please Entre a Valid Email !")

        End If

        If Textbox4.Text = "" Then
            ErrorProvider1.SetError(Textbox4, "empty field")
        ElseIf Textbox4.Text.Length < 8 Then
            ErrorProvider1.SetError(Textbox4, "Too short for a Password ! At least 8 characters")
        End If

        If Textbox5.Text = "" Then
            ErrorProvider1.SetError(Textbox5, "empty field")
       
        ElseIf Not Textbox5.Text = Textbox4.Text Then
            ErrorProvider1.SetError(Textbox5, "Your Conformation-password is incorrect !")

        ElseIf Textbox5.Text.Length < 8 Then
            ErrorProvider1.SetError(Textbox5, "Too short for a Password ! At least 8 characters")
        End If

        If CheckBoxcreate.Checked = False Then
            ErrorProvider1.SetError(CheckBoxcreate, "Unchecked")
        End If

    End Sub

    Private Sub Textbox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Textbox1.KeyPress
        If desNumeros.Contains(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Textbox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Textbox2.KeyPress
        If desNumeros.Contains(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub checkboxPasswordCreate_CheckedChanged_1(sender As Object, e As EventArgs) Handles checkboxPasswordCreate.CheckedChanged
        If checkboxPasswordCreate.Checked = True Then
            Textbox4.isPassword = False
            Textbox5.isPassword = False
        Else
            Textbox4.isPassword = True
            Textbox5.isPassword = True
        End If
    End Sub

    Private Sub GunaLinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GunaLinkLabel4.LinkClicked
        anima1.HideSync(Panel3)
        anima1.ShowSync(Panel2)
    End Sub

    Private Sub GunaLinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GunaLinkLabel1.LinkClicked
        anima1.HideSync(Panel2)
        anima1.ShowSync(Panel3)
    End Sub

    'log in ******************************************************************

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If String.IsNullOrWhiteSpace(textbox7.Text) Then
            ErrorProvider1.SetError(textbox7, "empty field")
        End If

        If textbox6.Text = "" Then
            ErrorProvider1.SetError(textbox6, "empty field")
        ElseIf Not validEmail(textbox6.Text) Then
            ErrorProvider1.SetError(textbox6, "Please Entre a Valid Email !")
        End If
    End Sub

    Private Sub GunaButton2_Click_1(sender As Object, e As EventArgs) Handles GunaButton2.Click
        ErrorProvider2.Clear()
        Timer2.Start()
        If Not String.IsNullOrWhiteSpace(textbox6.Text) AndAlso Not String.IsNullOrWhiteSpace(textbox7.Text) AndAlso validEmail(textbox6.Text) Then
            con = New MySqlConnection
            con.ConnectionString = "server= localhost; database=databasecc; uid = root; pwd=;"
            Dim command As MySqlCommand
            Dim reader As MySqlDataReader

            Try
                con.Open()
                Dim query As String
                query = "SELECT * FROM `utilisateurs` WHERE email='" & textbox6.Text & "' AND pwd='" & SHA512(textbox7.Text) & "'"
                command = New MySqlCommand(query, con)
                reader = command.ExecuteReader

                If reader.Read Then
                    userid = reader.Item("id")
                    username = reader.Item("firstname") + " " + reader.Item("lastname")
                    userRights = reader.Item("droits")
                    'count = count + 1
                    '  End While
                    '   If count = 1 Then
                    MessageBox.Show("Welcom")
                    Me.Hide()
                    Form2.Show()
                    con.Close()

                Else
                    label4.Text = "The Email or The Password is incorrecte"
                    con.Close()

                End If
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
        End Try
        End If
    End Sub

    Private Sub GunaLinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GunaLinkLabel3.LinkClicked
        Me.Close()
    End Sub

  

    Private Sub GunaCheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles GunaCheckBox1.CheckedChanged
        If GunaCheckBox1.Checked = True Then
            textbox7.isPassword = False
        Else
            textbox7.isPassword = True
        End If
    End Sub

    Private Sub textbox6_OnValueChanged(sender As Object, e As EventArgs) Handles textbox6.OnValueChanged

    End Sub
End Class
