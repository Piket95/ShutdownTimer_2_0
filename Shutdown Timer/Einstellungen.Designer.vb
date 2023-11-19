<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Einstellungen
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Einstellungen))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpBilder = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.cmdZurück = New System.Windows.Forms.Button()
        Me.cmdSpeichern = New System.Windows.Forms.Button()
        Me.cmdEinstellungendurch = New System.Windows.Forms.Button()
        Me.txtEinstellungen = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdUmrechnerdurch = New System.Windows.Forms.Button()
        Me.txtUmrechner = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdUhrzeitdurch = New System.Windows.Forms.Button()
        Me.txtUhrzeit = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdCountdowndurch = New System.Windows.Forms.Button()
        Me.txtCountdown = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdHauptmenüdurch = New System.Windows.Forms.Button()
        Me.txtHauptmenü = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tpChangelog = New System.Windows.Forms.TabPage()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.tpGeplant = New System.Windows.Forms.TabPage()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.tpVersionsinfos = New System.Windows.Forms.TabPage()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabControl1.SuspendLayout()
        Me.tpBilder.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.tpChangelog.SuspendLayout()
        Me.tpGeplant.SuspendLayout()
        Me.tpVersionsinfos.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpBilder)
        Me.TabControl1.Controls.Add(Me.tpChangelog)
        Me.TabControl1.Controls.Add(Me.tpGeplant)
        Me.TabControl1.Controls.Add(Me.tpVersionsinfos)
        Me.TabControl1.Location = New System.Drawing.Point(2, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(343, 508)
        Me.TabControl1.TabIndex = 0
        '
        'tpBilder
        '
        Me.tpBilder.Controls.Add(Me.Button1)
        Me.tpBilder.Controls.Add(Me.Button2)
        Me.tpBilder.Controls.Add(Me.Button3)
        Me.tpBilder.Controls.Add(Me.Button4)
        Me.tpBilder.Controls.Add(Me.Button5)
        Me.tpBilder.Controls.Add(Me.cmdZurück)
        Me.tpBilder.Controls.Add(Me.cmdSpeichern)
        Me.tpBilder.Controls.Add(Me.cmdEinstellungendurch)
        Me.tpBilder.Controls.Add(Me.txtEinstellungen)
        Me.tpBilder.Controls.Add(Me.Label6)
        Me.tpBilder.Controls.Add(Me.cmdUmrechnerdurch)
        Me.tpBilder.Controls.Add(Me.txtUmrechner)
        Me.tpBilder.Controls.Add(Me.Label5)
        Me.tpBilder.Controls.Add(Me.cmdUhrzeitdurch)
        Me.tpBilder.Controls.Add(Me.txtUhrzeit)
        Me.tpBilder.Controls.Add(Me.Label4)
        Me.tpBilder.Controls.Add(Me.cmdCountdowndurch)
        Me.tpBilder.Controls.Add(Me.txtCountdown)
        Me.tpBilder.Controls.Add(Me.Label3)
        Me.tpBilder.Controls.Add(Me.cmdHauptmenüdurch)
        Me.tpBilder.Controls.Add(Me.txtHauptmenü)
        Me.tpBilder.Controls.Add(Me.Panel1)
        Me.tpBilder.Controls.Add(Me.Label1)
        Me.tpBilder.Location = New System.Drawing.Point(4, 22)
        Me.tpBilder.Name = "tpBilder"
        Me.tpBilder.Padding = New System.Windows.Forms.Padding(3)
        Me.tpBilder.Size = New System.Drawing.Size(335, 482)
        Me.tpBilder.TabIndex = 0
        Me.tpBilder.Text = "Bilder ändern"
        Me.tpBilder.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(306, 387)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(22, 20)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "x"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(305, 327)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(22, 20)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "x"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(306, 270)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(22, 20)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "x"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(306, 214)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(22, 20)
        Me.Button4.TabIndex = 20
        Me.Button4.Text = "x"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(306, 158)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(22, 20)
        Me.Button5.TabIndex = 19
        Me.Button5.Text = "x"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'cmdZurück
        '
        Me.cmdZurück.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdZurück.Location = New System.Drawing.Point(189, 430)
        Me.cmdZurück.Name = "cmdZurück"
        Me.cmdZurück.Size = New System.Drawing.Size(139, 44)
        Me.cmdZurück.TabIndex = 17
        Me.cmdZurück.Text = "Zurück zum Hauptmenü"
        Me.cmdZurück.UseVisualStyleBackColor = True
        '
        'cmdSpeichern
        '
        Me.cmdSpeichern.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSpeichern.Location = New System.Drawing.Point(44, 430)
        Me.cmdSpeichern.Name = "cmdSpeichern"
        Me.cmdSpeichern.Size = New System.Drawing.Size(139, 44)
        Me.cmdSpeichern.TabIndex = 16
        Me.cmdSpeichern.Text = "Speichern"
        Me.cmdSpeichern.UseVisualStyleBackColor = True
        '
        'cmdEinstellungendurch
        '
        Me.cmdEinstellungendurch.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEinstellungendurch.Location = New System.Drawing.Point(253, 387)
        Me.cmdEinstellungendurch.Name = "cmdEinstellungendurch"
        Me.cmdEinstellungendurch.Size = New System.Drawing.Size(47, 20)
        Me.cmdEinstellungendurch.TabIndex = 15
        Me.cmdEinstellungendurch.Text = "..."
        Me.cmdEinstellungendurch.UseVisualStyleBackColor = True
        '
        'txtEinstellungen
        '
        Me.txtEinstellungen.Enabled = False
        Me.txtEinstellungen.Location = New System.Drawing.Point(7, 387)
        Me.txtEinstellungen.Name = "txtEinstellungen"
        Me.txtEinstellungen.Size = New System.Drawing.Size(240, 20)
        Me.txtEinstellungen.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 363)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Einstellungen"
        '
        'cmdUmrechnerdurch
        '
        Me.cmdUmrechnerdurch.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUmrechnerdurch.Location = New System.Drawing.Point(252, 327)
        Me.cmdUmrechnerdurch.Name = "cmdUmrechnerdurch"
        Me.cmdUmrechnerdurch.Size = New System.Drawing.Size(47, 20)
        Me.cmdUmrechnerdurch.TabIndex = 12
        Me.cmdUmrechnerdurch.Text = "..."
        Me.cmdUmrechnerdurch.UseVisualStyleBackColor = True
        '
        'txtUmrechner
        '
        Me.txtUmrechner.Enabled = False
        Me.txtUmrechner.Location = New System.Drawing.Point(6, 327)
        Me.txtUmrechner.Name = "txtUmrechner"
        Me.txtUmrechner.Size = New System.Drawing.Size(240, 20)
        Me.txtUmrechner.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 303)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Umrechner"
        '
        'cmdUhrzeitdurch
        '
        Me.cmdUhrzeitdurch.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUhrzeitdurch.Location = New System.Drawing.Point(253, 270)
        Me.cmdUhrzeitdurch.Name = "cmdUhrzeitdurch"
        Me.cmdUhrzeitdurch.Size = New System.Drawing.Size(47, 20)
        Me.cmdUhrzeitdurch.TabIndex = 9
        Me.cmdUhrzeitdurch.Text = "..."
        Me.cmdUhrzeitdurch.UseVisualStyleBackColor = True
        '
        'txtUhrzeit
        '
        Me.txtUhrzeit.Enabled = False
        Me.txtUhrzeit.Location = New System.Drawing.Point(7, 270)
        Me.txtUhrzeit.Name = "txtUhrzeit"
        Me.txtUhrzeit.Size = New System.Drawing.Size(240, 20)
        Me.txtUhrzeit.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 246)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Shutdown per Uhrzeit"
        '
        'cmdCountdowndurch
        '
        Me.cmdCountdowndurch.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCountdowndurch.Location = New System.Drawing.Point(253, 214)
        Me.cmdCountdowndurch.Name = "cmdCountdowndurch"
        Me.cmdCountdowndurch.Size = New System.Drawing.Size(47, 20)
        Me.cmdCountdowndurch.TabIndex = 6
        Me.cmdCountdowndurch.Text = "..."
        Me.cmdCountdowndurch.UseVisualStyleBackColor = True
        '
        'txtCountdown
        '
        Me.txtCountdown.Enabled = False
        Me.txtCountdown.Location = New System.Drawing.Point(7, 214)
        Me.txtCountdown.Name = "txtCountdown"
        Me.txtCountdown.Size = New System.Drawing.Size(240, 20)
        Me.txtCountdown.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(193, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Shutdown per Countdown"
        '
        'cmdHauptmenüdurch
        '
        Me.cmdHauptmenüdurch.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHauptmenüdurch.Location = New System.Drawing.Point(253, 158)
        Me.cmdHauptmenüdurch.Name = "cmdHauptmenüdurch"
        Me.cmdHauptmenüdurch.Size = New System.Drawing.Size(47, 20)
        Me.cmdHauptmenüdurch.TabIndex = 3
        Me.cmdHauptmenüdurch.Text = "..."
        Me.cmdHauptmenüdurch.UseVisualStyleBackColor = True
        '
        'txtHauptmenü
        '
        Me.txtHauptmenü.Enabled = False
        Me.txtHauptmenü.Location = New System.Drawing.Point(7, 158)
        Me.txtHauptmenü.Name = "txtHauptmenü"
        Me.txtHauptmenü.Size = New System.Drawing.Size(240, 20)
        Me.txtHauptmenü.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(9, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(320, 80)
        Me.Panel1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(4, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(316, 64)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Unter diesem Reiter kannst du die jeweiligen" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bilder ändern, die im Hauptmenü ode" &
    "r den" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "einzelnen Anwendungsseiten angezeigt" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "werden."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hauptmenü"
        '
        'tpChangelog
        '
        Me.tpChangelog.Controls.Add(Me.RichTextBox1)
        Me.tpChangelog.Location = New System.Drawing.Point(4, 22)
        Me.tpChangelog.Name = "tpChangelog"
        Me.tpChangelog.Size = New System.Drawing.Size(335, 482)
        Me.tpChangelog.TabIndex = 2
        Me.tpChangelog.Text = "Changelog"
        Me.tpChangelog.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(335, 482)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'tpGeplant
        '
        Me.tpGeplant.Controls.Add(Me.RichTextBox2)
        Me.tpGeplant.Location = New System.Drawing.Point(4, 22)
        Me.tpGeplant.Name = "tpGeplant"
        Me.tpGeplant.Size = New System.Drawing.Size(335, 482)
        Me.tpGeplant.TabIndex = 3
        Me.tpGeplant.Text = "Geplant"
        Me.tpGeplant.UseVisualStyleBackColor = True
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox2.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox2.Location = New System.Drawing.Point(-3, 0)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(338, 482)
        Me.RichTextBox2.TabIndex = 1
        Me.RichTextBox2.Text = "- Changelog überarbeiten (schöner gestalten) und evtl. über eine HTTP Seite abruf" &
    "en lassen" & Global.Microsoft.VisualBasic.ChrW(10) & "- Format der Bilder hinter die Textboxen "
        '
        'tpVersionsinfos
        '
        Me.tpVersionsinfos.Controls.Add(Me.cmdUpdate)
        Me.tpVersionsinfos.Controls.Add(Me.lblVersion)
        Me.tpVersionsinfos.Controls.Add(Me.Panel2)
        Me.tpVersionsinfos.Location = New System.Drawing.Point(4, 22)
        Me.tpVersionsinfos.Name = "tpVersionsinfos"
        Me.tpVersionsinfos.Padding = New System.Windows.Forms.Padding(3)
        Me.tpVersionsinfos.Size = New System.Drawing.Size(335, 482)
        Me.tpVersionsinfos.TabIndex = 1
        Me.tpVersionsinfos.Text = "Versionsinformationen"
        Me.tpVersionsinfos.UseVisualStyleBackColor = True
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdate.Location = New System.Drawing.Point(10, 143)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(311, 69)
        Me.cmdUpdate.TabIndex = 23
        Me.cmdUpdate.Text = "Update herunterladen"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        Me.cmdUpdate.Visible = False
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(6, 51)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(276, 42)
        Me.lblVersion.TabIndex = 22
        Me.lblVersion.Text = "Version x.x.x.x"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Location = New System.Drawing.Point(6, 338)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(323, 136)
        Me.Panel2.TabIndex = 21
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(9, 11)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(172, 13)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Piket95 alias Dennis Adam © 2015"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(351, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(350, 508)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Einstellungen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 508)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Einstellungen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shutdown Timer - Einstellungen"
        Me.TabControl1.ResumeLayout(False)
        Me.tpBilder.ResumeLayout(False)
        Me.tpBilder.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tpChangelog.ResumeLayout(False)
        Me.tpGeplant.ResumeLayout(False)
        Me.tpVersionsinfos.ResumeLayout(False)
        Me.tpVersionsinfos.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpBilder As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents tpVersionsinfos As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents cmdHauptmenüdurch As Button
    Friend WithEvents txtHauptmenü As TextBox
    Friend WithEvents cmdUhrzeitdurch As Button
    Friend WithEvents txtUhrzeit As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmdCountdowndurch As Button
    Friend WithEvents txtCountdown As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmdEinstellungendurch As Button
    Friend WithEvents txtEinstellungen As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmdUmrechnerdurch As Button
    Friend WithEvents txtUmrechner As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cmdSpeichern As Button
    Friend WithEvents cmdZurück As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents lblVersion As Label
    Friend WithEvents cmdUpdate As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents tpChangelog As TabPage
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents tpGeplant As TabPage
    Friend WithEvents RichTextBox2 As RichTextBox
End Class
