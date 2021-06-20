<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Addvoter
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.name = New System.Windows.Forms.TextBox()
        Me.Address = New System.Windows.Forms.TextBox()
        Me.gender = New System.Windows.Forms.TextBox()
        Me.age = New System.Windows.Forms.TextBox()
        Me.id = New System.Windows.Forms.TextBox()
        Me.city = New System.Windows.Forms.ComboBox()
        Me.Add = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(599, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Create New Voter"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(379, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(379, 254)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(379, 322)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 28)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "City"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(379, 390)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 28)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Age"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(379, 455)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 28)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Gender"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(379, 514)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 28)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Voter ID"
        '
        'name
        '
        Me.name.Location = New System.Drawing.Point(646, 169)
        Me.name.Name = "name"
        Me.name.Size = New System.Drawing.Size(243, 27)
        Me.name.TabIndex = 7
        '
        'Address
        '
        Me.Address.Location = New System.Drawing.Point(646, 247)
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(243, 27)
        Me.Address.TabIndex = 8
        '
        'gender
        '
        Me.gender.Location = New System.Drawing.Point(646, 456)
        Me.gender.Name = "gender"
        Me.gender.Size = New System.Drawing.Size(243, 27)
        Me.gender.TabIndex = 9
        '
        'age
        '
        Me.age.Location = New System.Drawing.Point(646, 383)
        Me.age.Name = "age"
        Me.age.Size = New System.Drawing.Size(243, 27)
        Me.age.TabIndex = 10
        '
        'id
        '
        Me.id.Location = New System.Drawing.Point(646, 507)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(243, 27)
        Me.id.TabIndex = 11
        '
        'city
        '
        Me.city.FormattingEnabled = True
        Me.city.Items.AddRange(New Object() {"Amravati", "Nagpur", "Pune", "Mumbai"})
        Me.city.Location = New System.Drawing.Point(646, 314)
        Me.city.Name = "city"
        Me.city.Size = New System.Drawing.Size(243, 28)
        Me.city.TabIndex = 12
        Me.city.Tag = ""
        '
        'Add
        '
        Me.Add.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Add.Location = New System.Drawing.Point(410, 580)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(203, 37)
        Me.Add.TabIndex = 13
        Me.Add.Text = "Add"
        Me.Add.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(673, 580)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(203, 37)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Addvoter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1307, 693)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Add)
        Me.Controls.Add(Me.city)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.age)
        Me.Controls.Add(Me.gender)
        Me.Controls.Add(Me.Address)
        Me.Controls.Add(Me.name)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)

        Me.Text = "Addvoter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents name As TextBox
    Friend WithEvents Address As TextBox
    Friend WithEvents gender As TextBox
    Friend WithEvents age As TextBox
    Friend WithEvents id As TextBox
    Friend WithEvents city As ComboBox
    Friend WithEvents Add As Button
    Friend WithEvents Button1 As Button
End Class
