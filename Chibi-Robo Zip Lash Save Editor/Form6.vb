Public Class Form6

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Me.Close()
    End Sub

    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click
        Me.Close()
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.ComboBox1.SelectedItem = Form1.ComboBox1.Items.Item(0) Then
            Label7.Text = "Close"
            Label7.Location = New Point(48, 10)
        End If
        If Form1.ComboBox1.SelectedItem = Form1.ComboBox1.Items.Item(1) Then
            Label7.Text = "Fermer"
            Label7.Location = New Point(45, 10)
        End If
    End Sub
End Class