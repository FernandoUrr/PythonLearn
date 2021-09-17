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

'Esta macro va a actualizar el formato de acuerdo con lo se especifique en la condición negativa, es decir en el Else

Private Sub Worksheet_Change(ByVal Target As Range)
    If Application.Intersect(Target, Range("G13")) Is Nothing Then
        Exit Sub
    Else
        a = "Etapa 2: Parametrización Conjunta"
        b = "Etapa 4: Cargue de información"
        c = "Etapa 6: Socialización y capacitación"
        d = Target.Value

        If (d = a) Or (d = b) Or (d = c) Then
            For i = 24 To 27
                Worksheets("Control de Etapas").Rows(i).Hidden = True
            Next
        Else
            For i = 24 To 27
                Worksheets("Control de Etapas").Rows(i).Hidden = False
            Next
        End If
    End If
End Sub

'Este es uno con mejores actualizaciones, capaz de mejorar
'El Keyword Call es capaz de llamar una macro la cual estará explicada más debajo
Private Sub Worksheet_Change(ByVal Target As Range)
If Application.Intersect(Target, Range("I15")) Is Nothing Then
    Exit Sub
Else
    e = "Etapa 1: Evaluación AS IS y definición TO BE de Procedimientos, instructivos y perfiles"
    a = "Etapa 2: Parametrización Conjunta"
    n = "Etapa 3: Pruebas de parametrización"
    b = "Etapa 4: Cargue de información"
    l = "Etapa 5: Actualización de documentos: Procedimientos, instructivos, anexos y perfiles"
    c = "Etapa 6: Socialización y capacitación"
    d = Target.Value

    If (d = l) Or (d = a) Then
        For i = 24 To 31
            Worksheets("Control de Etapas").Rows(i).Hidden = False
        Next
        For i = 26 To 31
            Worksheets("Control de Etapas").Rows(i).Hidden = True
        Next
        Range("G20:M31").Select
        Selection.ClearContents
        Range("I15").Select
        Call Bring_Information
    Else
        If (d = b) Or (d = c) Then
            For i = 24 To 31
                Worksheets("Control de Etapas").Rows(i).Hidden = False
            Next
            For i = 24 To 31
                Worksheets("Control de Etapas").Rows(i).Hidden = True
            Next
            Range("G20:M31").Select
            Selection.ClearContents
            Range("I15").Select
            Call Bring_Information
        Else
            If (d = n) Then
                For i = 24 To 31
                    Worksheets("Control de Etapas").Rows(i).Hidden = False
                Next
                For i = 30 To 31
                    Worksheets("Control de Etapas").Rows(i).Hidden = True
                Next
                Range("G20:M31").Select
                Selection.ClearContents
                Range("I15").Select
                Call Bring_Information
            Else
                For i = 24 To 31
                    Worksheets("Control de Etapas").Rows(i).Hidden = False
                Next
                Range("G20:M31").Select
                Selection.ClearContents
                Range("I15").Select
                Call Bring_Information
            End If
        End If
    End If
End If
End Sub

'Macro de Bring_Information
'Se elimina el keyword de Private para que sea una clase bastante ksual

Sub Bring_Information()
conc = Worksheets("Control de Etapas").Range("K13").Value
'Actualizando las observaciones por actividad
For i = 2 To 1000
    If conc = Worksheets("BD Proyecto").Cells(i, 1).Value Then
        k = 20
        For j = 17 To 22 Step 1
            Worksheets("Control de Etapas").Range("l" & k) = Worksheets("BD Proyecto").Cells(i, j).Value
        Next
        k = 20
        For j = 23 To 28 Step 1
            Worksheets("Control de Etapas").Range("G" & k) = Worksheets("BD Proyecto").Cells(i, j).Value
            k = k + 2
            'm = MsgBox("Si vas por good way", vbOKOnly, "Yuju")
        Next
        Worksheets("Control de Etapas").Range("D38") = Worksheets("BD Proyecto").Cells(i, 30).Value
    End If
Next
End Sub






'Este que sigue es uno más personalizado, es el botón de actualizar
Private Sub UpdateInfo_Click()
If Worksheets("Control de Etapas").Range("C15").Value = "" Or Worksheets("Control de Etapas").Range("I15").Value = "" Then
    m = MsgBox("Por favor seleccione una etapa válida", vbOKOnly, "Grave Error")
    conc = Worksheets("Control de Etapas").Range("K13").Value
    'Actualizando las observaciones por actividad
Else
    a = MsgBox("¿Completamente seguro de que quiere actualizar esta etapa?", vbYesNo, "OJO!!!")
    If a = vbYes Then
    For i = 2 To 1000
        If conc = Worksheets("BD Proyecto").Cells(i, 1).Value Then
            k = 20
            For j = 17 To 22 Step 1
                Worksheets("BD Proyecto").Cells(i, j) = Worksheets("Control de Etapas").Range("l" & k).Value
            Next
            k = 20
            For j = 23 To 28 Step 1
                Worksheets("BD Proyecto").Cells(i, j) = Worksheets("Control de Etapas").Range("G" & k).Value
                k = k + 2
                'm = MsgBox("Si vas por good way", vbOKOnly, "Yuju")
            Next
            Worksheets("Control de Etapas").Range("D38") = Worksheets("BD Proyecto").Cells(i, 30).Value
        End If
    Next
    End If
End If
End Sub