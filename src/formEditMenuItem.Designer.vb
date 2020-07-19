<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formEditMenuItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formEditMenuItem))
        Me.btnEditItem = New System.Windows.Forms.Button()
        Me.iptItemPrice = New System.Windows.Forms.TextBox()
        Me.lblItemPrice = New System.Windows.Forms.Label()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.lblItem = New System.Windows.Forms.Label()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEditItem
        '
        Me.btnEditItem.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditItem.Location = New System.Drawing.Point(82, 340)
        Me.btnEditItem.Name = "btnEditItem"
        Me.btnEditItem.Size = New System.Drawing.Size(268, 35)
        Me.btnEditItem.TabIndex = 60
        Me.btnEditItem.Text = "Confirm Edit Item"
        Me.btnEditItem.UseVisualStyleBackColor = True
        '
        'iptItemPrice
        '
        Me.iptItemPrice.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iptItemPrice.Location = New System.Drawing.Point(196, 289)
        Me.iptItemPrice.Name = "iptItemPrice"
        Me.iptItemPrice.Size = New System.Drawing.Size(154, 31)
        Me.iptItemPrice.TabIndex = 59
        '
        'lblItemPrice
        '
        Me.lblItemPrice.AutoSize = True
        Me.lblItemPrice.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemPrice.Location = New System.Drawing.Point(86, 294)
        Me.lblItemPrice.Name = "lblItemPrice"
        Me.lblItemPrice.Size = New System.Drawing.Size(104, 26)
        Me.lblItemPrice.TabIndex = 58
        Me.lblItemPrice.Text = "Item Price:"
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemName.Location = New System.Drawing.Point(77, 242)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(113, 26)
        Me.lblItemName.TabIndex = 57
        Me.lblItemName.Text = "Item Name:"
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(12, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(76, 40)
        Me.btnBack.TabIndex = 56
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnHelp
        '
        Me.btnHelp.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.Location = New System.Drawing.Point(382, 12)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(40, 40)
        Me.btnHelp.TabIndex = 55
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
        Me.picLogo.TabIndex = 54
        Me.picLogo.TabStop = False
        '
        'lblItem
        '
        Me.lblItem.AutoSize = True
        Me.lblItem.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItem.Location = New System.Drawing.Point(196, 242)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(114, 26)
        Me.lblItem.TabIndex = 61
        Me.lblItem.Text = "(itemName)"
        '
        'formEditMenuItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(434, 562)
        Me.Controls.Add(Me.lblItem)
        Me.Controls.Add(Me.btnEditItem)
        Me.Controls.Add(Me.iptItemPrice)
        Me.Controls.Add(Me.lblItemPrice)
        Me.Controls.Add(Me.lblItemName)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.picLogo)
        Me.MaximumSize = New System.Drawing.Size(450, 600)
        Me.MinimumSize = New System.Drawing.Size(450, 600)
        Me.Name = "formEditMenuItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Menu Item"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEditItem As System.Windows.Forms.Button
    Friend WithEvents iptItemPrice As System.Windows.Forms.TextBox
    Friend WithEvents lblItemPrice As System.Windows.Forms.Label
    Friend WithEvents lblItemName As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblItem As System.Windows.Forms.Label
End Class
