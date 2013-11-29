Public Class Form1


    Public posicion As Integer = 0

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Label1.Text = DateTime.Now.ToShortTimeString


    End Sub ' muestra la hora del sistema en el label

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim saludo As String
        Dim letras() As Char



        ' Label1.Text = DateTime.Now.ToShortTimeString()



        letras = Label1.Text.ToCharArray
        saludo = letras(6) + letras(8)



        If saludo = "pm" Then
            saludo = "Muy Buenas Tardes :)"

        Else : saludo = "Buenos Dias Empleado jaja :)"
        End If

        Label2.Text = saludo


    End Sub ' al cargar muestra las vistas correctamente

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click



        admin.entradasalida(posicion, 0) = TextBox1.Text
        admin.entradasalida(posicion, 1) = Label1.Text

        posicion = posicion + 1

        MsgBox("Adelante que tenga una Buena Jornada :)")
        GroupBox1.Show()
        GroupBox2.Hide()

        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub ' agrega a entradasysalidas al numero de empleado y 

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click



        For i As Integer = 0 To 9

            If TextBox1.Text = admin.entradasalida(i, 0) Then

                admin.entradasalida(i, 2) = Label1.Text

            End If

        Next

        MsgBox("Descanza, nos Vemos Mañana :)")
        GroupBox1.Show()
        GroupBox2.Hide()

        TextBox1.Text = ""
        TextBox2.Text = ""

    End Sub ' agrega a entradasysalidas la salida del usuario encontrado

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click




        Dim Contrasena As String
        Dim Usuario As String
        Dim archivo As String
        Dim letras() As Char
        Dim validar(30) As String

        'mira es para los usuarios, ni te metas aqui jajaja

        Usuario = TextBox1.Text
        Contrasena = TextBox2.Text
        archivo = My.Computer.FileSystem.ReadAllText("C:/experimental/empleados.txt")
        letras = archivo.ToCharArray


        'hice el arreglo infinito jajaja de char para sacar cada palabra de los usuario

        Dim j As Integer = 0
        For i As Integer = 0 To letras.Length - 1


            If letras(i) <> " " Then

                validar(j) = validar(j) + letras(i)

            Else : j = j + 1

            End If

        Next

        'ya que se hicieron las palabra aqui devajo hago la validacion de la contrase;a, 

        For i As Integer = 0 To validar.Length - 1

            If Usuario = validar(i) Then

                i = i + 1 'le sumo uno al contadorpor que la siguente palabra es la contrase;a, y como ya coincidio con el usuario no ay pierde

                If Usuario = "admin" And Contrasena = validar(i) Then 'valido si el usuario es admin para dirijir a esa vista, ovio confirmo contrase;a

                    admin.Show()
                    Me.Hide()



                ElseIf Contrasena = validar(i) Then 'solo confirmo contrase;a pues el usario ya quedo, dirijo a la vista de usuario

                    GroupBox2.Show()
                    GroupBox1.Hide()

                End If


            End If
        Next





        Button3.Enabled = False
        Button2.Enabled = True

        Label5.Text = "Muy Buen Dia !!! Disfrutalo Trabajando"

        For i As Integer = 0 To 9

            If TextBox1.Text = admin.entradasalida(i, 0) Then

                Label5.Text = "Descanza Compañero nos vemos Mañana"

                Button3.Enabled = True
                Button2.Enabled = False


            End If

        Next



    End Sub ' verificasion de usuario y contraseña, y validacion si ya entro

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        registro.Show()
        Me.Hide()



    End Sub 'vista del registro que ay en el sistema antes di aplicar el dia

End Class
