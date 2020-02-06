Public Class Generate_Barcode

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim Barcode, Check12Digit As String
        If Not (String.IsNullOrEmpty(TextBox1.Text)) Then
            Check12Digit = TextBox1.Text.PadRight(12, CChar("0"))
            Barcode = EAN13(Check12Digit)
            Label4.Text = Barcode
            If Not (String.IsNullOrEmpty(Barcode12Digits)) And
                Not Barcode12Digits = "" Then
                RichTextBox1.Text = Barcode12Digits.Trim.ToString()
                Dim intstart As Int16 = Convert.ToInt16(RichTextBox1.TextLength - 1)
                




            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        LoginScreen.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PrintDocument1.PrinterSettings.Copies = 1
        PrintDocument1.Print()

    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(Label4.Text, Label4.Font, Brushes.Black, 100, 100)

    End Sub
End Class