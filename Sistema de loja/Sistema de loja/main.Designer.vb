<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.linktwitter = New System.Windows.Forms.PictureBox()
        Me.linkinstagram = New System.Windows.Forms.PictureBox()
        Me.linkface = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.linktwitter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.linkinstagram, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.linkface, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.linktwitter)
        Me.Panel1.Controls.Add(Me.linkinstagram)
        Me.Panel1.Controls.Add(Me.linkface)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(722, 31)
        Me.Panel1.TabIndex = 0
        '
        'linktwitter
        '
        Me.linktwitter.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.linktwitter.BackColor = System.Drawing.Color.Gainsboro
        Me.linktwitter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.linktwitter.Image = Global.Sistema_de_loja.My.Resources.Resources._18_icone_twitter
        Me.linktwitter.Location = New System.Drawing.Point(431, 3)
        Me.linktwitter.Name = "linktwitter"
        Me.linktwitter.Size = New System.Drawing.Size(28, 25)
        Me.linktwitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.linktwitter.TabIndex = 1
        Me.linktwitter.TabStop = False
        '
        'linkinstagram
        '
        Me.linkinstagram.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.linkinstagram.BackColor = System.Drawing.Color.Gainsboro
        Me.linkinstagram.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.linkinstagram.Image = Global.Sistema_de_loja.My.Resources.Resources.c3adcone_instagram
        Me.linkinstagram.Location = New System.Drawing.Point(405, 3)
        Me.linkinstagram.Name = "linkinstagram"
        Me.linkinstagram.Size = New System.Drawing.Size(28, 25)
        Me.linkinstagram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.linkinstagram.TabIndex = 1
        Me.linkinstagram.TabStop = False
        '
        'linkface
        '
        Me.linkface.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.linkface.BackColor = System.Drawing.Color.Gainsboro
        Me.linkface.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.linkface.Image = Global.Sistema_de_loja.My.Resources.Resources.icon175x175
        Me.linkface.Location = New System.Drawing.Point(375, 3)
        Me.linkface.Name = "linkface"
        Me.linkface.Size = New System.Drawing.Size(32, 25)
        Me.linkface.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.linkface.TabIndex = 1
        Me.linkface.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PictureBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.Sistema_de_loja.My.Resources.Resources.drupal1
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(31, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Gota"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(82, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(287, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sistema de Controle e Gestão Administrativo"
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = Global.Sistema_de_loja.My.Resources.Resources.apple
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(722, 450)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.linktwitter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.linkinstagram, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.linkface, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents linkinstagram As System.Windows.Forms.PictureBox
    Friend WithEvents linkface As System.Windows.Forms.PictureBox
    Friend WithEvents linktwitter As System.Windows.Forms.PictureBox

End Class
