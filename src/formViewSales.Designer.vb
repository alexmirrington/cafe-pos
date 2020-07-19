<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formViewSales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formViewSales))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.iptSearch = New System.Windows.Forms.TextBox()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.dateFrom = New System.Windows.Forms.DateTimePicker()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.dateTo = New System.Windows.Forms.DateTimePicker()
        Me.lstSales = New System.Windows.Forms.ListBox()
        Me.btnSortDate = New System.Windows.Forms.Button()
        Me.btnSortEmployee = New System.Windows.Forms.Button()
        Me.btnInspectRecord = New System.Windows.Forms.Button()
        Me.btnSortTotal = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(12, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(76, 40)
        Me.btnBack.TabIndex = 31
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnHelp
        '
        Me.btnHelp.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.Location = New System.Drawing.Point(382, 12)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(40, 40)
        Me.btnHelp.TabIndex = 30
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
        Me.picLogo.TabIndex = 29
        Me.picLogo.TabStop = False
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.Location = New System.Drawing.Point(7, 177)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(75, 26)
        Me.lblSearch.TabIndex = 32
        Me.lblSearch.Text = "Search:"
        '
        'iptSearch
        '
        Me.iptSearch.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iptSearch.Location = New System.Drawing.Point(88, 176)
        Me.iptSearch.Name = "iptSearch"
        Me.iptSearch.Size = New System.Drawing.Size(334, 31)
        Me.iptSearch.TabIndex = 33
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrom.Location = New System.Drawing.Point(19, 211)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(63, 26)
        Me.lblFrom.TabIndex = 34
        Me.lblFrom.Text = "From:"
        '
        'dateFrom
        '
        Me.dateFrom.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateFrom.Location = New System.Drawing.Point(88, 210)
        Me.dateFrom.Name = "dateFrom"
        Me.dateFrom.Size = New System.Drawing.Size(334, 27)
        Me.dateFrom.TabIndex = 35
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTo.Location = New System.Drawing.Point(45, 244)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(37, 26)
        Me.lblTo.TabIndex = 36
        Me.lblTo.Text = "To:"
        '
        'dateTo
        '
        Me.dateTo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTo.Location = New System.Drawing.Point(88, 243)
        Me.dateTo.Name = "dateTo"
        Me.dateTo.Size = New System.Drawing.Size(334, 27)
        Me.dateTo.TabIndex = 37
        '
        'lstSales
        '
        Me.lstSales.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSales.FormattingEnabled = True
        Me.lstSales.ItemHeight = 23
        Me.lstSales.Location = New System.Drawing.Point(12, 296)
        Me.lstSales.Name = "lstSales"
        Me.lstSales.Size = New System.Drawing.Size(410, 165)
        Me.lstSales.TabIndex = 38
        '
        'btnSortDate
        '
        Me.btnSortDate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSortDate.Location = New System.Drawing.Point(12, 467)
        Me.btnSortDate.Name = "btnSortDate"
        Me.btnSortDate.Size = New System.Drawing.Size(202, 40)
        Me.btnSortDate.TabIndex = 39
        Me.btnSortDate.Text = "Sort by Date"
        Me.btnSortDate.UseVisualStyleBackColor = True
        '
        'btnSortEmployee
        '
        Me.btnSortEmployee.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSortEmployee.Location = New System.Drawing.Point(12, 513)
        Me.btnSortEmployee.Name = "btnSortEmployee"
        Me.btnSortEmployee.Size = New System.Drawing.Size(202, 40)
        Me.btnSortEmployee.TabIndex = 40
        Me.btnSortEmployee.Text = "Sort by Employee"
        Me.btnSortEmployee.UseVisualStyleBackColor = True
        '
        'btnInspectRecord
        '
        Me.btnInspectRecord.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInspectRecord.Location = New System.Drawing.Point(220, 513)
        Me.btnInspectRecord.Name = "btnInspectRecord"
        Me.btnInspectRecord.Size = New System.Drawing.Size(202, 40)
        Me.btnInspectRecord.TabIndex = 42
        Me.btnInspectRecord.Text = "Inspect Record"
        Me.btnInspectRecord.UseVisualStyleBackColor = True
        '
        'btnSortTotal
        '
        Me.btnSortTotal.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSortTotal.Location = New System.Drawing.Point(220, 467)
        Me.btnSortTotal.Name = "btnSortTotal"
        Me.btnSortTotal.Size = New System.Drawing.Size(202, 40)
        Me.btnSortTotal.TabIndex = 41
        Me.btnSortTotal.Text = "Sort by Order Total"
        Me.btnSortTotal.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 267)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(312, 26)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Order Date:           Total:       Waiter:"
        '
        'formViewSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(434, 562)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnInspectRecord)
        Me.Controls.Add(Me.btnSortTotal)
        Me.Controls.Add(Me.btnSortEmployee)
        Me.Controls.Add(Me.btnSortDate)
        Me.Controls.Add(Me.lstSales)
        Me.Controls.Add(Me.dateTo)
        Me.Controls.Add(Me.lblTo)
        Me.Controls.Add(Me.dateFrom)
        Me.Controls.Add(Me.lblFrom)
        Me.Controls.Add(Me.iptSearch)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.picLogo)
        Me.MaximumSize = New System.Drawing.Size(450, 600)
        Me.MinimumSize = New System.Drawing.Size(450, 600)
        Me.Name = "formViewSales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Sales"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents iptSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblFrom As System.Windows.Forms.Label
    Friend WithEvents dateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTo As System.Windows.Forms.Label
    Friend WithEvents dateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents lstSales As System.Windows.Forms.ListBox
    Friend WithEvents btnSortDate As System.Windows.Forms.Button
    Friend WithEvents btnSortEmployee As System.Windows.Forms.Button
    Friend WithEvents btnInspectRecord As System.Windows.Forms.Button
    Friend WithEvents btnSortTotal As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
