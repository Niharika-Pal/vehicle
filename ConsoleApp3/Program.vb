Imports System

Module Program
    Class VEHICLE
        Protected speed As Double
        Protected n As String
        Protected mile As Double
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

        Public Overridable Sub mileage(distance As Double, litres As Double)
            mile = distance / litres
            Console.WriteLine("mileage is " & mile)
        End Sub

    End Class

    Class Bmw
        Inherits VEHICLE


        Public Sub New(name, sped)
            MyBase.New("bmw", 40)
        End Sub

        Public Overrides Sub mileage(distance As Double, litres As Double)
            MyBase.mileage(165, 6)
        End Sub
         

        Public Overrides Sub typ(typ As String)
            MyBase.typ("automatic")
        End Sub
    End Class

    Class ferrari
        Inherits VEHICLE


        Public Sub New(name, sped)
            MyBase.New("ferrari", 60)
        End Sub

        Public Overrides Sub mileage(distance As Double, litres As Double)
            MyBase.mileage(178, 6)
        End Sub


        Public Overrides Sub typ(typ As String)
            MyBase.typ("automatic")
        End Sub
    End Class
    


    Sub main()
        Console.WriteLine("Information OF BMW")
        Dim c1 As Bmw = New Bmw("Bmw", 40)
        c1.typ("automatic")

        c1.mileage(165, 5)
        Console.ReadLine()
    End Sub
End Module
