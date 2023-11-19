<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Countdown
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Countdown))
        Me.lblEingabe = New System.Windows.Forms.Label()
        Me.cboStunden = New System.Windows.Forms.ComboBox()
        Me.lblStunden = New System.Windows.Forms.Label()
        Me.lblMinuten = New System.Windows.Forms.Label()
        Me.lblSekunden = New System.Windows.Forms.Label()
        Me.cboMinuten = New System.Windows.Forms.ComboBox()
        Me.cboSekunden = New System.Windows.Forms.ComboBox()
        Me.cmdZurück = New System.Windows.Forms.Button()
        Me.lblCStunden = New System.Windows.Forms.Label()
        Me.lblDoppelp1 = New System.Windows.Forms.Label()
        Me.lblCMinuten = New System.Windows.Forms.Label()
        Me.lblDoppelp2 = New System.Windows.Forms.Label()
        Me.lblCSekunden = New System.Windows.Forms.Label()
        Me.cmdAbbrechen = New System.Windows.Forms.Button()
        Me.cmdStarten = New System.Windows.Forms.Button()
        Me.cmdÜbernehmen = New System.Windows.Forms.Button()
        Me.cmdÄndern = New System.Windows.Forms.Button()
        Me.cmdPause = New System.Windows.Forms.Button()
        Me.timCountdown = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblEingabe
        '
        Me.lblEingabe.AutoSize = True
        Me.lblEingabe.BackColor = System.Drawing.Color.Transparent
        Me.lblEingabe.Font = New System.Drawing.Font("Lucida Console", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEingabe.Location = New System.Drawing.Point(12, 264)
        Me.lblEingabe.Name = "lblEingabe"
        Me.lblEingabe.Size = New System.Drawing.Size(237, 19)
        Me.lblEingabe.TabIndex = 0
        Me.lblEingabe.Text = "Countdown eingeben:"
        '
        'cboStunden
        '
        Me.cboStunden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStunden.FormattingEnabled = True
        Me.cboStunden.Location = New System.Drawing.Point(16, 335)
        Me.cboStunden.Name = "cboStunden"
        Me.cboStunden.Size = New System.Drawing.Size(73, 21)
        Me.cboStunden.TabIndex = 1
        '
        'lblStunden
        '
        Me.lblStunden.AutoSize = True
        Me.lblStunden.BackColor = System.Drawing.Color.Transparent
        Me.lblStunden.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStunden.Location = New System.Drawing.Point(13, 304)
        Me.lblStunden.Name = "lblStunden"
        Me.lblStunden.Size = New System.Drawing.Size(85, 16)
        Me.lblStunden.TabIndex = 2
        Me.lblStunden.Text = "Stunden"
        '
        'lblMinuten
        '
        Me.lblMinuten.AutoSize = True
        Me.lblMinuten.BackColor = System.Drawing.Color.Transparent
        Me.lblMinuten.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinuten.Location = New System.Drawing.Point(164, 304)
        Me.lblMinuten.Name = "lblMinuten"
        Me.lblMinuten.Size = New System.Drawing.Size(85, 16)
        Me.lblMinuten.TabIndex = 3
        Me.lblMinuten.Text = "Minuten"
        '
        'lblSekunden
        '
        Me.lblSekunden.AutoSize = True
        Me.lblSekunden.BackColor = System.Drawing.Color.Transparent
        Me.lblSekunden.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSekunden.Location = New System.Drawing.Point(318, 304)
        Me.lblSekunden.Name = "lblSekunden"
        Me.lblSekunden.Size = New System.Drawing.Size(96, 16)
        Me.lblSekunden.TabIndex = 4
        Me.lblSekunden.Text = "Sekunden"
        '
        'cboMinuten
        '
        Me.cboMinuten.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMinuten.FormattingEnabled = True
        Me.cboMinuten.Location = New System.Drawing.Point(167, 335)
        Me.cboMinuten.Name = "cboMinuten"
        Me.cboMinuten.Size = New System.Drawing.Size(73, 21)
        Me.cboMinuten.TabIndex = 5
        '
        'cboSekunden
        '
        Me.cboSekunden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSekunden.FormattingEnabled = True
        Me.cboSekunden.Location = New System.Drawing.Point(321, 335)
        Me.cboSekunden.Name = "cboSekunden"
        Me.cboSekunden.Size = New System.Drawing.Size(73, 21)
        Me.cboSekunden.TabIndex = 6
        '
        'cmdZurück
        '
        Me.cmdZurück.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdZurück.Location = New System.Drawing.Point(480, 510)
        Me.cmdZurück.Name = "cmdZurück"
        Me.cmdZurück.Size = New System.Drawing.Size(139, 44)
        Me.cmdZurück.TabIndex = 7
        Me.cmdZurück.Text = "Zurück zum Hauptmenü"
        Me.cmdZurück.UseVisualStyleBackColor = True
        '
        'lblCStunden
        '
        Me.lblCStunden.AutoSize = True
        Me.lblCStunden.BackColor = System.Drawing.Color.Transparent
        Me.lblCStunden.Font = New System.Drawing.Font("Impact", 54.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCStunden.Location = New System.Drawing.Point(55, 16)
        Me.lblCStunden.Name = "lblCStunden"
        Me.lblCStunden.Size = New System.Drawing.Size(119, 91)
        Me.lblCStunden.TabIndex = 8
        Me.lblCStunden.Text = "00"
        '
        'lblDoppelp1
        '
        Me.lblDoppelp1.AutoSize = True
        Me.lblDoppelp1.BackColor = System.Drawing.Color.Transparent
        Me.lblDoppelp1.Font = New System.Drawing.Font("Impact", 54.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDoppelp1.Location = New System.Drawing.Point(190, 16)
        Me.lblDoppelp1.Name = "lblDoppelp1"
        Me.lblDoppelp1.Size = New System.Drawing.Size(55, 91)
        Me.lblDoppelp1.TabIndex = 9
        Me.lblDoppelp1.Text = ":"
        '
        'lblCMinuten
        '
        Me.lblCMinuten.AutoSize = True
        Me.lblCMinuten.BackColor = System.Drawing.Color.Transparent
        Me.lblCMinuten.Font = New System.Drawing.Font("Impact", 54.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCMinuten.Location = New System.Drawing.Point(239, 16)
        Me.lblCMinuten.Name = "lblCMinuten"
        Me.lblCMinuten.Size = New System.Drawing.Size(119, 91)
        Me.lblCMinuten.TabIndex = 10
        Me.lblCMinuten.Text = "00"
        '
        'lblDoppelp2
        '
        Me.lblDoppelp2.AutoSize = True
        Me.lblDoppelp2.BackColor = System.Drawing.Color.Transparent
        Me.lblDoppelp2.Font = New System.Drawing.Font("Impact", 54.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDoppelp2.Location = New System.Drawing.Point(376, 16)
        Me.lblDoppelp2.Name = "lblDoppelp2"
        Me.lblDoppelp2.Size = New System.Drawing.Size(55, 91)
        Me.lblDoppelp2.TabIndex = 11
        Me.lblDoppelp2.Text = ":"
        '
        'lblCSekunden
        '
        Me.lblCSekunden.AutoSize = True
        Me.lblCSekunden.BackColor = System.Drawing.Color.Transparent
        Me.lblCSekunden.Font = New System.Drawing.Font("Impact", 54.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCSekunden.Location = New System.Drawing.Point(426, 16)
        Me.lblCSekunden.Name = "lblCSekunden"
        Me.lblCSekunden.Size = New System.Drawing.Size(119, 91)
        Me.lblCSekunden.TabIndex = 12
        Me.lblCSekunden.Text = "00"
        '
        'cmdAbbrechen
        '
        Me.cmdAbbrechen.Enabled = False
        Me.cmdAbbrechen.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAbbrechen.Location = New System.Drawing.Point(335, 510)
        Me.cmdAbbrechen.Name = "cmdAbbrechen"
        Me.cmdAbbrechen.Size = New System.Drawing.Size(139, 44)
        Me.cmdAbbrechen.TabIndex = 13
        Me.cmdAbbrechen.Text = "Countdown abbrechen"
        Me.cmdAbbrechen.UseVisualStyleBackColor = True
        '
        'cmdStarten
        '
        Me.cmdStarten.Enabled = False
        Me.cmdStarten.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdStarten.Location = New System.Drawing.Point(45, 510)
        Me.cmdStarten.Name = "cmdStarten"
        Me.cmdStarten.Size = New System.Drawing.Size(139, 44)
        Me.cmdStarten.TabIndex = 14
        Me.cmdStarten.Text = "Countdown starten"
        Me.cmdStarten.UseVisualStyleBackColor = True
        '
        'cmdÜbernehmen
        '
        Me.cmdÜbernehmen.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdÜbernehmen.Location = New System.Drawing.Point(480, 304)
        Me.cmdÜbernehmen.Name = "cmdÜbernehmen"
        Me.cmdÜbernehmen.Size = New System.Drawing.Size(130, 23)
        Me.cmdÜbernehmen.TabIndex = 15
        Me.cmdÜbernehmen.Text = "Übernehmen"
        Me.cmdÜbernehmen.UseVisualStyleBackColor = True
        '
        'cmdÄndern
        '
        Me.cmdÄndern.Enabled = False
        Me.cmdÄndern.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdÄndern.Location = New System.Drawing.Point(480, 333)
        Me.cmdÄndern.Name = "cmdÄndern"
        Me.cmdÄndern.Size = New System.Drawing.Size(130, 23)
        Me.cmdÄndern.TabIndex = 16
        Me.cmdÄndern.Text = "Ändern"
        Me.cmdÄndern.UseVisualStyleBackColor = True
        '
        'cmdPause
        '
        Me.cmdPause.Enabled = False
        Me.cmdPause.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPause.Location = New System.Drawing.Point(190, 510)
        Me.cmdPause.Name = "cmdPause"
        Me.cmdPause.Size = New System.Drawing.Size(139, 44)
        Me.cmdPause.TabIndex = 17
        Me.cmdPause.Text = "Countdown pausieren"
        Me.cmdPause.UseVisualStyleBackColor = True
        '
        'timCountdown
        '
        Me.timCountdown.Interval = 1150
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-4, -4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(624, 251)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblCSekunden)
        Me.GroupBox1.Controls.Add(Me.lblCStunden)
        Me.GroupBox1.Controls.Add(Me.lblDoppelp1)
        Me.GroupBox1.Controls.Add(Me.lblCMinuten)
        Me.GroupBox1.Controls.Add(Me.lblDoppelp2)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 372)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(594, 117)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'Countdown
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(622, 566)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmdPause)
        Me.Controls.Add(Me.cmdÄndern)
        Me.Controls.Add(Me.cmdÜbernehmen)
        Me.Controls.Add(Me.cmdStarten)
        Me.Controls.Add(Me.cmdAbbrechen)
        Me.Controls.Add(Me.cmdZurück)
        Me.Controls.Add(Me.cboSekunden)
        Me.Controls.Add(Me.cboMinuten)
        Me.Controls.Add(Me.lblSekunden)
        Me.Controls.Add(Me.lblMinuten)
        Me.Controls.Add(Me.lblStunden)
        Me.Controls.Add(Me.cboStunden)
        Me.Controls.Add(Me.lblEingabe)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Countdown"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shutdown Timer - Herunterfahren mit Countdown"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEingabe As System.Windows.Forms.Label
    Friend WithEvents cboStunden As System.Windows.Forms.ComboBox
    Friend WithEvents lblStunden As System.Windows.Forms.Label
    Friend WithEvents lblMinuten As System.Windows.Forms.Label
    Friend WithEvents lblSekunden As System.Windows.Forms.Label
    Friend WithEvents cboMinuten As System.Windows.Forms.ComboBox
    Friend WithEvents cboSekunden As System.Windows.Forms.ComboBox
    Friend WithEvents cmdZurück As System.Windows.Forms.Button
    Friend WithEvents lblCStunden As System.Windows.Forms.Label
    Friend WithEvents lblDoppelp1 As System.Windows.Forms.Label
    Friend WithEvents lblCMinuten As System.Windows.Forms.Label
    Friend WithEvents lblDoppelp2 As System.Windows.Forms.Label
    Friend WithEvents lblCSekunden As System.Windows.Forms.Label
    Friend WithEvents cmdAbbrechen As System.Windows.Forms.Button
    Friend WithEvents cmdStarten As System.Windows.Forms.Button
    Friend WithEvents cmdÜbernehmen As System.Windows.Forms.Button
    Friend WithEvents cmdÄndern As System.Windows.Forms.Button
    Friend WithEvents cmdPause As System.Windows.Forms.Button
    Friend WithEvents timCountdown As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
