Module Resultados

    Public Const sencilla_p = 400
    Public Const doble_p = 700
    Public Const compartida_p = 350
    Public Const sencilla_s = 375
    Public Const doble_s = 600
    Public Const compartida_s = 300

    Public index As Byte = 0
    Public nit(5) As Integer
    Public nombre(5) As String
    Public tipo_cabina(5) As String
    Public tipo_clase(5)
    Public no_personas(5) As Integer
    Public precioIn(5) As Double
    Public totalCal(5) As Double

    Sub Consultar(nit_con As Integer)
        Dim existe As Boolean = False
        For i = 0 To 5
            If nit(i) = nit_con Then
                existe = True
                Form1.txt_nit.Text = nit(i)
                Form1.txt_nombre.Text = nombre(i)
                Form1.txt_noPersonas.Text = no_personas(i)

                Select Case tipo_cabina(i)
                    Case "Sencilla"
                        Form1.cb_tipocabina.SelectedIndex = 0
                    Case "Doble"
                        Form1.cb_tipocabina.SelectedIndex = 1
                    Case "Compartida"
                        Form1.cb_tipocabina.SelectedIndex = 2
                End Select

                Select Case tipo_clase(i)
                    Case "Primera Clase"
                        Form1.cb_tipoclase.SelectedIndex = 0
                    Case "Segunda Clase"
                        Form1.cb_tipoclase.SelectedIndex = 1
                End Select

            End If
        Next i

        If existe = True Then
            MsgBox("Registro encontrado correctamente..")
        Else
            MsgBox("Registro no encontrado..")
        End If
    End Sub

    Sub Total()

        Select Case Form1.cb_tipocabina.SelectedIndex
            Case 0
                If Form1.cb_tipoclase.SelectedIndex = 0 Then
                    precioIn(index) = sencilla_p
                    totalCal(index) = Form1.txt_noPersonas.Text * sencilla_p
                ElseIf Form1.cb_tipoclase.SelectedIndex = 1 Then
                    precioIn(index) = sencilla_s
                    totalCal(index) = Form1.txt_noPersonas.Text * sencilla_s
                End If
            Case 1
                If Form1.cb_tipoclase.SelectedIndex = 0 Then
                    precioIn(index) = doble_p
                    totalCal(index) = Form1.txt_noPersonas.Text * doble_p
                ElseIf Form1.cb_tipoclase.SelectedIndex = 1 Then
                    precioIn(index) = doble_s
                    totalCal(index) = Form1.txt_noPersonas.Text * doble_s
                End If
            Case 2
                If Form1.cb_tipoclase.SelectedIndex = 0 Then
                    precioIn(index) = compartida_p
                    totalCal(index) = Form1.txt_noPersonas.Text * compartida_p
                ElseIf Form1.cb_tipoclase.SelectedIndex = 1 Then
                    precioIn(index) = compartida_s
                    totalCal(index) = Form1.txt_noPersonas.Text * compartida_s
                End If
        End Select

    End Sub

End Module
