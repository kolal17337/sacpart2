Public Class Form1
    Dim sr As New System.IO.StreamReader("u:\kolal17337\My Documents\My Pictures\markdata.csv")
    Dim marksarray2(100, 100) As String

    Private Sub btn_calculate_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        Dim y As Integer = 0
        Dim z As Integer = 0
        Dim a As Integer = 0
        Dim x As Integer = 0

        Do Until sr.EndOfStream = True
            lbl_read.Text = sr.ReadLine & vbNewLine
            Dim marksarray() As String = Split(lbl_read.Text, Delimiter:=",")

            lblNames.Text = marksarray(0)
            marksarray2(x, 0) = lblNames.Text
            x = x + 1

            lbl_engmarks.Text = marksarray(1)
            marksarray2(y, 1) = lbl_engmarks.Text
            y = y + 1

            lbl_mathsmarks.Text = marksarray(2)
            marksarray2(z, 2) = lbl_mathsmarks.Text
            z = z + 1

            lbl_pemarks.Text = marksarray(3)
            marksarray2(a, 3) = lbl_pemarks.Text
            a = a + 1

        Loop
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim strName
        Dim c As Integer = 0
        strName = InputBox("What is the name of the student?")
        While c < 7
            If marksarray2(c, 0) = strName Then
                MsgBox("The person's marks are " & marksarray2(c, 1) & " for English, " & marksarray2(c, 2) & " for Maths, and " & marksarray2(c, 3) & " for PE.")
                c = c + 1
            Else
                c = c + 1
            End If
        End While
    End Sub
End Class
