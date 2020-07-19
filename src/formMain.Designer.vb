<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formMain))
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnTakeOrders = New System.Windows.Forms.Button()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnPayForOrders = New System.Windows.Forms.Button()
        Me.btnChangeMenu = New System.Windows.Forms.Button()
        Me.btnViewSales = New System.Windows.Forms.Button()
        Me.btnSwitchUser = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnHelp
        '
        Me.btnHelp.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.Location = New System.Drawing.Point(382, 12)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(40, 40)
        Me.btnHelp.TabIndex = 14
        Me.btnHelp.Text = "?"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'btnTakeOrders
        '
        Me.btnTakeOrders.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTakeOrders.Location = New System.Drawing.Point(109, 238)
        Me.btnTakeOrders.Name = "btnTakeOrders"
        Me.btnTakeOrders.Size = New System.Drawing.Size(222, 35)
        Me.btnTakeOrders.TabIndex = 13
        Me.btnTakeOrders.Text = "Take Orders"
        Me.btnTakeOrders.UseVisualStyleBackColor = True
        '
        'picLogo
        '
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(-2, 60)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(440, 110)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo.TabIndex = 12
        Me.picLogo.TabStop = False
        '
        'lblWelcome
        '
        Me.lblWelcome.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(12, 187)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblWelcome.Size = New System.Drawing.Size(410, 26)
        Me.lblWelcome.TabIndex = 11
        Me.lblWelcome.Text = "Welcome, (Username)"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPayForOrders
        '
        Me.btnPayForOrders.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayForOrders.Location = New System.Drawing.Point(109, 279)
        Me.btnPayForOrders.Name = "btnPayForOrders"
        Me.btnPayForOrders.Size = New System.Drawing.Size(222, 35)
        Me.btnPayForOrders.TabIndex = 15
        Me.btnPayForOrders.Text = "Pay for Orders"
        Me.btnPayForOrders.UseVisualStyleBackColor = True
        '
        'btnChangeMenu
        '
        Me.btnChangeMenu.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeMenu.Location = New System.Drawing.Point(109, 339)
        Me.btnChangeMenu.Name = "btnChangeMenu"
        Me.btnChangeMenu.Size = New System.Drawing.Size(222, 35)
        Me.btnChangeMenu.TabIndex = 16
        Me.btnChangeMenu.Text = "Change Menu"
        Me.btnChangeMenu.UseVisualStyleBackColor = True
        '
        'btnViewSales
        '
        Me.btnViewSales.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewSales.Location = New System.Drawing.Point(109, 380)
        Me.btnViewSales.Name = "btnViewSales"
        Me.btnViewSales.Size = New System.Drawing.Size(222, 35)
        Me.btnViewSales.TabIndex = 17
        Me.btnViewSales.Text = "View Sales"
        Me.btnViewSales.UseVisualStyleBackColor = True
        '
        'btnSwitchUser
        '
        Me.btnSwitchUser.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSwitchUser.Location = New System.Drawing.Point(109, 434)
        Me.btnSwitchUser.Name = "btnSwitchUser"
        Me.btnSwitchUser.Size = New System.Drawing.Size(222, 35)
        Me.btnSwitchUser.TabIndex = 18
        Me.btnSwitchUser.Text = "Switch User"
        Me.btnSwitchUser.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(109, 475)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(222, 35)
        Me.btnQuit.TabIndex = 19
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'formMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(434, 562)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnSwitchUser)
        Me.Controls.Add(Me.btnViewSales)
        Me.Controls.Add(Me.btnChangeMenu)
        Me.Controls.Add(Me.btnPayForOrders)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnTakeOrders)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.lblWelcome)
        Me.MaximumSize = New System.Drawing.Size(450, 600)
        Me.MinimumSize = New System.Drawing.Size(450, 600)
        Me.Name = "formMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents btnTakeOrders As System.Windows.Forms.Button
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents btnPayForOrders As System.Windows.Forms.Button
    Friend WithEvents btnChangeMenu As System.Windows.Forms.Button
    Friend WithEvents btnViewSales As System.Windows.Forms.Button
    Friend WithEvents btnSwitchUser As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
End Class
