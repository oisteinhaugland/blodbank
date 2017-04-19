Public Class timebestilling

    Public timebestilling_id As Integer
        Public bestilling_dato As Date
        Public bestilling_tidspunkt As Integer
        Public blodgiver_id As Integer
        Public er_aktiv As Integer

    Public Sub New(ByVal t_id As Integer, ByVal b_dato As Date, ByVal b_tid As Integer, ByVal b_id As Integer, ByVal b_aktiv As Integer)

        timebestilling_id = t_id
        bestilling_dato = b_dato
        bestilling_tidspunkt = b_tid
        blodgiver_id = b_id
        er_aktiv = b_aktiv
    End Sub

End Class
