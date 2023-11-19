Option Strict Off
Public Class Countdown

    Private Sub Countdown_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.picCountdown <> "" Then
            PictureBox1.Image = Bitmap.FromFile(My.Settings.picCountdown)
        End If

        Dim n As Integer = 0

        Do Until n = 60
            If n < 10 Then
                cboStunden.Items.Add("0" & n)
                cboMinuten.Items.Add("0" & n)
                cboSekunden.Items.Add("0" & n)
            ElseIf n < 24 Then
                cboStunden.Items.Add(n)
                cboMinuten.Items.Add(n)
                cboSekunden.Items.Add(n)
            ElseIf n > 24 Then
                cboMinuten.Items.Add(n)
                cboSekunden.Items.Add(n)
            End If
            n = n + 1
        Loop

        cboMinuten.SelectedIndex = 0
        cboSekunden.SelectedIndex = 0
        cboStunden.SelectedIndex = 0

    End Sub

    Private Sub cmdZurück_Click(sender As Object, e As EventArgs) Handles cmdZurück.Click
        Hauptmenü.Show()
        Me.Close()
    End Sub

    Private Sub cmdÜbernehmen_Click(sender As Object, e As EventArgs) Handles cmdÜbernehmen.Click
        If cboStunden.Text = "" Or cboMinuten.Text = "" Or cboSekunden.Text <> "" Then
            cboStunden.Enabled = False
            cboMinuten.Enabled = False
            cboSekunden.Enabled = False

            lblCStunden.Text = cboStunden.Text
            lblCMinuten.Text = cboMinuten.Text
            lblCSekunden.Text = cboSekunden.Text

            cmdÄndern.Enabled = True
            cmdStarten.Enabled = True
            cmdÜbernehmen.Enabled = False
        Else
            MsgBox("Bitte wählen Sie die gewünschte Zeit, die ablaufen soll in den Comboboxen aus und bestätigen Sie die Eingabe bzw. starten Sie den Timer mit dem 'Übernehmen' Button", MsgBoxStyle.Critical & MsgBoxStyle.OkOnly, "Bitte geben Sie die gewünschte Zeit ein!")
        End If
    End Sub

    Private Sub cmdÄndern_Click(sender As Object, e As EventArgs) Handles cmdÄndern.Click
        cboStunden.Enabled = True
        cboMinuten.Enabled = True
        cboSekunden.Enabled = True

        cmdÄndern.Enabled = False
        cmdStarten.Enabled = False
        cmdÜbernehmen.Enabled = True
    End Sub

    Private Sub cmdStarten_Click(sender As Object, e As EventArgs) Handles cmdStarten.Click
        cmdÄndern.Enabled = False
        cmdAbbrechen.Enabled = True
        cmdStarten.Enabled = False
        cmdPause.Enabled = True

        timCountdown.Start()
    End Sub

    Private Sub cmdAbbrechen_Click(sender As Object, e As EventArgs) Handles cmdAbbrechen.Click
        timCountdown.Stop()
        cmdÜbernehmen.Enabled = True
        cmdPause.Enabled = False
        cmdAbbrechen.Enabled = False

        lblCMinuten.Text = "00"
        lblCSekunden.Text = "00"
        lblCStunden.Text = "00"

        cboMinuten.Enabled = True
        cboSekunden.Enabled = True
        cboStunden.Enabled = True

    End Sub

    Private Sub cmdPause_Click(sender As Object, e As EventArgs) Handles cmdPause.Click
        timCountdown.Stop()
        cmdPause.Enabled = False
        cmdStarten.Enabled = True
    End Sub

    Private Sub timCountdown_Tick(sender As Object, e As EventArgs) Handles timCountdown.Tick
        Dim intSekunden As Integer = CInt(lblCSekunden.Text)
        Dim intMinuten As Integer = CInt(lblCMinuten.Text)
        Dim intStunden As Integer = CInt(lblCStunden.Text)

        If intSekunden = 0 Then
            If intMinuten > 0 Then
                intSekunden = 59
                intMinuten = intMinuten - 1
            ElseIf intStunden > 0 Then
                intMinuten = 59
                intSekunden = 59
                intStunden = intStunden - 1
            End If
        Else
            intSekunden = intSekunden - 1
        End If

        If intSekunden <= 9 Then
            lblCSekunden.Text = "0" & intSekunden
        Else
            lblCSekunden.Text = intSekunden
        End If

        If intMinuten <= 9 Then
            lblCMinuten.Text = "0" & intMinuten
        Else
            lblCMinuten.Text = intMinuten
        End If

        If intStunden <= 9 Then
            lblCStunden.Text = "0" & intStunden
        Else
            lblCStunden.Text = intStunden
        End If

        If intStunden = 0 And intMinuten = 0 And intSekunden = 0 Then
            timCountdown.Stop()
            cmdAbbrechen.Enabled = False
            cmdPause.Enabled = False
            cmdÜbernehmen.Enabled = True
            cboMinuten.Enabled = True
            cboSekunden.Enabled = True
            cboStunden.Enabled = True
            Shell("shutdown -s ")
        End If


    End Sub
End Class
