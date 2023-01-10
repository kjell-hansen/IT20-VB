<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNyArtist
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
        Me.txtArtist = New System.Windows.Forms.TextBox()
        Me.btnSpara = New System.Windows.Forms.Button()
        Me.btnAngra = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(73, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Artist"
        '
        'txtArtist
        '
        Me.txtArtist.Location = New System.Drawing.Point(132, 41)
        Me.txtArtist.Name = "txtArtist"
        Me.txtArtist.Size = New System.Drawing.Size(125, 27)
        Me.txtArtist.TabIndex = 1
        '
        'btnSpara
        '
        Me.btnSpara.Location = New System.Drawing.Point(79, 127)
        Me.btnSpara.Name = "btnSpara"
        Me.btnSpara.Size = New System.Drawing.Size(90, 34)
        Me.btnSpara.TabIndex = 2
        Me.btnSpara.Text = "Spara"
        Me.btnSpara.UseVisualStyleBackColor = True
        '
        'btnAngra
        '
        Me.btnAngra.Location = New System.Drawing.Point(201, 130)
        Me.btnAngra.Name = "btnAngra"
        Me.btnAngra.Size = New System.Drawing.Size(94, 29)
        Me.btnAngra.TabIndex = 3
        Me.btnAngra.Text = "Ångra"
        Me.btnAngra.UseVisualStyleBackColor = True
        '
        'frmNyArtist
        '
        Me.AcceptButton = Me.btnSpara
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAngra
        Me.ClientSize = New System.Drawing.Size(377, 187)
        Me.Controls.Add(Me.btnAngra)
        Me.Controls.Add(Me.btnSpara)
        Me.Controls.Add(Me.txtArtist)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNyArtist"
        Me.Text = "Ny artist"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtArtist As TextBox
    Friend WithEvents btnSpara As Button
    Friend WithEvents btnAngra As Button
End Class
