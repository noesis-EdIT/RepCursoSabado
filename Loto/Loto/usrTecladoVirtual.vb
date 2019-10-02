Imports System.ComponentModel

Public Class usrTecladoVirtual
    Implements INotifyPropertyChanged
    Private vTeclaPulsada As String
    Private vVisible As Boolean

    Public Shared Function EnviarPulsacion() As Integer
        Dim resultado As Integer

        Return resultado
    End Function

    Public Property TeclaPulsada As String
        Get
            Return vTeclaPulsada
        End Get
        Set(ByVal value As String)
            vTeclaPulsada = value
            OnPropertyChanged("TeclaPulsada")
        End Set
    End Property

    Public Property Visible As Boolean
        Get
            Return vVisible
        End Get
        Set(ByVal value As Boolean)
            vVisible = value
        End Set
    End Property

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Protected Sub OnPropertyChanged(ByVal name As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(name))
    End Sub

    Private Sub btnCero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCero.Click
        TeclaPulsada = "0"
    End Sub

    Private Sub btnUno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUno.Click
        TeclaPulsada = "1"
    End Sub

    Private Sub btnDos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDos.Click
        TeclaPulsada = "2"
    End Sub

    Private Sub btnTres_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTres.Click
        TeclaPulsada = "3"
    End Sub

    Private Sub btnCuatro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuatro.Click
        TeclaPulsada = "4"
    End Sub

    Private Sub btnCinco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCinco.Click
        TeclaPulsada = "5"
    End Sub

    Private Sub btnSeis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeis.Click
        TeclaPulsada = "6"
    End Sub

    Private Sub btnSiete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiete.Click
        TeclaPulsada = "7"
    End Sub

    Private Sub btnOcho_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOcho.Click
        TeclaPulsada = "8"
    End Sub

    Private Sub btnNueve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNueve.Click
        TeclaPulsada = "9"
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        TeclaPulsada = "Cerrar"
    End Sub
End Class
