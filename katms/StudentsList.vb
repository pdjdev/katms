Public Class StudentsList
    Dim count As Integer = 0
    Dim autosave As Boolean = True
    Public askread As Boolean = False

    Dim orderMode As String = ""
    Dim desc As Boolean = False

    Dim shown = False

    Public Sub Add_Student(sdata As String)
        '항목 추가
        Dim newPanel As New StudentPanel
        newPanel.Dock = DockStyle.Top

        'newPanel.DeviceData = DeviceItemData(count)
        '디바이스의 이름으로 디바이스패널 이름 지정 -> 나중에 삭제할때 중요함!!

        Dim starttime As Date = Date.Now
        Dim endtime As Date = starttime.AddMinutes(Convert.ToInt32(getData(sdata, "dur")))

        With newPanel
            .Name = "std_" + count.ToString
            .SIDLabel.Text = getData(sdata, "id")
            .SNameLabel.Text = getData(sdata, "name")
            .StartTimeLabel.Text = starttime.ToString("tt hh:mm")
            .EndTimeLabel.Text = endtime.ToString("tt hh:mm")
            .ProgramLabel.Text = getData(sdata, "prog")
        End With

        ListPanel.Controls.Add(newPanel)
        count += 1

        If Not orderMode = "" Then
            ListSorting(orderMode, desc)
        End If

        If autosave Then SaveList()
    End Sub

    Private Sub StudentsList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        shown = False

        Dim locdata As String = GetINI("listloc")

        If locdata.Contains(",") Then
            Dim loc = locdata.Split(",")
            If IsNumeric(Trim(loc(0))) And IsNumeric(Trim(loc(1))) Then
                SetDesktopLocation(Convert.ToInt32(loc(0)), Convert.ToInt32(loc(1)))
            End If
        End If

        Dim sizedata As String = GetINI("listsize")

        If sizedata.Contains(",") Then
            Dim siz = sizedata.Split(",")
            If IsNumeric(Trim(siz(0))) And IsNumeric(Trim(siz(1))) Then
                Width = Convert.ToInt32(siz(0))
                Height = Convert.ToInt32(siz(1))
            End If
        End If

        Dim tmp = ReadListData()
        If askread Then
            If Not tmp = Nothing Then
                If MsgBox("임시 저장된 목록이 있습니다. 불러오시겠습니까?" + vbCr + "(아니오를 누르면 빈 상태로 시작합니다)", vbQuestion + vbYesNo) = vbYes Then
                    LoadList(tmp)
                End If

                LoadList(tmp)

            End If
        Else
            LoadList(tmp)
        End If

        shown = True
    End Sub

    Public Sub StudentsList_Delete(name As String)

        For Each ctrls As StudentPanel In ListPanel.Controls
            If ctrls.Name = name Then
                ctrls.Dispose()
                Controls.Remove(ctrls)
            End If
        Next

        If autosave Then SaveList()
    End Sub

    Public Sub SaveList()
        Dim listdata As String = "<list>" + vbCr

        For Each ctrls As StudentPanel In ListPanel.Controls
            listdata += "<cell>" + vbCr
            listdata += "<id>" + ctrls.SIDLabel.Text + "</id>" + vbCr
            listdata += "<name>" + ctrls.SNameLabel.Text + "</name>" + vbCr
            listdata += "<stime>" + ctrls.StartTimeLabel.Text + "</stime>" + vbCr
            listdata += "<etime>" + ctrls.EndTimeLabel.Text + "</etime>" + vbCr
            listdata += "<prog>" + ctrls.ProgramLabel.Text + "</prog>" + vbCr
            listdata += "</cell>" + vbCr

        Next

        listdata += "</list>"

        SaveListData(listdata)
    End Sub

    Public Sub LoadList(data As String)

        TopMost = (GetINI("listtopmost") = "True")
        autosave = Not (GetINI("autosave") = "False")

        TopMostChk.Checked = TopMost
        AutoSaveChk.Checked = autosave

        Dim tmp = ReadListData()
retry:
        If tmp.Contains("<cell>") Then
            Dim FirstStart As Long = tmp.IndexOf("<cell>") + "<cell>".Length + 1
            Dim part = Trim(Mid$(tmp, FirstStart, tmp.Substring(FirstStart).IndexOf("</cell>") + 1))

            tmp = Mid(tmp, tmp.Substring(FirstStart).IndexOf("</cell>") + 1)
            'MsgBox(part)
            Dim newPanel As New StudentPanel
            newPanel.Dock = DockStyle.Top

            With newPanel
                .Name = "std_" + count.ToString
                .SIDLabel.Text = getData(part, "id")
                .SNameLabel.Text = getData(part, "name")
                .StartTimeLabel.Text = getData(part, "stime")
                .EndTimeLabel.Text = getData(part, "etime")
                .ProgramLabel.Text = getData(part, "prog")
            End With

            ListPanel.Controls.Add(newPanel)
            count += 1

            GoTo retry

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        StudentEnter.ReloadList()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("정말로 비우시겠습니까? (현재 목록 항목과 저장정보가 모두 지워집니다)", vbQuestion + vbYesNo) = vbYes Then
            SaveListData("")
            StudentEnter.ReloadList()
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles AutoSaveChk.CheckedChanged
        autosave = AutoSaveChk.Checked
        If shown Then SetINI("autosave", autosave.ToString)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles TopMostChk.CheckedChanged
        TopMost = TopMostChk.Checked
        If shown Then SetINI("listtopmost", TopMost.ToString)
    End Sub

    Sub ListSorting(type As String, desc As Boolean)

        If type = "" Then Exit Sub

        Dim spanels As New List(Of StudentPanel)

        For Each c As StudentPanel In ListPanel.Controls
            spanels.Add(c)
        Next

        Select Case type
            Case "stime"
                If Not desc Then
                    spanels = spanels.OrderBy(Function(x) Convert.ToDateTime(x.StartTimeLabel.Text.ToString)).ToList
                Else
                    spanels = spanels.OrderByDescending(Function(x) Convert.ToDateTime(x.StartTimeLabel.Text.ToString)).ToList
                End If
            Case "etime"
                If Not desc Then
                    spanels = spanels.OrderBy(Function(x) Convert.ToDateTime(x.EndTimeLabel.Text.ToString)).ToList
                Else
                    spanels = spanels.OrderByDescending(Function(x) Convert.ToDateTime(x.EndTimeLabel.Text.ToString)).ToList
                End If
        End Select

        For Each sort_c As StudentPanel In spanels
            sort_c.BringToFront()
        Next

    End Sub

    Private Sub STimeHeaderLabel_Click(sender As Object, e As EventArgs) Handles STimeHeaderLabel.Click
        If orderMode = "stime" Then desc = Not desc
        orderMode = "stime"

        STimeHeaderLabel.Text = "입 실 시 간 "
        ETimeHeaderLabel.Text = "종 료 시 간 "
        If desc Then
            STimeHeaderLabel.Text += "▼"
        Else
            STimeHeaderLabel.Text += "▲"
        End If

        ListSorting(orderMode, desc)
    End Sub

    Private Sub ETimeHeaderLabel_Click(sender As Object, e As EventArgs) Handles ETimeHeaderLabel.Click
        If orderMode = "etime" Then desc = Not desc
        orderMode = "etime"

        STimeHeaderLabel.Text = "입 실 시 간 "
        ETimeHeaderLabel.Text = "종 료 시 간 "
        If desc Then
            ETimeHeaderLabel.Text += "▼"
        Else
            ETimeHeaderLabel.Text += "▲"
        End If

        ListSorting(orderMode, desc)
    End Sub

    Private Sub HeaderLabel_MouseEnter(sender As Object, e As EventArgs) Handles STimeHeaderLabel.MouseEnter, ETimeHeaderLabel.MouseEnter
        sender.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub HeaderLabel_MouseLeave(sender As Object, e As EventArgs) Handles STimeHeaderLabel.MouseLeave, ETimeHeaderLabel.MouseLeave
        sender.BackColor = Color.Transparent
    End Sub

    Private Sub StudentsList_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If shown Then SetINI("listsize", Width.ToString + "," + Height.ToString)
    End Sub

    Private Sub StudentsList_LocationChanged(sender As Object, e As EventArgs) Handles MyBase.LocationChanged
        If shown Then SetINI("listloc", Location.X.ToString + "," + Location.Y.ToString)
    End Sub
End Class