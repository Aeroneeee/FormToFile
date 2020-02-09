Public Class Form1

    Dim countTxt, countXml, countJson As Byte
    Dim ToFile As String

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Application.Exit()
    End Sub
    Public Sub NumberOnly(ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8) Then
            ErrorProvider1.Clear()

        Else
            e.Handled = True
            ErrorProvider1.SetError(agetxtbox, "Please Enter Number Only")

        End If

    End Sub

    Private Sub agetxtbox_KeyPress(sender As Object, e As EventArgs) Handles agetxtbox.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub Txt_Click(sender As Object, e As EventArgs) Handles Txt.Click

        If SaveFileAs(countTxt, ".txt") Then
            countTxt += 1
        End If

    End Sub


    Private Sub Xml_Click(sender As Object, e As EventArgs) Handles Xml.Click

        If SaveFileAs(countXml, ".xml") Then
            countXml += 1
        End If

    End Sub


    Private Sub Json_Click(sender As Object, e As EventArgs) Handles Json.Click

        If SaveFileAs(countJson, ".json") Then
            countJson += 1
        End If

    End Sub

    Private Function SaveFileAs(count As Byte, fileType As String)
        If nametxtbox.Text <> "" And agetxtbox.Text <> "" And addresstxtbox.Text <> "" Then

            ToFile = String.Concat(nametxtbox.Text,
                                   Environment.NewLine,
                                   agetxtbox.Text,
                                   Environment.NewLine,
                                   addresstxtbox.Text)

            My.Computer.FileSystem.WriteAllText("C:\Users\Aerone\Documents\Visual Studio 2019\FormToFile\SavedFile" & count & fileType, "" & ToFile, True)

            MsgBox("Successfully saved the file.", MsgBoxStyle.Information, "Successfully Saved")

            nametxtbox.Clear()
            agetxtbox.Clear()
            addresstxtbox.Clear()

            Return True

        Else

            MsgBox("Please write all information.", MsgBoxStyle.Critical, "Input Data")
            Return False

        End If

    End Function



    Private Sub closeBtn_MouseHover(sender As Object, e As EventArgs) Handles closeBtn.MouseHover
        closeBtn.BackColor = Color.Pink
    End Sub

    Private Sub closeBtn_MouseLeave(sender As Object, e As EventArgs) Handles closeBtn.MouseLeave
        closeBtn.BackColor = Color.Transparent
    End Sub

    Private Sub Txt_MouseHover(sender As Object, e As EventArgs) Handles Txt.MouseHover
        Txt.Size = New Size(75, 90)
        Txt.Location = New Point(24, 298)
    End Sub

    Private Sub Txt_MouseLeave(sender As Object, e As EventArgs) Handles Txt.MouseLeave
        Txt.Size = New Size(70, 85)
        Txt.Location = New Point(26, 300)
    End Sub

    Private Sub Xml_MouseHover(sender As Object, e As EventArgs) Handles Xml.MouseHover
        Xml.Size = New Size(75, 90)
        Xml.Location = New Point(124, 298)
    End Sub

    Private Sub Xml_MouseLeave(sender As Object, e As EventArgs) Handles Xml.MouseLeave
        Xml.Size = New Size(70, 85)
        Xml.Location = New Point(126, 300)
    End Sub

    Private Sub Json_MouseHover(sender As Object, e As EventArgs) Handles Json.MouseHover
        Json.Size = New Size(75, 90)
        Json.Location = New Point(226, 298)
    End Sub

    Private Sub Json_MouseLeave(sender As Object, e As EventArgs) Handles Json.MouseLeave
        Json.Size = New Size(70, 85)
        Json.Location = New Point(228, 300)
    End Sub

End Class
