Imports System
Public Class Einstellungen

    Public ofd As New OpenFileDialog
    Public username As String = System.Environment.UserName
    Private Sub cmdZurück_Click(sender As Object, e As EventArgs) Handles cmdZurück.Click
        Hauptmenü.Show()
        Me.Close()
    End Sub

    Private Sub Einstellungen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.picEinstellungen <> "" Then
            PictureBox1.Image = Bitmap.FromFile(My.Settings.picEinstellungen)
        End If

        lblVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)

        If My.Settings.picHauptmenü <> "" Then
            txtHauptmenü.Text = My.Settings.picHauptmenü
        End If

        If My.Settings.picCountdown <> "" Then
            txtCountdown.Text = My.Settings.picCountdown
        End If

        If My.Settings.picUhrzeit <> "" Then
            txtUhrzeit.Text = My.Settings.picUhrzeit
        End If

        If My.Settings.picUmrechner <> "" Then
            txtUmrechner.Text = My.Settings.picUmrechner
        End If

        If My.Settings.picEinstellungen <> "" Then
            txtEinstellungen.Text = My.Settings.picEinstellungen
        End If
    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        MsgBox("Das Programm wird gleich neu gestartet. Bitte haben Sie etwas Geduld!", MsgBoxStyle.Information)
        Hauptmenü.web.DownloadFile(Hauptmenü.UpdateDownloadPath, Hauptmenü.SaveFileName)
        Hauptmenü.web.DownloadFile(Hauptmenü.UpdateBatDownloadPath, Hauptmenü.SaveFileName1)
        Process.Start("runupdate.bat")
        Application.Exit()
    End Sub

    Private Sub cmdHauptmenüdurch_Click(sender As Object, e As EventArgs) Handles cmdHauptmenüdurch.Click

        ofd.InitialDirectory = "C:\Users\" & username & "\Pictures\"
        ofd.Filter = "JPG-Dateien|*.jpg|JPEG-Dateien|*.jpeg|PNG-Dateien|*.png|GIF-Dateien|*.gif|IMG-Dateien|*.img|Alle Dateien|*.* "
        ofd.FilterIndex = 0

        If ofd.ShowDialog = DialogResult.OK Then
            txtHauptmenü.Text = ofd.FileName
        End If
    End Sub

    Private Sub cmdSpeichern_Click(sender As Object, e As EventArgs) Handles cmdSpeichern.Click
        If txtEinstellungen.Text <> "" Then
            PictureBox1.Image = Bitmap.FromFile(txtEinstellungen.Text)
            My.Settings.picEinstellungen = txtEinstellungen.Text
        Else
            txtEinstellungen.Text = ""
            My.Settings.picEinstellungen = ""
        End If

        If txtHauptmenü.Text <> "" Then
            Hauptmenü.PictureBox1.Image = Bitmap.FromFile(txtHauptmenü.Text)
            My.Settings.picHauptmenü = txtHauptmenü.Text
        Else
            txtHauptmenü.Text = ""
            My.Settings.picHauptmenü = ""
        End If

        If txtCountdown.Text <> "" Then
            Countdown.PictureBox1.Image = Bitmap.FromFile(txtCountdown.Text)
            My.Settings.picCountdown = txtCountdown.Text
        Else
            txtCountdown.Text = ""
            My.Settings.picCountdown = ""
        End If

        If txtUhrzeit.Text <> "" Then
            Uhrzeit.PictureBox1.Image = Bitmap.FromFile(txtUhrzeit.Text)
            My.Settings.picUhrzeit = txtUhrzeit.Text
        Else
            txtUhrzeit.Text = ""
            My.Settings.picUhrzeit = ""
        End If

        If txtUmrechner.Text <> "" Then
            Umrechner.PictureBox1.Image = Bitmap.FromFile(txtUmrechner.Text)
            My.Settings.picUmrechner = txtUmrechner.Text
        Else
            txtUmrechner.Text = ""
            My.Settings.picUmrechner = ""
        End If
    End Sub

    Private Sub cmdCountdowndurch_Click(sender As Object, e As EventArgs) Handles cmdCountdowndurch.Click
        ofd.InitialDirectory = "C:\Users\" & username & "\Pictures\"
        ofd.Filter = "JPG-Dateien|*.jpg|JPEG-Dateien|*.jpeg|PNG-Dateien|*.png|GIF-Dateien|*.gif|IMG-Dateien|*.img|Alle Dateien|*.* "
        ofd.FilterIndex = 0

        If ofd.ShowDialog = DialogResult.OK Then
            txtCountdown.Text = ofd.FileName
        End If
    End Sub

    Private Sub cmdUhrzeitdurch_Click(sender As Object, e As EventArgs) Handles cmdUhrzeitdurch.Click
        ofd.InitialDirectory = "C:\Users\" & username & "\Pictures\"
        ofd.Filter = "JPG-Dateien|*.jpg|JPEG-Dateien|*.jpeg|PNG-Dateien|*.png|GIF-Dateien|*.gif|IMG-Dateien|*.img|Alle Dateien|*.* "
        ofd.FilterIndex = 0

        If ofd.ShowDialog = DialogResult.OK Then
            txtUhrzeit.Text = ofd.FileName
        End If
    End Sub

    Private Sub cmdUmrechnerdurch_Click(sender As Object, e As EventArgs) Handles cmdUmrechnerdurch.Click
        ofd.InitialDirectory = "C:\Users\" & username & "\Pictures\"
        ofd.Filter = "JPG-Dateien|*.jpg|JPEG-Dateien|*.jpeg|PNG-Dateien|*.png|GIF-Dateien|*.gif|IMG-Dateien|*.img|Alle Dateien|*.* "
        ofd.FilterIndex = 0

        If ofd.ShowDialog = DialogResult.OK Then
            txtUmrechner.Text = ofd.FileName
        End If
    End Sub

    Private Sub cmdEinstellungendurch_Click(sender As Object, e As EventArgs) Handles cmdEinstellungendurch.Click
        ofd.InitialDirectory = "C:\Users\" & username & "\Pictures\"
        ofd.Filter = "JPG-Dateien|*.jpg|JPEG-Dateien|*.jpeg|PNG-Dateien|*.png|GIF-Dateien|*.gif|IMG-Dateien|*.img|Alle Dateien|*.* "
        ofd.FilterIndex = 0

        If ofd.ShowDialog = DialogResult.OK Then
            txtEinstellungen.Text = ofd.FileName
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        txtHauptmenü.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        txtCountdown.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtUhrzeit.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtUmrechner.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtEinstellungen.Text = ""
    End Sub
End Class