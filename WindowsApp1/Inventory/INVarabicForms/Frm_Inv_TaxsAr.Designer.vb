<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Inv_TaxsAr
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
        Me.RadButton3 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton2 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.UserControl11 = New WindowsApp1.UserControl1()
        Me.RadTextBox1 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        CType(Me.RadButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadButton3
        '
        Me.RadButton3.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.RadButton3.Location = New System.Drawing.Point(5, 171)
        Me.RadButton3.Name = "RadButton3"
        Me.RadButton3.Size = New System.Drawing.Size(110, 24)
        Me.RadButton3.TabIndex = 7
        Me.RadButton3.Text = "الغاء الامر"
        '
        'RadButton2
        '
        Me.RadButton2.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.RadButton2.Location = New System.Drawing.Point(121, 171)
        Me.RadButton2.Name = "RadButton2"
        Me.RadButton2.Size = New System.Drawing.Size(110, 24)
        Me.RadButton2.TabIndex = 6
        Me.RadButton2.Text = "تعديل"
        '
        'RadButton1
        '
        Me.RadButton1.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.RadButton1.Location = New System.Drawing.Point(237, 171)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(110, 24)
        Me.RadButton1.TabIndex = 5
        Me.RadButton1.Text = "حفظ"
        '
        'UserControl11
        '
        Me.UserControl11.Location = New System.Drawing.Point(2, -1)
        Me.UserControl11.Name = "UserControl11"
        Me.UserControl11.Size = New System.Drawing.Size(420, 136)
        Me.UserControl11.TabIndex = 4
        '
        'RadTextBox1
        '
        Me.RadTextBox1.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.RadTextBox1.Location = New System.Drawing.Point(58, 135)
        Me.RadTextBox1.Name = "RadTextBox1"
        Me.RadTextBox1.Size = New System.Drawing.Size(267, 27)
        Me.RadTextBox1.TabIndex = 8
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.RadLabel1.Location = New System.Drawing.Point(331, 136)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(98, 26)
        Me.RadLabel1.TabIndex = 9
        Me.RadLabel1.Text = "نسبه الضريبه "
        '
        'Frm_Inv_TaxsAr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 208)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.RadTextBox1)
        Me.Controls.Add(Me.RadButton3)
        Me.Controls.Add(Me.RadButton2)
        Me.Controls.Add(Me.RadButton1)
        Me.Controls.Add(Me.UserControl11)
        Me.Name = "Frm_Inv_TaxsAr"
        Me.Text = "Frm_Inv_TaxsAr"
        CType(Me.RadButton3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RadButton3 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton2 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents UserControl11 As UserControl1
    Friend WithEvents RadTextBox1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
End Class
