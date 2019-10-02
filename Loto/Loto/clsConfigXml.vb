Imports System.Xml.Serialization
Imports System.IO

Public Class clsConfigXml
    Public Property Server As String
    Public Property Password As String
    Public Property User As String
    Public Property Database As String

    Public Sub Guardar()
        Dim xmlSerial As XmlSerializer
        xmlSerial = New XmlSerializer(GetType(clsConfigXml))
        Dim writer As TextWriter = New StreamWriter("clsConfigXml.xml")
        xmlSerial.Serialize(writer, Me)
        writer.Close()
    End Sub

    Public Shared Function LeerInicial() As clsConfigXml
        ' Construct an instance of the XmlSerializer with the type of object that is being deserialized.
        Dim cfg As New clsConfigXml
        Dim mySerializer As XmlSerializer = New XmlSerializer(GetType(clsConfigXml))
        Dim myFileStream As FileStream

        If Not File.Exists("clsConfigXml.xml") Then
            myFileStream = New FileStream("clsConfigXml.xml", FileMode.OpenOrCreate)
        Else
            myFileStream = New FileStream("clsConfigXml.xml", FileMode.Open)
        End If

        If myFileStream.Length = 0 Then
            myFileStream.Close()
            Exit Function
        End If

        ' Call the Deserialize method and cast to the object type.
        cfg = CType(mySerializer.Deserialize(myFileStream), clsConfigXml)
        myFileStream.Close()
        Return cfg
    End Function

End Class
