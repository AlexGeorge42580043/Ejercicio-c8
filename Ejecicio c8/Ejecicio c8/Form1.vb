Public Class Form1
    Private Sub btEjecutar_Click(sender As Object, e As EventArgs) Handles btEjecutar.Click
        Dim a, n, suma, amayor, amenor As Integer
        n = 0
        a = InputBox("Escribir numero a sumar", "Ejercicio c8", 0)
        amayor = a
        amenor = a
        If a <> -999 Then
            suma = a
            Do
                a = InputBox("Escribir numero a sumar", "Ejercicio c8", 0)
                If a <> -999 Then
                    suma = suma + a
                    If amenor > a Then
                        amenor = a
                    End If
                End If
                If amayor < a Then
                    amayor = a
                End If
            Loop Until a = -999
        Else
            suma = a
        End If
        lblMostrarMayor.Text = "" & amayor
        lblMostrarMenor.Text = "" & amenor
        lblMostrarSuma.Text = "" & suma
    End Sub
End Class
