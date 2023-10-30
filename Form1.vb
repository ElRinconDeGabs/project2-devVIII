Public Class Form1

    Private pic_Nave As New Nave()
    Private pic_BDG As New BDG()

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Controls.Add(pic_Nave.imagen)
        Controls.Add(pic_BDG.imagen)
    End Sub

    Private Sub Tmr_nave_Tick(sender As Object, e As EventArgs) Handles Tmr_nave.Tick

        pic_Nave.Mover(pic_BDG)
    End Sub

    Private Sub btn_iniciar_Click(sender As Object, e As EventArgs) Handles Btn_Iniciar.Click

        Tmr_nave.Enabled = True
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        Select Case keyData
            Case Keys.Up
                pic_Nave.arriba()
            Case Keys.Down
                pic_Nave.abajo()
            Case Keys.Left
                pic_Nave.izquierda()
            Case Keys.Right
                pic_Nave.derecha()
        End Select
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
End Class
