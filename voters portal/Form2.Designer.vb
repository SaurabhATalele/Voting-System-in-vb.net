<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.unamebox = New System.Windows.Forms.TextBox()
        Me.passwordbox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(582, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 41)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LOGIN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(436, 214)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(436, 275)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password"
        '
        'ComboBox1
        '
        Me.ComboBox1.DisplayMember = "Voter,Admin"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"User", "Admin"})
        Me.ComboBox1.Location = New System.Drawing.Point(579, 339)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(154, 28)
        Me.ComboBox1.TabIndex = 4
        Me.ComboBox1.Text = "Select type"
        Me.ComboBox1.ValueMember = "Voter,Admin"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(436, 332)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 28)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Type"
        '
        'unamebox
        '
        Me.unamebox.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.unamebox.Location = New System.Drawing.Point(579, 214)
        Me.unamebox.Name = "unamebox"
        Me.unamebox.Size = New System.Drawing.Size(154, 32)
        Me.unamebox.TabIndex = 6
        '
        'passwordbox
        '
        Me.passwordbox.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.passwordbox.Location = New System.Drawing.Point(580, 278)
        Me.passwordbox.Name = "passwordbox"
        Me.passwordbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordbox.Size = New System.Drawing.Size(154, 32)
        Me.passwordbox.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Lime
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Button1.Location = New System.Drawing.Point(556, 416)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(156, 33)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "LOGIN"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(556, 452)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 28)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Not Registered?"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkOrange
        Me.Button2.Location = New System.Drawing.Point(556, 492)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(156, 36)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "SignUp"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(1310, 571)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.passwordbox)
        Me.Controls.Add(Me.unamebox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents unamebox As TextBox
    Friend WithEvents passwordbox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
End Class
