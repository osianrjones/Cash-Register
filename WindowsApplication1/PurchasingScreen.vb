Imports System.IO

Public Class PurchasingScreen

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
   
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim listofnames As New List(Of String)
        Dim listofcheckdigits As New List(Of String)
        Dim CheckDigit() As String
        TextBox1.Clear()

        For Each Line In File.ReadAllLines("CheckDigits.txt")
            If Line.Contains(TextBox1.Text) Then
                CheckDigit = Line.Split("=")
                For i = 0 To UBound(CheckDigit)
                    If (IsNumeric(CheckDigit)) = False Then

                        listofnames.Add(CheckDigit(i))

                    Else
                        listofcheckdigits.Add(CheckDigit(i))




                    End If

                Next i






            End If
        Next







    End Sub

    Private Sub PurchasingScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        Me.TextBox1.AppendText(1)

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Me.TextBox1.AppendText(2)

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Me.TextBox1.AppendText(3)

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Me.TextBox1.AppendText(4)

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.TextBox1.AppendText(5)

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.TextBox1.AppendText(6)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.TextBox1.AppendText(7)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.TextBox1.AppendText(8)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.TextBox1.AppendText(9)

    End Sub

    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.TextBox1.AppendText(0)
        
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Count - 1)




    End Sub
End Class