Public Class TipoNave

    Private _id As Integer
    Private _nombre As String
    Public ptn As New PersistenciaTipoNave
    'Encapsulamos atributos
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Public Property nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    'creamos overrides sobre el atributo nombre
    Public Overrides Function ToString() As String
        Return nombre
    End Function

    Public Function buscarXid(id As Integer, tabla As String)
        Return ptn.tipoNaveXid(id)
    End Function
    Public Function buscarXid2(id As Integer, tabla As String)
        Return ptn.existeIdXtabla(id, tabla)
    End Function
    Public Sub guardarTipoNave(tn As TipoNave)
        ptn.guardar_tipoNave(tn)
    End Sub

    Public Sub modificar_tipoNave(tn As TipoNave)
        ptn.modificar_tipoNave(tn)
    End Sub

    Public Function Lista_TiposNaves() As ArrayList
        Dim listaTiposNaves As ArrayList
        listaTiposNaves = ptn.Lista_tiposNaves
        Return listaTiposNaves
    End Function
End Class
