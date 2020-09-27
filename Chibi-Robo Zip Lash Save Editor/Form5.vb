Public Class Form5
    Dim fdialog As New Form2
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If NumericUpDown1.Value = 0 Then
            NumericUpDown1.Value = 1
        ElseIf NumericUpDown1.Value = 1 Then
            NumericUpDown1.Value = 0
            End If
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        If NumericUpDown1.Value = 0 Then
            PictureBox3.Image = My.Resources.geant_v
        End If
        If NumericUpDown1.Value = 1 Then
            PictureBox3.Image = My.Resources.geant1
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If NumericUpDown2.Value = 0 Then
            NumericUpDown2.Value = 1
        ElseIf NumericUpDown2.Value = 1 Then
            NumericUpDown2.Value = 0
        End If
    End Sub

    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown2.ValueChanged
        If NumericUpDown2.Value = 0 Then
            PictureBox4.Image = My.Resources.geant_v
        End If
        If NumericUpDown2.Value = 1 Then
            PictureBox4.Image = My.Resources.geant2
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        If NumericUpDown3.Value = 0 Then
            NumericUpDown3.Value = 1
        ElseIf NumericUpDown3.Value = 1 Then
            NumericUpDown3.Value = 0
        End If
    End Sub

    Private Sub NumericUpDown3_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown3.ValueChanged
        If NumericUpDown3.Value = 0 Then
            PictureBox5.Image = My.Resources.geant_v
        End If
        If NumericUpDown3.Value = 1 Then
            PictureBox5.Image = My.Resources.geant3
        End If
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        If NumericUpDown4.Value = 0 Then
            NumericUpDown4.Value = 1
        ElseIf NumericUpDown4.Value = 1 Then
            NumericUpDown4.Value = 0
        End If
    End Sub

    Private Sub NumericUpDown4_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown4.ValueChanged
        If NumericUpDown4.Value = 0 Then
            PictureBox6.Image = My.Resources.geant_v
        End If
        If NumericUpDown4.Value = 1 Then
            PictureBox6.Image = My.Resources.geant4
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If NumericUpDown5.Value = 0 Then
            NumericUpDown5.Value = 1
        ElseIf NumericUpDown5.Value = 1 Then
            NumericUpDown5.Value = 2
        ElseIf NumericUpDown5.Value = 2 Then
            NumericUpDown5.Value = 3
        ElseIf NumericUpDown5.Value = 3 Then
            NumericUpDown5.Value = 4
        ElseIf NumericUpDown5.Value = 4 Then
            NumericUpDown5.Value = 5
        ElseIf NumericUpDown5.Value = 5 Then
            NumericUpDown5.Value = 0
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If NumericUpDown6.Value = 0 Then
            NumericUpDown6.Value = 1
        ElseIf NumericUpDown6.Value = 1 Then
            NumericUpDown6.Value = 2
        ElseIf NumericUpDown6.Value = 2 Then
            NumericUpDown6.Value = 3
        ElseIf NumericUpDown6.Value = 3 Then
            NumericUpDown6.Value = 4
        ElseIf NumericUpDown6.Value = 4 Then
            NumericUpDown6.Value = 5
        ElseIf NumericUpDown6.Value = 5 Then
            NumericUpDown6.Value = 0
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Me.Close()
    End Sub

    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click
        Me.Close()
    End Sub

    Private Sub NumericUpDown5_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown5.ValueChanged
        If NumericUpDown5.Value = 0 Then
            PictureBox1.Image = My.Resources.batteriev
        End If
        If NumericUpDown5.Value = 1 Then
            PictureBox1.Image = My.Resources.batterie1
        End If
        If NumericUpDown5.Value = 2 Then
            PictureBox1.Image = My.Resources.batterie2
        End If
        If NumericUpDown5.Value = 3 Then
            PictureBox1.Image = My.Resources.batterie3
        End If
        If NumericUpDown5.Value = 4 Then
            PictureBox1.Image = My.Resources.batterie4
        End If
        If NumericUpDown5.Value = 5 Then
            PictureBox1.Image = My.Resources.batterie5
        End If
    End Sub

    Private Sub NumericUpDown6_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown6.ValueChanged
        If NumericUpDown6.Value = 0 Then
            PictureBox2.Image = My.Resources.réacteurv
        End If
        If NumericUpDown6.Value = 1 Then
            PictureBox2.Image = My.Resources.réacteur1
        End If
        If NumericUpDown6.Value = 2 Then
            PictureBox2.Image = My.Resources.réacteur2
        End If
        If NumericUpDown6.Value = 3 Then
            PictureBox2.Image = My.Resources.réacteur3
        End If
        If NumericUpDown6.Value = 4 Then
            PictureBox2.Image = My.Resources.réacteur4
        End If
        If NumericUpDown6.Value = 5 Then
            PictureBox2.Image = My.Resources.réacteur5
        End If
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.ComboBox1.SelectedItem = Form1.ComboBox1.Items.Item(0) Then
            Label7.Text = "Close"
            Label7.Location = New Point(47, 10)
        End If
        If Form1.ComboBox1.SelectedItem = Form1.ComboBox1.Items.Item(1) Then
            Label7.Text = "Fermer"
            Label7.Location = New Point(45, 10)
        End If
        NumericUpDown1.Value = Form1.NumericUpDown6.Value
        NumericUpDown2.Value = Form1.NumericUpDown7.Value
        NumericUpDown3.Value = Form1.NumericUpDown8.Value
        NumericUpDown4.Value = Form1.NumericUpDown9.Value
        NumericUpDown5.Value = Form1.NumericUpDown10.Value
        NumericUpDown6.Value = Form1.NumericUpDown11.Value
    End Sub
    Private Sub Form5_FormClosing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        Form1.NumericUpDown6.Value = NumericUpDown1.Value
        Form1.NumericUpDown7.Value = NumericUpDown2.Value
        Form1.NumericUpDown8.Value = NumericUpDown3.Value
        Form1.NumericUpDown9.Value = NumericUpDown4.Value
        Form1.NumericUpDown10.Value = NumericUpDown5.Value
        Form1.NumericUpDown11.Value = NumericUpDown6.Value
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        If Form1.ComboBox1.SelectedItem = Form1.ComboBox1.Items.Item(0) Then
            fdialog.Label1.Text = "Click for edit items (appears when 6-F is unlocked)"
            fdialog.ShowDialog()
        End If
        If Form1.ComboBox1.SelectedItem = Form1.ComboBox1.Items.Item(1) Then
            fdialog.Label1.Text = "Cliquez pour editer les objets (apparaît lorsque 6-F est débloqué)"
            fdialog.ShowDialog()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        If Form1.ComboBox1.SelectedItem = Form1.ComboBox1.Items.Item(0) Then
            fdialog.Label1.Text = "Click for edit items"
            fdialog.ShowDialog()
        End If
        If Form1.ComboBox1.SelectedItem = Form1.ComboBox1.Items.Item(1) Then
            fdialog.Label1.Text = "Cliquez pour editer les objets"
            fdialog.ShowDialog()
        End If
    End Sub
End Class