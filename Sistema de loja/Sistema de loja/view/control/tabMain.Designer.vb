<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tabMain
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
        Me.tbcIndex = New System.Windows.Forms.TabControl()
        Me.tbCadastro = New System.Windows.Forms.TabPage()
        Me.tbAlterar = New System.Windows.Forms.TabPage()
        Me.tbFormVendas = New System.Windows.Forms.TabPage()
        Me.tbFecharCx = New System.Windows.Forms.TabPage()
        Me.tbQuitarCx = New System.Windows.Forms.TabPage()
        Me.tbConsultas = New System.Windows.Forms.TabPage()
        Me.tbcIndex.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbcIndex
        '
        Me.tbcIndex.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.tbcIndex.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tbcIndex.Controls.Add(Me.tbCadastro)
        Me.tbcIndex.Controls.Add(Me.tbAlterar)
        Me.tbcIndex.Controls.Add(Me.tbFormVendas)
        Me.tbcIndex.Controls.Add(Me.tbFecharCx)
        Me.tbcIndex.Controls.Add(Me.tbQuitarCx)
        Me.tbcIndex.Controls.Add(Me.tbConsultas)
        Me.tbcIndex.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbcIndex.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcIndex.Location = New System.Drawing.Point(0, 0)
        Me.tbcIndex.Name = "tbcIndex"
        Me.tbcIndex.SelectedIndex = 0
        Me.tbcIndex.Size = New System.Drawing.Size(706, 87)
        Me.tbcIndex.TabIndex = 1
        '
        'tbCadastro
        '
        Me.tbCadastro.BackColor = System.Drawing.Color.SkyBlue
        Me.tbCadastro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tbCadastro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCadastro.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.tbCadastro.Location = New System.Drawing.Point(4, 27)
        Me.tbCadastro.Name = "tbCadastro"
        Me.tbCadastro.Padding = New System.Windows.Forms.Padding(3)
        Me.tbCadastro.Size = New System.Drawing.Size(698, 56)
        Me.tbCadastro.TabIndex = 0
        Me.tbCadastro.Text = "Cadastro"
        '
        'tbAlterar
        '
        Me.tbAlterar.BackColor = System.Drawing.Color.SkyBlue
        Me.tbAlterar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tbAlterar.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.tbAlterar.Location = New System.Drawing.Point(4, 27)
        Me.tbAlterar.Name = "tbAlterar"
        Me.tbAlterar.Padding = New System.Windows.Forms.Padding(3)
        Me.tbAlterar.Size = New System.Drawing.Size(912, 91)
        Me.tbAlterar.TabIndex = 1
        Me.tbAlterar.Text = "Alterar excluir cadastro"
        '
        'tbFormVendas
        '
        Me.tbFormVendas.BackColor = System.Drawing.Color.SkyBlue
        Me.tbFormVendas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tbFormVendas.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.tbFormVendas.Location = New System.Drawing.Point(4, 27)
        Me.tbFormVendas.Name = "tbFormVendas"
        Me.tbFormVendas.Size = New System.Drawing.Size(912, 91)
        Me.tbFormVendas.TabIndex = 2
        Me.tbFormVendas.Text = "Formulário de Vendas"
        '
        'tbFecharCx
        '
        Me.tbFecharCx.BackColor = System.Drawing.Color.SkyBlue
        Me.tbFecharCx.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tbFecharCx.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.tbFecharCx.Location = New System.Drawing.Point(4, 27)
        Me.tbFecharCx.Name = "tbFecharCx"
        Me.tbFecharCx.Size = New System.Drawing.Size(912, 91)
        Me.tbFecharCx.TabIndex = 3
        Me.tbFecharCx.Text = "Fechamento do caixa"
        '
        'tbQuitarCx
        '
        Me.tbQuitarCx.BackColor = System.Drawing.Color.SkyBlue
        Me.tbQuitarCx.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tbQuitarCx.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.tbQuitarCx.Location = New System.Drawing.Point(4, 27)
        Me.tbQuitarCx.Name = "tbQuitarCx"
        Me.tbQuitarCx.Size = New System.Drawing.Size(912, 91)
        Me.tbQuitarCx.TabIndex = 4
        Me.tbQuitarCx.Text = "Quitar débitos"
        '
        'tbConsultas
        '
        Me.tbConsultas.BackColor = System.Drawing.Color.SkyBlue
        Me.tbConsultas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tbConsultas.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.tbConsultas.Location = New System.Drawing.Point(4, 27)
        Me.tbConsultas.Name = "tbConsultas"
        Me.tbConsultas.Size = New System.Drawing.Size(912, 91)
        Me.tbConsultas.TabIndex = 5
        Me.tbConsultas.Text = "Consultas"
        '
        'tabPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tbcIndex)
        Me.Name = "tabPrincipal"
        Me.Size = New System.Drawing.Size(706, 87)
        Me.tbcIndex.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbcIndex As System.Windows.Forms.TabControl
    Friend WithEvents tbCadastro As System.Windows.Forms.TabPage
    Friend WithEvents tbAlterar As System.Windows.Forms.TabPage
    Friend WithEvents tbFormVendas As System.Windows.Forms.TabPage
    Friend WithEvents tbFecharCx As System.Windows.Forms.TabPage
    Friend WithEvents tbQuitarCx As System.Windows.Forms.TabPage
    Friend WithEvents tbConsultas As System.Windows.Forms.TabPage

End Class
