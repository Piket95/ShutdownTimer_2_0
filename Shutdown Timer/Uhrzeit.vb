Public Class Uhrzeit

    Private Sub Uhrzeit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.picUhrzeit <> "" Then
            PictureBox1.Image = Bitmap.FromFile(My.Settings.picUhrzeit)
        End If

        'Hier werden die Comboboxen mit den Zahlen gefüllt, mit denen später die Uhrzeit festgelegt wird
        Dim n As Integer = 0

        Timer1.Start()

        Do Until n = 60
            If n < 10 Then
                cboStunde.Items.Add("0" & n)
                cboMinute.Items.Add("0" & n)
                cboSekunde.Items.Add("0" & n)
            ElseIf n < 24 Then
                cboStunde.Items.Add(n)
                cboMinute.Items.Add(n)
                cboSekunde.Items.Add(n)
            ElseIf n >= 24 Then
                cboMinute.Items.Add(n)
                cboSekunde.Items.Add(n)
            End If
            n = n + 1
        Loop

        cboStunde.SelectedIndex = 0
        cboMinute.SelectedIndex = 0
        cboSekunde.SelectedIndex = 0

        'Hier wird die Uhrzeit das erste Mal in die Labels geschrieben und dann später im Timer1_Tick aktuell gehalten
        lblStunde.Text = DateTime.Now.Hour
        lblMinute.Text = DateTime.Now.Minute
        lblSekunde.Text = DateTime.Now.Second

        If DateTime.Now.Second < 10 Then
            lblSekunde.Text = "0" & DateTime.Now.Second
        Else
            lblSekunde.Text = DateTime.Now.Second
        End If

        If DateTime.Now.Minute < 10 Then
            lblMinute.Text = "0" & DateTime.Now.Minute
        Else
            lblMinute.Text = DateTime.Now.Minute
        End If

        If DateTime.Now.Hour < 10 Then
            lblStunde.Text = "0" & DateTime.Now.Hour
        Else
            lblStunde.Text = DateTime.Now.Hour
        End If
    End Sub
    'Speicherung ob die Meldungen für 1 Stunde vor herunterfahren oder 30 Minuten vor herunterfahren usw. schon aktiviert wurden (Anfangs auf False, wird im Timer1_Tick geändert)
    Public boStunde As Boolean = False
    Public boHalbestunde As Boolean = False
    Public boViertelstunde As Boolean = False
    Public boFünfMinuten As Boolean = False

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Die Uhrzeit wird hier aus dem System ausgelesen und einzeln in die Sekunde, Minute und Stunde Labels geschrieben

        lblStunde.Text = DateTime.Now.Hour
        lblMinute.Text = DateTime.Now.Minute
        lblSekunde.Text = DateTime.Now.Second

        If DateTime.Now.Second < 10 Then
            lblSekunde.Text = "0" & DateTime.Now.Second
        Else
            lblSekunde.Text = DateTime.Now.Second
        End If

        If DateTime.Now.Minute < 10 Then
            lblMinute.Text = "0" & DateTime.Now.Minute
        Else
            lblMinute.Text = DateTime.Now.Minute
        End If

        If DateTime.Now.Hour < 10 Then
            lblStunde.Text = "0" & DateTime.Now.Hour
        Else
            lblStunde.Text = DateTime.Now.Hour
        End If

        If cbAktiv.Checked = True Then

            Dim n As Integer = 0
            Dim intMinute As Integer = CInt(lblMinute.Text)
            Dim intStunde As Integer = CInt(lblStunde.Text)

            If Einstellungen_Uhrzeit.cbKeine.Checked = True Then
                boStunde = True
                boHalbestunde = True
                boViertelstunde = True
                boFünfMinuten = True
            Else
                boStunde = False
                boHalbestunde = False
                boViertelstunde = False
                boFünfMinuten = False
            End If

            'Meldung 1 Stunde bevor die Uhrzeit erreicht wurde
            If ((CInt(lblStunde.Text) + 1 = CInt(cboStunde.Text) And lblMinute.Text = cboMinute.Text And lblSekunde.Text = cboSekunde.Text) Or (lblStunde.Text = "23" And cboStunde.Text = "00" And lblMinute.Text = cboMinute.Text And lblSekunde.Text = cboSekunde.Text)) And boStunde = False And (Einstellungen_Uhrzeit.cbStunde.Checked = True Or Einstellungen_Uhrzeit.cbAlle.Checked = True) Then
                boStunde = True
                If MsgBox("ACHTUNG:" & vbNewLine & vbNewLine & "Der PC wird in 1 Stunde, wie eingestellt, herunterfahren." & vbNewLine & "Wenn Sie nicht möchten, dass der PC automatisch herunterfährt, klicken Sie auf Abbrechen", MsgBoxStyle.OkCancel + MsgBoxStyle.Exclamation, "PC fährt in 1 Stunde herunter! - Shutdown Timer") = vbCancel Then
                    lblHinweis.Text = ("PC fährt um - Uhr runter!")

                    cbAktiv.Checked = False

                    cboMinute.Enabled = True
                    cboSekunde.Enabled = True
                    cboStunde.Enabled = True

                    cmdÄndern.Enabled = False
                    cmdÜbernehmen.Enabled = True

                    boStunde = False
                    boHalbestunde = False
                    boViertelstunde = False
                    boFünfMinuten = False
                End If
            End If

            If boHalbestunde = False And (Einstellungen_Uhrzeit.cbHalbe.Checked = True Or Einstellungen_Uhrzeit.cbAlle.Checked = True) Then
                'Meldung 30 Minuten bevor die Uhrzeit erreicht wurde

                Do Until n = 30
                    intMinute = intMinute + 1
                    n = n + 1

                    If intMinute > 59 Then
                        intMinute = 0
                        intStunde = intStunde + 1
                        If intStunde > 23 Then
                            intStunde = 0
                        End If
                    End If
                Loop

                If intMinute = CInt(cboMinute.Text) And intStunde = CInt(cboStunde.Text) And lblSekunde.Text = cboSekunde.Text Then
                    boHalbestunde = True
                    If MsgBox("ACHTUNG:" & vbNewLine & vbNewLine & "Der PC wird in 30 Minuten, wie eingestellt, herunterfahren." & vbNewLine & "Wenn Sie nicht möchten, dass der PC automatisch herunterfährt, klicken Sie auf Abbrechen", MsgBoxStyle.OkCancel + MsgBoxStyle.Exclamation, "PC fährt in 30 Minuten herunter! - Shutdown Timer") = vbCancel Then
                        lblHinweis.Text = ("PC fährt um - Uhr runter!")

                        cbAktiv.Checked = False

                        cboMinute.Enabled = True
                        cboSekunde.Enabled = True
                        cboStunde.Enabled = True

                        cmdÄndern.Enabled = False
                        cmdÜbernehmen.Enabled = True

                        boStunde = False
                        boHalbestunde = False
                        boViertelstunde = False
                        boFünfMinuten = False
                    End If
                End If

                intMinute = CInt(lblMinute.Text)
                n = 0
                intStunde = CInt(lblStunde.Text)
            End If


            If boViertelstunde = False And (Einstellungen_Uhrzeit.cbViertel.Checked = True Or Einstellungen_Uhrzeit.cbAlle.Checked = True) Then
                'Meldung 15 Minuten bevor die Uhrzeit erreicht wurde

                Do Until n = 15
                    intMinute = intMinute + 1
                    n = n + 1

                    If intMinute > 59 Then
                        intMinute = 0
                        intStunde = intStunde + 1
                        If intStunde > 23 Then
                            intStunde = 0
                        End If
                    End If
                Loop

                If intMinute = CInt(cboMinute.Text) And intStunde = CInt(cboStunde.Text) And lblSekunde.Text = cboSekunde.Text Then
                    boViertelstunde = True
                    If MsgBox("ACHTUNG:" & vbNewLine & vbNewLine & "Der PC wird in 15 Minuten, wie eingestellt, herunterfahren." & vbNewLine & "Wenn Sie nicht möchten, dass der PC automatisch herunterfährt, klicken Sie auf Abbrechen", MsgBoxStyle.OkCancel + MsgBoxStyle.Exclamation, "PC fährt in 15 Minuten herunter! - Shutdown Timer") = vbCancel Then
                        lblHinweis.Text = ("PC fährt um - Uhr runter!")

                        cbAktiv.Checked = False

                        cboMinute.Enabled = True
                        cboSekunde.Enabled = True
                        cboStunde.Enabled = True

                        cmdÄndern.Enabled = False
                        cmdÜbernehmen.Enabled = True

                        boStunde = False
                        boHalbestunde = False
                        boViertelstunde = False
                        boFünfMinuten = False
                    End If
                End If

                intMinute = CInt(lblMinute.Text)
                n = 0
                intStunde = CInt(lblStunde.Text)
            End If

            If boFünfMinuten = False And (Einstellungen_Uhrzeit.cbFünf.Checked = True Or Einstellungen_Uhrzeit.cbAlle.Checked = True) Then
                'Meldung 5 Minuten bevor die Uhrzeit erreicht wurde

                Do Until n = 5
                    intMinute = intMinute + 1
                    n = n + 1

                    If intMinute > 59 Then
                        intMinute = 0
                        intStunde = intStunde + 1
                        If intStunde > 23 Then
                            intStunde = 0
                        End If
                    End If
                Loop

                If intMinute = CInt(cboMinute.Text) And intStunde = CInt(cboStunde.Text) And lblSekunde.Text = cboSekunde.Text Then
                    boFünfMinuten = True
                    If MsgBox("ACHTUNG:" & vbNewLine & vbNewLine & "Der PC wird in 5 Minuten, wie eingestellt, herunterfahren." & vbNewLine & "Wenn Sie nicht möchten, dass der PC automatisch herunterfährt, klicken Sie auf Abbrechen", MsgBoxStyle.OkCancel + MsgBoxStyle.Exclamation, "PC fährt in 5 Minuten herunter! - Shutdown Timer") = vbCancel Then
                        lblHinweis.Text = ("PC fährt um - Uhr runter!")

                        cbAktiv.Checked = False

                        cboMinute.Enabled = True
                        cboSekunde.Enabled = True
                        cboStunde.Enabled = True

                        cmdÄndern.Enabled = False
                        cmdÜbernehmen.Enabled = True

                        boStunde = False
                        boHalbestunde = False
                        boViertelstunde = False
                        boFünfMinuten = False
                    End If
                End If

                intMinute = CInt(lblMinute.Text)
                n = 0
                intStunde = CInt(lblStunde.Text)
            End If
        End If

        If lblMinute.Text = cboMinute.Text And lblStunde.Text = cboStunde.Text And lblSekunde.Text = cboSekunde.Text Then
            Shell("shutdown -s ")
        End If

    End Sub

    Private Sub cmdÜbernehmen_Click(sender As Object, e As EventArgs) Handles cmdÜbernehmen.Click
        lblHinweis.Text = ("PC fährt um " & cboStunde.Text & ":" & cboMinute.Text & ":" & cboSekunde.Text & " Uhr runter!")

        If MsgBox("Der Modus wird nun aktviert! Bitte beachten Sie, dass der PC um diese Uhrzeit vollständig herunterfährt und alle NICHT gespeicherten Daten verloren gehen!!!!!!" _
                  & vbNewLine & vbNewLine & "Sie werden 1 Stunde, 30 Minuten, 15 Minuten und/oder 5 Minuten vor dem geplanten herunterfahren benachrichtigt, oder auch garnicht! Jenachdem wie Sie die Einstellungen im internen Einstellungsmenü festgelegt haben!" _
                  & vbNewLine & vbNewLine & "Sind Sie damit einverstanden, dass der Modus aktiviert wird? " & vbNewLine & "(Damit gehen Sie die genannten Risiken ein!)", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Achtung!") = MsgBoxResult.Yes Then
            cbAktiv.Checked = True

            cmdÜbernehmen.Enabled = False
            cmdÄndern.Enabled = True

            cboMinute.Enabled = False
            cboSekunde.Enabled = False
            cboStunde.Enabled = False
        End If
    End Sub

    Private Sub cmdÄndern_Click(sender As Object, e As EventArgs) Handles cmdÄndern.Click
        lblHinweis.Text = ("PC fährt um - Uhr runter!")

        cbAktiv.Checked = False

        cboMinute.Enabled = True
        cboSekunde.Enabled = True
        cboStunde.Enabled = True

        cmdÄndern.Enabled = False
        cmdÜbernehmen.Enabled = True

        boStunde = False
        boHalbestunde = False
        boViertelstunde = False
        boFünfMinuten = False
    End Sub

    Private Sub cmdZurück_Click(sender As Object, e As EventArgs) Handles cmdZurück.Click
        Hauptmenü.Show()
        Me.Close()
    End Sub

    Private Sub cmdEinstellungen_Click(sender As Object, e As EventArgs) Handles cmdEinstellungen.Click
        Einstellungen_Uhrzeit.Show()
    End Sub
End Class