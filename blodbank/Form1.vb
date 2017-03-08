Imports MySql.Data.MySqlClient

Public Class Form1

    'Tilkoblingsinformasjon til phpMyAdmin Konto team 5
    Private team_passord As String = "M2oHUQ17"
    Private team_brukernavn As String = "g_oops_05"
    Private tjener_navn As String = "mysql.stud.iie.ntnu.no"
    Private db_tilkobling_str As String
    Private db_oppkobling As New MySqlConnection

    'Funksjon for å kjøre SQL spørringer
    Private Function sql_sporring(ByRef sql As String) As DataTable
        Dim data_tabell As New DataTable

        Try
            db_oppkobling.Open()
            Dim sql_kommando As New MySqlCommand(sql, db_oppkobling)
            Dim data_adapter As New MySqlDataAdapter

            data_adapter.SelectCommand = sql_kommando
            data_adapter.Fill(data_tabell)

            db_oppkobling.Close()
        Catch ex As MySqlException
            MessageBox.Show("goofed: " & ex.Message)
            db_oppkobling.Close()
        End Try

        Return data_tabell

    End Function


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'String for å koble seg til phpMyAdmin
        db_tilkobling_str = "Server=" & tjener_navn & ";" &
                            "Database=" & team_brukernavn & ";" &
                            "Uid=" & team_brukernavn & ";" &
                            "Pwd=" & team_passord & ";"

        db_oppkobling.ConnectionString = db_tilkobling_str
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sql_sporring("CREATE TABLE Person (Id int, Fornavn char(25), Etternavn char(25), mail char(25))")
    End Sub
End Class
