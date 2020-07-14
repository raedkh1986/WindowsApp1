<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Inv_CalcQtyAr
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
        Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn5 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.RadGridView1 = New Telerik.WinControls.UI.RadGridView()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadGridView1
        '
        Me.RadGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadGridView1.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.RadGridView1.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.RadGridView1.MasterTemplate.AllowAddNewRow = False
        Me.RadGridView1.MasterTemplate.AllowColumnReorder = False
        GridViewTextBoxColumn1.FieldName = "B_Barcode"
        GridViewTextBoxColumn1.HeaderText = "باركود الصنف"
        GridViewTextBoxColumn1.Name = "B_Barcode"
        GridViewTextBoxColumn1.Width = 150
        GridViewTextBoxColumn2.FieldName = "B_Name"
        GridViewTextBoxColumn2.HeaderText = "اسم الصنف"
        GridViewTextBoxColumn2.Name = "B_Name"
        GridViewTextBoxColumn2.Width = 200
        GridViewTextBoxColumn3.FieldName = "B_INQTY"
        GridViewTextBoxColumn3.HeaderText = "الكمية الداخلة"
        GridViewTextBoxColumn3.Name = "B_INQTY"
        GridViewTextBoxColumn3.Width = 150
        GridViewTextBoxColumn4.FieldName = "B_OQTY"
        GridViewTextBoxColumn4.HeaderText = "الكمية الخارجة"
        GridViewTextBoxColumn4.Name = "B_OQTY"
        GridViewTextBoxColumn4.Width = 150
        GridViewTextBoxColumn5.FieldName = "B_Balance"
        GridViewTextBoxColumn5.HeaderText = "الرصيد"
        GridViewTextBoxColumn5.Name = "B_Balance"
        GridViewTextBoxColumn5.Width = 150
        Me.RadGridView1.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewTextBoxColumn4, GridViewTextBoxColumn5})
        Me.RadGridView1.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.RadGridView1.Name = "RadGridView1"
        Me.RadGridView1.ReadOnly = True
        Me.RadGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadGridView1.Size = New System.Drawing.Size(818, 527)
        Me.RadGridView1.TabIndex = 0
        Me.RadGridView1.Text = "RadGridView1"
        '
        'Frm_Inv_CalcQtyAr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(818, 527)
        Me.Controls.Add(Me.RadGridView1)
        Me.Name = "Frm_Inv_CalcQtyAr"
        Me.Text = "Frm_Inv_CalcQtyAr"
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RadGridView1 As Telerik.WinControls.UI.RadGridView
End Class
