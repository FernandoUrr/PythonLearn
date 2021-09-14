'Macros utilizadas en ERV para la automatización. Pendiente añadir comentarios para explicar cada uno
'Añadir una nueva opción a una lista:
Private Sub Add_Client()
Dim i As Integer
a = Worksheets("Formulario de Ingreso").Range("D10").Value
For i = 2 To 200 Step 1
    If (Worksheets("Formulario de Ingreso").Cells(i, 17).Value = Worksheets("Formulario de Ingreso").Range("D10").Value) Then
        k = MsgBox("La entidad " & a & " ya se encuentra registrada", vbOKOnly, "Alerta!!")
        i = 200
    Else
        If (Worksheets("Formulario de Ingreso").Cells(i, 17).Value = 0) Then
            Worksheets("Formulario de Ingreso").Cells(i, 17) = Worksheets("Formulario de Ingreso").Range("D10").Value
            k = MsgBox("Entidad de nombre: " & a & " registrada con éxito, ya puede registrar la solicitud", vbOKOnly, "")
            i = 200
        End If
    End If
Next
Range("Q1").Sort Key1:=Range("Q2"), Order1:=xlAscending
Range("D10").Select
Selection.ClearContents
Range("D10").Select
End Sub

'Para ingresar un nuevo registro:
Private Sub Add_new_record()
Dim i, j, k, n, y, z As Integer
k = 15
For i = 1 To 2000 Step 1
    If (Worksheets("BD-Solicitudes").Cells(i, 1).Value = "") Then
        For j = 1 To 36
            If (Worksheets("Formulario de Ingreso").Cells(k, 3).Value = Worksheets("BD-Solicitudes").Cells(1, j).Value) Then
                Worksheets("BD-Solicitudes").Cells(i, j) = Worksheets("Formulario de Ingreso").Cells(k, 4).Value
                k = k + 1
            End If
        Next
        l = MsgBox("Solicitud registrada con éxito" & i, vbOKOnly)
        i = 2000
    End If
Next
Range("D14:D39").Select
Selection.ClearContents
Range("D14").Select
End Sub

'Para traer un registro:
Private Sub Bring_record()
Dim i, j, k, l As Integer
k = 15
For i = 1 To 2000 Step 1
    If (Worksheets("Formulario de Ingreso").Range("D13").Value = Worksheets("BD-Solicitudes").Range("BE" & i).Value) Then
        For j = 1 To 36
            If (Worksheets("Formulario de Ingreso").Cells(k, 3).Value = Worksheets("BD-Solicitudes").Cells(1, j).Value) Then
                Worksheets("Formulario de Ingreso").Cells(k, 4) = Worksheets("BD-Solicitudes").Cells(i, j).Value
                k = k + 1
            End If
        Next
        l = MsgBox("Solicitud traída con éxito" & i, vbOKOnly)
        i = 2000
    End If
Next
End Sub

'Guardar definitivo una macro que esté creada
Private Sub Hard_Save()
Dim i, j, k As Integer
k = 15
For i = 1 To 2000 Step 1
    If (Worksheets("Formulario de Ingreso").Range("D13").Value = Worksheets("BD-Solicitudes").Range("BE" & i).Value) Then
        For j = 1 To 36
            If (Worksheets("Formulario de Ingreso").Cells(k, 3).Value = Worksheets("BD-Solicitudes").Cells(1, j).Value) Then
                Worksheets("BD-Solicitudes").Cells(i, j) = Worksheets("Formulario de Ingreso").Cells(k, 4).Value
                k = k + 1
            End If
        Next
        l = MsgBox("Solicitud guardada con éxito" & i, vbOKOnly)
        i = 2000
    End If
Next
Range("D14:D39").Select
Selection.ClearContents
Range("D14").Select
End Sub
