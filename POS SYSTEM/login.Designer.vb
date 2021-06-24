<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LOGIN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LOGIN))
        Me.closebtn = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaLinePanel1 = New Guna.UI.WinForms.GunaLinePanel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.txtpassword = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLabel35 = New Guna.UI.WinForms.GunaLabel()
        Me.btnlogin = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.lbl_changepassword = New Guna.UI.WinForms.GunaLabel()
        Me.cbshowpassword = New Guna.UI.WinForms.GunaCheckBox()
        Me.GunaLinePanel1.SuspendLayout()
        Me.SuspendLayout()
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
        'GunaLinePanel1
        '
        Me.GunaLinePanel1.Controls.Add(Me.GunaLabel1)
        Me.GunaLinePanel1.Controls.Add(Me.closebtn)
        Me.GunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaLinePanel1.LineColor = System.Drawing.Color.Black
        Me.GunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaLinePanel1.Name = "GunaLinePanel1"
        Me.GunaLinePanel1.Size = New System.Drawing.Size(416, 30)
        Me.GunaLinePanel1.TabIndex = 1
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(3, 1)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(239, 25)
        Me.GunaLabel1.TabIndex = 4
        Me.GunaLabel1.Text = "NYAME TEASE ENTERPRISE"
        Me.GunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtpassword
        '
        Me.txtpassword.Animated = True
        Me.txtpassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpassword.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpassword.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!)
        Me.txtpassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.txtpassword.LineColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtpassword.Location = New System.Drawing.Point(146, 52)
        Me.txtpassword.MaxLength = 12
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(231, 37)
        Me.txtpassword.TabIndex = 112
        '
        'GunaLabel35
        '
        Me.GunaLabel35.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaLabel35.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.GunaLabel35.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.GunaLabel35.Location = New System.Drawing.Point(39, 52)
        Me.GunaLabel35.Name = "GunaLabel35"
        Me.GunaLabel35.Size = New System.Drawing.Size(107, 37)
        Me.GunaLabel35.TabIndex = 111
        Me.GunaLabel35.Text = "Password"
        Me.GunaLabel35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnlogin
        '
        Me.btnlogin.Animated = True
        Me.btnlogin.AnimationHoverSpeed = 0.02!
        Me.btnlogin.AnimationSpeed = 0.01!
        Me.btnlogin.BackColor = System.Drawing.Color.Transparent
        Me.btnlogin.BaseColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnlogin.BorderColor = System.Drawing.Color.Black
        Me.btnlogin.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnlogin.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnlogin.CheckedForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnlogin.CheckedImage = Nothing
        Me.btnlogin.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnlogin.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnlogin.FocusedColor = System.Drawing.Color.Empty
        Me.btnlogin.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.btnlogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnlogin.Image = Nothing
        Me.btnlogin.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnlogin.LineBottom = 5
        Me.btnlogin.LineColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnlogin.Location = New System.Drawing.Point(146, 121)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnlogin.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnlogin.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnlogin.OnHoverImage = Nothing
        Me.btnlogin.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnlogin.OnPressedColor = System.Drawing.Color.Black
        Me.btnlogin.OnPressedDepth = 0
        Me.btnlogin.Radius = 15
        Me.btnlogin.Size = New System.Drawing.Size(98, 30)
        Me.btnlogin.TabIndex = 123
        Me.btnlogin.Text = "Login"
        Me.btnlogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_changepassword
        '
        Me.lbl_changepassword.AutoSize = True
        Me.lbl_changepassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_changepassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.lbl_changepassword.Location = New System.Drawing.Point(12, 136)
        Me.lbl_changepassword.Name = "lbl_changepassword"
        Me.lbl_changepassword.Size = New System.Drawing.Size(104, 15)
        Me.lbl_changepassword.TabIndex = 124
        Me.lbl_changepassword.Text = "change password?"
        '
        'cbshowpassword
        '
        Me.cbshowpassword.BaseColor = System.Drawing.Color.White
        Me.cbshowpassword.CheckedOffColor = System.Drawing.Color.Gray
        Me.cbshowpassword.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbshowpassword.FillColor = System.Drawing.Color.White
        Me.cbshowpassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.cbshowpassword.Location = New System.Drawing.Point(307, 97)
        Me.cbshowpassword.Name = "cbshowpassword"
        Me.cbshowpassword.Size = New System.Drawing.Size(108, 20)
        Me.cbshowpassword.TabIndex = 129
        Me.cbshowpassword.Text = "show password"
        '
        'LOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(416, 163)
        Me.Controls.Add(Me.cbshowpassword)
        Me.Controls.Add(Me.lbl_changepassword)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.GunaLabel35)
        Me.Controls.Add(Me.GunaLinePanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LOGIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "USER LOGIN"
        Me.GunaLinePanel1.ResumeLayout(False)
        Me.GunaLinePanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents closebtn As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaLinePanel1 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtpassword As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLabel35 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnlogin As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents lbl_changepassword As Guna.UI.WinForms.GunaLabel
    Friend WithEvents cbshowpassword As Guna.UI.WinForms.GunaCheckBox
End Class
