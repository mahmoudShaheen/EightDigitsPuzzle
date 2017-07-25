''FIFO Frontier'' 
Public Class FIFOfrontier
    Private f As Queue(Of node) = New Queue(Of node)
    Private extra As List(Of Integer) = New List(Of Integer)

    Public Sub insert(ByVal x As node) 'add node to the frontier'
        f.Enqueue(x)
        addState(x.getState)
    End Sub

    Private Sub addState(s() As Integer)

        Dim state As Integer = 0
        For c = 0 To 8
            state *= 10
            state += s(c)
        Next
        If (extra.Count = 0) Then
            extra.Insert(0, state)
            GoTo l
        End If
        Dim i = binSearch(0, extra.Count - 1, state)
        If (extra(i) > state) Then
            extra.Insert(i, state)
        Else
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

    Public Function pop() 'return the first node in the frontier'
        If (f.Count() > 0) Then
            Return f.Dequeue()
        Else
            Return (-1)
        End If
    End Function

    Public Function empty() 'is the frontier empty?'
        If (f.Count() = 0) Then
            Return (True)
        Else
            Return (False)
        End If
    End Function

    Public Function isHere(ByVal x As node) 'is the Node already in the frontier?'
        'Return f.Contains(x)
        Dim s = x.getState()
        Dim state As Integer = 0
        For c = 0 To 8
            state *= 10
            state += s(c)
        Next
        Dim i = binSearch(0, extra.Count - 1, state)
        If (extra(i) = state) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function getCount()
        Return f.Count
    End Function
End Class
