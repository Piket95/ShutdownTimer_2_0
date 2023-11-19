<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Uhrzeit
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Uhrzeit))
        Me.lblStunde = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboStunde = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboMinute = New System.Windows.Forms.ComboBox()
        Me.cboSekunde = New System.Windows.Forms.ComboBox()
        Me.cmdÜbernehmen = New System.Windows.Forms.Button()
        Me.cmdÄndern = New System.Windows.Forms.Button()
        Me.lblHinweis = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbAktiv = New System.Windows.Forms.CheckBox()
        Me.cmdZurück = New System.Windows.Forms.Button()
        Me.lblMinute = New System.Windows.Forms.Label()
        Me.lblSekunde = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmdEinstellungen = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblStunde
        '
        Me.lblStunde.AutoSize = True
        Me.lblStunde.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStunde.Location = New System.Drawing.Point(254, 23)
        Me.lblStunde.Name = "lblStunde"
        Me.lblStunde.Size = New System.Drawing.Size(69, 54)
        Me.lblStunde.TabIndex = 0
        Me.lblStunde.Text = "00"
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 380)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(415, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Zeit eingeben nach der der PC herunterfahren soll:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 408)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Stunde"
        '
        'cboStunde
        '
        Me.cboStunde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStunde.FormattingEnabled = True
        Me.cboStunde.Location = New System.Drawing.Point(16, 436)
        Me.cboStunde.Name = "cboStunde"
        Me.cboStunde.Size = New System.Drawing.Size(93, 21)
        Me.cboStunde.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(175, 408)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Minute"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(345, 408)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Sekunde"
        '
        'cboMinute
        '
        Me.cboMinute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMinute.FormattingEnabled = True
        Me.cboMinute.Location = New System.Drawing.Point(178, 436)
        Me.cboMinute.Name = "cboMinute"
        Me.cboMinute.Size = New System.Drawing.Size(93, 21)
        Me.cboMinute.TabIndex = 7
        '
        'cboSekunde
        '
        Me.cboSekunde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSekunde.FormattingEnabled = True
        Me.cboSekunde.Location = New System.Drawing.Point(348, 436)
        Me.cboSekunde.Name = "cboSekunde"
        Me.cboSekunde.Size = New System.Drawing.Size(93, 21)
        Me.cboSekunde.TabIndex = 8
        '
        'cmdÜbernehmen
        '
        Me.cmdÜbernehmen.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdÜbernehmen.Location = New System.Drawing.Point(473, 408)
        Me.cmdÜbernehmen.Name = "cmdÜbernehmen"
        Me.cmdÜbernehmen.Size = New System.Drawing.Size(130, 23)
        Me.cmdÜbernehmen.TabIndex = 16
        Me.cmdÜbernehmen.Text = "Aktivieren"
        Me.cmdÜbernehmen.UseVisualStyleBackColor = True
        '
        'cmdÄndern
        '
        Me.cmdÄndern.Enabled = False
        Me.cmdÄndern.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdÄndern.Location = New System.Drawing.Point(473, 437)
        Me.cmdÄndern.Name = "cmdÄndern"
        Me.cmdÄndern.Size = New System.Drawing.Size(130, 23)
        Me.cmdÄndern.TabIndex = 17
        Me.cmdÄndern.Text = "Ändern"
        Me.cmdÄndern.UseVisualStyleBackColor = True
        '
        'lblHinweis
        '
        Me.lblHinweis.AutoSize = True
        Me.lblHinweis.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHinweis.Location = New System.Drawing.Point(14, 484)
        Me.lblHinweis.Name = "lblHinweis"
        Me.lblHinweis.Size = New System.Drawing.Size(283, 16)
        Me.lblHinweis.TabIndex = 18
        Me.lblHinweis.Text = "PC fährt um - Uhr runter!"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cbAktiv)
        Me.Panel1.Location = New System.Drawing.Point(473, 468)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(110, 44)
        Me.Panel1.TabIndex = 19
        '
        'cbAktiv
        '
        Me.cbAktiv.AutoSize = True
        Me.cbAktiv.Enabled = False
        Me.cbAktiv.Location = New System.Drawing.Point(14, 14)
        Me.cbAktiv.Name = "cbAktiv"
        Me.cbAktiv.Size = New System.Drawing.Size(84, 17)
        Me.cbAktiv.TabIndex = 0
        Me.cbAktiv.Text = "Modus aktiv"
        Me.cbAktiv.UseVisualStyleBackColor = True
        '
        'cmdZurück
        '
        Me.cmdZurück.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdZurück.Location = New System.Drawing.Point(463, 531)
        Me.cmdZurück.Name = "cmdZurück"
        Me.cmdZurück.Size = New System.Drawing.Size(139, 44)
        Me.cmdZurück.TabIndex = 20
        Me.cmdZurück.Text = "Zurück zum Hauptmenü"
        Me.cmdZurück.UseVisualStyleBackColor = True
        '
        'lblMinute
        '
        Me.lblMinute.AutoSize = True
        Me.lblMinute.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinute.Location = New System.Drawing.Point(369, 23)
        Me.lblMinute.Name = "lblMinute"
        Me.lblMinute.Size = New System.Drawing.Size(69, 54)
        Me.lblMinute.TabIndex = 21
        Me.lblMinute.Text = "00"
        '
        'lblSekunde
        '
        Me.lblSekunde.AutoSize = True
        Me.lblSekunde.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSekunde.Location = New System.Drawing.Point(484, 23)
        Me.lblSekunde.Name = "lblSekunde"
        Me.lblSekunde.Size = New System.Drawing.Size(69, 54)
        Me.lblSekunde.TabIndex = 22
        Me.lblSekunde.Text = "00"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(329, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 54)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(444, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 54)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = ":"
        '
        'cmdEinstellungen
        '
        Me.cmdEinstellungen.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEinstellungen.Location = New System.Drawing.Point(288, 531)
        Me.cmdEinstellungen.Name = "cmdEinstellungen"
        Me.cmdEinstellungen.Size = New System.Drawing.Size(169, 44)
        Me.cmdEinstellungen.TabIndex = 25
        Me.cmdEinstellungen.Text = "Einstellungen"
        Me.cmdEinstellungen.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(612, 264)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblStunde)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lblSekunde)
        Me.GroupBox1.Controls.Add(Me.lblMinute)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 271)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(585, 96)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Aktuelle Uhrzeit"
        '
        'Uhrzeit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 582)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmdEinstellungen)
        Me.Controls.Add(Me.cmdZurück)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblHinweis)
        Me.Controls.Add(Me.cmdÄndern)
        Me.Controls.Add(Me.cmdÜbernehmen)
        Me.Controls.Add(Me.cboSekunde)
        Me.Controls.Add(Me.cboMinute)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboStunde)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Uhrzeit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shutdown Timer - Herunterfahren nach bestimmter Uhrzeit"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblStunde As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboStunde As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboMinute As System.Windows.Forms.ComboBox
    Friend WithEvents cboSekunde As System.Windows.Forms.ComboBox
    Friend WithEvents cmdÜbernehmen As System.Windows.Forms.Button
    Friend WithEvents cmdÄndern As System.Windows.Forms.Button
    Friend WithEvents lblHinweis As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cbAktiv As System.Windows.Forms.CheckBox
    Friend WithEvents cmdZurück As System.Windows.Forms.Button
    Friend WithEvents lblMinute As Label
    Friend WithEvents lblSekunde As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmdEinstellungen As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
