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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.picTarning1 = New System.Windows.Forms.PictureBox()
        Me.picTarning2 = New System.Windows.Forms.PictureBox()
        Me.picTarning3 = New System.Windows.Forms.PictureBox()
        Me.btnSla = New System.Windows.Forms.Button()
        Me.imlTarningar = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.picTarning1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTarning2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTarning3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picTarning1
        '
        Me.picTarning1.Location = New System.Drawing.Point(95, 56)
        Me.picTarning1.Name = "picTarning1"
        Me.picTarning1.Size = New System.Drawing.Size(64, 64)
        Me.picTarning1.TabIndex = 0
        Me.picTarning1.TabStop = False
        '
        'picTarning2
        '
        Me.picTarning2.Location = New System.Drawing.Point(200, 56)
        Me.picTarning2.Name = "picTarning2"
        Me.picTarning2.Size = New System.Drawing.Size(64, 64)
        Me.picTarning2.TabIndex = 0
        Me.picTarning2.TabStop = False
        '
        'picTarning3
        '
        Me.picTarning3.Location = New System.Drawing.Point(305, 56)
        Me.picTarning3.Name = "picTarning3"
        Me.picTarning3.Size = New System.Drawing.Size(64, 64)
        Me.picTarning3.TabIndex = 0
        Me.picTarning3.TabStop = False
        '
        'btnSla
        '
        Me.btnSla.Font = New System.Drawing.Font("Palatino Linotype", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSla.Location = New System.Drawing.Point(182, 151)
        Me.btnSla.Name = "btnSla"
        Me.btnSla.Size = New System.Drawing.Size(102, 48)
        Me.btnSla.TabIndex = 1
        Me.btnSla.Text = "Slå!"
        Me.btnSla.UseVisualStyleBackColor = True
        '
        'imlTarningar
        '
        Me.imlTarningar.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.imlTarningar.ImageStream = CType(resources.GetObject("imlTarningar.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlTarningar.TransparentColor = System.Drawing.Color.Transparent
        Me.imlTarningar.Images.SetKeyName(0, "1.png")
        Me.imlTarningar.Images.SetKeyName(1, "2.png")
        Me.imlTarningar.Images.SetKeyName(2, "3.png")
        Me.imlTarningar.Images.SetKeyName(3, "4.png")
        Me.imlTarningar.Images.SetKeyName(4, "5.png")
        Me.imlTarningar.Images.SetKeyName(5, "6.png")
        '
        'Form1
        '
        Me.AcceptButton = Me.btnSla
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 248)
        Me.Controls.Add(Me.btnSla)
        Me.Controls.Add(Me.picTarning3)
        Me.Controls.Add(Me.picTarning2)
        Me.Controls.Add(Me.picTarning1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Rulla tärningar"
        CType(Me.picTarning1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTarning2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTarning3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picTarning1 As PictureBox
    Friend WithEvents picTarning2 As PictureBox
    Friend WithEvents picTarning3 As PictureBox
    Friend WithEvents btnSla As Button
    Friend WithEvents imlTarningar As ImageList
End Class
