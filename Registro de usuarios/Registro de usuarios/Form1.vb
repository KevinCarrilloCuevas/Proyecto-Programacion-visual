Public Class Form1




    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click



        If Trim(TextBox1.Text) = "" Or Trim(TextBox5.Text) = "" Then
            MessageBox.Show("Algunos campos del usuario estan vacios, Verifiquelos", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            MessageBox.Show("Usuario Registrado Con Exito")

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If Trim(TextBox2.Text) = "" Or Trim(TextBox3.Text) = "" Or Trim(TextBox4.Text) = "" Then
            MessageBox.Show("Algunos campos estan vacios, Verifiquelos", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            MessageBox.Show("Datos Guardado Con Exito ")

        End If



        If (ComboBox1.SelectedIndex = -1) Then

            MessageBox.Show("No Ha elegido ninguna opcion en STATUS", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        If (ComboBox2.SelectedIndex = -1) Then

            MessageBox.Show("No Ha elegido UN TIPO DE USUARIO", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If




        If CheckedListBox1.CheckedItems.Count < 1 Then
            MessageBox.Show("tienes que elegir al menos un puesto de trabajo", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)


        ElseIf CheckedListBox1.CheckedItems.Count > 1 Then

            MessageBox.Show("Solo puedes elegir un puesto de trabajo", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If



        If RadioButton1.Checked Then

        ElseIf RadioButton2.Checked Then

        Else
            MessageBox.Show("No eligio un genero", "genero", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If


    End Sub

End Class
