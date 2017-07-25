Imports System
Imports System.IO

Public Class Puzzle

    Public btn(8) As Button
    Public Order(8) As Integer
    Public PosLeft(8) As Integer
    Public PosTop(8) As Integer
    Public Problem As problem
    Public Search As searchAlgorithm = New searchAlgorithm
    Public solution As LinkedList(Of node) = New LinkedList(Of node)
    Public searchType As String
    Public watch As Stopwatch
    Private tempState(8) As Integer
    Private appLogLine As String
    Private counter As Integer
    'Public solvability As Boolean


    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load 'creates buttons as the input array "initialization"
        Me.Left = 500
        Me.Top = 250

        Order = {0, 1, 2, 3, 4, 5, 6, 7, 8}
        For i = 0 To 8
            btn(Order(i)) = New System.Windows.Forms.Button()
            If (Order(i) <> 0) Then
                btn(Order(i)).Text = Order(i)
            End If

            btn(Order(i)).Width = 50
            btn(Order(i)).Height = 50
            btn(Order(i)).Visible = True
            btn(Order(i)).Left = 50 * (i Mod 3)
            PosLeft(Order(i)) = btn(Order(i)).Left

            btn(Order(i)).Top = Int(i / 3) * 50
            PosTop(Order(i)) = btn(Order(i)).Top

            AddHandler btn(Order(i)).Click, AddressOf btn_clicked
            Me.Controls.Add(btn(Order(i)))

        Next

        btn(0).Enabled = False

    End Sub

    Private Sub btn_clicked(ByVal sender As Object, ByVal e As EventArgs)
        Dim tempLeft, tempTop, location0, locationi As Integer
        Solve.Enabled = True
        For i = 1 To 8
            If sender Is btn(i) Then
                If (checkClick(i)) Then

                    Result.solutionTimer.Stop()
                    Result.nextButton.Enabled = False
                    Result.btnAutoSolve.Enabled = False

                    For c = 0 To 8
                        If Order(c) = 0 Then
                            location0 = c
                        End If
                        If Order(c) = i Then
                            locationi = c
                        End If
                    Next
                    Order(location0) = i
                    Order(locationi) = 0
                    '------------------------------
                    tempLeft = btn(i).Left
                    tempTop = btn(i).Top
                    '------------------------------
                    PosLeft(i) = btn(0).Left
                    PosTop(i) = btn(0).Top
                    btn(i).Left = PosLeft(i)
                    btn(i).Top = PosTop(i)
                    '------------------------------
                    PosLeft(0) = tempLeft
                    PosTop(0) = tempTop
                    btn(0).Left = tempLeft
                    btn(0).Top = tempTop
                End If
            End If
        Next
    End Sub

    Private Function checkClick(ByVal i As Integer) As Boolean
        If (PosLeft(i) = PosLeft(0) And Math.Abs(PosTop(i) - PosTop(0)) = 50) Then
            Return True
        ElseIf (PosTop(i) = PosTop(0) And Math.Abs(PosLeft(i) - PosLeft(0)) = 50) Then
            Return True
        End If
        Return False

        ' check the order more efficient
        ' can return the move

    End Function

    Public Sub reOrderButtons(ByVal s() As Integer)
        For i = 0 To 8
            Order(i) = s(i)
            btn(Order(i)).Left = 50 * (i Mod 3)
            PosLeft(Order(i)) = btn(Order(i)).Left
            btn(Order(i)).Top = Int(i / 3) * 50
            PosTop(Order(i)) = btn(Order(i)).Top
        Next
    End Sub

    Private Sub Solve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Solve.Click

        If (copyInitStateAndTestGoal()) Then
            MsgBox("They are already in order !!", MsgBoxStyle.OkOnly, "Are you Kidding ?!")
            GoTo X
        End If
        btnResolve.Enabled = True

        Problem = New problem(tempState)
        reOrderButtons(tempState)
        resetResultForm()
        solveProblem()


        My.Computer.Audio.Play(My.Resources.music_marimba_chord, AudioPlayMode.WaitToComplete)

        If Not (solution Is Nothing) Then
            printStats()
            showSolution()
        Else
            printNoSolutionStats()
            'MessageBox.Show("Algorithm Failure, No path was found..." & vbCrLf & "Invalid Input Order", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Result.Close()
        End If
X:
    End Sub

    Private Sub btnResolve_Click(sender As Object, e As EventArgs) Handles btnResolve.Click
        reOrderButtons(Problem.getInitialState)
        resetResultForm()
        solveProblem()

        My.Computer.Audio.Play(My.Resources.music_marimba_chord, AudioPlayMode.WaitToComplete)
        If solution.Count <> 0 Then
            printStats()
            showSolution()
        Else
            printNoSolutionStats()
            'MessageBox.Show("Algorithm Failure", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function copyInitStateAndTestGoal()
        Dim l As Boolean = True
        For i = 0 To 8
            tempState(i) = Order(i)
            If tempState(i) <> i Then
                l = False
            End If
        Next
        Return l
    End Function

    Private Sub showSolution()
        Dim newLine As String
        solution.RemoveFirst()
        printSolution(solution)
        newLine = searchType & "_" & solution.Count & "_" & Search.getSetCount & "_" & Search.getFrontierCount & "_" & Result.timeBox.Text
        appLogLine = newLine
        My.Settings.applog.Add(newLine)
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Sub resetResultForm()
        Result.nextButton.Enabled = True
        Result.SolList.Items.Clear()
        Result.stepsBox.Text = ""
        Result.frountierBox.Text = ""
        Result.eSetBox.Text = ""
        Result.timeBox.Text = ""
        Result.temp = 0
        'Result.Hide()
    End Sub

    Public Sub solveProblem()

        watch = Stopwatch.StartNew()
        If typeDFS.Checked Then
            solution = Search.DFS(Problem)
            searchType = "DFS"
        ElseIf typeBFS.Checked Then
            solution = Search.BFS(Problem)
            searchType = "BFS"
        ElseIf typeGBFS.Checked Then
            solution = Search.GBFS(Problem)
            searchType = "GBFS"
        ElseIf typeAstar.Checked Then
            solution = Search.Astar(Problem)
            searchType = "Astar"

        ElseIf typeR_DFS.Checked Then
            solution = Search.R_DFS(Problem)
            searchType = "RDFS"
        ElseIf typeR_BFS.Checked Then
            solution = Search.R_BFS(Problem)
            searchType = "RBFS"
        ElseIf typeR_GBFS.Checked Then
            solution = Search.R_GBFS(Problem)
            searchType = "RGBFS"
        ElseIf typeR_Astar.Checked Then
            solution = Search.R_Astar(Problem)
            searchType = "RAstar"
        End If
        watch.Stop()
    End Sub

    Public Sub printSolution(ByVal xSolution As LinkedList(Of node))
        Result.rSolution = xSolution
        Result.tempCount = solution.Count - 1
        Result.Show()
        Result.nextButton.PerformClick()
    End Sub

    Private Sub printStats()
        Dim min, sec, millis As Integer
        Result.eSetBox.Text = Search.getSetCount()
        Result.frountierBox.Text = Search.getFrontierCount()
        min = Math.Floor(watch.Elapsed.TotalMilliseconds / 60000)
        sec = (Math.Floor(watch.Elapsed.TotalMilliseconds / 1000)) Mod (60)
        millis = (watch.Elapsed.TotalMilliseconds) Mod (1000)
        Result.timeBox.Text = min & ":" & sec & ":" & millis
    End Sub

    Private Sub btnTryAll_Click(sender As Object, e As EventArgs) Handles btnTryAll.Click

        btnTryAll.Enabled = False
        If (copyInitStateAndTestGoal()) Then
            MsgBox("They are already in order !!", MsgBoxStyle.OkOnly, "Are you Kidding ?!")
            GoTo X
        End If
        ProgressBar1.Value = 0

        ComparisonForm.Close()
        ComparisonForm.resetDataLists()

        typeAstar.Checked = True
        Solve.PerformClick()
        If solution Is Nothing Then
            Timer1.Stop()
            btnTryAll.Enabled = True
            GoTo X
        End If
        ProgressBar1.Value = 12
        ComparisonForm.addline(appLogLine)
        ComparisonForm.setState(Problem.getInitialState)
        ComparisonForm.Show()

        counter = 0
        Timer1.Start()
X:

    End Sub

    Private Sub shStatistics_Click(sender As Object, e As EventArgs) Handles shStatistics.Click
        Statistics.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEnterOrder.Click
        EnterOrder.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        counter += 1
        solveCounter()
    End Sub

    Public Sub tic()
        Timer1_Tick(Timer1, Nothing)
    End Sub

    Private Sub solveCounter()

        If counter = 1 Then
            typeR_Astar.Checked = True
            btnResolve.PerformClick()
            ComparisonForm.addline(appLogLine)
            'Result.Close()
        ElseIf counter = 2 Then
            typeBFS.Checked = True
            btnResolve.PerformClick()
            ComparisonForm.addline(appLogLine)
            'Result.Close()
        ElseIf counter = 3 Then
            typeR_BFS.Checked = True
            btnResolve.PerformClick()
            ComparisonForm.addline(appLogLine)
            'Result.Close()
        ElseIf counter = 4 Then
            typeGBFS.Checked = True
            btnResolve.PerformClick()
            ComparisonForm.addline(appLogLine)
            'Result.Close()
        ElseIf counter = 5 Then
            typeR_GBFS.Checked = True
            btnResolve.PerformClick()
            ComparisonForm.addline(appLogLine)
            'Result.Close()
        ElseIf counter = 6 Then
            typeDFS.Checked = True
            btnResolve.PerformClick()
            ComparisonForm.addline(appLogLine)
            'Result.Close()
        ElseIf counter = 7 Then
            typeR_DFS.Checked = True
            btnResolve.PerformClick()
            ComparisonForm.addline(appLogLine)
            'Result.Close()
        Else
            Timer1.Stop()
            btnTryAll.Enabled = True
            ProgressBar1.Value = 99
            GoTo x
        End If
        ProgressBar1.Value += 12
x:

    End Sub

    Private Sub printNoSolutionStats()
        'Result.nextButton.Enabled = True
        Result.SolList.Items.Clear()
        Result.stepsBox.Text = "---"
        Result.frountierBox.Text = "0"
        Result.eSetBox.Text = Search.getSetCount
        Result.temp = 0
        'MsgBox(watch.ElapsedMilliseconds)
        Dim min = Math.Floor(watch.ElapsedMilliseconds / 60000)
        Dim sec = (Math.Floor(watch.ElapsedMilliseconds / 1000)) Mod 60
        Dim ms = watch.ElapsedMilliseconds Mod 1000
        Result.timeBox.Text = min & " : " & sec & " : " & ms

        Result.Show()
    End Sub

End Class
