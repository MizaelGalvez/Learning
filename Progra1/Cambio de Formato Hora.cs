Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim valor As String
        Dim caracteres() As Char
        Dim formato As Integer
        Dim validar As Integer
        Dim signo As String
        Dim ampm As String
        Dim horas As String
        Dim minutos As String
        Dim falla As Integer
        Dim entrar As Boolean


        ampm = " am"
        signo = ":"
        valor = TextBox1.Text
        entrar = True

        
        If valor.Length < 5 Then

            MsgBox("Error con el formato ingresado " & vbNewLine & "deves inclir 00:00")
            entrar = False

        End If

        If entrar = True Then

            caracteres = valor.ToCharArray()

            formato = caracteres(0) + caracteres(1)
            validar = caracteres(3) + caracteres(4)
            falla = formato

            If formato > 12 Then

                valor = formato - 2
                caracteres = valor.ToCharArray()
                valor = caracteres(1)
                If formato > 21 Then
                    valor = "1" + valor
                End If
                formato = Convert.ToInt32(valor)
                ampm = " pm"

            End If

            horas = Convert.ToString(formato)
            minutos = Convert.ToString(validar)

            If falla > 24 Or validar > 60 Then

                MsgBox("Horas incorrectas EXAGERASTE mamon" & vbNewLine & "Horas maximo 24:" & vbNewLine & "Minutos maximo :60")

            Else
                Label1.Text = horas + signo + minutos + ampm

            End If

        End If

    End Sub


End Class
