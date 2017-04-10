Public Class lager

    Private enhet_id As Integer
    Private blod_egenskap As Integer
    Private blod_mengde As Integer
    Private blod_type As Integer
    'Public ordre_dato As Date
    'Public behandlet As Boolean


    Public Sub New(ByVal bestillings_id As Integer, ByVal b_egenskap As Integer, ByVal b_type As Integer) ', ByVal b_egenskap As Integer, ByVal b_mengde As Integer, ByVal o_dato As Date, ByVal blod_behandlet As Boolean, ByVal b_type As Integer)
        enhet_id = bestillings_id
        blod_egenskap = b_egenskap
        blod_type = b_type


        'blod_mengde = b_mengde
        'ordre_dato = o_dato
        'behandlet = blod_behandlet
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
