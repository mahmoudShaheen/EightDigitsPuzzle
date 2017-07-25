<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComparisonForm
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
        Me.components = New System.ComponentModel.Container()
        Me.lstTime = New System.Windows.Forms.ListBox()
        Me.lstExplored = New System.Windows.Forms.ListBox()
        Me.lstFrontier = New System.Windows.Forms.ListBox()
        Me.lstType = New System.Windows.Forms.ListBox()
        Me.lstStep = New System.Windows.Forms.ListBox()
        Me.num = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstTime
        '
        Me.lstTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTime.FormattingEnabled = True
        Me.lstTime.ItemHeight = 20
        Me.lstTime.Location = New System.Drawing.Point(289, 31)
        Me.lstTime.Name = "lstTime"
        Me.lstTime.Size = New System.Drawing.Size(120, 164)
        Me.lstTime.TabIndex = 1
        '
        'lstExplored
        '
        Me.lstExplored.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstExplored.FormattingEnabled = True
        Me.lstExplored.ItemHeight = 20
        Me.lstExplored.Location = New System.Drawing.Point(415, 31)
        Me.lstExplored.Name = "lstExplored"
        Me.lstExplored.Size = New System.Drawing.Size(120, 164)
        Me.lstExplored.TabIndex = 2
        '
        'lstFrontier
        '
        Me.lstFrontier.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstFrontier.FormattingEnabled = True
        Me.lstFrontier.ItemHeight = 20
        Me.lstFrontier.Location = New System.Drawing.Point(541, 31)
        Me.lstFrontier.Name = "lstFrontier"
        Me.lstFrontier.Size = New System.Drawing.Size(120, 164)
        Me.lstFrontier.TabIndex = 3
        '
        'lstType
        '
        Me.lstType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstType.FormattingEnabled = True
        Me.lstType.ItemHeight = 20
        Me.lstType.Location = New System.Drawing.Point(37, 31)
        Me.lstType.Name = "lstType"
        Me.lstType.Size = New System.Drawing.Size(120, 164)
        Me.lstType.TabIndex = 4
        '
        'lstStep
        '
        Me.lstStep.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstStep.FormattingEnabled = True
        Me.lstStep.ItemHeight = 20
        Me.lstStep.Location = New System.Drawing.Point(163, 31)
        Me.lstStep.Name = "lstStep"
        Me.lstStep.Size = New System.Drawing.Size(120, 164)
        Me.lstStep.TabIndex = 5
        '
        'num
        '
        Me.num.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num.FormattingEnabled = True
        Me.num.ItemHeight = 20
        Me.num.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.num.Location = New System.Drawing.Point(12, 31)
        Me.num.Name = "num"
        Me.num.Size = New System.Drawing.Size(19, 164)
        Me.num.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Search Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(160, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Solution Steps"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(286, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Time"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(412, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Explored Nodes"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(538, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Frontier Nodes"
        '
        'Timer1
        '
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 198)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Initial State :"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.Location = New System.Drawing.Point(130, 198)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(57, 20)
        Me.lblState.TabIndex = 9
        Me.lblState.Text = "Label7"
        '
        'ComparisonForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 226)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.num)
        Me.Controls.Add(Me.lstStep)
        Me.Controls.Add(Me.lstType)
        Me.Controls.Add(Me.lstFrontier)
        Me.Controls.Add(Me.lstExplored)
        Me.Controls.Add(Me.lstTime)
        Me.Name = "ComparisonForm"
        Me.Text = "Comparison Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstTime As System.Windows.Forms.ListBox
    Friend WithEvents lstExplored As System.Windows.Forms.ListBox
    Friend WithEvents lstFrontier As System.Windows.Forms.ListBox
    Friend WithEvents lstType As System.Windows.Forms.ListBox
    Friend WithEvents lstStep As System.Windows.Forms.ListBox
    Friend WithEvents num As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblState As System.Windows.Forms.Label
End Class
