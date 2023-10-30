Public Class BDG
    Private _imagen As PictureBox

    Public Sub New()
        _imagen = New PictureBox
        _imagen.Size = New Size(800, 450)
        _imagen.Location = New Point(20, 50)
        _imagen.Image = Image.FromFile("C:\Users\yeyoe\OneDrive - Universidad Tecnológica de Panamá\DDS8\ILS231_SAMANIEGO_2210_PROY2\BDG.jpeg")
        _imagen.SizeMode = PictureBoxSizeMode.StretchImage

    End Sub
    Public Property imagen As PictureBox
        Get
            Return _imagen
        End Get
        Set(value As PictureBox)
            _imagen = value
        End Set
    End Property
End Class
