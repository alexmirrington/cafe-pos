<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPayOrders
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formPayOrders))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.lstOrders = New System.Windows.Forms.ListBox()
        Me.btnConfirmPayment = New System.Windows.Forms.Button()
        Me.iptCustomerComments = New System.Windows.Forms.TextBox()
        Me.lblCustomerComments = New System.Windows.Forms.Label()
        Me.btnSortByTable = New System.Windows.Forms.Button()
        Me.btnSortByTotal = New System.Windows.Forms.Button()
        Me.lblHeading = New System.Windows.Forms.Label()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(12, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(76, 40)
        Me.btnBack.TabIndex = 28
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnHelp
        '
        Me.btnHelp.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.Location = New System.Drawing.Point(382, 12)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(40, 40)
        Me.btnHelp.TabIndex = 27
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
        Me.picLogo.TabIndex = 26
        Me.picLogo.TabStop = False
        '
        'lstOrders
        '
        Me.lstOrders.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOrders.FormattingEnabled = True
        Me.lstOrders.ItemHeight = 23
        Me.lstOrders.Location = New System.Drawing.Point(12, 199)
        Me.lstOrders.Name = "lstOrders"
        Me.lstOrders.Size = New System.Drawing.Size(243, 303)
        Me.lstOrders.TabIndex = 29
        '
        'btnConfirmPayment
        '
        Me.btnConfirmPayment.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmPayment.Location = New System.Drawing.Point(12, 510)
        Me.btnConfirmPayment.Name = "btnConfirmPayment"
        Me.btnConfirmPayment.Size = New System.Drawing.Size(410, 40)
        Me.btnConfirmPayment.TabIndex = 30
        Me.btnConfirmPayment.Text = "Confirm Payment"
        Me.btnConfirmPayment.UseVisualStyleBackColor = True
        '
        'iptCustomerComments
        '
        Me.iptCustomerComments.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iptCustomerComments.Location = New System.Drawing.Point(264, 300)
        Me.iptCustomerComments.Multiline = True
        Me.iptCustomerComments.Name = "iptCustomerComments"
        Me.iptCustomerComments.Size = New System.Drawing.Size(158, 202)
        Me.iptCustomerComments.TabIndex = 31
        '
        'lblCustomerComments
        '
        Me.lblCustomerComments.AutoSize = True
        Me.lblCustomerComments.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerComments.Location = New System.Drawing.Point(262, 276)
        Me.lblCustomerComments.Name = "lblCustomerComments"
        Me.lblCustomerComments.Size = New System.Drawing.Size(163, 21)
        Me.lblCustomerComments.TabIndex = 32
        Me.lblCustomerComments.Text = "Customer Comments:"
        '
        'btnSortByTable
        '
        Me.btnSortByTable.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSortByTable.Location = New System.Drawing.Point(266, 176)
        Me.btnSortByTable.Name = "btnSortByTable"
        Me.btnSortByTable.Size = New System.Drawing.Size(158, 40)
        Me.btnSortByTable.TabIndex = 33
        Me.btnSortByTable.Text = "Sort by Table Number"
        Me.btnSortByTable.UseVisualStyleBackColor = True
        '
        'btnSortByTotal
        '
        Me.btnSortByTotal.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSortByTotal.Location = New System.Drawing.Point(266, 222)
        Me.btnSortByTotal.Name = "btnSortByTotal"
        Me.btnSortByTotal.Size = New System.Drawing.Size(158, 40)
        Me.btnSortByTotal.TabIndex = 34
        Me.btnSortByTotal.Text = "Sort by Order Total"
        Me.btnSortByTotal.UseVisualStyleBackColor = True
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(12, 173)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(248, 26)
        Me.lblHeading.TabIndex = 35
        Me.lblHeading.Text = "Table:     Waiter:    Subtotal:"
        '
        'formPayOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(434, 562)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.btnSortByTotal)
        Me.Controls.Add(Me.btnSortByTable)
        Me.Controls.Add(Me.lblCustomerComments)
        Me.Controls.Add(Me.iptCustomerComments)
        Me.Controls.Add(Me.btnConfirmPayment)
        Me.Controls.Add(Me.lstOrders)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.picLogo)
        Me.MaximumSize = New System.Drawing.Size(450, 600)
        Me.MinimumSize = New System.Drawing.Size(450, 600)
        Me.Name = "formPayOrders"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pay For Orders"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lstOrders As System.Windows.Forms.ListBox
    Friend WithEvents btnConfirmPayment As System.Windows.Forms.Button
    Friend WithEvents iptCustomerComments As System.Windows.Forms.TextBox
    Friend WithEvents lblCustomerComments As System.Windows.Forms.Label
    Friend WithEvents btnSortByTable As System.Windows.Forms.Button
    Friend WithEvents btnSortByTotal As System.Windows.Forms.Button
    Friend WithEvents lblHeading As System.Windows.Forms.Label
End Class
