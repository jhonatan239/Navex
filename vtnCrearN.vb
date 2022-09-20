Public Class vtnCrearN
    Private Sub btnImagen_Click(sender As Object, e As EventArgs) Handles btnImagen.Click
        If Me.OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            pbImagen.Image = Image.FromFile(OpenFileDialog1.FileName)
            pbImagen.Visible = True
        End If
    End Sub

    Private Sub vtnCrearN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        recargarVtn()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim n As New Nave
        Dim T As Control
        For Each T In Me.Controls
            If TypeOf T Is TextBox Then
                If Trim(T.Text) = "" Then
                    T.Text = "0"
                    'Else   
                    '    MessageBox.Show("Dot Net Perls is awesome.")
                End If
            Else
                ' mesagebox aqui hay otro control diferente de textbox

            End If
        Next


        n.id = lblId.Text
        n.nombre = txtnom.Text
        If cboxTipoNa.SelectedItem.ToString.Equals("") Then
            MsgBox("Seleccione un tipo de Nave")
            Exit Sub

        Else
            n.tipoDeNave = cboxTipoNa.SelectedItem

        End If


        n.empresa = txtEmpresa.Text
        n.tipoCombustible = txtTipoCom.Text

        n.potencia = txtPotencia.Text
        n.tipoDeCarga = txtTipoCarg.Text
        n.pais = txtPais.Text
        n.peso = txtPeso.Text
        n.capDeCarga = txtCapCarg.Text
        n.altura = txtAltura.Text
        n.toneEmpuje = txtTonEmp.Text
        n.funcion = txtFuncion.Text
        n.capDePersonas = txtCapPer.Text

        If OpenFileDialog1.FileName <> "" And OpenFileDialog1.FileName <> "OpenFileDialog1" Then

            Dim s As String
            n.imagen = OpenFileDialog1.FileName
            s = n.imagen
            pbImagen.ImageLocation = OpenFileDialog1.FileName
            n.imagen = s.Replace("\", "-")
        Else
            n.imagen = ""

        End If


        If n.buscarXid(n.id, "naves") Then
            n.modificar_Nave(n)
            recargarVtn()

        Else

            n.guardar_Nave(n)
            recargarVtn()

        End If

    End Sub

    Private Sub btnEditarTipo_Click(sender As Object, e As EventArgs) Handles btnEditarTipo.Click
        Dim tn As TipoNave

        Try
            tn = cboxTipoNa.SelectedItem
            vtnTipoNave.Show()
            vtnTipoNave.lblId.Text = tn.id
            vtnTipoNave.txtNom.Text = tn.nombre
            vtnTipoNave.btnGuar.Text = "Actualizar"
            vtnTipoNave.btnEliminar.Visible = True
        Catch ex As Exception
            MsgBox("No seleccionaste un tipo de Nave a editar, puedes Crear uno nuevo si lo deseas.")
        End Try
    End Sub

    Public Sub recargarVtn()
        'Vamos a buscar el ultimo id y se le suma 1 en base a la table que le pasamos
        Dim tabla As String, ptn As New PersistenciaTipoNave
        tabla = "naves"
        lblId.Text = ptn.ultimoId(tabla) + 1

        'Cargamos el combo de tipos de naves
        Dim tn As New TipoNave, ListaTiposN As New ArrayList

        ListaTiposN = tn.Lista_TiposNaves
        For Each tn In ListaTiposN
            cboxTipoNa.Items.Add(tn)
        Next
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEditarEx.Click
        vtnBuscarN.Show()
        vtnBuscarN.btnEditNa.Visible = True
        btnEditarEx.Visible = True


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnElimin.Click

    End Sub
End Class