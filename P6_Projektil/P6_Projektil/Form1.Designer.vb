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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtVinkel = New System.Windows.Forms.TextBox()
        Me.txtHastighet = New System.Windows.Forms.TextBox()
        Me.btnRita = New System.Windows.Forms.Button()
        Me.btnRensa = New System.Windows.Forms.Button()
        Me.picWorld = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.dlgColor = New System.Windows.Forms.ColorDialog()
        CType(Me.picWorld, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Vinkel"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Hastighet"
        '
        'txtVinkel
        '
        Me.txtVinkel.Location = New System.Drawing.Point(132, 69)
        Me.txtVinkel.MaxLength = 2
        Me.txtVinkel.Name = "txtVinkel"
        Me.txtVinkel.Size = New System.Drawing.Size(62, 27)
        Me.txtVinkel.TabIndex = 1
        Me.txtVinkel.Text = "10"
        Me.txtVinkel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtHastighet
        '
        Me.txtHastighet.Location = New System.Drawing.Point(132, 118)
        Me.txtHastighet.MaxLength = 3
        Me.txtHastighet.Name = "txtHastighet"
        Me.txtHastighet.Size = New System.Drawing.Size(62, 27)
        Me.txtHastighet.TabIndex = 2
        Me.txtHastighet.Text = "10"
        Me.txtHastighet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnRita
        '
        Me.btnRita.Location = New System.Drawing.Point(132, 223)
        Me.btnRita.Name = "btnRita"
        Me.btnRita.Size = New System.Drawing.Size(71, 36)
        Me.btnRita.TabIndex = 3
        Me.btnRita.Text = "Rita!"
        Me.btnRita.UseVisualStyleBackColor = True
        '
        'btnRensa
        '
        Me.btnRensa.Location = New System.Drawing.Point(132, 277)
        Me.btnRensa.Name = "btnRensa"
        Me.btnRensa.Size = New System.Drawing.Size(71, 36)
        Me.btnRensa.TabIndex = 3
        Me.btnRensa.Text = "Rensa"
        Me.btnRensa.UseVisualStyleBackColor = True
        '
        'picWorld
        '
        Me.picWorld.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picWorld.BackColor = System.Drawing.Color.White
        Me.picWorld.Location = New System.Drawing.Point(291, 6)
        Me.picWorld.Name = "picWorld"
        Me.picWorld.Size = New System.Drawing.Size(497, 430)
        Me.picWorld.TabIndex = 4
        Me.picWorld.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Projektil"
        '
        'txtColor
        '
        Me.txtColor.BackColor = System.Drawing.Color.Lime
        Me.txtColor.Location = New System.Drawing.Point(130, 161)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(64, 27)
        Me.txtColor.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 442)
        Me.Controls.Add(Me.txtColor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.picWorld)
        Me.Controls.Add(Me.btnRensa)
        Me.Controls.Add(Me.btnRita)
        Me.Controls.Add(Me.txtHastighet)
        Me.Controls.Add(Me.txtVinkel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1100, 750)
        Me.MinimumSize = New System.Drawing.Size(630, 345)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picWorld, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtVinkel As TextBox
    Friend WithEvents txtHastighet As TextBox
    Friend WithEvents btnRita As Button
    Friend WithEvents btnRensa As Button
    Friend WithEvents picWorld As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtColor As TextBox
    Friend WithEvents dlgColor As ColorDialog
End Class
