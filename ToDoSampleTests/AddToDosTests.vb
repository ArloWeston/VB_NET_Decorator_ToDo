Imports System.Text
Imports System.Windows.Forms
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports ToDoSample

<TestClass()> Public Class AddToDosTests

  <TestMethod()> Public Sub GetFromTextBoxesTests()

    Dim expectedDate As Date = Date.Today()
    Dim expectedToDo As String = "This is my test ToDo!"

    Dim addToDo As IAddToDos = Nothing
    addToDo = New GetDataFromTextBoxes(expectedDate, expectedToDo, addToDo)

    Dim dataObj As New AddToDosVals()
    addToDo.RunMe(dataObj)

    Dim actualDate As Date = dataObj.DueDate
    Dim actualToDo As String = dataObj.ToDoTask

    Assert.AreEqual(expectedDate, actualDate)
    Assert.AreEqual(expectedToDo, actualToDo)

  End Sub


  <TestMethod()> Public Sub WriteToDataGridViewTests()
    'I'm going to borrow the dgv from Form1 for my tests
    'I think it is OK because I'm testing that specific form 
    'works with this function

    Dim frmTest As New Form1

    Dim expectedRows = 1

    Dim addToDo As IAddToDos = Nothing
    addToDo = New GetDataFromTextBoxes(Date.Today(), "This is my test ToDo2!", addToDo)
    addToDo = New WriteToDataGridView(frmTest.dgvForTests, addToDo)

    Dim dataObj As New AddToDosVals()
    addToDo.RunMe(dataObj)

    Dim actualRows As Integer = frmTest.dgvForTests.Rows.Count

    Assert.AreEqual(expectedRows, actualRows)

  End Sub


  <TestMethod()> Public Sub SortDataGridViewByDateTests()

    Dim testDay1 As New Date(2018, 12, 1)
    Dim testToDo1 As String = "Last Test ToDo"
    Dim testDay2 As New Date(2017, 12, 31)
    Dim testToDo2 As String = "First Test ToDo"
    Dim testDay3 As New Date(2018, 7, 15)
    Dim testToDo3 As String = "Middle Test ToDo"

    Dim frmTest As New Form1

    Dim addToDo As IAddToDos = Nothing
    'the set up:
    addToDo = New GetDataFromTextBoxes(testDay1, testToDo1, addToDo)
    addToDo = New WriteToDataGridView(frmTest.dgvForTests, addToDo)
    addToDo = New GetDataFromTextBoxes(testDay2, testToDo2, addToDo)
    addToDo = New WriteToDataGridView(frmTest.dgvForTests, addToDo)
    addToDo = New GetDataFromTextBoxes(testDay3, testToDo3, addToDo)
    addToDo = New WriteToDataGridView(frmTest.dgvForTests, addToDo)

    'the test:
    addToDo = New SortDataGridViewByDate(frmTest.dgvForTests, addToDo)
    Dim dataobj As New AddToDosVals()
    addToDo.RunMe(dataobj)


    Assert.AreEqual(testToDo2, frmTest.dgvForTests.Rows(0).Cells(2).Value)
    Assert.AreEqual(testToDo3, frmTest.dgvForTests.Rows(1).Cells(2).Value)
    Assert.AreEqual(testToDo1, frmTest.dgvForTests.Rows(2).Cells(2).Value)

  End Sub

  'when there is an error, error should be visiable on form
  '

  <TestMethod()> Public Sub AlertOnErrorTest()

    Dim frmTest As New Form1

    Dim expected As String = "ERROR: Test Error Message"

    Dim addToDo As IAddToDos = Nothing
    addToDo = New AlertOnError(frmTest, addToDo)

    Dim dataObj As New AddToDosVals()
    dataObj.ErrObj.HasError = True
    dataObj.ErrObj.Message = "Test Error Message"
    addToDo.RunMe(dataObj)

    Dim actual As String = frmTest.ErrorMessage

    Assert.AreEqual(expected, actual)

  End Sub

End Class 'GetFromTextBoxesTests