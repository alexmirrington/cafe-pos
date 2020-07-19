<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formEditMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formEditMenu))
        Me.btnResetMenu = New System.Windows.Forms.Button()
        Me.btnDeleteMenuItem = New System.Windows.Forms.Button()
        Me.btnEditMenuItem = New System.Windows.Forms.Button()
        Me.btnAddMenuItem = New System.Windows.Forms.Button()
        Me.lstMenuItems = New System.Windows.Forms.ListBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnResetMenu
        '
        Me.btnResetMenu.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetMenu.Location = New System.Drawing.Point(220, 513)
        Me.btnResetMenu.Name = "btnResetMenu"
        Me.btnResetMenu.Size = New System.Drawing.Size(202, 40)
        Me.btnResetMenu.TabIndex = 50
        Me.btnResetMenu.Text = "Reset Menu"
        Me.btnResetMenu.UseVisualStyleBackColor = True
        '
        'btnDeleteMenuItem
        '
        Me.btnDeleteMenuItem.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteMenuItem.Location = New System.Drawing.Point(220, 467)
        Me.btnDeleteMenuItem.Name = "btnDeleteMenuItem"
        Me.btnDeleteMenuItem.Size = New System.Drawing.Size(202, 40)
        Me.btnDeleteMenuItem.TabIndex = 49
        Me.btnDeleteMenuItem.Text = "Delete Menu Item"
        Me.btnDeleteMenuItem.UseVisualStyleBackColor = True
        '
        'btnEditMenuItem
        '
        Me.btnEditMenuItem.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditMenuItem.Location = New System.Drawing.Point(12, 513)
        Me.btnEditMenuItem.Name = "btnEditMenuItem"
        Me.btnEditMenuItem.Size = New System.Drawing.Size(202, 40)
        Me.btnEditMenuItem.TabIndex = 48
        Me.btnEditMenuItem.Text = "Edit Menu Item"
        Me.btnEditMenuItem.UseVisualStyleBackColor = True
        '
        'btnAddMenuItem
        '
        Me.btnAddMenuItem.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddMenuItem.Location = New System.Drawing.Point(12, 467)
        Me.btnAddMenuItem.Name = "btnAddMenuItem"
        Me.btnAddMenuItem.Size = New System.Drawing.Size(202, 40)
        Me.btnAddMenuItem.TabIndex = 47
        Me.btnAddMenuItem.Text = "Add Menu Item"
        Me.btnAddMenuItem.UseVisualStyleBackColor = True
        '
        'lstMenuItems
        '
        Me.lstMenuItems.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstMenuItems.FormattingEnabled = True
        Me.lstMenuItems.ItemHeight = 23
        Me.lstMenuItems.Location = New System.Drawing.Point(12, 181)
        Me.lstMenuItems.Name = "lstMenuItems"
        Me.lstMenuItems.Size = New System.Drawing.Size(410, 280)
        Me.lstMenuItems.TabIndex = 46
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(12, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(76, 40)
        Me.btnBack.TabIndex = 45
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnHelp
        '
        Me.btnHelp.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.Location = New System.Drawing.Point(382, 12)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(40, 40)
        Me.btnHelp.TabIndex = 44
        Me.btnHelp.Text = "?"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'picLogo
        '
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(-2, 60)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(440, 110)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo.TabIndex = 43
        Me.picLogo.TabStop = False
        '
        'formEditMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(434, 562)
        Me.Controls.Add(Me.btnResetMenu)
        Me.Controls.Add(Me.btnDeleteMenuItem)
        Me.Controls.Add(Me.btnEditMenuItem)
        Me.Controls.Add(Me.btnAddMenuItem)
        Me.Controls.Add(Me.lstMenuItems)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.picLogo)
        Me.MaximumSize = New System.Drawing.Size(450, 600)
        Me.MinimumSize = New System.Drawing.Size(450, 600)
        Me.Name = "formEditMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Menu"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnResetMenu As System.Windows.Forms.Button
    Friend WithEvents btnDeleteMenuItem As System.Windows.Forms.Button
    Friend WithEvents btnEditMenuItem As System.Windows.Forms.Button
    Friend WithEvents btnAddMenuItem As System.Windows.Forms.Button
    Friend WithEvents lstMenuItems As System.Windows.Forms.ListBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
End Class
