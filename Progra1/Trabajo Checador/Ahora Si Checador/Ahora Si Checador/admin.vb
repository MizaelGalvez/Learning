Public Class admin


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        GroupBox2.Hide()
        GroupBox3.Hide()
        GroupBox1.Hide()
        GroupBox4.Show()

        DataGridView2.Rows.Clear()

        'utilizando el codigo para actualizar la grid por cualquier cosa
        '|
        '|
        'V
        Dim empleadoUBI As Integer
        Dim numempleado1, nombre1, horario1, pagohora1, retardos1, faltas1, horastrabajadas1, password1, total As String

        For empleadoUBI = 0 To 9



            numempleado1 = Datos(empleadoUBI, 0)
            nombre1 = Datos(empleadoUBI, 1)
            horario1 = Datos(empleadoUBI, 2)
            pagohora1 = Datos(empleadoUBI, 3)
            retardos1 = Datos(empleadoUBI, 4)
            faltas1 = Datos(empleadoUBI, 5)
            horastrabajadas1 = Datos(empleadoUBI, 6)
            password1 = Datos(empleadoUBI, 7)
            total = Datos(empleadoUBI, 8)






            DataGridView2.Rows.Add(numempleado1, nombre1, horario1, pagohora1, retardos1, faltas1, horastrabajadas1, password1, total)

            numempleado1 = ""
            nombre1 = ""
            horario1 = ""
            pagohora1 = ""
            retardos1 = ""
            faltas1 = ""
            horastrabajadas1 = ""
            password1 = ""
            total = ""


            empleado = My.Computer.FileSystem.ReadAllText("C:/experimental/totalnumero.txt")

        Next
        'A
        '|
        '|
        'aqui termina la actualizacion en el boton

    End Sub ' cambia a la vista empleados y actualiza el Grid

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        GroupBox1.Hide()
        GroupBox2.Hide()
        GroupBox4.Hide()
        GroupBox3.Show()

        DataGridView2.Rows.Clear()

        'utilizando el codigo para actualizar la grid por cualquier cosa
        '|
        '|
        'V
        Dim empleadoUBI As Integer
        Dim numempleado1, nombre1, horario1, pagohora1, retardos1, faltas1, horastrabajadas1, password1, total As String

        For empleadoUBI = 0 To 9



            numempleado1 = Datos(empleadoUBI, 0)
            nombre1 = Datos(empleadoUBI, 1)
            horario1 = Datos(empleadoUBI, 2)
            pagohora1 = Datos(empleadoUBI, 3)
            retardos1 = Datos(empleadoUBI, 4)
            faltas1 = Datos(empleadoUBI, 5)
            horastrabajadas1 = Datos(empleadoUBI, 6)
            password1 = Datos(empleadoUBI, 7)
            total = Datos(empleadoUBI, 8)






            DataGridView2.Rows.Add(numempleado1, nombre1, horario1, pagohora1, retardos1, faltas1, horastrabajadas1, password1, total)

            numempleado1 = ""
            nombre1 = ""
            horario1 = ""
            pagohora1 = ""
            retardos1 = ""
            faltas1 = ""
            horastrabajadas1 = ""
            password1 = ""
            total = ""


            empleado = My.Computer.FileSystem.ReadAllText("C:/experimental/totalnumero.txt")

        Next
        'A
        '|
        '|
        'aqui termina la actualizacion en el boton
    End Sub ' cambia a la vista recursos humanos y actualiza el Grid

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '| solo se actualizan las bariables para utilizar en las operaciones
        '|
        'V

        tolerancia = TextBox5.Text
        retardosparafaltas = TextBox6.Text
        pagoextra = NumericUpDown1.Value

        'A
        '|
        '| termina estas funciones de agregar el valor por defecto

        GroupBox3.Hide()
        GroupBox1.Hide()
        GroupBox4.Hide()
        GroupBox2.Show()
    End Sub ' actualizacion de variable de operaciones, por si solo queria verlas y no cambiarlas

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        GroupBox2.Hide()
        GroupBox3.Hide()
        GroupBox4.Hide()
        GroupBox1.Show()



        'empieza las funciones de retardos faltas y total del pago
        '|
        '|
        'V
        '
        '
        Dim horaEnt As String
        Dim horaSal As String
        Dim min As String
        Dim letras() As Char
        Dim temporal As String
        Dim registroempleado(10) As String
        Dim numempleado As String
        Dim faltatemporal As String
        '
        '
        
        For i As Integer = 0 To Form1.posicion - 1

            registroempleado(i) = entradasalida(i, 0) + entradasalida(i, 1) + entradasalida(i, 2)

            letras = registroempleado(i).ToCharArray

            numempleado = letras(0) + letras(1) + letras(2)
            horaEnt = letras(3) + letras(4)

            horaSal = letras(8) + letras(9)
            min = letras(4) + letras(6) + letras(7)



            For index = 0 To 9

                faltatemporal = Datos(index, 5)
                Datos(index, 5) = Datos(index, 5) + 1

                If numempleado = Datos(index, 0) Then

                    Datos(index, 5) = faltatemporal

                    Datos(index, 6) = Datos(index, 6) + (horaSal - horaEnt)
                    Datos(index, 8) = Datos(index, 8) + (Datos(index, 3) * Datos(index, 6))
                    If Datos(index, 2) = "Matutino" Then

                        If min >= 615 Then

                            Datos(index, 4) = Datos(index, 4) + 1
                        End If

                    ElseIf Datos(index, 2) = "Vespertino" Then

                        If min >= 415 Then
                            Datos(index, 4) = Datos(index, 4) + 1

                        End If

                    End If

                End If

                faltatemporal = ""

            Next


        Next
        '
        'A
        '|
        '|
        'aqui terminan las operaciones logicas

        Dim empleadoUBI As Integer
        Dim numempleado1, nombre1, horario1, pagohora1, retardos1, faltas1, horastrabajadas1, password1, total As String

        DataGridView2.Rows.Clear()
        DataGridView3.Rows.Clear()

        For empleadoUBI = 0 To 9



            numempleado1 = Datos(empleadoUBI, 0)
            nombre1 = Datos(empleadoUBI, 1)
            horario1 = Datos(empleadoUBI, 2)
            pagohora1 = Datos(empleadoUBI, 3)
            retardos1 = Datos(empleadoUBI, 4)
            faltas1 = Datos(empleadoUBI, 5)
            horastrabajadas1 = Datos(empleadoUBI, 6)
            password1 = Datos(empleadoUBI, 7)
            total = Datos(empleadoUBI, 8)






            DataGridView2.Rows.Add(numempleado1, nombre1, horario1, pagohora1, retardos1, faltas1, horastrabajadas1, password1, total)
            DataGridView3.Rows.Add(numempleado1, nombre1, horario1, pagohora1, retardos1, faltas1, horastrabajadas1, password1, total)

            numempleado1 = ""
            nombre1 = ""
            horario1 = ""
            pagohora1 = ""
            retardos1 = ""
            faltas1 = ""
            horastrabajadas1 = ""
            password1 = ""
            total = ""

        Next


        Using file As New IO.StreamWriter("C:\experimental\datosempleados.txt")
            file.Flush()
        End Using
        '
        '
        For i As Integer = 0 To 9
            '
            For j As Integer = 0 To 8
                temporal = Datos(i, j) + " "
                My.Computer.FileSystem.WriteAllText("C:\experimental\datosempleados.txt",
                temporal, True)
            Next
            '
        Next


        ' borrando el registro diario
        '|
        'V
        For i As Integer = 0 To 9
            For j As Integer = 0 To 2
                entradasalida(i, j) = ""

            Next
        Next
        'A
        '|
        'listo desde cero



    End Sub ' las operaciones matematicas al "aplicar Siguiente dia osea borrar el registro de entrada para que entren de nuevo" clik al Label Administrador

    Private Sub admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GroupBox2.Hide()
        GroupBox3.Hide()
        GroupBox4.Hide()
        GroupBox1.Show()

        'inicia el llenado del grid desde el archivo datosemplados
        '
        '
        Dim archivo As String
        Dim letras() As Char
        Dim palabras(Datos.Length) As String
        '
        archivo = My.Computer.FileSystem.ReadAllText("C:/experimental/datosempleados.txt")
        letras = archivo.ToCharArray
        '
        '
        '
        '
        '
        '

        'hice el arreglo infinito jajaja de char para sacar cada palabra de los usuario
        '|
        '|
        'V
        '
        Dim j As Integer = 0
        For i As Integer = 0 To letras.Length - 1
            '
            '
            If letras(i) <> " " Then
                '
                palabras(j) = palabras(j) + letras(i)
                '
            Else : j = j + 1
                '
            End If
            '
        Next
        '
        'A
        '|
        '|'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        'ya que se hicieron las palabra aqui devajo se agregan al arreglo datos 
        '|
        '|
        'V
        '
        Dim a As Integer = 0
        '
        '
        For i As Integer = 0 To 9
            '
            For f As Integer = 0 To 8
                '
                Datos(i, f) = palabras(a)
                a = a + 1
            Next
            '
        Next
        '
        'A
        '|
        '|
        'termina el llenado del grid desde el archivo datosemplados
    End Sub ' es la carga de los datos al cambiar a ADMIN !!! carga los data Grid 

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        Dim user As String
        Dim passs As String
        Dim posicion As Integer = 0
        Dim imprimir As String



        Using file As New IO.StreamWriter("C:\experimental\empleados.txt")
            file.Flush()
        End Using




        For i As Integer = 0 To 9



            'aqui empieza la escritura de contraseñas
            '|
            '|
            'V
            '
            user = Datos(posicion, 0)
            passs = Datos(posicion, 7)
            imprimir = user + " " + passs + " "
            '
            '
            '
            posicion = posicion + 1
            '
            My.Computer.FileSystem.WriteAllText("C:\experimental\empleados.txt",
            imprimir, True)
            '
            'A
            '|
            '|
            'aquitermina la escritura de contreaseñas



        Next

        imprimir = "admin 998877 "
        My.Computer.FileSystem.WriteAllText("C:\experimental\empleados.txt",
            imprimir, True)



        'inicia imprimir el arreglo en un archivo
        '|
        '|
        'V
        '
        imprimir = ""
        '
        '
        Using file As New IO.StreamWriter("C:\experimental\datosempleados.txt")
            file.Flush()
        End Using
        '
        '
        For i As Integer = 0 To 9
            '
            For j As Integer = 0 To 8
                imprimir = Datos(i, j) + " "
                My.Computer.FileSystem.WriteAllText("C:\experimental\datosempleados.txt",
                imprimir, True)
            Next
            '
        Next
        '
        'A
        '|
        '|
        'termina la escritura del archivo

        'escribiendo el contador para agregar mas empleados despues de cargados sin problemas
        '|
        '|
        'V
        '
        imprimir = ""
        '
        Using file As New IO.StreamWriter("C:\experimental\totalnumero.txt")
            file.Flush()
        End Using
        '
        imprimir = empleado
        '
        My.Computer.FileSystem.WriteAllText("C:\experimental\totalnumero.txt",
        imprimir, True)
        '
        'A
        '|
        '|
        'listo ya quedo el contador

        Form1.TextBox1.Text = ""
        Form1.TextBox2.Text = ""

        Form1.Show()
        Me.Hide()
    End Sub ' boton de Regresar, Guarda Todos los datos en los Archivos

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click


        Datos(empleado, 0) = TextBox1.Text
        Datos(empleado, 1) = TextBox2.Text
        Datos(empleado, 2) = ComboBox1.Text
        Datos(empleado, 3) = ComboBox2.Text
        Datos(empleado, 4) = 0
        Datos(empleado, 5) = 0
        Datos(empleado, 6) = 0
        Datos(empleado, 7) = pass
        Datos(empleado, 8) = 0




        empleado = empleado + 1
        pass = pass + 10



        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""

        Dim empleadoUBI As Integer
        Dim numempleado1, nombre1, horario1, pagohora1, retardos1, faltas1, horastrabajadas1, password1, total As String

        DataGridView2.Rows.Clear()

        For empleadoUBI = 0 To 9



            numempleado1 = Datos(empleadoUBI, 0)
            nombre1 = Datos(empleadoUBI, 1)
            horario1 = Datos(empleadoUBI, 2)
            pagohora1 = Datos(empleadoUBI, 3)
            retardos1 = Datos(empleadoUBI, 4)
            faltas1 = Datos(empleadoUBI, 5)
            horastrabajadas1 = Datos(empleadoUBI, 6)
            password1 = Datos(empleadoUBI, 7)
            total = Datos(empleadoUBI, 8)






            DataGridView2.Rows.Add(numempleado1, nombre1, horario1, pagohora1, retardos1, faltas1, horastrabajadas1, password1, total)

            numempleado1 = ""
            nombre1 = ""
            horario1 = ""
            pagohora1 = ""
            retardos1 = ""
            faltas1 = ""
            horastrabajadas1 = ""
            password1 = ""




        Next

    End Sub  ' Agregar Empleados Nuevos

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

        tolerancia = TextBox5.Text
        retardosparafaltas = TextBox6.Text
        pagoextra = NumericUpDown1.Value

    End Sub ' modificando variables de las operaciones


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        DataGridView1.Rows.Clear()

        Dim empleadoUBI As Integer
        Dim numempleado1, nombre1, horario1, pagohora1, retardos1, faltas1, horastrabajadas1, password1, total As String

        For empleadoUBI = 0 To 9



            numempleado1 = Datos(empleadoUBI, 0)
            nombre1 = Datos(empleadoUBI, 1)
            horario1 = Datos(empleadoUBI, 2)
            pagohora1 = Datos(empleadoUBI, 3)
            retardos1 = Datos(empleadoUBI, 4)
            faltas1 = Datos(empleadoUBI, 5)
            horastrabajadas1 = Datos(empleadoUBI, 6)
            password1 = Datos(empleadoUBI, 7)
            total = Datos(empleadoUBI, 8)

            If Datos(empleadoUBI, 4) <> 0 Then
                DataGridView1.Rows.Add(numempleado1, nombre1, horario1, pagohora1, retardos1, faltas1, horastrabajadas1, password1, total)

                numempleado1 = ""
                nombre1 = ""
                horario1 = ""
                pagohora1 = ""
                retardos1 = ""
                faltas1 = ""
                horastrabajadas1 = ""
                password1 = ""
                total = ""

            End If

            numempleado1 = ""
            nombre1 = ""
            horario1 = ""
            pagohora1 = ""
            retardos1 = ""
            faltas1 = ""
            horastrabajadas1 = ""
            password1 = ""
            total = ""

        Next
    End Sub ' Filtrar Retardos

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        DataGridView1.Rows.Clear()

        Dim empleadoUBI As Integer
        Dim numempleado1, nombre1, horario1, pagohora1, retardos1, faltas1, horastrabajadas1, password1, total As String

        For empleadoUBI = 0 To 9



            numempleado1 = Datos(empleadoUBI, 0)
            nombre1 = Datos(empleadoUBI, 1)
            horario1 = Datos(empleadoUBI, 2)
            pagohora1 = Datos(empleadoUBI, 3)
            retardos1 = Datos(empleadoUBI, 4)
            faltas1 = Datos(empleadoUBI, 5)
            horastrabajadas1 = Datos(empleadoUBI, 6)
            password1 = Datos(empleadoUBI, 7)
            total = Datos(empleadoUBI, 8)

            If Datos(empleadoUBI, 5) <> 0 Then
                DataGridView1.Rows.Add(numempleado1, nombre1, horario1, pagohora1, retardos1, faltas1, horastrabajadas1, password1, total)

                numempleado1 = ""
                nombre1 = ""
                horario1 = ""
                pagohora1 = ""
                retardos1 = ""
                faltas1 = ""
                horastrabajadas1 = ""
                password1 = ""
                total = ""

            End If

            numempleado1 = ""
            nombre1 = ""
            horario1 = ""
            pagohora1 = ""
            retardos1 = ""
            faltas1 = ""
            horastrabajadas1 = ""
            password1 = ""
            total = ""

        Next
    End Sub ' Filtrar Faltas

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        DataGridView1.Rows.Clear()

        Dim empleadoUBI As Integer
        Dim numempleado1, nombre1, horario1, pagohora1, retardos1, faltas1, horastrabajadas1, password1, total As String


        Dim media As Double
        For empleadoUBI = 0 To 9



            numempleado1 = Datos(empleadoUBI, 0)
            nombre1 = Datos(empleadoUBI, 1)
            horario1 = Datos(empleadoUBI, 2)
            pagohora1 = Datos(empleadoUBI, 3)
            retardos1 = Datos(empleadoUBI, 4)
            faltas1 = Datos(empleadoUBI, 5)
            horastrabajadas1 = Datos(empleadoUBI, 6)
            password1 = Datos(empleadoUBI, 7)
            total = Datos(empleadoUBI, 8)


            For index = 0 To 9

                media = media + Datos(index, 7)


            Next

            media = media / empleado

            If Datos(empleadoUBI, 8) > media Then
                DataGridView1.Rows.Add(numempleado1, nombre1, horario1, pagohora1, retardos1, faltas1, horastrabajadas1, password1, total)

                numempleado1 = ""
                nombre1 = ""
                horario1 = ""
                pagohora1 = ""
                retardos1 = ""
                faltas1 = ""
                horastrabajadas1 = ""
                password1 = ""
                total = ""

            End If

            numempleado1 = ""
            nombre1 = ""
            horario1 = ""
            pagohora1 = ""
            retardos1 = ""
            faltas1 = ""
            horastrabajadas1 = ""
            password1 = ""
            total = ""

        Next
    End Sub ' Filtrar mejores seldos


    Dim tolerancia As String
    Dim retardosparafaltas As String
    Dim pagoextra As Integer

    Dim Datos(10, 9) As String
    Dim empleado As String
    Dim pass As String = 10

    Public entradasalida(10, 3) As String




End Class