<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaquinasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistraciónToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistraciónToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuplementosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistraciónToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Tomato
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.MaquinasToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.EmpleadosToolStripMenuItem, Me.SuplementosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(465, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistraciónToolStripMenuItem, Me.ConsultarToolStripMenuItem})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'RegistraciónToolStripMenuItem
        '
        Me.RegistraciónToolStripMenuItem.Name = "RegistraciónToolStripMenuItem"
        Me.RegistraciónToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RegistraciónToolStripMenuItem.Text = "Registración"
        '
        'ConsultarToolStripMenuItem
        '
        Me.ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        Me.ConsultarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ConsultarToolStripMenuItem.Text = "Consultar"
        '
        'MaquinasToolStripMenuItem
        '
        Me.MaquinasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistraciónToolStripMenuItem1, Me.ConsultarToolStripMenuItem1})
        Me.MaquinasToolStripMenuItem.Name = "MaquinasToolStripMenuItem"
        Me.MaquinasToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.MaquinasToolStripMenuItem.Text = "Maquinas"
        '
        'RegistraciónToolStripMenuItem1
        '
        Me.RegistraciónToolStripMenuItem1.Name = "RegistraciónToolStripMenuItem1"
        Me.RegistraciónToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.RegistraciónToolStripMenuItem1.Text = "Registración"
        '
        'ConsultarToolStripMenuItem1
        '
        Me.ConsultarToolStripMenuItem1.Name = "ConsultarToolStripMenuItem1"
        Me.ConsultarToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ConsultarToolStripMenuItem1.Text = "Consultar"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistraciónToolStripMenuItem2, Me.ConsultarToolStripMenuItem2})
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'RegistraciónToolStripMenuItem2
        '
        Me.RegistraciónToolStripMenuItem2.Name = "RegistraciónToolStripMenuItem2"
        Me.RegistraciónToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.RegistraciónToolStripMenuItem2.Text = "Registración"
        '
        'ConsultarToolStripMenuItem2
        '
        Me.ConsultarToolStripMenuItem2.Name = "ConsultarToolStripMenuItem2"
        Me.ConsultarToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.ConsultarToolStripMenuItem2.Text = "Consultar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label1.Location = New System.Drawing.Point(86, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(299, 33)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Gimnasio STRONGEST"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Tomato
        Me.btnSalir.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(378, 216)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 33)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrToolStripMenuItem, Me.ConsultarToolStripMenuItem3})
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'RegistrToolStripMenuItem
        '
        Me.RegistrToolStripMenuItem.Name = "RegistrToolStripMenuItem"
        Me.RegistrToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RegistrToolStripMenuItem.Text = "Registración"
        '
        'ConsultarToolStripMenuItem3
        '
        Me.ConsultarToolStripMenuItem3.Name = "ConsultarToolStripMenuItem3"
        Me.ConsultarToolStripMenuItem3.Size = New System.Drawing.Size(152, 22)
        Me.ConsultarToolStripMenuItem3.Text = "Consultar"
        '
        'SuplementosToolStripMenuItem
        '
        Me.SuplementosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistraciónToolStripMenuItem3, Me.ConsultarToolStripMenuItem4})
        Me.SuplementosToolStripMenuItem.Name = "SuplementosToolStripMenuItem"
        Me.SuplementosToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.SuplementosToolStripMenuItem.Text = "Suplementos"
        '
        'RegistraciónToolStripMenuItem3
        '
        Me.RegistraciónToolStripMenuItem3.Name = "RegistraciónToolStripMenuItem3"
        Me.RegistraciónToolStripMenuItem3.Size = New System.Drawing.Size(152, 22)
        Me.RegistraciónToolStripMenuItem3.Text = "Registración"
        '
        'ConsultarToolStripMenuItem4
        '
        Me.ConsultarToolStripMenuItem4.Name = "ConsultarToolStripMenuItem4"
        Me.ConsultarToolStripMenuItem4.Size = New System.Drawing.Size(152, 22)
        Me.ConsultarToolStripMenuItem4.Text = "Consultar"
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(465, 261)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Sistema Gimnasio"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistraciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MaquinasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistraciónToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistraciónToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents EmpleadosToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem3 As Windows.Forms.ToolStripMenuItem
    Friend WithEvents SuplementosToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistraciónToolStripMenuItem3 As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem4 As Windows.Forms.ToolStripMenuItem
End Class
