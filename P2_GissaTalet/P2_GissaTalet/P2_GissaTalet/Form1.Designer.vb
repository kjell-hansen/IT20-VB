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
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DIn gissning..."
        '
        'txtGissning
        '
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
        Me.lblAntalGissningar.Size = New System.Drawing.Size(159, 20)
        Me.lblAntalGissningar.TabIndex = 3
        Me.lblAntalGissningar.Text = "Du har gissat ... gånger"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
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
End Class
