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
        Me.txtTal = New System.Windows.Forms.TextBox()
        Me.btnLaggTill = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblSumma = New System.Windows.Forms.Label()
        Me.lblMedel = New System.Windows.Forms.Label()
        Me.lstTal = New System.Windows.Forms.ListBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnBorjaOm = New System.Windows.Forms.Button()
        Me.btnTaBort = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtTal
        '
        Me.txtTal.Location = New System.Drawing.Point(37, 23)
        Me.txtTal.Name = "txtTal"
        Me.txtTal.Size = New System.Drawing.Size(110, 27)
        Me.txtTal.TabIndex = 0
        '
        'btnLaggTill
        '
        Me.btnLaggTill.Location = New System.Drawing.Point(179, 20)
        Me.btnLaggTill.Name = "btnLaggTill"
        Me.btnLaggTill.Size = New System.Drawing.Size(82, 33)
        Me.btnLaggTill.TabIndex = 1
        Me.btnLaggTill.Text = "Lägg till"
        Me.btnLaggTill.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Summa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Medel"
        '
        'lblSumma
        '
        Me.lblSumma.AutoSize = True
        Me.lblSumma.Location = New System.Drawing.Point(112, 84)
        Me.lblSumma.Name = "lblSumma"
        Me.lblSumma.Size = New System.Drawing.Size(76, 20)
        Me.lblSumma.TabIndex = 4
        Me.lblSumma.Text = "lblSumma"
        '
        'lblMedel
        '
        Me.lblMedel.AutoSize = True
        Me.lblMedel.Location = New System.Drawing.Point(112, 123)
        Me.lblMedel.Name = "lblMedel"
        Me.lblMedel.Size = New System.Drawing.Size(68, 20)
        Me.lblMedel.TabIndex = 5
        Me.lblMedel.Text = "lblMedel"
        '
        'lstTal
        '
        Me.lstTal.FormattingEnabled = True
        Me.lstTal.ItemHeight = 20
        Me.lstTal.Location = New System.Drawing.Point(386, 23)
        Me.lstTal.Name = "lstTal"
        Me.lstTal.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstTal.Size = New System.Drawing.Size(123, 184)
        Me.lstTal.TabIndex = 6
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(212, 217)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(91, 42)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Avsluta"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnBorjaOm
        '
        Me.btnBorjaOm.Location = New System.Drawing.Point(88, 217)
        Me.btnBorjaOm.Name = "btnBorjaOm"
        Me.btnBorjaOm.Size = New System.Drawing.Size(91, 42)
        Me.btnBorjaOm.TabIndex = 8
        Me.btnBorjaOm.Text = "Börja om"
        Me.btnBorjaOm.UseVisualStyleBackColor = True
        '
        'btnTaBort
        '
        Me.btnTaBort.Enabled = False
        Me.btnTaBort.Location = New System.Drawing.Point(441, 216)
        Me.btnTaBort.Name = "btnTaBort"
        Me.btnTaBort.Size = New System.Drawing.Size(68, 33)
        Me.btnTaBort.TabIndex = 9
        Me.btnTaBort.Text = "Ta bort"
        Me.btnTaBort.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.btnLaggTill
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 277)
        Me.Controls.Add(Me.btnTaBort)
        Me.Controls.Add(Me.btnBorjaOm)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lstTal)
        Me.Controls.Add(Me.lblMedel)
        Me.Controls.Add(Me.lblSumma)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLaggTill)
        Me.Controls.Add(Me.txtTal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Rullande Beräkning"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTal As TextBox
    Friend WithEvents btnLaggTill As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblSumma As Label
    Friend WithEvents lblMedel As Label
    Friend WithEvents lstTal As ListBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnBorjaOm As Button
    Friend WithEvents btnTaBort As Button
End Class
