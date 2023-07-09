Imports MySql.Data.MySqlClient
Imports System.IO


Public Class Form2
    'zone declaration ------------------
    Dim mycmd As New MySqlCommand
    Dim myconnection As New DTconnection
    Dim dadapter As New MySqlDataAdapter
    Dim dtable As New DataTable
    Dim url As String
    Public id11 As Integer = Nothing
    Dim save As String

    'datagrid sub 
    Sub Rgridview()
        mycmd.Connection = myconnection.open
        mycmd.CommandText = "SELECT * FROM `utilisateurs` order by id asc"
        dadapter = New MySqlDataAdapter(mycmd)
        dtable.Rows.Clear()
        dadapter.Fill(dtable)
        If Not dtable Is Nothing AndAlso dtable.Rows.Count > 0 Then
            BunifuDataGridView1.AutoGenerateColumns = False
            BunifuDataGridView1.DataSource = dtable
            BunifuDataGridView1.Columns(0).DataPropertyName = "id"
            BunifuDataGridView1.Columns(1).DataPropertyName = "firstname"
            BunifuDataGridView1.Columns(2).DataPropertyName = "lastname"
            BunifuDataGridView1.Columns(3).DataPropertyName = "email"
            BunifuDataGridView1.Columns(4).DataPropertyName = "droits"
        End If
        myconnection.close()
    End Sub

    Dim vscrollhelper As Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper
    Private Sub GunaLabel3_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub


    Private Sub GunaAdvenceButton8_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton8.Click
        Form1.userrights = 0
        Form1.username = ""
        Form1.userid = 0
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        wlcm.Text = Form1.username
        label2.Text = Form1.username
        Select Case Form1.userrights
            Case 0  'no rights
                buttonusers.Hide()
                buttonmodify.Hide()
                buttoninsert.Hide()
                buttonRead.Hide()
            Case 1   'read only
                buttonusers.Hide()
                buttonmodify.Hide()
                buttoninsert.Hide()
            Case 3  ' read and write 
                buttonusers.Hide()
                buttonmodify.Hide()
            Case 5   ' read , write and modify
                buttonusers.Hide()
            Case 7    ' all acccess ! R,W and M AND also users manag

        End Select


        ' the shadow in the top-panel !
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(Panel3, Color.Black, 20, 5, Guna.UI.WinForms.VerHorAlign.HoriziontalTop)
        ' Scroll-Datagrid bar bro !
        vscrollhelper = New Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper(BunifuDataGridView1, GunaVScrollBar1, True)
        vscrollhelper.UpdateScrollBar()
        'home analytics 
        Dim con As New MySqlConnection
        con.ConnectionString = "server= localhost; database=databasecc; uid = root; pwd=;"
        Dim command9 As MySqlCommand
        Dim reader9 As MySqlDataReader
        Dim i As Integer = 0
        Try
            con.Open()
            Dim query9 As String
            query9 = "SELECT * FROM `utilisateurs` "
            command9 = New MySqlCommand(query9, con)
            reader9 = command9.ExecuteReader
            While reader9.Read
                i = i + 1
            End While
            users1.Text = i
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        i = 0
        Try
            con.Open()
            Dim query9 As String
            query9 = "SELECT * FROM `client` "
            command9 = New MySqlCommand(query9, con)
            reader9 = command9.ExecuteReader
            While reader9.Read
                i = i + 1
            End While
            client1.Text = i
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        i = 0
        Try
            con.Open()
            Dim query9 As String
            query9 = "SELECT * FROM `facture` "
            command9 = New MySqlCommand(query9, con)
            reader9 = command9.ExecuteReader
            While reader9.Read
                i = i + 1
            End While
            bill1.Text = i
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub GunaLinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GunaLinkLabel1.LinkClicked
        Me.Close()
    End Sub

    Private Sub BunifuDataGridView1_Resize(sender As Object, e As EventArgs) Handles BunifuDataGridView1.Resize
        If vscrollhelper IsNot Nothing Then vscrollhelper.UpdateScrollBar()
    End Sub

    


    Private Sub GunaAdvenceButton10_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton10.Click
        Rgridview()
       
    End Sub

    Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs) Handles buttonusers.Click
        Rgridview()
        animation1.HideSync(Panelhome)
        animation1.HideSync(panelinsert)
        animation1.HideSync(panelsearch)
        animation1.HideSync(panelmodify)
        animation1.ShowSync(Panelusers)
    End Sub

    Private Sub GunaAdvenceButton11_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton11.Click
        Dim connect As MySqlConnection = New MySqlConnection("server= localhost; database=databasecc; uid = root; pwd=;")
        Dim cmd As New MySqlCommand
        Dim requete As String
        If Not ID.Text = "NO USER SELECTED" Then
            requete = "DELETE FROM `utilisateurs` WHERE id='" & ID.Text & "'"
            If MessageBox.Show("DO YOU REALLY WANNA DELETE THIS USER ?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.Yes Then
                Try
                    connect.Open()
                    cmd = New MySqlCommand(requete, connect)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("DELETED With Success")
                    Rgridview()
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try

            End If
        Else
            MessageBox.Show("YOU MUST SELECT A USER !", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BunifuDataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuDataGridView1.CellContentClick
        Dim ind As New Integer
        ind = BunifuDataGridView1.CurrentRow.Index.ToString
        ID.Text = BunifuDataGridView1.Rows.Item(ind).Cells.Item(0).Value()
        nom.Text = BunifuDataGridView1.Rows.Item(ind).Cells.Item(1).Value() + " " + BunifuDataGridView1.Rows.Item(ind).Cells.Item(2).Value()
        EMAIL.Text = BunifuDataGridView1.Rows.Item(ind).Cells.Item(3).Value()


    End Sub


    Private Sub GunaAdvenceButton12_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton12.Click
        ' le choix combobox
        Dim rights As New Integer
        Dim connect As MySqlConnection = New MySqlConnection("server= localhost; database=databasecc; uid = root; pwd=;")
        Dim cmd As New MySqlCommand
        Dim requete As String
        If Not ComboBox1.Text = Nothing AndAlso Not ID.Text = "NO USER SELECTED" Then
            If ComboBox1.Text = "READ ONLY" Then
                rights = 1
            ElseIf ComboBox1.Text = "WRITE AND READ" Then
                rights = 3
            ElseIf ComboBox1.Text = "MODIFY, WRITE AND READ" Then
                rights = 5
            ElseIf ComboBox1.Text = "NO RIGHTS" Then
                rights = 0
            ElseIf ComboBox1.Text = "ADMIN" Then
                rights = 7
            End If
            MessageBox.Show(rights)
            requete = " UPDATE `utilisateurs` SET `droits`='" & rights & "' WHERE `id`='" & ID.Text & "'"
            Try
                connect.Open()
                cmd = New MySqlCommand(requete, connect)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Saved With Success")
                Rgridview()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        Else
            MessageBox.Show("NO USER SELECTED")
        End If


    End Sub

    Private Sub GunaAdvenceButton6_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton6.Click
        animation1.HideSync(panelinsert)
        animation1.HideSync(panelsearch)
        animation1.HideSync(Panelusers)
        animation1.HideSync(panelmodify)
        animation1.ShowSync(Panelhome)
    End Sub

    Private Sub GunaAdvenceButton3_Click_1(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.Click
        'SELECT FILE
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()
        If result = DialogResult.OK Then
            'text result
            textbox75.Text = OpenFileDialog1.FileName
            url = OpenFileDialog1.FileName
            ' MessageBox.Show(url)
        End If
    End Sub


    Private Sub buttoninsert_Click(sender As Object, e As EventArgs) Handles buttoninsert.Click
        animation1.HideSync(Panelhome)
        animation1.HideSync(Panelusers)
        animation1.HideSync(panelsearch)
        animation1.HideSync(panelmodify)
        animation1.ShowSync(panelinsert)

    End Sub

    
    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.Click
        textbox6.Text = ""
        textbox61.Text = ""
        textbox62.Text = ""
        textbox63.Text = ""
        textbox65.Text = ""
        textbox66.Text = ""
        textbox67.Text = ""
        textbox68.Text = ""
        textbox7.Text = ""
        textbox71.Text = ""
        textbox73.Text = ""
        textbox75.Text = ""
    End Sub

    
    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        Dim con As New MySqlConnection
        con.ConnectionString = "server= localhost; database=databasecc; uid = root; pwd=;"
        Dim command As MySqlCommand
        Dim reader As MySqlDataReader
        Dim reader1 As MySqlDataReader

        Dim req As String
        If textbox6.Text = Nothing Or textbox61.Text = Nothing Or textbox62.Text = Nothing Then
            MessageBox.Show("NO CLIENT INFORMATIONS DETECTED !")
        ElseIf textbox75.Text = Nothing Then
            MessageBox.Show("NO BILL DETECTED !")
        Else
            Try
                con.Open()
                Dim query As String
                Dim query1 As String
                Dim cmnd As MySqlCommand
                query = "SELECT * FROM `client` WHERE ice='" & textbox61.Text & "'"
                command = New MySqlCommand(query, con)
                reader = command.ExecuteReader

                If reader.HasRows() Then
                    't es pas obligé a saisir client existant !
                    ' insert document c'est tout !
                    Try
                        query1 = "INSERT INTO `facture`(`id`, `type`, `date`, `montant`, `comment`, `url`, `idclient`) VALUES ('','" & textbox7.Text & "','" & textbox73.Value.ToString("yyyy-MM-dd") & "','" & textbox71.Text & "','" & textbox68.Text & "','" & url & "','" & reader.Item("id") & "')"
                        exe_mysql(query1)
                    Catch ex As Exception
                        MessageBox.Show(ex.ToString)
                    End Try
                Else
                    Dim query3 As String
                    Dim con1 As New MySqlConnection
                    Dim id As String
                    id = 2
                    con1.ConnectionString = "server= localhost; database=databasecc; uid = root; pwd=;"
                    'insertion complete !!! dans les deux tables 
                    reader.Close()
                    req = "INSERT INTO `client`(`id`, `name`, `ice`, `adresse`, `reprename`, `tel`, `gsm`, `email`) VALUES ('','" & textbox6.Text & "','" & textbox61.Text & "','" & textbox62.Text & "','" & textbox63.Text & "','" & textbox66.Text & "','" & textbox65.Text & "','" & textbox67.Text & "')"
                    exe_mysql(req)
                    Try
                        con1.Open()
                        query3 = "SELECT id FROM `client` WHERE ice='" & textbox61.Text & "'"
                        cmnd = New MySqlCommand(query3, con1)
                        reader = cmnd.ExecuteReader
                        While reader.Read()
                            id = reader.Item(0)
                        End While
                        query1 = "INSERT INTO `facture`(`id`, `type`, `date`, `montant`, `comment`, `url`, `idclient`) VALUES ('','" & textbox7.Text & "','" & textbox73.Value.ToString("yyyy-MM-dd") & "','" & textbox71.Text & "','" & textbox68.Text & "','" & url & "','" & id & "')"
                        exe_mysql(query1)
                    Catch ex As Exception
                        MessageBox.Show(ex.ToString)
                    End Try
                    con1.Close()

                End If
                con.Close()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try


            'upload the file 
            Try
                Dim filenameName As String()
                filenameName = OpenFileDialog1.FileName.Split()
                File.Copy(OpenFileDialog1.FileName, "upload\" + filenameName(filenameName.Length - 1))
                MessageBox.Show("DATA SAVED AND THE FILE UPLOADED")

                textbox6.Text = ""
                textbox61.Text = ""
                textbox62.Text = ""
                textbox63.Text = ""
                textbox65.Text = ""
                textbox66.Text = ""
                textbox67.Text = ""
                textbox68.Text = ""
                textbox7.ResetText()
                textbox71.Text = ""
                textbox73.ResetText()
                textbox75.Text = ""
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        End If

    End Sub

  
   
    Private Sub buttonRead_Click(sender As Object, e As EventArgs) Handles buttonRead.Click

        '-----------------------
       
        myconnection.close()
        animation1.HideSync(Panelhome)
        animation1.HideSync(panelinsert)
        animation1.HideSync(Panelusers)
        animation1.HideSync(panelmodify)
        animation1.ShowSync(panelsearch)

    End Sub


    Private Sub radioclient_Click(sender As Object, e As EventArgs) Handles radioclient.Click

        Dim mycmd As New MySqlCommand
        Dim myconnection As New DTconnection
        Dim dadapter As New MySqlDataAdapter
        Dim dtable As New DataTable
        'datagrid sub 
        mycmd.Connection = myconnection.open
        mycmd.CommandText = "SELECT * FROM `client` order by id asc"
        dadapter = New MySqlDataAdapter(mycmd)
        dtable.Rows.Clear()
        dadapter.Fill(dtable)
        If Not dtable Is Nothing AndAlso dtable.Rows.Count > 0 Then
            datagridclient.AutoGenerateColumns = False
            datagridclient.DataSource = dtable
            datagridclient.Columns(0).DataPropertyName = "id"
            datagridclient.Columns(1).DataPropertyName = "name"
            datagridclient.Columns(2).DataPropertyName = "ice"
            datagridclient.Columns(3).DataPropertyName = "adresse"
            datagridclient.Columns(4).DataPropertyName = "reprename"
            datagridclient.Columns(5).DataPropertyName = "tel"
            datagridclient.Columns(6).DataPropertyName = "gsm"
            datagridclient.Columns(7).DataPropertyName = "email"
        End If
        myconnection.close()
        animation1.HideSync(panelradiobill)
        animation1.ShowSync(panelradioclient)

    End Sub

    Private Sub radiobill_Click(sender As Object, e As EventArgs) Handles radiobill.Click
        Dim mycmd As New MySqlCommand
        Dim myconnection As New DTconnection
        Dim dadapter As New MySqlDataAdapter
        Dim dtable As New DataTable
        'datagrid sub 
        Try
            mycmd.Connection = myconnection.open
            mycmd.CommandText = "SELECT * FROM `facture` inner join `client` on facture.idclient = client.id"
            dadapter = New MySqlDataAdapter(mycmd)
            dtable.Rows.Clear()
            dadapter.Fill(dtable)
            If Not dtable Is Nothing AndAlso dtable.Rows.Count > 0 Then
                GunaDataGrid1.AutoGenerateColumns = False
                GunaDataGrid1.DataSource = dtable
                GunaDataGrid1.Columns(0).DataPropertyName = "id"
                GunaDataGrid1.Columns(1).DataPropertyName = "type"
                GunaDataGrid1.Columns(2).DataPropertyName = "date"
                GunaDataGrid1.Columns(3).DataPropertyName = "montant"
                GunaDataGrid1.Columns(4).DataPropertyName = "comment"
                GunaDataGrid1.Columns(5).DataPropertyName = "url"
                GunaDataGrid1.Columns(6).DataPropertyName = "name"
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        animation1.HideSync(panelradioclient)
        animation1.ShowSync(panelradiobill)
    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        Dim mycmd As New MySqlCommand
        Dim myconnection As New DTconnection
        Dim dadapter As New MySqlDataAdapter
        Dim dtable As New DataTable
        'datagrid sub 
        mycmd.Connection = myconnection.open
        mycmd.CommandText = "SELECT * FROM `client` WHERE ice = '" & searchclient.Text & "' or name =  '" & searchclient.Text & "'"
        dadapter = New MySqlDataAdapter(mycmd)
        dtable.Rows.Clear()
        dadapter.Fill(dtable)
        If Not dtable Is Nothing AndAlso dtable.Rows.Count > 0 Then
            datagridclient.AutoGenerateColumns = False
            datagridclient.DataSource = dtable
            datagridclient.Columns(0).DataPropertyName = "id"
            datagridclient.Columns(1).DataPropertyName = "name"
            datagridclient.Columns(2).DataPropertyName = "ice"
            datagridclient.Columns(3).DataPropertyName = "adresse"
            datagridclient.Columns(4).DataPropertyName = "reprename"
            datagridclient.Columns(5).DataPropertyName = "tel"
            datagridclient.Columns(6).DataPropertyName = "gsm"
            datagridclient.Columns(7).DataPropertyName = "email"
        End If
        myconnection.close()
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Dim mycmd As New MySqlCommand
        Dim myconnection As New DTconnection
        Dim dadapter As New MySqlDataAdapter
        Dim dtable As New DataTable
        'datagrid sub 
        Try
            mycmd.Connection = myconnection.open
            mycmd.CommandText = "SELECT * FROM `facture`inner join `client` on facture.idclient = client.id WHERE name = '" & searchbox.Text & "'"
            dadapter = New MySqlDataAdapter(mycmd)
            dtable.Rows.Clear()
            dadapter.Fill(dtable)
            If Not dtable Is Nothing AndAlso dtable.Rows.Count > 0 Then
                GunaDataGrid1.AutoGenerateColumns = False
                GunaDataGrid1.DataSource = dtable
                GunaDataGrid1.Columns(0).DataPropertyName = "id"
                GunaDataGrid1.Columns(1).DataPropertyName = "type"
                GunaDataGrid1.Columns(2).DataPropertyName = "date"
                GunaDataGrid1.Columns(3).DataPropertyName = "montant"
                GunaDataGrid1.Columns(4).DataPropertyName = "comment"
                GunaDataGrid1.Columns(5).DataPropertyName = "url"
                GunaDataGrid1.Columns(6).DataPropertyName = "name"
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        myconnection.close()
    End Sub

    Private Sub buttonmodify_Click(sender As Object, e As EventArgs) Handles buttonmodify.Click
        animation1.HideSync(Panelhome)
        animation1.HideSync(Panelusers)
        animation1.HideSync(panelsearch)
        animation1.HideSync(panelinsert)
        animation1.ShowSync(panelmodify)

    End Sub


    Private Sub GunaDataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GunaDataGridView2.CellContentClick
        Dim ind As New Integer
        ind = GunaDataGridView2.CurrentRow.Index.ToString
        id11 = GunaDataGridView2.Rows.Item(ind).Cells.Item(0).Value()
        name1.Text = GunaDataGridView2.Rows.Item(ind).Cells.Item(1).Value()
        ice1.Text = GunaDataGridView2.Rows.Item(ind).Cells.Item(2).Value()
        adresse1.Text = GunaDataGridView2.Rows.Item(ind).Cells.Item(3).Value()
        reprename1.Text = GunaDataGridView2.Rows.Item(ind).Cells.Item(4).Value()
        tel1.Text = GunaDataGridView2.Rows.Item(ind).Cells.Item(5).Value()
        gsm1.Text = GunaDataGridView2.Rows.Item(ind).Cells.Item(6).Value()
        email1.Text = GunaDataGridView2.Rows.Item(ind).Cells.Item(7).Value()
        save = "UPDATE `client` SET `name`='" & name1.Text & "',`ice`='" & ice1.Text & "',`adresse`='" & adresse1.Text & "',`reprename`='" & reprename1.Text & "',`tel`='" & tel1.Text & "',`gsm`='" & gsm1.Text & "',`email`='" & email1.Text & "' WHERE id='" & id11 & "'"
    End Sub

    Private Sub GunaButton4_Click(sender As Object, e As EventArgs) Handles GunaButton4.Click
        If Not id11 = Nothing Then
            If MessageBox.Show("DO YOU REALLY WANNA DELETE THIS Client and all the Bill related ?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.Yes Then

                exe_mysql("DELETE FROM facture WHERE idclient='" & id11 & "'")
                exe_mysql("DELETE FROM client WHERE id='" & id11 & "'")
            End If
        Else
            MessageBox.Show("no client selected !")
        End If
        Dim mycmd As New MySqlCommand
        Dim myconnection As New DTconnection
        Dim dadapter As New MySqlDataAdapter
        Dim dtable As New DataTable
        'datagrid sub 
        mycmd.Connection = myconnection.open
        mycmd.CommandText = "SELECT * FROM `client` order by id asc"
        dadapter = New MySqlDataAdapter(mycmd)
        dtable.Rows.Clear()
        dadapter.Fill(dtable)
        If Not dtable Is Nothing AndAlso dtable.Rows.Count > 0 Then
            GunaDataGridView2.AutoGenerateColumns = False
            GunaDataGridView2.DataSource = dtable
            GunaDataGridView2.Columns(0).DataPropertyName = "id"
            GunaDataGridView2.Columns(1).DataPropertyName = "name"
            GunaDataGridView2.Columns(2).DataPropertyName = "ice"
            GunaDataGridView2.Columns(3).DataPropertyName = "adresse"
            GunaDataGridView2.Columns(4).DataPropertyName = "reprename"
            GunaDataGridView2.Columns(5).DataPropertyName = "tel"
            GunaDataGridView2.Columns(6).DataPropertyName = "gsm"
            GunaDataGridView2.Columns(7).DataPropertyName = "email"
        End If
        myconnection.close()
    End Sub

    Private Sub GunaButton3_Click(sender As Object, e As EventArgs) Handles GunaButton3.Click
        If Not id11 = Nothing Then
            exe_mysql(save)
            MessageBox.Show("saved ")
        Else
            MessageBox.Show("no client selected")
        End If
        Dim mycmd As New MySqlCommand
        Dim myconnection As New DTconnection
        Dim dadapter As New MySqlDataAdapter
        Dim dtable As New DataTable
        'datagrid sub 
        mycmd.Connection = myconnection.open
        mycmd.CommandText = "SELECT * FROM `client` order by id asc"
        dadapter = New MySqlDataAdapter(mycmd)
        dtable.Rows.Clear()
        dadapter.Fill(dtable)
        If Not dtable Is Nothing AndAlso dtable.Rows.Count > 0 Then
            GunaDataGridView2.AutoGenerateColumns = False
            GunaDataGridView2.DataSource = dtable
            GunaDataGridView2.Columns(0).DataPropertyName = "id"
            GunaDataGridView2.Columns(1).DataPropertyName = "name"
            GunaDataGridView2.Columns(2).DataPropertyName = "ice"
            GunaDataGridView2.Columns(3).DataPropertyName = "adresse"
            GunaDataGridView2.Columns(4).DataPropertyName = "reprename"
            GunaDataGridView2.Columns(5).DataPropertyName = "tel"
            GunaDataGridView2.Columns(6).DataPropertyName = "gsm"
            GunaDataGridView2.Columns(7).DataPropertyName = "email"
        End If
        myconnection.close()
    End Sub




    Private Sub Radiomodifybill_CheckedChanged(sender As Object, e As EventArgs) Handles Radiomodifybill.CheckedChanged
        Dim mycmd As New MySqlCommand
        Dim myconnection As New DTconnection
        Dim dadapter As New MySqlDataAdapter
        Dim dtable As New DataTable
        'datagrid sub 
        Try
            mycmd.Connection = myconnection.open
            mycmd.CommandText = "SELECT * FROM `facture` inner join `client` on facture.idclient = client.id"
            dadapter = New MySqlDataAdapter(mycmd)
            dtable.Rows.Clear()
            dadapter.Fill(dtable)
            GunaDataGrid1.AutoGenerateColumns = False
            GunaDataGrid1.DataSource = dtable
            GunaDataGrid1.Columns(0).DataPropertyName = "id"
            GunaDataGrid1.Columns(1).DataPropertyName = "type"
            GunaDataGrid1.Columns(2).DataPropertyName = "date"
            GunaDataGrid1.Columns(3).DataPropertyName = "montant"
            GunaDataGrid1.Columns(4).DataPropertyName = "comment"
            GunaDataGrid1.Columns(5).DataPropertyName = "url"
            GunaDataGrid1.Columns(6).DataPropertyName = "name"
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        ' animation1.HideSync(panelmodifybill)
        animation1.HideSync(panelmodifyclient)
    End Sub

    Private Sub RadiomodifyClient_CheckedChanged(sender As Object, e As EventArgs) Handles RadiomodifyClient.CheckedChanged
        Dim mycmd As New MySqlCommand
        Dim myconnection As New DTconnection
        Dim dadapter As New MySqlDataAdapter
        Dim dtable As New DataTable
        'datagrid sub 
        mycmd.Connection = myconnection.open
        mycmd.CommandText = "SELECT * FROM `client` order by id asc"
        dadapter = New MySqlDataAdapter(mycmd)
        dtable.Rows.Clear()
        dadapter.Fill(dtable)
        If Not dtable Is Nothing AndAlso dtable.Rows.Count > 0 Then
            GunaDataGridView2.AutoGenerateColumns = False
            GunaDataGridView2.DataSource = dtable
            GunaDataGridView2.Columns(0).DataPropertyName = "id"
            GunaDataGridView2.Columns(1).DataPropertyName = "name"
            GunaDataGridView2.Columns(2).DataPropertyName = "ice"
            GunaDataGridView2.Columns(3).DataPropertyName = "adresse"
            GunaDataGridView2.Columns(4).DataPropertyName = "reprename"
            GunaDataGridView2.Columns(5).DataPropertyName = "tel"
            GunaDataGridView2.Columns(6).DataPropertyName = "gsm"
            GunaDataGridView2.Columns(7).DataPropertyName = "email"
        End If
        myconnection.close()
        ' animation1.HideSync(panelmodifybill)
        animation1.ShowSync(panelmodifyclient)
    End Sub

    Private Sub GunaButton5_Click(sender As Object, e As EventArgs) Handles GunaButton5.Click
        ' Process.Start(GunaDataGrid1.CurrentRow. )
    End Sub
End Class