Public Class Karantene

    Public blodgiver_id As Integer
    Public fornavn As String
    Public etternavn As String
    Public fodseldato As Date
    Public adresse As String
    Public post_nr As String
    Public post_sted As String
    Public telefon As Integer
    Public epost As String
    Public godkjent_egenerklering As Integer
    Public karantene As Date
    Public passord As String
    Public blodtype As String
    Public personnummer As String


    Public Sub New(ByVal b_blodgiver_id As Integer, ByVal b_fornavn As String, ByVal b_etternavn As String, ByVal b_fdato As Date, ByVal b_adresse As String, ByVal b_post_nr As String, ByVal b_post_sted As String, ByVal b_telefon As Integer, ByVal b_epost As String, ByVal b_erklering As Integer, ByVal b_karantene As Date, ByVal b_passord As String, ByVal b_blodtype As String, ByVal b_personnummer As String)


        blodgiver_id = b_blodgiver_id
        fornavn = b_fornavn
        etternavn = b_etternavn
        fodseldato = b_fdato
        adresse = b_adresse
        post_nr = b_post_nr
        post_sted = b_post_sted
        telefon = b_telefon
        epost = b_epost
        godkjent_egenerklering = b_erklering
        karantene = b_karantene
        passord = b_passord
        blodtype = b_blodtype
        personnummer = b_personnummer

    End Sub
End Class
