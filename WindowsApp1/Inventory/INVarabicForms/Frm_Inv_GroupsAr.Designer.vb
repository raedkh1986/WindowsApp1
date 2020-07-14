<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Inv_GroupsAr
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
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.UserControl11 = New WindowsApp1.UserControl1()
        Me.RadButton2 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton3 = New Telerik.WinControls.UI.RadButton()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadButton1
        '
        Me.RadButton1.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.RadButton1.Location = New System.Drawing.Point(234, 144)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(110, 24)
        Me.RadButton1.TabIndex = 1
        Me.RadButton1.Text = "حفظ"
        '
        'UserControl11
        '
        Me.UserControl11.Location = New System.Drawing.Point(2, 2)
        Me.UserControl11.Name = "UserControl11"
        Me.UserControl11.Size = New System.Drawing.Size(420, 136)
        Me.UserControl11.TabIndex = 0
        '
        'RadButton2
        '
        Me.RadButton2.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.RadButton2.Location = New System.Drawing.Point(118, 144)
        Me.RadButton2.Name = "RadButton2"
        Me.RadButton2.Size = New System.Drawing.Size(110, 24)
        Me.RadButton2.TabIndex = 2
        Me.RadButton2.Text = "تعديل"
        '
        'RadButton3
        '
        Me.RadButton3.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.RadButton3.Location = New System.Drawing.Point(2, 144)
        Me.RadButton3.Name = "RadButton3"
        Me.RadButton3.Size = New System.Drawing.Size(110, 24)
        Me.RadButton3.TabIndex = 3
        Me.RadButton3.Text = "الغاء الامر"
        '
        'Frm_Inv_GroupsAr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 174)
        Me.Controls.Add(Me.RadButton3)
        Me.Controls.Add(Me.RadButton2)
        Me.Controls.Add(Me.RadButton1)
        Me.Controls.Add(Me.UserControl11)
        Me.Name = "Frm_Inv_GroupsAr"
        Me.Text = "Frm_Inv_GroupsAr"
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UserControl11 As UserControl1
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton2 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton3 As Telerik.WinControls.UI.RadButton
End Class
