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
        Me.components = New System.ComponentModel.Container()
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
        Me.btnBorja = New System.Windows.Forms.Button()
        Me.timTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTid = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblPoang = New System.Windows.Forms.Label()
        Me.timTraff = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picWorld, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Vinkel"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Hastighet"
        '
        'txtVinkel
        '
        Me.txtVinkel.Location = New System.Drawing.Point(116, 52)
        Me.txtVinkel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtVinkel.MaxLength = 2
        Me.txtVinkel.Name = "txtVinkel"
        Me.txtVinkel.Size = New System.Drawing.Size(55, 23)
        Me.txtVinkel.TabIndex = 1
        Me.txtVinkel.Text = "10"
        Me.txtVinkel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtHastighet
        '
        Me.txtHastighet.Location = New System.Drawing.Point(116, 88)
        Me.txtHastighet.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtHastighet.MaxLength = 3
        Me.txtHastighet.Name = "txtHastighet"
        Me.txtHastighet.Size = New System.Drawing.Size(55, 23)
        Me.txtHastighet.TabIndex = 2
        Me.txtHastighet.Text = "10"
        Me.txtHastighet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnRita
        '
        Me.btnRita.Location = New System.Drawing.Point(116, 167)
        Me.btnRita.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRita.Name = "btnRita"
        Me.btnRita.Size = New System.Drawing.Size(62, 27)
        Me.btnRita.TabIndex = 3
        Me.btnRita.Text = "Rita!"
        Me.btnRita.UseVisualStyleBackColor = True
        '
        'btnRensa
        '
        Me.btnRensa.Location = New System.Drawing.Point(116, 208)
        Me.btnRensa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRensa.Name = "btnRensa"
        Me.btnRensa.Size = New System.Drawing.Size(62, 27)
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
        Me.picWorld.Location = New System.Drawing.Point(255, 4)
        Me.picWorld.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picWorld.Name = "picWorld"
        Me.picWorld.Size = New System.Drawing.Size(435, 322)
        Me.picWorld.TabIndex = 4
        Me.picWorld.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Projektil"
        '
        'txtColor
        '
        Me.txtColor.BackColor = System.Drawing.Color.Lime
        Me.txtColor.Location = New System.Drawing.Point(114, 121)
        Me.txtColor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(56, 23)
        Me.txtColor.TabIndex = 6
        Me.txtColor.TabStop = False
        '
        'btnBorja
        '
        Me.btnBorja.Location = New System.Drawing.Point(41, 167)
        Me.btnBorja.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBorja.Name = "btnBorja"
        Me.btnBorja.Size = New System.Drawing.Size(62, 27)
        Me.btnBorja.TabIndex = 3
        Me.btnBorja.Text = "Börja!"
        Me.btnBorja.UseVisualStyleBackColor = True
        '
        'timTimer
        '
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 257)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Återstående tid:"
        '
        'lblTid
        '
        Me.lblTid.AutoSize = True
        Me.lblTid.Location = New System.Drawing.Point(32, 272)
        Me.lblTid.Name = "lblTid"
        Me.lblTid.Size = New System.Drawing.Size(19, 15)
        Me.lblTid.TabIndex = 8
        Me.lblTid.Text = "60"
        Me.lblTid.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(60, 272)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "sek"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(130, 257)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 15)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Poäng:"
        '
        'lblPoang
        '
        Me.lblPoang.AutoSize = True
        Me.lblPoang.Location = New System.Drawing.Point(139, 272)
        Me.lblPoang.Name = "lblPoang"
        Me.lblPoang.Size = New System.Drawing.Size(54, 15)
        Me.lblPoang.TabIndex = 8
        Me.lblPoang.Text = "lblPoang"
        Me.lblPoang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'timTraff
        '
        '
        'Form1
        '
        Me.AcceptButton = Me.btnRita
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnRensa
        Me.ClientSize = New System.Drawing.Size(700, 332)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblPoang)
        Me.Controls.Add(Me.lblTid)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtColor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.picWorld)
        Me.Controls.Add(Me.btnRensa)
        Me.Controls.Add(Me.btnBorja)
        Me.Controls.Add(Me.btnRita)
        Me.Controls.Add(Me.txtHastighet)
        Me.Controls.Add(Me.txtVinkel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(964, 572)
        Me.MinimumSize = New System.Drawing.Size(553, 269)
        Me.Name = "Form1"
        Me.Text = "Skjut projektiler"
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
    Friend WithEvents btnBorja As Button
    Friend WithEvents timTimer As Timer
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTid As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblPoang As Label
    Friend WithEvents timTraff As Timer
End Class
