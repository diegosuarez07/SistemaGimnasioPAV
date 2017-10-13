<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Facturacion
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
        Me.cmb_cliente = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_seleccionar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_articulo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_cantidad = New System.Windows.Forms.NumericUpDown()
        Me.btn_añadir = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_fin = New System.Windows.Forms.Button()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.txt_cantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmb_cliente
        '
        Me.cmb_cliente.FormattingEnabled = True
        Me.cmb_cliente.Location = New System.Drawing.Point(63, 52)
        Me.cmb_cliente.Name = "cmb_cliente"
        Me.cmb_cliente.Size = New System.Drawing.Size(324, 21)
        Me.cmb_cliente.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cliente: "
        '
        'btn_seleccionar
        '
        Me.btn_seleccionar.Location = New System.Drawing.Point(429, 52)
        Me.btn_seleccionar.Name = "btn_seleccionar"
        Me.btn_seleccionar.Size = New System.Drawing.Size(73, 23)
        Me.btn_seleccionar.TabIndex = 2
        Me.btn_seleccionar.Text = "Seleccionar"
        Me.btn_seleccionar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Articulo: "
        '
        'cmb_articulo
        '
        Me.cmb_articulo.Enabled = False
        Me.cmb_articulo.FormattingEnabled = True
        Me.cmb_articulo.Location = New System.Drawing.Point(66, 129)
        Me.cmb_articulo.Name = "cmb_articulo"
        Me.cmb_articulo.Size = New System.Drawing.Size(224, 21)
        Me.cmb_articulo.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(310, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Cantidad"
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Enabled = False
        Me.txt_cantidad.Location = New System.Drawing.Point(365, 129)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(43, 20)
        Me.txt_cantidad.TabIndex = 6
        '
        'btn_añadir
        '
        Me.btn_añadir.Enabled = False
        Me.btn_añadir.Location = New System.Drawing.Point(429, 126)
        Me.btn_añadir.Name = "btn_añadir"
        Me.btn_añadir.Size = New System.Drawing.Size(75, 23)
        Me.btn_añadir.TabIndex = 7
        Me.btn_añadir.Text = "Añadir"
        Me.btn_añadir.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.Nombre, Me.Cantidad, Me.PrecioUnitario})
        Me.DataGridView1.Enabled = False
        Me.DataGridView1.Location = New System.Drawing.Point(18, 194)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(485, 307)
        Me.DataGridView1.TabIndex = 8
        '
        'id
        '
        Me.id.HeaderText = "ID Articulo"
        Me.id.Name = "id"
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        '
        'PrecioUnitario
        '
        Me.PrecioUnitario.HeaderText = "Precio Unitario"
        Me.PrecioUnitario.Name = "PrecioUnitario"
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Enabled = False
        Me.btn_eliminar.Location = New System.Drawing.Point(21, 517)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(185, 27)
        Me.btn_eliminar.TabIndex = 9
        Me.btn_eliminar.Text = "Eliminar Seleccionado"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_fin
        '
        Me.btn_fin.Enabled = False
        Me.btn_fin.Location = New System.Drawing.Point(382, 587)
        Me.btn_fin.Name = "btn_fin"
        Me.btn_fin.Size = New System.Drawing.Size(122, 22)
        Me.btn_fin.TabIndex = 10
        Me.btn_fin.Text = "Finalizar Factura"
        Me.btn_fin.UseVisualStyleBackColor = True
        '
        'txt_total
        '
        Me.txt_total.Enabled = False
        Me.txt_total.Location = New System.Drawing.Point(414, 523)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(86, 20)
        Me.txt_total.TabIndex = 11
        Me.txt_total.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(362, 526)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Total"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Factura Nº "
        Me.Label5.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(76, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(94, 21)
        Me.ComboBox1.TabIndex = 15
        Me.ComboBox1.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(429, 640)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(73, 48)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Facturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 728)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.btn_fin)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_añadir)
        Me.Controls.Add(Me.txt_cantidad)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmb_articulo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_seleccionar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_cliente)
        Me.Name = "Facturacion"
        Me.Text = "Facturacion"
        CType(Me.txt_cantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmb_cliente As Windows.Forms.ComboBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents btn_seleccionar As Windows.Forms.Button
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents cmb_articulo As Windows.Forms.ComboBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents txt_cantidad As Windows.Forms.NumericUpDown
    Friend WithEvents btn_añadir As Windows.Forms.Button
    Friend WithEvents DataGridView1 As Windows.Forms.DataGridView
    Friend WithEvents btn_eliminar As Windows.Forms.Button
    Friend WithEvents btn_fin As Windows.Forms.Button
    Friend WithEvents txt_total As Windows.Forms.TextBox
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents id As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioUnitario As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents ComboBox1 As Windows.Forms.ComboBox
    Friend WithEvents Button1 As Windows.Forms.Button
End Class
