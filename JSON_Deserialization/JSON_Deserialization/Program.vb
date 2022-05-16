Imports System
Imports Newtonsoft.Json

Module Program
    Sub Main(args As String())

        Dim MasterList = New List(Of test)
        Dim a = New test

        a.Firstname = "Rahul"
        a.Lastname = "Kaintura"
        a.Skills = "Architecture"

        Dim b = New test
        b.Firstname = "Vishal"
        b.Lastname = "Pilaware"
        b.Skills = "Test the Application"

        MasterList.Add(a)
        MasterList.Add(b)

        Dim result = JsonConvert.SerializeObject(MasterList)
        Console.WriteLine(result)
        Console.ReadLine()

        Dim res = JsonConvert.DeserializeObject(Of List(Of test))(result)
        For Each data As test In res
            Console.WriteLine(data.Firstname + ">" + data.Lastname + ">" + data.Skills)
            Console.ReadLine()
        Next

        'Dim p = New test

        'p.Firstname = "Peter"
        'p.Lastname = "Parkar"
        'p.Skills = "Jump On Building with no fear"
        'Dim Result = JsonConvert.SerializeObject(p)
        'Console.WriteLine(p)
        'Console.ReadLine()
        'Dim res As test = JsonConvert.DeserializeObject(Of test)(Result)
        'Console.WriteLine(res.Firstname + ">" + res.Lastname + ">" + res.Skills)
    End Sub

    Public Class test
        Public Firstname As String
        Public Lastname As String
        Public Skills As String
    End Class
End Module
