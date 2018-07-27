<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Goals
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
        Me.cmdsave = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtUserN = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmdBack
        '
        Me.cmdBack.Location = New System.Drawing.Point(147, 245)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(100, 30)
        Me.cmdBack.TabIndex = 21
        Me.cmdBack.Text = "Back"
        Me.cmdBack.UseVisualStyleBackColor = True
        '
        'cmdsave
        '
        Me.cmdsave.Location = New System.Drawing.Point(147, 200)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(100, 30)
        Me.cmdsave.TabIndex = 20
        Me.cmdsave.Text = "Save"
        Me.cmdsave.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(108, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 18)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Price:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(108, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 18)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Goal:"
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(166, 139)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(100, 20)
        Me.txtPass.TabIndex = 17
        '
        'txtUserN
        '
        Me.txtUserN.Location = New System.Drawing.Point(166, 99)
        Me.txtUserN.Name = "txtUserN"
        Me.txtUserN.Size = New System.Drawing.Size(100, 20)
        Me.txtUserN.TabIndex = 16
        '
        'Goals
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 354)
        Me.Controls.Add(Me.cmdBack)
        Me.Controls.Add(Me.cmdsave)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUserN)
        Me.Name = "Goals"
        Me.Text = "Goals"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdBack As Button
    Friend WithEvents cmdsave As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtUserN As TextBox
End Class
