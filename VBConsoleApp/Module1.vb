Module Module1

    Sub Main()

        Dim rFile As Object = New ReadOnlyFile("..\..\TextFile1.txt")
        For Each line In rFile.Customer
            Console.WriteLine(line)
        Next
        Console.WriteLine("----------------------------")
        For Each line In rFile.Customer(StringSearchOption.Contains, True)
            Console.WriteLine(line)
        Next
        For Each line In rFile.Supplier
            Console.WriteLine(line)
        Next

        Dim myObj As Object = New ReadOnlyFile("")
        myObj.helloWorld = "Hello World"

        Console.WriteLine(myObj.helloWorld)

    End Sub

End Module
