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
        Me.txtTal1 = New System.Windows.Forms.TextBox()
        Me.txtTal2 = New System.Windows.Forms.TextBox()
        Me.btnRakna = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.cboRaknesatt = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txtTal1
        '
        Me.txtTal1.Location = New System.Drawing.Point(37, 38)
        Me.txtTal1.Name = "txtTal1"
        Me.txtTal1.Size = New System.Drawing.Size(106, 27)
        Me.txtTal1.TabIndex = 0
        '
        'txtTal2
        '
        Me.txtTal2.Location = New System.Drawing.Point(343, 38)
        Me.txtTal2.Name = "txtTal2"
        Me.txtTal2.Size = New System.Drawing.Size(127, 27)
        Me.txtTal2.TabIndex = 1
        '
        'btnRakna
        '
        Me.btnRakna.Location = New System.Drawing.Point(343, 109)
        Me.btnRakna.Name = "btnRakna"
        Me.btnRakna.Size = New System.Drawing.Size(82, 30)
        Me.btnRakna.TabIndex = 2
        Me.btnRakna.Text = "Räkna"
        Me.btnRakna.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(529, 41)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(53, 20)
        Me.lblResult.TabIndex = 3
        Me.lblResult.Text = "Label1"
        '
        'cboRaknesatt
        '
        Me.cboRaknesatt.FormattingEnabled = True
        Me.cboRaknesatt.Items.AddRange(New Object() {"+", "-", "*", "/", "%"})
        Me.cboRaknesatt.Location = New System.Drawing.Point(183, 37)
        Me.cboRaknesatt.Name = "cboRaknesatt"
        Me.cboRaknesatt.Size = New System.Drawing.Size(118, 28)
        Me.cboRaknesatt.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 192)
        Me.Controls.Add(Me.cboRaknesatt)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnRakna)
        Me.Controls.Add(Me.txtTal2)
        Me.Controls.Add(Me.txtTal1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Enkel Matte"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTal1 As TextBox
    Friend WithEvents txtTal2 As TextBox
    Friend WithEvents btnRakna As Button
    Friend WithEvents lblResult As Label
    Friend WithEvents cboRaknesatt As ComboBox
End Class
