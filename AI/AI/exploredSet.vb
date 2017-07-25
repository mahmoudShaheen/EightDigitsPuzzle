Public Class exploredSet
    Private extra As List(Of Integer) = New List(Of Integer)

    Public Sub insert(ByVal x As node) 'add Node to the exploredSet'
        addState(x.getState)
    End Sub

    Public Function isHere(ByVal x As node) 'is the Node already in the exploredSet?'
        Dim s = x.getState()
        Dim state As Integer = 0
        For c = 0 To 8
            state *= 10
            state += s(c)
        Next

        'Selection
        'Return extra.Contains(state)

        'Binary Search
        Dim i = binSearch(0, extra.Count - 1, state)
        If (extra(i) = state) Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Sub addState(s() As Integer)

        Dim state As Integer = 0
        For c = 0 To 8
            state *= 10
            state += s(c)
        Next
        If (extra.Count = 0) Then
            extra.Insert(0, state)
            GoTo l
        End If
        ' selection
        'For r = 0 To extra.Count - 1
        '    If state < extra(r) Then
        '        extra.Insert(r, state)
        '        GoTo l
        '    End If
        'Next
        ' binary
        Dim i = binSearch(0, extra.Count - 1, state)
        If (extra(i) > state) Then
            extra.Insert(i, state)
        ElseIf (extra(i) < state) Then
            extra.Insert(i + 1, state)

        End If

l:
    End Sub
    Private Function binSearch(s As Integer, e As Integer, state As Integer)

        If (s >= e) Then
            Return s
        End If
        Dim i = Int((s + e) / 2)
        If (extra(i) = state) Then
            Return i
        ElseIf (extra(i) > state) Then
            Return binSearch(s, i - 1, state)
        Else
            Return binSearch(i + 1, e, state)
        End If

    End Function

    Public Function count()
        Return extra.Count
    End Function

    Public Sub clear()
        extra.Clear()
    End Sub
End Class
