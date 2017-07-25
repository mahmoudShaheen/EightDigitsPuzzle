Imports System
Imports System.IO

Public Class Statistics

    Public BFS As SearchStatistics
    Public DFS As SearchStatistics
    Public GBFS As SearchStatistics
    Public Astar As SearchStatistics

    Public StepContainer As Panel

    Private Sub Statistics_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DFS = New SearchStatistics("DFS", 1)
        BFS = New SearchStatistics("BFS", 2)
        GBFS = New SearchStatistics("GBFS", 3)
        Astar = New SearchStatistics("Astar", 4)

        My.Settings.Reload()

        PanelScroll.Height = Me.Height - 80 - 45
        PanelScroll.Left = 50 + 10 + 230 + 230 + 230 + 230 + 40
        PanelScroll.Top = 45


        Dim Steps(32) As Label
        Dim DataWidth = 50
        Dim DataHeight = 15
        Dim TitleHeight = 25

        Dim ExtraContainer = New System.Windows.Forms.Panel()
        ExtraContainer.Width = DataWidth + 20
        ExtraContainer.Height = 10 + 25 + 10 + 15 + 10
        ExtraContainer.Left = 0
        ExtraContainer.Top = 0
        Me.Controls.Add(ExtraContainer)

        'Dim ResetBtn = New System.Windows.Forms.Button
        'ResetBtn.Text = "Reset"
        'ResetBtn.Height = 25
        'ResetBtn.Width = 100
        'ResetBtn.Parent = ExtraContainer
        'ResetBtn.Top = 10
        'ResetBtn.Left = 10
        'AddHandler ResetBtn.Click, AddressOf ResetBtn_clicked
        'ExtraContainer.Controls.Add(ResetBtn)


        StepContainer = New System.Windows.Forms.Panel
        StepContainer.Height = 32 * 25 + 25 + 10 + 10
        StepContainer.Width = DataWidth + 10
        StepContainer.Left = 0
        StepContainer.Top = 0
        Me.Controls.Add(StepContainer)


        For i = 1 To 32
            Steps(i) = New System.Windows.Forms.Label()
            Steps(i).Parent = StepContainer
            Steps(i).Width = DataWidth
            Steps(i).Height = DataHeight
            Steps(i).Top = 10 + TitleHeight + 10 * (i + 1) + i * DataHeight
            Steps(i).Left = 10
            Steps(i).Text = i
            Steps(i).BorderStyle = BorderStyle.FixedSingle
            Steps(i).TextAlign = ContentAlignment.MiddleCenter
            StepContainer.Controls.Add(Steps(i))
        Next

        Steps(0) = New System.Windows.Forms.Label()
        Steps(0).Parent = ExtraContainer
        Steps(0).Width = DataWidth
        Steps(0).Height = DataHeight
        Steps(0).Top = 45
        Steps(0).Left = 10
        Steps(0).Text = "Steps"
        Steps(0).BorderStyle = BorderStyle.FixedSingle
        Steps(0).TextAlign = ContentAlignment.MiddleCenter
        ExtraContainer.Controls.Add(Steps(0))


        Dim info() As String

        For Each line In My.Settings.applog
            info = line.Split("_")
            If (info(0) = "BFS") Then
                BFS.editData(line)
            ElseIf (info(0) = "Astar") Then
                Astar.editData(line)
            ElseIf (info(0) = "DFS") And Int(info(1)) < 31 Then
                DFS.editData(line)
            ElseIf (info(0) = "GBFS") And Int(info(1)) < 31 Then
                GBFS.editData(line)
            End If
        Next

        'If File.Exists(path) Then
        '    Using sr As New StreamReader(path)

        '        While Not sr.EndOfStream
        '            line = sr.ReadLine()
        '            info = line.Split("_")
        '            If (info(0) = "BFS") Then
        '                BFS.editData(info)
        '            ElseIf (info(0) = "Astar") Then
        '                Astar.editData(info)
        '            End If
        '        End While

        '    End Using
        'End If

    End Sub

    Private Sub PanelScroll_Scroll(sender As Object, e As ScrollEventArgs) Handles PanelScroll.Scroll

        BFS.container.Top = -3 * PanelScroll.Value
        Astar.container.Top = -3 * PanelScroll.Value
        StepContainer.Top = -3 * PanelScroll.Value
        DFS.container.Top = -3 * PanelScroll.Value
        GBFS.container.Top = -3 * PanelScroll.Value

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Dim x = MsgBox("Are you sure you want to reset data ?!", MsgBoxStyle.OkCancel, "Confirm Action")
        If x = MsgBoxResult.Ok Then
            My.Settings.applog.Clear()
            My.Settings.Save()
            Me.Close()
        End If
    End Sub

    Private Sub btnStore_Click(sender As Object, e As EventArgs) Handles btnStore.Click

        Dim path = Directory.GetCurrentDirectory & "/Statistics.txt"

        If (File.Exists(path)) Then
            File.Delete(path)
        End If

        Using sw As StreamWriter = File.AppendText(path)
            For Each line In My.Settings.applog
                sw.WriteLine(line)
            Next
            sw.WriteLine("==================================")
            sw.WriteLine(DateString & "  " & TimeOfDay)
            sw.WriteLine("==================================")
        End Using
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click

        Dim path = Directory.GetCurrentDirectory & "/Statistics.txt"
        Dim line As String
        If File.Exists(path) Then
            My.Settings.applog.Clear()
            My.Settings.Save()
            Using sr As New StreamReader(path)
                While Not sr.EndOfStream
                    line = sr.ReadLine()
                    If line.Contains("=") Then
                        GoTo L
                    End If
                    My.Settings.applog.Add(line)
                End While
L:
                My.Settings.Save()
            End Using
        Else
            MsgBox("No 'Statistics.txt' file was found at current directory", MsgBoxStyle.OkOnly, "Warning")
        End If

        Me.Close()
        Puzzle.shStatistics.PerformClick()

    End Sub
End Class

Public Class SearchStatistics

    Public container As Panel
    Private DataLabels(32, 2) As Label
    Private DataWidth = 50
    Private DataHeight = 15

    Public TitleContainer As Panel
    Private Title As Label
    Private Titles(3) As Label
    Private TitleWidth = 3 * DataWidth + 20 + 50
    Private ContainerWidth = TitleWidth + 20
    Private TitleHeight = 25

    Private RepLables(32) As Label
    Private rep(32) As Integer

    Public Sub New(searchType As String, x As Integer)

        TitleContainer = New System.Windows.Forms.Panel()
        TitleContainer.Width = ContainerWidth
        TitleContainer.Height = 10 + 25 + 10 + 15 + 10
        TitleContainer.Left = 10 + (x - 1) * ContainerWidth + DataWidth
        TitleContainer.Top = 0
        Statistics.Controls.Add(TitleContainer)

        Title = New System.Windows.Forms.Label()
        Title.Width = TitleWidth
        Title.Height = TitleHeight
        Title.Parent = container
        Title.Left = 10
        Title.Top = 10
        Title.Text = searchType
        Title.BorderStyle = BorderStyle.FixedSingle
        Title.TextAlign = ContentAlignment.MiddleCenter
        TitleContainer.Controls.Add(Title)

        Titles(0) = New System.Windows.Forms.Label
        Titles(0).Width = 40
        Titles(0).Height = DataHeight
        Titles(0).Parent = TitleContainer
        Titles(0).Left = 10
        Titles(0).Top = 45
        Titles(0).BorderStyle = BorderStyle.FixedSingle
        TitleContainer.Controls.Add(Titles(0))

        For i = 1 To 3
            Titles(i) = New System.Windows.Forms.Label
            Titles(i).Width = DataWidth
            Titles(i).Height = DataHeight
            Titles(i).Parent = TitleContainer
            Titles(i).Left = 60 + (i - 1) * (DataWidth + 10)
            Titles(i).Top = 45
            Titles(i).TextAlign = ContentAlignment.MiddleCenter
            Titles(i).BorderStyle = BorderStyle.FixedSingle
            TitleContainer.Controls.Add(Titles(0))
        Next

        Titles(0).Text = "#"
        Titles(1).Text = "m:s:ms"
        Titles(2).Text = "Explored"
        Titles(3).Text = "Frontier"


        container = New System.Windows.Forms.Panel()
        container.Width = ContainerWidth
        container.Height = 32 * 25 + 25 + 10 + 10
        container.Left = 10 + (x - 1) * ContainerWidth + DataWidth
        container.Top = 0
        'container.BackColor = Color.Black
        Statistics.Controls.Add(container)

        

        For i = 1 To 32
            RepLables(i) = New System.Windows.Forms.Label()
            RepLables(i).Parent = container
            RepLables(i).Width = 40
            RepLables(i).Height = DataHeight
            RepLables(i).Top = 10 + TitleHeight + 10 * (i + 1) + i * DataHeight
            RepLables(i).Left = 10
            RepLables(i).Text = 0
            RepLables(i).BorderStyle = BorderStyle.FixedSingle
            RepLables(i).TextAlign = ContentAlignment.MiddleCenter
            container.Controls.Add(RepLables(i))
            rep(i) = 1
        Next

        For i = 1 To 32
            For j = 0 To 2
                DataLabels(i, j) = New System.Windows.Forms.Label()
                DataLabels(i, j).Parent = container
                DataLabels(i, j).Width = DataWidth
                DataLabels(i, j).Height = DataHeight
                DataLabels(i, j).Top = 10 + TitleHeight + 10 * (i + 1) + i * DataHeight
                DataLabels(i, j).Left = 60 + j * (DataWidth + 10)
                DataLabels(i, j).Text = 0
                DataLabels(i, j).BorderStyle = BorderStyle.FixedSingle
                DataLabels(i, j).TextAlign = ContentAlignment.MiddleCenter
                container.Controls.Add(DataLabels(i, j))
            Next
        Next

        

    End Sub

    Public Sub editData(line As String)

        Try
            Dim info() As String = line.Split("_")
            Dim stepindex As Integer = info(1)
            If (stepindex <> 0) Then
                Dim oldVal, newVal As String

                oldVal = DataLabels(stepindex, 0).Text
                If oldVal = "0" Then
                    'time   Explored    frontier
                    DataLabels(stepindex, 0).Text = info(4)
                    DataLabels(stepindex, 1).Text = info(2)
                    DataLabels(stepindex, 2).Text = info(3)
                Else
                    'time   Explored    frontier
                    rep(stepindex) += 1
                    newVal = info(4)
                    DataLabels(stepindex, 0).Text = getAverageTime(oldVal, newVal, rep(stepindex))
                    newVal = info(2)
                    oldVal = DataLabels(stepindex, 1).Text
                    DataLabels(stepindex, 1).Text = Int(Int(oldVal) * (rep(stepindex) - 1) / rep(stepindex) + Int(newVal) / rep(stepindex))
                    newVal = info(3)
                    oldVal = DataLabels(stepindex, 2).Text
                    DataLabels(stepindex, 2).Text = Int(Int(oldVal) * (rep(stepindex) - 1) / rep(stepindex) + Int(newVal) / rep(stepindex))

                End If
                RepLables(stepindex).Text = rep(stepindex)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & vbCrLf & "The following line does not match the data form" & vbCrLf & line)
        End Try


    End Sub

    Private Function getAverageTime(old As String, current As String, i As Single)
        Dim OldTime() = old.Split(":")
        Dim NewTime() = current.Split(":")

        Dim ot As Single = OldTime(0) * 60000 + OldTime(1) * 1000 + OldTime(2)
        Dim nt As Single = NewTime(0) * 60000 + NewTime(1) * 1000 + NewTime(2)

        nt = (ot * (i - 1) + nt) / i

        Dim m As Integer = Int(nt / 60000)
        Dim s As Integer = Int(nt / 1000) Mod 60
        Dim ms As Integer = Int(nt) Mod 1000

        Dim res As String
        res = m & ":" & s & ":" & ms

        Return res

    End Function
End Class