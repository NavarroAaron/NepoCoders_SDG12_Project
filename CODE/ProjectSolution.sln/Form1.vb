Imports System.Data.SqlClient
Imports System.IO

Public Class Form1

    ' === GLOBAL VARIABLES ===
    Private CurrentUserID As Integer
    Private CurrentUserRole As String

    ' =========================
    ' FORM LOAD
    ' =========================
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtPassword.UseSystemPasswordChar = True
        txtPassword.Multiline = False
        ErrorProvider1.Clear()
        Me.ReportViewer2.RefreshReport()
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer2.RefreshReport()
    End Sub

    ' =========================
    ' LOGIN TAB (frmLogin)
    ' =========================
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text.Trim() = "" Or txtPassword.Text.Trim() = "" Then
            ErrorProvider1.SetError(txtUsername, "Username required")
            ErrorProvider1.SetError(txtPassword, "Password required")
            Exit Sub
        End If

        Using conn As SqlConnection = ManagerDB.GetConnection()
            conn.Open()
            Dim cmd As New SqlCommand("SELECT UserID, Role FROM Users WHERE Username=@user AND PasswordHash=@pass", conn)
            cmd.Parameters.AddWithValue("@user", txtUsername.Text)
            cmd.Parameters.AddWithValue("@pass", txtPassword.Text)
            Dim reader = cmd.ExecuteReader()
            If reader.Read() Then
                CurrentUserID = Convert.ToInt32(reader("UserID"))
                CurrentUserRole = reader("Role").ToString()
                MessageBox.Show("Login successful!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Invalid credentials.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Using
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        ' Toggle password visibility
        txtPassword.UseSystemPasswordChar = Not chkShowPassword.Checked
    End Sub

    ' =========================
    ' RESOURCES TAB (frmResources)
    ' =========================
    Private Sub btnAddResource_Click(sender As Object, e As EventArgs) Handles btnAddResource.Click
        Using conn As SqlConnection = ManagerDB.GetConnection()
            conn.Open()
            Dim cmd As New SqlCommand("INSERT INTO Resources (ResourceName, Quantity, Category) VALUES (@name,@qty,@cat)", conn)
            cmd.Parameters.AddWithValue("@name", txtResourceName.Text)
            cmd.Parameters.AddWithValue("@qty", Convert.ToInt32(txtQuantity.Text))
            cmd.Parameters.AddWithValue("@cat", txtCategory.Text)
            cmd.ExecuteNonQuery()
        End Using
        LoadResources()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdateResource.Click
        Dim resourceId As Integer


        If Not Integer.TryParse(txtResourceID.Text, resourceId) Then
            MessageBox.Show("Please enter a valid numeric Resource ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Using conn As SqlConnection = ManagerDB.GetConnection()
            conn.Open()
            Dim cmd As New SqlCommand("UPDATE Resources 
                                   SET ResourceName=@name, Quantity=@qty, Category=@cat 
                                   WHERE ResourceID=@id", conn)
            cmd.Parameters.AddWithValue("@id", resourceId)
            cmd.Parameters.AddWithValue("@name", txtResourceName.Text)
            cmd.Parameters.AddWithValue("@qty", Convert.ToInt32(txtQuantity.Text))
            cmd.Parameters.AddWithValue("@cat", txtCategory.Text)

            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("Resource updated successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No resource found with that ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End Using

        LoadResources()
    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDeleteResource.Click
        Dim resourceId As Integer

        ' Validate input
        If Not Integer.TryParse(txtResourceID.Text, resourceId) Then
            MessageBox.Show("Please enter a valid numeric Resource ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Using conn As SqlConnection = ManagerDB.GetConnection()
            conn.Open()
            Dim cmd As New SqlCommand("DELETE FROM Resources WHERE ResourceID=@id", conn)
            cmd.Parameters.AddWithValue("@id", resourceId)
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("Resource deleted successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No resource found with that ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End Using

        LoadResources()
    End Sub



    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtResourceID.Clear()
        txtResourceName.Clear()
        txtQuantity.Clear()
        txtCategory.Clear()
    End Sub

    Private Sub LoadResources()
        Using conn As SqlConnection = ManagerDB.GetConnection()
            conn.Open()
            Dim adapter As New SqlDataAdapter("SELECT * FROM Resources", conn)
            Dim table As New DataTable()
            adapter.Fill(table)
            dgvResources.DataSource = table
        End Using
    End Sub

    ' =========================
    ' BUDGET TAB (frmBudget)
    ' =========================
    Private Sub btnSetBudget_Click(sender As Object, e As EventArgs) Handles btnDeleteBudget.Click
        Using conn As SqlConnection = ManagerDB.GetConnection()
            conn.Open()
            Dim cmd As New SqlCommand("INSERT INTO Budgets (UserID, Amount, Period) VALUES (@uid,@amt,@per)", conn)
            cmd.Parameters.AddWithValue("@uid", CurrentUserID)
            cmd.Parameters.AddWithValue("@amt", Convert.ToDecimal(txtBudgetAmount.Text))
            cmd.Parameters.AddWithValue("@per", cmbPeriod.SelectedItem.ToString())
            cmd.ExecuteNonQuery()
        End Using

        lblBudgetStatus.Text = "Budget set: ₱" & txtBudgetAmount.Text & " (" & cmbPeriod.SelectedItem.ToString() & ")"
    End Sub

    Private Sub btnMonitor_Click(sender As Object, e As EventArgs) Handles btnMonitor.Click
        Dim totalBudget As Decimal = 0
        Dim balance As Decimal = 0
        Dim totalUsed As Decimal = 0

        Using conn As SqlConnection = ManagerDB.GetConnection()
            conn.Open()


            Dim budgetCmd As New SqlCommand("SELECT TOP 1 Amount, Balance FROM Budgets WHERE UserID=@uid ORDER BY BudgetID DESC", conn)
            budgetCmd.Parameters.AddWithValue("@uid", CurrentUserID)
            Using reader = budgetCmd.ExecuteReader()
                If reader.Read() Then

                    totalBudget = If(IsDBNull(reader("Amount")), 0D, Convert.ToDecimal(reader("Amount")))
                    balance = If(IsDBNull(reader("Balance")), 0D, Convert.ToDecimal(reader("Balance")))
                Else

                    totalBudget = 0D
                    balance = 0D
                    lblBudgetStatus.Text = "No budget found for this user."
                End If
            End Using


            Dim transCmd As New SqlCommand("SELECT COUNT(*) FROM Transactions WHERE UserID=@uid", conn)
            transCmd.Parameters.AddWithValue("@uid", CurrentUserID)
            totalUsed = Convert.ToDecimal(transCmd.ExecuteScalar())
        End Using


        Dim percentUsed As Integer = 0
        If totalBudget > 0 Then
            percentUsed = CInt((totalUsed / totalBudget) * 100)
            If percentUsed > 100 Then percentUsed = 100
        End If

        pbBudgetStatus.Value = percentUsed
        lblBudgetStatus.Text = "Budget ₱" & totalBudget & " | Used: " & totalUsed & " | Remaining ₱" & balance
    End Sub

    Private Sub btnSendMoney_Click(sender As Object, e As EventArgs) Handles btnSendMoney.Click
        Dim amount As Decimal

        If Not Decimal.TryParse(txtBudgetAmount.Text, amount) Then
            MessageBox.Show("Enter a valid amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Using conn As SqlConnection = ManagerDB.GetConnection()
            conn.Open()
            Dim cmd As New SqlCommand("INSERT INTO Budgets (UserID, Amount, Period, Balance, Description) 
                                   VALUES (@uid, @amt, @per, @bal, @desc)", conn)
            cmd.Parameters.AddWithValue("@uid", CurrentUserID)
            cmd.Parameters.AddWithValue("@amt", amount)
            cmd.Parameters.AddWithValue("@per", cmbPeriod.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@bal", amount)
            cmd.Parameters.AddWithValue("@desc", txtDescription.Text)
            cmd.ExecuteNonQuery()
        End Using

        lblBudgetStatus.Text = "₱" & amount & " sent to UserID " & CurrentUserID
        LoadBudgets()
    End Sub
    Private Sub LoadBudgets()
        Using conn As SqlConnection = ManagerDB.GetConnection()
            conn.Open()
            Dim cmd As New SqlCommand("SELECT BudgetID, UserID, Amount, Period, TransactionDate, Balance, Description FROM Budgets WHERE UserID=@uid", conn)
            cmd.Parameters.AddWithValue("@uid", CurrentUserID)

            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            dgvBudgets.DataSource = table
        End Using
    End Sub

    ' =========================
    ' TRANSACTIONS TAB (frmTransactions)
    ' =========================
    Private Sub btnDistribute_Click(sender As Object, e As EventArgs) Handles btnDistribute.Click
        Using conn As SqlConnection = ManagerDB.GetConnection()
            conn.Open()
            Dim cmd As New SqlCommand("INSERT INTO Transactions (UserID, ResourceID) VALUES (@uid,@rid)", conn)
            cmd.Parameters.AddWithValue("@uid", CurrentUserID)
            cmd.Parameters.AddWithValue("@rid", Convert.ToInt32(txtTransactionResourceID.Text))
            cmd.ExecuteNonQuery()

            Dim updateCmd As New SqlCommand("UPDATE Resources SET Quantity = Quantity - 1 WHERE ResourceID=@rid", conn)
            updateCmd.Parameters.AddWithValue("@rid", Convert.ToInt32(txtTransactionResourceID.Text))
            updateCmd.ExecuteNonQuery()
        End Using
        lblTransactionStatus.Text = "Distribution recorded!"
        LoadTransactions()
    End Sub
    Private Sub btnDeleteTransaction_Click(sender As Object, e As EventArgs) Handles btnDeleteTransaction.Click
        Dim resourceId As Integer


        If Not Integer.TryParse(txtTransactionResourceID.Text, resourceId) Then
            MessageBox.Show("Please enter a valid numeric Transaction Resource ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Using conn As SqlConnection = ManagerDB.GetConnection()
            conn.Open()
            Dim cmd As New SqlCommand("DELETE FROM Transactions WHERE UserID=@uid AND ResourceID=@rid", conn)
            cmd.Parameters.AddWithValue("@uid", CurrentUserID)
            cmd.Parameters.AddWithValue("@rid", resourceId)

            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("Transaction deleted successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No transaction found for this UserID and ResourceID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End Using

        LoadTransactions()
    End Sub


    Private Sub btnViewTransactions_Click(sender As Object, e As EventArgs) Handles btnViewTransactions.Click
        LoadTransactions()
    End Sub

    Private Sub LoadTransactions()
        Using conn As SqlConnection = ManagerDB.GetConnection()
            conn.Open()
            Dim adapter As New SqlDataAdapter("SELECT * FROM Transactions", conn)
            Dim table As New DataTable()
            adapter.Fill(table)
            dgvTransactions.DataSource = table
        End Using
    End Sub

    ' =========================
    ' REPORTS TAB (frmReports)
    ' =========================
    Private Sub btnGenerateReport_Click(sender As Object, e As EventArgs) Handles btnGenerateReport.Click
        Try
            Using conn As SqlConnection = ManagerDB.GetConnection()
                conn.Open()
                Dim ds As New DataSet()

                Dim cmdBudgets As New SqlCommand("SELECT BudgetID, UserID, Amount, Period, Balance, Description FROM Budgets", conn)
                Dim adapterBudgets As New SqlDataAdapter(cmdBudgets)
                adapterBudgets.Fill(ds, "Budgets")

                ReportViewer1.LocalReport.ReportPath = Application.StartupPath & "\SummaryReport.rdlc"
                ReportViewer1.LocalReport.DataSources.Clear()
                ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Budgets", ds.Tables("Budgets")))
                ReportViewer1.RefreshReport()
            End Using

        Catch ex As SqlException
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch ex As FileNotFoundException
            MessageBox.Show("Report file not found: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch ex As Exception
            MessageBox.Show("Unexpected error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExportPDF_Click(sender As Object, e As EventArgs) Handles btnExportPDF.Click
        Try
            ' ✅ Ensure report is loaded before export
            If ReportViewer1.LocalReport Is Nothing OrElse ReportViewer1.LocalReport.ReportPath = "" Then
                MessageBox.Show("Please generate the report first before exporting.", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim bytes As Byte() = ReportViewer1.LocalReport.Render("PDF")
            Dim savePath As String = Application.StartupPath & "\SummaryReport.pdf"

            Using fs As New IO.FileStream(savePath, IO.FileMode.Create)
                fs.Write(bytes, 0, bytes.Length)
            End Using

            MessageBox.Show("Budget report exported to PDF at " & savePath, "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As IOException
            MessageBox.Show("File error: " & ex.Message, "Export Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch ex As Exception
            MessageBox.Show("Unexpected error: " & ex.Message, "Export Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class
