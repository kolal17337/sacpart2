Public Class Form1
    Dim engmarks As Integer = 0
    Dim mathsmarks As Integer = 0
    Dim pemarks As Integer = 0
    Dim rows As Integer = 0
    Dim sr As New System.IO.StreamReader("u:\kolal17337\My Documents\My Pictures\markdata.csv")

    Private Sub btn_calculate_Click(sender As Object, e As EventArgs) Handles btn_calculate.Click
        Do Until sr.EndOfStream = True
            lbl_read.Text = sr.ReadLine & vbNewLine
            Dim marksarray() As String = Split(lbl_read.Text, Delimiter:=",")

            lbl_engmarks.Text = marksarray(1)
            If IsNumeric(marksarray(1)) Then
                engmarks = lbl_engmarks.Text + engmarks
                rows = rows + 1
            End If

            lbl_mathsmarks.Text = marksarray(2)
            If IsNumeric(marksarray(2)) Then
                mathsmarks = lbl_mathsmarks.Text + mathsmarks
            End If

            lbl_pemarks.Text = marksarray(3)
            If IsNumeric(marksarray(3)) Then
                pemarks = lbl_pemarks.Text + pemarks
            End If

            lbl_engavg.Text = "The average english mark is: " & engmarks / rows
            lbl_mathavg.Text = "The average maths mark is: " & mathsmarks / rows
            lbl_peavg.Text = "The average pe mark is: " & pemarks / rows
        Loop
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbl_read.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles lbl_engavg.Click

    End Sub
End Class
