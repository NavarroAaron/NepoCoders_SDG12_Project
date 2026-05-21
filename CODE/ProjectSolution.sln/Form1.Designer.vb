<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.chkShowPassword = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtResourceName = New System.Windows.Forms.TextBox()
        Me.txtResourceID = New System.Windows.Forms.TextBox()
        Me.btnAddResource = New System.Windows.Forms.Button()
        Me.btnUpdateResource = New System.Windows.Forms.Button()
        Me.btnDeleteResource = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.dgvResources = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.lblBudgetStatus = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbPeriod = New System.Windows.Forms.ComboBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtBudgetAmount = New System.Windows.Forms.TextBox()
        Me.btnSendMoney = New System.Windows.Forms.Button()
        Me.btnMonitor = New System.Windows.Forms.Button()
        Me.btnDeleteBudget = New System.Windows.Forms.Button()
        Me.pbBudgetStatus = New System.Windows.Forms.ProgressBar()
        Me.dgvBudgets = New System.Windows.Forms.DataGridView()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.lblTransactionStatus = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTransactionResourceID = New System.Windows.Forms.TextBox()
        Me.btnDistribute = New System.Windows.Forms.Button()
        Me.btnDeleteTransaction = New System.Windows.Forms.Button()
        Me.btnViewTransactions = New System.Windows.Forms.Button()
        Me.dgvTransactions = New System.Windows.Forms.DataGridView()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.btnExportPDF = New System.Windows.Forms.Button()
        Me.btnGenerateReport = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvResources, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgvBudgets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.dgvTransactions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(0, -1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(799, 533)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Wheat
        Me.TabPage1.Controls.Add(Me.chkShowPassword)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtPassword)
        Me.TabPage1.Controls.Add(Me.txtUsername)
        Me.TabPage1.Controls.Add(Me.btnLogin)
        Me.TabPage1.Controls.Add(Me.btnExit)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(791, 507)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Login"
        '
        'chkShowPassword
        '
        Me.chkShowPassword.AutoSize = True
        Me.chkShowPassword.Location = New System.Drawing.Point(399, 306)
        Me.chkShowPassword.Name = "chkShowPassword"
        Me.chkShowPassword.Size = New System.Drawing.Size(102, 17)
        Me.chkShowPassword.TabIndex = 6
        Me.chkShowPassword.Text = "Show Password"
        Me.chkShowPassword.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(266, 264)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(266, 211)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Username"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(266, 280)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(235, 20)
        Me.txtPassword.TabIndex = 3
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(266, 227)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(235, 20)
        Me.txtUsername.TabIndex = 2
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(565, 437)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 1
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(657, 437)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Wheat
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.txtCategory)
        Me.TabPage2.Controls.Add(Me.txtQuantity)
        Me.TabPage2.Controls.Add(Me.txtResourceName)
        Me.TabPage2.Controls.Add(Me.txtResourceID)
        Me.TabPage2.Controls.Add(Me.btnAddResource)
        Me.TabPage2.Controls.Add(Me.btnUpdateResource)
        Me.TabPage2.Controls.Add(Me.btnDeleteResource)
        Me.TabPage2.Controls.Add(Me.btnClear)
        Me.TabPage2.Controls.Add(Me.dgvResources)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(791, 507)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Resources"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(48, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Resource ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(48, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Quantity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 223)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Category"
        '
        'txtCategory
        '
        Me.txtCategory.Location = New System.Drawing.Point(47, 242)
        Me.txtCategory.Multiline = True
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(252, 34)
        Me.txtCategory.TabIndex = 8
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(47, 176)
        Me.txtQuantity.Multiline = True
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(252, 34)
        Me.txtQuantity.TabIndex = 7
        '
        'txtResourceName
        '
        Me.txtResourceName.Location = New System.Drawing.Point(47, 109)
        Me.txtResourceName.Multiline = True
        Me.txtResourceName.Name = "txtResourceName"
        Me.txtResourceName.Size = New System.Drawing.Size(252, 32)
        Me.txtResourceName.TabIndex = 6
        '
        'txtResourceID
        '
        Me.txtResourceID.Location = New System.Drawing.Point(47, 46)
        Me.txtResourceID.Multiline = True
        Me.txtResourceID.Name = "txtResourceID"
        Me.txtResourceID.Size = New System.Drawing.Size(252, 36)
        Me.txtResourceID.TabIndex = 5
        '
        'btnAddResource
        '
        Me.btnAddResource.Location = New System.Drawing.Point(683, 118)
        Me.btnAddResource.Name = "btnAddResource"
        Me.btnAddResource.Size = New System.Drawing.Size(75, 23)
        Me.btnAddResource.TabIndex = 4
        Me.btnAddResource.Text = "Add"
        Me.btnAddResource.UseVisualStyleBackColor = True
        '
        'btnUpdateResource
        '
        Me.btnUpdateResource.Location = New System.Drawing.Point(683, 160)
        Me.btnUpdateResource.Name = "btnUpdateResource"
        Me.btnUpdateResource.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdateResource.TabIndex = 3
        Me.btnUpdateResource.Text = "Update"
        Me.btnUpdateResource.UseVisualStyleBackColor = True
        '
        'btnDeleteResource
        '
        Me.btnDeleteResource.Location = New System.Drawing.Point(683, 202)
        Me.btnDeleteResource.Name = "btnDeleteResource"
        Me.btnDeleteResource.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteResource.TabIndex = 2
        Me.btnDeleteResource.Text = "Delete"
        Me.btnDeleteResource.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(683, 242)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'dgvResources
        '
        Me.dgvResources.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResources.Location = New System.Drawing.Point(21, 282)
        Me.dgvResources.Name = "dgvResources"
        Me.dgvResources.Size = New System.Drawing.Size(746, 193)
        Me.dgvResources.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.Wheat
        Me.TabPage3.Controls.Add(Me.lblBudgetStatus)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Controls.Add(Me.cmbPeriod)
        Me.TabPage3.Controls.Add(Me.txtDescription)
        Me.TabPage3.Controls.Add(Me.txtBudgetAmount)
        Me.TabPage3.Controls.Add(Me.btnSendMoney)
        Me.TabPage3.Controls.Add(Me.btnMonitor)
        Me.TabPage3.Controls.Add(Me.btnDeleteBudget)
        Me.TabPage3.Controls.Add(Me.pbBudgetStatus)
        Me.TabPage3.Controls.Add(Me.dgvBudgets)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(791, 507)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Budget"
        '
        'lblBudgetStatus
        '
        Me.lblBudgetStatus.AutoSize = True
        Me.lblBudgetStatus.Location = New System.Drawing.Point(395, 240)
        Me.lblBudgetStatus.Name = "lblBudgetStatus"
        Me.lblBudgetStatus.Size = New System.Drawing.Size(0, 13)
        Me.lblBudgetStatus.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(25, 102)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Period"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(233, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Description "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Amount"
        '
        'cmbPeriod
        '
        Me.cmbPeriod.FormattingEnabled = True
        Me.cmbPeriod.Items.AddRange(New Object() {"DAILY", "WEEKLY", "MONTHLY"})
        Me.cmbPeriod.Location = New System.Drawing.Point(22, 121)
        Me.cmbPeriod.Name = "cmbPeriod"
        Me.cmbPeriod.Size = New System.Drawing.Size(121, 21)
        Me.cmbPeriod.TabIndex = 7
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(233, 44)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(168, 32)
        Me.txtDescription.TabIndex = 6
        '
        'txtBudgetAmount
        '
        Me.txtBudgetAmount.Location = New System.Drawing.Point(22, 44)
        Me.txtBudgetAmount.Multiline = True
        Me.txtBudgetAmount.Name = "txtBudgetAmount"
        Me.txtBudgetAmount.Size = New System.Drawing.Size(168, 32)
        Me.txtBudgetAmount.TabIndex = 5
        '
        'btnSendMoney
        '
        Me.btnSendMoney.Location = New System.Drawing.Point(684, 154)
        Me.btnSendMoney.Name = "btnSendMoney"
        Me.btnSendMoney.Size = New System.Drawing.Size(75, 23)
        Me.btnSendMoney.TabIndex = 4
        Me.btnSendMoney.Text = "Send"
        Me.btnSendMoney.UseVisualStyleBackColor = True
        '
        'btnMonitor
        '
        Me.btnMonitor.Location = New System.Drawing.Point(684, 183)
        Me.btnMonitor.Name = "btnMonitor"
        Me.btnMonitor.Size = New System.Drawing.Size(75, 23)
        Me.btnMonitor.TabIndex = 3
        Me.btnMonitor.Text = "Monitor"
        Me.btnMonitor.UseVisualStyleBackColor = True
        '
        'btnDeleteBudget
        '
        Me.btnDeleteBudget.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnDeleteBudget.Location = New System.Drawing.Point(684, 212)
        Me.btnDeleteBudget.Name = "btnDeleteBudget"
        Me.btnDeleteBudget.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteBudget.TabIndex = 2
        Me.btnDeleteBudget.Text = "Delete"
        Me.btnDeleteBudget.UseVisualStyleBackColor = True
        '
        'pbBudgetStatus
        '
        Me.pbBudgetStatus.Location = New System.Drawing.Point(8, 213)
        Me.pbBudgetStatus.Name = "pbBudgetStatus"
        Me.pbBudgetStatus.Size = New System.Drawing.Size(232, 23)
        Me.pbBudgetStatus.TabIndex = 1
        '
        'dgvBudgets
        '
        Me.dgvBudgets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBudgets.Location = New System.Drawing.Point(6, 256)
        Me.dgvBudgets.Name = "dgvBudgets"
        Me.dgvBudgets.Size = New System.Drawing.Size(778, 240)
        Me.dgvBudgets.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.Wheat
        Me.TabPage4.Controls.Add(Me.lblTransactionStatus)
        Me.TabPage4.Controls.Add(Me.Label10)
        Me.TabPage4.Controls.Add(Me.txtTransactionResourceID)
        Me.TabPage4.Controls.Add(Me.btnDistribute)
        Me.TabPage4.Controls.Add(Me.btnDeleteTransaction)
        Me.TabPage4.Controls.Add(Me.btnViewTransactions)
        Me.TabPage4.Controls.Add(Me.dgvTransactions)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(791, 507)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Transaction"
        '
        'lblTransactionStatus
        '
        Me.lblTransactionStatus.AutoSize = True
        Me.lblTransactionStatus.Location = New System.Drawing.Point(362, 275)
        Me.lblTransactionStatus.Name = "lblTransactionStatus"
        Me.lblTransactionStatus.Size = New System.Drawing.Size(0, 13)
        Me.lblTransactionStatus.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(76, 84)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Tag = ""
        Me.Label10.Text = "Resource ID"
        '
        'txtTransactionResourceID
        '
        Me.txtTransactionResourceID.Location = New System.Drawing.Point(79, 100)
        Me.txtTransactionResourceID.Multiline = True
        Me.txtTransactionResourceID.Name = "txtTransactionResourceID"
        Me.txtTransactionResourceID.Size = New System.Drawing.Size(239, 32)
        Me.txtTransactionResourceID.TabIndex = 4
        '
        'btnDistribute
        '
        Me.btnDistribute.Location = New System.Drawing.Point(604, 100)
        Me.btnDistribute.Name = "btnDistribute"
        Me.btnDistribute.Size = New System.Drawing.Size(75, 23)
        Me.btnDistribute.TabIndex = 3
        Me.btnDistribute.Text = "Distribute"
        Me.btnDistribute.UseVisualStyleBackColor = True
        '
        'btnDeleteTransaction
        '
        Me.btnDeleteTransaction.Location = New System.Drawing.Point(604, 129)
        Me.btnDeleteTransaction.Name = "btnDeleteTransaction"
        Me.btnDeleteTransaction.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteTransaction.TabIndex = 2
        Me.btnDeleteTransaction.Text = "Delete"
        Me.btnDeleteTransaction.UseVisualStyleBackColor = True
        '
        'btnViewTransactions
        '
        Me.btnViewTransactions.Location = New System.Drawing.Point(604, 158)
        Me.btnViewTransactions.Name = "btnViewTransactions"
        Me.btnViewTransactions.Size = New System.Drawing.Size(75, 23)
        Me.btnViewTransactions.TabIndex = 1
        Me.btnViewTransactions.Text = "View"
        Me.btnViewTransactions.UseVisualStyleBackColor = True
        '
        'dgvTransactions
        '
        Me.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTransactions.Location = New System.Drawing.Point(69, 203)
        Me.dgvTransactions.Name = "dgvTransactions"
        Me.dgvTransactions.Size = New System.Drawing.Size(660, 298)
        Me.dgvTransactions.TabIndex = 0
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.Wheat
        Me.TabPage5.Controls.Add(Me.ReportViewer2)
        Me.TabPage5.Controls.Add(Me.btnExportPDF)
        Me.TabPage5.Controls.Add(Me.btnGenerateReport)
        Me.TabPage5.Controls.Add(Me.ReportViewer1)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(791, 507)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "report"
        '
        'ReportViewer2
        '
        Me.ReportViewer2.Location = New System.Drawing.Point(406, 250)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.ServerReport.BearerToken = Nothing
        Me.ReportViewer2.Size = New System.Drawing.Size(382, 246)
        Me.ReportViewer2.TabIndex = 1
        '
        'btnExportPDF
        '
        Me.btnExportPDF.Location = New System.Drawing.Point(306, 134)
        Me.btnExportPDF.Name = "btnExportPDF"
        Me.btnExportPDF.Size = New System.Drawing.Size(183, 58)
        Me.btnExportPDF.TabIndex = 4
        Me.btnExportPDF.Text = "Export PDF"
        Me.btnExportPDF.UseVisualStyleBackColor = True
        '
        'btnGenerateReport
        '
        Me.btnGenerateReport.Location = New System.Drawing.Point(306, 66)
        Me.btnGenerateReport.Name = "btnGenerateReport"
        Me.btnGenerateReport.Size = New System.Drawing.Size(183, 53)
        Me.btnGenerateReport.TabIndex = 3
        Me.btnGenerateReport.Text = "Generate Report"
        Me.btnGenerateReport.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Location = New System.Drawing.Point(8, 250)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(392, 246)
        Me.ReportViewer1.TabIndex = 2
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 529)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgvResources, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.dgvBudgets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.dgvTransactions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents chkShowPassword As CheckBox
    Friend WithEvents dgvResources As DataGridView
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtResourceName As TextBox
    Friend WithEvents txtResourceID As TextBox
    Friend WithEvents btnAddResource As Button
    Friend WithEvents btnUpdateResource As Button
    Friend WithEvents btnDeleteResource As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvBudgets As DataGridView
    Friend WithEvents cmbPeriod As ComboBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents txtBudgetAmount As TextBox
    Friend WithEvents btnSendMoney As Button
    Friend WithEvents btnMonitor As Button
    Friend WithEvents btnDeleteBudget As Button
    Friend WithEvents pbBudgetStatus As ProgressBar
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblBudgetStatus As Label
    Friend WithEvents btnDistribute As Button
    Friend WithEvents btnDeleteTransaction As Button
    Friend WithEvents btnViewTransactions As Button
    Friend WithEvents dgvTransactions As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents txtTransactionResourceID As TextBox
    Friend WithEvents lblTransactionStatus As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents btnExportPDF As Button
    Friend WithEvents btnGenerateReport As Button
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
End Class
