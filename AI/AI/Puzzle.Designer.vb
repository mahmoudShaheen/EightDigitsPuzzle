<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Puzzle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Puzzle))
        Me.Solve = New System.Windows.Forms.Button()
        Me.typeBFS = New System.Windows.Forms.RadioButton()
        Me.typeAstar = New System.Windows.Forms.RadioButton()
        Me.shStatistics = New System.Windows.Forms.Button()
        Me.btnResolve = New System.Windows.Forms.Button()
        Me.typeDFS = New System.Windows.Forms.RadioButton()
        Me.typeGBFS = New System.Windows.Forms.RadioButton()
        Me.typeR_DFS = New System.Windows.Forms.RadioButton()
        Me.typeR_BFS = New System.Windows.Forms.RadioButton()
        Me.typeR_GBFS = New System.Windows.Forms.RadioButton()
        Me.typeR_Astar = New System.Windows.Forms.RadioButton()
        Me.btnTryAll = New System.Windows.Forms.Button()
        Me.btnEnterOrder = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'Solve
        '
        Me.Solve.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Solve.Location = New System.Drawing.Point(163, 12)
        Me.Solve.Name = "Solve"
        Me.Solve.Size = New System.Drawing.Size(128, 35)
        Me.Solve.TabIndex = 0
        Me.Solve.Text = "Solve Current Order"
        Me.Solve.UseVisualStyleBackColor = True
        '
        'typeBFS
        '
        Me.typeBFS.AutoSize = True
        Me.typeBFS.Checked = True
        Me.typeBFS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.typeBFS.Location = New System.Drawing.Point(94, 156)
        Me.typeBFS.Name = "typeBFS"
        Me.typeBFS.Size = New System.Drawing.Size(55, 20)
        Me.typeBFS.TabIndex = 1
        Me.typeBFS.TabStop = True
        Me.typeBFS.Text = "BFS"
        Me.typeBFS.UseVisualStyleBackColor = True
        '
        'typeAstar
        '
        Me.typeAstar.AutoSize = True
        Me.typeAstar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.typeAstar.Location = New System.Drawing.Point(94, 182)
        Me.typeAstar.Name = "typeAstar"
        Me.typeAstar.Size = New System.Drawing.Size(42, 20)
        Me.typeAstar.TabIndex = 2
        Me.typeAstar.Text = "A*"
        Me.typeAstar.UseVisualStyleBackColor = True
        '
        'shStatistics
        '
        Me.shStatistics.Location = New System.Drawing.Point(163, 176)
        Me.shStatistics.Name = "shStatistics"
        Me.shStatistics.Size = New System.Drawing.Size(128, 35)
        Me.shStatistics.TabIndex = 3
        Me.shStatistics.Text = "Show Statistics"
        Me.shStatistics.UseVisualStyleBackColor = True
        '
        'btnResolve
        '
        Me.btnResolve.Enabled = False
        Me.btnResolve.Location = New System.Drawing.Point(163, 53)
        Me.btnResolve.Name = "btnResolve"
        Me.btnResolve.Size = New System.Drawing.Size(128, 35)
        Me.btnResolve.TabIndex = 5
        Me.btnResolve.Text = "Resolve Last Problem"
        Me.btnResolve.UseVisualStyleBackColor = True
        '
        'typeDFS
        '
        Me.typeDFS.AutoSize = True
        Me.typeDFS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.typeDFS.Location = New System.Drawing.Point(16, 156)
        Me.typeDFS.Name = "typeDFS"
        Me.typeDFS.Size = New System.Drawing.Size(56, 20)
        Me.typeDFS.TabIndex = 7
        Me.typeDFS.TabStop = True
        Me.typeDFS.Text = "DFS"
        Me.typeDFS.UseVisualStyleBackColor = True
        '
        'typeGBFS
        '
        Me.typeGBFS.AutoSize = True
        Me.typeGBFS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.typeGBFS.Location = New System.Drawing.Point(16, 182)
        Me.typeGBFS.Name = "typeGBFS"
        Me.typeGBFS.Size = New System.Drawing.Size(66, 20)
        Me.typeGBFS.TabIndex = 8
        Me.typeGBFS.TabStop = True
        Me.typeGBFS.Text = "GBFS"
        Me.typeGBFS.UseVisualStyleBackColor = True
        '
        'typeR_DFS
        '
        Me.typeR_DFS.AutoSize = True
        Me.typeR_DFS.Location = New System.Drawing.Point(16, 208)
        Me.typeR_DFS.Name = "typeR_DFS"
        Me.typeR_DFS.Size = New System.Drawing.Size(60, 17)
        Me.typeR_DFS.TabIndex = 10
        Me.typeR_DFS.TabStop = True
        Me.typeR_DFS.Text = "R_DFS"
        Me.typeR_DFS.UseVisualStyleBackColor = True
        '
        'typeR_BFS
        '
        Me.typeR_BFS.AutoSize = True
        Me.typeR_BFS.Location = New System.Drawing.Point(94, 208)
        Me.typeR_BFS.Name = "typeR_BFS"
        Me.typeR_BFS.Size = New System.Drawing.Size(59, 17)
        Me.typeR_BFS.TabIndex = 11
        Me.typeR_BFS.TabStop = True
        Me.typeR_BFS.Text = "R_BFS"
        Me.typeR_BFS.UseVisualStyleBackColor = True
        '
        'typeR_GBFS
        '
        Me.typeR_GBFS.AutoSize = True
        Me.typeR_GBFS.Location = New System.Drawing.Point(16, 231)
        Me.typeR_GBFS.Name = "typeR_GBFS"
        Me.typeR_GBFS.Size = New System.Drawing.Size(67, 17)
        Me.typeR_GBFS.TabIndex = 12
        Me.typeR_GBFS.TabStop = True
        Me.typeR_GBFS.Text = "R_GBFS"
        Me.typeR_GBFS.UseVisualStyleBackColor = True
        '
        'typeR_Astar
        '
        Me.typeR_Astar.AutoSize = True
        Me.typeR_Astar.Location = New System.Drawing.Point(94, 231)
        Me.typeR_Astar.Name = "typeR_Astar"
        Me.typeR_Astar.Size = New System.Drawing.Size(50, 17)
        Me.typeR_Astar.TabIndex = 13
        Me.typeR_Astar.TabStop = True
        Me.typeR_Astar.Text = "R_A*"
        Me.typeR_Astar.UseVisualStyleBackColor = True
        '
        'btnTryAll
        '
        Me.btnTryAll.Location = New System.Drawing.Point(163, 94)
        Me.btnTryAll.Name = "btnTryAll"
        Me.btnTryAll.Size = New System.Drawing.Size(128, 35)
        Me.btnTryAll.TabIndex = 14
        Me.btnTryAll.Text = "Try All"
        Me.btnTryAll.UseVisualStyleBackColor = True
        '
        'btnEnterOrder
        '
        Me.btnEnterOrder.Location = New System.Drawing.Point(163, 135)
        Me.btnEnterOrder.Name = "btnEnterOrder"
        Me.btnEnterOrder.Size = New System.Drawing.Size(128, 35)
        Me.btnEnterOrder.TabIndex = 15
        Me.btnEnterOrder.Text = "Enter Order"
        Me.btnEnterOrder.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 180000
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(163, 217)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(128, 31)
        Me.ProgressBar1.TabIndex = 16
        '
        'Puzzle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(303, 260)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnEnterOrder)
        Me.Controls.Add(Me.btnTryAll)
        Me.Controls.Add(Me.typeR_Astar)
        Me.Controls.Add(Me.typeR_GBFS)
        Me.Controls.Add(Me.typeR_BFS)
        Me.Controls.Add(Me.typeR_DFS)
        Me.Controls.Add(Me.typeGBFS)
        Me.Controls.Add(Me.typeDFS)
        Me.Controls.Add(Me.btnResolve)
        Me.Controls.Add(Me.shStatistics)
        Me.Controls.Add(Me.typeAstar)
        Me.Controls.Add(Me.typeBFS)
        Me.Controls.Add(Me.Solve)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Puzzle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Puzzle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Solve As System.Windows.Forms.Button
    Friend WithEvents typeBFS As System.Windows.Forms.RadioButton
    Friend WithEvents typeAstar As System.Windows.Forms.RadioButton
    Friend WithEvents shStatistics As System.Windows.Forms.Button
    Friend WithEvents btnResolve As System.Windows.Forms.Button
    Friend WithEvents typeDFS As System.Windows.Forms.RadioButton
    Friend WithEvents typeGBFS As System.Windows.Forms.RadioButton
    Friend WithEvents typeR_DFS As System.Windows.Forms.RadioButton
    Friend WithEvents typeR_BFS As System.Windows.Forms.RadioButton
    Friend WithEvents typeR_GBFS As System.Windows.Forms.RadioButton
    Friend WithEvents typeR_Astar As System.Windows.Forms.RadioButton
    Friend WithEvents btnTryAll As System.Windows.Forms.Button
    Friend WithEvents btnEnterOrder As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar

End Class
