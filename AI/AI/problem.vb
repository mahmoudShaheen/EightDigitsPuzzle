Public Class problem
    Private initialState(8) As Integer
    Private goal(8) As Integer

    Public Sub New(ByVal rState() As Integer) 'intialize the goal and initial state
        For i = 0 To 8
            initialState(i) = rState(i)
        Next

        For i = 0 To 8
            goal(i) = i
        Next

    End Sub

    Public Function actions(ByVal rNode As node) 'returns available actions
        Dim actionList(3) As Boolean
        'Up     -> 0
        'Down   -> 1
        'Right  -> 2
        'Left   -> 3
        For i = 0 To 3
            actionList(i) = available(rNode, i)
        Next
        Return actionList
    End Function

    Public Function goalTest(ByVal rNode As node) 'returns if the current node's state is the goal
        Dim nodeState(8) As Integer
        nodeState = rNode.getState()
        For i = 0 To 8
            If (goal(i) <> nodeState(i)) Then
                Return False
            End If
        Next

        Return True
    End Function

    Private Function available(ByVal rNode As node, ByVal rAction As Integer) 'Tests if an action is available or not and returns T/F
        Dim index As Integer
        index = Array.IndexOf(rNode.getState(), 0)
        Select Case rAction
            Case 0 'Up
                If (index > 2) Then
                    Return True
                End If
            Case 1 'Down
                If (index < 6) Then
                    Return True
                End If
            Case 2 'Right
                If (((index + 1) Mod 3) <> 0) Then
                    Return True
                End If
            Case 3 'Left
                If ((index Mod 3) <> 0) Then
                    Return True
                End If
            Case Else
                Return False
        End Select
        Return False
    End Function

    Public Function getInitialState() 'get initial state
        Return initialState
    End Function

    Public Function newActions(ByVal rNode As node) 'returns available actions
        Dim actionList As List(Of Integer) = New List(Of Integer)
        'Up     -> 0
        'Down   -> 1
        'Right  -> 2
        'Left   -> 3
        For i = 0 To 3
            If available(rNode, i) Then
                actionList.Add(i)
            End If
        Next
        Return actionList
    End Function

End Class
