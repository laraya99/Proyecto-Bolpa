<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegistroEmpleado
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtConfirmarContra = New System.Windows.Forms.TextBox()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.txtApellido2 = New System.Windows.Forms.TextBox()
        Me.txtApellido1 = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbPuesto = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.maskedFechaNacimiento = New System.Windows.Forms.MaskedTextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtConfirmarContra
        '
        Me.txtConfirmarContra.Location = New System.Drawing.Point(174, 422)
        Me.txtConfirmarContra.Name = "txtConfirmarContra"
        Me.txtConfirmarContra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmarContra.Size = New System.Drawing.Size(260, 20)
        Me.txtConfirmarContra.TabIndex = 137
        '
        'txtContraseña
        '
        Me.txtContraseña.Location = New System.Drawing.Point(174, 393)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.Size = New System.Drawing.Size(260, 20)
        Me.txtContraseña.TabIndex = 130
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(174, 364)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(260, 20)
        Me.txtUsuario.TabIndex = 128
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(174, 335)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(260, 20)
        Me.txtDireccion.TabIndex = 127
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(174, 277)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(260, 20)
        Me.txtTelefono.TabIndex = 126
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(174, 306)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(260, 20)
        Me.txtCorreo.TabIndex = 125
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(174, 189)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(260, 20)
        Me.txtCedula.TabIndex = 124
        '
        'txtApellido2
        '
        Me.txtApellido2.Location = New System.Drawing.Point(174, 160)
        Me.txtApellido2.Name = "txtApellido2"
        Me.txtApellido2.Size = New System.Drawing.Size(260, 20)
        Me.txtApellido2.TabIndex = 123
        '
        'txtApellido1
        '
        Me.txtApellido1.Location = New System.Drawing.Point(174, 131)
        Me.txtApellido1.Name = "txtApellido1"
        Me.txtApellido1.Size = New System.Drawing.Size(260, 20)
        Me.txtApellido1.TabIndex = 122
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(174, 102)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(260, 20)
        Me.txtNombre.TabIndex = 112
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(9, 420)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(159, 18)
        Me.Label14.TabIndex = 136
        Me.Label14.Text = "Confirmar Contraseña:"
        '
        'cbPuesto
        '
        Me.cbPuesto.FormattingEnabled = True
        Me.cbPuesto.Location = New System.Drawing.Point(174, 247)
        Me.cbPuesto.Name = "cbPuesto"
        Me.cbPuesto.Size = New System.Drawing.Size(260, 21)
        Me.cbPuesto.TabIndex = 135
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(73, 246)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(95, 18)
        Me.Label15.TabIndex = 134
        Me.Label15.Text = "Área Laboral:"
        '
        'Button3
        '
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.DarkRed
        Me.Button3.Location = New System.Drawing.Point(511, 149)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(105, 38)
        Me.Button3.TabIndex = 131
        Me.Button3.Text = "Salir"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(79, 391)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(89, 18)
        Me.Label17.TabIndex = 129
        Me.Label17.Text = "Contraseña:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(98, 275)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(70, 18)
        Me.Label18.TabIndex = 121
        Me.Label18.Text = "Teléfono:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(42, 159)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(126, 18)
        Me.Label19.TabIndex = 120
        Me.Label19.Text = "Segundo Apellido:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(13, 217)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(155, 18)
        Me.Label20.TabIndex = 119
        Me.Label20.Text = "Fecha De Nacimiento:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(57, 130)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(111, 18)
        Me.Label21.TabIndex = 118
        Me.Label21.Text = "Primer Apellido:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(23, 362)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(145, 18)
        Me.Label22.TabIndex = 117
        Me.Label22.Text = "Nombre De Usuario:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(110, 188)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(58, 18)
        Me.Label23.TabIndex = 116
        Me.Label23.Text = "Cédula:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(93, 333)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(75, 18)
        Me.Label24.TabIndex = 115
        Me.Label24.Text = "Dirección:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(109, 304)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(59, 18)
        Me.Label25.TabIndex = 114
        Me.Label25.Text = "Correo:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(102, 101)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(66, 18)
        Me.Label26.TabIndex = 113
        Me.Label26.Text = "Nombre:"
        '
        'btnAgregar
        '
        Me.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.DarkRed
        Me.btnAgregar.Location = New System.Drawing.Point(511, 101)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(105, 38)
        Me.btnAgregar.TabIndex = 111
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(264, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 24)
        Me.Label1.TabIndex = 139
        Me.Label1.Text = "Registro De Empleado"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.Bolpa.My.Resources.Resources.DiseñoGeneral
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(716, 472)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 138
        Me.PictureBox1.TabStop = False
        '
        'maskedFechaNacimiento
        '
        Me.maskedFechaNacimiento.Location = New System.Drawing.Point(174, 218)
        Me.maskedFechaNacimiento.Mask = "00/00/0000"
        Me.maskedFechaNacimiento.Name = "maskedFechaNacimiento"
        Me.maskedFechaNacimiento.Size = New System.Drawing.Size(260, 20)
        Me.maskedFechaNacimiento.TabIndex = 133
        Me.maskedFechaNacimiento.ValidatingType = GetType(Date)
        '
        'RegistroEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 472)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtConfirmarContra)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.txtCedula)
        Me.Controls.Add(Me.txtApellido2)
        Me.Controls.Add(Me.txtApellido1)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cbPuesto)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.maskedFechaNacimiento)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RegistroEmpleado"
        Me.Text = "MaestroEmpleado"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtConfirmarContra As TextBox
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents txtApellido2 As TextBox
    Friend WithEvents txtApellido1 As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents cbPuesto As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents maskedFechaNacimiento As MaskedTextBox
End Class
