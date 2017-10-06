<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistracionSuplemento
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
        Me.ckb_activo = New System.Windows.Forms.CheckBox()
        Me.cmb_proveedor = New System.Windows.Forms.ComboBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_precioventa = New System.Windows.Forms.NumericUpDown()
        Me.txt_preciocompra = New System.Windows.Forms.NumericUpDown()
        Me.txt_codigo = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.txt_precioventa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_preciocompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_codigo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ckb_activo
        '
        Me.ckb_activo.AutoSize = True
        Me.ckb_activo.Enabled = False
        Me.ckb_activo.Location = New System.Drawing.Point(157, 287)
        Me.ckb_activo.Name = "ckb_activo"
        Me.ckb_activo.Size = New System.Drawing.Size(56, 17)
        Me.ckb_activo.TabIndex = 49
        Me.ckb_activo.Text = "Activo"
        Me.ckb_activo.UseVisualStyleBackColor = True
        '
        'cmb_proveedor
        '
        Me.cmb_proveedor.Enabled = False
        Me.cmb_proveedor.FormattingEnabled = True
        Me.cmb_proveedor.Location = New System.Drawing.Point(157, 242)
        Me.cmb_proveedor.Name = "cmb_proveedor"
        Me.cmb_proveedor.Size = New System.Drawing.Size(216, 21)
        Me.cmb_proveedor.TabIndex = 48
        '
        'txt_nombre
        '
        Me.txt_nombre.Enabled = False
        Me.txt_nombre.Location = New System.Drawing.Point(159, 106)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(214, 20)
        Me.txt_nombre.TabIndex = 47
        '
        'txt_precioventa
        '
        Me.txt_precioventa.Enabled = False
        Me.txt_precioventa.Location = New System.Drawing.Point(157, 198)
        Me.txt_precioventa.Maximum = New Decimal(New Integer() {-1530494976, 232830, 0, 0})
        Me.txt_precioventa.Name = "txt_precioventa"
        Me.txt_precioventa.Size = New System.Drawing.Size(216, 20)
        Me.txt_precioventa.TabIndex = 44
        '
        'txt_preciocompra
        '
        Me.txt_preciocompra.Enabled = False
        Me.txt_preciocompra.Location = New System.Drawing.Point(157, 151)
        Me.txt_preciocompra.Maximum = New Decimal(New Integer() {-727379968, 232, 0, 0})
        Me.txt_preciocompra.Name = "txt_preciocompra"
        Me.txt_preciocompra.Size = New System.Drawing.Size(216, 20)
        Me.txt_preciocompra.TabIndex = 45
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(159, 66)
        Me.txt_codigo.Maximum = New Decimal(New Integer() {1215752192, 23, 0, 0})
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(216, 20)
        Me.txt_codigo.TabIndex = 46
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(64, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Proveedor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(64, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Precio Venta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Precio Compra"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Codigo"
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(384, 356)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(42, 29)
        Me.btn_salir.TabIndex = 38
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.Enabled = False
        Me.btn_guardar.Location = New System.Drawing.Point(115, 333)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(57, 50)
        Me.btn_guardar.TabIndex = 36
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Location = New System.Drawing.Point(37, 333)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(53, 50)
        Me.btn_nuevo.TabIndex = 37
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Gill Sans MT", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(49, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(355, 40)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Registración de suplementos"
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(215, 333)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(57, 50)
        Me.Button1.TabIndex = 51
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RegistracionSuplemento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 397)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ckb_activo)
        Me.Controls.Add(Me.cmb_proveedor)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_precioventa)
        Me.Controls.Add(Me.txt_preciocompra)
        Me.Controls.Add(Me.txt_codigo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Name = "RegistracionSuplemento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegistracionSuplemento"
        CType(Me.txt_precioventa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_preciocompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_codigo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ckb_activo As Windows.Forms.CheckBox
    Friend WithEvents cmb_proveedor As Windows.Forms.ComboBox
    Friend WithEvents txt_nombre As Windows.Forms.TextBox
    Friend WithEvents txt_precioventa As Windows.Forms.NumericUpDown
    Friend WithEvents txt_preciocompra As Windows.Forms.NumericUpDown
    Friend WithEvents txt_codigo As Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents btn_salir As Windows.Forms.Button
    Friend WithEvents btn_guardar As Windows.Forms.Button
    Friend WithEvents btn_nuevo As Windows.Forms.Button
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents Button1 As Windows.Forms.Button
End Class
