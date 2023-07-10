Public Class Form2

    Dim BT As Integer
    Dim AT As Integer
    Dim Prio As Integer
    Dim ST As Integer
    Dim ET As Integer
    Dim WT As Integer
    Dim TA As Integer
    Dim RT As Integer
    Dim flag As Integer


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim zel As ListViewItem = ListView1.Items.Add(TextBox1.Text)

        zel.SubItems.Add(TextBox2.Text)
        zel.SubItems.Add(TextBox3.Text)

        Button1.Enabled = True
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class