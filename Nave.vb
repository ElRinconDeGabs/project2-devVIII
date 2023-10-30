Public Class Nave

    Private _imagen As PictureBox

    Public Sub New()
        _imagen = New PictureBox
        _imagen.Size = New Size(50, 50)
        _imagen.Location = New Point(100, 100)
        _imagen.Image = Image.FromFile("C:\Users\yeyoe\OneDrive - Universidad Tecnológica de Panamá\DDS8\ILS231_SAMANIEGO_2210_PROY2\Nave.png")
        _imagen.BackgroundImage = Image.FromFile("C:\Users\yeyoe\OneDrive - Universidad Tecnológica de Panamá\DDS8\ILS231_SAMANIEGO_2210_PROY2\BDG.jpeg")
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

    Private _x As Integer
    Private Property x As Integer
        Get
            _x = _imagen.Location.X
            Return _x
        End Get
        Set(value As Integer)
            _x = value
        End Set
    End Property
    Private _y As Integer
    Public Property y As Integer
        Get
            _y = _imagen.Location.Y
            Return _y
        End Get
        Set(value As Integer)
            _y = value
        End Set
    End Property

    Private _dirx As Integer
    Public Property dirx As Integer
        Get
            Return _dirx
        End Get
        Set(value As Integer)
            _dirx = value
        End Set
    End Property

    Private _diry As Integer
    Public Property diry As Integer
        Get
            Return _diry
        End Get
        Set(value As Integer)
            _diry = value
        End Set
    End Property

    Public Sub arriba()
        diry -= 1
    End Sub
    Public Sub abajo()
        diry += 1
    End Sub
    Public Sub izquierda()
        dirx -= 1
    End Sub
    Public Sub derecha()
        dirx += 1
    End Sub

    Public Sub Mover(bdg As BDG)
        If y <= bdg.imagen.Location.Y Then
            diry = Math.Abs(diry) ' Rebotar hacia abajo
        End If
        If y + imagen.Height >= bdg.imagen.Location.Y + bdg.imagen.Height Then
            diry = -Math.Abs(diry) ' Rebotar hacia arriba
        End If
        If x <= bdg.imagen.Location.X Then
            dirx = Math.Abs(dirx) ' Rebotar hacia la derecha
        End If
        If x + imagen.Width >= bdg.imagen.Location.X + bdg.imagen.Width Then
            dirx = -Math.Abs(dirx) ' Rebotar hacia la izquierda
        End If
        _imagen.Location = New Point(x + dirx, y + diry)

        If diry < 0 And dirx = 0 Then
            _imagen.Image = Image.FromFile("C:\Users\yeyoe\OneDrive - Universidad Tecnológica de Panamá\DDS8\ILS231_SAMANIEGO_2210_PROY2\Nave.png")
            _imagen.BackgroundImage = Image.FromFile("C:\Users\yeyoe\OneDrive - Universidad Tecnológica de Panamá\DDS8\ILS231_SAMANIEGO_2210_PROY2\BDG.jpeg")
        End If

        If diry > 0 And dirx = 0 Then
            _imagen.Image = Image.FromFile("C:\Users\yeyoe\OneDrive - Universidad Tecnológica de Panamá\DDS8\ILS231_SAMANIEGO_2210_PROY2\N2_Abajo.png")
            _imagen.BackgroundImage = Image.FromFile("C:\Users\yeyoe\OneDrive - Universidad Tecnológica de Panamá\DDS8\ILS231_SAMANIEGO_2210_PROY2\BDG.jpeg")
        End If

        If dirx < 0 And diry = 0 Then
            _imagen.Image = Image.FromFile("C:\Users\yeyoe\OneDrive - Universidad Tecnológica de Panamá\DDS8\ILS231_SAMANIEGO_2210_PROY2\N4_Izquierda.png")
            _imagen.BackgroundImage = Image.FromFile("C:\Users\yeyoe\OneDrive - Universidad Tecnológica de Panamá\DDS8\ILS231_SAMANIEGO_2210_PROY2\BDG.jpeg")
        End If

        If dirx > 0 And diry = 0 Then
            _imagen.Image = Image.FromFile("C:\Users\yeyoe\OneDrive - Universidad Tecnológica de Panamá\DDS8\ILS231_SAMANIEGO_2210_PROY2\N3_Derecha.png")
            _imagen.BackgroundImage = Image.FromFile("C:\Users\yeyoe\OneDrive - Universidad Tecnológica de Panamá\DDS8\ILS231_SAMANIEGO_2210_PROY2\BDG.jpeg")
        End If

        If diry < 0 And dirx > 0 Then
            _imagen.Image = Image.FromFile("C:\Users\yeyoe\OneDrive - Universidad Tecnológica de Panamá\DDS8\ILS231_SAMANIEGO_2210_PROY2\N5_ADerecha.png")
            _imagen.BackgroundImage = Image.FromFile("C:\Users\yeyoe\OneDrive - Universidad Tecnológica de Panamá\DDS8\ILS231_SAMANIEGO_2210_PROY2\BDG.jpeg")
        End If

        If diry < 0 And dirx < 0 Then
            _imagen.Image = Image.FromFile("C:\Users\yeyoe\OneDrive - Universidad Tecnológica de Panamá\DDS8\ILS231_SAMANIEGO_2210_PROY2\N6_AIzquierda.png")
            _imagen.BackgroundImage = Image.FromFile("C:\Users\yeyoe\OneDrive - Universidad Tecnológica de Panamá\DDS8\ILS231_SAMANIEGO_2210_PROY2\BDG.jpeg")
        End If

        If diry > 0 And dirx > 0 Then
            _imagen.Image = Image.FromFile("C:\Users\yeyoe\OneDrive - Universidad Tecnológica de Panamá\DDS8\ILS231_SAMANIEGO_2210_PROY2\N7_AbDerecha.png")
            _imagen.BackgroundImage = Image.FromFile("C:\Users\yeyoe\OneDrive - Universidad Tecnológica de Panamá\DDS8\ILS231_SAMANIEGO_2210_PROY2\BDG.jpeg")
        End If

        If diry > 0 And dirx < 0 Then
            _imagen.Image = Image.FromFile("C:\Users\yeyoe\OneDrive - Universidad Tecnológica de Panamá\DDS8\ILS231_SAMANIEGO_2210_PROY2\N8_AbIzquierda.png")
            _imagen.BackgroundImage = Image.FromFile("C:\Users\yeyoe\OneDrive - Universidad Tecnológica de Panamá\DDS8\ILS231_SAMANIEGO_2210_PROY2\BDG.jpeg")
        End If

    End Sub

End Class
