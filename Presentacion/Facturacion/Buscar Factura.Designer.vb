<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Buscar_Factura
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.txt_numerofac = New System.Windows.Forms.NumericUpDown()
        Me.txt_cliente = New System.Windows.Forms.TextBox()
        Me.txt_fecha = New System.Windows.Forms.TextBox()
        Me.Cl = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_salir = New System.Windows.Forms.Button()
        CType(Me.txt_numerofac, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Factura Nº"
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(448, 26)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(52, 20)
        Me.btn_buscar.TabIndex = 2
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'txt_numerofac
        '
        Me.txt_numerofac.Location = New System.Drawing.Point(128, 28)
        Me.txt_numerofac.Name = "txt_numerofac"
        Me.txt_numerofac.Size = New System.Drawing.Size(294, 20)
        Me.txt_numerofac.TabIndex = 3
        '
        'txt_cliente
        '
        Me.txt_cliente.Location = New System.Drawing.Point(85, 81)
        Me.txt_cliente.Name = "txt_cliente"
        Me.txt_cliente.Size = New System.Drawing.Size(145, 20)
        Me.txt_cliente.TabIndex = 4
        '
        'txt_fecha
        '
        Me.txt_fecha.Location = New System.Drawing.Point(494, 83)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(179, 20)
        Me.txt_fecha.TabIndex = 5
        '
        'Cl
        '
        Me.Cl.AutoSize = True
        Me.Cl.Location = New System.Drawing.Point(20, 83)
        Me.Cl.Name = "Cl"
        Me.Cl.Size = New System.Drawing.Size(39, 13)
        Me.Cl.TabIndex = 6
        Me.Cl.Text = "Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(378, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Fecha de compra"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(28, 159)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(770, 250)
        Me.DataGridView1.TabIndex = 8
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(666, 470)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(149, 43)
        Me.btn_salir.TabIndex = 9
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'Buscar_Factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 528)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Cl)
        Me.Controls.Add(Me.txt_fecha)
        Me.Controls.Add(Me.txt_cliente)
        Me.Controls.Add(Me.txt_numerofac)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Buscar_Factura"
        Me.Text = "Buscar_Factura"
        CType(Me.txt_numerofac, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents btn_buscar As Windows.Forms.Button
    Friend WithEvents txt_numerofac As Windows.Forms.NumericUpDown
    Friend WithEvents txt_cliente As Windows.Forms.TextBox
    Friend WithEvents txt_fecha As Windows.Forms.TextBox
    Friend WithEvents Cl As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents DataGridView1 As Windows.Forms.DataGridView
    Friend WithEvents btn_salir As Windows.Forms.Button
End Class
