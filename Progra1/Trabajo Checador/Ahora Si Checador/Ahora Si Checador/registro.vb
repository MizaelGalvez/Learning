Public Class registro

    Private Sub registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' llenado del datagrid registro pormedio de un arreglo bidimencional
        '|
        '|
        'V

        Dim empleadoUBI As Integer
        Dim numempleado, horaentrada, horasalida As String

        DataGridView2.Rows.Clear()

        For empleadoUBI = 0 To 9

            numempleado = admin.entradasalida(empleadoUBI, 0)
            horaentrada = admin.entradasalida(empleadoUBI, 1)
            horasalida = admin.entradasalida(empleadoUBI, 2)

            DataGridView2.Rows.Add(numempleado, horaentrada, horasalida)

            numempleado = ""
            horaentrada = ""
            horasalida = ""

        Next

        'A
        '|
        '|
        'aqui termina la escritura


    End Sub ' llena los tada grid conforme a entradas y salidas.

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Form1.GroupBox1.Show()
        Form1.GroupBox2.Hide()

        Form1.Show()
        Me.Hide()

    End Sub ' botton regresar cambia las vistas

End Class