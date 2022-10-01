<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBkUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBkUp))
        Me.pnlBkp = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlBkp.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlBkp
        '
        Me.pnlBkp.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.pnlBkp.Controls.Add(Me.Label4)
        Me.pnlBkp.Controls.Add(Me.Button7)
        Me.pnlBkp.Controls.Add(Me.Label2)
        Me.pnlBkp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBkp.Location = New System.Drawing.Point(0, 0)
        Me.pnlBkp.Name = "pnlBkp"
        Me.pnlBkp.Size = New System.Drawing.Size(819, 476)
        Me.pnlBkp.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(82, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(180, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Última copia de seguridad:"
        '
        'Button7
        '
        Me.Button7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button7.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button7.Location = New System.Drawing.Point(226, 335)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(308, 50)
        Me.Button7.TabIndex = 7
        Me.Button7.Text = "Back Up"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(82, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(654, 48)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'FormBkUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 476)
        Me.Controls.Add(Me.pnlBkp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormBkUp"
        Me.Text = "Form2"
        Me.pnlBkp.ResumeLayout(False)
        Me.pnlBkp.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlBkp As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Label2 As Label
End Class
