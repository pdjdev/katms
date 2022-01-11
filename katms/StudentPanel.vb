Public Class StudentPanel
    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        'If MsgBox("삭제하시겠습니까?", vbQuestion + vbYesNo) = vbYes Then
        StudentsList.StudentsList_Delete(Name)
        'End If
    End Sub

    Private Sub SIDLabel_Click(sender As Object, e As EventArgs) Handles SIDLabel.DoubleClick
        AddStudent.OldStudentData = GetStudentsById(ReadData(), SIDLabel.Text)
        AddStudent.ShowDialog(Me)
    End Sub

    Private Sub SIDLabel_MouseEnter(sender As Object, e As EventArgs) Handles SIDLabel.MouseEnter
        sender.BackColor = Color.FromArgb(232, 232, 232)
    End Sub

    Private Sub SIDLabel_MouseLeave(sender As Object, e As EventArgs) Handles SIDLabel.MouseLeave
        sender.BackColor = Color.Transparent
    End Sub
End Class
