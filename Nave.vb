Public Class Nave

    Private _id As Integer
    Private _tipoDeNave As TipoNave
    Private _nombre As String
    Private _potencia As Integer
    Private _tipoDeCarga As String
    Private _tipoCombustible As String
    Private _empresa As String
    Private _pais As String
    Private _peso As Double
    Private _capDeCarga As Integer
    Private _altura As Double
    Private _toneEmpuje As Double
    Private _imagen As String
    Private _funcion As String
    Private _capDePersonas As Integer
    Public pn As New PersistenciaNave

    'creamos overrides sobre el atributo nombre
    Public Overrides Function ToString() As String
        Return nombre
    End Function

    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Public Property tipoDeNave() As TipoNave
        Get
            Return _tipoDeNave
        End Get
        Set(ByVal value As TipoNave)
            _tipoDeNave = value
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

    Public Property potencia() As Integer
        Get
            Return _potencia
        End Get
        Set(ByVal value As Integer)
            _potencia = value
        End Set
    End Property

    Public Property tipoDeCarga() As String
        Get
            Return _tipoDeCarga
        End Get
        Set(ByVal value As String)
            _tipoDeCarga = value
        End Set
    End Property

    Public Property tipoCombustible() As String
        Get
            Return _tipoCombustible
        End Get
        Set(ByVal value As String)
            _tipoCombustible = value
        End Set
    End Property

    Public Property empresa() As String
        Get
            Return _empresa
        End Get
        Set(ByVal value As String)
            _empresa = value
        End Set
    End Property

    Public Property pais() As String
        Get
            Return _pais
        End Get
        Set(ByVal value As String)
            _pais = value
        End Set
    End Property

    Public Property peso() As Double
        Get
            Return _peso
        End Get
        Set(ByVal value As Double)
            _peso = value
        End Set
    End Property

    Public Property altura() As Double
        Get
            Return _altura
        End Get
        Set(ByVal value As Double)
            _altura = value
        End Set
    End Property

    Public Property capDeCarga() As Integer
        Get
            Return _capDeCarga
        End Get
        Set(ByVal value As Integer)
            _capDeCarga = value
        End Set
    End Property

    Public Property toneEmpuje() As Double
        Get
            Return _toneEmpuje
        End Get
        Set(ByVal value As Double)
            _toneEmpuje = value
        End Set
    End Property

    Public Property imagen() As String
        Get
            Return _imagen
        End Get
        Set(ByVal value As String)
            _imagen = value
        End Set
    End Property

    Public Property funcion() As String
        Get
            Return _funcion
        End Get
        Set(ByVal value As String)
            _funcion = value
        End Set
    End Property

    Public Property capDePersonas() As Integer
        Get
            Return _capDePersonas
        End Get
        Set(ByVal value As Integer)
            _capDePersonas = value
        End Set
    End Property


    Public Sub guardar_Nave(n As Nave)
        pn.guardar_Nave(n)
    End Sub

    Public Sub modificar_Nave(n As Nave)
        pn.modificar_nave(n)
    End Sub

    Public Function buscarXid(id As Integer, tabla As String)
        Return pn.existeIdXtabla(id, tabla)
    End Function

    Public Function listarXParametros(nom As String)
        Dim lista As New ArrayList
        lista = pn.ListaNaveXnombre(nom)
        Return lista

    End Function


    Public Overloads Function listarXcolumVal(tabla As String, val As String)
        Dim lista As New ArrayList
        lista = pn.ListaNaveXColumVal(tabla, val)
        Return lista
    End Function

    Public Overloads Function listarXcolumVal(colum As String, val1 As Integer, val2 As Integer)
        Dim lista As New ArrayList
        lista = pn.ListaNaveXcolumVal(colum, val1, val2)
        Return lista
    End Function
End Class
