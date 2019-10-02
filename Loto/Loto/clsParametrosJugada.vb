Imports System.Xml.Serialization
Imports System.IO

Public Class clsParametrosJugada
    Private _NumMasFrecuente1, _NumMasFrecuente2, _NumMasFrecuente3 As SByte
    Private _CantPares As Byte
    Private _TerminacionParaDosNum As SByte
    Private _NumSorteoAnterior As SByte
    Private _CantNumUnSoloDigito As Byte
    Private _AlmenosDosNumConsec As Boolean
    Private _SumatoriaMinima As Byte
    Private _SumatoriaMaxima As Byte
    Private _DifEntreConsecutivosMin As Byte
    Private _DifEntreConsecutivosMax As Byte
    Private _CantMinimaPrimos As SByte
    Private _NumExcluido1, _NumExcluido2, _NumExcluido3 As SByte

    Public Property NumMasFrecuente1() As SByte
        Get
            NumMasFrecuente1 = _NumMasFrecuente1
        End Get
        Set(ByVal value As SByte)
            _NumMasFrecuente1 = value
        End Set
    End Property

    Public Property NumMasFrecuente2() As SByte
        Get
            NumMasFrecuente2 = _NumMasFrecuente2
        End Get
        Set(ByVal value As SByte)
            _NumMasFrecuente2 = value
        End Set
    End Property

    Public Property NumMasFrecuente3() As SByte
        Get
            NumMasFrecuente3 = _NumMasFrecuente3
        End Get
        Set(ByVal value As SByte)
            _NumMasFrecuente3 = value
        End Set
    End Property

    Public Property CantPares As Byte
        Get
            CantPares = _CantPares
        End Get
        Set(ByVal value As Byte)
            _CantPares = value
        End Set
    End Property

    Public Property TerminacionParaDosNum As SByte
        Get
            TerminacionParaDosNum = _TerminacionParaDosNum
        End Get
        Set(ByVal value As SByte)
            _TerminacionParaDosNum = value
        End Set
    End Property

    Public Property NumSorteoAnterior As SByte
        Get
            Return _NumSorteoAnterior
        End Get
        Set(ByVal value As SByte)
            _NumSorteoAnterior = value
        End Set
    End Property

    Public Property CantNumUnSoloDigito As Byte
        Get
            Return _CantNumUnSoloDigito
        End Get
        Set(ByVal value As Byte)
            _CantNumUnSoloDigito = value
        End Set
    End Property

    Public Property AlmenosDosNumConsec As Boolean
        Get
            Return _AlmenosDosNumConsec
        End Get
        Set(ByVal value As Boolean)
            _AlmenosDosNumConsec = value
        End Set
    End Property

    Public Property SumatoriaMinima As Byte
        Get
            Return _SumatoriaMinima
        End Get
        Set(ByVal value As Byte)
            _SumatoriaMinima = value
        End Set
    End Property

    Public Property SumatoriaMaxima As Byte
        Get
            Return _SumatoriaMaxima
        End Get
        Set(ByVal value As Byte)
            _SumatoriaMaxima = value
        End Set
    End Property

    Public Property DifEntreConsecutivosMin As Byte
        Get
            Return _DifEntreConsecutivosMin
        End Get
        Set(ByVal value As Byte)
            _DifEntreConsecutivosMin = value
        End Set
    End Property

    Public Property DifEntreConsecutivosMax As Byte
        Get
            Return _DifEntreConsecutivosMax
        End Get
        Set(ByVal value As Byte)
            _DifEntreConsecutivosMax = value
        End Set
    End Property

    Public Property CantMinimaPrimos As SByte
        Get
            Return _CantMinimaPrimos
        End Get
        Set(ByVal value As SByte)
            _CantMinimaPrimos = value
        End Set
    End Property

    Public Property NumExcluido1() As SByte
        Get
            Return _NumExcluido1
        End Get
        Set(ByVal value As SByte)
            _NumExcluido1 = value
        End Set
    End Property

    Public Property NumExcluido2() As SByte
        Get
            Return _NumExcluido2
        End Get
        Set(ByVal value As SByte)
            _NumExcluido2 = value
        End Set
    End Property

    Public Property NumExcluido3() As SByte
        Get
            Return _NumExcluido3
        End Get
        Set(ByVal value As SByte)
            _NumExcluido3 = value
        End Set
    End Property

    Public Sub Guardar()
        Dim xmlSerial As XmlSerializer
        xmlSerial = New XmlSerializer(GetType(clsParametrosJugada))
        Dim writer As TextWriter = New StreamWriter("clsParametrosJugada.xml")
        xmlSerial.Serialize(writer, Me)
        writer.Close()
    End Sub

    Public Shared Function Leer() As clsParametrosJugada
        ' Construct an instance of the XmlSerializer with the type of object that is being deserialized.
        Dim cfg As New clsParametrosJugada
        Dim mySerializer As XmlSerializer = New XmlSerializer(GetType(clsParametrosJugada))
        Dim myFileStream As FileStream  '--> To read the file, create a FileStream.
        Dim myFileStreamCreado As Boolean

        If Not File.Exists("clsParametrosJugada.xml") Then
            cfg = Nothing
        Else
            myFileStream = New FileStream("clsParametrosJugada.xml", FileMode.Open)
            myFileStreamCreado = True
        End If

        If myFileStream.Length = 0 Then
            cfg = Nothing
        Else
            ' Call the Deserialize method and cast to the object type.
            cfg = CType(mySerializer.Deserialize(myFileStream), clsParametrosJugada)
        End If

        If myFileStreamCreado Then myFileStream.Close()
        Return cfg
    End Function

    Public Sub New()
        '_listaExcluidos.Clear()
    End Sub
End Class
