<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class resultForm
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
        Me.resultPanel = New System.Windows.Forms.Panel()
        Me.gwaResult2 = New System.Windows.Forms.Label()
        Me.studNoResult = New System.Windows.Forms.Label()
        Me.sexResult = New System.Windows.Forms.Label()
        Me.sectionResult = New System.Windows.Forms.Label()
        Me.nameResult = New System.Windows.Forms.Label()
        Me.statusResult = New System.Windows.Forms.Label()
        Me.gwaResult = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.statusLabel = New System.Windows.Forms.Label()
        Me.gwaLabel1 = New System.Windows.Forms.Label()
        Me.studentGradeLabel = New System.Windows.Forms.Label()
        Me.studentNoLabel2 = New System.Windows.Forms.Label()
        Me.sexLabel2 = New System.Windows.Forms.Label()
        Me.sectionLabel2 = New System.Windows.Forms.Label()
        Me.nameLabel2 = New System.Windows.Forms.Label()
        Me.studentInfoLabel2 = New System.Windows.Forms.Label()
        Me.sgsHeader = New System.Windows.Forms.Label()
        Me.systemLogo2 = New System.Windows.Forms.PictureBox()
        Me.resultPanel.SuspendLayout()
        CType(Me.systemLogo2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'resultPanel
        '
        Me.resultPanel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.resultPanel.Controls.Add(Me.gwaResult2)
        Me.resultPanel.Controls.Add(Me.studNoResult)
        Me.resultPanel.Controls.Add(Me.sexResult)
        Me.resultPanel.Controls.Add(Me.sectionResult)
        Me.resultPanel.Controls.Add(Me.nameResult)
        Me.resultPanel.Controls.Add(Me.statusResult)
        Me.resultPanel.Controls.Add(Me.gwaResult)
        Me.resultPanel.Controls.Add(Me.Button1)
        Me.resultPanel.Controls.Add(Me.statusLabel)
        Me.resultPanel.Controls.Add(Me.gwaLabel1)
        Me.resultPanel.Controls.Add(Me.studentGradeLabel)
        Me.resultPanel.Controls.Add(Me.studentNoLabel2)
        Me.resultPanel.Controls.Add(Me.sexLabel2)
        Me.resultPanel.Controls.Add(Me.sectionLabel2)
        Me.resultPanel.Controls.Add(Me.nameLabel2)
        Me.resultPanel.Controls.Add(Me.studentInfoLabel2)
        Me.resultPanel.Controls.Add(Me.sgsHeader)
        Me.resultPanel.Controls.Add(Me.systemLogo2)
        Me.resultPanel.Cursor = System.Windows.Forms.Cursors.Default
        Me.resultPanel.Location = New System.Drawing.Point(0, 0)
        Me.resultPanel.Name = "resultPanel"
        Me.resultPanel.Size = New System.Drawing.Size(501, 500)
        Me.resultPanel.TabIndex = 0
        '
        'gwaResult2
        '
        Me.gwaResult2.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gwaResult2.Location = New System.Drawing.Point(340, 343)
        Me.gwaResult2.Name = "gwaResult2"
        Me.gwaResult2.Size = New System.Drawing.Size(99, 40)
        Me.gwaResult2.TabIndex = 17
        Me.gwaResult2.Text = "GRADES!"
        Me.gwaResult2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'studNoResult
        '
        Me.studNoResult.BackColor = System.Drawing.Color.White
        Me.studNoResult.Font = New System.Drawing.Font("Segoe UI", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studNoResult.Location = New System.Drawing.Point(190, 252)
        Me.studNoResult.Name = "studNoResult"
        Me.studNoResult.Size = New System.Drawing.Size(265, 40)
        Me.studNoResult.TabIndex = 16
        Me.studNoResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'sexResult
        '
        Me.sexResult.BackColor = System.Drawing.Color.White
        Me.sexResult.Font = New System.Drawing.Font("Segoe UI", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sexResult.Location = New System.Drawing.Point(190, 212)
        Me.sexResult.Name = "sexResult"
        Me.sexResult.Size = New System.Drawing.Size(265, 40)
        Me.sexResult.TabIndex = 15
        Me.sexResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'sectionResult
        '
        Me.sectionResult.BackColor = System.Drawing.Color.White
        Me.sectionResult.Font = New System.Drawing.Font("Segoe UI", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sectionResult.Location = New System.Drawing.Point(190, 172)
        Me.sectionResult.Name = "sectionResult"
        Me.sectionResult.Size = New System.Drawing.Size(265, 40)
        Me.sectionResult.TabIndex = 14
        Me.sectionResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nameResult
        '
        Me.nameResult.BackColor = System.Drawing.Color.White
        Me.nameResult.Font = New System.Drawing.Font("Segoe UI", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameResult.Location = New System.Drawing.Point(190, 132)
        Me.nameResult.Name = "nameResult"
        Me.nameResult.Size = New System.Drawing.Size(265, 40)
        Me.nameResult.TabIndex = 13
        Me.nameResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'statusResult
        '
        Me.statusResult.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statusResult.Location = New System.Drawing.Point(115, 383)
        Me.statusResult.Name = "statusResult"
        Me.statusResult.Size = New System.Drawing.Size(163, 40)
        Me.statusResult.TabIndex = 12
        Me.statusResult.Text = "PASSED"
        Me.statusResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gwaResult
        '
        Me.gwaResult.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gwaResult.Location = New System.Drawing.Point(267, 343)
        Me.gwaResult.Name = "gwaResult"
        Me.gwaResult.Size = New System.Drawing.Size(76, 40)
        Me.gwaResult.TabIndex = 11
        Me.gwaResult.Text = "INVALID"
        Me.gwaResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(207, 442)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 35)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'statusLabel
        '
        Me.statusLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statusLabel.Location = New System.Drawing.Point(46, 383)
        Me.statusLabel.Name = "statusLabel"
        Me.statusLabel.Size = New System.Drawing.Size(63, 40)
        Me.statusLabel.TabIndex = 9
        Me.statusLabel.Text = "Status:"
        Me.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gwaLabel1
        '
        Me.gwaLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gwaLabel1.Location = New System.Drawing.Point(46, 343)
        Me.gwaLabel1.Name = "gwaLabel1"
        Me.gwaLabel1.Size = New System.Drawing.Size(246, 40)
        Me.gwaLabel1.TabIndex = 8
        Me.gwaLabel1.Text = "General Weighted Average:"
        Me.gwaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'studentGradeLabel
        '
        Me.studentGradeLabel.Font = New System.Drawing.Font("Segoe UI", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentGradeLabel.Location = New System.Drawing.Point(12, 303)
        Me.studentGradeLabel.Name = "studentGradeLabel"
        Me.studentGradeLabel.Size = New System.Drawing.Size(476, 40)
        Me.studentGradeLabel.TabIndex = 7
        Me.studentGradeLabel.Text = "Student Grade "
        Me.studentGradeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'studentNoLabel2
        '
        Me.studentNoLabel2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentNoLabel2.Location = New System.Drawing.Point(46, 252)
        Me.studentNoLabel2.Name = "studentNoLabel2"
        Me.studentNoLabel2.Size = New System.Drawing.Size(138, 40)
        Me.studentNoLabel2.TabIndex = 6
        Me.studentNoLabel2.Text = "Student No."
        Me.studentNoLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'sexLabel2
        '
        Me.sexLabel2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sexLabel2.Location = New System.Drawing.Point(46, 212)
        Me.sexLabel2.Name = "sexLabel2"
        Me.sexLabel2.Size = New System.Drawing.Size(138, 40)
        Me.sexLabel2.TabIndex = 5
        Me.sexLabel2.Text = "Sex:"
        Me.sexLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'sectionLabel2
        '
        Me.sectionLabel2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sectionLabel2.Location = New System.Drawing.Point(46, 172)
        Me.sectionLabel2.Name = "sectionLabel2"
        Me.sectionLabel2.Size = New System.Drawing.Size(138, 40)
        Me.sectionLabel2.TabIndex = 4
        Me.sectionLabel2.Text = "Section:"
        Me.sectionLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nameLabel2
        '
        Me.nameLabel2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLabel2.Location = New System.Drawing.Point(46, 132)
        Me.nameLabel2.Name = "nameLabel2"
        Me.nameLabel2.Size = New System.Drawing.Size(138, 40)
        Me.nameLabel2.TabIndex = 3
        Me.nameLabel2.Text = "Name:"
        Me.nameLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'studentInfoLabel2
        '
        Me.studentInfoLabel2.Font = New System.Drawing.Font("Segoe UI", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentInfoLabel2.Location = New System.Drawing.Point(12, 82)
        Me.studentInfoLabel2.Name = "studentInfoLabel2"
        Me.studentInfoLabel2.Size = New System.Drawing.Size(476, 40)
        Me.studentInfoLabel2.TabIndex = 2
        Me.studentInfoLabel2.Text = "Student Information"
        Me.studentInfoLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'sgsHeader
        '
        Me.sgsHeader.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sgsHeader.Location = New System.Drawing.Point(125, 9)
        Me.sgsHeader.Name = "sgsHeader"
        Me.sgsHeader.Size = New System.Drawing.Size(330, 70)
        Me.sgsHeader.TabIndex = 1
        Me.sgsHeader.Text = "Student Grading System"
        Me.sgsHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'systemLogo2
        '
        Me.systemLogo2.Image = Global.Simple_Student_Grading_System.My.Resources.Resources.school_icon
        Me.systemLogo2.Location = New System.Drawing.Point(46, 9)
        Me.systemLogo2.Name = "systemLogo2"
        Me.systemLogo2.Size = New System.Drawing.Size(73, 70)
        Me.systemLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.systemLogo2.TabIndex = 0
        Me.systemLogo2.TabStop = False
        '
        'resultForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(500, 500)
        Me.Controls.Add(Me.resultPanel)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "resultForm"
        Me.Text = "General Weighted Average"
        Me.resultPanel.ResumeLayout(False)
        CType(Me.systemLogo2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents resultPanel As Panel
    Friend WithEvents systemLogo2 As PictureBox
    Friend WithEvents sgsHeader As Label
    Friend WithEvents studentInfoLabel2 As Label
    Friend WithEvents nameLabel2 As Label
    Friend WithEvents sexLabel2 As Label
    Friend WithEvents sectionLabel2 As Label
    Friend WithEvents studentNoLabel2 As Label
    Friend WithEvents studentGradeLabel As Label
    Friend WithEvents statusLabel As Label
    Friend WithEvents gwaLabel1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents statusResult As Label
    Friend WithEvents gwaResult As Label
    Friend WithEvents studNoResult As Label
    Friend WithEvents sexResult As Label
    Friend WithEvents sectionResult As Label
    Friend WithEvents nameResult As Label
    Friend WithEvents gwaResult2 As Label
End Class
