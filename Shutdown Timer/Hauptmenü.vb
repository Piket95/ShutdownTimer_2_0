Public Class Hauptmenü

    Public web As New System.Net.WebClient()

    Public VersionFilePath As String = "https://dl.dropboxusercontent.com/u/56211824/ShutDownTimerUpdate/version.txt?dl=1"
    Public UpdateDownloadPath As String = "https://dl.dropboxusercontent.com/u/56211824/ShutDownTimerUpdate/Shutdown%20Timer.exe?dl=1"
    Public UpdateBatDownloadPath As String = "https://dl.dropboxusercontent.com/u/56211824/ShutDownTimerUpdate/runupdate.bat?dl=1"
    Public SaveFileName As String = Application.StartupPath & "\update.exe"
    Public SaveFileName1 As String = Application.StartupPath & "\runupdate.bat"



    Private Function TestInternetConnection() As Boolean
        Try
            Dim ping As New System.Net.NetworkInformation.Ping()
            ping.Send("google.de")
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


    Private Sub cmdBeenden_Click(sender As Object, e As EventArgs) Handles cmdBeenden.Click
        Me.Close()
    End Sub

    Private Sub cmdCountdown_Click(sender As Object, e As EventArgs) Handles cmdCountdown.Click
        Countdown.Show()
        Me.Close()
    End Sub

    Private Sub cmdUhrzeit_Click(sender As Object, e As EventArgs) Handles cmdUhrzeit.Click
        Uhrzeit.Show()
        Me.Close()
    End Sub

    Private Sub cmdUmrechner_Click(sender As Object, e As EventArgs) Handles cmdUmrechner.Click
        Umrechner.Show()
        Me.Close()
    End Sub

    Private Sub cmdEinstellungen_Click(sender As Object, e As EventArgs) Handles cmdEinstellungen.Click
        Einstellungen.Show()
        Me.Close()
    End Sub

    Public Updatebenachrichtigung As Boolean = False

    Private Sub Hauptmenü_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.picHauptmenü <> "" Then
            PictureBox1.Image = Bitmap.FromFile(My.Settings.picHauptmenü)
        End If

        If Updatebenachrichtigung = False Then

            Dim ergebnis As DialogResult

            If TestInternetConnection() Then
                Try
                    Dim version As Integer = CInt(web.DownloadString(VersionFilePath))
                    If version > CInt(String.Format("{0}", My.Application.Info.Version.ToString)) Then
                        Einstellungen.cmdUpdate.Visible = True
                        ergebnis = MsgBox("Neue Version verfügbar! Möchten Sie die neue Version jetzt herunterladen und installieren?", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Update gefunden!")
                        Einstellungen.Show()
                        Einstellungen.tpVersionsinfos.Show()
                        Updatebenachrichtigung = True
                        Me.Close()
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Else : MessageBox.Show("Keine Internetverbindung")
            End If

        End If





    End Sub
End Class