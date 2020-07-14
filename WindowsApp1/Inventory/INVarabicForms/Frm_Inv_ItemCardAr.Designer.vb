<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Inv_ItemCardAr
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn5 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn6 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn7 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn8 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewSummaryItem1 As Telerik.WinControls.UI.GridViewSummaryItem = New Telerik.WinControls.UI.GridViewSummaryItem()
        Dim GridViewSummaryItem2 As Telerik.WinControls.UI.GridViewSummaryItem = New Telerik.WinControls.UI.GridViewSummaryItem()
        Dim GridViewSummaryItem3 As Telerik.WinControls.UI.GridViewSummaryItem = New Telerik.WinControls.UI.GridViewSummaryItem()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.RadGridView1 = New Telerik.WinControls.UI.RadGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGridView1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RadGridView1
        '
        Me.RadGridView1.Controls.Add(Me.Label1)
        Me.RadGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadGridView1.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.RadGridView1.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.RadGridView1.MasterTemplate.AllowAddNewRow = False
        Me.RadGridView1.MasterTemplate.AllowColumnReorder = False
        GridViewTextBoxColumn1.FieldName = "Item_id"
        GridViewTextBoxColumn1.HeaderText = "رقم الصنف"
        GridViewTextBoxColumn1.Name = "Item_id"
        GridViewTextBoxColumn1.Width = 100
        GridViewTextBoxColumn2.FieldName = "B_Barcode"
        GridViewTextBoxColumn2.HeaderText = "باركود الصنف"
        GridViewTextBoxColumn2.Name = "B_Barcode"
        GridViewTextBoxColumn2.Width = 150
        GridViewTextBoxColumn3.FieldName = "B_Name"
        GridViewTextBoxColumn3.HeaderText = "الوصف"
        GridViewTextBoxColumn3.Name = "B_Name"
        GridViewTextBoxColumn3.Width = 150
        GridViewTextBoxColumn4.FieldName = "B_Source"
        GridViewTextBoxColumn4.HeaderText = "نوع الحركة"
        GridViewTextBoxColumn4.Name = "B_Source"
        GridViewTextBoxColumn4.Width = 100
        GridViewTextBoxColumn5.FieldName = "B_INQTY"
        GridViewTextBoxColumn5.HeaderText = "الكمية الداخلة"
        GridViewTextBoxColumn5.Name = "B_INQTY"
        GridViewTextBoxColumn5.Width = 100
        GridViewTextBoxColumn6.FieldName = "B_OQTY"
        GridViewTextBoxColumn6.HeaderText = "الكمية الخارجة"
        GridViewTextBoxColumn6.Name = "B_OQTY"
        GridViewTextBoxColumn6.Width = 100
        GridViewTextBoxColumn7.FieldName = "Item_Cost"
        GridViewTextBoxColumn7.HeaderText = "الكلفة"
        GridViewTextBoxColumn7.Name = "Item_Cost"
        GridViewTextBoxColumn7.Width = 100
        GridViewTextBoxColumn8.FieldName = "Item_Price"
        GridViewTextBoxColumn8.HeaderText = "سعر البيع"
        GridViewTextBoxColumn8.Name = "Item_Price"
        GridViewTextBoxColumn8.Width = 100
        Me.RadGridView1.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewTextBoxColumn4, GridViewTextBoxColumn5, GridViewTextBoxColumn6, GridViewTextBoxColumn7, GridViewTextBoxColumn8})
        GridViewSummaryItem1.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum
        GridViewSummaryItem1.AggregateExpression = Nothing
        GridViewSummaryItem1.FormatString = "{0}"
        GridViewSummaryItem1.Name = "B_INQTY"
        GridViewSummaryItem2.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum
        GridViewSummaryItem2.AggregateExpression = Nothing
        GridViewSummaryItem2.FormatString = "{0}"
        GridViewSummaryItem2.Name = "B_OQTY"
        GridViewSummaryItem3.AggregateExpression = Nothing
        GridViewSummaryItem3.FormatString = "{0}"
        GridViewSummaryItem3.Name = "(B_INQTY -B_OQTY)"
        Me.RadGridView1.MasterTemplate.SummaryRowsBottom.Add(New Telerik.WinControls.UI.GridViewSummaryRowItem(New Telerik.WinControls.UI.GridViewSummaryItem() {GridViewSummaryItem1, GridViewSummaryItem2, GridViewSummaryItem3}))
        Me.RadGridView1.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.RadGridView1.Name = "RadGridView1"
        Me.RadGridView1.ReadOnly = True
        Me.RadGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadGridView1.Size = New System.Drawing.Size(914, 670)
        Me.RadGridView1.TabIndex = 0
        Me.RadGridView1.Text = "RadGridView1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 648)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'Frm_Inv_ItemCardAr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 670)
        Me.Controls.Add(Me.RadGridView1)
        Me.Name = "Frm_Inv_ItemCardAr"
        Me.Text = "Frm_Inv_ItemCardAr"
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGridView1.ResumeLayout(False)
        Me.RadGridView1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RadGridView1 As Telerik.WinControls.UI.RadGridView
    Friend WithEvents Label1 As Label
End Class
