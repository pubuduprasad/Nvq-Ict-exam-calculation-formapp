<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VBForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.label10 = New System.Windows.Forms.Label()
        Me.linkLabel = New System.Windows.Forms.LinkLabel()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.GradeResult = New System.Windows.Forms.TextBox()
        Me.CompetentResult = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.AverageResult = New System.Windows.Forms.TextBox()
        Me.TotalResult = New System.Windows.Forms.TextBox()
        Me.ExitBTN = New System.Windows.Forms.Button()
        Me.ClearBTN = New System.Windows.Forms.Button()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.CalculateBTN = New System.Windows.Forms.Button()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.MsPowerPoint = New System.Windows.Forms.TextBox()
        Me.Name = New System.Windows.Forms.TextBox()
        Me.MsAccess = New System.Windows.Forms.TextBox()
        Me.MsExcel = New System.Windows.Forms.TextBox()
        Me.MsWord = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.label10.Location = New System.Drawing.Point(467, 480)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(154, 16)
        Me.label10.TabIndex = 42
        Me.label10.Text = "Created by pubuduzeo :)"
        '
        'linkLabel
        '
        Me.linkLabel.AutoSize = True
        Me.linkLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkLabel.Location = New System.Drawing.Point(623, 480)
        Me.linkLabel.Name = "linkLabel"
        Me.linkLabel.Size = New System.Drawing.Size(204, 16)
        Me.linkLabel.TabIndex = 41
        Me.linkLabel.TabStop = True
        Me.linkLabel.Text = "https://github.com/pubuduprasad"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.Location = New System.Drawing.Point(486, 423)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(58, 19)
        Me.label8.TabIndex = 38
        Me.label8.Text = "Grade "
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.Location = New System.Drawing.Point(450, 367)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(94, 19)
        Me.label9.TabIndex = 37
        Me.label9.Text = "Competent"
        '
        'GradeResult
        '
        Me.GradeResult.Location = New System.Drawing.Point(559, 409)
        Me.GradeResult.Multiline = True
        Me.GradeResult.Name = "GradeResult"
        Me.GradeResult.Size = New System.Drawing.Size(251, 41)
        Me.GradeResult.TabIndex = 36
        '
        'CompetentResult
        '
        Me.CompetentResult.Location = New System.Drawing.Point(559, 361)
        Me.CompetentResult.Multiline = True
        Me.CompetentResult.Name = "CompetentResult"
        Me.CompetentResult.Size = New System.Drawing.Size(251, 40)
        Me.CompetentResult.TabIndex = 35
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.Location = New System.Drawing.Point(69, 423)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(76, 19)
        Me.label7.TabIndex = 34
        Me.label7.Text = "Average "
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(94, 367)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(51, 19)
        Me.label6.TabIndex = 33
        Me.label6.Text = "Total "
        '
        'AverageResult
        '
        Me.AverageResult.Location = New System.Drawing.Point(160, 409)
        Me.AverageResult.Multiline = True
        Me.AverageResult.Name = "AverageResult"
        Me.AverageResult.Size = New System.Drawing.Size(251, 41)
        Me.AverageResult.TabIndex = 32
        '
        'TotalResult
        '
        Me.TotalResult.Location = New System.Drawing.Point(160, 361)
        Me.TotalResult.Multiline = True
        Me.TotalResult.Name = "TotalResult"
        Me.TotalResult.Size = New System.Drawing.Size(251, 40)
        Me.TotalResult.TabIndex = 31
        '
        'ExitBTN
        '
        Me.ExitBTN.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Bold)
        Me.ExitBTN.Location = New System.Drawing.Point(558, 278)
        Me.ExitBTN.Name = "ExitBTN"
        Me.ExitBTN.Size = New System.Drawing.Size(252, 37)
        Me.ExitBTN.TabIndex = 30
        Me.ExitBTN.Text = "Exit"
        Me.ExitBTN.UseVisualStyleBackColor = True
        '
        'ClearBTN
        '
        Me.ClearBTN.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Bold)
        Me.ClearBTN.Location = New System.Drawing.Point(292, 278)
        Me.ClearBTN.Name = "ClearBTN"
        Me.ClearBTN.Size = New System.Drawing.Size(252, 37)
        Me.ClearBTN.TabIndex = 29
        Me.ClearBTN.Text = "Clear"
        Me.ClearBTN.UseVisualStyleBackColor = True
        '
        'groupBox2
        '
        Me.groupBox2.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox2.Location = New System.Drawing.Point(12, 335)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(815, 132)
        Me.groupBox2.TabIndex = 40
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "RESULTS"
        '
        'CalculateBTN
        '
        Me.CalculateBTN.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalculateBTN.Location = New System.Drawing.Point(31, 278)
        Me.CalculateBTN.Name = "CalculateBTN"
        Me.CalculateBTN.Size = New System.Drawing.Size(252, 37)
        Me.CalculateBTN.TabIndex = 28
        Me.CalculateBTN.Text = "Calculate "
        Me.CalculateBTN.UseVisualStyleBackColor = True
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.MsPowerPoint)
        Me.groupBox1.Controls.Add(Me.Name)
        Me.groupBox1.Controls.Add(Me.MsAccess)
        Me.groupBox1.Controls.Add(Me.MsExcel)
        Me.groupBox1.Controls.Add(Me.MsWord)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(12, 10)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(470, 254)
        Me.groupBox1.TabIndex = 39
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "MARKS"
        '
        'MsPowerPoint
        '
        Me.MsPowerPoint.Location = New System.Drawing.Point(148, 197)
        Me.MsPowerPoint.Multiline = True
        Me.MsPowerPoint.Name = "MsPowerPoint"
        Me.MsPowerPoint.Size = New System.Drawing.Size(269, 26)
        Me.MsPowerPoint.TabIndex = 4
        '
        'Name
        '
        Me.Name.Location = New System.Drawing.Point(148, 28)
        Me.Name.Multiline = True
        Me.Name.Name = "Name"
        Me.Name.Size = New System.Drawing.Size(269, 26)
        Me.Name.TabIndex = 0
        '
        'MsAccess
        '
        Me.MsAccess.Location = New System.Drawing.Point(148, 152)
        Me.MsAccess.Multiline = True
        Me.MsAccess.Name = "MsAccess"
        Me.MsAccess.Size = New System.Drawing.Size(269, 26)
        Me.MsAccess.TabIndex = 1
        '
        'MsExcel
        '
        Me.MsExcel.Location = New System.Drawing.Point(148, 111)
        Me.MsExcel.Multiline = True
        Me.MsExcel.Name = "MsExcel"
        Me.MsExcel.Size = New System.Drawing.Size(269, 26)
        Me.MsExcel.TabIndex = 2
        '
        'MsWord
        '
        Me.MsWord.Location = New System.Drawing.Point(148, 70)
        Me.MsWord.Multiline = True
        Me.MsWord.Name = "MsWord"
        Me.MsWord.Size = New System.Drawing.Size(269, 26)
        Me.MsWord.TabIndex = 3
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(28, 34)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(47, 16)
        Me.label1.TabIndex = 8
        Me.label1.Text = "Name "
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(28, 155)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(74, 16)
        Me.label2.TabIndex = 9
        Me.label2.Text = "MS Access "
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(28, 114)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(60, 16)
        Me.label3.TabIndex = 10
        Me.label3.Text = "MS Excel"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(28, 200)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(104, 16)
        Me.label5.TabIndex = 12
        Me.label5.Text = "MS Power Point "
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(28, 73)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(64, 16)
        Me.label4.TabIndex = 11
        Me.label4.Text = "MS Word"
        '
        'VBForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 505)
        Me.Controls.Add(Me.label10)
        Me.Controls.Add(Me.linkLabel)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.GradeResult)
        Me.Controls.Add(Me.CompetentResult)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.AverageResult)
        Me.Controls.Add(Me.TotalResult)
        Me.Controls.Add(Me.ExitBTN)
        Me.Controls.Add(Me.ClearBTN)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.CalculateBTN)
        Me.Controls.Add(Me.groupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "VBForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form VB"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label10 As Label
    Private WithEvents linkLabel As LinkLabel
    Private WithEvents label8 As Label
    Private WithEvents label9 As Label
    Private WithEvents GradeResult As TextBox
    Private WithEvents CompetentResult As TextBox
    Private WithEvents label7 As Label
    Private WithEvents label6 As Label
    Private WithEvents AverageResult As TextBox
    Private WithEvents TotalResult As TextBox
    Private WithEvents ExitBTN As Button
    Private WithEvents ClearBTN As Button
    Private WithEvents groupBox2 As GroupBox
    Private WithEvents CalculateBTN As Button
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents MsPowerPoint As TextBox
#Disable Warning BC40004 ' Member conflicts with member in the base type and should be declared 'Shadows'
    Private WithEvents Name As TextBox
#Enable Warning BC40004 ' Member conflicts with member in the base type and should be declared 'Shadows'
    Private WithEvents MsAccess As TextBox
    Private WithEvents MsExcel As TextBox
    Private WithEvents MsWord As TextBox
    Private WithEvents label1 As Label
    Private WithEvents label2 As Label
    Private WithEvents label3 As Label
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
End Class
