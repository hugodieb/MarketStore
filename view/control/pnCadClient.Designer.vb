<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pnCadClient
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
        Me.flwControlCadClient = New System.Windows.Forms.FlowLayoutPanel()
        Me.gpDP = New System.Windows.Forms.GroupBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.txtDistrictCadClient = New System.Windows.Forms.TextBox()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.txtComplementCadClient = New System.Windows.Forms.TextBox()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.txtCellPhoneCadClient = New System.Windows.Forms.TextBox()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.txtPhoneCadClient = New System.Windows.Forms.TextBox()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.txtAddressCadClient = New System.Windows.Forms.TextBox()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.txtRgCadClient = New System.Windows.Forms.TextBox()
        Me.GroupBox16 = New System.Windows.Forms.GroupBox()
        Me.txtCPFCadClient = New System.Windows.Forms.TextBox()
        Me.GroupBox17 = New System.Windows.Forms.GroupBox()
        Me.txtNameCadClient = New System.Windows.Forms.TextBox()
        Me.cderrorname = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cderrorcpf = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cderrorrg = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cderroradrress = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cderrorstreet = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cderrorphone = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cderrorcellphone = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.flwControlCadClient.SuspendLayout()
        Me.gpDP.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
        Me.GroupBox16.SuspendLayout()
        Me.GroupBox17.SuspendLayout()
        CType(Me.cderrorname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cderrorcpf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cderrorrg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cderroradrress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cderrorstreet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cderrorphone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cderrorcellphone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'flwControlCadClient
        '
        Me.flwControlCadClient.BackColor = System.Drawing.Color.MidnightBlue
        Me.flwControlCadClient.Controls.Add(Me.gpDP)
        Me.flwControlCadClient.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flwControlCadClient.Location = New System.Drawing.Point(15, 65)
        Me.flwControlCadClient.Name = "flwControlCadClient"
        Me.flwControlCadClient.Padding = New System.Windows.Forms.Padding(7, 10, 10, 10)
        Me.flwControlCadClient.Size = New System.Drawing.Size(786, 235)
        Me.flwControlCadClient.TabIndex = 2
        '
        'gpDP
        '
        Me.gpDP.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpDP.AutoSize = True
        Me.gpDP.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.gpDP.Controls.Add(Me.GroupBox10)
        Me.gpDP.Controls.Add(Me.GroupBox11)
        Me.gpDP.Controls.Add(Me.GroupBox12)
        Me.gpDP.Controls.Add(Me.GroupBox13)
        Me.gpDP.Controls.Add(Me.GroupBox14)
        Me.gpDP.Controls.Add(Me.GroupBox15)
        Me.gpDP.Controls.Add(Me.GroupBox16)
        Me.gpDP.Controls.Add(Me.GroupBox17)
        Me.gpDP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpDP.ForeColor = System.Drawing.Color.Black
        Me.gpDP.Location = New System.Drawing.Point(7, 10)
        Me.gpDP.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.gpDP.Name = "gpDP"
        Me.gpDP.Padding = New System.Windows.Forms.Padding(0)
        Me.gpDP.Size = New System.Drawing.Size(771, 215)
        Me.gpDP.TabIndex = 1
        Me.gpDP.TabStop = False
        Me.gpDP.Text = "Dados Pessoais"
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.txtDistrictCadClient)
        Me.GroupBox10.Location = New System.Drawing.Point(15, 146)
        Me.GroupBox10.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(288, 50)
        Me.GroupBox10.TabIndex = 0
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Bairro"
        '
        'txtDistrictCadClient
        '
        Me.txtDistrictCadClient.Location = New System.Drawing.Point(6, 20)
        Me.txtDistrictCadClient.Name = "txtDistrictCadClient"
        Me.txtDistrictCadClient.Size = New System.Drawing.Size(247, 21)
        Me.txtDistrictCadClient.TabIndex = 1
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.txtComplementCadClient)
        Me.GroupBox11.Location = New System.Drawing.Point(503, 86)
        Me.GroupBox11.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(263, 50)
        Me.GroupBox11.TabIndex = 0
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Complemento"
        '
        'txtComplementCadClient
        '
        Me.txtComplementCadClient.Location = New System.Drawing.Point(6, 20)
        Me.txtComplementCadClient.Name = "txtComplementCadClient"
        Me.txtComplementCadClient.Size = New System.Drawing.Size(228, 21)
        Me.txtComplementCadClient.TabIndex = 0
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.txtCellPhoneCadClient)
        Me.GroupBox12.Location = New System.Drawing.Point(551, 146)
        Me.GroupBox12.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(215, 50)
        Me.GroupBox12.TabIndex = 0
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Telefone Celular"
        '
        'txtCellPhoneCadClient
        '
        Me.txtCellPhoneCadClient.Location = New System.Drawing.Point(6, 20)
        Me.txtCellPhoneCadClient.Name = "txtCellPhoneCadClient"
        Me.txtCellPhoneCadClient.Size = New System.Drawing.Size(180, 21)
        Me.txtCellPhoneCadClient.TabIndex = 1
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.txtPhoneCadClient)
        Me.GroupBox13.Location = New System.Drawing.Point(326, 146)
        Me.GroupBox13.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(200, 50)
        Me.GroupBox13.TabIndex = 0
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "Telefone Residencial"
        '
        'txtPhoneCadClient
        '
        Me.txtPhoneCadClient.Location = New System.Drawing.Point(6, 20)
        Me.txtPhoneCadClient.Name = "txtPhoneCadClient"
        Me.txtPhoneCadClient.Size = New System.Drawing.Size(167, 21)
        Me.txtPhoneCadClient.TabIndex = 1
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.txtAddressCadClient)
        Me.GroupBox14.Location = New System.Drawing.Point(14, 86)
        Me.GroupBox14.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(469, 50)
        Me.GroupBox14.TabIndex = 0
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "Endereço"
        '
        'txtAddressCadClient
        '
        Me.txtAddressCadClient.Location = New System.Drawing.Point(6, 20)
        Me.txtAddressCadClient.Name = "txtAddressCadClient"
        Me.txtAddressCadClient.Size = New System.Drawing.Size(437, 21)
        Me.txtAddressCadClient.TabIndex = 0
        '
        'GroupBox15
        '
        Me.GroupBox15.Controls.Add(Me.txtRgCadClient)
        Me.GroupBox15.Location = New System.Drawing.Point(576, 26)
        Me.GroupBox15.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(190, 50)
        Me.GroupBox15.TabIndex = 0
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "RG"
        '
        'txtRgCadClient
        '
        Me.txtRgCadClient.Location = New System.Drawing.Point(6, 20)
        Me.txtRgCadClient.Name = "txtRgCadClient"
        Me.txtRgCadClient.Size = New System.Drawing.Size(155, 21)
        Me.txtRgCadClient.TabIndex = 0
        '
        'GroupBox16
        '
        Me.GroupBox16.Controls.Add(Me.txtCPFCadClient)
        Me.GroupBox16.Location = New System.Drawing.Point(357, 26)
        Me.GroupBox16.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Size = New System.Drawing.Size(200, 50)
        Me.GroupBox16.TabIndex = 0
        Me.GroupBox16.TabStop = False
        Me.GroupBox16.Text = "CPF"
        '
        'txtCPFCadClient
        '
        Me.txtCPFCadClient.Location = New System.Drawing.Point(6, 20)
        Me.txtCPFCadClient.Name = "txtCPFCadClient"
        Me.txtCPFCadClient.Size = New System.Drawing.Size(169, 21)
        Me.txtCPFCadClient.TabIndex = 0
        Me.txtCPFCadClient.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GroupBox17
        '
        Me.GroupBox17.Controls.Add(Me.txtNameCadClient)
        Me.GroupBox17.Location = New System.Drawing.Point(14, 26)
        Me.GroupBox17.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox17.Name = "GroupBox17"
        Me.GroupBox17.Size = New System.Drawing.Size(321, 50)
        Me.GroupBox17.TabIndex = 0
        Me.GroupBox17.TabStop = False
        Me.GroupBox17.Text = "Nome"
        '
        'txtNameCadClient
        '
        Me.txtNameCadClient.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNameCadClient.Location = New System.Drawing.Point(6, 20)
        Me.txtNameCadClient.Name = "txtNameCadClient"
        Me.txtNameCadClient.Size = New System.Drawing.Size(288, 21)
        Me.txtNameCadClient.TabIndex = 0
        '
        'cderrorname
        '
        Me.cderrorname.ContainerControl = Me
        '
        'cderrorcpf
        '
        Me.cderrorcpf.ContainerControl = Me
        '
        'cderrorrg
        '
        Me.cderrorrg.ContainerControl = Me
        '
        'cderroradrress
        '
        Me.cderroradrress.ContainerControl = Me
        '
        'cderrorstreet
        '
        Me.cderrorstreet.ContainerControl = Me
        '
        'cderrorphone
        '
        Me.cderrorphone.ContainerControl = Me
        '
        'cderrorcellphone
        '
        Me.cderrorcellphone.ContainerControl = Me
        '
        'pnCadClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.flwControlCadClient)
        Me.Name = "pnCadClient"
        Me.Size = New System.Drawing.Size(953, 670)
        Me.flwControlCadClient.ResumeLayout(False)
        Me.flwControlCadClient.PerformLayout()
        Me.gpDP.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout()
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox15.PerformLayout()
        Me.GroupBox16.ResumeLayout(False)
        Me.GroupBox16.PerformLayout()
        Me.GroupBox17.ResumeLayout(False)
        Me.GroupBox17.PerformLayout()
        CType(Me.cderrorname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cderrorcpf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cderrorrg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cderroradrress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cderrorstreet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cderrorphone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cderrorcellphone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents flwControlCadClient As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents gpDP As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDistrictCadClient As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents txtComplementCadClient As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCellPhoneCadClient As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPhoneCadClient As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox14 As System.Windows.Forms.GroupBox
    Friend WithEvents txtAddressCadClient As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox15 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRgCadClient As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox16 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCPFCadClient As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox17 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNameCadClient As System.Windows.Forms.TextBox
    Friend WithEvents cderrorname As System.Windows.Forms.ErrorProvider
    Friend WithEvents cderrorcpf As System.Windows.Forms.ErrorProvider
    Friend WithEvents cderrorrg As System.Windows.Forms.ErrorProvider
    Friend WithEvents cderroradrress As System.Windows.Forms.ErrorProvider
    Friend WithEvents cderrorstreet As System.Windows.Forms.ErrorProvider
    Friend WithEvents cderrorphone As System.Windows.Forms.ErrorProvider
    Friend WithEvents cderrorcellphone As System.Windows.Forms.ErrorProvider

End Class
