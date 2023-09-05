Imports System

Module Program
    Class VEHICLE
        Private speed As Double
        Private mile As Double
        Private type As String

        Public Sub New()
            Dim speed As Double
            speed = 0
        End Sub

        Public Sub New(sped As Double)
            speed = sped
        End Sub

        Public Overridable Sub typ(typ As String)
            type = typ
        End Sub
        Public Overridable Sub mileage(distance As Double, litres As Double)
            mile = distance / litres
            Conole.writeline("mileage is " & mile)
        End Sub
    End Class

    Class Bmw
        Inherits VEHICLE


        Public Sub New(sped)
            MyBase.New()
        End Sub

        Public override Sub mileage()
           MyBase.mileage()
            Console.WriteLine("mileage is " & mile)
        End Sub
    End Class

    Class ferrari
        Inherits VEHICLE


        ' Private distance As Double = 250
        ' Private time As Double = 1
        ' Private litres As Double = 1

        ' Public Sub New()
        '    Dim speed As Double
        '  speed = distance / time
        '     Console.WriteLine("speed is " & speed)
        '  End Sub

        ' Public Sub mile()
        ' Dim mileage As Double
        ''     mileage = distance / litres
        '   Console.WriteLine("mileage is " & mileage)
        '  End Sub
        ''  End Class

        Sub main()

        Dim c1 As Bmw = New Bmw()

        Dim c2 As ferrari = New ferrari()
        Console.WriteLine("Information OF BMW")
        c1.show()
        c1.mil()
        Console.WriteLine("Information OF FERRARI")
        c2.READ()
        c2.mile()

    End Sub
End Module
