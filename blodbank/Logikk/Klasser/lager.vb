Public Class Lager

    Private enhet_id As Integer
    Private blod_egenskap As Integer
    Private blod_mengde As Integer
    Private blod_type As Integer


    Public Sub New(ByVal bestillings_id As Integer, ByVal b_egenskap As Integer, ByVal b_type As Integer)
        enhet_id = bestillings_id
        blod_egenskap = b_egenskap
        blod_type = b_type

    End Sub

    Public Function hentId()
        Return enhet_id
    End Function

    Public Function hentBlogenskap()
        Return blod_egenskap
    End Function

    Public Function hentBlodType()
        Return blod_type
    End Function

End Class
