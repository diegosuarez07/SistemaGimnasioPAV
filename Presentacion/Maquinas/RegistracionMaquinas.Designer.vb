<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistracionMaquinas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.cmd_exit = New System.Windows.Forms.Button()
        Me.cmd_save = New System.Windows.Forms.Button()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_date = New System.Windows.Forms.MaskedTextBox()
        Me.cmb_area = New System.Windows.Forms.ComboBox()
        Me.cmb_prov = New System.Windows.Forms.ComboBox()
        Me.lbl_area = New System.Windows.Forms.Label()
        Me.lbl_prov = New System.Windows.Forms.Label()
        Me.lbl_fecha = New System.Windows.Forms.Label()
        Me.lbl_descripcion = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmd_exit
        '
        Me.cmd_exit.Location = New System.Drawing.Point(401, 260)
        Me.cmd_exit.Name = "cmd_exit"
        Me.cmd_exit.Size = New System.Drawing.Size(52, 22)
        Me.cmd_exit.TabIndex = 36
        Me.cmd_exit.Text = "Salir"
        Me.cmd_exit.UseVisualStyleBackColor = True
        '
        'cmd_save
        '
        Me.cmd_save.Enabled = False
        Me.cmd_save.Location = New System.Drawing.Point(110, 242)
        Me.cmd_save.Name = "cmd_save"
        Me.cmd_save.Size = New System.Drawing.Size(57, 37)
        Me.cmd_save.TabIndex = 34
        Me.cmd_save.Text = "Guardar"
        Me.cmd_save.UseVisualStyleBackColor = True
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.Location = New System.Drawing.Point(22, 243)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(57, 36)
        Me.cmd_nuevo.TabIndex = 35
        Me.cmd_nuevo.Text = "Nuevo"
        Me.cmd_nuevo.UseVisualStyleBackColor = True
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Enabled = False
        Me.txt_descripcion.Location = New System.Drawing.Point(110, 79)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(192, 20)
        Me.txt_descripcion.TabIndex = 33
        '
        'txt_nombre
        '
        Me.txt_nombre.Enabled = False
        Me.txt_nombre.Location = New System.Drawing.Point(112, 29)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(192, 20)
        Me.txt_nombre.TabIndex = 32
        '
        'txt_date
        '
        Me.txt_date.Enabled = False
        Me.txt_date.Location = New System.Drawing.Point(147, 161)
        Me.txt_date.Mask = "00/00/0000"
        Me.txt_date.Name = "txt_date"
        Me.txt_date.Size = New System.Drawing.Size(68, 20)
        Me.txt_date.TabIndex = 31
        Me.txt_date.ValidatingType = GetType(Date)
        '
        'cmb_area
        '
        Me.cmb_area.Enabled = False
        Me.cmb_area.FormattingEnabled = True
        Me.cmb_area.Location = New System.Drawing.Point(112, 193)
        Me.cmb_area.Name = "cmb_area"
        Me.cmb_area.Size = New System.Drawing.Size(190, 21)
        Me.cmb_area.TabIndex = 30
        '
        'cmb_prov
        '
        Me.cmb_prov.Enabled = False
        Me.cmb_prov.FormattingEnabled = True
        Me.cmb_prov.Location = New System.Drawing.Point(112, 124)
        Me.cmb_prov.Name = "cmb_prov"
        Me.cmb_prov.Size = New System.Drawing.Size(190, 21)
        Me.cmb_prov.TabIndex = 29
        '
        'lbl_area
        '
        Me.lbl_area.AutoSize = True
        Me.lbl_area.Location = New System.Drawing.Point(35, 201)
        Me.lbl_area.Name = "lbl_area"
        Me.lbl_area.Size = New System.Drawing.Size(29, 13)
        Me.lbl_area.TabIndex = 24
        Me.lbl_area.Text = "Area"
        '
        'lbl_prov
        '
        Me.lbl_prov.AutoSize = True
        Me.lbl_prov.Location = New System.Drawing.Point(35, 126)
        Me.lbl_prov.Name = "lbl_prov"
        Me.lbl_prov.Size = New System.Drawing.Size(56, 13)
        Me.lbl_prov.TabIndex = 25
        Me.lbl_prov.Text = "Proveedor"
        '
        'lbl_fecha
        '
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.Location = New System.Drawing.Point(35, 164)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(90, 13)
        Me.lbl_fecha.TabIndex = 26
        Me.lbl_fecha.Text = "Fecha de compra"
        '
        'lbl_descripcion
        '
        Me.lbl_descripcion.AutoSize = True
        Me.lbl_descripcion.Location = New System.Drawing.Point(35, 81)
        Me.lbl_descripcion.Name = "lbl_descripcion"
        Me.lbl_descripcion.Size = New System.Drawing.Size(63, 13)
        Me.lbl_descripcion.TabIndex = 27
        Me.lbl_descripcion.Text = "Descripcion"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(35, 36)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(44, 13)
        Me.lbl_nombre.TabIndex = 28
        Me.lbl_nombre.Text = "Nombre"
        '
        'RegistracionMaquinas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 313)
        Me.Controls.Add(Me.cmd_exit)
        Me.Controls.Add(Me.cmd_save)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.txt_descripcion)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_date)
        Me.Controls.Add(Me.cmb_area)
        Me.Controls.Add(Me.cmb_prov)
        Me.Controls.Add(Me.lbl_area)
        Me.Controls.Add(Me.lbl_prov)
        Me.Controls.Add(Me.lbl_fecha)
        Me.Controls.Add(Me.lbl_descripcion)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Name = "RegistracionMaquinas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegistracionMaquinas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_exit As Windows.Forms.Button
    Friend WithEvents cmd_save As Windows.Forms.Button
    Friend WithEvents cmd_nuevo As Windows.Forms.Button
    Friend WithEvents txt_descripcion As Windows.Forms.TextBox
    Friend WithEvents txt_nombre As Windows.Forms.TextBox
    Friend WithEvents txt_date As Windows.Forms.MaskedTextBox
    Friend WithEvents cmb_area As Windows.Forms.ComboBox
    Friend WithEvents cmb_prov As Windows.Forms.ComboBox
    Friend WithEvents lbl_area As Windows.Forms.Label
    Friend WithEvents lbl_prov As Windows.Forms.Label
    Friend WithEvents lbl_fecha As Windows.Forms.Label
    Friend WithEvents lbl_descripcion As Windows.Forms.Label
    Friend WithEvents lbl_nombre As Windows.Forms.Label
End Class
