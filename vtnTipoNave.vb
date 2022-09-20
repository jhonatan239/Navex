Public Class vtnTipoNave

    Private Sub vtnTipoNave_Load_2(sender As Object, e As EventArgs) Handles MyBase.Load

        recargarVtn()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGuar.Click
        Dim tn As New TipoNave
        tn.id = lblId.Text
        tn.nombre = txtNom.Text

        If tn.buscarXid2(tn.id, "tipoNaves") Then
            tn.modificar_tipoNave(tn)
            recargarVtn()
            vtnCrearN.recargarVtn()
        Else
            tn.guardarTipoNave(tn)
            recargarVtn()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    'limpiamos y agregamos cargamos el id siguiente
    Public Sub recargarVtn()
        'Vamos a buscar el ultimo id y se le suma 1 en base a la table que le pasamos
        Dim tabla As String, ptn As New PersistenciaTipoNave
        tabla = "tiponaves"
        lblId.Text = ptn.ultimoId(tabla) + 1
        txtNom.Clear()
        btnEliminar.Visible = False
        btnGuar.Text = "Guardar"

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        recargarVtn()
    End Sub
End Class