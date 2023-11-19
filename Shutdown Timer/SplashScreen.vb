Public Class SplashScreen
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

        lblVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value <> 100 Then
            ProgressBar1.Value = ProgressBar1.Value + 1.5
        Else
            Hauptmenü.Show()
            Me.Close()
        End If
    End Sub
End Class