<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    Try
      If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
      End If
    Finally
      MyBase.Dispose(disposing)
    End Try
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.TextBox2 = New System.Windows.Forms.TextBox()
    Me.btnAdd = New System.Windows.Forms.Button()
    Me.dgvToDo = New System.Windows.Forms.DataGridView()
    Me.colDone = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.colDueDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.colTask = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
    Me.lblError = New System.Windows.Forms.Label()
    CType(Me.dgvToDo, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(64, 42)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(189, 37)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Stuff To Do:"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.Location = New System.Drawing.Point(152, 107)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(82, 20)
    Me.Label2.TabIndex = 1
    Me.Label2.Text = "Due Date:"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label3.Location = New System.Drawing.Point(288, 107)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(47, 20)
    Me.Label3.TabIndex = 2
    Me.Label3.Text = "Task:"
    '
    'TextBox2
    '
    Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TextBox2.Location = New System.Drawing.Point(288, 130)
    Me.TextBox2.Name = "TextBox2"
    Me.TextBox2.Size = New System.Drawing.Size(432, 26)
    Me.TextBox2.TabIndex = 4
    '
    'btnAdd
    '
    Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnAdd.Location = New System.Drawing.Point(71, 129)
    Me.btnAdd.Name = "btnAdd"
    Me.btnAdd.Size = New System.Drawing.Size(75, 28)
    Me.btnAdd.TabIndex = 5
    Me.btnAdd.Text = "Add"
    Me.btnAdd.UseVisualStyleBackColor = True
    '
    'dgvToDo
    '
    Me.dgvToDo.AllowUserToAddRows = False
    Me.dgvToDo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvToDo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDone, Me.colDueDate, Me.colTask})
    Me.dgvToDo.Location = New System.Drawing.Point(72, 182)
    Me.dgvToDo.Name = "dgvToDo"
    Me.dgvToDo.Size = New System.Drawing.Size(648, 429)
    Me.dgvToDo.TabIndex = 6
    '
    'colDone
    '
    Me.colDone.HeaderText = "Done"
    Me.colDone.Name = "colDone"
    Me.colDone.Width = 50
    '
    'colDueDate
    '
    Me.colDueDate.HeaderText = "Due Date"
    Me.colDueDate.Name = "colDueDate"
    '
    'colTask
    '
    Me.colTask.HeaderText = "Task"
    Me.colTask.Name = "colTask"
    Me.colTask.Width = 450
    '
    'DateTimePicker1
    '
    Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.DateTimePicker1.Location = New System.Drawing.Point(152, 130)
    Me.DateTimePicker1.Name = "DateTimePicker1"
    Me.DateTimePicker1.Size = New System.Drawing.Size(130, 26)
    Me.DateTimePicker1.TabIndex = 7
    '
    'lblError
    '
    Me.lblError.AutoSize = True
    Me.lblError.BackColor = System.Drawing.SystemColors.Control
    Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblError.ForeColor = System.Drawing.Color.Red
    Me.lblError.Location = New System.Drawing.Point(390, 65)
    Me.lblError.Name = "lblError"
    Me.lblError.Size = New System.Drawing.Size(0, 20)
    Me.lblError.TabIndex = 8
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(783, 662)
    Me.Controls.Add(Me.lblError)
    Me.Controls.Add(Me.DateTimePicker1)
    Me.Controls.Add(Me.dgvToDo)
    Me.Controls.Add(Me.btnAdd)
    Me.Controls.Add(Me.TextBox2)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Name = "Form1"
    Me.Text = "Form1"
    CType(Me.dgvToDo, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents Label1 As Label
  Friend WithEvents Label2 As Label
  Friend WithEvents Label3 As Label
  Friend WithEvents TextBox2 As TextBox
  Friend WithEvents btnAdd As Button
  Friend WithEvents dgvToDo As DataGridView
  Friend WithEvents DateTimePicker1 As DateTimePicker
  Friend WithEvents colDone As DataGridViewCheckBoxColumn
  Friend WithEvents colDueDate As DataGridViewTextBoxColumn
  Friend WithEvents colTask As DataGridViewTextBoxColumn
  Friend WithEvents lblError As Label
End Class
