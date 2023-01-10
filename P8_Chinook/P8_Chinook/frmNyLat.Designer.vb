<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNyLat
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
        Me.lblAlbum = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNamn = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboMediatyp = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboGenre = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtKompositor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtLangd = New System.Windows.Forms.TextBox()
        Me.txtStorlek = New System.Windows.Forms.TextBox()
        Me.txtPris = New System.Windows.Forms.TextBox()
        Me.btnSpara = New System.Windows.Forms.Button()
        Me.btnAvbryt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "AlbumId"
        '
        'lblAlbum
        '
        Me.lblAlbum.AutoSize = True
        Me.lblAlbum.Location = New System.Drawing.Point(154, 29)
        Me.lblAlbum.Name = "lblAlbum"
        Me.lblAlbum.Size = New System.Drawing.Size(70, 20)
        Me.lblAlbum.TabIndex = 1
        Me.lblAlbum.Text = "lblAlbum"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Låtnamn"
        '
        'txtNamn
        '
        Me.txtNamn.Location = New System.Drawing.Point(154, 56)
        Me.txtNamn.Name = "txtNamn"
        Me.txtNamn.Size = New System.Drawing.Size(125, 27)
        Me.txtNamn.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Mediatyp"
        '
        'cboMediatyp
        '
        Me.cboMediatyp.FormattingEnabled = True
        Me.cboMediatyp.Location = New System.Drawing.Point(154, 93)
        Me.cboMediatyp.Name = "cboMediatyp"
        Me.cboMediatyp.Size = New System.Drawing.Size(151, 28)
        Me.cboMediatyp.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Genre"
        '
        'cboGenre
        '
        Me.cboGenre.FormattingEnabled = True
        Me.cboGenre.Location = New System.Drawing.Point(154, 129)
        Me.cboGenre.Name = "cboGenre"
        Me.cboGenre.Size = New System.Drawing.Size(151, 28)
        Me.cboGenre.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Kompositör"
        '
        'txtKompositor
        '
        Me.txtKompositor.Location = New System.Drawing.Point(154, 164)
        Me.txtKompositor.Name = "txtKompositor"
        Me.txtKompositor.Size = New System.Drawing.Size(125, 27)
        Me.txtKompositor.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 207)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Längd (ms)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(39, 244)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 20)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Storlek (bytes)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(39, 280)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 20)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Pris"
        '
        'txtLangd
        '
        Me.txtLangd.Location = New System.Drawing.Point(154, 204)
        Me.txtLangd.MaxLength = 7
        Me.txtLangd.Name = "txtLangd"
        Me.txtLangd.Size = New System.Drawing.Size(125, 27)
        Me.txtLangd.TabIndex = 13
        Me.txtLangd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtStorlek
        '
        Me.txtStorlek.Location = New System.Drawing.Point(154, 241)
        Me.txtStorlek.MaxLength = 10
        Me.txtStorlek.Name = "txtStorlek"
        Me.txtStorlek.Size = New System.Drawing.Size(125, 27)
        Me.txtStorlek.TabIndex = 14
        Me.txtStorlek.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPris
        '
        Me.txtPris.Location = New System.Drawing.Point(154, 277)
        Me.txtPris.MaxLength = 5
        Me.txtPris.Name = "txtPris"
        Me.txtPris.Size = New System.Drawing.Size(125, 27)
        Me.txtPris.TabIndex = 15
        Me.txtPris.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnSpara
        '
        Me.btnSpara.Location = New System.Drawing.Point(49, 351)
        Me.btnSpara.Name = "btnSpara"
        Me.btnSpara.Size = New System.Drawing.Size(94, 29)
        Me.btnSpara.TabIndex = 16
        Me.btnSpara.Text = "Spara"
        Me.btnSpara.UseVisualStyleBackColor = True
        '
        'btnAvbryt
        '
        Me.btnAvbryt.Location = New System.Drawing.Point(173, 351)
        Me.btnAvbryt.Name = "btnAvbryt"
        Me.btnAvbryt.Size = New System.Drawing.Size(94, 29)
        Me.btnAvbryt.TabIndex = 17
        Me.btnAvbryt.Text = "Avbryt"
        Me.btnAvbryt.UseVisualStyleBackColor = True
        '
        'frmNyLat
        '
        Me.AcceptButton = Me.btnSpara
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAvbryt
        Me.ClientSize = New System.Drawing.Size(350, 403)
        Me.Controls.Add(Me.btnAvbryt)
        Me.Controls.Add(Me.btnSpara)
        Me.Controls.Add(Me.txtPris)
        Me.Controls.Add(Me.txtStorlek)
        Me.Controls.Add(Me.txtLangd)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtKompositor)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboGenre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboMediatyp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNamn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblAlbum)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNyLat"
        Me.Text = "Ny låt på album"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblAlbum As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNamn As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboMediatyp As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cboGenre As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtKompositor As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtLangd As TextBox
    Friend WithEvents txtStorlek As TextBox
    Friend WithEvents txtPris As TextBox
    Friend WithEvents btnSpara As Button
    Friend WithEvents btnAvbryt As Button
End Class
