Public Class Form1
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click



        'mostrar valores en listboxs
        ListBox1.Items.Add(Edad(indice))
        ListBox2.Items.Add(genero(indice))
        ListBox3.Items.Add(codigo(indice))
        ListBox4.Items.Add(montodaños(indice))
        ListBox5.Items.Add(taller(indice))





    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'validando datos de entrada
        If indice < 6 Then

            'valores en vectores
            Edad(indice) = Val(TextBox1.Text)
            genero(indice) = ComboBox1.SelectedItem
            codigo(indice) = ComboBox2.SelectedItem
            montodaños(indice) = Val(TextBox2.Text)

            If RadioButton1.Checked = True Then
                taller(indice) = "Confianza"
            Else
                taller(indice) = "Aseguradora"
            End If
        Else
            MsgBox("Vectores llenos")
        End If



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        'limpiar 

        TextBox1.Clear()
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
        TextBox2.Clear()
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()
        ListBox5.Items.Clear()


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        'total conductores
        While (TextBox1.Text = " ") = False
            est5 = est5 + 1
            TextBox7.Text = est5

        End While


        'calculo del primer %
        For Edad As Integer = 1 To 25
            est1 = est1 + 1
        Next
        vest1 = (est1 / est5) * 100
        TextBox3.Text = vest1

        'calculo conductores fem
        While (ComboBox1.SelectedIndex = 0)
            est2 = est2 + 1
            TextBox4.Text = est2
        End While


        'calculo conductores M 18<x<25
        While (ComboBox2.SelectedIndex = 1)
            Select Case Edad(indice)
                Case 18 To 25
                    est3 = est3 + 1
            End Select
            vest3 = (est3 / est1) * 100
            TextBox5.Text = vest3
        End While

        'calculo conductores ext
        While (ComboBox2.SelectedIndex = 0)
            est4 = est4 + 1
            TextBox6.Text = est4
        End While


        'calculo total monto daños
        While (TextBox2.Text = " ") = False
            est6 = est6 + 1
            TextBox8.Text = est6
        End While



    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        'limpiar estadisticas
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        'abrir form2
        Form2.Show()


    End Sub
End Class
