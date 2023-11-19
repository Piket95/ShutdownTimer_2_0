Public Class Einstellungen_Uhrzeit
    Private Sub Einstellungen_Uhrzeit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.boCBAlle = True Or My.Settings.boCBKeine = True Then
            If My.Settings.boCBAlle = True Then
                cbAlle.Enabled = True
                cbAlle.Checked = True
                cbKeine.Enabled = False
            Else
                cbKeine.Enabled = True
                cbKeine.Checked = True
                cbAlle.Enabled = False
            End If

            cbFünf.Enabled = False
            cbHalbe.Enabled = False
            cbStunde.Enabled = False
            cbViertel.Enabled = False

        Else

            cbFünf.Enabled = True
            cbHalbe.Enabled = True
            cbStunde.Enabled = True
            cbViertel.Enabled = True
            cbAlle.Enabled = True

            GoTo Hier
        End If

Hier:
        If My.Settings.boCBStunde = True Then
            cbStunde.Checked = True
        End If

        If My.Settings.boCBHalbe = True Then
            cbHalbe.Checked = True
        End If

        If My.Settings.boCBViertel = True Then
            cbViertel.Checked = True
        End If

        If My.Settings.boCBFünf = True Then
            cbFünf.Checked = True
        End If

    End Sub

    Private Sub cmdZurück_Click(sender As Object, e As EventArgs) Handles cmdZurück.Click
        Me.Close()
    End Sub

    Private Sub cmdÜbernehmen_Click(sender As Object, e As EventArgs) Handles cmdÜbernehmen.Click

        If cbAlle.Checked = True Then
            My.Settings.boCBAlle = True
        Else
            My.Settings.boCBAlle = False
        End If

        If cbKeine.Checked = True Then
            My.Settings.boCBKeine = True
        Else
            My.Settings.boCBKeine = False
        End If

        If cbStunde.Checked = True Then
            My.Settings.boCBStunde = True
        Else
            My.Settings.boCBStunde = False
        End If

        If cbHalbe.Checked = True Then
            My.Settings.boCBHalbe = True
        Else
            My.Settings.boCBHalbe = False
        End If

        If cbViertel.Checked = True Then
            My.Settings.boCBViertel = True
        Else
            My.Settings.boCBViertel = False
        End If

        If cbFünf.Checked = True Then
            My.Settings.boCBFünf = True
        Else
            My.Settings.boCBFünf = False
        End If

        Me.Close()
    End Sub

    Private Sub cbAlle_CheckedChanged(sender As Object, e As EventArgs) Handles cbAlle.CheckedChanged
        If cbAlle.Checked = True Then
            cbFünf.Enabled = False
            cbHalbe.Enabled = False
            cbStunde.Enabled = False
            cbViertel.Enabled = False
            cbKeine.Enabled = False
        Else
            cbFünf.Enabled = True
            cbHalbe.Enabled = True
            cbStunde.Enabled = True
            cbViertel.Enabled = True
            cbKeine.Enabled = True
        End If
    End Sub

    Private Sub cbKeine_CheckedChanged(sender As Object, e As EventArgs) Handles cbKeine.CheckedChanged
        If cbKeine.Checked = True Then
            cbFünf.Enabled = False
            cbHalbe.Enabled = False
            cbStunde.Enabled = False
            cbViertel.Enabled = False
            cbAlle.Enabled = False
        Else
            cbFünf.Enabled = True
            cbHalbe.Enabled = True
            cbStunde.Enabled = True
            cbViertel.Enabled = True
            cbAlle.Enabled = True
        End If
    End Sub
End Class