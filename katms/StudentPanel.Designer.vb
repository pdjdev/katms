<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentPanel
    Inherits System.Windows.Forms.UserControl

    'UserControl은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ProgramLabel = New System.Windows.Forms.Label()
        Me.EndTimeLabel = New System.Windows.Forms.Label()
        Me.StartTimeLabel = New System.Windows.Forms.Label()
        Me.SNameLabel = New System.Windows.Forms.Label()
        Me.SIDLabel = New System.Windows.Forms.Label()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.LeftPanel = New System.Windows.Forms.Panel()
        Me.LBottomPanel = New System.Windows.Forms.Panel()
        Me.LTopPanel = New System.Windows.Forms.Panel()
        Me.RightPanel = New System.Windows.Forms.Panel()
        Me.RBottomPanel = New System.Windows.Forms.Panel()
        Me.RTopPanel = New System.Windows.Forms.Panel()
        Me.TopPanel = New System.Windows.Forms.Panel()
        Me.BottomPanel = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.LeftPanel.SuspendLayout()
        Me.RightPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.73171!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.43902!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.5122!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.34146!))
        Me.TableLayoutPanel1.Controls.Add(Me.ProgramLabel, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.EndTimeLabel, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.StartTimeLabel, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.SNameLabel, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.SIDLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DeleteButton, 5, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("맑은 고딕 Semilight", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(24, 12)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(8, 10, 8, 10)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1242, 54)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'ProgramLabel
        '
        Me.ProgramLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgramLabel.Font = New System.Drawing.Font("나눔바른고딕", 12.0!)
        Me.ProgramLabel.Location = New System.Drawing.Point(822, 0)
        Me.ProgramLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.ProgramLabel.Name = "ProgramLabel"
        Me.ProgramLabel.Size = New System.Drawing.Size(290, 54)
        Me.ProgramLabel.TabIndex = 4
        Me.ProgramLabel.Text = "고등내신대비"
        Me.ProgramLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EndTimeLabel
        '
        Me.EndTimeLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EndTimeLabel.Font = New System.Drawing.Font("나눔바른고딕", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.EndTimeLabel.Location = New System.Drawing.Point(616, 0)
        Me.EndTimeLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.EndTimeLabel.Name = "EndTimeLabel"
        Me.EndTimeLabel.Size = New System.Drawing.Size(206, 54)
        Me.EndTimeLabel.TabIndex = 3
        Me.EndTimeLabel.Text = "16:03"
        Me.EndTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StartTimeLabel
        '
        Me.StartTimeLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StartTimeLabel.Font = New System.Drawing.Font("나눔바른고딕", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.StartTimeLabel.Location = New System.Drawing.Point(410, 0)
        Me.StartTimeLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.StartTimeLabel.Name = "StartTimeLabel"
        Me.StartTimeLabel.Size = New System.Drawing.Size(206, 54)
        Me.StartTimeLabel.TabIndex = 2
        Me.StartTimeLabel.Text = "14:03"
        Me.StartTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SNameLabel
        '
        Me.SNameLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SNameLabel.Font = New System.Drawing.Font("나눔바른고딕", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.SNameLabel.Location = New System.Drawing.Point(182, 0)
        Me.SNameLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.SNameLabel.Name = "SNameLabel"
        Me.SNameLabel.Size = New System.Drawing.Size(228, 54)
        Me.SNameLabel.TabIndex = 1
        Me.SNameLabel.Text = "홍길동"
        Me.SNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SIDLabel
        '
        Me.SIDLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SIDLabel.Font = New System.Drawing.Font("나눔바른고딕", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.SIDLabel.Location = New System.Drawing.Point(0, 0)
        Me.SIDLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.SIDLabel.Name = "SIDLabel"
        Me.SIDLabel.Size = New System.Drawing.Size(182, 54)
        Me.SIDLabel.TabIndex = 0
        Me.SIDLabel.Text = "12345678"
        Me.SIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DeleteButton
        '
        Me.DeleteButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteButton.Font = New System.Drawing.Font("나눔바른고딕", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.DeleteButton.ForeColor = System.Drawing.Color.Gray
        Me.DeleteButton.Location = New System.Drawing.Point(1116, 4)
        Me.DeleteButton.Margin = New System.Windows.Forms.Padding(4)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(122, 46)
        Me.DeleteButton.TabIndex = 5
        Me.DeleteButton.Text = "삭제하기"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'LeftPanel
        '
        Me.LeftPanel.BackgroundImage = Global.katms.My.Resources.Resources.left_mid
        Me.LeftPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LeftPanel.Controls.Add(Me.LBottomPanel)
        Me.LeftPanel.Controls.Add(Me.LTopPanel)
        Me.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftPanel.Location = New System.Drawing.Point(12, 0)
        Me.LeftPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.LeftPanel.Name = "LeftPanel"
        Me.LeftPanel.Size = New System.Drawing.Size(12, 78)
        Me.LeftPanel.TabIndex = 1
        '
        'LBottomPanel
        '
        Me.LBottomPanel.BackgroundImage = Global.katms.My.Resources.Resources.bottom_left
        Me.LBottomPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LBottomPanel.Location = New System.Drawing.Point(0, 66)
        Me.LBottomPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.LBottomPanel.Name = "LBottomPanel"
        Me.LBottomPanel.Size = New System.Drawing.Size(12, 12)
        Me.LBottomPanel.TabIndex = 1
        '
        'LTopPanel
        '
        Me.LTopPanel.BackgroundImage = Global.katms.My.Resources.Resources.top_left
        Me.LTopPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LTopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.LTopPanel.Location = New System.Drawing.Point(0, 0)
        Me.LTopPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.LTopPanel.Name = "LTopPanel"
        Me.LTopPanel.Size = New System.Drawing.Size(12, 12)
        Me.LTopPanel.TabIndex = 0
        '
        'RightPanel
        '
        Me.RightPanel.BackgroundImage = Global.katms.My.Resources.Resources.right_mid
        Me.RightPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RightPanel.Controls.Add(Me.RBottomPanel)
        Me.RightPanel.Controls.Add(Me.RTopPanel)
        Me.RightPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.RightPanel.Location = New System.Drawing.Point(1266, 0)
        Me.RightPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.RightPanel.Name = "RightPanel"
        Me.RightPanel.Size = New System.Drawing.Size(12, 78)
        Me.RightPanel.TabIndex = 2
        '
        'RBottomPanel
        '
        Me.RBottomPanel.BackgroundImage = Global.katms.My.Resources.Resources.bottom_right
        Me.RBottomPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.RBottomPanel.Location = New System.Drawing.Point(0, 66)
        Me.RBottomPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.RBottomPanel.Name = "RBottomPanel"
        Me.RBottomPanel.Size = New System.Drawing.Size(12, 12)
        Me.RBottomPanel.TabIndex = 3
        '
        'RTopPanel
        '
        Me.RTopPanel.BackgroundImage = Global.katms.My.Resources.Resources.top_right
        Me.RTopPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RTopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.RTopPanel.Location = New System.Drawing.Point(0, 0)
        Me.RTopPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.RTopPanel.Name = "RTopPanel"
        Me.RTopPanel.Size = New System.Drawing.Size(12, 12)
        Me.RTopPanel.TabIndex = 2
        '
        'TopPanel
        '
        Me.TopPanel.BackgroundImage = Global.katms.My.Resources.Resources.top_mid
        Me.TopPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(24, 0)
        Me.TopPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(1242, 12)
        Me.TopPanel.TabIndex = 2
        '
        'BottomPanel
        '
        Me.BottomPanel.BackgroundImage = Global.katms.My.Resources.Resources.bottom_mid
        Me.BottomPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomPanel.Location = New System.Drawing.Point(24, 66)
        Me.BottomPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.BottomPanel.Name = "BottomPanel"
        Me.BottomPanel.Size = New System.Drawing.Size(1242, 12)
        Me.BottomPanel.TabIndex = 3
        '
        'StudentPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.LightGray
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.BottomPanel)
        Me.Controls.Add(Me.TopPanel)
        Me.Controls.Add(Me.RightPanel)
        Me.Controls.Add(Me.LeftPanel)
        Me.Font = New System.Drawing.Font("맑은 고딕 Semilight", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Margin = New System.Windows.Forms.Padding(8, 10, 8, 10)
        Me.Name = "StudentPanel"
        Me.Padding = New System.Windows.Forms.Padding(12, 0, 12, 0)
        Me.Size = New System.Drawing.Size(1290, 78)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.LeftPanel.ResumeLayout(False)
        Me.RightPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ProgramLabel As Label
    Friend WithEvents EndTimeLabel As Label
    Friend WithEvents StartTimeLabel As Label
    Friend WithEvents SNameLabel As Label
    Friend WithEvents SIDLabel As Label
    Friend WithEvents DeleteButton As Button
    Friend WithEvents LeftPanel As Panel
    Friend WithEvents RightPanel As Panel
    Friend WithEvents TopPanel As Panel
    Friend WithEvents BottomPanel As Panel
    Friend WithEvents LBottomPanel As Panel
    Friend WithEvents LTopPanel As Panel
    Friend WithEvents RBottomPanel As Panel
    Friend WithEvents RTopPanel As Panel
End Class
