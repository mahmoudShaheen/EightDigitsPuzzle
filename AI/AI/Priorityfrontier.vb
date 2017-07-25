Public Class Priorityfrontier
    Private f As List(Of node) = New List(Of node)
    Private extra As List(Of Integer) = New List(Of Integer)


    'Private indeces As List(Of Integer) = New List(Of Integer)

    Public Sub insert(ByVal x As node) 'add node to the frontier and sort it'


        Dim ind As Integer
        If f.Count = 0 Then
            f.Insert(0, x)
            'addState(x.getState())
            'maxN = x
        Else
            'If (maxN.getFofn < x.getFofn) Then
            '    maxN = x
            'End If
            ind = getIndex(x.getFofn())
            f.Insert(ind, x)
            'Dim state As Integer
            'Dim s = x.getState
            'For c = 0 To 8
            '    state *= 10
            '    state += s(c)
            'Next
            'Dim i = extrabinSearch(0, extra.Count - 1, state)
            'If (extra(i) <> state) Then
            '    addState(x.getState())
            'End If
        End If

        addState(x.getState())
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

        Dim i = extrabinSearch(0, extra.Count - 1, state)
        If (extra(i) > state) Then
            extra.Insert(i, state)
        ElseIf (extra(i) < state) Then
            extra.Insert(i + 1, state)
        Else
            'state = state
        End If
l:
    End Sub

    Private Function getIndex(s As Integer)
        s += 1
        Dim l = f.Count - 1
        Return (binSearch(0, l, s))
    End Function

    Private Function binSearch(s As Integer, e As Integer, cost As Integer)

        If s = e Then
            If f(s).getFofn < cost Then
                Return s + 1
            End If
            Return s
        End If

        Dim i As Integer = Int((e + s) / 2)

        If f(i).getFofn < cost Then
            If (i = e) Then
                Return i
            End If
            Return binSearch(i + 1, e, cost)
        ElseIf f(i).getFofn > cost Then
            If i = 0 Then
                Return 0
            End If
            Return binSearch(s, i - 1, cost)
        End If

        While f(i).getFofn = cost
            i -= 1
            If i <= 0 Then
                GoTo N
            End If
        End While
N:
        Return (i + 1)

    End Function

    Private Function extrabinSearch(s As Integer, e As Integer, state As Integer)

        If (s >= e) Then
            Return s
        End If
        Dim i = Int((s + e) / 2) ' s+e-.01

        If (extra(i) = state) Then
            Return i
        ElseIf (extra(i) > state) Then
            Return extrabinSearch(s, i - 1, state)
        Else
            Return extrabinSearch(i + 1, e, state)
        End If

    End Function

    Public Function pop() 'return the first node in the frontier'
        If (f.Count() > 0) Then
            Dim temp As node
            temp = f(0)

            Dim state As Integer
            Dim s = temp.getState
            If Not (testEquality(s, temp.getState)) Then
                MsgBox("not equal")
            End If
            For c = 0 To 8
                state *= 10
                state += s(c)
            Next
            Dim i = extrabinSearch(0, extra.Count - 1, state)
            If (extra.Count <> 0) Then
                extra.RemoveAt(i)
            End If
            'If (extra.Contains(state)) Then
            '    state = state
            '    'MsgBox("Error")
            'End If

            f.RemoveAt(0)
            Return temp
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

        'Dim r1 = f.Contains(x)
        If extra.Count = 0 Then
            Return False
        End If

        Dim s = x.getState()
        Dim state As Integer = 0
        For c = 0 To 8
            state *= 10
            state += s(c)
        Next
        Dim i = extrabinSearch(0, extra.Count - 1, state)
        If (extra(i) = state) Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Sub replace(ByVal NewNode As node)
        insert(NewNode)
    End Sub

    Public Function getCount()
        Return extra.Count()
    End Function

    Private Function testEquality(a() As Integer, b() As Integer)
        For i = 0 To 8
            If a(i) <> b(i) Then
                Return False
            End If
        Next
        Return True
    End Function

End Class

'Private Function found(s As Integer, e As Integer, x As Integer)

'    Dim i = Int((s + e) / 2)
'    Dim temp = f(i).getFofn

'    If (e = s) Then
'        If (temp = x) Then
'            Return s
'        Else
'            Return -1
'        End If
'    End If

'    If (temp = x) Then
'        Return i
'    ElseIf (temp < x) Then
'        Return found(i + 1, e, x)
'    Else
'        Return found(s, i - 1, x)
'    End If

'    Return -1

'End Function