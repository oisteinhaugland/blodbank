Imports System.Security.Cryptography
Imports System.Text
Public Class hashtest

    Public Function CreateRandomSalt() As String
        'the following is the string that will hold the salt charachters
        Dim mix As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+=][}{<>"
        Dim salt As String = ""
        Dim rnd As New Random
        Dim sb As New StringBuilder
        For i As Integer = 1 To 100 'Length of the salt
            Dim x As Integer = rnd.Next(0, mix.Length - 1)
            salt &= (mix.Substring(x, 1))
        Next
        Return salt
    End Function



    Public Function Hash512(password As String, salt As String) As String
        Dim convertedToBytes As Byte() = Encoding.UTF8.GetBytes(password & salt)
        Dim hashType As HashAlgorithm = New SHA512Managed()
        Dim hashBytes As Byte() = hashType.ComputeHash(convertedToBytes)
        Dim hashedResult As String = Convert.ToBase64String(hashBytes)
        Return hashedResult
    End Function



    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim salt = CreateRandomSalt()
        Dim lagretSaltOgPassord = (Hash512(plainPassword.Text, salt))

        hashedPassword.Text = lagretSaltOgPassord & vbCrLf & vbCrLf & salt

        sql_sporring("INSERT INTO `g_oops_05`.`hashtesth`(salt,hashedpassword, bruker_id)VALUES('" & salt & "', '" & lagretSaltOgPassord & "', 1)")

    End Sub

    Private Sub passwordcheck_Click(sender As Object, e As EventArgs) Handles passwordcheck.Click
        Dim vanligpassord = convertedToPlainpassword.Text
        Dim fuck As New DataTable
        Dim brukerSalt
        Dim brukerHashedPassord
        fuck = sql_sporring("SELECT * FROM hashtesth where bruker_id = 1")
        For Each rad In fuck.Rows
            brukerSalt = rad("salt")
            brukerHashedPassord = rad("hashedpassword")
        Next

        Dim skjekkaPassord = Hash512(vanligpassord, brukerSalt)

        If skjekkaPassord = brukerHashedPassord Then
            MsgBox("it fucking worked?")
        Else
            MsgBox("you fucking failed")
        End If



    End Sub
End Class