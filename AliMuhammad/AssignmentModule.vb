Module AssignmentModule

    Sub Main()

        Console.WriteLine("Task 1")

        Dim C, G, S, weight, content As String
        Do
            Console.WriteLine("Enter Content Type")
            content = Console.ReadLine()
            If content <> "C" And content <> "G" And content <> "S" Then
                Console.WriteLine("Sack is rejected because of invalid sack type")
            End If
        Loop Until (content = "C" Or content = "G" Or content = "S")

        Do
            Console.WriteLine("Enter Sack Weight")
            weight = Console.ReadLine()
            If content = "G" Or content = "S" Then
                If weight > 50 Then
                    Console.WriteLine("Sack rejected due to over weight")
                ElseIf weight < 50 Then
                    Console.WriteLine("Sack rejected due to underweight")
                End If
            End If
        Loop Until (weight = 50)

        Do
            Console.WriteLine("Enter Sack Weight")
            weight = Console.ReadLine()
            If content = "C" Then
                If weight > 25 Then
                    Console.WriteLine("rejected due to overweight")
                ElseIf weight < 25 Then
                    Console.WriteLine("rejected due to under weight")
                End If
            End If
        Loop Until (weight = 25)

        Console.WriteLine("Task 2")

        Dim Tweight, Reject, Total, Ssack, Gsack, Csack As Integer
        Console.WriteLine("Enter Total number of Gravel Sacks")
        Gsack = Console.ReadLine()
        Console.WriteLine("Enter Total Number of sand sack")
        Ssack = Console.ReadLine()
        Total = Gsack + Csack + Ssack
        For count = 1 To 10
            content = Console.ReadLine()
            If content <> "G" And content <> "S" And content <> "C" Then
                Console.WriteLine("rejected due to invalid content")
                Reject = Reject + 1

            End If
            weight = Console.ReadLine()
            If content = G Or content = S Then
                If weight <> 50 Then
                    Console.WriteLine("rejected due to weight")
                    Reject = Reject + 1
                Else
                    Tweight = Tweight + weight
                End If
                If content = C Then
                    If weight <> 25 Then
                        Console.WriteLine("Rejected due to weight")
                        Reject = Reject + 1
                    Else
                        Tweight = Tweight + weight

                    End If

                End If

            End If
        Next
        Console.WriteLine("Total weight is {0}", Tweight)
        Console.WriteLine("Total rejected sacks are {0}", Reject)

        Console.WriteLine("Task 3")

        Dim Tprice, Dprice, amtsaved, Sp As Integer
        Tprice = (Csack * 3) + (Gsack * 2) + (Ssack * 2)
        Do
            If (Csack >= 1 And Ssack >= 2 And Gsack >= 2) Then
                Sp = Sp + 1
                Csack = Csack - 1
                Gsack = Gsack - 2
                Ssack = Ssack - 2
            End If
        Loop Until (Gsack < 2 Or Ssack < 2 Or Csack < 1)
        If Sp = 0 Then
            Dprice = (Sp * 10) + (Csack * 1) + (Gsack * 2) + (Ssack * 2)
        End If
        amtsaved = Tprice - Dprice
        Console.WriteLine("Discount {0}", Dprice)
        Console.WriteLine("Amount Saves {0}", amtsaved)
        Console.ReadKey()

    End Sub

End Module