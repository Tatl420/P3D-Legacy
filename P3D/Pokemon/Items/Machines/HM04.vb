Namespace Items.Machines

    <Item(246, "HM 04")>
    Public Class HM04

        Inherits TechMachine

        Public Sub New()
            MyBase.New(False, 100, 70)
            _textureRectangle = New Rectangle(48, 192, 24, 24)
        End Sub

    End Class

End Namespace
