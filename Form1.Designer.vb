<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtNama = New TextBox()
        ButtonHitung = New Button()
        txtGajiPokok = New TextBox()
        txtJumlahAnak = New TextBox()
        txtGajiTotal = New TextBox()
        ButtonTampilkanData = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(119, 96)
        Label1.Name = "Label1"
        Label1.Size = New Size(536, 41)
        Label1.TabIndex = 0
        Label1.Text = "Aplikasi Perhitungan Gaji Karyawan"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(132, 177)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 25)
        Label2.TabIndex = 1
        Label2.Text = "Name : "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(132, 228)
        Label3.Name = "Label3"
        Label3.Size = New Size(113, 25)
        Label3.TabIndex = 2
        Label3.Text = "Gaji Pokok : "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(132, 281)
        Label4.Name = "Label4"
        Label4.Size = New Size(130, 25)
        Label4.TabIndex = 3
        Label4.Text = "Jumlah Anak : "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(132, 332)
        Label5.Name = "Label5"
        Label5.Size = New Size(100, 25)
        Label5.TabIndex = 4
        Label5.Text = "Gaji Total :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(492, 285)
        Label6.Name = "Label6"
        Label6.Size = New Size(142, 20)
        Label6.TabIndex = 5
        Label6.Text = "Maksimal Anak ke-3"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(268, 175)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(200, 27)
        txtNama.TabIndex = 6
        ' 
        ' ButtonHitung
        ' 
        ButtonHitung.Location = New Point(495, 177)
        ButtonHitung.Name = "ButtonHitung"
        ButtonHitung.Size = New Size(139, 76)
        ButtonHitung.TabIndex = 10
        ButtonHitung.Text = "Hitung"
        ButtonHitung.UseVisualStyleBackColor = True
        ' 
        ' txtGajiPokok
        ' 
        txtGajiPokok.Location = New Point(268, 226)
        txtGajiPokok.Name = "txtGajiPokok"
        txtGajiPokok.Size = New Size(200, 27)
        txtGajiPokok.TabIndex = 11
        ' 
        ' txtJumlahAnak
        ' 
        txtJumlahAnak.Location = New Point(268, 278)
        txtJumlahAnak.Name = "txtJumlahAnak"
        txtJumlahAnak.Size = New Size(200, 27)
        txtJumlahAnak.TabIndex = 12
        ' 
        ' txtGajiTotal
        ' 
        txtGajiTotal.Location = New Point(268, 333)
        txtGajiTotal.Name = "txtGajiTotal"
        txtGajiTotal.Size = New Size(200, 27)
        txtGajiTotal.TabIndex = 13
        ' 
        ' ButtonTampilkanData
        ' 
        ButtonTampilkanData.Location = New Point(495, 316)
        ButtonTampilkanData.Name = "ButtonTampilkanData"
        ButtonTampilkanData.Size = New Size(139, 44)
        ButtonTampilkanData.TabIndex = 15
        ButtonTampilkanData.Text = "List Karyawan"
        ButtonTampilkanData.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        ClientSize = New Size(777, 522)
        Controls.Add(ButtonTampilkanData)
        Controls.Add(txtGajiTotal)
        Controls.Add(txtJumlahAnak)
        Controls.Add(txtGajiPokok)
        Controls.Add(ButtonHitung)
        Controls.Add(txtNama)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Aplikasi Perthitungan Gaji Karyawan"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents ButtonHitung As Button
    Friend WithEvents txtGajiPokok As TextBox
    Friend WithEvents txtJumlahAnak As TextBox
    Friend WithEvents txtGajiTotal As TextBox
    Friend WithEvents ButtonTampilkanData As Button

End Class
