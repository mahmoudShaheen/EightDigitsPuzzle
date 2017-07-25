Public Class EnterOrder

    Private index As Integer
    Private leftPosition(8) As Integer
    Private TopPosition(8) As Integer
    Public sentOrder(8) As Integer
    Private clicked(8) As Boolean
    Private spaces() As Boolean

    Private Sub EnterOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        index = 0
        leftPosition = {12, 68, 124, 12, 68, 124, 12, 68, 124}
        TopPosition = {12, 12, 12, 68, 68, 68, 124, 124, 124}
        spaces = {True, True, True, True, True, True, True, True, True}
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        btnClick(btn0, 0)
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        btnClick(btn1, 1)
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        btnClick(btn2, 2)
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        btnClick(btn3, 3)
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        btnClick(btn4, 4)
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        btnClick(btn5, 5)
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        btnClick(btn6, 6)
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        btnClick(btn7, 7)
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        btnClick(btn8, 8)
    End Sub

    Private Sub btnClick(ByRef a As Button, i As Integer)
        If (clicked(i)) Then
            clicked(i) = False
            a.Left = 312 + (i Mod 3) * 56
            a.Top = 12 + 56 * Int(i / 3)
            spaces(Array.IndexOf(sentOrder, i)) = True
            index -= 1
        Else
            clicked(i) = True
            Dim c As Integer = getFirstSpace()
            sentOrder(c) = i
            spaces(c) = False
            a.Left = leftPosition(c)
            a.Top = TopPosition(c)
            index += 1
        End If
    End Sub

    Private Function getFirstSpace()
        For i = 0 To 8
            If (spaces(i)) Then
                Return i
            End If
        Next
        Return -1
    End Function

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        If index = 9 Then
            'checkSolvable()
            Puzzle.reOrderButtons(sentOrder)
            Me.Close()
        Else
            MsgBox("All buttons must be put... ")
        End If
    End Sub

    Private Sub checkSolvable()

        Dim s(8) As Integer
        For i = 0 To 8
            s(i) = sentOrder(i)
        Next

        Dim r As Integer = 0
        Dim temp As Integer
        Dim TempIndex As Integer

        For i = 0 To 7
            If s(i) <> (i + 1) Then
                temp = s(i)
                TempIndex = Array.IndexOf(s, i + 1)
                s(i) = i + 1
                s(TempIndex) = temp
                r += 1
            End If
        Next

        TempIndex = Array.IndexOf(s, 0)
        r += (Int(TempIndex / 3) + (TempIndex Mod 3))

        If (r Mod 2 = 1) Then
            MsgBox("Not Solvable")
        Else
            MsgBox("Solvable")
        End If

    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        If index = 9 Then
            'checkSolvable()
            checkSolvable2()
        End If
    End Sub

    Public Sub checkSolvable2()
        Dim v As Integer = 0

        For i = 0 To 7
            If (sentOrder(i) <> 0) Then
                For j = i + 1 To 8
                    If (sentOrder(i) > sentOrder(j)) And (sentOrder(j) <> 0) Then
                        v += 1
                    End If
                Next
            End If
        Next

        If (v Mod 2 = 1) Then
            MsgBox("Not Solvable")
        Else
            MsgBox("Solvable")
        End If

    End Sub
End Class