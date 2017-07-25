Public Class searchAlgorithm
    Private Root As node 'Root node will have Null action which is really a Zero "used here as up"
    Private Node As node
    Private eSet As exploredSet = New exploredSet
    Private Actions(3) As Boolean
    'new
    Private ACT As List(Of Integer) = New List(Of Integer)
    Private Child As node
    Private frontierSize As Integer = 0

    Public Function BFS(ByVal rProblem As problem) 'returns solution or failure
        'initialization
        Dim frontier As FIFOfrontier = New FIFOfrontier
        Root = New node(rProblem.getInitialState, Nothing, Nothing, Nothing)
        frontier.insert(Root)
        eSet.clear()

        If rProblem.goalTest(Root) Then
            Return Root.getSolution()
        End If

        While True
            If frontier.empty() Then
                'Puzzle.watch.Stop()
                'Dim s As String
                's = Puzzle.watch.ElapsedMilliseconds
                's = s & vbCrLf & eSet.count
                'MsgBox(s)
                Return Nothing
            End If
            Node = frontier.pop()
            eSet.insert(Node)
            Actions = rProblem.actions(Node)

            For i = 0 To 3
                If Actions(i) Then
                    Child = Node.childNode(i)
                    If Not (eSet.isHere(Child)) And Not (frontier.isHere(Child)) Then
                        If rProblem.goalTest(Child) Then
                            frontierSize = frontier.getCount
                            Return Child.getSolution()
                        End If
                        frontier.insert(Child)
                    End If
                End If
            Next

        End While

        Return False
    End Function

    Public Function R_BFS(ByVal rProblem As problem) 'returns solution or failure
        'initialization
        Dim frontier As FIFOfrontier = New FIFOfrontier
        Root = New node(rProblem.getInitialState, Nothing, Nothing, Nothing)
        frontier.insert(Root)
        eSet.clear()

        If rProblem.goalTest(Root) Then
            Return Root.getSolution()
        End If
        Randomize()
        While True

            If frontier.empty() Then
                'Puzzle.watch.Stop()
                'Dim s As String
                's = Puzzle.watch.ElapsedMilliseconds
                's = s & vbCrLf & eSet.count
                'MsgBox(s)
                Return Nothing
            End If
            Node = frontier.pop()
            eSet.insert(Node)

            ACT = rProblem.newActions(Node)

            Dim ind As Integer
            Dim c As Integer = ACT.Count - 1
            For i = 0 To c
                ind = Int(Math.Abs(ACT.Count * Rnd() - 0.1))

                Child = Node.childNode(ACT(ind))
                ACT.Remove(ACT(ind))
                If Not (eSet.isHere(Child)) And Not (frontier.isHere(Child)) Then
                    If rProblem.goalTest(Child) Then
                        frontierSize = frontier.getCount
                        Return Child.getSolution()
                    End If
                    frontier.insert(Child)
                End If
            Next
        End While

        Return False
    End Function

    Public Function DFS(ByVal rProblem As problem) 'returns solution or failure
        'initialization
        Dim frontier As LIFOfrontier = New LIFOfrontier
        Root = New node(rProblem.getInitialState, Nothing, Nothing, Nothing)
        frontier.insert(Root)
        eSet.clear()

        If rProblem.goalTest(Root) Then
            Return Root.getSolution()
        End If

        While True
            If frontier.empty() Then
                'Puzzle.watch.Stop()
                'Dim s As String
                's = Puzzle.watch.ElapsedMilliseconds
                's = s & vbCrLf & eSet.count
                'MsgBox(s)
                Return Nothing
            End If
            Node = frontier.pop()
            eSet.insert(Node)
            Actions = rProblem.actions(Node)

            For i = 0 To 3
                If Actions(i) Then
                    Child = Node.childNode(i)
                    If Not (eSet.isHere(Child)) And Not (frontier.isHere(Child)) Then
                        If rProblem.goalTest(Child) Then
                            frontierSize = frontier.getCount
                            Return Child.getSolution()
                        End If
                        frontier.insert(Child)
                    End If
                End If
            Next

        End While

        Return False
    End Function

    Public Function R_DFS(ByVal rProblem As problem) 'returns solution or failure
        'initialization
        Dim frontier As LIFOfrontier = New LIFOfrontier
        Root = New node(rProblem.getInitialState, Nothing, Nothing, Nothing)
        frontier.insert(Root)
        eSet.clear()

        If rProblem.goalTest(Root) Then
            Return Root.getSolution()
        End If
        Randomize()
        While True
            If frontier.empty() Then
                Return Nothing
            End If
            Node = frontier.pop()
            eSet.insert(Node)
            ACT = rProblem.newActions(Node)

            Dim ind As Integer
            Dim c As Integer = ACT.Count - 1
            For i = 0 To c
                ind = Int(Math.Abs(ACT.Count * Rnd() - 0.1))

                Child = Node.childNode(ACT(ind))
                ACT.Remove(ACT(ind))
                If Not (eSet.isHere(Child)) And Not (frontier.isHere(Child)) Then
                    If rProblem.goalTest(Child) Then
                        frontierSize = frontier.getCount
                        Return Child.getSolution()
                    End If
                    frontier.insert(Child)
                End If
            Next

        End While

        Return False
    End Function

    Public Function Astar(ByVal rProblem As problem)

        Root = New node(rProblem.getInitialState, Nothing, Nothing, 0)
        Dim frontier As Priorityfrontier = New Priorityfrontier
        frontier.insert(Root)
        eSet.clear()

        While True
            If frontier.empty() Then
                Return Nothing
            End If

            Node = frontier.pop()
            If (eSet.count <> 0) Then
                If (eSet.isHere(Node)) Then
                    GoTo CON
                End If
            End If

            If rProblem.goalTest(Node) Then
                frontierSize = frontier.getCount
                Return Node.getSolution()
            End If

            eSet.insert(Node)

            Actions = rProblem.actions(Node)
            For i = 0 To 3
                If Actions(i) Then
                    Child = Node.childNode(i)

                    If (Not (eSet.isHere(Child))) Then
                        If (Not (frontier.isHere(Child))) Then
                            frontier.insert(Child)
                        Else
                            frontier.replace(Child)
                        End If
                    End If
                End If
            Next
CON:
        End While

        Return False
    End Function

    Public Function R_Astar(ByVal rProblem As problem)

        Root = New node(rProblem.getInitialState, Nothing, Nothing, 0)
        Dim frontier As Priorityfrontier = New Priorityfrontier
        frontier.insert(Root)
        eSet.clear()

        Randomize()

        While True
            If frontier.empty() Then
                Return Nothing
            End If

            Node = frontier.pop()

            If rProblem.goalTest(Node) Then
                frontierSize = frontier.getCount
                Return Node.getSolution()
            End If

            eSet.insert(Node)

            ACT = rProblem.newActions(Node)

            Dim ind As Integer
            Dim c As Integer = ACT.Count - 1
            For i = 0 To c
                ind = Int(Math.Abs(ACT.Count * Rnd() - 0.1))
                Child = Node.childNode(ACT(ind))
                ACT.Remove(ACT(ind))
                If (Not (eSet.isHere(Child))) Then
                    If (Not (frontier.isHere(Child))) Then
                        frontier.insert(Child)
                    Else
                        frontier.replace(Child)
                    End If
                End If
            Next
        End While

        Return False
    End Function

    Public Function GBFS(ByVal rProblem As problem)

        Root = New node(rProblem.getInitialState, Nothing, Nothing, 0)
        Dim frontier As Priorityfrontier = New Priorityfrontier
        frontier.insert(Root)
        eSet.clear()

        While True
            If Puzzle.watch.ElapsedMilliseconds > 5000 Then
                Return Nothing
            End If

            If frontier.empty() Then
                Return Nothing
            End If

            Node = frontier.pop()

            If rProblem.goalTest(Node) Then
                frontierSize = frontier.getCount
                Return Node.getSolution()
            End If

            eSet.insert(Node)

            Actions = rProblem.actions(Node)
            For i = 0 To 3
                If Actions(i) Then
                    Child = Node.childNode(i)

                    If (Not (eSet.isHere(Child))) Then
                        If (Not (frontier.isHere(Child))) Then
                            frontier.insert(Child)
                        Else
                            frontier.replace(Child)
                        End If
                    End If

                End If
            Next

        End While

        Return False
    End Function

    Public Function R_GBFS(ByVal rProblem As problem)

        Root = New node(rProblem.getInitialState, Nothing, Nothing, 0)
        Dim frontier As Priorityfrontier = New Priorityfrontier
        frontier.insert(Root)
        eSet.clear()

        Randomize()
        While True
            If frontier.empty() Then
                Return Nothing
            End If

            Node = frontier.pop()

            If rProblem.goalTest(Node) Then
                frontierSize = frontier.getCount
                Return Node.getSolution()
            End If

            eSet.insert(Node)

            ACT = rProblem.newActions(Node)

            Dim ind As Integer
            Dim c As Integer = ACT.Count - 1
            For i = 0 To c
                ind = Int(Math.Abs(ACT.Count * Rnd() - 0.1))
                Child = Node.childNode(ACT(ind))
                ACT.Remove(ACT(ind))

                If (Not (eSet.isHere(Child))) Then
                    If (Not (frontier.isHere(Child))) Then
                        frontier.insert(Child)
                    Else
                        frontier.replace(Child)
                    End If
                End If
            Next

        End While

        Return False
    End Function


    Public Function getSetCount()
        Return eSet.count()
    End Function

    Public Function getFrontierCount()
        Return frontierSize
    End Function
End Class

