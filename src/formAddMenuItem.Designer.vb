<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAddMenuItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formAddMenuItem))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.iptItemName = New System.Windows.Forms.TextBox()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.iptItemPrice = New System.Windows.Forms.TextBox()
        Me.lblItemPrice = New System.Windows.Forms.Label()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.togFood = New System.Windows.Forms.RadioButton()
        Me.togBeverage = New System.Windows.Forms.RadioButton()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(12, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(76, 40)
        Me.btnBack.TabIndex = 48
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnHelp
        '
        Me.btnHelp.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.Location = New System.Drawing.Point(382, 12)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(40, 40)
        Me.btnHelp.TabIndex = 47
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
        Me.picLogo.TabIndex = 46
        Me.picLogo.TabStop = False
        '
        'iptItemName
        '
        Me.iptItemName.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iptItemName.Location = New System.Drawing.Point(196, 241)
        Me.iptItemName.Name = "iptItemName"
        Me.iptItemName.Size = New System.Drawing.Size(154, 31)
        Me.iptItemName.TabIndex = 53
        '
        'btnAddItem
        '
        Me.btnAddItem.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddItem.Location = New System.Drawing.Point(82, 401)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(268, 35)
        Me.btnAddItem.TabIndex = 52
        Me.btnAddItem.Text = "Add Item"
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'iptItemPrice
        '
        Me.iptItemPrice.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iptItemPrice.Location = New System.Drawing.Point(196, 289)
        Me.iptItemPrice.Name = "iptItemPrice"
        Me.iptItemPrice.Size = New System.Drawing.Size(154, 31)
        Me.iptItemPrice.TabIndex = 51
        '
        'lblItemPrice
        '
        Me.lblItemPrice.AutoSize = True
        Me.lblItemPrice.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemPrice.Location = New System.Drawing.Point(86, 294)
        Me.lblItemPrice.Name = "lblItemPrice"
        Me.lblItemPrice.Size = New System.Drawing.Size(104, 26)
        Me.lblItemPrice.TabIndex = 50
        Me.lblItemPrice.Text = "Item Price:"
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemName.Location = New System.Drawing.Point(77, 242)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(113, 26)
        Me.lblItemName.TabIndex = 49
        Me.lblItemName.Text = "Item Name:"
        '
        'togFood
        '
        Me.togFood.AutoSize = True
        Me.togFood.Checked = True
        Me.togFood.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.togFood.Location = New System.Drawing.Point(173, 331)
        Me.togFood.Name = "togFood"
        Me.togFood.Size = New System.Drawing.Size(73, 30)
        Me.togFood.TabIndex = 64
        Me.togFood.TabStop = True
        Me.togFood.Text = "Food"
        Me.togFood.UseVisualStyleBackColor = True
        '
        'togBeverage
        '
        Me.togBeverage.AutoSize = True
        Me.togBeverage.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.togBeverage.Location = New System.Drawing.Point(173, 365)
        Me.togBeverage.Name = "togBeverage"
        Me.togBeverage.Size = New System.Drawing.Size(107, 30)
        Me.togBeverage.TabIndex = 65
        Me.togBeverage.Text = "Beverage"
        Me.togBeverage.UseVisualStyleBackColor = True
        '
        'formAddMenuItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(434, 562)
        Me.Controls.Add(Me.togFood)
        Me.Controls.Add(Me.togBeverage)
        Me.Controls.Add(Me.iptItemName)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.iptItemPrice)
        Me.Controls.Add(Me.lblItemPrice)
        Me.Controls.Add(Me.lblItemName)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.picLogo)
        Me.MaximumSize = New System.Drawing.Size(450, 600)
        Me.MinimumSize = New System.Drawing.Size(450, 600)
        Me.Name = "formAddMenuItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Menu Item"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents iptItemName As System.Windows.Forms.TextBox
    Friend WithEvents btnAddItem As System.Windows.Forms.Button
    Friend WithEvents iptItemPrice As System.Windows.Forms.TextBox
    Friend WithEvents lblItemPrice As System.Windows.Forms.Label
    Friend WithEvents lblItemName As System.Windows.Forms.Label
    Friend WithEvents togFood As System.Windows.Forms.RadioButton
    Friend WithEvents togBeverage As System.Windows.Forms.RadioButton
End Class
