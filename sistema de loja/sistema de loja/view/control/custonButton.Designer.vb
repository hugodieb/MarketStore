<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class custonButton
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(custonButton))
        Me.pnButtonCuston = New System.Windows.Forms.Panel()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.lblButtonCuston = New System.Windows.Forms.Label()
        Me.picbtncuston = New System.Windows.Forms.PictureBox()
        Me.imgButtonCuston = New System.Windows.Forms.ImageList(Me.components)
        Me.pnButtonCuston.SuspendLayout()
        CType(Me.picbtncuston, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnButtonCuston
        '
        Me.pnButtonCuston.BackColor = System.Drawing.Color.MidnightBlue
        Me.pnButtonCuston.Controls.Add(Me.Splitter1)
        Me.pnButtonCuston.Controls.Add(Me.lblButtonCuston)
        Me.pnButtonCuston.Controls.Add(Me.picbtncuston)
        Me.pnButtonCuston.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnButtonCuston.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnButtonCuston.Location = New System.Drawing.Point(0, 0)
        Me.pnButtonCuston.Name = "pnButtonCuston"
        Me.pnButtonCuston.Padding = New System.Windows.Forms.Padding(3)
        Me.pnButtonCuston.Size = New System.Drawing.Size(106, 71)
        Me.pnButtonCuston.TabIndex = 0
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.Color.White
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Splitter1.Location = New System.Drawing.Point(102, 3)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(1, 65)
        Me.Splitter1.TabIndex = 2
        Me.Splitter1.TabStop = False
        '
        'lblButtonCuston
        '
        Me.lblButtonCuston.AutoSize = True
        Me.lblButtonCuston.Font = New System.Drawing.Font("Lucida Calligraphy", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblButtonCuston.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblButtonCuston.Location = New System.Drawing.Point(4, 44)
        Me.lblButtonCuston.Name = "lblButtonCuston"
        Me.lblButtonCuston.Size = New System.Drawing.Size(82, 15)
        Me.lblButtonCuston.TabIndex = 1
        Me.lblButtonCuston.Text = "Fornecedor"
        '
        'picbtncuston
        '
        Me.picbtncuston.BackColor = System.Drawing.Color.Transparent
        Me.picbtncuston.Location = New System.Drawing.Point(34, 6)
        Me.picbtncuston.Name = "picbtncuston"
        Me.picbtncuston.Size = New System.Drawing.Size(31, 33)
        Me.picbtncuston.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picbtncuston.TabIndex = 0
        Me.picbtncuston.TabStop = False
        '
        'imgButtonCuston
        '
        Me.imgButtonCuston.ImageStream = CType(resources.GetObject("imgButtonCuston.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgButtonCuston.TransparentColor = System.Drawing.Color.Transparent
        Me.imgButtonCuston.Images.SetKeyName(0, "adduser.png")
        Me.imgButtonCuston.Images.SetKeyName(1, "BarcodeBlack_953.jpeg")
        Me.imgButtonCuston.Images.SetKeyName(2, "icon256.png")
        Me.imgButtonCuston.Images.SetKeyName(3, "user_add.png")
        '
        'custonButton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnButtonCuston)
        Me.Name = "custonButton"
        Me.Size = New System.Drawing.Size(106, 71)
        Me.pnButtonCuston.ResumeLayout(False)
        Me.pnButtonCuston.PerformLayout()
        CType(Me.picbtncuston, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnButtonCuston As System.Windows.Forms.Panel
    Friend WithEvents picbtncuston As System.Windows.Forms.PictureBox
    Friend WithEvents imgButtonCuston As System.Windows.Forms.ImageList
    Friend WithEvents lblButtonCuston As System.Windows.Forms.Label
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter

End Class
