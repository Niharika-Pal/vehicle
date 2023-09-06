Imports System

Module Program
    Class VEHICLE
        Protected speed As Double
        Protected n As String
        Protected type As String

        Public Sub New()
            Dim speed As Double
            speed = 0
        End Sub

        Public Sub New(name As String, sped As Double)
            n = name
            speed = sped
            Console.WriteLine("speed is " & speed)
        End Sub

        Public Overridable Sub typ(typ As String)
            type = typ
            Console.WriteLine("type of vehicle is " & type)
        End Sub


    End Class

    Class Bmw
        Inherits VEHICLE
        Protected mile As Double


        Public Sub New(name, sped)
            MyBase.New("bmw", 40)
        End Sub


        Public Sub mileage(distance As Double, litres As Double)
            mile = distance / litres
            Console.WriteLine("mileage is " & mile)
        End Sub

        Public Function get_value() As Integer
            Return mile
        End Function


        Public Overrides Sub typ(typ As String)
            MyBase.typ("automatic")
        End Sub
    End Class

    Class ferrari
        Inherits VEHICLE
        Public mil As Double


        Public Sub New(name, sped)
            MyBase.New("ferrari", 60)
        End Sub


        Public Sub mileage(distance As Double, litres As Double)
            mil = distance / litres
            Console.WriteLine("mileage is " & mil)
        End Sub

        Public Function val() As Integer
            Return mil
        End Function

        Public Overrides Sub typ(typ As String)
            MyBase.typ("automatic")
        End Sub
    End Class
    


    Sub main()
        Dim mee As Double
        Dim meet As Integer
        Console.WriteLine("Information OF BMW")
        Dim c1 As Bmw = New Bmw("Bmw", 40)
        c1.typ("automatic")
        c1.mileage(165, 5)
        mee = c1.get_value()



        Console.WriteLine("Information OF ferrari")
        Dim c2 As ferrari = New ferrari("Bmw", 50)
        c2.typ("automatic")
        c2.mileage(175, 5)
        meet = c2.val()


        If mee > meet Then
            Console.WriteLine("bmw has more mileage than ferrari so its more econoical")
        Else
            Console.WriteLine("ferrari is more economical with high mileage")

        End If

        Console.ReadLine()
    End Sub

End Module
