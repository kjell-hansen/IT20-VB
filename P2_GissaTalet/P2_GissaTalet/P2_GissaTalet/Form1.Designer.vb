<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtGissning = New System.Windows.Forms.TextBox()
        Me.btnGissa = New System.Windows.Forms.Button()
        Me.lblAntalGissningar = New System.Windows.Forms.Label()
        Me.btnGeUpp = New System.Windows.Forms.Button()
        Me.btnBorjaOm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Din gissning..."
        '
        'txtGissning
        '
        Me.txtGissning.AcceptsReturn = True
        Me.txtGissning.Location = New System.Drawing.Point(161, 33)
        Me.txtGissning.Name = "txtGissning"
        Me.txtGissning.Size = New System.Drawing.Size(88, 27)
        Me.txtGissning.TabIndex = 1
        '
        'btnGissa
        '
        Me.btnGissa.Location = New System.Drawing.Point(154, 77)
        Me.btnGissa.Name = "btnGissa"
        Me.btnGissa.Size = New System.Drawing.Size(96, 35)
        Me.btnGissa.TabIndex = 2
        Me.btnGissa.Text = "Gissa!"
        Me.btnGissa.UseVisualStyleBackColor = True
        '
        'lblAntalGissningar
        '
        Me.lblAntalGissningar.AutoSize = True
        Me.lblAntalGissningar.Location = New System.Drawing.Point(312, 33)
        Me.lblAntalGissningar.Name = "lblAntalGissningar"
        Me.lblAntalGissningar.Size = New System.Drawing.Size(302, 20)
        Me.lblAntalGissningar.TabIndex = 3
        Me.lblAntalGissningar.Text = "Det gäller att gissa ett tal mellan 1 och 1000"
        '
        'btnGeUpp
        '
        Me.btnGeUpp.Location = New System.Drawing.Point(157, 131)
        Me.btnGeUpp.Name = "btnGeUpp"
        Me.btnGeUpp.Size = New System.Drawing.Size(114, 36)
        Me.btnGeUpp.TabIndex = 4
        Me.btnGeUpp.Text = "Jag ger upp!"
        Me.btnGeUpp.UseVisualStyleBackColor = True
        '
        'btnBorjaOm
        '
        Me.btnBorjaOm.Location = New System.Drawing.Point(157, 197)
        Me.btnBorjaOm.Name = "btnBorjaOm"
        Me.btnBorjaOm.Size = New System.Drawing.Size(117, 42)
        Me.btnBorjaOm.TabIndex = 5
        Me.btnBorjaOm.Text = "Börja om"
        Me.btnBorjaOm.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.btnGissa
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnBorjaOm)
        Me.Controls.Add(Me.btnGeUpp)
        Me.Controls.Add(Me.lblAntalGissningar)
        Me.Controls.Add(Me.btnGissa)
        Me.Controls.Add(Me.txtGissning)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtGissning As TextBox
    Friend WithEvents btnGissa As Button
    Friend WithEvents lblAntalGissningar As Label
    Friend WithEvents btnGeUpp As Button
    Friend WithEvents btnBorjaOm As Button
End Class
