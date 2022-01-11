Module DataWriter
    Public saveloc As String = My.Application.Info.DirectoryPath + "\students.txt"
    Public listsaveloc As String = My.Application.Info.DirectoryPath + "\list.txt"

    Public Function CheckStudentsById(data As String, id As String)
        Dim res As Boolean = False

        If data.Contains("<students>") Then
            data = getData(data, "students")
            res = data.Contains("<id>" + id + "</id>")
        End If

        Return res
    End Function

    Public Function GetStudentsById(data As String, id As String)
        Dim res As Boolean = False

        Dim tmp As String = data

retry:
        If tmp.Contains("<a student>") Then
            Dim FirstStart As Long = tmp.IndexOf("<a student>") + "<a student>".Length + 2
            Dim part = Trim(Mid$(tmp, FirstStart, tmp.Substring(FirstStart).IndexOf("</a>")))

            tmp = Mid(tmp, tmp.Substring(FirstStart).IndexOf("</a>") + 1)
            'MsgBox(part)
            If getData(part, "id") = id Then
                Clipboard.SetText(part)
                Return part
            Else
                GoTo retry
            End If
        Else
            Return Nothing
        End If

        Return res
    End Function

    Public Sub ReplaceStudentsData(oldpart As String, newpart As String)
        Dim tmp = ReadData()
        tmp = tmp.Replace(oldpart, newpart)
        SaveData(tmp)

    End Sub

    Public Sub AddNewStudent(id As String, name As String, dur As Integer, prog As String, memo As String)
        Dim data As String = vbCr + "<a student>" + vbCr
        data += "<id>" + id + "</id>" + vbCr
        data += "<name>" + name + "</name>" + vbCr
        data += "<dur>" + dur.ToString + "</dur>" + vbCr
        data += "<prog>" + prog + "</prog>" + vbCr
        data += "<memo>" + memo + "</memo>" + vbCr + "</a>"

        data += midReturn("<students>", "</students>", ReadData())

        SaveData("<students>" + data + "</students>")
    End Sub

    Public Sub RemoveStudentbyid(id As String)
        Dim tmp As String = ReadData()

retry:
        If tmp.Contains("<a student>") Then
            Dim FirstStart As Long = tmp.IndexOf("<a student>")
            Dim part = Trim(Mid$(tmp, FirstStart, tmp.Substring(FirstStart).IndexOf("</a>") + 5))
            tmp = Mid(tmp, tmp.Substring(FirstStart).IndexOf("</a>") + 1)
            'MsgBox(part)
            If getData(part, "id") = id Then
                SaveData(ReadData().Replace(part, ""))
            Else
                GoTo retry
            End If

        End If

    End Sub

    Public Sub SaveData(data As String)
        My.Computer.FileSystem.WriteAllText(saveloc, data, False, System.Text.Encoding.GetEncoding(949))
    End Sub

    Public Sub SaveListData(data As String)
        My.Computer.FileSystem.WriteAllText(listsaveloc, data, False, System.Text.Encoding.GetEncoding(949))
    End Sub

    Public Function ReadData() As String
        If My.Computer.FileSystem.FileExists(saveloc) Then
            Return My.Computer.FileSystem.ReadAllText(saveloc, System.Text.Encoding.GetEncoding(949))
        Else
            MsgBox("학생 정보 저장 파일을 찾을 수 없습니다.", vbCritical)
            Return Nothing
        End If
    End Function

    Public Function ReadListData() As String
        If My.Computer.FileSystem.FileExists(listsaveloc) Then
            Return My.Computer.FileSystem.ReadAllText(listsaveloc, System.Text.Encoding.GetEncoding(949))
        Else
            MsgBox("목록 저장 파일을 찾을 수 없습니다.", vbCritical)
            Return Nothing
        End If
    End Function

    Public Function midReturn(ByVal first As String, ByVal last As String, ByRef total As String)
        If total.Contains(first) Then
            Dim FirstStart As Long = total.IndexOf(first) + first.Length + 1
            Return Trim(Mid$(total, FirstStart, total.Substring(FirstStart).IndexOf(last) + 1))
        Else
            Return Nothing
        End If
    End Function


    '중간의 문자열을 여러개 List로 리턴하는 함수
    Public Function multipleMidReturn(ByVal first As String, ByVal last As String, ByRef total As String) As List(Of String)
        If total.Contains(first) Then
            Dim tmptotal = total
            Dim res As New List(Of String)

            While tmptotal.Contains(first) = True
                Dim FirstStart As Long = tmptotal.IndexOf(first) + first.Length + 1
                res.Add(Trim(Mid$(tmptotal, FirstStart, tmptotal.Substring(FirstStart).IndexOf(last) + 1)))
                tmptotal = Mid(tmptotal, FirstStart, tmptotal.Length)
            End While

            Return res
        Else
            Return Nothing
        End If
    End Function

    'xml형식 파일을 전체값에서 따로 추출하는 함수
    Public Function getData(datastr As String, name As String) As String
        Return midReturn("<" + name + ">", "</" + name + ">", datastr)
    End Function

    Public Function getDatas(datastr As String, name As String) As List(Of String)
        Return multipleMidReturn("<" + name + ">", "</" + name + ">", datastr)
    End Function

End Module
