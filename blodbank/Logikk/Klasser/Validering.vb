Imports System.Text.RegularExpressions

Public Class Validering

    'Regex
    Public telefonformat As String = "(\d+){8}"
    Public postNrformat As String = "^(\d){4}"
    Public poststedFormat As String = "(\w+)"
    Public personnummerFormat As String = "^(\d){5}$"
    Public adresseFormat As String = "(\w+)\s(\d+)"
    Public navnFormat As String = "(\w+)"
    Public epostFormat As String = "^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$"
    Public datoFormat As String = "^(\d){2}\.(\d){2}\.(\d){4}$"
    Public registrerMengdeFormat As String = "^(\d)$"
    Public blodgiverIdFormat As String = "^(\d){1,}$"
    Public passordFormat As String = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{4,}$"
    Public registrerBlodprosentFormat As String = "^0*(?:[1-9][0-9]?|100)$"

    Public Function formatSkjekk(ByVal text As String, ByVal regularexpression As String)
        Dim match As Match = Regex.Match((text), regularexpression)
        If match.Success Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
