Public Class ComparisonForm

    Private counter As Integer

    Private Sub AllSolResults_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Puzzle.btnTryAll.Enabled = True
        Puzzle.ProgressBar1.Value = 0
    End Sub

    Private Sub AllSolResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 300

    End Sub

    Public Sub addline(line As String)
        counter = 0
        Dim info() = line.Split("_")
        lstType.Items.Add(info(0))
        lstStep.Items.Add(info(1))
        lstTime.Items.Add(info(4))
        lstExplored.Items.Add(info(2))
        lstFrontier.Items.Add(info(3))
        Timer1.Start()
        My.Computer.Audio.Play(My.Resources.music_marimba_chord, AudioPlayMode.WaitToComplete)
    End Sub

    Public Sub resetDataLists()
        lstType.Items.Clear()
        lstStep.Items.Clear()
        lstTime.Items.Clear()
        lstExplored.Items.Clear()
        lstFrontier.Items.Clear()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        counter += 1
        If counter = 15 Then
            Timer1.Stop()
            Puzzle.Timer1.Start()
            Puzzle.tic()
        End If
    End Sub

    Public Sub setState(s() As Integer)
        lblState.Text = ""
        For i = 0 To 7
            lblState.Text = lblState.Text & s(i) & " , "
        Next
        lblState.Text = lblState.Text & s(8)
    End Sub

End Class