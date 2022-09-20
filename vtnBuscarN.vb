Public Class vtnBuscarN

    Private Sub vtnBuscarN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        recargarVtn()
    End Sub

    Public Sub recargarVtn()
        'Cargamos el combo de tipos de naves
        Dim tn As New TipoNave, ListaTiposN As New ArrayList
        ListaTiposN = tn.Lista_TiposNaves
        For Each tn In ListaTiposN
            cboxTipoN.Items.Add(tn)
        Next
        'Cargamos el combo de tipos de naves
        Dim n As New Nave, ListaN As New ArrayList

        ListaN = n.listarXParametros("")
        For Each n In ListaN
            lstNaves.Items.Add(n)
        Next
    End Sub

    Private Sub lstNaves_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstNaves.SelectedIndexChanged
        Dim n As New Nave
        n = lstNaves.SelectedItem

        lblId.Text = n.id
        lblNom.Text = n.nombre
        lblTipoN.Text = n.tipoDeNave.id
        lblEmp.Text = n.empresa
        lblPotencia.Text = n.potencia
        lblTipoCarga.Text = n.tipoDeCarga
        lblPais.Text = n.pais
        lblPeso.Text = n.peso
        lblCapCarg.Text = n.capDeCarga
        lblTipoCom.Text = n.tipoCombustible
        lblAlt.Text = n.altura
        lblTonEmp.Text = n.toneEmpuje
        lblCapPers.Text = n.capDePersonas
        lblFuncion.Text = n.funcion

        If n.imagen <> "" And n.imagen <> "OFDialog" Then
            pbImagen.Visible = True
            Dim s As String
            'prod.imagen = OFDialog.FileName
            s = n.imagen
            n.imagen = s.Replace("-", "\")
            pbImagen.Load(n.imagen)
        Else
            pbImagen.Visible = False

        End If
    End Sub

    Private Sub cboxTipoN_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxTipoN.SelectedIndexChanged

        'filtramos por tipo de nave si el RB es marcado y luego se selecciona un tipo de nave
        If cbCaracter.Checked = True Then
            busqueda()
        End If
    End Sub

    'Funcion de busqueda dondedonde pasamos parametros columna y valor dependiendo el filtro seleccionado
    Public Sub busqueda()
        Dim na As New Nave, listaNa As New ArrayList, tabla As String, val As String

        If rbTipoNave.Checked = True Then
            Dim tn2 As TipoNave
            tn2 = cboxTipoN.SelectedItem
            tabla = "tipoNave"
            val = tn2.id.ToString
        ElseIf rbNombre.Checked = True Then
            tabla = "nombre"
            val = txtNom.Text
        ElseIf rbPais.Checked = True Then
            tabla = "pais"
            val = txtPais.Text
        ElseIf rbEmpresa.Checked = True Then
            tabla = "empresa"
            val = txtEmpresa.Text
        Else
            MsgBox("Seleccione un tipo de filtro")
            Exit Sub
        End If

        lstNaves.Items.Clear()
        listaNa = na.listarXcolumVal(tabla, val)
        For Each na In listaNa
            lstNaves.Items.Add(na)
        Next
    End Sub

    Private Sub txtNom_TextChanged(sender As Object, e As EventArgs) Handles txtNom.TextChanged
        If cbCaracter.Checked = True Then
            busqueda()
        End If
    End Sub

    Private Sub txtPais_TextChanged(sender As Object, e As EventArgs) Handles txtPais.TextChanged
        If cbCaracter.Checked = True Then
            busqueda()
        End If
    End Sub

    Private Sub txtEmpresa_TextChanged(sender As Object, e As EventArgs) Handles txtEmpresa.TextChanged
        If cbCaracter.Checked = True Then
            busqueda()
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        busqueda()
    End Sub

    Private Sub btnBusquedaAv_Click(sender As Object, e As EventArgs) Handles btnBusquedaAv.Click
        busquedaAv()
    End Sub

    '<>
    Public Sub busquedaAv()
        Dim val1 As Integer, val2 As Integer, colum As String
        Dim na As New Nave, listaNa As New ArrayList

        If rbPotencia.Checked = True Then
            If txtPoMay.Text <> "" Or txtPoMe.Text <> "" Then
                colum = "potencia"

                If txtPoMay.Text <> "" Then
                    val1 = txtPoMay.Text
                Else
                    val1 = 0
                End If

                If txtPoMe.Text <> "" Then
                    val2 = txtPoMe.Text
                Else
                    val2 = 0
                End If

                listaNa = na.listarXcolumVal(colum, val1, val2)
                lstNaves.Items.Clear()

                For Each na In listaNa
                    lstNaves.Items.Add(na)
                Next

            End If

        ElseIf rbCapCarg.Checked = True Then
            If txtCapMay.Text <> "" Or txtCapMe.Text <> "" Then

                colum = "capacidadCarga"

                If txtCapMay.Text <> "" Then
                    val1 = txtCapMay.Text
                Else
                    val1 = 0
                End If
                If txtCapMe.Text <> "" Then
                    val2 = txtCapMe.Text
                Else
                    val2 = 0
                End If
                listaNa = na.listarXcolumVal(colum, val1, val2)
                lstNaves.Items.Clear()

                For Each na In listaNa
                    lstNaves.Items.Add(na)
                Next

            End If
        Else
            MsgBox("Seleccione un tipo de busqueda avanzada y cargue los datos")
        End If
    End Sub

    Private Sub btnEditNa_Click(sender As Object, e As EventArgs) Handles btnEditNa.Click
        Dim nav As New Nave, tna As New TipoNave
        nav = lstNaves.SelectedItem
        vtnCrearN.Show()

        vtnCrearN.lblId.Text = nav.id
        vtnCrearN.txtnom.Text = nav.nombre

        Dim i As Integer
        For i = 0 To vtnCrearN.cboxTipoNa.Items.Count - 1
            tna = vtnCrearN.cboxTipoNa.Items(i)
            If tna.id = nav.tipoDeNave.id Then
                vtnCrearN.cboxTipoNa.SelectedIndex() = i

            End If
        Next

        vtnCrearN.txtEmpresa.Text = nav.empresa
        vtnCrearN.txtPotencia.Text = nav.potencia
        vtnCrearN.txtTipoCarg.Text = nav.tipoDeCarga
        vtnCrearN.txtPais.Text = nav.pais
        vtnCrearN.txtPeso.Text = nav.peso
        vtnCrearN.txtCapCarg.Text = nav.capDeCarga
        vtnCrearN.txtAltura.Text = nav.altura
        vtnCrearN.txtTonEmp.Text = nav.toneEmpuje
        vtnCrearN.txtFuncion.Text = nav.funcion
        vtnCrearN.txtCapPer.Text = nav.capDePersonas
        If nav.imagen <> "" And nav.imagen <> "OFDialog" Then
            vtnCrearN.pbImagen.Visible = True
            Dim s As String
            'prod.imagen = OFDialog.FileName
            s = nav.imagen
            nav.imagen = s.Replace("-", "\")
            vtnCrearN.pbImagen.Load(nav.imagen)
        Else
            vtnCrearN.pbImagen.Visible = False

        End If

        vtnCrearN.btnEditarEx.Visible = True

        btnEditNa.Visible = False
        Me.Close()

    End Sub
End Class