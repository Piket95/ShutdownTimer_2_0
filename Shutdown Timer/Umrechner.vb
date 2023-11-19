Public Class Umrechner

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hauptmenü.Show()
        Me.Close()
    End Sub

    Private Sub Umrechner_Load(sender As Object, e As EventArgs) Handles Me.Load
        If My.Settings.picUmrechner <> "" Then
            PictureBox1.Image = Bitmap.FromFile(My.Settings.picUmrechner)
        End If

        cboVon.SelectedIndex = 2
        cboZu.SelectedIndex = 2
    End Sub

    Private Sub cmdUmrechnen_Click(sender As Object, e As EventArgs) Handles cmdUmrechnen.Click
        If IsNumeric(txtVon.Text) = False Then
            MsgBox("Bitte geben Sie eine Zahl ein! Buchstaben sind nicht erlaubt...", vbOKOnly, "Bitte beachten Sie Ihre Eingabe...")
            Exit Sub
        End If

        If cboVon.SelectedIndex = "2" And cboZu.SelectedIndex = "2" Then
            txtZu.Text = txtVon.Text
        End If

        If cboVon.SelectedIndex = "2" And cboZu.SelectedIndex = "1" Then
            txtZu.Text = CInt(txtVon.Text) / 60
        End If

        If cboVon.SelectedIndex = "2" And cboZu.SelectedIndex = "0" Then
            txtZu.Text = CInt(txtVon.Text) / 60
            txtZu.Text = CInt(txtZu.Text) / 60
        End If


        If cboVon.SelectedIndex = "1" And cboZu.SelectedIndex = "2" Then
            txtZu.Text = CInt(txtVon.Text) * 60
        End If

        If cboVon.SelectedIndex = "1" And cboZu.SelectedIndex = "1" Then
            txtZu.Text = txtVon.Text
        End If

        If cboVon.SelectedIndex = "1" And cboZu.SelectedIndex = "0" Then
            txtZu.Text = CInt(txtVon.Text) / 60
        End If


        If cboVon.SelectedIndex = "0" And cboZu.SelectedIndex = "2" Then
            txtZu.Text = CInt(txtVon.Text) * 60
            txtZu.Text = CInt(txtZu.Text) * 60
        End If

        If cboVon.SelectedIndex = "0" And cboZu.SelectedIndex = "1" Then
            txtZu.Text = CInt(txtVon.Text) * 60
        End If

        If cboVon.SelectedIndex = "0" And cboZu.SelectedIndex = "0" Then
            txtZu.Text = txtVon.Text
        End If
    End Sub
End Class