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
        Me.components = New System.ComponentModel.Container()
        Me.pnBotton = New System.Windows.Forms.Panel()
        Me.lblNameUser = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.calendarData = New System.Windows.Forms.Label()
        Me.linktwitter = New System.Windows.Forms.PictureBox()
        Me.linkinstagram = New System.Windows.Forms.PictureBox()
        Me.linkface = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnTop = New System.Windows.Forms.Panel()
        Me.pnFill = New System.Windows.Forms.Panel()
        Me.pntabmain = New System.Windows.Forms.Panel()
        Me.hr = New System.Windows.Forms.Timer(Me.components)
        Me.calendarHora = New System.Windows.Forms.Label()
        Me.TabPrincipal2 = New Sistema_de_loja.tabMain()
        Me.TabPrincipal1 = New Sistema_de_loja.tabMain()
        Me.pnBotton.SuspendLayout()
        CType(Me.linktwitter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.linkinstagram, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.linkface, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnFill.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnBotton
        '
        Me.pnBotton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnBotton.Controls.Add(Me.lblNameUser)
        Me.pnBotton.Controls.Add(Me.Label3)
        Me.pnBotton.Controls.Add(Me.calendarHora)
        Me.pnBotton.Controls.Add(Me.calendarData)
        Me.pnBotton.Controls.Add(Me.linktwitter)
        Me.pnBotton.Controls.Add(Me.linkinstagram)
        Me.pnBotton.Controls.Add(Me.linkface)
        Me.pnBotton.Controls.Add(Me.PictureBox1)
        Me.pnBotton.Controls.Add(Me.Label2)
        Me.pnBotton.Controls.Add(Me.Label1)
        Me.pnBotton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnBotton.Location = New System.Drawing.Point(0, 488)
        Me.pnBotton.Name = "pnBotton"
        Me.pnBotton.Size = New System.Drawing.Size(920, 31)
        Me.pnBotton.TabIndex = 0
        Me.pnBotton.Tag = ""
        '
        'lblNameUser
        '
        Me.lblNameUser.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblNameUser.AutoSize = True
        Me.lblNameUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameUser.Location = New System.Drawing.Point(599, 10)
        Me.lblNameUser.Name = "lblNameUser"
        Me.lblNameUser.Size = New System.Drawing.Size(39, 13)
        Me.lblNameUser.TabIndex = 4
        Me.lblNameUser.Text = "Nome"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(541, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Usuário : "
        '
        'calendarData
        '
        Me.calendarData.AutoSize = True
        Me.calendarData.Dock = System.Windows.Forms.DockStyle.Right
        Me.calendarData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calendarData.Location = New System.Drawing.Point(920, 0)
        Me.calendarData.Name = "calendarData"
        Me.calendarData.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.calendarData.Size = New System.Drawing.Size(0, 18)
        Me.calendarData.TabIndex = 2
        '
        'linktwitter
        '
        Me.linktwitter.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.linktwitter.BackColor = System.Drawing.Color.Gainsboro
        Me.linktwitter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.linktwitter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.linktwitter.Image = Global.Sistema_de_loja.My.Resources.Resources._18_icone_twitter
        Me.linktwitter.Location = New System.Drawing.Point(437, 3)
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
        Me.linkinstagram.Cursor = System.Windows.Forms.Cursors.Hand
        Me.linkinstagram.Image = Global.Sistema_de_loja.My.Resources.Resources.c3adcone_instagram
        Me.linkinstagram.Location = New System.Drawing.Point(408, 3)
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
        Me.linkface.Cursor = System.Windows.Forms.Cursors.Hand
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
        'pnTop
        '
        Me.pnTop.AutoSize = True
        Me.pnTop.BackColor = System.Drawing.Color.Gray
        Me.pnTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnTop.Location = New System.Drawing.Point(0, 0)
        Me.pnTop.Name = "pnTop"
        Me.pnTop.Size = New System.Drawing.Size(920, 0)
        Me.pnTop.TabIndex = 2
        '
        'pnFill
        '
        Me.pnFill.BackColor = System.Drawing.Color.Transparent
        Me.pnFill.BackgroundImage = Global.Sistema_de_loja.My.Resources.Resources.wallpaper_comprao_bonanza_1
        Me.pnFill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnFill.Controls.Add(Me.pntabmain)
        Me.pnFill.Controls.Add(Me.TabPrincipal2)
        Me.pnFill.Controls.Add(Me.TabPrincipal1)
        Me.pnFill.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnFill.Location = New System.Drawing.Point(0, 0)
        Me.pnFill.Name = "pnFill"
        Me.pnFill.Size = New System.Drawing.Size(920, 488)
        Me.pnFill.TabIndex = 3
        '
        'pntabmain
        '
        Me.pntabmain.BackColor = System.Drawing.Color.Transparent
        Me.pntabmain.Dock = System.Windows.Forms.DockStyle.Top
        Me.pntabmain.Location = New System.Drawing.Point(0, 0)
        Me.pntabmain.Name = "pntabmain"
        Me.pntabmain.Size = New System.Drawing.Size(916, 130)
        Me.pntabmain.TabIndex = 3
        '
        'hr
        '
        Me.hr.Enabled = True
        '
        'calendarHora
        '
        Me.calendarHora.AutoSize = True
        Me.calendarHora.Dock = System.Windows.Forms.DockStyle.Right
        Me.calendarHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calendarHora.Location = New System.Drawing.Point(920, 0)
        Me.calendarHora.Name = "calendarHora"
        Me.calendarHora.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.calendarHora.Size = New System.Drawing.Size(0, 18)
        Me.calendarHora.TabIndex = 2
        '
        'TabPrincipal2
        '
        Me.TabPrincipal2.AutoScroll = True
        Me.TabPrincipal2.AutoSize = True
        Me.TabPrincipal2.BackColor = System.Drawing.Color.MidnightBlue
        Me.TabPrincipal2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabPrincipal2.Location = New System.Drawing.Point(0, 0)
        Me.TabPrincipal2.Name = "TabPrincipal2"
        Me.TabPrincipal2.Size = New System.Drawing.Size(916, 0)
        Me.TabPrincipal2.TabIndex = 1
        '
        'TabPrincipal1
        '
        Me.TabPrincipal1.AutoScroll = True
        Me.TabPrincipal1.AutoSize = True
        Me.TabPrincipal1.BackColor = System.Drawing.Color.MidnightBlue
        Me.TabPrincipal1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabPrincipal1.Location = New System.Drawing.Point(0, 0)
        Me.TabPrincipal1.Name = "TabPrincipal1"
        Me.TabPrincipal1.Size = New System.Drawing.Size(916, 0)
        Me.TabPrincipal1.TabIndex = 0
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(920, 519)
        Me.Controls.Add(Me.pnFill)
        Me.Controls.Add(Me.pnTop)
        Me.Controls.Add(Me.pnBotton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnBotton.ResumeLayout(False)
        Me.pnBotton.PerformLayout()
        CType(Me.linktwitter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.linkinstagram, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.linkface, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnFill.ResumeLayout(False)
        Me.pnFill.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnBotton As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents linkinstagram As System.Windows.Forms.PictureBox
    Friend WithEvents linkface As System.Windows.Forms.PictureBox
    Friend WithEvents linktwitter As System.Windows.Forms.PictureBox
    Friend WithEvents TabPrincipal1 As Sistema_de_loja.tabMain
    Friend WithEvents TabPrincipal2 As Sistema_de_loja.tabMain
    Friend WithEvents pnTop As System.Windows.Forms.Panel
    Friend WithEvents pnFill As System.Windows.Forms.Panel
    Friend WithEvents pntabmain As System.Windows.Forms.Panel
    Friend WithEvents hr As System.Windows.Forms.Timer
    Friend WithEvents calendarData As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblNameUser As System.Windows.Forms.Label
    Friend WithEvents calendarHora As System.Windows.Forms.Label

End Class
