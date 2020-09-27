Public Class Form4
    Dim fdialog As New Form2
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.ComboBox1.SelectedItem = Form1.ComboBox1.Items.Item(0) Then
            Label7.Text = "Close"
            Label7.Location = New Point(48, 10)
            RadioButton1.Text = "Link"
            RadioButton2.Text = "Unlink"
            RadioButton4.Text = "Do Nothing"
            RadioButton7.Text = "Unlock"
            RadioButton5.Text = "Delete"
            RadioButton6.Text = "Do Nothing"
        End If
        If Form1.ComboBox1.SelectedItem = Form1.ComboBox1.Items.Item(1) Then
            Label7.Text = "Fermer"
            Label7.Location = New Point(45, 10)
            RadioButton1.Text = "Lier"
            RadioButton2.Text = "Dé-lier"
            RadioButton4.Text = "Ne rien faire"
            RadioButton7.Text = "Débloquer"
            RadioButton5.Text = "Effacer"
            RadioButton6.Text = "Ne rien faire"
        End If
        If Form1.Label3.Text = "Link" Then
            RadioButton1.Checked = True
        End If
        If Form1.Label3.Text = "Unlink" Then
            RadioButton2.Checked = True
        End If
        If Form1.Label3.Text = "Nothing" Then
            RadioButton4.Checked = True
        End If
        If Form1.Label6.Text = "Extra" Then
            RadioButton7.Checked = True
        End If
        If Form1.Label6.Text = "Delete" Then
            RadioButton5.Checked = True
        End If
        If Form1.Label6.Text = "Nothing" Then
            RadioButton6.Checked = True
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Me.Close()
    End Sub

    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click
        Me.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            Form1.Label3.Text = "Link"
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            Form1.Label3.Text = "Unlink"
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            Form1.Label3.Text = "Nothing"
        End If
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        If RadioButton7.Checked = True Then
            Form1.Label6.Text = "Extra"
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = True Then
            Form1.Label6.Text = "Delete"
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked = True Then
            Form1.Label6.Text = "Nothing"
        End If
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        If Form1.ComboBox1.SelectedItem = Form1.ComboBox1.Items.Item(0) Then
            fdialog.Label1.Text = "Unlock in-game extras normally" & vbNewLine & "unlocked by scanning an Amiibo"
            fdialog.ShowDialog()
        End If
        If Form1.ComboBox1.SelectedItem = Form1.ComboBox1.Items.Item(1) Then
            fdialog.Label1.Text = "Depuis l'écran de sélection de sauvegarde" & vbNewLine & "Accédez au Menu amiibo pour débloquer les extras amiibo"
            fdialog.ShowDialog()
        End If
    End Sub
End Class