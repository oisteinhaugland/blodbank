'entitetsklasse
Public Class Blodgiver

    Private blodgiver_id As Integer
    Private fornavn As String
    Private etternavn As String
    Private fodseldato As Date
    Private adresse As String
    Private post_nr As String
    Private post_sted As String
    Private telefon As Integer
    Private epost As String
    Private godkjent_egenerklering As Integer
    Private karantene As Date
    Private passord As String
    Private blodtype As String
    Private personnummer As String


    Public Sub New(ByVal b_blodgiver_id As Integer, ByVal b_fornavn As String, ByVal b_etternavn As String, ByVal b_fdato As Date, ByVal b_adresse As String, ByVal b_post_nr As String, ByVal b_post_sted As String, ByVal b_telefon As Integer, ByVal b_epost As String, ByVal b_erklering As Integer, ByVal b_karantene As Date, ByVal b_blodtype As String, ByVal b_personnummer As String)

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

        blodtype = b_blodtype
        personnummer = b_personnummer

    End Sub
End Class
