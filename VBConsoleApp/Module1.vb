Imports System.Globalization

Module Module1

    Sub Main()


        Dim fr As String = "12/31/2012 00:00:00.000"
        'Dim df As DateTime = DateTime.Parse(fr, CultureInfo.GetCultureInfo("en-US"))
        Dim df As DateTime = DateTime.Parse(fr, CultureInfo.GetCultureInfo("en-GB"), DateTimeStyles.AdjustToUniversal)

        Console.WriteLine(df.ToString())

        'Dim rFile As Object = New ReadOnlyFile("..\..\TextFile1.txt")
        'For Each line In rFile.Customer
        '    Console.WriteLine(line)
        'Next
        'Console.WriteLine("----------------------------")
        'For Each line In rFile.Customer(StringSearchOption.Contains, True)
        '    Console.WriteLine(line)
        'Next
        'For Each line In rFile.Supplier
        '    Console.WriteLine(line)
        'Next

        'Dim myObj As Object = New ReadOnlyFile("")
        'myObj.helloWorld = "Hello World"

        'Console.WriteLine(myObj.helloWorld)

    End Sub

End Module
