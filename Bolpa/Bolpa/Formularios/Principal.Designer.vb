<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.tsmiInventario = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiFacturas = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarFacturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CobroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeudasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiReportes = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiEntidades = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip.SuspendLayout()
        Me.Panel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.Lime
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiInventario, Me.ToolStripMenuItem2, Me.tsmiFacturas, Me.ToolStripMenuItem4, Me.tsmiReportes, Me.ToolStripMenuItem6, Me.tsmiEntidades})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'tsmiInventario
        '
        Me.tsmiInventario.Name = "tsmiInventario"
        Me.tsmiInventario.Size = New System.Drawing.Size(72, 20)
        Me.tsmiInventario.Text = "Inventario"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Enabled = False
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(22, 20)
        Me.ToolStripMenuItem2.Text = "|"
        '
        'tsmiFacturas
        '
        Me.tsmiFacturas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerarFacturaToolStripMenuItem, Me.FacturasToolStripMenuItem})
        Me.tsmiFacturas.Name = "tsmiFacturas"
        Me.tsmiFacturas.Size = New System.Drawing.Size(63, 20)
        Me.tsmiFacturas.Text = "Facturas"
        '
        'GenerarFacturaToolStripMenuItem
        '
        Me.GenerarFacturaToolStripMenuItem.Name = "GenerarFacturaToolStripMenuItem"
        Me.GenerarFacturaToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.GenerarFacturaToolStripMenuItem.Text = "Generar Factura"
        '
        'FacturasToolStripMenuItem
        '
        Me.FacturasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CobroToolStripMenuItem, Me.DeudasToolStripMenuItem})
        Me.FacturasToolStripMenuItem.Name = "FacturasToolStripMenuItem"
        Me.FacturasToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.FacturasToolStripMenuItem.Text = "Facturas"
        '
        'CobroToolStripMenuItem
        '
        Me.CobroToolStripMenuItem.Name = "CobroToolStripMenuItem"
        Me.CobroToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.CobroToolStripMenuItem.Text = "Cobros"
        '
        'DeudasToolStripMenuItem
        '
        Me.DeudasToolStripMenuItem.Name = "DeudasToolStripMenuItem"
        Me.DeudasToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.DeudasToolStripMenuItem.Text = "Deudas"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Enabled = False
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(22, 20)
        Me.ToolStripMenuItem4.Text = "|"
        '
        'tsmiReportes
        '
        Me.tsmiReportes.Name = "tsmiReportes"
        Me.tsmiReportes.Size = New System.Drawing.Size(65, 20)
        Me.tsmiReportes.Text = "Reportes"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Enabled = False
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(22, 20)
        Me.ToolStripMenuItem6.Text = "|"
        '
        'tsmiEntidades
        '
        Me.tsmiEntidades.CheckOnClick = True
        Me.tsmiEntidades.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.EmpleadosToolStripMenuItem, Me.ProveedoresToolStripMenuItem})
        Me.tsmiEntidades.Name = "tsmiEntidades"
        Me.tsmiEntidades.Size = New System.Drawing.Size(70, 20)
        Me.tsmiEntidades.Text = "Entidades"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'Panel
        '
        Me.Panel.Controls.Add(Me.PictureBox1)
        Me.Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel.Location = New System.Drawing.Point(0, 0)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(800, 599)
        Me.Panel.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.Bolpa.My.Resources.Resources.DiseñoGeneral
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(800, 599)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 599)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.Panel)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.MaximumSize = New System.Drawing.Size(816, 638)
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Bolpa"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.Panel.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents tsmiInventario As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents tsmiFacturas As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents tsmiReportes As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents tsmiEntidades As ToolStripMenuItem
    Friend WithEvents Panel As Panel
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenerarFacturaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacturasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CobroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeudasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
End Class
