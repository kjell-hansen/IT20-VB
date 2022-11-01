<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLista
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
        Me.lstAdresser = New System.Windows.Forms.ListView()
        Me.colId = New System.Windows.Forms.ColumnHeader()
        Me.colFornamn = New System.Windows.Forms.ColumnHeader()
        Me.colEfternamn = New System.Windows.Forms.ColumnHeader()
        Me.colAdress = New System.Windows.Forms.ColumnHeader()
        Me.colPostnr = New System.Windows.Forms.ColumnHeader()
        Me.colOrt = New System.Windows.Forms.ColumnHeader()
        Me.SuspendLayout()
        '
        'lstAdresser
        '
        Me.lstAdresser.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colId, Me.colFornamn, Me.colEfternamn, Me.colAdress, Me.colPostnr, Me.colOrt})
        Me.lstAdresser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstAdresser.FullRowSelect = True
        Me.lstAdresser.GridLines = True
        Me.lstAdresser.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstAdresser.Location = New System.Drawing.Point(0, 0)
        Me.lstAdresser.MultiSelect = False
        Me.lstAdresser.Name = "lstAdresser"
        Me.lstAdresser.Size = New System.Drawing.Size(542, 275)
        Me.lstAdresser.TabIndex = 0
        Me.lstAdresser.UseCompatibleStateImageBehavior = False
        Me.lstAdresser.View = System.Windows.Forms.View.Details
        '
        'colId
        '
        Me.colId.Text = "Id"
        '
        'colFornamn
        '
        Me.colFornamn.Text = "Förnamn"
        Me.colFornamn.Width = 100
        '
        'colEfternamn
        '
        Me.colEfternamn.Text = "Efternamn"
        Me.colEfternamn.Width = 100
        '
        'colAdress
        '
        Me.colAdress.Text = "Adress"
        Me.colAdress.Width = 100
        '
        'colPostnr
        '
        Me.colPostnr.Text = "Postnr"
        '
        'colOrt
        '
        Me.colOrt.Text = "Ort"
        Me.colOrt.Width = 80
        '
        'frmLista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 275)
        Me.Controls.Add(Me.lstAdresser)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(560, 320)
        Me.Name = "frmLista"
        Me.Text = "Adresslista"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstAdresser As ListView
    Friend WithEvents colId As ColumnHeader
    Friend WithEvents colFornamn As ColumnHeader
    Friend WithEvents colEfternamn As ColumnHeader
    Friend WithEvents colAdress As ColumnHeader
    Friend WithEvents colPostnr As ColumnHeader
    Friend WithEvents colOrt As ColumnHeader
End Class
