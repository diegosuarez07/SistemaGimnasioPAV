<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistracionEmpleados
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmb_horario = New System.Windows.Forms.ComboBox()
        Me.cmb_funcion = New System.Windows.Forms.ComboBox()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_documento = New System.Windows.Forms.NumericUpDown()
        Me.txt_direccion = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.lbl_calle = New System.Windows.Forms.Label()
        Me.lbl_doc = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_apellido = New System.Windows.Forms.Label()
        Me.btn_guardar = New System.Windows.Forms.Button()
        CType(Me.txt_documento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmb_horario
        '
        Me.cmb_horario.FormattingEnabled = True
        Me.cmb_horario.Location = New System.Drawing.Point(113, 223)
        Me.cmb_horario.Name = "cmb_horario"
        Me.cmb_horario.Size = New System.Drawing.Size(220, 21)
        Me.cmb_horario.TabIndex = 59
        '
        'cmb_funcion
        '
        Me.cmb_funcion.FormattingEnabled = True
        Me.cmb_funcion.Location = New System.Drawing.Point(113, 184)
        Me.cmb_funcion.Name = "cmb_funcion"
        Me.cmb_funcion.Size = New System.Drawing.Size(221, 21)
        Me.cmb_funcion.TabIndex = 58
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(422, 339)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(42, 29)
        Me.btn_salir.TabIndex = 56
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Location = New System.Drawing.Point(13, 318)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(53, 50)
        Me.btn_nuevo.TabIndex = 55
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(113, 260)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(56, 17)
        Me.CheckBox1.TabIndex = 52
        Me.CheckBox1.Text = "Activo"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 226)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Horario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 187)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Funcion"
        '
        'txt_documento
        '
        Me.txt_documento.Location = New System.Drawing.Point(113, 100)
        Me.txt_documento.Name = "txt_documento"
        Me.txt_documento.Size = New System.Drawing.Size(222, 20)
        Me.txt_documento.TabIndex = 49
        '
        'txt_direccion
        '
        Me.txt_direccion.Enabled = False
        Me.txt_direccion.Location = New System.Drawing.Point(113, 145)
        Me.txt_direccion.MaxLength = 50
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(222, 20)
        Me.txt_direccion.TabIndex = 46
        '
        'txt_nombre
        '
        Me.txt_nombre.Enabled = False
        Me.txt_nombre.Location = New System.Drawing.Point(113, 62)
        Me.txt_nombre.MaxLength = 50
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(222, 20)
        Me.txt_nombre.TabIndex = 47
        '
        'txt_apellido
        '
        Me.txt_apellido.Enabled = False
        Me.txt_apellido.Location = New System.Drawing.Point(113, 21)
        Me.txt_apellido.MaxLength = 50
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(222, 20)
        Me.txt_apellido.TabIndex = 48
        '
        'lbl_calle
        '
        Me.lbl_calle.AutoSize = True
        Me.lbl_calle.Location = New System.Drawing.Point(24, 145)
        Me.lbl_calle.Name = "lbl_calle"
        Me.lbl_calle.Size = New System.Drawing.Size(52, 13)
        Me.lbl_calle.TabIndex = 45
        Me.lbl_calle.Text = "Direccion"
        '
        'lbl_doc
        '
        Me.lbl_doc.AutoSize = True
        Me.lbl_doc.Location = New System.Drawing.Point(24, 107)
        Me.lbl_doc.Name = "lbl_doc"
        Me.lbl_doc.Size = New System.Drawing.Size(62, 13)
        Me.lbl_doc.TabIndex = 44
        Me.lbl_doc.Text = "Documento"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(24, 62)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(44, 13)
        Me.lbl_nombre.TabIndex = 43
        Me.lbl_nombre.Text = "Nombre"
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.Location = New System.Drawing.Point(24, 28)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(44, 13)
        Me.lbl_apellido.TabIndex = 42
        Me.lbl_apellido.Text = "Apellido"
        '
        'btn_guardar
        '
        Me.btn_guardar.Enabled = False
        Me.btn_guardar.Location = New System.Drawing.Point(93, 318)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(57, 50)
        Me.btn_guardar.TabIndex = 54
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'RegistracionEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 387)
        Me.Controls.Add(Me.cmb_horario)
        Me.Controls.Add(Me.cmb_funcion)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_documento)
        Me.Controls.Add(Me.txt_direccion)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_apellido)
        Me.Controls.Add(Me.lbl_calle)
        Me.Controls.Add(Me.lbl_doc)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.lbl_apellido)
        Me.Name = "RegistracionEmpleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegistracionEmpleados"
        CType(Me.txt_documento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmb_horario As Windows.Forms.ComboBox
    Friend WithEvents cmb_funcion As Windows.Forms.ComboBox
    Friend WithEvents btn_salir As Windows.Forms.Button
    Friend WithEvents btn_nuevo As Windows.Forms.Button
    Friend WithEvents CheckBox1 As Windows.Forms.CheckBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents txt_documento As Windows.Forms.NumericUpDown
    Friend WithEvents txt_direccion As Windows.Forms.TextBox
    Friend WithEvents txt_nombre As Windows.Forms.TextBox
    Friend WithEvents txt_apellido As Windows.Forms.TextBox
    Friend WithEvents lbl_calle As Windows.Forms.Label
    Friend WithEvents lbl_doc As Windows.Forms.Label
    Friend WithEvents lbl_nombre As Windows.Forms.Label
    Friend WithEvents lbl_apellido As Windows.Forms.Label
    Friend WithEvents btn_guardar As Windows.Forms.Button
End Class
