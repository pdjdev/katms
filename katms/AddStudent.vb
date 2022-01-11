Public Class AddStudent
    Public OldStudentData As String = ""
    Dim orgid As Integer = -1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not CheckError() Then
            If OldStudentData = "" Then
                If CheckStudentsById(ReadData, StudentIDTB.Text) Then
                    MsgBox("이미 같은 ID를 가진 학생이 있습니다. 삭제 후 다시 시도해 주세요.", vbExclamation)
                    Exit Sub
                Else
                    AddNewStudent(StudentIDTB.Text, StudentNameTB.Text, ClassdurNUM.Value, ProgramTB.Text, StudentMemoTB.Text)
                    If MsgBox("추가가 완료되었습니다. 또 추가하겠습니까?", vbQuestion + vbYesNo) = vbYes Then
                        StudentIDTB.Text = Nothing
                        StudentNameTB.Text = Nothing
                        StudentMemoTB.Text = Nothing
                        StudentIDTB.Select()
                    Else
                        Me.Close()
                    End If
                End If
            Else

                '아이디가 다를 경우 => 충돌시 변경 막기
                If Not (orgid.ToString = StudentIDTB.Text) Then
                    If CheckStudentsById(ReadData, StudentIDTB.Text) Then
                        MsgBox("이미 같은 ID를 가진 학생이 있습니다. 다른 ID로 수정후 저장하세요.", vbExclamation)
                        Exit Sub
                    End If
                End If

                Dim Data = "<id>" + StudentIDTB.Text + "</id>" + vbCr
                Data += "<name>" + StudentNameTB.Text + "</name>" + vbCr
                Data += "<dur>" + ClassdurNUM.Value.ToString + "</dur>" + vbCr
                Data += "<prog>" + ProgramTB.Text + "</prog>" + vbCr
                Data += "<memo>" + StudentMemoTB.Text + "</memo>"
                ReplaceStudentsData(OldStudentData, Data)

                Me.Close()
            End If
        End If
    End Sub

    Private Function CheckError() As Boolean
        Dim NG As Boolean = False

        If StudentIDTB.Text = Nothing Then
            MsgBox("학생코드를 입력해 주십시오.", vbExclamation)
            NG = True
            GoTo endtask
        End If

        If Not IsNumeric(StudentIDTB.Text) Then
            MsgBox("학생코드는 숫자여야만 합니다.", vbExclamation)
            NG = True
            GoTo endtask
        End If

        If StudentNameTB.Text = Nothing Then
            MsgBox("학생이름을 입력해 주십시오.", vbExclamation)
            NG = True
            GoTo endtask
        End If

        If ClassdurNUM.Value < 1 Then
            MsgBox("수업시간은 1분보다 길어야 합니다.", vbExclamation)
            NG = True
        End If

endtask:
        Return NG
    End Function

    Private Sub AddStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not OldStudentData = "" Then

            If IsNumeric(getData(OldStudentData, "id")) Then
                orgid = Convert.ToInt32(getData(OldStudentData, "id"))
            Else
                MsgBox("학생 데이터가 올바르지 않습니다", vbCritical)
            End If

            Label1.Text = "학생 편집"
            Text = "학생 편집"
            Button1.Text = "저장"
            StudentIDTB.Text = orgid.ToString
            StudentNameTB.Text = getData(OldStudentData, "name")
            ClassdurNUM.Value = getData(OldStudentData, "dur")
            ProgramTB.Text = getData(OldStudentData, "prog")
            StudentMemoTB.Text = getData(OldStudentData, "memo")
        End If
    End Sub
End Class