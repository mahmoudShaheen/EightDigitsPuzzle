<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Result
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Result))
        Me.SolList = New System.Windows.Forms.ListBox()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.nextButton = New System.Windows.Forms.Button()
        Me.timeBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.eSetBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.stepsBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.frountierBox = New System.Windows.Forms.TextBox()
        Me.solutionTimer = New System.Windows.Forms.Timer(Me.components)
        Me.btnAutoSolve = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SolList
        '
        Me.SolList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SolList.FormattingEnabled = True
        Me.SolList.Location = New System.Drawing.Point(12, 28)
        Me.SolList.Name = "SolList"
        Me.SolList.Size = New System.Drawing.Size(192, 316)
        Me.SolList.TabIndex = 0
        '
        'exitButton
        '
        Me.exitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitButton.Location = New System.Drawing.Point(215, 316)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(181, 28)
        Me.exitButton.TabIndex = 3
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'nextButton
        '
        Me.nextButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nextButton.Location = New System.Drawing.Point(318, 254)
        Me.nextButton.Name = "nextButton"
        Me.nextButton.Size = New System.Drawing.Size(78, 56)
        Me.nextButton.TabIndex = 5
        Me.nextButton.Text = "Next Step"
        Me.nextButton.UseVisualStyleBackColor = True
        '
        'timeBox
        '
        Me.timeBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeBox.Location = New System.Drawing.Point(215, 63)
        Me.timeBox.Name = "timeBox"
        Me.timeBox.ReadOnly = True
        Me.timeBox.Size = New System.Drawing.Size(181, 22)
        Me.timeBox.TabIndex = 6
        Me.timeBox.Text = "wait..."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(212, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Elapsed Time"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(210, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Explored Set"
        '
        'eSetBox
        '
        Me.eSetBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eSetBox.Location = New System.Drawing.Point(215, 171)
        Me.eSetBox.Name = "eSetBox"
        Me.eSetBox.ReadOnly = True
        Me.eSetBox.Size = New System.Drawing.Size(181, 22)
        Me.eSetBox.TabIndex = 9
        Me.eSetBox.Text = "wait..."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(212, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Steps"
        '
        'stepsBox
        '
        Me.stepsBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stepsBox.Location = New System.Drawing.Point(215, 226)
        Me.stepsBox.Name = "stepsBox"
        Me.stepsBox.ReadOnly = True
        Me.stepsBox.Size = New System.Drawing.Size(181, 22)
        Me.stepsBox.TabIndex = 11
        Me.stepsBox.Text = "wait..."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Solution Steps List"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(212, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "min : sec : ms"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(210, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Frountier"
        '
        'frountierBox
        '
        Me.frountierBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frountierBox.Location = New System.Drawing.Point(213, 115)
        Me.frountierBox.Name = "frountierBox"
        Me.frountierBox.ReadOnly = True
        Me.frountierBox.Size = New System.Drawing.Size(183, 22)
        Me.frountierBox.TabIndex = 9
        Me.frountierBox.Text = "wait..."
        '
        'solutionTimer
        '
        Me.solutionTimer.Interval = 250
        '
        'btnAutoSolve
        '
        Me.btnAutoSolve.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAutoSolve.Location = New System.Drawing.Point(215, 254)
        Me.btnAutoSolve.Name = "btnAutoSolve"
        Me.btnAutoSolve.Size = New System.Drawing.Size(78, 56)
        Me.btnAutoSolve.TabIndex = 12
        Me.btnAutoSolve.Text = "Auto Solve"
        Me.btnAutoSolve.UseVisualStyleBackColor = True
        '
        'Result
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 355)
        Me.Controls.Add(Me.btnAutoSolve)
        Me.Controls.Add(Me.stepsBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.frountierBox)
        Me.Controls.Add(Me.eSetBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.timeBox)
        Me.Controls.Add(Me.nextButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.SolList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Result"
        Me.Text = "Result"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SolList As System.Windows.Forms.ListBox
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents nextButton As System.Windows.Forms.Button
    Friend WithEvents timeBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents eSetBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents stepsBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents frountierBox As System.Windows.Forms.TextBox
    Friend WithEvents solutionTimer As System.Windows.Forms.Timer
    Friend WithEvents btnAutoSolve As System.Windows.Forms.Button
End Class
