
Imports MySql.Data.MySqlClient

Public Class Form1
    Dim user As String
    Dim pass As String

    Private Sub Btn_entra_Click_1(sender As Object, e As EventArgs) Handles Btn_entra.Click
        Try
            user = txt_usuario.Text
            pass = txt_contra.Text
            If Conectar.Prueba() Then
                MessageBox.Show("Usuario ")
                Me.Hide()
                principal.Show()
            End If

        Catch ex As MySqlException
            MessageBox.Show("Usuario sin autorizacion en el sistema")

        End Try


    End Sub
End Class
