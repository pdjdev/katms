Public Class EditStudent
    Dim tmplist As ListViewItem '처리용 임시 리스트

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadStudents()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim c As Integer = ListView1.CheckedItems.Count
        Dim names As String = ""

        If c = 1 Then
            names = ListView1.CheckedItems(0).SubItems(1).Text
        ElseIf c > 1 Then
            For i = 0 To c - 1
                If i > 3 Then
                    names += "외 " + (c - 4).ToString + "명"
                    Exit For
                End If
                names += ListView1.CheckedItems(i).SubItems(1).Text
                If i < c - 1 Then names += ", "
            Next
        Else
            Exit Sub
        End If

        If MsgBox(names + vbCr + vbCr + "정말 위 학생의 정보를 삭제하시겠습니까?", vbQuestion + vbYesNo) = vbNo Then
            Exit Sub
        End If

        For i = 0 To c - 1
            RemoveStudentbyid(ListView1.CheckedItems(i).SubItems(0).Text)
        Next
        LoadStudents()
    End Sub

    Public Sub LoadStudents(Optional filter As String = "")

        Dim filtering As Boolean = Not (filter = "")

        ListView1.Items.Clear()

        Dim tmp As String = getData(ReadData(), "students")

        If tmp.Contains("<a student>") And tmp.Contains("</a>") Then
            Dim students As List(Of String) = multipleMidReturn("<a student>", "</a>", tmp)

            For Each s In students

                If filtering Then
                    If Not (getData(s, "id").Contains(filter) Or getData(s, "name").Contains(filter)) Then
                        Continue For
                    End If
                End If

                tmplist = ListView1.Items.Add(getData(s, "id"))
                tmplist.SubItems.Add(getData(s, "name"))
                tmplist.SubItems.Add(getData(s, "dur"))
                tmplist.SubItems.Add(getData(s, "prog"))
            Next
        Else
            'ListView1.Items.Add("").SubItems.Add("(학생 없음)")
        End If
    End Sub

    Private Sub RemoveStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim searchIcon As New Bitmap(My.Resources.search, FilterBT.Height - 3, FilterBT.Height - 3)
        FilterBT.Image = searchIcon
        LoadStudents()
    End Sub

    Private Sub ListView1_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles ListView1.ColumnClick
        If ListView1.Columns.Item(e.Column).ListView.Sorting <> SortOrder.Descending Then
            ListView1.Columns.Item(e.Column).ListView.Sorting = SortOrder.Descending
        ElseIf ListView1.Columns.Item(e.Column).ListView.Sorting <> SortOrder.Ascending Then
            ListView1.Columns.Item(e.Column).ListView.Sorting = SortOrder.Ascending
        End If
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        AddStudent.Close()
        AddStudent.OldStudentData = GetStudentsById(ReadData(), ListView1.SelectedItems(0).Text)
        AddStudent.ShowDialog(Me)
        LoadStudents()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AddStudent.Close()
        AddStudent.ShowDialog(Me)
    End Sub

    Private Sub FilterBT_Click(sender As Object, e As EventArgs) Handles FilterBT.Click
        LoadStudents(FilterTB.Text)
    End Sub

    Private Sub FilterTB_KeyDown(sender As Object, e As KeyEventArgs) Handles FilterTB.KeyDown
        If e.KeyCode = Keys.Return Then
            LoadStudents(FilterTB.Text)
        End If
    End Sub
End Class