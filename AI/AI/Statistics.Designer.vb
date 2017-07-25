<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Statistics
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Statistics))
        Me.PanelScroll = New System.Windows.Forms.VScrollBar()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnStore = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelScroll
        '
        Me.PanelScroll.LargeChange = 15
        Me.PanelScroll.Location = New System.Drawing.Point(555, 50)
        Me.PanelScroll.Maximum = 150
        Me.PanelScroll.Name = "PanelScroll"
        Me.PanelScroll.Size = New System.Drawing.Size(20, 227)
        Me.PanelScroll.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnLoad)
        Me.Panel1.Controls.Add(Me.btnStore)
        Me.Panel1.Controls.Add(Me.btnReset)
        Me.Panel1.Location = New System.Drawing.Point(0, 430)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1043, 41)
        Me.Panel1.TabIndex = 2
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(718, 3)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(227, 33)
        Me.btnLoad.TabIndex = 3
        Me.btnLoad.Text = "Load from text file"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'btnStore
        '
        Me.btnStore.Location = New System.Drawing.Point(408, 3)
        Me.btnStore.Name = "btnStore"
        Me.btnStore.Size = New System.Drawing.Size(227, 33)
        Me.btnStore.TabIndex = 3
        Me.btnStore.Text = "Store to text file"
        Me.btnStore.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(100, 3)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(227, 33)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "Reset Statistics"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Statistics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1044, 471)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelScroll)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1060, 510)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1060, 510)
        Me.Name = "Statistics"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Statistics"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelScroll As System.Windows.Forms.VScrollBar
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents btnStore As System.Windows.Forms.Button
End Class
