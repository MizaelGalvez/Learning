		Dim unidades(9) As String
        Dim especiales(15) As String
        Dim decenas(5) As String
        Dim decenas_comp(5) As String
        Dim centenas(9) As String
        Dim letras As String
        Dim Valor As String

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

        centenas(1) = "Cien"
        centenas(2) = "Docientos"
        centenas(3) = "Trecientos"
        centenas(4) = "Cuatrocientos"
        centenas(5) = "Quinientos"
        centenas(6) = "Seiscientos"
        centenas(7) = "Setecientos"
        centenas(8) = "Ochocientos"
        centenas(9) = "Novecientos"




valor = txt_texto.Text 

If valor.length = 1 Then 
	letras = unidades(Val(valor))
Else
	If Val(valor) Mod 10 = o Then
		letras = decenas(Val(valor))
	Else
		Select Case valor
			Case "11", "12", "13", "14", "15"
				letras = especiales(val(valor))
			Case Else
				letras = decenas_compuestas(val(valor.Substring(0,1))) +
				unidades(val(valor.Substring(1,1))).ToLower
		End Select
	End If
End If

txt_texto.Text = letras
