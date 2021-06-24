Imports System.Data.SQLite

Module DatabaseQueries
    Dim db As SQLiteConnection
    Dim command As SQLiteCommand
    Dim reader As SQLiteDataReader

    Public Sub Home()
        MainForm.pnlhome.BringToFront()
        MainForm.pnlhome.Dock = DockStyle.Fill
        MainForm.homebtn.Checked = True
    End Sub

    Public Sub Recieptpanel()
        'mainapp.pnlreceipt.BringToFront()
        'mainapp.pnlreceipt.Dock = DockStyle.Fill
        'mainapp.btnreceiptpanel.Checked = True
    End Sub

    Public Sub DataGriviewSize()
        MainForm.dgvitems.Columns(0).Width = 10
        MainForm.dgvitems.Columns(1).Width = 320
        MainForm.dgvitems.Columns(2).Width = 105
        MainForm.dgvitems.Columns(3).Width = 113
    End Sub

    Public Sub Datagridview()
        Dim sda As New SQLiteDataAdapter
        Dim dbinding As New BindingSource
        Dim dbDataset As New DataTable
        Try
            Using connection As New SQLiteConnection(String.Format("Datasource = " & Application.StartupPath & "\databases\database1.db; Read Only = False "))
                Dim getitems As String = "Select * from Items"
                Dim command As New SQLiteCommand(getitems, connection)
                sda.SelectCommand = command
                sda.Fill(dbDataset)
                dbinding.DataSource = dbDataset
                MainForm.dgvitems.DataSource = dbinding
                sda.Update(dbDataset)
                connection.Open()
                Dim reader As SQLiteDataReader = command.ExecuteReader
                reader.Read()
                reader.Close()
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
            End Using

            Try
                If MainForm.dgvitems.Rows.Count > 0 Then
                    For i As Integer = 0 To MainForm.dgvitems.Rows.Count - 1
                        Dim CellChange As Integer = MainForm.dgvitems.Rows(i).Cells(3).Value.ToString().Trim()
                        If CellChange < 5 Then

                            With MainForm.dgvitems()
                                .Rows(i).Cells(3).Style.BackColor = Color.Red
                            End With

                        End If
                    Next
                End If
            Catch e As Exception
                MessageBox.Show(e.ToString())
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        DataGriviewSize()

    End Sub

    Public Sub Livesearch()
        'Public connectionstring As String = String.Format("Datasource = " & Application.StartupPath & "\databases\database1.db ")

        Dim sda As New SQLiteDataAdapter
        Dim dbinding As New BindingSource
        Dim dbDataset As New DataTable
        Try
            Using connection As New SQLiteConnection(String.Format("Datasource = " & Application.StartupPath & "\databases\database1.db; Read Only = False "))
                Dim getitems As String = "Select * from Items"
                Dim command As New SQLiteCommand(getitems, connection)
                sda.SelectCommand = command
                sda.Fill(dbDataset)
                dbinding.DataSource = dbDataset
                MainForm.dgvitems.DataSource = dbinding
                sda.Update(dbDataset)
                connection.Open()
                Dim reader As SQLiteDataReader = command.ExecuteReader
                reader.Read()
                reader.Close()
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Dim dv As New DataView(dbDataset)
        dv.RowFilter = String.Format("item_name  Like '%{0}%'", MainForm.searchtxt.Text)
        MainForm.dgvitems.DataSource = dv

        Dim dv1 As New DataView(dbDataset)
        dv1.RowFilter = String.Format("item_name  Like '%{0}%'", MainForm.txtInventorysearch.Text)
        MainForm.dgvitems2.DataSource = dv1

    End Sub

    Public Sub View(ByVal search As String)

        Dim sda As New SQLiteDataAdapter
        Dim dbinding As New BindingSource
        Try
            Using connection As New SQLiteConnection(String.Format("Datasource = " & Application.StartupPath & "\databases\database1.db; Read Only = False"))
                Dim query As String = ("SELECT * FROM items where item_id = '" & search & "' ")
                Dim command As New SQLiteCommand(query, connection)

                Dim adapter As New SQLiteDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)

                connection.Open()
                Dim reader As SQLiteDataReader = command.ExecuteReader
                reader.Read()
                MainForm.txtitemno.Text = table(0)(0)
                MainForm.txtitemname.Text = table(0)(1)
                MainForm.txtprice.Text = table(0)(2)

                reader.Dispose()
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Public Sub View2(ByVal search As String)
        Dim sda As New SQLiteDataAdapter
        Dim dbinding As New BindingSource
        Try
            Using connection As New SQLiteConnection(String.Format("Datasource = " & Application.StartupPath & "\databases\database1.db; Read Only = False"))
                Dim query As String = ("SELECT * FROM receipt_item where item_id = '" & search & "'and receipt_id = '" & MainForm.txtreceiptno.Text & "' ")
                Dim command As New SQLiteCommand(query, connection)
                Dim adapter As New SQLiteDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)

                connection.Open()
                Dim reader As SQLiteDataReader = command.ExecuteReader
                reader.Read()
                MainForm.txtitemno.Text = table(0)(0)
                MainForm.txtreceiptno.Text = table(0)(1)
                MainForm.txtitemname.Text = table(0)(2)
                MainForm.txtprice.Text = table(0)(3)
                MainForm.txtcount.Text = table(0)(4)
                MainForm.txtsubtotal.Text = table(0)(5)

                reader.Dispose()
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Public Sub dgvdisplayitems()
        Dim dbgettable As New DataTable
        Dim sda As New SQLiteDataAdapter
        Dim dbinding As New BindingSource

        Using connectionString As New SQLiteConnection(String.Format("Datasource = " & Application.StartupPath & "\databases\database1.db; Read Only = False "))

            Dim gettable As String = "SELECT * FROM receipt_item WHERE receipt_id = '" & MainForm.txtreceiptno.Text & "' "
            Dim gettablecommand As New SQLiteCommand(gettable, connectionString)
            sda.SelectCommand = gettablecommand
            sda.Fill(dbgettable)
            dbinding.DataSource = dbgettable
            MainForm.dgvdisplay.DataSource = dbinding
            sda.Update(dbgettable)
            connectionString.Open()
            Dim gettablereader As SQLiteDataReader = gettablecommand.ExecuteReader
            gettablereader.Read()
            gettablereader.Close()
            connectionString.Close()
        End Using

        MainForm.dgvdisplay.Columns(0).Width = 0
        MainForm.dgvdisplay.Columns(1).Width = 0
        MainForm.dgvdisplay.Columns(2).Width = 300
        MainForm.dgvdisplay.Columns(3).Width = 70
        MainForm.dgvdisplay.Columns(4).Width = 70
        MainForm.dgvdisplay.Columns(5).Width = 93
    End Sub

    Public Sub insert()
        Using connectionString As New SQLiteConnection(String.Format("Datasource = " & Application.StartupPath & "\databases\database1.db; Read Only = False "))

            Dim insertreceipt As String = "insert into receipt_item(Item_id,receipt_id,Name,Price,Qty,Subtotal)
                    VALUES('" & MainForm.txtitemno.Text & "','" & MainForm.txtreceiptno.Text & "',
                           '" & MainForm.txtitemname.Text & "', '" & MainForm.txtprice.Text & "',
                           '" & MainForm.txtcount.Text & "','" & MainForm.txtsubtotal.Text & "' ) "
            Dim insertcommand As New SQLiteCommand(insertreceipt, connectionString)
            connectionString.Open()
            insertcommand.ExecuteNonQuery()
            connectionString.Close()
        End Using
        MainForm.txtitemno.Text = Nothing
        MainForm.txtitemname.Text = Nothing
        MainForm.txtprice.Text = Nothing
        MainForm.txtcount.Text = Nothing
    End Sub

    Public Sub update()
        Using connection As New SQLiteConnection(String.Format("Datasource = " & Application.StartupPath & "\databases\database1.db; Read Only = False "))

            Dim updatereceipt As String = "update receipt_item set Qty='" & MainForm.txtcount.Text & "', subtotal='" & MainForm.txtsubtotal.Text & "' WHERE item_id='" & MainForm.txtitemno.Text & "' AND receipt_id = '" & MainForm.txtreceiptno.Text & "' "

            Dim updatecommand As New SQLiteCommand(updatereceipt, connection)
            connection.Open()
            updatecommand.ExecuteNonQuery()
            connection.Close()
            dgvdisplayitems()
            MainForm.txtitemno.Text = Nothing
            MainForm.txtitemname.Text = Nothing
            MainForm.txtprice.Text = Nothing
            MainForm.txtcount.Text = Nothing
        End Using
    End Sub

    Public Function Checkitemstock() As Boolean

        Using connection As New SQLiteConnection(String.Format("Datasource = " & Application.StartupPath & "\databases\database1.db; Read Only = False "))
            Dim getstock As String = "Select Item_stock from items where Item_id = '" & MainForm.txtitemno.Text & "' "
            Dim command As New SQLiteCommand(getstock, connection)
            Dim adapter As New SQLiteDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            connection.Open()
            Dim reader As SQLiteDataReader = command.ExecuteReader
            reader.Read()
            Dim stock As Integer = table(0)(0)
            reader.Close()
            connection.Close()
            Dim checkstock As Integer = stock - CInt(MainForm.txtcount.Text)
            If checkstock < 0 Then
                Return False
            Else
                Return True
            End If
        End Using
    End Function

    Public Sub Removestock()
        Try
            Using connection As New SQLiteConnection(String.Format("Datasource = " & Application.StartupPath & "\databases\database1.db; Read Only = False "))

                Dim new_stock As Integer = CInt(MainForm.txtcount.Text)

                Dim updatestock As String = "update items set item_stock = item_stock - " & new_stock & " where item_id = " & CInt(MainForm.txtitemno.Text) & " "

                Dim updatecommand As New SQLiteCommand(updatestock, connection)
                connection.Open()
                updatecommand.ExecuteNonQuery()
                connection.Close()
            End Using
            Datagridview()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub Add()

        If Len(MainForm.txtreceiptno.Text) = 0 Or Len(MainForm.txtcount.Text) = 0 Then
            MsgBox("Generate Receipt number Or Enter Count", MsgBoxStyle.Critical, "Warning")
        Else
            Try
                Using connection As New SQLiteConnection(String.Format("Datasource = " & Application.StartupPath & "\databases\database1.db; Read Only = False "))

                    Dim getpassword As String = "Select * from receipt_item where Item_id = '" & MainForm.txtitemno.Text & "' and receipt_id = '" & MainForm.txtreceiptno.Text & "' "
                    Dim selectcommand As New SQLiteCommand(getpassword, connection)
                    connection.Open()
                    Dim reader As SQLiteDataReader = selectcommand.ExecuteReader
                    Dim thereornot As Boolean = reader.Read()
                    reader.Close()
                    connection.Close()

                    If thereornot = False Then
                        If Checkitemstock() = False Then
                            MsgBox("Out Of Stock")
                        Else
                            Removestock()
                            insert()
                            dgvdisplayitems()

                        End If
                    Else
                        If Checkitemstock() = False Then
                            MsgBox("Out Of Stock")
                        Else
                            update()
                        End If

                    End If
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Public Sub Addstock()
        Try
            Using connection As New SQLiteConnection(String.Format("Datasource = " & Application.StartupPath & "\databases\database1.db; Read Only = False "))

                Dim new_stock As Integer = MainForm.txtcount.Text

                Dim updatereceipt As String = "update items set item_stock = item_stock + " & new_stock & " where item_id = " & MainForm.txtitemno.Text & " "

                Dim updatecommand As New SQLiteCommand(updatereceipt, connection)
                connection.Open()
                updatecommand.ExecuteNonQuery()
                connection.Close()
                Datagridview()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub Remove()
        If Len(MainForm.txtreceiptno.Text) = 0 Or Len(MainForm.txtcount.Text) = 0 Then
            MsgBox("No Item Chosen", MsgBoxStyle.Critical, "Warning!!")
        Else
            Using connectionString As New SQLiteConnection(String.Format("Datasource = " & Application.StartupPath & "\databases\database1.db; Read Only = False "))

                Dim removeitem As String = "delete from receipt_item where item_id='" & MainForm.txtitemno.Text & "' AND receipt_id = '" & MainForm.txtreceiptno.Text & "' "
                Dim removecommand As New SQLiteCommand(removeitem, connectionString)
                connectionString.Open()
                removecommand.ExecuteNonQuery()
                connectionString.Close()

                dgvdisplayitems()

            End Using
        End If
        Addstock()
        MainForm.txtitemno.Text = Nothing
        MainForm.txtitemname.Text = Nothing
        MainForm.txtprice.Text = Nothing
        MainForm.txtcount.Text = Nothing
    End Sub

End Module