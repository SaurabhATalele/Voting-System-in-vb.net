<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class signup
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.textbox1 = New System.Windows.Forms.TextBox()
        Me.pwd = New System.Windows.Forms.TextBox()
        Me.voterid = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(390, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SIGNUP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(276, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(276, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(276, 242)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 28)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Voter ID"
        '
        'textbox1
        '
        Me.textbox1.Location = New System.Drawing.Point(523, 111)
        Me.textbox1.Name = "textbox1"
        Me.textbox1.Size = New System.Drawing.Size(191, 27)
        Me.textbox1.TabIndex = 5
        '
        'pwd
        '
        Me.pwd.Location = New System.Drawing.Point(523, 180)
        Me.pwd.Name = "pwd"
        Me.pwd.Size = New System.Drawing.Size(191, 27)
        Me.pwd.TabIndex = 6
        '
        'voterid
        '
        Me.voterid.Location = New System.Drawing.Point(523, 242)
        Me.voterid.Name = "voterid"
        Me.voterid.Size = New System.Drawing.Size(191, 27)
        Me.voterid.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(354, 323)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(175, 43)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "SIGNUP"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'signup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 510)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.voterid)
        Me.Controls.Add(Me.pwd)
        Me.Controls.Add(Me.textbox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "signup"
        Me.Text = "signup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents textbox1 As TextBox
    Friend WithEvents pwd As TextBox
    Friend WithEvents voterid As TextBox
    Friend WithEvents Button1 As Button
End Class
