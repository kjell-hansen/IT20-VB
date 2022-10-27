<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdresser
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFornamn = New System.Windows.Forms.TextBox()
        Me.txtEfternamn = New System.Windows.Forms.TextBox()
        Me.txtAdress = New System.Windows.Forms.TextBox()
        Me.txtPostnr = New System.Windows.Forms.TextBox()
        Me.txtOrt = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnForsta = New System.Windows.Forms.Button()
        Me.btnForegaende = New System.Windows.Forms.Button()
        Me.btnNasta = New System.Windows.Forms.Button()
        Me.btnSista = New System.Windows.Forms.Button()
        Me.txtPost = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Förnamn"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Efternamn"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Adress"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 246)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Postnr"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(153, 246)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Ort"
        '
        'txtFornamn
        '
        Me.txtFornamn.Location = New System.Drawing.Point(28, 45)
        Me.txtFornamn.Name = "txtFornamn"
        Me.txtFornamn.Size = New System.Drawing.Size(249, 27)
        Me.txtFornamn.TabIndex = 5
        '
        'txtEfternamn
        '
        Me.txtEfternamn.Location = New System.Drawing.Point(28, 114)
        Me.txtEfternamn.Name = "txtEfternamn"
        Me.txtEfternamn.Size = New System.Drawing.Size(249, 27)
        Me.txtEfternamn.TabIndex = 6
        '
        'txtAdress
        '
        Me.txtAdress.Location = New System.Drawing.Point(28, 191)
        Me.txtAdress.Name = "txtAdress"
        Me.txtAdress.Size = New System.Drawing.Size(249, 27)
        Me.txtAdress.TabIndex = 7
        '
        'txtPostnr
        '
        Me.txtPostnr.Location = New System.Drawing.Point(28, 269)
        Me.txtPostnr.Name = "txtPostnr"
        Me.txtPostnr.Size = New System.Drawing.Size(77, 27)
        Me.txtPostnr.TabIndex = 8
        '
        'txtOrt
        '
        Me.txtOrt.Location = New System.Drawing.Point(153, 269)
        Me.txtOrt.Name = "txtOrt"
        Me.txtOrt.Size = New System.Drawing.Size(235, 27)
        Me.txtOrt.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtPost)
        Me.Panel1.Controls.Add(Me.btnSista)
        Me.Panel1.Controls.Add(Me.btnNasta)
        Me.Panel1.Controls.Add(Me.btnForegaende)
        Me.Panel1.Controls.Add(Me.btnForsta)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 312)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(535, 55)
        Me.Panel1.TabIndex = 10
        '
        'btnForsta
        '
        Me.btnForsta.Location = New System.Drawing.Point(12, 8)
        Me.btnForsta.Name = "btnForsta"
        Me.btnForsta.Size = New System.Drawing.Size(68, 35)
        Me.btnForsta.TabIndex = 0
        Me.btnForsta.Text = "<<"
        Me.btnForsta.UseVisualStyleBackColor = True
        '
        'btnForegaende
        '
        Me.btnForegaende.Location = New System.Drawing.Point(86, 8)
        Me.btnForegaende.Name = "btnForegaende"
        Me.btnForegaende.Size = New System.Drawing.Size(68, 35)
        Me.btnForegaende.TabIndex = 0
        Me.btnForegaende.Text = "<"
        Me.btnForegaende.UseVisualStyleBackColor = True
        '
        'btnNasta
        '
        Me.btnNasta.Location = New System.Drawing.Point(209, 8)
        Me.btnNasta.Name = "btnNasta"
        Me.btnNasta.Size = New System.Drawing.Size(68, 35)
        Me.btnNasta.TabIndex = 0
        Me.btnNasta.Text = ">"
        Me.btnNasta.UseVisualStyleBackColor = True
        '
        'btnSista
        '
        Me.btnSista.Location = New System.Drawing.Point(283, 8)
        Me.btnSista.Name = "btnSista"
        Me.btnSista.Size = New System.Drawing.Size(68, 35)
        Me.btnSista.TabIndex = 0
        Me.btnSista.Text = ">>"
        Me.btnSista.UseVisualStyleBackColor = True
        '
        'txtPost
        '
        Me.txtPost.Location = New System.Drawing.Point(158, 10)
        Me.txtPost.Name = "txtPost"
        Me.txtPost.Size = New System.Drawing.Size(46, 27)
        Me.txtPost.TabIndex = 1
        Me.txtPost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmAdresser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 367)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtOrt)
        Me.Controls.Add(Me.txtPostnr)
        Me.Controls.Add(Me.txtAdress)
        Me.Controls.Add(Me.txtEfternamn)
        Me.Controls.Add(Me.txtFornamn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MinimumSize = New System.Drawing.Size(553, 414)
        Me.Name = "frmAdresser"
        Me.Text = "Adresser"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFornamn As TextBox
    Friend WithEvents txtEfternamn As TextBox
    Friend WithEvents txtAdress As TextBox
    Friend WithEvents txtPostnr As TextBox
    Friend WithEvents txtOrt As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnForsta As Button
    Friend WithEvents txtPost As TextBox
    Friend WithEvents btnSista As Button
    Friend WithEvents btnNasta As Button
    Friend WithEvents btnForegaende As Button
End Class
