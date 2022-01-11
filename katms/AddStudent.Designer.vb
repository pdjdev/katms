<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddStudent
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ClassdurNUM = New System.Windows.Forms.NumericUpDown()
        Me.StudentIDTB = New System.Windows.Forms.TextBox()
        Me.StudentNameTB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ProgramTB = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.StudentMemoTB = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        CType(Me.ClassdurNUM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(551, 19)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(134, 41)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "등록"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(25, 0, 25, 0)
        Me.Panel2.Size = New System.Drawing.Size(704, 59)
        Me.Panel2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("맑은 고딕", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(18, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 28)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "학생 추가"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("맑은 고딕", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(19, 16)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "학생코드"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("맑은 고딕", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(19, 55)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "이름"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("맑은 고딕", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(415, 55)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 23)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "수업시간(분)"
        '
        'ClassdurNUM
        '
        Me.ClassdurNUM.Font = New System.Drawing.Font("맑은 고딕", 10.0!)
        Me.ClassdurNUM.Location = New System.Drawing.Point(528, 52)
        Me.ClassdurNUM.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ClassdurNUM.Maximum = New Decimal(New Integer() {360000, 0, 0, 0})
        Me.ClassdurNUM.Name = "ClassdurNUM"
        Me.ClassdurNUM.Size = New System.Drawing.Size(156, 30)
        Me.ClassdurNUM.TabIndex = 3
        '
        'StudentIDTB
        '
        Me.StudentIDTB.Font = New System.Drawing.Font("맑은 고딕", 10.0!)
        Me.StudentIDTB.Location = New System.Drawing.Point(127, 13)
        Me.StudentIDTB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.StudentIDTB.Name = "StudentIDTB"
        Me.StudentIDTB.Size = New System.Drawing.Size(274, 30)
        Me.StudentIDTB.TabIndex = 1
        '
        'StudentNameTB
        '
        Me.StudentNameTB.Font = New System.Drawing.Font("맑은 고딕", 10.0!)
        Me.StudentNameTB.Location = New System.Drawing.Point(127, 52)
        Me.StudentNameTB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.StudentNameTB.Name = "StudentNameTB"
        Me.StudentNameTB.Size = New System.Drawing.Size(274, 30)
        Me.StudentNameTB.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("맑은 고딕", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(19, 93)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 23)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "프로그램"
        '
        'ProgramTB
        '
        Me.ProgramTB.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgramTB.Font = New System.Drawing.Font("맑은 고딕", 10.0!)
        Me.ProgramTB.Location = New System.Drawing.Point(127, 90)
        Me.ProgramTB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ProgramTB.Name = "ProgramTB"
        Me.ProgramTB.Size = New System.Drawing.Size(558, 30)
        Me.ProgramTB.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("맑은 고딕", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(19, 132)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 23)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "개별메모"
        '
        'StudentMemoTB
        '
        Me.StudentMemoTB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StudentMemoTB.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.StudentMemoTB.Location = New System.Drawing.Point(23, 162)
        Me.StudentMemoTB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.StudentMemoTB.Multiline = True
        Me.StudentMemoTB.Name = "StudentMemoTB"
        Me.StudentMemoTB.Size = New System.Drawing.Size(660, 181)
        Me.StudentMemoTB.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.StudentMemoTB)
        Me.Panel1.Controls.Add(Me.StudentNameTB)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.ProgramTB)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.StudentIDTB)
        Me.Panel1.Controls.Add(Me.ClassdurNUM)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 59)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(15)
        Me.Panel1.Size = New System.Drawing.Size(704, 362)
        Me.Panel1.TabIndex = 12
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 421)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(15)
        Me.Panel3.Size = New System.Drawing.Size(704, 79)
        Me.Panel3.TabIndex = 12
        '
        'AddStudent
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(704, 500)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MinimumSize = New System.Drawing.Size(722, 421)
        Me.Name = "AddStudent"
        Me.Icon = My.Resources.katmsico
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "학생 추가"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ClassdurNUM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ClassdurNUM As NumericUpDown
    Friend WithEvents StudentIDTB As TextBox
    Friend WithEvents StudentNameTB As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ProgramTB As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents StudentMemoTB As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
End Class
