Module Module1

    Sub Main()
        Dim val, val2 As Integer
        Console.Write("numero de filas:")
        val = Integer.Parse(Console.ReadLine())
        If val <= 0 Then
            Console.WriteLine("se esperaba un numero mayor a cero")
        Else
            Do
                val2 = val
                Do
                    Console.Write("*")
                    val2 = val2 - 1
                Loop While val2 > 0
                Console.WriteLine("")
                val = val - 1
            Loop While val > 0
        End If
        
        Console.ReadKey()

    End Sub

End Module
