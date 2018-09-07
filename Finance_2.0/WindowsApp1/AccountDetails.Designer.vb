<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountDetails
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
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CmdReturn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAOW = New System.Windows.Forms.TextBox()
        Me.txtHPW = New System.Windows.Forms.TextBox()
        Me.txtROP = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.cmdInc = New System.Windows.Forms.Button()
        Me.cmdEx = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(242, 327)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(121, 27)
        Me.cmdSave.TabIndex = 20
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(221, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 20)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Set to username"
        '
        'CmdReturn
        '
        Me.CmdReturn.Location = New System.Drawing.Point(242, 426)
        Me.CmdReturn.Name = "CmdReturn"
        Me.CmdReturn.Size = New System.Drawing.Size(121, 27)
        Me.CmdReturn.TabIndex = 18
        Me.CmdReturn.Text = "Return"
        Me.CmdReturn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(109, 221)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(214, 20)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Amount of weeks worked:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(109, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Amount of hours per week:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(109, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Rate of pay:"
        '
        'txtAOW
        '
        Me.txtAOW.Location = New System.Drawing.Point(342, 221)
        Me.txtAOW.Name = "txtAOW"
        Me.txtAOW.Size = New System.Drawing.Size(100, 20)
        Me.txtAOW.TabIndex = 13
        '
        'txtHPW
        '
        Me.txtHPW.Location = New System.Drawing.Point(342, 170)
        Me.txtHPW.Name = "txtHPW"
        Me.txtHPW.Size = New System.Drawing.Size(100, 20)
        Me.txtHPW.TabIndex = 12
        '
        'txtROP
        '
        Me.txtROP.Location = New System.Drawing.Point(342, 118)
        Me.txtROP.Name = "txtROP"
        Me.txtROP.Size = New System.Drawing.Size(100, 20)
        Me.txtROP.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(109, 275)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(177, 20)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Set Current Balance:"
        '
        'txtBalance
        '
        Me.txtBalance.Location = New System.Drawing.Point(342, 275)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.Size = New System.Drawing.Size(100, 20)
        Me.txtBalance.TabIndex = 21
        '
        'cmdInc
        '
        Me.cmdInc.Location = New System.Drawing.Point(242, 360)
        Me.cmdInc.Name = "cmdInc"
        Me.cmdInc.Size = New System.Drawing.Size(121, 27)
        Me.cmdInc.TabIndex = 24
        Me.cmdInc.Text = "Income"
        Me.cmdInc.UseVisualStyleBackColor = True
        '
        'cmdEx
        '
        Me.cmdEx.Location = New System.Drawing.Point(242, 393)
        Me.cmdEx.Name = "cmdEx"
        Me.cmdEx.Size = New System.Drawing.Size(121, 27)
        Me.cmdEx.TabIndex = 23
        Me.cmdEx.Text = "Expenditure"
        Me.cmdEx.UseVisualStyleBackColor = True
        '
        'AccountDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 493)
        Me.Controls.Add(Me.cmdInc)
        Me.Controls.Add(Me.cmdEx)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtBalance)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CmdReturn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAOW)
        Me.Controls.Add(Me.txtHPW)
        Me.Controls.Add(Me.txtROP)
        Me.Name = "AccountDetails"
        Me.Text = "Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdSave As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents CmdReturn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAOW As TextBox
    Friend WithEvents txtHPW As TextBox
    Friend WithEvents txtROP As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtBalance As TextBox
    Friend WithEvents cmdInc As Button
    Friend WithEvents cmdEx As Button
End Class
