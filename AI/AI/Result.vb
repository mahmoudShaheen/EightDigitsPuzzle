Public Class Result
    Public rSolution As LinkedList(Of node)
    Public temp As Integer
    Public tempCount As Integer

    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Environment.Exit(0)
    End Sub

    Private Sub printOne()
        Dim tempNode As node
        Dim linkedListNode As LinkedListNode(Of node)
        Dim tempState(8) As Integer
        Dim tempStr As String
        linkedListNode = rSolution.First

        If Not (linkedListNode Is Nothing) Then

            tempNode = linkedListNode.Value
            rSolution.RemoveFirst()
            tempState = tempNode.getState()
            tempStr = String.Join(", ", tempState.Select(Function(x) x.ToString()).ToArray())
            SolList.Items.Add(temp & ") " & tempStr)
            For i = 0 To 8
                If tempState(i) <> Puzzle.Order(i) And (Puzzle.Order(i) <> 0) Then
                    Puzzle.btn(Puzzle.Order(i)).PerformClick()
                    If (btnAutoSolve.Text = "Pause") Then
                        solutionTimer.Start()
                    End If
                End If
            Next

        End If
        btnAutoSolve.Enabled = True
        If rSolution.Count = 0 Then
            solutionTimer.Stop()
            btnAutoSolve.Text = "Auto Solve"
            solutionTimer.Stop()
            nextButton.Enabled = True
            MsgBox("Solved !! :D")
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Statistics.Show()
    End Sub

    Private Sub nextButton_Click(sender As Object, e As EventArgs) Handles nextButton.Click
        If rSolution Is Nothing Then
            GoTo ee
        End If
        printOne()
        stepsBox.Text = temp & " / " & tempCount
        If (temp < tempCount) Then
            temp = temp + 1
        End If
        nextButton.Enabled = True
ee:
    End Sub

    Private Sub solutionTimer_Tick(sender As Object, e As EventArgs) Handles solutionTimer.Tick

        printOne()
        stepsBox.Text = temp & " / " & tempCount
        If (temp < tempCount) Then
            temp = temp + 1
        End If


    End Sub

    Private Sub btnAutoSolve_Click(sender As Object, e As EventArgs) Handles btnAutoSolve.Click
        If (rSolution Is Nothing) Then
            GoTo ee
        End If
        If (tempCount > 100) Then
            solutionTimer.Interval = 10
        Else
            solutionTimer.Interval = 100
        End If

        If (btnAutoSolve.Text = "Pause") Then
            btnAutoSolve.Text = "Auto Solve"
            solutionTimer.Stop()
            nextButton.Enabled = True
        Else
            btnAutoSolve.Text = "Pause"
            solutionTimer.Start()
            nextButton.Enabled = False
        End If
ee:
    End Sub

    Private Sub Result_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Left = 0
        Me.Top = 250

    End Sub
End Class