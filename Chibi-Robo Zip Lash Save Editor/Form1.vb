Imports PackageIO
Public Class Form1
    Dim filepath As String
    Dim Cash As String
    Dim fdialog As New Form2
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim open As New OpenFileDialog
        open.Title = "Open save C3_SAVEDATA_X"
        fdialog.Label1.Text = "                             Open C3_SAVEDATA_X" & vbNewLine & "                 Backup your save before use this editor"
        fdialog.ShowDialog()
        open.ShowDialog()
        filepath = open.FileName
        Readfile()

    End Sub
    Private Sub Readfile()
        Try
            Dim Reader As New PackageIO.Reader(filepath, PackageIO.Endian.Little)
            Reader.Position = &H2A5C
            Cash = Reader.Position
            NumericUpDown1.Value = Reader.ReadInt32
        Catch ex As Exception
            fdialog.Label1.Text = "     Save Game is Corrupted or not a Chibi-Robo ZL Save"
            fdialog.ShowDialog()
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
            Writer.Position = &H11E8
            Writer.WriteInt32(1232348144)
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
            Writer.Position = &H11D8
            Writer.WriteInt8(15)
            Writer.Position = &H11D9
            Writer.WriteInt8(38)
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
            Writer.Position = &H11D8
            Writer.WriteInt8(70)
            Writer.Position = &H11D9
            Writer.WriteInt8(23)
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        WriteFile()
    End Sub
    Private Sub WriteFile()
        Try
            Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
            Writer.Position = Cash
            Writer.WriteInt32(NumericUpDown1.Value)
            fdialog.Label1.Text = "                                        File Save"
            fdialog.ShowDialog()
        Catch ex As Exception
            fdialog.Label1.Text = "                        An error has occurred"
            fdialog.ShowDialog()
        End Try
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Big)
            Writer.Position = &H1131
            Writer.WriteUInt16(55040)
            Writer.Position = &H2E24
            Writer.WriteInt32(142412388)
            Writer.Position = &H2E28
            Writer.WriteInt32(77932602)
            Writer.Position = &H2E2C
            Writer.WriteUInt32(2236186880)
            Writer.Position = &H2E32
            Writer.WriteUInt16(1823)
            Writer.Position = &H2E48
            Writer.WriteInt16(3584)
            fdialog.Label1.Text = "                         Since the selection file game" & vbNewLine & "          Access to amiibo's menu for unlock extras amiibo"
            fdialog.ShowDialog()
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Big)
            Writer.Position = &H2E4C
            Writer.WriteInt32(77932602)
            Writer.Position = &H2E50
            Writer.WriteUInt32(2236186880)
            Writer.Position = &H2E54
            Writer.WriteInt32(1823)
            Writer.Position = &H2E6C
            Writer.WriteInt16(3072)
            fdialog.Label1.Text = "                             amiibo Chibi-Robo linked"
            fdialog.ShowDialog()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "World 2" Then
            Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Big)
            Writer.Position = &H424
            Writer.WriteInt16(512)
        End If
        If ComboBox1.Text = "World 1" Then
            Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Big)
            Writer.Position = &H424
            Writer.WriteInt16(256)
        End If
        If ComboBox1.Text = "World 3" Then
            Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Big)
            Writer.Position = &H424
            Writer.WriteInt16(768)
        End If
        If ComboBox1.Text = "World 4" Then
            Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Big)
            Writer.Position = &H424
            Writer.WriteInt16(1024)
        End If
        If ComboBox1.Text = "World 5" Then
            Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Big)
            Writer.Position = &H424
            Writer.WriteInt16(1280)
        End If
        If ComboBox1.Text = "World 6" Then
            Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Big)
            Writer.Position = &H424
            Writer.WriteInt16(1536)
        End If
        If ComboBox1.Text = "World 7" Then
            Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Big)
            Writer.Position = &H424
            Writer.WriteInt16(1792)
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text = "Level 1" Then
            Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Big)
            Writer.Position = &H428
            Writer.WriteInt16(256)
        End If
        If ComboBox2.Text = "Level 2" Then
            Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Big)
            Writer.Position = &H428
            Writer.WriteInt16(512)
        End If
        If ComboBox2.Text = "Level 3" Then
            Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Big)
            Writer.Position = &H428
            Writer.WriteInt16(768)
        End If
        If ComboBox2.Text = "Level 4" Then
            Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Big)
            Writer.Position = &H428
            Writer.WriteInt16(1024)
        End If
        If ComboBox2.Text = "Level 5" Then
            Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Big)
            Writer.Position = &H428
            Writer.WriteInt16(1280)
        End If
        If ComboBox2.Text = "Level 6" Then
            Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Big)
            Writer.Position = &H428
            Writer.WriteInt16(1536)
        End If
        If ComboBox2.Text = "Boss level" Then
            Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Big)
            Writer.Position = &H428
            Writer.WriteInt16(1792)
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Big)
            Writer.Position = &H2A63
            Writer.WriteInt16(200)
            Writer.Position = &H2A65
            Writer.WriteInt16(0)
            Writer.Position = &H2A67
            Writer.WriteInt16(1)
            Writer.Position = &H2A69
            Writer.WriteInt16(2)
            Writer.Position = &H2A6B
            Writer.WriteInt16(3)
            Writer.Position = &H2A6D
            Writer.WriteInt16(4)
            Writer.Position = &H2A6F
            Writer.WriteInt16(5)
            Writer.Position = &H2A71
            Writer.WriteInt16(6)
            Writer.Position = &H2A73
            Writer.WriteInt16(7)
            Writer.Position = &H2A75
            Writer.WriteInt16(8)
            Writer.Position = &H2A77
            Writer.WriteInt16(9)
            Writer.Position = &H2A79
            Writer.WriteInt16(10)
            Writer.Position = &H2A7B
            Writer.WriteInt16(11)
            Writer.Position = &H2A7D
            Writer.WriteInt16(12)
            Writer.Position = &H2A7F
            Writer.WriteInt16(13)
            Writer.Position = &H2A81
            Writer.WriteInt16(14)
            Writer.Position = &H2A83
            Writer.WriteInt16(15)
            Writer.Position = &H2A85
            Writer.WriteInt16(16)
            Writer.Position = &H2A87
            Writer.WriteInt16(17)
            Writer.Position = &H2A89
            Writer.WriteInt16(18)
            Writer.Position = &H2A8B
            Writer.WriteInt16(19)
            Writer.Position = &H2A8D
            Writer.WriteInt16(20)
            Writer.Position = &H2A8F
            Writer.WriteInt16(21)
            Writer.Position = &H2A91
            Writer.WriteInt16(22)
            Writer.Position = &H2A93
            Writer.WriteInt16(23)
            Writer.Position = &H2A95
            Writer.WriteInt16(24)
            Writer.Position = &H2A97
            Writer.WriteInt16(25)
            Writer.Position = &H2A99
            Writer.WriteInt16(26)
            Writer.Position = &H2A9B
            Writer.WriteInt16(27)
            Writer.Position = &H2A9D
            Writer.WriteInt16(28)
            Writer.Position = &H2A9F
            Writer.WriteInt16(29)
            Writer.Position = &H2AA1
            Writer.WriteInt16(30)
            Writer.Position = &H2AA3
            Writer.WriteInt16(31)
            Writer.Position = &H2AA5
            Writer.WriteInt16(32)
            Writer.Position = &H2AA7
            Writer.WriteInt16(33)
            Writer.Position = &H2AA9
            Writer.WriteInt16(34)
            Writer.Position = &H2AAB
            Writer.WriteInt16(35)
            Writer.Position = &H2AAD
            Writer.WriteInt16(36)
            Writer.Position = &H2AAF
            Writer.WriteInt16(37)
            Writer.Position = &H2AB1
            Writer.WriteInt16(38)
            Writer.Position = &H2AB3
            Writer.WriteInt16(39)
            Writer.Position = &H2AB5
            Writer.WriteInt16(40)
            Writer.Position = &H2AB7
            Writer.WriteInt16(41)
            Writer.Position = &H2AB9
            Writer.WriteInt16(42)
            Writer.Position = &H2ABB
            Writer.WriteInt16(43)
            Writer.Position = &H2ABD
            Writer.WriteInt16(44)
            Writer.Position = &H2ABF
            Writer.WriteInt16(45)
            Writer.Position = &H2AC1
            Writer.WriteInt16(46)
            Writer.Position = &H2AC3
            Writer.WriteInt16(47)
            Writer.Position = &H2AC5
            Writer.WriteInt16(48)
            Writer.Position = &H2AC7
            Writer.WriteInt16(49)
            Writer.Position = &H2AC9
            Writer.WriteInt16(50)
            Writer.Position = &H2ACB
            Writer.WriteInt16(51)
            Writer.Position = &H2ACD
            Writer.WriteInt16(52)
            Writer.Position = &H2ACF
            Writer.WriteInt16(53)
            Writer.Position = &H2AD1
            Writer.WriteInt16(54)
            Writer.Position = &H2AD3
            Writer.WriteInt16(55)
            Writer.Position = &H2AD5
            Writer.WriteInt16(56)
            Writer.Position = &H2AD7
            Writer.WriteInt16(57)
            Writer.Position = &H2AD9
            Writer.WriteInt16(58)
            Writer.Position = &H2ADB
            Writer.WriteInt16(59)
            Writer.Position = &H2ADD
            Writer.WriteInt16(60)
            Writer.Position = &H2ADF
            Writer.WriteInt16(61)
            Writer.Position = &H2AE1
            Writer.WriteInt16(62)
            Writer.Position = &H2AE3
            Writer.WriteInt16(63)
            Writer.Position = &H2AE5
            Writer.WriteInt16(64)
            Writer.Position = &H2AE7
            Writer.WriteInt16(65)
            Writer.Position = &H2AE9
            Writer.WriteInt16(66)
            Writer.Position = &H2AEB
            Writer.WriteInt16(67)
            Writer.Position = &H2AED
            Writer.WriteInt16(68)
            Writer.Position = &H2AEF
            Writer.WriteInt16(69)
            Writer.Position = &H2AF1
            Writer.WriteInt16(70)
            Writer.Position = &H2AF3
            Writer.WriteInt16(71)
            Writer.Position = &H2AF5
            Writer.WriteInt16(72)
            Writer.Position = &H2AF7
            Writer.WriteInt16(73)
            Writer.Position = &H2AF9
            Writer.WriteInt16(74)
            Writer.Position = &H2AFB
            Writer.WriteInt16(75)
            Writer.Position = &H2AFD
            Writer.WriteInt16(76)
            Writer.Position = &H2AFF
            Writer.WriteInt16(77)
            Writer.Position = &H2B01
            Writer.WriteInt16(78)
            Writer.Position = &H2B03
            Writer.WriteInt16(79)
            Writer.Position = &H2B05
            Writer.WriteInt16(80)
            Writer.Position = &H2B07
            Writer.WriteInt16(81)
            Writer.Position = &H2B09
            Writer.WriteInt16(82)
            Writer.Position = &H2B0B
            Writer.WriteInt16(83)
            Writer.Position = &H2B0D
            Writer.WriteInt16(84)
            Writer.Position = &H2B0F
            Writer.WriteInt16(85)
            Writer.Position = &H2B11
            Writer.WriteInt16(86)
            Writer.Position = &H2B13
            Writer.WriteInt16(87)
            Writer.Position = &H2B15
            Writer.WriteInt16(88)
            Writer.Position = &H2B17
            Writer.WriteInt16(89)
            Writer.Position = &H2B19
            Writer.WriteInt16(90)
            Writer.Position = &H2B1B
            Writer.WriteInt16(91)
            Writer.Position = &H2B1D
            Writer.WriteInt16(92)
            Writer.Position = &H2B1F
            Writer.WriteInt16(93)
            Writer.Position = &H2B21
            Writer.WriteInt16(94)
            Writer.Position = &H2B23
            Writer.WriteInt16(95)
            Writer.Position = &H2B25
            Writer.WriteInt16(96)
            Writer.Position = &H2B27
            Writer.WriteInt16(97)
            Writer.Position = &H2B29
            Writer.WriteInt16(98)
            Writer.Position = &H2B2B
            Writer.WriteInt16(99)
            Writer.Position = &H2B2D
            Writer.WriteInt16(100)
            Writer.Position = &H2B2F
            Writer.WriteInt16(101)
            Writer.Position = &H2B31
            Writer.WriteInt16(102)
            Writer.Position = &H2B33
            Writer.WriteInt16(103)
            Writer.Position = &H2B35
            Writer.WriteInt16(104)
            Writer.Position = &H2B37
            Writer.WriteInt16(105)
            Writer.Position = &H2B39
            Writer.WriteInt16(106)
            Writer.Position = &H2B3B
            Writer.WriteInt16(107)
            Writer.Position = &H2B3D
            Writer.WriteInt16(108)
            Writer.Position = &H2B3F
            Writer.WriteInt16(109)
            Writer.Position = &H2B41
            Writer.WriteInt16(110)
            Writer.Position = &H2B43
            Writer.WriteInt16(111)
            Writer.Position = &H2B45
            Writer.WriteInt16(112)
            Writer.Position = &H2B47
            Writer.WriteInt16(113)
            Writer.Position = &H2B49
            Writer.WriteInt16(114)
            Writer.Position = &H2B4B
            Writer.WriteInt16(115)
            Writer.Position = &H2B4D
            Writer.WriteInt16(116)
            Writer.Position = &H2B4F
            Writer.WriteInt16(117)
            Writer.Position = &H2B51
            Writer.WriteInt16(118)
            Writer.Position = &H2B53
            Writer.WriteInt16(119)
            Writer.Position = &H2B55
            Writer.WriteInt16(120)
            Writer.Position = &H2B57
            Writer.WriteInt16(121)
            Writer.Position = &H2B59
            Writer.WriteInt16(122)
            Writer.Position = &H2B5B
            Writer.WriteInt16(123)
            Writer.Position = &H2B5D
            Writer.WriteInt16(124)
            Writer.Position = &H2B5F
            Writer.WriteInt16(125)
            Writer.Position = &H2B61
            Writer.WriteInt16(126)
            Writer.Position = &H2B63
            Writer.WriteInt16(127)
            Writer.Position = &H2B65
            Writer.WriteInt16(128)
            Writer.Position = &H2B67
            Writer.WriteInt16(129)
            Writer.Position = &H2B69
            Writer.WriteInt16(130)
            Writer.Position = &H2B6B
            Writer.WriteInt16(131)
            Writer.Position = &H2B6D
            Writer.WriteInt16(132)
            Writer.Position = &H2B6F
            Writer.WriteInt16(133)
            Writer.Position = &H2B71
            Writer.WriteInt16(134)
            Writer.Position = &H2B73
            Writer.WriteInt16(135)
            Writer.Position = &H2B75
            Writer.WriteInt16(136)
            Writer.Position = &H2B77
            Writer.WriteInt16(137)
            Writer.Position = &H2B79
            Writer.WriteInt16(138)
            Writer.Position = &H2B7B
            Writer.WriteInt16(139)
            Writer.Position = &H2B7D
            Writer.WriteInt16(140)
            Writer.Position = &H2B7F
            Writer.WriteInt16(141)
            Writer.Position = &H2B81
            Writer.WriteInt16(142)
            Writer.Position = &H2B83
            Writer.WriteInt16(143)
            Writer.Position = &H2B85
            Writer.WriteInt16(144)
            Writer.Position = &H2B87
            Writer.WriteInt16(145)
            Writer.Position = &H2B89
            Writer.WriteInt16(146)
            Writer.Position = &H2B8B
            Writer.WriteInt16(147)
            Writer.Position = &H2B8D
            Writer.WriteInt16(148)
            Writer.Position = &H2B8F
            Writer.WriteInt16(149)
            Writer.Position = &H2B91
            Writer.WriteInt16(150)
            Writer.Position = &H2B93
            Writer.WriteInt16(151)
            Writer.Position = &H2B95
            Writer.WriteInt16(152)
            Writer.Position = &H2B97
            Writer.WriteInt16(153)
            Writer.Position = &H2B99
            Writer.WriteInt16(154)
            Writer.Position = &H2B9B
            Writer.WriteInt16(155)
            Writer.Position = &H2B9D
            Writer.WriteInt16(156)
            Writer.Position = &H2B9F
            Writer.WriteInt16(157)
            Writer.Position = &H2BA1
            Writer.WriteInt16(158)
            Writer.Position = &H2BA3
            Writer.WriteInt16(159)
            Writer.Position = &H2BA5
            Writer.WriteInt16(160)
            Writer.Position = &H2BA7
            Writer.WriteInt16(161)
            Writer.Position = &H2BA9
            Writer.WriteInt16(162)
            Writer.Position = &H2BAB
            Writer.WriteInt16(163)
            Writer.Position = &H2BAD
            Writer.WriteInt16(164)
            Writer.Position = &H2BAF
            Writer.WriteInt16(165)
            Writer.Position = &H2BB1
            Writer.WriteInt16(166)
            Writer.Position = &H2BB3
            Writer.WriteInt16(167)
            Writer.Position = &H2BB5
            Writer.WriteInt16(168)
            Writer.Position = &H2BB7
            Writer.WriteInt16(169)
            Writer.Position = &H2BB9
            Writer.WriteInt16(170)
            Writer.Position = &H2BBB
            Writer.WriteInt16(171)
            Writer.Position = &H2BBD
            Writer.WriteInt16(172)
            Writer.Position = &H2BBF
            Writer.WriteInt16(173)
            Writer.Position = &H2BC1
            Writer.WriteInt16(174)
            Writer.Position = &H2BC3
            Writer.WriteInt16(175)
            Writer.Position = &H2BC5
            Writer.WriteInt16(176)
            Writer.Position = &H2BC7
            Writer.WriteInt16(177)
            Writer.Position = &H2BC9
            Writer.WriteInt16(178)
            Writer.Position = &H2BCB
            Writer.WriteInt16(179)
            Writer.Position = &H2BCD
            Writer.WriteInt16(180)
            Writer.Position = &H2BCF
            Writer.WriteInt16(181)
            Writer.Position = &H2BD1
            Writer.WriteInt16(182)
            Writer.Position = &H2BD3
            Writer.WriteInt16(183)
            Writer.Position = &H2BD5
            Writer.WriteInt16(184)
            Writer.Position = &H2BD7
            Writer.WriteInt16(185)
            Writer.Position = &H2BD9
            Writer.WriteInt16(186)
            Writer.Position = &H2BDB
            Writer.WriteInt16(187)
            Writer.Position = &H2BDD
            Writer.WriteInt16(188)
            Writer.Position = &H2BDF
            Writer.WriteInt16(189)
            Writer.Position = &H2BE1
            Writer.WriteInt16(190)
            Writer.Position = &H2BE3
            Writer.WriteInt16(191)
            Writer.Position = &H2BE5
            Writer.WriteInt16(192)
            Writer.Position = &H2BE7
            Writer.WriteInt16(193)
            Writer.Position = &H2BE9
            Writer.WriteInt16(194)
            Writer.Position = &H2BEB
            Writer.WriteInt16(195)
            Writer.Position = &H2BED
            Writer.WriteInt16(196)
            Writer.Position = &H2BEF
            Writer.WriteInt16(197)
            Writer.Position = &H2BF1
            Writer.WriteInt16(198)
            Writer.Position = &H2BF3
            Writer.WriteInt16(199)
            Writer.Position = &H2BF5
            Writer.WriteInt16(200)
            fdialog.Label1.Text = "                               All figurines unlocked"
            fdialog.ShowDialog()
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
            Writer.Position = &H10FD
            Writer.WriteInt16(180)
            Writer.Position = &H1109
            Writer.WriteInt8(18)
            Writer.Position = &H1119
            Writer.WriteInt8(32)
            Writer.Position = &H1125
            Writer.WriteInt8(32)
            Writer.Position = &H112D
            Writer.WriteInt8(80)
            fdialog.Label1.Text = "                          Access to the floor unlocked" & vbNewLine & "            use this after unlock extras amiibo in the game"
            fdialog.ShowDialog()
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked = True Then
            Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
            For i As Integer = 0 To 74
                Writer.Position = &H2CBE + i
                Writer.WriteUInt16(65535)
            Next
            fdialog.Label1.Text = "                           All figurines info. unlocked"
            fdialog.ShowDialog()
        End If
    End Sub
End Class
