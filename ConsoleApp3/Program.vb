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

        Public Sub New(sped As Double)
            speed = sped
            Console.WriteLine("Speed is " & speed)
        End Sub

        Public Overridable Sub typ(typ As String)
            type = typ
            Console.WriteLine("Type of vehicle is " & type)
        End Sub


    End Class

    Class BMW
        Inherits VEHICLE
        Protected mile As Double


        Public Sub New(sped)
            MyBase.New(sped)
        End Sub


        Public Sub mileage(distance As Double, litres As Double)
            mile = distance / litres
            Console.WriteLine("Mileage is : " & mile)
        End Sub

        Public Function get_value() As Integer
            Return mile
        End Function


        Public Overrides Sub typ(typ As String)
            MyBase.typ(typ)
        End Sub
    End Class

    Class ferrari
        Inherits VEHICLE
        Public mil As Double


        Public Sub New(sped)
            MyBase.New(sped)
        End Sub


        Public Sub mileage(distance As Double, litres As Double)
            mil = distance / litres
            Console.WriteLine("Mileage is : " & mil)
        End Sub

        Public Function val() As Integer
            Return mil
        End Function

        Public Overrides Sub typ(typ As String)
            MyBase.typ(typ)
        End Sub
    End Class

    Class audi
        Inherits VEHICLE
        Public mil As Double


        Public Sub New(sped)
            MyBase.New(sped)
        End Sub


        Public Sub mileage(distance As Double, litres As Double)
            mil = distance / litres
            Console.WriteLine("Mileage is " & mil)
        End Sub


        Public Function val() As Integer
            Return mil
        End Function

        Public Overrides Sub typ(typ As String)
            MyBase.typ(typ)
        End Sub
    End Class

    Sub main()
        Dim mee As Double
        Dim meet As Double
        Dim meetu As Double
        Console.WriteLine("INFORMATION OF BMW : " & vbCrLf)
        Dim c1 As BMW = New BMW(40)
        c1.typ("Automatic")
        c1.mileage(165, 5)
        mee = c1.get_value()

        Console.WriteLine(vbCrLf & "INFORMATION OF FERRARI : " & vbCrLf)
        Dim c2 As ferrari = New ferrari(50)
        c2.typ("Automatic")
        c2.mileage(175, 5)
        meet = c2.val()

        Console.WriteLine(vbCrLf & "INFORMATION OF AUDI : " & vbCrLf)
        Dim c3 As audi = New audi(70)
        c3.typ("Automatic")
        c3.mileage(185, 5)
        meetu = c3.val()
        Console.WriteLine()

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
