﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class header
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
        Me.pnIndex = New System.Windows.Forms.Panel()
        Me.lblMarketCenter = New System.Windows.Forms.Label()
        Me.pictMarketCenter = New System.Windows.Forms.PictureBox()
        Me.pictLogin = New System.Windows.Forms.PictureBox()
        Me.pnIndex.SuspendLayout()
        CType(Me.pictMarketCenter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnIndex
        '
        Me.pnIndex.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnIndex.BackgroundImage = Global.Sistema_de_loja.My.Resources.Resources.photoshop_background_54519
        Me.pnIndex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnIndex.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnIndex.Controls.Add(Me.lblMarketCenter)
        Me.pnIndex.Controls.Add(Me.pictMarketCenter)
        Me.pnIndex.Controls.Add(Me.pictLogin)
        Me.pnIndex.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnIndex.Location = New System.Drawing.Point(0, 0)
        Me.pnIndex.Name = "pnIndex"
        Me.pnIndex.Size = New System.Drawing.Size(722, 41)
        Me.pnIndex.TabIndex = 2
        '
        'lblMarketCenter
        '
        Me.lblMarketCenter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.lblMarketCenter.AutoSize = True
        Me.lblMarketCenter.BackColor = System.Drawing.Color.Transparent
        Me.lblMarketCenter.Font = New System.Drawing.Font("Mistral", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarketCenter.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblMarketCenter.Location = New System.Drawing.Point(242, 2)
        Me.lblMarketCenter.Name = "lblMarketCenter"
        Me.lblMarketCenter.Size = New System.Drawing.Size(200, 33)
        Me.lblMarketCenter.TabIndex = 2
        Me.lblMarketCenter.Text = "Market Center Shop"
        Me.lblMarketCenter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pictMarketCenter
        '
        Me.pictMarketCenter.BackColor = System.Drawing.Color.Transparent
        Me.pictMarketCenter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pictMarketCenter.Location = New System.Drawing.Point(0, 0)
        Me.pictMarketCenter.Name = "pictMarketCenter"
        Me.pictMarketCenter.Size = New System.Drawing.Size(664, 37)
        Me.pictMarketCenter.TabIndex = 1
        Me.pictMarketCenter.TabStop = False
        '
        'pictLogin
        '
        Me.pictLogin.BackColor = System.Drawing.Color.Transparent
        Me.pictLogin.BackgroundImage = Global.Sistema_de_loja.My.Resources.Resources.Login_icon
        Me.pictLogin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pictLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictLogin.Dock = System.Windows.Forms.DockStyle.Right
        Me.pictLogin.Image = Global.Sistema_de_loja.My.Resources.Resources.Login_icon1
        Me.pictLogin.Location = New System.Drawing.Point(664, 0)
        Me.pictLogin.Name = "pictLogin"
        Me.pictLogin.Size = New System.Drawing.Size(54, 37)
        Me.pictLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictLogin.TabIndex = 0
        Me.pictLogin.TabStop = False
        '
        'header
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnIndex)
        Me.Name = "header"
        Me.Size = New System.Drawing.Size(722, 41)
        Me.pnIndex.ResumeLayout(False)
        Me.pnIndex.PerformLayout()
        CType(Me.pictMarketCenter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnIndex As System.Windows.Forms.Panel
    Friend WithEvents pictLogin As System.Windows.Forms.PictureBox
    Friend WithEvents lblMarketCenter As System.Windows.Forms.Label
    Friend WithEvents pictMarketCenter As System.Windows.Forms.PictureBox

End Class