﻿Public Class lager

    Public enhet_id As Integer
    Public blod_egenskap As Integer
    'Public blod_mengde As Integer
    Public blod_type As Integer
    'Public ordre_dato As Date
    'Public behandlet As Boolean


    Public Sub New(ByVal bestillings_id As Integer, ByVal b_egenskap As Integer, ByVal b_type As Integer) ', ByVal b_egenskap As Integer, ByVal b_mengde As Integer, ByVal o_dato As Date, ByVal blod_behandlet As Boolean, ByVal b_type As Integer)
        enhet_id = bestillings_id
        blod_egenskap = b_egenskap
        'blod_mengde = b_mengde
        'ordre_dato = o_dato
        'behandlet = blod_behandlet
        blod_type = b_type
    End Sub






End Class
