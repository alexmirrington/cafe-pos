<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formNewLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formNewLogin))
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.iptUsername = New System.Windows.Forms.TextBox()
        Me.btnCreateUser = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.iptPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.iptConfirmPassword = New System.Windows.Forms.TextBox()
        Me.lblConfirmPassword = New System.Windows.Forms.Label()
        Me.togManager = New System.Windows.Forms.RadioButton()
        Me.togEmployee = New System.Windows.Forms.RadioButton()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnHelp
        '
        Me.btnHelp.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.Location = New System.Drawing.Point(382, 12)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(40, 40)
        Me.btnHelp.TabIndex = 7
        Me.btnHelp.Text = "?"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'iptUsername
        '
        Me.iptUsername.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iptUsername.Location = New System.Drawing.Point(217, 234)
        Me.iptUsername.Name = "iptUsername"
        Me.iptUsername.Size = New System.Drawing.Size(154, 31)
        Me.iptUsername.TabIndex = 1
        '
        'btnCreateUser
        '
        Me.btnCreateUser.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateUser.Location = New System.Drawing.Point(85, 454)
        Me.btnCreateUser.Name = "btnCreateUser"
        Me.btnCreateUser.Size = New System.Drawing.Size(263, 35)
        Me.btnCreateUser.TabIndex = 6
        Me.btnCreateUser.Text = "Create User"
        Me.btnCreateUser.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-2, 60)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(440, 110)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'iptPassword
        '
        Me.iptPassword.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iptPassword.Location = New System.Drawing.Point(217, 281)
        Me.iptPassword.Name = "iptPassword"
        Me.iptPassword.Size = New System.Drawing.Size(154, 31)
        Me.iptPassword.TabIndex = 2
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(112, 281)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(99, 26)
        Me.lblPassword.TabIndex = 12
        Me.lblPassword.Text = "Password:"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(107, 235)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(104, 26)
        Me.lblUsername.TabIndex = 11
        Me.lblUsername.Text = "Username:"
        '
        'iptConfirmPassword
        '
        Me.iptConfirmPassword.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iptConfirmPassword.Location = New System.Drawing.Point(217, 326)
        Me.iptConfirmPassword.Name = "iptConfirmPassword"
        Me.iptConfirmPassword.Size = New System.Drawing.Size(154, 31)
        Me.iptConfirmPassword.TabIndex = 3
        '
        'lblConfirmPassword
        '
        Me.lblConfirmPassword.AutoSize = True
        Me.lblConfirmPassword.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmPassword.Location = New System.Drawing.Point(35, 327)
        Me.lblConfirmPassword.Name = "lblConfirmPassword"
        Me.lblConfirmPassword.Size = New System.Drawing.Size(172, 26)
        Me.lblConfirmPassword.TabIndex = 18
        Me.lblConfirmPassword.Text = "Confirm Password:"
        '
        'togManager
        '
        Me.togManager.AutoSize = True
        Me.togManager.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.togManager.Location = New System.Drawing.Point(193, 406)
        Me.togManager.Name = "togManager"
        Me.togManager.Size = New System.Drawing.Size(106, 30)
        Me.togManager.TabIndex = 5
        Me.togManager.Text = "Manager"
        Me.togManager.UseVisualStyleBackColor = True
        '
        'togEmployee
        '
        Me.togEmployee.AutoSize = True
        Me.togEmployee.Checked = True
        Me.togEmployee.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.togEmployee.Location = New System.Drawing.Point(193, 372)
        Me.togEmployee.Name = "togEmployee"
        Me.togEmployee.Size = New System.Drawing.Size(114, 30)
        Me.togEmployee.TabIndex = 4
        Me.togEmployee.TabStop = True
        Me.togEmployee.Text = "Employee"
        Me.togEmployee.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(12, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(76, 40)
        Me.btnBack.TabIndex = 8
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'formNewLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(434, 562)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.togEmployee)
        Me.Controls.Add(Me.togManager)
        Me.Controls.Add(Me.iptConfirmPassword)
        Me.Controls.Add(Me.lblConfirmPassword)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.iptUsername)
        Me.Controls.Add(Me.btnCreateUser)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.iptPassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.MaximumSize = New System.Drawing.Size(450, 600)
        Me.MinimumSize = New System.Drawing.Size(450, 600)
        Me.Name = "formNewLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create New Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents iptUsername As System.Windows.Forms.TextBox
    Friend WithEvents btnCreateUser As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents iptPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents iptConfirmPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblConfirmPassword As System.Windows.Forms.Label
    Friend WithEvents togManager As System.Windows.Forms.RadioButton
    Friend WithEvents togEmployee As System.Windows.Forms.RadioButton
    Friend WithEvents btnBack As System.Windows.Forms.Button

End Class
