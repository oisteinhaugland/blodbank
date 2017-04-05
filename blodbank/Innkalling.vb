Public Class Innkalling

    'Public blodgiver_id As Integer
    Public blodgiver_id As Integer
    Public fornavn As String
    Public etternavn As String
    Public epost As String


    Public Sub New(ByVal bgiver_id As Integer, I_fornavn As String, ByVal I_etternavn As String, ByVal b_epost As String)

        blodgiver_id = bgiver_id
        fornavn = I_fornavn
        etternavn = I_etternavn
        epost = b_epost

    End Sub


End Class
