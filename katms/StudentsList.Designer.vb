<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StudentsList
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ListPanel = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ETimeHeaderLabel = New System.Windows.Forms.Label()
        Me.STimeHeaderLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TipLabel = New System.Windows.Forms.Label()
        Me.AutoSaveChk = New System.Windows.Forms.CheckBox()
        Me.TopMostChk = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListPanel
        '
        Me.ListPanel.AutoScroll = True
        Me.ListPanel.BackColor = System.Drawing.Color.LightGray
        Me.ListPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListPanel.Location = New System.Drawing.Point(0, 66)
        Me.ListPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.ListPanel.Name = "ListPanel"
        Me.ListPanel.Size = New System.Drawing.Size(1180, 654)
        Me.ListPanel.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.67716!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.37385!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.6102!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.6102!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.42567!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.30291!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ETimeHeaderLabel, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.STimeHeaderLabel, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("맑은 고딕 Semilight", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 6)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(8, 10, 8, 10)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(12, 0, 12, 0)
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1180, 48)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("나눔바른고딕", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(1055, 0)
        Me.Label6.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 48)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = ". . ."
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("나눔바른고딕", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(777, 0)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(270, 48)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "프 로 그 램"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ETimeHeaderLabel
        '
        Me.ETimeHeaderLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ETimeHeaderLabel.Font = New System.Drawing.Font("나눔바른고딕", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ETimeHeaderLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ETimeHeaderLabel.Location = New System.Drawing.Point(585, 0)
        Me.ETimeHeaderLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.ETimeHeaderLabel.Name = "ETimeHeaderLabel"
        Me.ETimeHeaderLabel.Size = New System.Drawing.Size(192, 48)
        Me.ETimeHeaderLabel.TabIndex = 3
        Me.ETimeHeaderLabel.Text = "종 료 시 간"
        Me.ETimeHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'STimeHeaderLabel
        '
        Me.STimeHeaderLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.STimeHeaderLabel.Font = New System.Drawing.Font("나눔바른고딕", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.STimeHeaderLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.STimeHeaderLabel.Location = New System.Drawing.Point(393, 0)
        Me.STimeHeaderLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.STimeHeaderLabel.Name = "STimeHeaderLabel"
        Me.STimeHeaderLabel.Size = New System.Drawing.Size(192, 48)
        Me.STimeHeaderLabel.TabIndex = 2
        Me.STimeHeaderLabel.Text = "입 실 시 간"
        Me.STimeHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("나눔바른고딕", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(181, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(212, 48)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "학 생 이 름"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("나눔바른고딕", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "학 생 번 호"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(0, 6, 0, 0)
        Me.Panel2.Size = New System.Drawing.Size(1180, 66)
        Me.Panel2.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightGray
        Me.Panel3.BackgroundImage = Global.katms.My.Resources.Resources.bottom_mid
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 54)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1180, 12)
        Me.Panel3.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.TipLabel)
        Me.Panel1.Controls.Add(Me.AutoSaveChk)
        Me.Panel1.Controls.Add(Me.TopMostChk)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.SaveButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 689)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
        Me.Panel1.Size = New System.Drawing.Size(1180, 31)
        Me.Panel1.TabIndex = 0
        '
        'TipLabel
        '
        Me.TipLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TipLabel.Font = New System.Drawing.Font("맑은 고딕", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.TipLabel.ForeColor = System.Drawing.Color.Gray
        Me.TipLabel.Location = New System.Drawing.Point(115, 0)
        Me.TipLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TipLabel.Name = "TipLabel"
        Me.TipLabel.Size = New System.Drawing.Size(673, 31)
        Me.TipLabel.TabIndex = 22
        Me.TipLabel.Text = "학생 번호를 더블 클릭하면 해당 학생의 정보를 편집할 수 있습니다. (단, 수정된 사항은 다음 출석부터 반영)"
        Me.TipLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AutoSaveChk
        '
        Me.AutoSaveChk.Checked = True
        Me.AutoSaveChk.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AutoSaveChk.Dock = System.Windows.Forms.DockStyle.Right
        Me.AutoSaveChk.Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.AutoSaveChk.Location = New System.Drawing.Point(788, 0)
        Me.AutoSaveChk.Margin = New System.Windows.Forms.Padding(4)
        Me.AutoSaveChk.Name = "AutoSaveChk"
        Me.AutoSaveChk.Size = New System.Drawing.Size(92, 31)
        Me.AutoSaveChk.TabIndex = 21
        Me.AutoSaveChk.Text = "자동 저장"
        Me.AutoSaveChk.UseVisualStyleBackColor = True
        '
        'TopMostChk
        '
        Me.TopMostChk.Dock = System.Windows.Forms.DockStyle.Left
        Me.TopMostChk.Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.TopMostChk.Location = New System.Drawing.Point(6, 0)
        Me.TopMostChk.Margin = New System.Windows.Forms.Padding(4)
        Me.TopMostChk.Name = "TopMostChk"
        Me.TopMostChk.Size = New System.Drawing.Size(109, 31)
        Me.TopMostChk.TabIndex = 20
        Me.TopMostChk.Text = "항상 위에"
        Me.TopMostChk.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("맑은 고딕", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(880, 0)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 31)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "비우기"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("맑은 고딕", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(980, 0)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 31)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "불러오기"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.SaveButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.SaveButton.FlatAppearance.BorderSize = 0
        Me.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveButton.Font = New System.Drawing.Font("맑은 고딕", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.SaveButton.ForeColor = System.Drawing.Color.Black
        Me.SaveButton.Location = New System.Drawing.Point(1080, 0)
        Me.SaveButton.Margin = New System.Windows.Forms.Padding(0)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(100, 31)
        Me.SaveButton.TabIndex = 17
        Me.SaveButton.Text = "저장하기"
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'StudentsList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1180, 720)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ListPanel)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Icon = Global.katms.My.Resources.Resources.katmsico
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(840, 455)
        Me.Name = "StudentsList"
        Me.Text = "학생 목록"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListPanel As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ETimeHeaderLabel As Label
    Friend WithEvents STimeHeaderLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SaveButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TopMostChk As CheckBox
    Friend WithEvents Button2 As Button
    Friend WithEvents AutoSaveChk As CheckBox
    Friend WithEvents TipLabel As Label
End Class
