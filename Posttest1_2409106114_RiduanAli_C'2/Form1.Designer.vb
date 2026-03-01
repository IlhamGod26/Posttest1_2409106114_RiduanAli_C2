<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		lblInput = New Label()
		lblHasil = New Label()
		lblPredikat = New Label()
		txtInputIP = New TextBox()
		btnTambah = New Button()
		btnReset = New Button()
		txtHasilIPK = New TextBox()
		SuspendLayout()
		' 
		' lblInput
		' 
		lblInput.AutoSize = True
		lblInput.Location = New Point(50, 30)
		lblInput.Name = "lblInput"
		lblInput.Size = New Size(86, 20)
		lblInput.TabIndex = 6
		lblInput.Text = "IP Semester"
		' 
		' lblHasil
		' 
		lblHasil.AutoSize = True
		lblHasil.Location = New Point(50, 110)
		lblHasil.Name = "lblHasil"
		lblHasil.Size = New Size(89, 20)
		lblHasil.TabIndex = 5
		lblHasil.Text = "IP Kumulatif"
		' 
		' lblPredikat
		' 
		lblPredikat.AutoSize = True
		lblPredikat.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
		lblPredikat.Location = New Point(150, 150)
		lblPredikat.Name = "lblPredikat"
		lblPredikat.Size = New Size(20, 28)
		lblPredikat.TabIndex = 4
		lblPredikat.Text = "-"
		' 
		' txtInputIP
		' 
		txtInputIP.Location = New Point(150, 27)
		txtInputIP.Name = "txtInputIP"
		txtInputIP.Size = New Size(125, 27)
		txtInputIP.TabIndex = 3
		' 
		' btnTambah
		' 
		btnTambah.Location = New Point(138, 60)
		btnTambah.Name = "btnTambah"
		btnTambah.Size = New Size(94, 29)
		btnTambah.TabIndex = 2
		btnTambah.Text = "Tambah"
		' 
		' btnReset
		' 
		btnReset.Location = New Point(238, 60)
		btnReset.Name = "btnReset"
		btnReset.Size = New Size(94, 29)
		btnReset.TabIndex = 1
		btnReset.Text = "Reset"
		' 
		' txtHasilIPK
		' 
		txtHasilIPK.Location = New Point(150, 107)
		txtHasilIPK.Name = "txtHasilIPK"
		txtHasilIPK.ReadOnly = True
		txtHasilIPK.Size = New Size(125, 27)
		txtHasilIPK.TabIndex = 0
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(8.0F, 20.0F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(400, 250)
		Controls.Add(txtHasilIPK)
		Controls.Add(btnReset)
		Controls.Add(btnTambah)
		Controls.Add(txtInputIP)
		Controls.Add(lblPredikat)
		Controls.Add(lblHasil)
		Controls.Add(lblInput)
		Name = "Form1"
		Text = "Kalkulator IP"
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents lblInput As System.Windows.Forms.Label
	Friend WithEvents lblHasil As System.Windows.Forms.Label
    Friend WithEvents lblPredikat As System.Windows.Forms.Label
    Friend WithEvents txtInputIP As System.Windows.Forms.TextBox
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents txtHasilIPK As System.Windows.Forms.TextBox
End Class