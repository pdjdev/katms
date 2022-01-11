Public Class StudentEnter

    Dim shown As Boolean = False
    Private Sub NumButton_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click, Button10.Click
        Dim bt As Button = sender
        typetxt(bt.Text)
    End Sub

    Sub typetxt(txt As String)
        TextBox1.Text += txt
        TextBox1.SelectionStart = TextBox1.Text.Length + 1
        TextBox1.Select()
    End Sub

    Sub deletetxt()
        If Not TextBox1.Text = Nothing Then
            TextBox1.Text = Mid(TextBox1.Text, 1, TextBox1.Text.Length - 1)
            TextBox1.SelectionStart = TextBox1.Text.Length + 1
        End If
        TextBox1.Select()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        deletetxt()
    End Sub

    '학생 찾기 시작
    Private Sub EnterButton_Click(sender As Object, e As EventArgs) Handles EnterButton.Click
        Dim stdfind As String = GetStudentsById(ReadData, TextBox1.Text)

        If stdfind = Nothing Then
            MessagePopup.Label1.Text = "학생을 찾을 수 없습니다"
            MessagePopup.ShowDialog(Me)
        Else
            StudentsList.Add_Student(stdfind)
            TextBox1.Text = Nothing
            MessagePopup.Label1.Text = "등록 완료 되었습니다"
            MessagePopup.ShowDialog(Me)
        End If
    End Sub

    Private Sub StudentEnter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        shown = False

        Dim sideimgdata As String = GetINI("sideimgloc")

        If My.Computer.FileSystem.FileExists(sideimgdata) Then
            SidePictureBox.ImageLocation = sideimgdata
        Else
            SidePictureBox.Image = My.Resources.back
        End If

        Dim sidecolordata As String = GetINI("sidecolor")

        If Not sidecolordata = "" Then
            SidePictureBox.BackColor = ColorTranslator.FromHtml(sidecolordata)
        End If

        TopMostChk.Checked = (GetINI("entertopmost") = "True")

        Dim locdata As String = GetINI("enterloc")

        If locdata.Contains(",") Then
            Dim loc = locdata.Split(",")
            If IsNumeric(Trim(loc(0))) And IsNumeric(Trim(loc(1))) Then
                SetDesktopLocation(Convert.ToInt32(loc(0)), Convert.ToInt32(loc(1)))
            End If
        End If

        Dim sizedata As String = GetINI("entersize")

        If sizedata.Contains(",") Then
            Dim siz = sizedata.Split(",")
            If IsNumeric(Trim(siz(0))) And IsNumeric(Trim(siz(1))) Then
                Width = Convert.ToInt32(siz(0))
                Height = Convert.ToInt32(siz(1))
            End If
        End If

        verLabel.Text = "v" + My.Application.Info.Version.ToString
        StudentsList.Show()

        If (ReadData() = Nothing) Then
            If MsgBox("학생 데이터를 찾을 수 없습니다. 새로 만드시겠습니까?", vbQuestion + vbYesNo) = vbYes Then
                SaveData("")
            End If
        End If

        shown = True
    End Sub

    Public Sub ReloadList()
        Dim point As Point = StudentsList.Location
        Dim size As Size = StudentsList.Size

        StudentsList.Close()
        StudentsList.askread = False
        StudentsList.Size = size
        StudentsList.Show()
        StudentsList.SetDesktopLocation(point.X, point.Y)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles TopMostChk.CheckedChanged
        TopMost = TopMostChk.Checked
        If shown Then SetINI("entertopmost", TopMost.ToString)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        StudentsList.Show()
    End Sub

    Private Sub MenuButton_Click(sender As Object, e As EventArgs) Handles MenuButton.Click
        ContextMenuStrip1.Show(Cursor.Position)
    End Sub

    Private Sub 학생등록ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 학생등록ToolStripMenuItem.Click
        AddStudent.Close()
        AddStudent.Show()
    End Sub

    Private Sub 학생추가ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 학생추가ToolStripMenuItem.Click
        EditStudent.Show()
    End Sub

    Private Sub ArrWindowsBT_Click(sender As Object, e As EventArgs) Handles ArrWindowsBT.Click
        Dim desktopArea_width As Integer = My.Computer.Screen.WorkingArea.Width
        Dim desktopArea_height As Integer = My.Computer.Screen.WorkingArea.Height

        Width = MinimumSize.Width
        Height = desktopArea_height
        SetDesktopLocation(desktopArea_width - Width, 0)

        StudentsList.Width = desktopArea_width - Width
        StudentsList.Height = desktopArea_height
        StudentsList.SetDesktopLocation(0, 0)
    End Sub

    Private Sub StudentEnter_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If shown Then SetINI("entersize", Width.ToString + "," + Height.ToString)
    End Sub

    Private Sub StudentEnter_LocationChanged(sender As Object, e As EventArgs) Handles MyBase.LocationChanged
        If shown Then SetINI("enterloc", Location.X.ToString + "," + Location.Y.ToString)
    End Sub

    Private Sub 이미지수정ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 이미지수정ToolStripMenuItem.Click
        Dim dialog As New OpenFileDialog
        dialog.Filter = "이미지 파일|*.jpg;*.png;*.gif;*.bmp"

        If dialog.ShowDialog = DialogResult.OK Then
            SidePictureBox.ImageLocation = dialog.FileName
            SetINI("sideimgloc", dialog.FileName)
        End If
    End Sub

    Private Sub SidePictureBox_DoubleClick(sender As Object, e As EventArgs) Handles SidePictureBox.DoubleClick
        ContextMenuStrip2.Show(Cursor.Position)
    End Sub

    Private Sub 배경수정ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 배경수정ToolStripMenuItem.Click
        Dim cpicker As New ColorDialog

        If cpicker.ShowDialog = DialogResult.OK Then
            SidePictureBox.BackColor = cpicker.Color
            SetINI("sidecolor", ColorTranslator.ToHtml(cpicker.Color))
        End If
    End Sub

    Private Sub 스타일초기화ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 스타일초기화ToolStripMenuItem.Click
        SetINI("sideimgloc", "")
        SetINI("sidecolor", "")

        SidePictureBox.Image = My.Resources.back
        SidePictureBox.BackColor = Color.FromArgb(254, 231, 103)
    End Sub
End Class