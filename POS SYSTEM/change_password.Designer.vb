<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class change_password
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(change_password))
        Me.GunaLinePanel1 = New Guna.UI.WinForms.GunaLinePanel()
        Me.btnclose = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.closebtn = New Guna.UI.WinForms.GunaImageButton()
        Me.btnchange = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.txtoldpassword = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLabel35 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.txtnewpassword = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.txtrepeatpassword = New Guna.UI.WinForms.GunaLineTextBox()
        Me.lblpassword = New Guna.UI.WinForms.GunaLabel()
        Me.cbshowpassword = New Guna.UI.WinForms.GunaCheckBox()
        Me.GunaLinePanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaLinePanel1
        '
        Me.GunaLinePanel1.Controls.Add(Me.btnclose)
        Me.GunaLinePanel1.Controls.Add(Me.GunaLabel1)
        Me.GunaLinePanel1.Controls.Add(Me.closebtn)
        Me.GunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaLinePanel1.LineColor = System.Drawing.Color.Black
        Me.GunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaLinePanel1.Name = "GunaLinePanel1"
        Me.GunaLinePanel1.Size = New System.Drawing.Size(391, 30)
        Me.GunaLinePanel1.TabIndex = 2
        '
        'btnclose
        '
        Me.btnclose.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnclose.Image = CType(resources.GetObject("btnclose.Image"), System.Drawing.Image)
        Me.btnclose.ImageSize = New System.Drawing.Size(32, 32)
        Me.btnclose.Location = New System.Drawing.Point(362, 0)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.OnHoverImage = Nothing
        Me.btnclose.OnHoverImageOffset = New System.Drawing.Point(-1, 0)
        Me.btnclose.Size = New System.Drawing.Size(29, 30)
        Me.btnclose.TabIndex = 5
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(4, 3)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(226, 25)
        Me.GunaLabel1.TabIndex = 4
        Me.GunaLabel1.Text = "REXHUNDUF ENTERPRISE"
        Me.GunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'closebtn
        '
        Me.closebtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.closebtn.Image = CType(resources.GetObject("closebtn.Image"), System.Drawing.Image)
        Me.closebtn.ImageSize = New System.Drawing.Size(32, 32)
        Me.closebtn.Location = New System.Drawing.Point(390, 0)
        Me.closebtn.Name = "closebtn"
        Me.closebtn.OnHoverImage = Nothing
        Me.closebtn.OnHoverImageOffset = New System.Drawing.Point(-1, 0)
        Me.closebtn.Size = New System.Drawing.Size(29, 30)
        Me.closebtn.TabIndex = 0
        '
        'btnchange
        '
        Me.btnchange.Animated = True
        Me.btnchange.AnimationHoverSpeed = 0.02!
        Me.btnchange.AnimationSpeed = 0.01!
        Me.btnchange.BackColor = System.Drawing.Color.Transparent
        Me.btnchange.BaseColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnchange.BorderColor = System.Drawing.Color.Black
        Me.btnchange.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnchange.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnchange.CheckedForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnchange.CheckedImage = Nothing
        Me.btnchange.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnchange.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnchange.FocusedColor = System.Drawing.Color.Empty
        Me.btnchange.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.btnchange.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnchange.Image = Nothing
        Me.btnchange.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnchange.LineBottom = 5
        Me.btnchange.LineColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnchange.Location = New System.Drawing.Point(127, 233)
        Me.btnchange.Name = "btnchange"
        Me.btnchange.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnchange.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnchange.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnchange.OnHoverImage = Nothing
        Me.btnchange.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnchange.OnPressedColor = System.Drawing.Color.Black
        Me.btnchange.OnPressedDepth = 0
        Me.btnchange.Radius = 15
        Me.btnchange.Size = New System.Drawing.Size(141, 30)
        Me.btnchange.TabIndex = 126
        Me.btnchange.Text = "Change Password"
        Me.btnchange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtoldpassword
        '
        Me.txtoldpassword.Animated = True
        Me.txtoldpassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtoldpassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtoldpassword.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtoldpassword.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!)
        Me.txtoldpassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.txtoldpassword.LineColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtoldpassword.Location = New System.Drawing.Point(146, 57)
        Me.txtoldpassword.MaxLength = 12
        Me.txtoldpassword.Name = "txtoldpassword"
        Me.txtoldpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtoldpassword.Size = New System.Drawing.Size(231, 37)
        Me.txtoldpassword.TabIndex = 125
        '
        'GunaLabel35
        '
        Me.GunaLabel35.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaLabel35.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.GunaLabel35.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GunaLabel35.Location = New System.Drawing.Point(9, 57)
        Me.GunaLabel35.Name = "GunaLabel35"
        Me.GunaLabel35.Size = New System.Drawing.Size(136, 37)
        Me.GunaLabel35.TabIndex = 124
        Me.GunaLabel35.Text = "Old Password"
        Me.GunaLabel35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaLabel2
        '
        Me.GunaLabel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.GunaLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GunaLabel2.Location = New System.Drawing.Point(9, 101)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(136, 37)
        Me.GunaLabel2.TabIndex = 124
        Me.GunaLabel2.Text = "New Password"
        Me.GunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtnewpassword
        '
        Me.txtnewpassword.Animated = True
        Me.txtnewpassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtnewpassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtnewpassword.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtnewpassword.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!)
        Me.txtnewpassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.txtnewpassword.LineColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtnewpassword.Location = New System.Drawing.Point(147, 101)
        Me.txtnewpassword.MaxLength = 12
        Me.txtnewpassword.Name = "txtnewpassword"
        Me.txtnewpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtnewpassword.Size = New System.Drawing.Size(231, 37)
        Me.txtnewpassword.TabIndex = 125
        '
        'GunaLabel3
        '
        Me.GunaLabel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.GunaLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GunaLabel3.Location = New System.Drawing.Point(9, 144)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(136, 37)
        Me.GunaLabel3.TabIndex = 124
        Me.GunaLabel3.Text = "Repeat Passowrd"
        Me.GunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtrepeatpassword
        '
        Me.txtrepeatpassword.Animated = True
        Me.txtrepeatpassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtrepeatpassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtrepeatpassword.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtrepeatpassword.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!)
        Me.txtrepeatpassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.txtrepeatpassword.LineColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtrepeatpassword.Location = New System.Drawing.Point(147, 144)
        Me.txtrepeatpassword.MaxLength = 12
        Me.txtrepeatpassword.Name = "txtrepeatpassword"
        Me.txtrepeatpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtrepeatpassword.Size = New System.Drawing.Size(231, 37)
        Me.txtrepeatpassword.TabIndex = 125
        '
        'lblpassword
        '
        Me.lblpassword.AutoSize = True
        Me.lblpassword.BackColor = System.Drawing.Color.Transparent
        Me.lblpassword.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblpassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.lblpassword.Location = New System.Drawing.Point(77, 195)
        Me.lblpassword.Name = "lblpassword"
        Me.lblpassword.Size = New System.Drawing.Size(0, 21)
        Me.lblpassword.TabIndex = 127
        Me.lblpassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbshowpassword
        '
        Me.cbshowpassword.BaseColor = System.Drawing.Color.White
        Me.cbshowpassword.CheckedOffColor = System.Drawing.Color.Gray
        Me.cbshowpassword.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbshowpassword.FillColor = System.Drawing.Color.White
        Me.cbshowpassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.cbshowpassword.Location = New System.Drawing.Point(276, 187)
        Me.cbshowpassword.Name = "cbshowpassword"
        Me.cbshowpassword.Size = New System.Drawing.Size(108, 20)
        Me.cbshowpassword.TabIndex = 128
        Me.cbshowpassword.Text = "show password"
        '
        'change_password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(391, 275)
        Me.Controls.Add(Me.cbshowpassword)
        Me.Controls.Add(Me.lblpassword)
        Me.Controls.Add(Me.btnchange)
        Me.Controls.Add(Me.txtrepeatpassword)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.txtnewpassword)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.txtoldpassword)
        Me.Controls.Add(Me.GunaLabel35)
        Me.Controls.Add(Me.GunaLinePanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "change_password"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CHANGE PASSWORD"
        Me.GunaLinePanel1.ResumeLayout(False)
        Me.GunaLinePanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaLinePanel1 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents closebtn As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents btnclose As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents btnchange As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents txtoldpassword As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLabel35 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtnewpassword As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtrepeatpassword As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents lblpassword As Guna.UI.WinForms.GunaLabel
    Friend WithEvents cbshowpassword As Guna.UI.WinForms.GunaCheckBox
End Class
