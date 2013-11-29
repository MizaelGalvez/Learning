Public Class Form1

    Private _enabled As TextBox


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim unidades(9) As String 'Arreglo auxiliar para unidades
        Dim especiales(15) As String 'Arreglo auxiliar para números especiales
        Dim decenas(9) As String 'Arreglo auxiliar para decenas
        Dim decenas_comp(9) As String 'Arreglo auxiliar para complementos de decenas
        Dim letras As String 'El número en palabras
        Dim valor As String 'El número
        Dim centenas(9) As String
        

        unidades(0) = "cero"
        unidades(1) = "uno"
        unidades(2) = "dos"
        unidades(3) = "tres"
        unidades(4) = "cuatro"
        unidades(5) = "cinco"
        unidades(6) = "seis"
        unidades(7) = "siete"
        unidades(8) = "ocho"
        unidades(9) = "nueve"

        especiales(11) = "once"
        especiales(12) = "doce"
        especiales(13) = "trece"
        especiales(14) = "catorce"
        especiales(15) = "quince"

        decenas(1) = "Diez"
        decenas(2) = "Veinte"
        decenas(3) = "Treinta"
        decenas(4) = "Cuarenta"
        decenas(5) = "Cincuenta"
        decenas(6) = "Sesenta"
        decenas(7) = "Setenta"
        decenas(8) = "Ochenta"
        decenas(9) = "Noventa"

        decenas_comp(1) = "Dieci"
        decenas_comp(2) = "Venti"
        decenas_comp(3) = "Treinta y "
        decenas_comp(4) = "Cuarenta y "
        decenas_comp(5) = "Cincuenta y "
        decenas_comp(6) = "Sesenta y "
        decenas_comp(7) = "Setenta y "
        decenas_comp(8) = "Ochenta y "
        decenas_comp(9) = "Noventa y "

        centenas(1) = "Ciento "
        centenas(2) = "Docientos "
        centenas(3) = "Trecientos "
        centenas(4) = "Cuatrocientos "
        centenas(5) = "Quinientos "
        centenas(6) = "Seiscientos "
        centenas(7) = "Setecientos "
        centenas(8) = "Ochocientos "
        centenas(9) = "Novecientos "




        valor = TextBox1.Text

        Dim centena As String
        Dim caracteres() As Char

        If valor.Length = 3 Then

            centena = centenas(Val(valor.Substring(0, 1)))

            caracteres = valor.ToCharArray()

            valor = caracteres(1) + caracteres(2)

            //Label2.Text = valor

        End If


        If valor.Length = 1 Then
            letras = unidades(Val(valor))
        Else
            If Val(valor) Mod 10 = 0 Then
                letras = decenas(Val(valor) / 10)
            Else
                Select Case valor
                    Case "11", "12", "13", "14", "15"
                        letras = especiales(Val(valor))
                    Case Else
                        letras = decenas_comp(Val(valor.Substring(0, 1))) + _
                         unidades(Val(valor.Substring(1, 1))).ToLower
                End Select
            End If
        End If

        Label1.Text = centena + letras


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        TextBox1.Hide()
        Label11.Text = TextBox1.Text

        TextBox3.Hide()
        Label12.Text = TextBox3.Text

        TextBox2.Hide()
        Label13.Text = TextBox2.Text
    End Sub

    

End Class