Imports System.Dynamic
Imports System.IO
Imports System.Threading.Tasks

Public Enum StringSearchOption
    StartsWith
    Contains
    EndsWith
End Enum

Public Class ReadOnlyFile
    Inherits DynamicObject

    Private _filePath As String

    Public Sub New(filePath As String)
        If Not File.Exists(filePath) Then
            Console.WriteLine("File path does not exist")
        End If
        _filePath = filePath
    End Sub

    Public Function GetPropertyValue(ByVal propertyName As String,
                                 Optional ByVal StringSearchOption As StringSearchOption = StringSearchOption.StartsWith,
                                 Optional ByVal trimSpaces As Boolean = True) As List(Of String)

        Dim sr As StreamReader = Nothing
        Dim results As New List(Of String)
        Dim line = ""
        Dim testLine = ""

        Try
            sr = New StreamReader(_filePath)

            While Not sr.EndOfStream
                line = sr.ReadLine()

                ' Perform a case-insensitive search by using the specified search options.
                testLine = UCase(line)
                If trimSpaces Then testLine = Trim(testLine)

                Select Case StringSearchOption
                    Case StringSearchOption.StartsWith
                        If testLine.StartsWith(UCase(propertyName)) Then results.Add(line)
                    Case StringSearchOption.Contains
                        If testLine.Contains(UCase(propertyName)) Then results.Add(line)
                    Case StringSearchOption.EndsWith
                        If testLine.EndsWith(UCase(propertyName)) Then results.Add(line)
                End Select
            End While
        Catch
            ' Trap any exception that occurs in reading the file and return Nothing.
            results = Nothing
        Finally
            If sr IsNot Nothing Then sr.Close()
        End Try

        Return results
    End Function

    ' Implement the TryGetMember method of the DynamicObject class for dynamic member calls.
    Public Overrides Function TryGetMember(ByVal binder As GetMemberBinder,
                                           ByRef result As Object) As Boolean
        result = GetPropertyValue(binder.Name)
        Return If(result Is Nothing, False, True)
    End Function

    ' Implement the TryInvokeMember method of the DynamicObject class for 
    ' dynamic member calls that have arguments.
    Public Overrides Function TryInvokeMember(ByVal binder As InvokeMemberBinder,
                                              ByVal args() As Object,
                                              ByRef result As Object) As Boolean

        Dim StringSearchOption As StringSearchOption = StringSearchOption.StartsWith
        Dim trimSpaces = True

        Try
            If args.Length > 0 Then StringSearchOption = CType(args(0), StringSearchOption)
        Catch
            Throw New ArgumentException("StringSearchOption argument must be a StringSearchOption enum value.")
        End Try

        Try
            If args.Length > 1 Then trimSpaces = CType(args(1), Boolean)
        Catch
            Throw New ArgumentException("trimSpaces argument must be a Boolean value.")
        End Try

        result = GetPropertyValue(binder.Name, StringSearchOption, trimSpaces)

        Return If(result Is Nothing, False, True)
    End Function

End Class

Public Class SignalAgent
    Inherits DynamicObject

    Protected ReadOnly _task As task

    Public Sub New()

    End Sub

    Public Overrides Function TryGetMember(binder As System.Dynamic.GetMemberBinder, ByRef result As Object) As Boolean

        result = Nothing
        Return False

    End Function

    Public Overrides Function TryInvokeMember(binder As System.Dynamic.InvokeMemberBinder, args() As Object, ByRef result As Object) As Boolean

        result = Invoke(binder.Name, args)
        Return True

    End Function

    Public Function Invoke(method As String, ParamArray args As Object()) As Task

        Dim invocation = GetInvocationData(method, args)

        Dim signal As String = ""

        Return _task

    End Function

    Protected Overridable Function GetInvocationData(method As String, args As Object()) As Object
        Return New With {.Hub = "", .Method = "", .Args = args}
    End Function

End Class
