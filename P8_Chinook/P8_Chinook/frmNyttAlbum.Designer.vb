<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNyttAlbum
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
        Me.cboArtist = New System.Windows.Forms.ComboBox()
        Me.txtAlbum = New System.Windows.Forms.TextBox()
        Me.btnSpara = New System.Windows.Forms.Button()
        Me.btnAvbryt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(73, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Artist"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Albumnamn"
        '
        'cboArtist
        '
        Me.cboArtist.FormattingEnabled = True
        Me.cboArtist.Location = New System.Drawing.Point(146, 42)
        Me.cboArtist.Name = "cboArtist"
        Me.cboArtist.Size = New System.Drawing.Size(193, 28)
        Me.cboArtist.TabIndex = 2
        '
        'txtAlbum
        '
        Me.txtAlbum.Location = New System.Drawing.Point(146, 90)
        Me.txtAlbum.Name = "txtAlbum"
        Me.txtAlbum.Size = New System.Drawing.Size(206, 27)
        Me.txtAlbum.TabIndex = 3
        '
        'btnSpara
        '
        Me.btnSpara.Location = New System.Drawing.Point(146, 157)
        Me.btnSpara.Name = "btnSpara"
        Me.btnSpara.Size = New System.Drawing.Size(94, 29)
        Me.btnSpara.TabIndex = 4
        Me.btnSpara.Text = "Spara"
        Me.btnSpara.UseVisualStyleBackColor = True
        '
        'btnAvbryt
        '
        Me.btnAvbryt.Location = New System.Drawing.Point(258, 157)
        Me.btnAvbryt.Name = "btnAvbryt"
        Me.btnAvbryt.Size = New System.Drawing.Size(94, 29)
        Me.btnAvbryt.TabIndex = 5
        Me.btnAvbryt.Text = "Avbryt"
        Me.btnAvbryt.UseVisualStyleBackColor = True
        '
        'frmNyttAlbum
        '
        Me.AcceptButton = Me.btnSpara
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAvbryt
        Me.ClientSize = New System.Drawing.Size(435, 222)
        Me.Controls.Add(Me.btnAvbryt)
        Me.Controls.Add(Me.btnSpara)
        Me.Controls.Add(Me.txtAlbum)
        Me.Controls.Add(Me.cboArtist)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNyttAlbum"
        Me.Text = "frmNyttAlbum"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cboArtist As ComboBox
    Friend WithEvents txtAlbum As TextBox
    Friend WithEvents btnSpara As Button
    Friend WithEvents btnAvbryt As Button
End Class
