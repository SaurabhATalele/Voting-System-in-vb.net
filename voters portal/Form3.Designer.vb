<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.labelname = New System.Windows.Forms.Label()
        Me.labeladdr = New System.Windows.Forms.Label()
        Me.labelcity = New System.Windows.Forms.Label()
        Me.labelage = New System.Windows.Forms.Label()
        Me.labelgender = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.labelid = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(54, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(54, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(54, 247)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "City"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(54, 314)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 28)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Age"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(54, 373)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 28)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Gender"
        '
        'labelname
        '
        Me.labelname.AutoSize = True
        Me.labelname.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelname.Location = New System.Drawing.Point(260, 115)
        Me.labelname.Name = "labelname"
        Me.labelname.Size = New System.Drawing.Size(64, 28)
        Me.labelname.TabIndex = 5
        Me.labelname.Text = "Name"
        '
        'labeladdr
        '
        Me.labeladdr.AutoSize = True
        Me.labeladdr.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labeladdr.Location = New System.Drawing.Point(260, 173)
        Me.labeladdr.Name = "labeladdr"
        Me.labeladdr.Size = New System.Drawing.Size(64, 28)
        Me.labeladdr.TabIndex = 6
        Me.labeladdr.Text = "Name"
        '
        'labelcity
        '
        Me.labelcity.AutoSize = True
        Me.labelcity.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelcity.Location = New System.Drawing.Point(260, 247)
        Me.labelcity.Name = "labelcity"
        Me.labelcity.Size = New System.Drawing.Size(64, 28)
        Me.labelcity.TabIndex = 7
        Me.labelcity.Text = "Name"
        '
        'labelage
        '
        Me.labelage.AutoSize = True
        Me.labelage.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelage.Location = New System.Drawing.Point(260, 314)
        Me.labelage.Name = "labelage"
        Me.labelage.Size = New System.Drawing.Size(64, 28)
        Me.labelage.TabIndex = 8
        Me.labelage.Text = "Name"
        '
        'labelgender
        '
        Me.labelgender.AutoSize = True
        Me.labelgender.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelgender.Location = New System.Drawing.Point(260, 373)
        Me.labelgender.Name = "labelgender"
        Me.labelgender.Size = New System.Drawing.Size(64, 28)
        Me.labelgender.TabIndex = 9
        Me.labelgender.Text = "Name"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(986, 113)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 52)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Vote"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(986, 207)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(147, 48)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(54, 439)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 28)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Voter ID"
        '
        'labelid
        '
        Me.labelid.AutoSize = True
        Me.labelid.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelid.Location = New System.Drawing.Point(260, 439)
        Me.labelid.Name = "labelid"
        Me.labelid.Size = New System.Drawing.Size(76, 28)
        Me.labelid.TabIndex = 13
        Me.labelid.Text = "Gender"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1356, 523)
        Me.Controls.Add(Me.labelid)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.labelgender)
        Me.Controls.Add(Me.labelage)
        Me.Controls.Add(Me.labelcity)
        Me.Controls.Add(Me.labeladdr)
        Me.Controls.Add(Me.labelname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents labelname As Label
    Friend WithEvents labeladdr As Label
    Friend WithEvents labelcity As Label
    Friend WithEvents labelage As Label
    Friend WithEvents labelgender As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents labelid As Label
End Class
