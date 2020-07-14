<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Inv_ItemsAr
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
        Dim GridViewTextBoxColumn11 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn12 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn13 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn14 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn15 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn16 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn17 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn18 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn19 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn20 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.RadGridView1 = New Telerik.WinControls.UI.RadGridView()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton2 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton3 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton4 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton5 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton6 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton7 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton8 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton9 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton10 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton11 = New Telerik.WinControls.UI.RadButton()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadGridView1
        '
        Me.RadGridView1.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.RadGridView1.Location = New System.Drawing.Point(3, 2)
        '
        '
        '
        Me.RadGridView1.MasterTemplate.AllowAddNewRow = False
        Me.RadGridView1.MasterTemplate.AllowColumnReorder = False
        GridViewTextBoxColumn11.FieldName = "Item_id"
        GridViewTextBoxColumn11.HeaderText = "رقم الصنف"
        GridViewTextBoxColumn11.Name = "Item_id"
        GridViewTextBoxColumn11.Width = 150
        GridViewTextBoxColumn12.FieldName = "Item_BarCode"
        GridViewTextBoxColumn12.HeaderText = "باركود الصنف"
        GridViewTextBoxColumn12.Name = "Item_BarCode"
        GridViewTextBoxColumn12.Width = 150
        GridViewTextBoxColumn13.FieldName = "Item_NameAr"
        GridViewTextBoxColumn13.HeaderText = "اسم الصنف"
        GridViewTextBoxColumn13.Name = "Item_NameAr"
        GridViewTextBoxColumn13.Width = 200
        GridViewTextBoxColumn14.FieldName = "Sup_NameAr"
        GridViewTextBoxColumn14.HeaderText = "اسم المرود"
        GridViewTextBoxColumn14.Name = "Sup_NameAr"
        GridViewTextBoxColumn14.Width = 200
        GridViewTextBoxColumn15.FieldName = "Fam_NameAr"
        GridViewTextBoxColumn15.HeaderText = "اسم العائله"
        GridViewTextBoxColumn15.Name = "Fam_NameAr"
        GridViewTextBoxColumn15.Width = 200
        GridViewTextBoxColumn16.FieldName = "Tax_NameAr"
        GridViewTextBoxColumn16.HeaderText = "نسبه الضريبه"
        GridViewTextBoxColumn16.Name = "Tax_NameAr"
        GridViewTextBoxColumn16.Width = 100
        GridViewTextBoxColumn17.FieldName = "Item_Cost"
        GridViewTextBoxColumn17.HeaderText = "الكلفه"
        GridViewTextBoxColumn17.Name = "Item_Cost"
        GridViewTextBoxColumn17.Width = 100
        GridViewTextBoxColumn18.FieldName = "Item_Price"
        GridViewTextBoxColumn18.HeaderText = "سعر البيع"
        GridViewTextBoxColumn18.Name = "Item_Price"
        GridViewTextBoxColumn18.Width = 100
        GridViewTextBoxColumn19.FieldName = "Item_Profit"
        GridViewTextBoxColumn19.HeaderText = "الربح"
        GridViewTextBoxColumn19.Name = "Item_Profit"
        GridViewTextBoxColumn19.Width = 100
        GridViewTextBoxColumn20.FieldName = "qty"
        GridViewTextBoxColumn20.HeaderText = "الكميه المتوفره"
        GridViewTextBoxColumn20.Name = "qty"
        GridViewTextBoxColumn20.Width = 115
        Me.RadGridView1.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn11, GridViewTextBoxColumn12, GridViewTextBoxColumn13, GridViewTextBoxColumn14, GridViewTextBoxColumn15, GridViewTextBoxColumn16, GridViewTextBoxColumn17, GridViewTextBoxColumn18, GridViewTextBoxColumn19, GridViewTextBoxColumn20})
        Me.RadGridView1.MasterTemplate.EnableFiltering = True
        Me.RadGridView1.MasterTemplate.ShowChildViewCaptions = True
        Me.RadGridView1.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.RadGridView1.Name = "RadGridView1"
        Me.RadGridView1.ReadOnly = True
        Me.RadGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadGridView1.ShowChildViewCaptions = True
        Me.RadGridView1.Size = New System.Drawing.Size(1428, 553)
        Me.RadGridView1.TabIndex = 0
        Me.RadGridView1.Text = "RadGridView1"
        '
        'RadButton1
        '
        Me.RadButton1.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.RadButton1.Location = New System.Drawing.Point(1308, 561)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(125, 69)
        Me.RadButton1.TabIndex = 1
        Me.RadButton1.Text = "جديد"
        '
        'RadButton2
        '
        Me.RadButton2.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.RadButton2.Location = New System.Drawing.Point(1179, 561)
        Me.RadButton2.Name = "RadButton2"
        Me.RadButton2.Size = New System.Drawing.Size(125, 69)
        Me.RadButton2.TabIndex = 2
        Me.RadButton2.Text = "تعديل"
        '
        'RadButton3
        '
        Me.RadButton3.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.RadButton3.Location = New System.Drawing.Point(1048, 561)
        Me.RadButton3.Name = "RadButton3"
        Me.RadButton3.Size = New System.Drawing.Size(125, 69)
        Me.RadButton3.TabIndex = 2
        Me.RadButton3.Text = "اعاده عرض"
        '
        'RadButton4
        '
        Me.RadButton4.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.RadButton4.Location = New System.Drawing.Point(917, 561)
        Me.RadButton4.Name = "RadButton4"
        Me.RadButton4.Size = New System.Drawing.Size(125, 69)
        Me.RadButton4.TabIndex = 2
        Me.RadButton4.Text = "تعديل اسعار"
        '
        'RadButton5
        '
        Me.RadButton5.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.RadButton5.Location = New System.Drawing.Point(786, 561)
        Me.RadButton5.Name = "RadButton5"
        Me.RadButton5.Size = New System.Drawing.Size(125, 69)
        Me.RadButton5.TabIndex = 2
        Me.RadButton5.Text = "كرت الماده"
        '
        'RadButton6
        '
        Me.RadButton6.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.RadButton6.Location = New System.Drawing.Point(655, 561)
        Me.RadButton6.Name = "RadButton6"
        Me.RadButton6.Size = New System.Drawing.Size(125, 69)
        Me.RadButton6.TabIndex = 2
        Me.RadButton6.Text = "جديد"
        '
        'RadButton7
        '
        Me.RadButton7.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.RadButton7.Location = New System.Drawing.Point(524, 561)
        Me.RadButton7.Name = "RadButton7"
        Me.RadButton7.Size = New System.Drawing.Size(125, 69)
        Me.RadButton7.TabIndex = 2
        Me.RadButton7.Text = "جديد"
        '
        'RadButton8
        '
        Me.RadButton8.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.RadButton8.Location = New System.Drawing.Point(393, 561)
        Me.RadButton8.Name = "RadButton8"
        Me.RadButton8.Size = New System.Drawing.Size(125, 69)
        Me.RadButton8.TabIndex = 2
        Me.RadButton8.Text = "جديد"
        '
        'RadButton9
        '
        Me.RadButton9.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.RadButton9.Location = New System.Drawing.Point(262, 561)
        Me.RadButton9.Name = "RadButton9"
        Me.RadButton9.Size = New System.Drawing.Size(125, 69)
        Me.RadButton9.TabIndex = 2
        Me.RadButton9.Text = "جديد"
        '
        'RadButton10
        '
        Me.RadButton10.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.RadButton10.Location = New System.Drawing.Point(132, 561)
        Me.RadButton10.Name = "RadButton10"
        Me.RadButton10.Size = New System.Drawing.Size(125, 69)
        Me.RadButton10.TabIndex = 2
        Me.RadButton10.Text = "جديد"
        '
        'RadButton11
        '
        Me.RadButton11.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.RadButton11.Location = New System.Drawing.Point(3, 561)
        Me.RadButton11.Name = "RadButton11"
        Me.RadButton11.Size = New System.Drawing.Size(125, 69)
        Me.RadButton11.TabIndex = 2
        Me.RadButton11.Text = "جديد"
        '
        'Frm_Inv_ItemsAr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1434, 634)
        Me.Controls.Add(Me.RadButton11)
        Me.Controls.Add(Me.RadButton10)
        Me.Controls.Add(Me.RadButton9)
        Me.Controls.Add(Me.RadButton8)
        Me.Controls.Add(Me.RadButton7)
        Me.Controls.Add(Me.RadButton6)
        Me.Controls.Add(Me.RadButton5)
        Me.Controls.Add(Me.RadButton4)
        Me.Controls.Add(Me.RadButton3)
        Me.Controls.Add(Me.RadButton2)
        Me.Controls.Add(Me.RadButton1)
        Me.Controls.Add(Me.RadGridView1)
        Me.Name = "Frm_Inv_ItemsAr"
        Me.Text = "Frm_Inv_ItemsAr"
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RadGridView1 As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton2 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton3 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton4 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton5 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton6 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton7 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton8 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton9 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton10 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton11 As Telerik.WinControls.UI.RadButton
End Class
