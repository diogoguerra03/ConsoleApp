Imports System.IO
Module Module3
    Sub main()
        'Leitura do username e pass
        Console.Write("Login: ")
        Dim strLogin As String = Console.ReadLine
        Console.Write("Pass: ")
        Dim strPass As String = Console.ReadLine

        'Se o user e a pass tiverem algo escrito 
        If Len(strLogin) > 0 And Len(strPass) > 0 Then
            Try
                Dim bw As New StreamWriter(New FileStream("user.txt", FileMode.Create))
                Try
                    bw.Write(strLogin)
                    bw.Write(";")
                    bw.Write(strPass)
                    bw.Write(";")
                Catch ex As Exception
                    Console.WriteLine("Erro na escrita." & vbNewLine & ex.Message)
                End Try
                bw.Close()
            Catch ex As Exception
                Console.WriteLine("Erro ao criar o ficheiro!" & vbNewLine & ex.Message)
                Return
            End Try
        End If
        Console.Read()
    End Sub
End Module
