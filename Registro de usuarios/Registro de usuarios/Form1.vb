Public Class Form1


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Red As Color


        If Trim(TextBox1.Text) = "" Then
            MessageBox.Show("Algunos Campos estan vacios")
            TextBox1.Invalidate()

        Else
            MessageBox.Show("Usuario Registrado Con Exito")

        End If



    End Sub


End Class
