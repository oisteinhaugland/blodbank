Public Class Bruker

    'Brukerinformasjon
    Private blodgiverId As Integer
    Private forNavn As String
    Private etterNavn As String
    Private fodselsDato As String
    Private kjønn As String

    'Kontaktinformasjon
    Private adresse As String
    Private epost As String
    Private postNr As Integer
    Private postSted As String
    Private telefon As Integer
    Private personNr As Integer

    'Relevant Blodbankinfo
    Private blodTypeId As String
    Private forrigeBlodgivning As Date
    Private godkjentEgenerklering As Boolean
    Private karantene As Date

    'Hvis ansatt
    Private ansattId As Integer

    Public Sub New(ByVal bgId As Integer,
                   ByVal fNavn As String,
                   ByVal eNavn As String,
                   ByVal fDato As String,
                   ByVal adresse As String,
                   ByVal epost As String,
                   ByVal postNr As String,
                   ByVal postSted As String,
                   ByVal telefon As String,
                   ByVal personNr As String,
                   ByVal blodTypeId As String,
                   ByVal karantene As String,
                   ByVal egenerkleringResultat As Boolean)

        blodgiverId = bgId
        forNavn = fNavn
        etterNavn = eNavn
        fodselsDato = fDato
        Me.adresse = adresse
        Me.epost = epost
        Me.postNr = postNr
        Me.postSted = postSted
        Me.telefon = telefon
        Me.personNr = personNr
        Me.blodTypeId = blodTypeId
        Me.karantene = karantene
        godkjentEgenerklering = egenerkleringResultat


        Dim kjønnId = CInt(personNr.ToString.Substring(2, 1))
        If (kjønnId Mod 2) = 0 Then
            kjønn = "Kvinne"
        Else
            kjønn = "Mann"
        End If


    End Sub

    Public Function hentBgID()
        Return blodgiverId
    End Function
    Public Function hentfNavn()
        Return forNavn
    End Function
    Public Function hentENavn()
        Return etterNavn
    End Function
    Public Function hentAdresse()
        Return adresse
    End Function
    Public Function hentfDato()
        Return fodselsDato
    End Function
    Public Function hentfBlodtapp()
        Return forrigeBlodgivning
    End Function
    Public Function hentKarantene()
        Return karantene
    End Function
    Public Function hentpNr()
        Return postNr
    End Function
    Public Function hentpSted()
        Return postSted
    End Function

    Public Function hentTlf()
        Return telefon
    End Function


    Public Function hentKjønn()
        Return kjønn
    End Function

    Public Function hentBTypeId()
        Return blodTypeId
    End Function



End Class
