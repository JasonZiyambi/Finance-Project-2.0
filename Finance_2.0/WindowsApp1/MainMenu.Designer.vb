﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.CmdAccount = New System.Windows.Forms.Button()
        Me.cmdLogout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdProjections = New System.Windows.Forms.Button()
        Me.cmdAnalysis = New System.Windows.Forms.Button()
        Me.cmdAdvisor = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CmdCTG = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CmdAccount
        '
        Me.CmdAccount.Location = New System.Drawing.Point(347, 184)
        Me.CmdAccount.Name = "CmdAccount"
        Me.CmdAccount.Size = New System.Drawing.Size(115, 37)
        Me.CmdAccount.TabIndex = 15
        Me.CmdAccount.Text = "Manage Account"
        Me.CmdAccount.UseVisualStyleBackColor = True
        '
        'cmdLogout
        '
        Me.cmdLogout.Location = New System.Drawing.Point(347, 317)
        Me.cmdLogout.Name = "cmdLogout"
        Me.cmdLogout.Size = New System.Drawing.Size(115, 36)
        Me.cmdLogout.TabIndex = 14
        Me.cmdLogout.Text = "Logout"
        Me.cmdLogout.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(310, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 35)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Main Menu"
        '
        'cmdProjections
        '
        Me.cmdProjections.Location = New System.Drawing.Point(600, 251)
        Me.cmdProjections.Name = "cmdProjections"
        Me.cmdProjections.Size = New System.Drawing.Size(115, 35)
        Me.cmdProjections.TabIndex = 12
        Me.cmdProjections.Text = "Projections"
        Me.cmdProjections.UseVisualStyleBackColor = True
        '
        'cmdAnalysis
        '
        Me.cmdAnalysis.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cmdAnalysis.Location = New System.Drawing.Point(347, 250)
        Me.cmdAnalysis.Name = "cmdAnalysis"
        Me.cmdAnalysis.Size = New System.Drawing.Size(115, 36)
        Me.cmdAnalysis.TabIndex = 11
        Me.cmdAnalysis.Text = "Analysis"
        Me.cmdAnalysis.UseVisualStyleBackColor = False
        '
        'cmdAdvisor
        '
        Me.cmdAdvisor.Location = New System.Drawing.Point(86, 250)
        Me.cmdAdvisor.Name = "cmdAdvisor"
        Me.cmdAdvisor.Size = New System.Drawing.Size(115, 36)
        Me.cmdAdvisor.TabIndex = 10
        Me.cmdAdvisor.Text = "Advisor "
        Me.cmdAdvisor.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(193, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 20)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Current Balance:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(343, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 20)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "                      "
        '
        'CmdCTG
        '
        Me.CmdCTG.Location = New System.Drawing.Point(86, 184)
        Me.CmdCTG.Name = "CmdCTG"
        Me.CmdCTG.Size = New System.Drawing.Size(115, 35)
        Me.CmdCTG.TabIndex = 18
        Me.CmdCTG.Text = "Continue to Goals"
        Me.CmdCTG.UseVisualStyleBackColor = True
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CmdCTG)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmdAccount)
        Me.Controls.Add(Me.cmdLogout)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdProjections)
        Me.Controls.Add(Me.cmdAnalysis)
        Me.Controls.Add(Me.cmdAdvisor)
        Me.Name = "MainMenu"
        Me.Text = "MainMenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmdAccount As Button
    Friend WithEvents cmdLogout As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdProjections As Button
    Friend WithEvents cmdAnalysis As Button
    Friend WithEvents cmdAdvisor As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CmdCTG As Button
End Class
