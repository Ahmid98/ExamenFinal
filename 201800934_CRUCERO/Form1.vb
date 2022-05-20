Public Class Form1
    Private Sub OPCION1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OPCION1ToolStripMenuItem.Click

        If index < 6 Then
            If txt_nit.Text <> Nothing Then
                nit(index) = Val(txt_nit.Text)
            Else
                MsgBox("Debe ingresar el numero de NIT..")
            End If

            If txt_nombre.Text <> Nothing Then
                nombre(index) = txt_nombre.Text
            Else
                MsgBox("Debe ingresar un nombre..")
            End If

            If txt_noPersonas.Text <> Nothing Then
                no_personas(index) = Val(txt_noPersonas.Text)
            Else
                MsgBox("Debe ingresar el numero de personas..")
            End If

            If cb_tipocabina.SelectedIndex <> -1 Then
                tipo_cabina(index) = cb_tipocabina.Text
            Else
                MsgBox("Debe seleccionar un tipo de cabina..")
            End If

            If cb_tipoclase.SelectedIndex <> -1 Then
                tipo_clase(index) = cb_tipoclase.Text
            Else
                MsgBox("Debe seleccionar un tipo de clase..")
            End If

            Resultados.Total()


            tabla.Rows.Clear()
            tabla.Rows.Add(nit(index), nombre(index), no_personas(index), tipo_cabina(index), tipo_clase(index), precioIn(index), totalCal(index))
            index += 1
        Else
            MsgBox("Ya no se pueden ingresar mas registros..")
        End If



    End Sub

    Private Sub CONSULTARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONSULTARToolStripMenuItem.Click
        Resultados.Consultar(txt_nitCon.Text)
    End Sub

    Private Sub MOSTRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOSTRARToolStripMenuItem.Click
        tabla.Rows.Clear()

        Dim i As Byte = 0

        While (i <= 5)

            If (nit(i) <> Nothing) Then
                tabla.Rows.Add(nit(i), nombre(i), no_personas(i), tipo_cabina(i), tipo_clase(i), precioIn(i), totalCal(i))
            Else
                Exit While
            End If
            i = i + 1
        End While
    End Sub

    Private Sub VectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VectoresToolStripMenuItem.Click
        Array.Clear(nit, 0, nit.Length)
        Array.Clear(nombre, 0, nombre.Length)
        Array.Clear(no_personas, 0, no_personas.Length)
        Array.Clear(tipo_cabina, 0, tipo_cabina.Length)
        Array.Clear(tipo_clase, 0, tipo_clase.Length)
        Array.Clear(precioIn, 0, precioIn.Length)
        Array.Clear(totalCal, 0, totalCal.Length)
        tabla.Rows.Clear()
        index = 0
    End Sub

    Private Sub DatosDeEntradaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatosDeEntradaToolStripMenuItem.Click
        txt_nit.Clear()
        txt_nit.Focus()
        txt_nombre.Clear()
        txt_noPersonas.Clear()
        cb_tipocabina.SelectedIndex = -1
        cb_tipoclase.SelectedIndex = -1
        txt_nitCon.Clear()
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If MsgBox("Deseas salir", vbYesNo, "") = vbYes Then
            End
        End If
    End Sub

    Private Sub ORDENDESCENDENTEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ORDENDESCENDENTEToolStripMenuItem.Click
        Dim i As Byte
        Dim j As Byte
        Dim temp As String

        For i = 0 To 4
            For j = i + 1 To 5
                If nit(i) <> Nothing Then
                    If nit(i) < nit(j) Then
                        temp = nit(i)
                        nit(i) = nit(j)
                        nit(j) = temp
                        temp = nombre(i)
                        nombre(i) = nombre(j)
                        nombre(j) = temp
                        temp = tipo_cabina(i)
                        tipo_cabina(i) = tipo_cabina(j)
                        tipo_cabina(j) = temp
                        temp = tipo_clase(i)
                        tipo_clase(i) = tipo_clase(j)
                        tipo_clase(j) = temp
                        temp = no_personas(i)
                        no_personas(i) = no_personas(j)
                        no_personas(j) = temp
                        temp = precioIn(i)
                        precioIn(i) = precioIn(j)
                        precioIn(j) = temp
                        temp = totalCal(i)
                        totalCal(i) = totalCal(j)
                        totalCal(j) = temp
                    End If
                End If
            Next j
        Next i

        tabla.Rows.Clear()

        Dim x As Byte = 0

        While (x <= 5)

            If (nit(x) <> Nothing) Then
                tabla.Rows.Add(nit(x), nombre(x), no_personas(x), tipo_cabina(x), tipo_clase(x), precioIn(x), totalCal(x))
            Else
                Exit While
            End If
            x = x + 1
        End While
    End Sub
End Class
