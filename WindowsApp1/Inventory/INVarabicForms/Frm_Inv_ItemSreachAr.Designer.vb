<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Inv_ItemSreachAr
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
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.RadGridView1 = New Telerik.WinControls.UI.RadGridView()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadGridView1
        '
        Me.RadGridView1.Dock = System.Windows.Forms.DockStyle.Fill
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
        GridViewTextBoxColumn2.FieldName = "Item_BarCode"
        GridViewTextBoxColumn2.HeaderText = "باركود الصنف"
        GridViewTextBoxColumn2.Name = "Item_BarCode"
        GridViewTextBoxColumn2.Width = 100
        GridViewTextBoxColumn3.FieldName = "Item_NameAr"
        GridViewTextBoxColumn3.HeaderText = "اسم الصنف"
        GridViewTextBoxColumn3.Name = "Item_NameAr"
        GridViewTextBoxColumn3.Width = 200
        Me.RadGridView1.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3})
        Me.RadGridView1.MasterTemplate.EnableFiltering = True
        Me.RadGridView1.MasterTemplate.EnableGrouping = False
        Me.RadGridView1.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.RadGridView1.Name = "RadGridView1"
        Me.RadGridView1.ReadOnly = True
        Me.RadGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadGridView1.Size = New System.Drawing.Size(421, 329)
        Me.RadGridView1.TabIndex = 0
        Me.RadGridView1.Text = "RadGridView1"
        '
        'Frm_Inv_ItemSreachAr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 329)
        Me.Controls.Add(Me.RadGridView1)
        Me.Name = "Frm_Inv_ItemSreachAr"
        Me.Text = "Frm_Inv_ItemSreachAr"
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RadGridView1 As Telerik.WinControls.UI.RadGridView
End Class
