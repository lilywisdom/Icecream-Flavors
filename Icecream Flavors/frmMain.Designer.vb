<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.ListBoxFlavors = New System.Windows.Forms.ListBox()
        Me.picFlavors = New System.Windows.Forms.PictureBox()
        CType(Me.picFlavors, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBoxFlavors
        '
        Me.ListBoxFlavors.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxFlavors.FormattingEnabled = True
        Me.ListBoxFlavors.ItemHeight = 37
        Me.ListBoxFlavors.Items.AddRange(New Object() {"Strawberry", "Vanilla", "Chocolate", "Pistachio", "Salted Caramel"})
        Me.ListBoxFlavors.Location = New System.Drawing.Point(376, 99)
        Me.ListBoxFlavors.Name = "ListBoxFlavors"
        Me.ListBoxFlavors.Size = New System.Drawing.Size(209, 189)
        Me.ListBoxFlavors.TabIndex = 0
        '
        'picFlavors
        '
        Me.picFlavors.Location = New System.Drawing.Point(51, 57)
        Me.picFlavors.Name = "picFlavors"
        Me.picFlavors.Size = New System.Drawing.Size(248, 270)
        Me.picFlavors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFlavors.TabIndex = 1
        Me.picFlavors.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(649, 398)
        Me.Controls.Add(Me.picFlavors)
        Me.Controls.Add(Me.ListBoxFlavors)
        Me.Name = "frmMain"
        Me.Text = "Ice Cream Flavors"
        CType(Me.picFlavors, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBoxFlavors As ListBox
    Friend WithEvents picFlavors As PictureBox
End Class
