<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewUser
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
        Me.cmdBack = New System.Windows.Forms.Button()
        Me.cmdCreateUser = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtConfirmP = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtUserN = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmdBack
        '
        Me.cmdBack.Location = New System.Drawing.Point(157, 319)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(100, 30)
        Me.cmdBack.TabIndex = 15
        Me.cmdBack.Text = "Back"
        Me.cmdBack.UseVisualStyleBackColor = True
        '
        'cmdCreateUser
        '
        Me.cmdCreateUser.Location = New System.Drawing.Point(157, 274)
        Me.cmdCreateUser.Name = "cmdCreateUser"
        Me.cmdCreateUser.Size = New System.Drawing.Size(100, 30)
        Me.cmdCreateUser.TabIndex = 14
        Me.cmdCreateUser.Text = "Create User"
        Me.cmdCreateUser.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(43, 210)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 18)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Confirm Password:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 18)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Password:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 18)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "User Name:"
        '
        'txtConfirmP
        '
        Me.txtConfirmP.Location = New System.Drawing.Point(210, 208)
        Me.txtConfirmP.Name = "txtConfirmP"
        Me.txtConfirmP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmP.Size = New System.Drawing.Size(100, 20)
        Me.txtConfirmP.TabIndex = 10
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(210, 169)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(100, 20)
        Me.txtPass.TabIndex = 9
        '
        'txtUserN
        '
        Me.txtUserN.Location = New System.Drawing.Point(210, 129)
        Me.txtUserN.Name = "txtUserN"
        Me.txtUserN.Size = New System.Drawing.Size(100, 20)
        Me.txtUserN.TabIndex = 8
        '
        'NewUservb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmdBack)
        Me.Controls.Add(Me.cmdCreateUser)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtConfirmP)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUserN)
        Me.Name = "NewUservb"
        Me.Text = "NewUservb"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdBack As Button
    Friend WithEvents cmdCreateUser As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtConfirmP As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtUserN As TextBox
End Class
