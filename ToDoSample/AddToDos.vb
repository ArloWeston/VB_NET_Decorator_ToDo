
Imports ToDoSample

Public Interface IAddToDos
  Function RunMe(ByVal dataObj As AddToDosVals) As AddToDosVals
End Interface


Public Class AddToDosVals
  Public Sub New()
    ErrObj = New ErrorObj()
  End Sub
  Public Property ErrObj As ErrorObj
  Public Property DueDate As Date
  Public Property ToDoTask As String
End Class


Public Class GetDataFromTextBoxes
  Implements IAddToDos

  Private _dueDate As Date
  Private _toDo As String
  Private _runMeFirst As IAddToDos

  Public Sub New(ByVal dueDate As Date, ByVal toDo As String, ByRef runMeFirst As IAddToDos)
    _dueDate = dueDate
    _toDo = toDo
    _runMeFirst = runMeFirst
  End Sub

  Public Function RunMe(dataObj As AddToDosVals) As AddToDosVals Implements IAddToDos.RunMe

    If Not IsNothing(_runMeFirst) Then
      dataObj = _runMeFirst.RunMe(dataObj)
    End If

    If Not dataObj.ErrObj.HasError Then

      If Not _dueDate = Nothing AndAlso Not _toDo.Trim = String.Empty Then
        dataObj.DueDate = _dueDate
        dataObj.ToDoTask = _toDo
      Else
        dataObj.ErrObj.HasError = True
        dataObj.ErrObj.Message = "Invalid input values"
      End If

    End If

    Return dataObj

  End Function

End Class  'GetDataFromTextBoxes


Public Class WriteToDataGridView
  Implements IAddToDos

  Private _dgvToDo As DataGridView
  Private _runMeFirst As IAddToDos

  Public Sub New(ByRef dgvToDo1 As DataGridView, ByRef runMeFirst As IAddToDos)
    _dgvToDo = dgvToDo1
    _runMeFirst = runMeFirst
  End Sub

  Public Function RunMe(dataObj As AddToDosVals) As AddToDosVals Implements IAddToDos.RunMe

    If Not IsNothing(_runMeFirst) Then
      dataObj = _runMeFirst.RunMe(dataObj)
    End If

    If Not dataObj.ErrObj.HasError Then

      Dim nRow As New DataGridViewRow()
      nRow.CreateCells(_dgvToDo)
      nRow.Cells(1).Value = dataObj.DueDate.ToShortDateString()
      nRow.Cells(2).Value = dataObj.ToDoTask
      _dgvToDo.Rows.Add(nRow)

    End If

    Return dataObj

  End Function

End Class  'WriteToDataGridView


Public Class SortDataGridViewByDate
  Implements IAddToDos


  Private _dgvToDo As DataGridView
  Private _runMeFirst As IAddToDos

  Public Sub New(ByRef dgvToDo1 As DataGridView, ByRef runMeFirst As IAddToDos)
    _dgvToDo = dgvToDo1
    _runMeFirst = runMeFirst
  End Sub

  Public Function RunMe(dataObj As AddToDosVals) As AddToDosVals Implements IAddToDos.RunMe

    If Not IsNothing(_runMeFirst) Then
      dataObj = _runMeFirst.RunMe(dataObj)
    End If

    If Not dataObj.ErrObj.HasError Then

      _dgvToDo.Sort(New DgvToDoComparer())

    End If

    Return dataObj

  End Function

  Private Class DgvToDoComparer
    Implements System.Collections.IComparer

    Public Sub New()

    End Sub

    Public Function Compare(x As Object, y As Object) As Integer Implements IComparer.Compare
      Dim compareResult As Integer = 0
      Try

        Dim xDate As Date = Date.ParseExact(x.cells(1).value, "M/d/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)
        Dim yDate As Date = Date.ParseExact(y.cells(1).value, "M/d/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)

        If xDate > yDate Then
          compareResult = 1
        Else
          compareResult = -1
        End If

      Catch ex As Exception
        compareResult = 0
      End Try

      Return compareResult

    End Function

  End Class

End Class  'SortDataGridViewByDate




Public Class AlertOnError
  Implements IAddToDos

  Private _currForm As Form1
  Private _runMeFirst As IAddToDos

  Public Sub New(ByRef currForm As Form1, ByRef runMeFirst As IAddToDos)
    _currForm = currForm
    _runMeFirst = runMeFirst
  End Sub

  Public Function RunMe(dataObj As AddToDosVals) As AddToDosVals Implements IAddToDos.RunMe

    If Not IsNothing(_runMeFirst) Then
      dataObj = _runMeFirst.RunMe(dataObj)
    End If

    If dataObj.ErrObj.HasError Then
      _currForm.ErrorMessage = "ERROR: " & dataObj.ErrObj.Message
    Else
      _currForm.ErrorMessage = ""
    End If

    Return dataObj

  End Function

End Class  'AlertOnError




Public Class ErrorObj
  Public Sub New()
    HasError = False
  End Sub
  Public Property HasError As Boolean
  Public Property Message As String
End Class


