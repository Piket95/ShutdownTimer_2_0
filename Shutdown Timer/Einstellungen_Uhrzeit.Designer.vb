<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Einstellungen_Uhrzeit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Einstellungen_Uhrzeit))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdÜbernehmen = New System.Windows.Forms.Button()
        Me.cmdZurück = New System.Windows.Forms.Button()
        Me.cbFünf = New System.Windows.Forms.CheckBox()
        Me.cbViertel = New System.Windows.Forms.CheckBox()
        Me.cbHalbe = New System.Windows.Forms.CheckBox()
        Me.cbStunde = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbAlle = New System.Windows.Forms.CheckBox()
        Me.cbKeine = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbKeine)
        Me.GroupBox1.Controls.Add(Me.cmdÜbernehmen)
        Me.GroupBox1.Controls.Add(Me.cmdZurück)
        Me.GroupBox1.Controls.Add(Me.cbFünf)
        Me.GroupBox1.Controls.Add(Me.cbViertel)
        Me.GroupBox1.Controls.Add(Me.cbHalbe)
        Me.GroupBox1.Controls.Add(Me.cbStunde)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.cbAlle)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(381, 292)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'cmdÜbernehmen
        '
        Me.cmdÜbernehmen.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdÜbernehmen.Location = New System.Drawing.Point(91, 242)
        Me.cmdÜbernehmen.Name = "cmdÜbernehmen"
        Me.cmdÜbernehmen.Size = New System.Drawing.Size(139, 44)
        Me.cmdÜbernehmen.TabIndex = 22
        Me.cmdÜbernehmen.Text = "Übernehmen"
        Me.cmdÜbernehmen.UseVisualStyleBackColor = True
        '
        'cmdZurück
        '
        Me.cmdZurück.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdZurück.Location = New System.Drawing.Point(236, 242)
        Me.cmdZurück.Name = "cmdZurück"
        Me.cmdZurück.Size = New System.Drawing.Size(139, 44)
        Me.cmdZurück.TabIndex = 21
        Me.cmdZurück.Text = "Zurück"
        Me.cmdZurück.UseVisualStyleBackColor = True
        '
        'cbFünf
        '
        Me.cbFünf.AutoSize = True
        Me.cbFünf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFünf.Location = New System.Drawing.Point(30, 210)
        Me.cbFünf.Name = "cbFünf"
        Me.cbFünf.Size = New System.Drawing.Size(225, 17)
        Me.cbFünf.TabIndex = 5
        Me.cbFünf.Text = "Benachrichtigung 5 Minuten vorher"
        Me.cbFünf.UseVisualStyleBackColor = True
        '
        'cbViertel
        '
        Me.cbViertel.AutoSize = True
        Me.cbViertel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbViertel.Location = New System.Drawing.Point(30, 187)
        Me.cbViertel.Name = "cbViertel"
        Me.cbViertel.Size = New System.Drawing.Size(232, 17)
        Me.cbViertel.TabIndex = 4
        Me.cbViertel.Text = "Benachrichtigung 15 Minuten vorher"
        Me.cbViertel.UseVisualStyleBackColor = True
        '
        'cbHalbe
        '
        Me.cbHalbe.AutoSize = True
        Me.cbHalbe.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbHalbe.Location = New System.Drawing.Point(30, 164)
        Me.cbHalbe.Name = "cbHalbe"
        Me.cbHalbe.Size = New System.Drawing.Size(232, 17)
        Me.cbHalbe.TabIndex = 3
        Me.cbHalbe.Text = "Benachrichtigung 30 Minuten vorher"
        Me.cbHalbe.UseVisualStyleBackColor = True
        '
        'cbStunde
        '
        Me.cbStunde.AutoSize = True
        Me.cbStunde.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbStunde.Location = New System.Drawing.Point(30, 141)
        Me.cbStunde.Name = "cbStunde"
        Me.cbStunde.Size = New System.Drawing.Size(220, 17)
        Me.cbStunde.TabIndex = 2
        Me.cbStunde.Text = "Benachrichtigung 1 Stunde vorher"
        Me.cbStunde.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(7, 20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(368, 49)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(274, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Häckenchen bedeuten, dass die" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Benachrichtigungen angezeigt werden!"
        '
        'cbAlle
        '
        Me.cbAlle.AutoSize = True
        Me.cbAlle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAlle.Location = New System.Drawing.Point(7, 84)
        Me.cbAlle.Name = "cbAlle"
        Me.cbAlle.Size = New System.Drawing.Size(164, 17)
        Me.cbAlle.TabIndex = 0
        Me.cbAlle.Text = "Alle Benachrichtigungen"
        Me.cbAlle.UseVisualStyleBackColor = True
        '
        'cbKeine
        '
        Me.cbKeine.AutoSize = True
        Me.cbKeine.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbKeine.Location = New System.Drawing.Point(7, 107)
        Me.cbKeine.Name = "cbKeine"
        Me.cbKeine.Size = New System.Drawing.Size(230, 17)
        Me.cbKeine.TabIndex = 23
        Me.cbKeine.Text = "Keine Benachrichtigungen anzeigen"
        Me.cbKeine.UseVisualStyleBackColor = True
        '
        'Einstellungen_Uhrzeit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 310)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Einstellungen_Uhrzeit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Einstellungsoptionen"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents cbAlle As CheckBox
    Friend WithEvents cbFünf As CheckBox
    Friend WithEvents cbViertel As CheckBox
    Friend WithEvents cbHalbe As CheckBox
    Friend WithEvents cbStunde As CheckBox
    Friend WithEvents cmdÜbernehmen As Button
    Friend WithEvents cmdZurück As Button
    Friend WithEvents cbKeine As CheckBox
End Class
