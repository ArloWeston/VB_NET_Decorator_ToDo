Public Class Form1

  Public Property dgvForTests As DataGridView

  Public Property ErrorMessage() As String
    Get
      Return Me.lblError.Text
    End Get
    Set(ByVal value As String)
      Me.lblError.Text = value
    End Set
  End Property

  Public Sub New()

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    dgvForTests = Me.dgvToDo
  End Sub

  Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

    Dim addToDo As IAddToDos = Nothing
    addToDo = New GetDataFromTextBoxes(Me.DateTimePicker1.Value, Me.TextBox2.Text, addToDo)
    addToDo = New WriteToDataGridView(Me.dgvToDo, addToDo)
    addToDo = New SortDataGridViewByDate(Me.dgvToDo, addToDo)
    addToDo = New AlertOnError(Me, addToDo)

    Dim dataObj As New AddToDosVals()
    addToDo.RunMe(dataObj)

  End Sub

End Class
