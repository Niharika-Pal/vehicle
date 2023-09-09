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
            Console.WriteLine("Mileage is : " & mile)
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
            Console.WriteLine("Mileage is : " & mil)
        End Sub

        Public Function val() As Integer
            Return mil
        End Function

        Public Overrides Sub typ(typ As String)
            MyBase.typ("automatic")
        End Sub
    End Class

    Class audi
        Inherits VEHICLE
        Public mil As Double


        Public Sub New(name, sped)
            MyBase.New("AUDI", 70)
        End Sub


        Public Sub mileage(distance As Double, litres As Double)
            mil = distance / litres
            Console.WriteLine("Mileage is " & mil)
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
        Dim meet As Double
        Dim meetu As Double
        Console.WriteLine("INFORMATION OF BMW : " & vbCrLf)
        Dim c1 As Bmw = New Bmw("BMW", 40)
        c1.typ("automatic")
        c1.mileage(165, 5)
        mee = c1.get_value()
        Console.WriteLine("")

        Console.WriteLine("INFORMATION OF FERRARI : " & vbCrLf)
        Dim c2 As ferrari = New ferrari("FERRARI", 50)
        c2.typ("automatic")
        c2.mileage(175, 5)
        meet = c2.val()
        Console.WriteLine("")

        Console.WriteLine("INFORMATION OF AUDI : " & vbCrLf)
        Dim c3 As audi = New audi("AUDI", 70)
        c3.typ("Automatic")
        c3.mileage(185, 5)
        meetu = c3.val()
        Console.WriteLine("")

        If mee > meet Then
            If mee > meetu Then
                Console.WriteLine("BMW has more mileage than ferrari so its more econoical.")
            End If
        ElseIf meet > meetu Then
            Console.WriteLine("Ferrari is more economical with high mileage.")
        Else
            Console.WriteLine("Audi is more economical with high mileage.")

        End If

        Console.ReadLine()
    End Sub

End Module
