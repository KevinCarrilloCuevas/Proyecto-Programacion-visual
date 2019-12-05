Public Class Form1


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click



        If Trim(TextBox1.Text) = "" Or Trim(TextBox5.Text) = "" Then
            MessageBox.Show("Algunos Campos estan vacios")

        Else
            MessageBox.Show("Usuario Registrado Con Exito")

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Trim(TextBox2.Text) = "" Or Trim(TextBox3.Text) = "" Or Trim(TextBox4.Text) = "" Then
            MessageBox.Show("Algunos Campos estan vacios Verifiquelos")

        Else
            MessageBox.Show("Datos Guardado Con Exito ")

        End If
        If (ComboBox1.SelectedIndex = -1) Then

            MessageBox.Show("NO Ha elegido ninguna opcion en STATUS")
        End If

        If (ComboBox2.SelectedIndex = -1) Then

            MessageBox.Show("NO Ha elegido UN TIPO DE USUARIO")
        End If


        If RadioButton1.Checked = 0 Or RadioButton2.Checked = 0 Then

            MessageBox.Show("NO Has elegido ningun GENERO")

        Else
            MessageBox.Show("Genero guardado")
        End If




    End Sub
End Class
