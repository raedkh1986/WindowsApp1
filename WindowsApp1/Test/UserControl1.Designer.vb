<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl1
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.RadTextBox1 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox2 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox3 = New Telerik.WinControls.UI.RadTextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadTextBox1
        '
        Me.RadTextBox1.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.RadTextBox1.Location = New System.Drawing.Point(176, 5)
        Me.RadTextBox1.Name = "RadTextBox1"
        Me.RadTextBox1.Size = New System.Drawing.Size(148, 27)
        Me.RadTextBox1.TabIndex = 0
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.RadLabel1.Location = New System.Drawing.Point(341, 5)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(38, 26)
        Me.RadLabel1.TabIndex = 3
        Me.RadLabel1.Text = "الرقم"
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.RadLabel2.Location = New System.Drawing.Point(341, 67)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(78, 26)
        Me.RadLabel2.TabIndex = 5
        Me.RadLabel2.Text = "الاسم     ع"
        '
        'RadTextBox2
        '
        Me.RadTextBox2.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.RadTextBox2.Location = New System.Drawing.Point(54, 67)
        Me.RadTextBox2.Name = "RadTextBox2"
        Me.RadTextBox2.Size = New System.Drawing.Size(270, 27)
        Me.RadTextBox2.TabIndex = 4
        '
        'RadLabel3
        '
        Me.RadLabel3.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.RadLabel3.Location = New System.Drawing.Point(341, 100)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(75, 26)
        Me.RadLabel3.TabIndex = 7
        Me.RadLabel3.Text = "E    الاسم"
        '
        'RadTextBox3
        '
        Me.RadTextBox3.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.RadTextBox3.Location = New System.Drawing.Point(54, 100)
        Me.RadTextBox3.Name = "RadTextBox3"
        Me.RadTextBox3.Size = New System.Drawing.Size(270, 27)
        Me.RadTextBox3.TabIndex = 6
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"فعال", "غير فعال"})
        Me.ComboBox1.Location = New System.Drawing.Point(3, 3)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(93, 26)
        Me.ComboBox1.TabIndex = 8
        Me.ComboBox1.Text = "فعال"
        '
        'UserControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.RadLabel3)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.RadTextBox3)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.RadTextBox2)
        Me.Controls.Add(Me.RadTextBox1)
        Me.Name = "UserControl1"
        Me.Size = New System.Drawing.Size(422, 181)
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RadTextBox1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox2 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox3 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
