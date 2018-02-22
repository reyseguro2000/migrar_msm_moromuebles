<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.cmb_bodegas = New System.Windows.Forms.ComboBox()
        Me.bt_buscar = New System.Windows.Forms.Button()
        Me.dg_clientes = New System.Windows.Forms.DataGridView()
        Me.dg_detalle = New System.Windows.Forms.DataGridView()
        Me.dg_pagos = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dg_credito = New System.Windows.Forms.DataGridView()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        CType(Me.dg_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_pagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_credito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bodega"
        '
        'cmb_bodegas
        '
        Me.cmb_bodegas.FormattingEnabled = True
        Me.cmb_bodegas.Location = New System.Drawing.Point(57, 26)
        Me.cmb_bodegas.Name = "cmb_bodegas"
        Me.cmb_bodegas.Size = New System.Drawing.Size(278, 21)
        Me.cmb_bodegas.TabIndex = 1
        '
        'bt_buscar
        '
        Me.bt_buscar.Location = New System.Drawing.Point(341, 26)
        Me.bt_buscar.Name = "bt_buscar"
        Me.bt_buscar.Size = New System.Drawing.Size(75, 23)
        Me.bt_buscar.TabIndex = 2
        Me.bt_buscar.Text = "Buscar"
        Me.bt_buscar.UseVisualStyleBackColor = True
        '
        'dg_clientes
        '
        Me.dg_clientes.AllowUserToAddRows = False
        Me.dg_clientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dg_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_clientes.Location = New System.Drawing.Point(12, 94)
        Me.dg_clientes.Name = "dg_clientes"
        Me.dg_clientes.ReadOnly = True
        Me.dg_clientes.Size = New System.Drawing.Size(889, 150)
        Me.dg_clientes.TabIndex = 3
        '
        'dg_detalle
        '
        Me.dg_detalle.AllowUserToAddRows = False
        Me.dg_detalle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dg_detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_detalle.Location = New System.Drawing.Point(299, 276)
        Me.dg_detalle.Name = "dg_detalle"
        Me.dg_detalle.ReadOnly = True
        Me.dg_detalle.Size = New System.Drawing.Size(240, 150)
        Me.dg_detalle.TabIndex = 5
        '
        'dg_pagos
        '
        Me.dg_pagos.AllowUserToAddRows = False
        Me.dg_pagos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dg_pagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_pagos.Location = New System.Drawing.Point(12, 276)
        Me.dg_pagos.Name = "dg_pagos"
        Me.dg_pagos.ReadOnly = True
        Me.dg_pagos.Size = New System.Drawing.Size(240, 150)
        Me.dg_pagos.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "clientes"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 257)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "pagos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(299, 260)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "detalles"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(469, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 86)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 432)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(127, 60)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(299, 432)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(127, 60)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(590, 257)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "credito"
        '
        'dg_credito
        '
        Me.dg_credito.AllowUserToAddRows = False
        Me.dg_credito.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dg_credito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_credito.Location = New System.Drawing.Point(573, 276)
        Me.dg_credito.Name = "dg_credito"
        Me.dg_credito.ReadOnly = True
        Me.dg_credito.Size = New System.Drawing.Size(240, 150)
        Me.dg_credito.TabIndex = 13
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(573, 432)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(127, 60)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(757, 31)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 16
        Me.Button5.Text = "COLOR"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(125, 520)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(688, 23)
        Me.ProgressBar1.TabIndex = 17
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(926, 586)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dg_credito)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dg_pagos)
        Me.Controls.Add(Me.dg_detalle)
        Me.Controls.Add(Me.dg_clientes)
        Me.Controls.Add(Me.bt_buscar)
        Me.Controls.Add(Me.cmb_bodegas)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dg_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_detalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_pagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_credito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_bodegas As ComboBox
    Friend WithEvents bt_buscar As Button
    Friend WithEvents dg_clientes As DataGridView
    Friend WithEvents dg_detalle As DataGridView
    Friend WithEvents dg_pagos As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents dg_credito As DataGridView
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
