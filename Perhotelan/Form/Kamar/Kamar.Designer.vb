﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Kamar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Kamar))
        Me.ToolStripKamar_ = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.DataGridViewKamar = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.BtnInfo = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnLogOut = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LblUser = New System.Windows.Forms.Label()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictBoxNama = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.ToolStripKamar_.SuspendLayout()
        CType(Me.DataGridViewKamar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictBoxNama, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStripKamar_
        '
        Me.ToolStripKamar_.Dock = System.Windows.Forms.DockStyle.Right
        Me.ToolStripKamar_.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStripKamar_.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.ToolStripKamar_.Location = New System.Drawing.Point(1104, 0)
        Me.ToolStripKamar_.Name = "ToolStripKamar_"
        Me.ToolStripKamar_.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStripKamar_.Size = New System.Drawing.Size(33, 565)
        Me.ToolStripKamar_.TabIndex = 72
        Me.ToolStripKamar_.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(28, 28)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'DataGridViewKamar
        '
        Me.DataGridViewKamar.BackgroundColor = System.Drawing.Color.Black
        Me.DataGridViewKamar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridViewKamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewKamar.Location = New System.Drawing.Point(12, 296)
        Me.DataGridViewKamar.Name = "DataGridViewKamar"
        Me.DataGridViewKamar.RowTemplate.Height = 25
        Me.DataGridViewKamar.Size = New System.Drawing.Size(1085, 256)
        Me.DataGridViewKamar.TabIndex = 75
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Controls.Add(Me.BtnHapus)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.BtnTambah)
        Me.Panel2.Controls.Add(Me.BtnInfo)
        Me.Panel2.Controls.Add(Me.BtnEdit)
        Me.Panel2.Location = New System.Drawing.Point(12, 69)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1085, 60)
        Me.Panel2.TabIndex = 89
        '
        'BtnHapus
        '
        Me.BtnHapus.BackColor = System.Drawing.Color.DimGray
        Me.BtnHapus.BackgroundImage = CType(resources.GetObject("BtnHapus.BackgroundImage"), System.Drawing.Image)
        Me.BtnHapus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnHapus.Location = New System.Drawing.Point(1030, 9)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(38, 39)
        Me.BtnHapus.TabIndex = 92
        Me.BtnHapus.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Papyrus", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(43, 11)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(274, 42)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "HOTEL AYO'S"
        '
        'BtnTambah
        '
        Me.BtnTambah.BackColor = System.Drawing.Color.DimGray
        Me.BtnTambah.BackgroundImage = CType(resources.GetObject("BtnTambah.BackgroundImage"), System.Drawing.Image)
        Me.BtnTambah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnTambah.Location = New System.Drawing.Point(898, 9)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(38, 39)
        Me.BtnTambah.TabIndex = 90
        Me.BtnTambah.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnTambah.UseVisualStyleBackColor = False
        '
        'BtnInfo
        '
        Me.BtnInfo.BackColor = System.Drawing.Color.DimGray
        Me.BtnInfo.BackgroundImage = CType(resources.GetObject("BtnInfo.BackgroundImage"), System.Drawing.Image)
        Me.BtnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnInfo.Location = New System.Drawing.Point(986, 9)
        Me.BtnInfo.Name = "BtnInfo"
        Me.BtnInfo.Size = New System.Drawing.Size(38, 39)
        Me.BtnInfo.TabIndex = 93
        Me.BtnInfo.UseVisualStyleBackColor = False
        '
        'BtnEdit
        '
        Me.BtnEdit.BackColor = System.Drawing.Color.DimGray
        Me.BtnEdit.BackgroundImage = CType(resources.GetObject("BtnEdit.BackgroundImage"), System.Drawing.Image)
        Me.BtnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnEdit.Location = New System.Drawing.Point(941, 9)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(38, 39)
        Me.BtnEdit.TabIndex = 91
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.Location = New System.Drawing.Point(505, 148)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(592, 130)
        Me.Panel4.TabIndex = 87
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.BtnLogOut)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1085, 60)
        Me.Panel1.TabIndex = 88
        '
        'BtnLogOut
        '
        Me.BtnLogOut.BackColor = System.Drawing.Color.Black
        Me.BtnLogOut.BackgroundImage = CType(resources.GetObject("BtnLogOut.BackgroundImage"), System.Drawing.Image)
        Me.BtnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnLogOut.Location = New System.Drawing.Point(1027, 6)
        Me.BtnLogOut.Name = "BtnLogOut"
        Me.BtnLogOut.Size = New System.Drawing.Size(38, 39)
        Me.BtnLogOut.TabIndex = 74
        Me.BtnLogOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnLogOut.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Variable Text", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(43, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "KAMAR"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.LblUser)
        Me.Panel3.Controls.Add(Me.LblEmail)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.PictBoxNama)
        Me.Panel3.Location = New System.Drawing.Point(12, 148)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(475, 130)
        Me.Panel3.TabIndex = 86
        '
        'LblUser
        '
        Me.LblUser.AutoSize = True
        Me.LblUser.Font = New System.Drawing.Font("Segoe UI Variable Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblUser.Location = New System.Drawing.Point(210, 39)
        Me.LblUser.Name = "LblUser"
        Me.LblUser.Size = New System.Drawing.Size(44, 21)
        Me.LblUser.TabIndex = 26
        Me.LblUser.Text = "User"
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.Font = New System.Drawing.Font("Segoe UI Variable Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblEmail.Location = New System.Drawing.Point(167, 68)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(138, 21)
        Me.LblEmail.TabIndex = 24
        Me.LblEmail.Text = "user@gmail.com"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(167, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 21)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Hello!"
        '
        'PictBoxNama
        '
        Me.PictBoxNama.Location = New System.Drawing.Point(43, 17)
        Me.PictBoxNama.Name = "PictBoxNama"
        Me.PictBoxNama.Size = New System.Drawing.Size(100, 100)
        Me.PictBoxNama.TabIndex = 0
        Me.PictBoxNama.TabStop = False
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog"
        '
        'Kamar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1137, 565)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.DataGridViewKamar)
        Me.Controls.Add(Me.ToolStripKamar_)
        Me.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "Kamar"
        Me.Text = "Kamar"
        Me.ToolStripKamar_.ResumeLayout(False)
        Me.ToolStripKamar_.PerformLayout()
        CType(Me.DataGridViewKamar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictBoxNama, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStripKamar_ As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents DataGridViewKamar As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnHapus As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents BtnTambah As Button
    Friend WithEvents BtnInfo As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnLogOut As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LblUser As Label
    Friend WithEvents LblEmail As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PictBoxNama As PictureBox
    Friend WithEvents OpenFileDialog As OpenFileDialog
End Class
