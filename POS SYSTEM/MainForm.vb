Imports System.Data.SQLite

Public Class MainForm

    Dim table As New DataTable("ItemRecieptTable")

    Public connectionstring As String = String.Format("Datasource = C:\Users\okwesi\Desktop\POS SYSTEM\bin\Debug\databases\database1.db ")

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        'Me.Close()
        Application.Exit()
        'LOGIN.Show()
    End Sub

    Public Sub change()
        Try
            If dgvitems.Rows.Count > 0 Then
                For i As Integer = 0 To dgvitems.Rows.Count - 1
                    Dim CellChange As Integer = dgvitems.Rows(i).Cells(3).Value.ToString().Trim()
                    If CellChange < 5 Then

                        With dgvitems
                            .Rows(i).Cells(3).Style.BackColor = Color.Red
                        End With

                    End If
                Next
            End If
        Catch e As Exception
            MessageBox.Show(e.ToString())
        End Try
    End Sub

    Private Sub mainapp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DatabaseQueries.Home()
        DatabaseQueries.Datagridview()
        Reciept.Gvreceipt()
        Inventory.Dgvitems()
        change()

    End Sub

    Private Sub homebtn_Click(sender As Object, e As EventArgs) Handles homebtn.Click
        DatabaseQueries.Home()
        DatabaseQueries.Datagridview()
    End Sub

    Private Sub btnreceiptpanel_Click(sender As Object, e As EventArgs)
        DatabaseQueries.Recieptpanel()
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        DatabaseQueries.Add()
    End Sub

    Private Sub btngen_Click(sender As Object, e As EventArgs) Handles btngen.Click
        Dim random As New Random()
        txtreceiptno.Text = random.Next(10000, 90000000)
    End Sub

    Public Sub dgvitems_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvitems.CellDoubleClick
        Dim num As Int16 = Nothing
        If e.RowIndex >= 0 Then
            num = e.RowIndex
            Dim row As DataGridViewRow
            row = Me.dgvitems.Rows(num)
            txtitemno.Text = row.Cells("item_id").Value.ToString
            Dim s As String = txtitemno.Text
            DatabaseQueries.View(s)
            'pnlreceipt.BringToFront()
            'pnlreceipt.Dock = DockStyle.Fill
        End If
        txtcount.Select()
    End Sub

    Private Sub txtcount_TextChanged(sender As Object, e As EventArgs) Handles txtcount.TextChanged
        If Len(txtcount.Text) > 0 Then
            txtsubtotal.Text = CDbl(txtcount.Text) * CDbl(txtprice.Text)
        Else
            txtsubtotal.Text = Nothing
        End If
    End Sub

    Private Sub btnremove_Click(sender As Object, e As EventArgs) Handles btnremove.Click
        DatabaseQueries.Remove()
    End Sub

    Private Sub dgvdisplay_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvdisplay.CellDoubleClick
        Dim num As Int16 = Nothing
        If e.RowIndex >= 0 Then
            num = e.RowIndex
            Dim row As DataGridViewRow
            row = Me.dgvdisplay.Rows(num)
            txtitemno.Text = row.Cells("item_id").Value.ToString
            Dim s As String = txtitemno.Text
            DatabaseQueries.View2(s)
        End If
    End Sub

    Private Sub printpanelbtn_Click(sender As Object, e As EventArgs) Handles printpanelbtn.Click
        GunaPanel2.BringToFront()
        GunaPanel2.Dock = DockStyle.Fill
        printpanelbtn.Checked = True
        PictureBox1.BackColor = Color.White
        If printpanelbtn.Checked = True And
             Len(txtcustomername.Text) = 0 Then
            btnprint.Enabled = False
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If dgvdisplay.Rows.Count = 0 Then
            MsgBox("ERROR!!, You have not entered any item")
        Else
            Reciept.Gvreceipt()
            btnadd.Checked = True
            GunaPanel2.BringToFront()
            GunaPanel2.Dock = DockStyle.Fill
            printpanelbtn.Checked = True
            btnadd.Checked = False
        End If

    End Sub

    Private Sub txtcustomername_TextChanged(sender As Object, e As EventArgs) Handles txtcustomername.TextChanged
        lblcustomername.Text = txtcustomername.Text.ToUpper
        If Len(txtcustomername.Text) > 0 Then
            btnprint.Enabled = True
        Else
            btnprint.Enabled = False
        End If
    End Sub

    Private Sub txtreceiptno_TextChanged(sender As Object, e As EventArgs) Handles txtreceiptno.TextChanged
        If Len(txtreceiptno.Text) > 0 Then
            btngen.Enabled = False
        Else
            btngen.Enabled = True
        End If
    End Sub

    Private Sub searchtxt_TextChanged_1(sender As Object, e As EventArgs) Handles searchtxt.TextChanged
        DatabaseQueries.Livesearch()
        change()
        dgvitems.ClearSelection()
    End Sub

    Private Sub Savereceipt()
        dgvdisplay.DataSource = Nothing
        dgvdisplay.Rows.Clear()
        Reciept.Savereciept()
        txtreceiptno.Text = Nothing
        btnadd.Checked = False
    End Sub

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        Try

            'If GVreceipt.Rows.Count =  Then
            '    MsgBox("No item was entered!!")
            'Else
            PrintReciept.DefaultPageSettings.Landscape = True
            PrintReciept.Print()
            Savereciept()
            dgvdisplay.DataSource = Nothing
            dgvdisplay.Rows.Clear()

            'End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintReciept.PrintPage
        Dim bm As New Bitmap(Me.receipt.Width, Me.receipt.Height)
        receipt.DrawToBitmap(bm, New Rectangle(5, 5, Me.receipt.Width, Me.receipt.Height))
        e.Graphics.DrawImage(bm, 0, 0)
    End Sub

    Private Sub inventorypnbtn_Click(sender As Object, e As EventArgs) Handles inventorypnbtn.Click
        inventorypanel.BringToFront()
        inventorypanel.Dock = DockStyle.Fill
        Inventory.Dgvitems()
    End Sub

    Private Sub txtInventorysearch_TextChanged(sender As Object, e As EventArgs) Handles txtInventorysearch.TextChanged
        DatabaseQueries.Livesearch()
    End Sub

    Private Sub dgvitems2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvitems2.CellClick
        Dim num As Int16 = Nothing
        If e.RowIndex >= 0 Then
            num = e.RowIndex
            Dim row As DataGridViewRow
            row = Me.dgvitems2.Rows(num)
            txtInvItemno.Text = row.Cells("item_id").Value.ToString
            Dim search As String = txtInvItemno.Text
            Inventory.DgvItems2CellClicked(search)
        End If
    End Sub

    Private Sub btnInventoryAdd_Click(sender As Object, e As EventArgs) Handles btnInventoryAdd.Click
        Inventory.Additem()
        dgvitems.Refresh()
    End Sub

    Private Sub btnInvClear_Click(sender As Object, e As EventArgs) Handles btnInvClear.Click
        txtInvItemno.Text = Nothing
        txtInvItemname.Text = Nothing
        txtInvItemprice.Text = Nothing
        txtInvItemstock.Text = Nothing
    End Sub

    Private Sub btnInventoryupdate_Click(sender As Object, e As EventArgs) Handles btnInventoryupdate.Click
        Inventory.Updateitem()
    End Sub

    Private Sub btnInventoryremove_Click(sender As Object, e As EventArgs) Handles btnInventoryremove.Click
        Inventory.Removeitem()
        dgvitems.Refresh()
    End Sub

    Private Sub Reportanelbtn_Click(sender As Object, e As EventArgs) Handles Reportanelbtn.Click
        pnlreport.BringToFront()
        pnlreport.Dock = DockStyle.Fill
        btnreportreceipt.Checked = True
        pnlreportreceipt.BringToFront()
        pnlreportreceipt.Dock = DockStyle.Fill
        btntoday.Checked = True
        If btnreportreceipt.Checked = True Then
            If btntoday.Checked = True Then
                Reports.Dgvreportreceiptoday()
                dgvreportreceipt.ClearSelection()
            End If
        End If
    End Sub

    Private Sub btnreportreceipt_Click(sender As Object, e As EventArgs) Handles btnreportreceipt.Click
        pnlreportreceipt.BringToFront()
        pnlreportreceipt.Dock = DockStyle.Fill
        btnreportreceipt.Checked = True
    End Sub

    Private Sub btntoday_Click(sender As Object, e As EventArgs) Handles btntoday.Click
        Reports.Dgvreportreceiptoday()
        dgvreportreceipt.ClearSelection()
    End Sub

    Private Sub Btnthismonth_Click(sender As Object, e As EventArgs) Handles Btnthismonth.Click
        Reports.DgvreportreceipMonthly()
        dgvreportreceipt.ClearSelection()
    End Sub

    Private Sub btnalltime_Click(sender As Object, e As EventArgs) Handles btnalltime.Click
        Reports.Dgvreportreceiptalltime()
        dgvreportreceipt.ClearSelection()
    End Sub

    Private Sub GVreceipt_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs)
        Reciept.Gvreceiptresize()
    End Sub

    Private Sub btnsaleschart_Click(sender As Object, e As EventArgs) Handles btnsaleschart.Click
        btnsaleschart.Checked = True
        pnlitemcharts.BringToFront()
        pnlitemcharts.Dock = DockStyle.Fill
        Reports.ItemsalesTable()
        Me.Chart1.Series("Item Sales").Points.Clear()
        Reports.ItemsalesBarchart()

        Me.Chart3.Series("Item Sales").Points.Clear()
        Reports.piechart()
    End Sub

    Private Sub GunaImageButton1_Click(sender As Object, e As EventArgs) Handles GunaImageButton1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnItemSoldReport_Click(sender As Object, e As EventArgs) Handles BtnItemSoldReport.Click
        ItemSoldPanel.BringToFront()
        ItemSoldPanel.Dock = DockStyle.Fill
        If BtnItemSoldReport.Checked = True Then
            If BtnItemSoldToday.Checked = True Then
                Reports.ItemSoldToday()
                ItemSoldTable.ClearSelection()
            End If
        End If
    End Sub

    Private Sub BtnItemSoldToday_Click(sender As Object, e As EventArgs) Handles BtnItemSoldToday.Click
        Reports.ItemSoldToday()
        ItemSoldTable.ClearSelection()
    End Sub

    Private Sub BtnItemSoldMonth_Click(sender As Object, e As EventArgs) Handles BtnItemSoldMonth.Click
        Reports.ItemSoldMonth()
        ItemSoldTable.ClearSelection()
    End Sub

    Private Sub BtnItemSoldYear_Click(sender As Object, e As EventArgs) Handles BtnItemSoldYear.Click
        Reports.ItemSoldYear()
        ItemSoldTable.ClearSelection()
    End Sub

    Private Sub BtnSearchpnl_Click(sender As Object, e As EventArgs) Handles BtnSearchpnl.Click
        searchpanel.BringToFront()
        searchpanel.Dock = DockStyle.Fill
        BtnSearchpnl.Checked = True

    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        If BtnRecieptSearch.Checked = True Then
            Reports.SearchReciept(txtsearch.Text)
        ElseIf BtnDateSearch.Checked = True Then
            Reports.SearchDate(txtsearch.Text)
        End If
    End Sub

    Private Sub ClearRptBtn_Click(sender As Object, e As EventArgs) Handles ClearRptBtn.Click
        txtreceiptno.Text = Nothing
        lblTotal.Text = Nothing
        lblreceiptno.Text = Nothing
        table.Clear()
        GVreceipt.DataSource = table
        GVreceipt.DataSource = Nothing
    End Sub

End Class