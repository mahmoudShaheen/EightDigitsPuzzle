Public Class node

    Private state(8) As Integer
    Private parent As node
    Private action As Integer
    ' ==============================
    Private Hofn As Integer
    Private Gofn As Integer
    Private Fofn As Integer

    Public Sub New(ByVal rState() As Integer, ByRef rParent As node, ByVal rAction As Integer, ByRef rGofn As Integer) 'Constructor
        state = rState
        parent = rParent
        action = rAction
        If Puzzle.typeAstar.Checked Or Puzzle.typeR_Astar.Checked Then
            Gofn = rGofn + 1
            Hofn = calculateHofn(state)
            Fofn = Gofn + Hofn
        ElseIf Puzzle.typeGBFS.Checked Or Puzzle.typeR_GBFS.Checked Then
            Hofn = calculateHofn(state)
            Fofn = Hofn
        End If
    End Sub

    Public Function getState() 'returns the current state
        Return state
    End Function

    Public Function childNode(ByVal rAction As Integer) 'Creates a new child node based on the action #no action check here
        Dim childState(8) As Integer
        Dim index As Integer
        For i = 0 To 8
            childState(i) = state(i)
        Next

        index = Array.IndexOf(childState, 0)
        Select Case rAction
            Case 0 'Up
                childState(index) = childState(index - 3)
                childState(index - 3) = 0
            Case 1 'Down
                childState(index) = childState(index + 3)
                childState(index + 3) = 0
            Case 2 'Right
                childState(index) = childState(index + 1)
                childState(index + 1) = 0
            Case 3 'Left
                childState(index) = childState(index - 1)
                childState(index - 1) = 0
            Case Else
                Return False
        End Select
        Dim newNode As node = New node(childState, Me, rAction, Me.Gofn)
        Return (newNode)
    End Function

    Public Function getSolution() 'returns solution as linked list of nodes

        Dim solution As LinkedList(Of node) = New LinkedList(Of node)
        Dim tempNode As node
        Dim linkedListNode As LinkedListNode(Of node)
        solution.AddFirst(Me)
        Do
            linkedListNode = solution.First
            tempNode = linkedListNode.Value
            tempNode = recSolution(tempNode)
            solution.AddFirst(tempNode)
        Loop Until linkedListNode.Value.parent Is Nothing
        Return (solution)

    End Function

    Private Function recSolution(ByVal rNode As node) 'returns the recived node's father
        Return rNode.parent
    End Function

    Public Function getParent()
        Return parent
    End Function

    Private Function calculateHofn(ByVal s() As Integer)
        Dim H As Integer = 0
        Dim R, C As Integer
        ' function definition
        For i = 0 To 8
            If (s(i) <> 0) Then
                R = Math.Abs((getRowDistanceTo0(s(i)) - getRowDistanceTo0(i)))
                C = Math.Abs((getColDistanceTo0(s(i)) - getColDistanceTo0(i)))
                H = H + R + C
            End If
        Next
        Return H
    End Function

    Private Function getRowDistanceTo0(ByVal i As Integer) As Integer
        Return Math.Floor(i / 3)
    End Function

    Private Function getColDistanceTo0(ByVal i As Integer) As Integer
        Return (i Mod 3)
    End Function

    Public Function getFofn()
        Return Fofn
    End Function

    Private Function calculateHofn2()



    End Function
End Class
