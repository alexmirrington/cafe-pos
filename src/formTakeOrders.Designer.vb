<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formTakeOrders
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formTakeOrders))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.tabControl = New System.Windows.Forms.TabControl()
        Me.tabSelectTable = New System.Windows.Forms.TabPage()
        Me.lblTableNumber = New System.Windows.Forms.Label()
        Me.togTable16 = New System.Windows.Forms.RadioButton()
        Me.togTable15 = New System.Windows.Forms.RadioButton()
        Me.togTable14 = New System.Windows.Forms.RadioButton()
        Me.togTable13 = New System.Windows.Forms.RadioButton()
        Me.togTable12 = New System.Windows.Forms.RadioButton()
        Me.togTable11 = New System.Windows.Forms.RadioButton()
        Me.togTable10 = New System.Windows.Forms.RadioButton()
        Me.togTable9 = New System.Windows.Forms.RadioButton()
        Me.togTable8 = New System.Windows.Forms.RadioButton()
        Me.togTable7 = New System.Windows.Forms.RadioButton()
        Me.togTable6 = New System.Windows.Forms.RadioButton()
        Me.togTable5 = New System.Windows.Forms.RadioButton()
        Me.togTable4 = New System.Windows.Forms.RadioButton()
        Me.togTable3 = New System.Windows.Forms.RadioButton()
        Me.togTable2 = New System.Windows.Forms.RadioButton()
        Me.togTable1 = New System.Windows.Forms.RadioButton()
        Me.tabFoodAndDrinks = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBeverageAmount = New System.Windows.Forms.TextBox()
        Me.comboBeverages = New System.Windows.Forms.ComboBox()
        Me.lblBeverageAmount = New System.Windows.Forms.Label()
        Me.btnAddBeverage = New System.Windows.Forms.Button()
        Me.lblBeverage = New System.Windows.Forms.Label()
        Me.btnResetList = New System.Windows.Forms.Button()
        Me.lstItems = New System.Windows.Forms.ListBox()
        Me.txtFoodAmount = New System.Windows.Forms.TextBox()
        Me.comboFood = New System.Windows.Forms.ComboBox()
        Me.lblFoodAmount = New System.Windows.Forms.Label()
        Me.btnAddFood = New System.Windows.Forms.Button()
        Me.lblFood = New System.Windows.Forms.Label()
        Me.tabConfirm = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnConfirmOrder = New System.Windows.Forms.Button()
        Me.lblOrderTotalAmount = New System.Windows.Forms.Label()
        Me.lblOrderTotalTitle = New System.Windows.Forms.Label()
        Me.lstItemsConfirm = New System.Windows.Forms.ListBox()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabControl.SuspendLayout()
        Me.tabSelectTable.SuspendLayout()
        Me.tabFoodAndDrinks.SuspendLayout()
        Me.tabConfirm.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(12, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(76, 40)
        Me.btnBack.TabIndex = 25
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnHelp
        '
        Me.btnHelp.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.Location = New System.Drawing.Point(382, 12)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(40, 40)
        Me.btnHelp.TabIndex = 24
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
        Me.picLogo.TabIndex = 23
        Me.picLogo.TabStop = False
        '
        'tabControl
        '
        Me.tabControl.Controls.Add(Me.tabSelectTable)
        Me.tabControl.Controls.Add(Me.tabFoodAndDrinks)
        Me.tabControl.Controls.Add(Me.tabConfirm)
        Me.tabControl.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabControl.ItemSize = New System.Drawing.Size(125, 28)
        Me.tabControl.Location = New System.Drawing.Point(12, 176)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tabControl.SelectedIndex = 0
        Me.tabControl.Size = New System.Drawing.Size(410, 374)
        Me.tabControl.TabIndex = 26
        '
        'tabSelectTable
        '
        Me.tabSelectTable.Controls.Add(Me.lblTableNumber)
        Me.tabSelectTable.Controls.Add(Me.togTable16)
        Me.tabSelectTable.Controls.Add(Me.togTable15)
        Me.tabSelectTable.Controls.Add(Me.togTable14)
        Me.tabSelectTable.Controls.Add(Me.togTable13)
        Me.tabSelectTable.Controls.Add(Me.togTable12)
        Me.tabSelectTable.Controls.Add(Me.togTable11)
        Me.tabSelectTable.Controls.Add(Me.togTable10)
        Me.tabSelectTable.Controls.Add(Me.togTable9)
        Me.tabSelectTable.Controls.Add(Me.togTable8)
        Me.tabSelectTable.Controls.Add(Me.togTable7)
        Me.tabSelectTable.Controls.Add(Me.togTable6)
        Me.tabSelectTable.Controls.Add(Me.togTable5)
        Me.tabSelectTable.Controls.Add(Me.togTable4)
        Me.tabSelectTable.Controls.Add(Me.togTable3)
        Me.tabSelectTable.Controls.Add(Me.togTable2)
        Me.tabSelectTable.Controls.Add(Me.togTable1)
        Me.tabSelectTable.Location = New System.Drawing.Point(4, 32)
        Me.tabSelectTable.Name = "tabSelectTable"
        Me.tabSelectTable.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSelectTable.Size = New System.Drawing.Size(402, 338)
        Me.tabSelectTable.TabIndex = 0
        Me.tabSelectTable.Text = "Select Table"
        Me.tabSelectTable.UseVisualStyleBackColor = True
        '
        'lblTableNumber
        '
        Me.lblTableNumber.AutoSize = True
        Me.lblTableNumber.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTableNumber.Location = New System.Drawing.Point(63, 15)
        Me.lblTableNumber.Name = "lblTableNumber"
        Me.lblTableNumber.Size = New System.Drawing.Size(255, 26)
        Me.lblTableNumber.TabIndex = 16
        Me.lblTableNumber.Text = "Please select a table number"
        '
        'togTable16
        '
        Me.togTable16.Appearance = System.Windows.Forms.Appearance.Button
        Me.togTable16.BackColor = System.Drawing.Color.LightGray
        Me.togTable16.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.togTable16.FlatAppearance.CheckedBackColor = System.Drawing.Color.Orange
        Me.togTable16.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat
        Me.togTable16.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Wheat
        Me.togTable16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.togTable16.Location = New System.Drawing.Point(256, 236)
        Me.togTable16.Name = "togTable16"
        Me.togTable16.Size = New System.Drawing.Size(60, 60)
        Me.togTable16.TabIndex = 15
        Me.togTable16.Tag = "15"
        Me.togTable16.Text = "16"
        Me.togTable16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.togTable16.UseVisualStyleBackColor = False
        '
        'togTable15
        '
        Me.togTable15.Appearance = System.Windows.Forms.Appearance.Button
        Me.togTable15.BackColor = System.Drawing.Color.LightGray
        Me.togTable15.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.togTable15.FlatAppearance.CheckedBackColor = System.Drawing.Color.Orange
        Me.togTable15.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat
        Me.togTable15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Wheat
        Me.togTable15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.togTable15.Location = New System.Drawing.Point(192, 236)
        Me.togTable15.Name = "togTable15"
        Me.togTable15.Size = New System.Drawing.Size(60, 60)
        Me.togTable15.TabIndex = 14
        Me.togTable15.Tag = "14"
        Me.togTable15.Text = "15"
        Me.togTable15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.togTable15.UseVisualStyleBackColor = False
        '
        'togTable14
        '
        Me.togTable14.Appearance = System.Windows.Forms.Appearance.Button
        Me.togTable14.BackColor = System.Drawing.Color.LightGray
        Me.togTable14.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.togTable14.FlatAppearance.CheckedBackColor = System.Drawing.Color.Orange
        Me.togTable14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat
        Me.togTable14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Wheat
        Me.togTable14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.togTable14.Location = New System.Drawing.Point(128, 236)
        Me.togTable14.Name = "togTable14"
        Me.togTable14.Size = New System.Drawing.Size(60, 60)
        Me.togTable14.TabIndex = 13
        Me.togTable14.Tag = "13"
        Me.togTable14.Text = "14"
        Me.togTable14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.togTable14.UseVisualStyleBackColor = False
        '
        'togTable13
        '
        Me.togTable13.Appearance = System.Windows.Forms.Appearance.Button
        Me.togTable13.BackColor = System.Drawing.Color.LightGray
        Me.togTable13.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.togTable13.FlatAppearance.CheckedBackColor = System.Drawing.Color.Orange
        Me.togTable13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat
        Me.togTable13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Wheat
        Me.togTable13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.togTable13.Location = New System.Drawing.Point(64, 236)
        Me.togTable13.Name = "togTable13"
        Me.togTable13.Size = New System.Drawing.Size(60, 60)
        Me.togTable13.TabIndex = 12
        Me.togTable13.Tag = "12"
        Me.togTable13.Text = "13"
        Me.togTable13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.togTable13.UseVisualStyleBackColor = False
        '
        'togTable12
        '
        Me.togTable12.Appearance = System.Windows.Forms.Appearance.Button
        Me.togTable12.BackColor = System.Drawing.Color.LightGray
        Me.togTable12.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.togTable12.FlatAppearance.CheckedBackColor = System.Drawing.Color.Orange
        Me.togTable12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat
        Me.togTable12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Wheat
        Me.togTable12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.togTable12.Location = New System.Drawing.Point(256, 172)
        Me.togTable12.Name = "togTable12"
        Me.togTable12.Size = New System.Drawing.Size(60, 60)
        Me.togTable12.TabIndex = 11
        Me.togTable12.Tag = "11"
        Me.togTable12.Text = "12"
        Me.togTable12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.togTable12.UseVisualStyleBackColor = False
        '
        'togTable11
        '
        Me.togTable11.Appearance = System.Windows.Forms.Appearance.Button
        Me.togTable11.BackColor = System.Drawing.Color.LightGray
        Me.togTable11.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.togTable11.FlatAppearance.CheckedBackColor = System.Drawing.Color.Orange
        Me.togTable11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat
        Me.togTable11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Wheat
        Me.togTable11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.togTable11.Location = New System.Drawing.Point(192, 172)
        Me.togTable11.Name = "togTable11"
        Me.togTable11.Size = New System.Drawing.Size(60, 60)
        Me.togTable11.TabIndex = 10
        Me.togTable11.Tag = "10"
        Me.togTable11.Text = "11"
        Me.togTable11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.togTable11.UseVisualStyleBackColor = False
        '
        'togTable10
        '
        Me.togTable10.Appearance = System.Windows.Forms.Appearance.Button
        Me.togTable10.BackColor = System.Drawing.Color.LightGray
        Me.togTable10.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.togTable10.FlatAppearance.CheckedBackColor = System.Drawing.Color.Orange
        Me.togTable10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat
        Me.togTable10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Wheat
        Me.togTable10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.togTable10.Location = New System.Drawing.Point(128, 172)
        Me.togTable10.Name = "togTable10"
        Me.togTable10.Size = New System.Drawing.Size(60, 60)
        Me.togTable10.TabIndex = 9
        Me.togTable10.Tag = "9"
        Me.togTable10.Text = "10"
        Me.togTable10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.togTable10.UseVisualStyleBackColor = False
        '
        'togTable9
        '
        Me.togTable9.Appearance = System.Windows.Forms.Appearance.Button
        Me.togTable9.BackColor = System.Drawing.Color.LightGray
        Me.togTable9.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.togTable9.FlatAppearance.CheckedBackColor = System.Drawing.Color.Orange
        Me.togTable9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat
        Me.togTable9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Wheat
        Me.togTable9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.togTable9.Location = New System.Drawing.Point(64, 172)
        Me.togTable9.Name = "togTable9"
        Me.togTable9.Size = New System.Drawing.Size(60, 60)
        Me.togTable9.TabIndex = 8
        Me.togTable9.Tag = "8"
        Me.togTable9.Text = "9"
        Me.togTable9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.togTable9.UseVisualStyleBackColor = False
        '
        'togTable8
        '
        Me.togTable8.Appearance = System.Windows.Forms.Appearance.Button
        Me.togTable8.BackColor = System.Drawing.Color.LightGray
        Me.togTable8.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.togTable8.FlatAppearance.CheckedBackColor = System.Drawing.Color.Orange
        Me.togTable8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat
        Me.togTable8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Wheat
        Me.togTable8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.togTable8.Location = New System.Drawing.Point(256, 108)
        Me.togTable8.Name = "togTable8"
        Me.togTable8.Size = New System.Drawing.Size(60, 60)
        Me.togTable8.TabIndex = 7
        Me.togTable8.Tag = "7"
        Me.togTable8.Text = "8"
        Me.togTable8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.togTable8.UseVisualStyleBackColor = False
        '
        'togTable7
        '
        Me.togTable7.Appearance = System.Windows.Forms.Appearance.Button
        Me.togTable7.BackColor = System.Drawing.Color.LightGray
        Me.togTable7.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.togTable7.FlatAppearance.CheckedBackColor = System.Drawing.Color.Orange
        Me.togTable7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat
        Me.togTable7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Wheat
        Me.togTable7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.togTable7.Location = New System.Drawing.Point(192, 108)
        Me.togTable7.Name = "togTable7"
        Me.togTable7.Size = New System.Drawing.Size(60, 60)
        Me.togTable7.TabIndex = 6
        Me.togTable7.Tag = "6"
        Me.togTable7.Text = "7"
        Me.togTable7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.togTable7.UseVisualStyleBackColor = False
        '
        'togTable6
        '
        Me.togTable6.Appearance = System.Windows.Forms.Appearance.Button
        Me.togTable6.BackColor = System.Drawing.Color.LightGray
        Me.togTable6.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.togTable6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Orange
        Me.togTable6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat
        Me.togTable6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Wheat
        Me.togTable6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.togTable6.Location = New System.Drawing.Point(128, 108)
        Me.togTable6.Name = "togTable6"
        Me.togTable6.Size = New System.Drawing.Size(60, 60)
        Me.togTable6.TabIndex = 5
        Me.togTable6.Tag = "5"
        Me.togTable6.Text = "6"
        Me.togTable6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.togTable6.UseVisualStyleBackColor = False
        '
        'togTable5
        '
        Me.togTable5.Appearance = System.Windows.Forms.Appearance.Button
        Me.togTable5.BackColor = System.Drawing.Color.LightGray
        Me.togTable5.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.togTable5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Orange
        Me.togTable5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat
        Me.togTable5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Wheat
        Me.togTable5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.togTable5.Location = New System.Drawing.Point(64, 108)
        Me.togTable5.Name = "togTable5"
        Me.togTable5.Size = New System.Drawing.Size(60, 60)
        Me.togTable5.TabIndex = 4
        Me.togTable5.Tag = "4"
        Me.togTable5.Text = "5"
        Me.togTable5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.togTable5.UseVisualStyleBackColor = False
        '
        'togTable4
        '
        Me.togTable4.Appearance = System.Windows.Forms.Appearance.Button
        Me.togTable4.BackColor = System.Drawing.Color.LightGray
        Me.togTable4.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.togTable4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Orange
        Me.togTable4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat
        Me.togTable4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Wheat
        Me.togTable4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.togTable4.Location = New System.Drawing.Point(256, 44)
        Me.togTable4.Name = "togTable4"
        Me.togTable4.Size = New System.Drawing.Size(60, 60)
        Me.togTable4.TabIndex = 3
        Me.togTable4.Tag = "3"
        Me.togTable4.Text = "4"
        Me.togTable4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.togTable4.UseVisualStyleBackColor = False
        '
        'togTable3
        '
        Me.togTable3.Appearance = System.Windows.Forms.Appearance.Button
        Me.togTable3.BackColor = System.Drawing.Color.LightGray
        Me.togTable3.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.togTable3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Orange
        Me.togTable3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat
        Me.togTable3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Wheat
        Me.togTable3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.togTable3.Location = New System.Drawing.Point(192, 44)
        Me.togTable3.Name = "togTable3"
        Me.togTable3.Size = New System.Drawing.Size(60, 60)
        Me.togTable3.TabIndex = 2
        Me.togTable3.Tag = "2"
        Me.togTable3.Text = "3"
        Me.togTable3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.togTable3.UseVisualStyleBackColor = False
        '
        'togTable2
        '
        Me.togTable2.Appearance = System.Windows.Forms.Appearance.Button
        Me.togTable2.BackColor = System.Drawing.Color.LightGray
        Me.togTable2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.togTable2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Orange
        Me.togTable2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat
        Me.togTable2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Wheat
        Me.togTable2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.togTable2.Location = New System.Drawing.Point(128, 44)
        Me.togTable2.Name = "togTable2"
        Me.togTable2.Size = New System.Drawing.Size(60, 60)
        Me.togTable2.TabIndex = 1
        Me.togTable2.Tag = "1"
        Me.togTable2.Text = "2"
        Me.togTable2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.togTable2.UseVisualStyleBackColor = False
        '
        'togTable1
        '
        Me.togTable1.Appearance = System.Windows.Forms.Appearance.Button
        Me.togTable1.BackColor = System.Drawing.Color.LightGray
        Me.togTable1.Checked = True
        Me.togTable1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.togTable1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Orange
        Me.togTable1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat
        Me.togTable1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Wheat
        Me.togTable1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.togTable1.Location = New System.Drawing.Point(64, 44)
        Me.togTable1.Name = "togTable1"
        Me.togTable1.Size = New System.Drawing.Size(60, 60)
        Me.togTable1.TabIndex = 0
        Me.togTable1.TabStop = True
        Me.togTable1.Tag = "0"
        Me.togTable1.Text = "1"
        Me.togTable1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.togTable1.UseVisualStyleBackColor = False
        '
        'tabFoodAndDrinks
        '
        Me.tabFoodAndDrinks.Controls.Add(Me.Label1)
        Me.tabFoodAndDrinks.Controls.Add(Me.txtBeverageAmount)
        Me.tabFoodAndDrinks.Controls.Add(Me.comboBeverages)
        Me.tabFoodAndDrinks.Controls.Add(Me.lblBeverageAmount)
        Me.tabFoodAndDrinks.Controls.Add(Me.btnAddBeverage)
        Me.tabFoodAndDrinks.Controls.Add(Me.lblBeverage)
        Me.tabFoodAndDrinks.Controls.Add(Me.btnResetList)
        Me.tabFoodAndDrinks.Controls.Add(Me.lstItems)
        Me.tabFoodAndDrinks.Controls.Add(Me.txtFoodAmount)
        Me.tabFoodAndDrinks.Controls.Add(Me.comboFood)
        Me.tabFoodAndDrinks.Controls.Add(Me.lblFoodAmount)
        Me.tabFoodAndDrinks.Controls.Add(Me.btnAddFood)
        Me.tabFoodAndDrinks.Controls.Add(Me.lblFood)
        Me.tabFoodAndDrinks.Location = New System.Drawing.Point(4, 32)
        Me.tabFoodAndDrinks.Name = "tabFoodAndDrinks"
        Me.tabFoodAndDrinks.Padding = New System.Windows.Forms.Padding(3)
        Me.tabFoodAndDrinks.Size = New System.Drawing.Size(402, 338)
        Me.tabFoodAndDrinks.TabIndex = 1
        Me.tabFoodAndDrinks.Text = "Food/Beverages"
        Me.tabFoodAndDrinks.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(237, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 26)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Order Summary"
        '
        'txtBeverageAmount
        '
        Me.txtBeverageAmount.Location = New System.Drawing.Point(100, 210)
        Me.txtBeverageAmount.Name = "txtBeverageAmount"
        Me.txtBeverageAmount.Size = New System.Drawing.Size(121, 31)
        Me.txtBeverageAmount.TabIndex = 25
        '
        'comboBeverages
        '
        Me.comboBeverages.FormattingEnabled = True
        Me.comboBeverages.Location = New System.Drawing.Point(100, 173)
        Me.comboBeverages.Name = "comboBeverages"
        Me.comboBeverages.Size = New System.Drawing.Size(121, 31)
        Me.comboBeverages.TabIndex = 24
        '
        'lblBeverageAmount
        '
        Me.lblBeverageAmount.AutoSize = True
        Me.lblBeverageAmount.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBeverageAmount.Location = New System.Drawing.Point(7, 211)
        Me.lblBeverageAmount.Name = "lblBeverageAmount"
        Me.lblBeverageAmount.Size = New System.Drawing.Size(87, 26)
        Me.lblBeverageAmount.TabIndex = 23
        Me.lblBeverageAmount.Text = "Amount:"
        '
        'btnAddBeverage
        '
        Me.btnAddBeverage.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddBeverage.Location = New System.Drawing.Point(29, 247)
        Me.btnAddBeverage.Name = "btnAddBeverage"
        Me.btnAddBeverage.Size = New System.Drawing.Size(192, 35)
        Me.btnAddBeverage.TabIndex = 22
        Me.btnAddBeverage.Text = "Add to List"
        Me.btnAddBeverage.UseVisualStyleBackColor = True
        '
        'lblBeverage
        '
        Me.lblBeverage.AutoSize = True
        Me.lblBeverage.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBeverage.Location = New System.Drawing.Point(-1, 174)
        Me.lblBeverage.Name = "lblBeverage"
        Me.lblBeverage.Size = New System.Drawing.Size(95, 26)
        Me.lblBeverage.TabIndex = 21
        Me.lblBeverage.Text = "Beverage:"
        '
        'btnResetList
        '
        Me.btnResetList.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetList.Location = New System.Drawing.Point(227, 297)
        Me.btnResetList.Name = "btnResetList"
        Me.btnResetList.Size = New System.Drawing.Size(169, 35)
        Me.btnResetList.TabIndex = 20
        Me.btnResetList.Text = "Reset List"
        Me.btnResetList.UseVisualStyleBackColor = True
        '
        'lstItems
        '
        Me.lstItems.FormattingEnabled = True
        Me.lstItems.ItemHeight = 23
        Me.lstItems.Location = New System.Drawing.Point(227, 34)
        Me.lstItems.Name = "lstItems"
        Me.lstItems.Size = New System.Drawing.Size(169, 257)
        Me.lstItems.TabIndex = 19
        '
        'txtFoodAmount
        '
        Me.txtFoodAmount.Location = New System.Drawing.Point(100, 75)
        Me.txtFoodAmount.Name = "txtFoodAmount"
        Me.txtFoodAmount.Size = New System.Drawing.Size(121, 31)
        Me.txtFoodAmount.TabIndex = 18
        '
        'comboFood
        '
        Me.comboFood.FormattingEnabled = True
        Me.comboFood.Location = New System.Drawing.Point(100, 38)
        Me.comboFood.Name = "comboFood"
        Me.comboFood.Size = New System.Drawing.Size(121, 31)
        Me.comboFood.TabIndex = 17
        '
        'lblFoodAmount
        '
        Me.lblFoodAmount.AutoSize = True
        Me.lblFoodAmount.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFoodAmount.Location = New System.Drawing.Point(7, 76)
        Me.lblFoodAmount.Name = "lblFoodAmount"
        Me.lblFoodAmount.Size = New System.Drawing.Size(87, 26)
        Me.lblFoodAmount.TabIndex = 16
        Me.lblFoodAmount.Text = "Amount:"
        '
        'btnAddFood
        '
        Me.btnAddFood.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddFood.Location = New System.Drawing.Point(29, 112)
        Me.btnAddFood.Name = "btnAddFood"
        Me.btnAddFood.Size = New System.Drawing.Size(192, 35)
        Me.btnAddFood.TabIndex = 15
        Me.btnAddFood.Text = "Add to List"
        Me.btnAddFood.UseVisualStyleBackColor = True
        '
        'lblFood
        '
        Me.lblFood.AutoSize = True
        Me.lblFood.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFood.Location = New System.Drawing.Point(33, 39)
        Me.lblFood.Name = "lblFood"
        Me.lblFood.Size = New System.Drawing.Size(61, 26)
        Me.lblFood.TabIndex = 14
        Me.lblFood.Text = "Food:"
        '
        'tabConfirm
        '
        Me.tabConfirm.Controls.Add(Me.Label2)
        Me.tabConfirm.Controls.Add(Me.btnConfirmOrder)
        Me.tabConfirm.Controls.Add(Me.lblOrderTotalAmount)
        Me.tabConfirm.Controls.Add(Me.lblOrderTotalTitle)
        Me.tabConfirm.Controls.Add(Me.lstItemsConfirm)
        Me.tabConfirm.Location = New System.Drawing.Point(4, 32)
        Me.tabConfirm.Name = "tabConfirm"
        Me.tabConfirm.Size = New System.Drawing.Size(402, 338)
        Me.tabConfirm.TabIndex = 2
        Me.tabConfirm.Text = "Confirm Order"
        Me.tabConfirm.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 26)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Order Summary"
        '
        'btnConfirmOrder
        '
        Me.btnConfirmOrder.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmOrder.Location = New System.Drawing.Point(238, 179)
        Me.btnConfirmOrder.Name = "btnConfirmOrder"
        Me.btnConfirmOrder.Size = New System.Drawing.Size(136, 35)
        Me.btnConfirmOrder.TabIndex = 23
        Me.btnConfirmOrder.Text = "Confirm Order"
        Me.btnConfirmOrder.UseVisualStyleBackColor = True
        '
        'lblOrderTotalAmount
        '
        Me.lblOrderTotalAmount.AutoSize = True
        Me.lblOrderTotalAmount.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderTotalAmount.Location = New System.Drawing.Point(270, 141)
        Me.lblOrderTotalAmount.Name = "lblOrderTotalAmount"
        Me.lblOrderTotalAmount.Size = New System.Drawing.Size(72, 26)
        Me.lblOrderTotalAmount.TabIndex = 22
        Me.lblOrderTotalAmount.Text = "$00.00"
        '
        'lblOrderTotalTitle
        '
        Me.lblOrderTotalTitle.AutoSize = True
        Me.lblOrderTotalTitle.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderTotalTitle.Location = New System.Drawing.Point(252, 115)
        Me.lblOrderTotalTitle.Name = "lblOrderTotalTitle"
        Me.lblOrderTotalTitle.Size = New System.Drawing.Size(113, 26)
        Me.lblOrderTotalTitle.TabIndex = 21
        Me.lblOrderTotalTitle.Text = "Order Total:"
        '
        'lstItemsConfirm
        '
        Me.lstItemsConfirm.FormattingEnabled = True
        Me.lstItemsConfirm.ItemHeight = 23
        Me.lstItemsConfirm.Location = New System.Drawing.Point(3, 29)
        Me.lstItemsConfirm.Name = "lstItemsConfirm"
        Me.lstItemsConfirm.Size = New System.Drawing.Size(205, 303)
        Me.lstItemsConfirm.TabIndex = 20
        '
        'formTakeOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(434, 562)
        Me.Controls.Add(Me.tabControl)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.picLogo)
        Me.MaximumSize = New System.Drawing.Size(450, 600)
        Me.MinimumSize = New System.Drawing.Size(450, 600)
        Me.Name = "formTakeOrders"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Take Orders"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabControl.ResumeLayout(False)
        Me.tabSelectTable.ResumeLayout(False)
        Me.tabSelectTable.PerformLayout()
        Me.tabFoodAndDrinks.ResumeLayout(False)
        Me.tabFoodAndDrinks.PerformLayout()
        Me.tabConfirm.ResumeLayout(False)
        Me.tabConfirm.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents tabControl As System.Windows.Forms.TabControl
    Friend WithEvents tabSelectTable As System.Windows.Forms.TabPage
    Friend WithEvents tabFoodAndDrinks As System.Windows.Forms.TabPage
    Friend WithEvents tabConfirm As System.Windows.Forms.TabPage
    Friend WithEvents togTable1 As System.Windows.Forms.RadioButton
    Friend WithEvents togTable2 As System.Windows.Forms.RadioButton
    Friend WithEvents togTable16 As System.Windows.Forms.RadioButton
    Friend WithEvents togTable15 As System.Windows.Forms.RadioButton
    Friend WithEvents togTable14 As System.Windows.Forms.RadioButton
    Friend WithEvents togTable13 As System.Windows.Forms.RadioButton
    Friend WithEvents togTable12 As System.Windows.Forms.RadioButton
    Friend WithEvents togTable11 As System.Windows.Forms.RadioButton
    Friend WithEvents togTable10 As System.Windows.Forms.RadioButton
    Friend WithEvents togTable9 As System.Windows.Forms.RadioButton
    Friend WithEvents togTable8 As System.Windows.Forms.RadioButton
    Friend WithEvents togTable7 As System.Windows.Forms.RadioButton
    Friend WithEvents togTable6 As System.Windows.Forms.RadioButton
    Friend WithEvents togTable5 As System.Windows.Forms.RadioButton
    Friend WithEvents togTable4 As System.Windows.Forms.RadioButton
    Friend WithEvents togTable3 As System.Windows.Forms.RadioButton
    Friend WithEvents lblFoodAmount As System.Windows.Forms.Label
    Friend WithEvents btnAddFood As System.Windows.Forms.Button
    Friend WithEvents lblFood As System.Windows.Forms.Label
    Friend WithEvents txtBeverageAmount As System.Windows.Forms.TextBox
    Friend WithEvents comboBeverages As System.Windows.Forms.ComboBox
    Friend WithEvents lblBeverageAmount As System.Windows.Forms.Label
    Friend WithEvents btnAddBeverage As System.Windows.Forms.Button
    Friend WithEvents lblBeverage As System.Windows.Forms.Label
    Friend WithEvents btnResetList As System.Windows.Forms.Button
    Friend WithEvents lstItems As System.Windows.Forms.ListBox
    Friend WithEvents txtFoodAmount As System.Windows.Forms.TextBox
    Friend WithEvents btnConfirmOrder As System.Windows.Forms.Button
    Friend WithEvents lblOrderTotalAmount As System.Windows.Forms.Label
    Friend WithEvents lblOrderTotalTitle As System.Windows.Forms.Label
    Friend WithEvents lstItemsConfirm As System.Windows.Forms.ListBox
    Friend WithEvents lblTableNumber As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents comboFood As System.Windows.Forms.ComboBox
End Class
