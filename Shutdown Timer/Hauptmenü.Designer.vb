<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hauptmenü
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Hauptmenü))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdCountdown = New System.Windows.Forms.Button()
        Me.cmdUhrzeit = New System.Windows.Forms.Button()
        Me.cmdBeenden = New System.Windows.Forms.Button()
        Me.cmdUmrechner = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmdEinstellungen = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lithos Pro Regular", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 45)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Willkommen"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(281, 48)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mithilfe dieses Programmes können Sie" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "bestimmen wann Sie Ihren PC" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Herunterfahre" &
    "n lassen wollen."
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(12, 57)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(319, 74)
        Me.Panel1.TabIndex = 2
        '
        'cmdCountdown
        '
        Me.cmdCountdown.Font = New System.Drawing.Font("Lucida Console", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCountdown.Location = New System.Drawing.Point(12, 158)
        Me.cmdCountdown.Name = "cmdCountdown"
        Me.cmdCountdown.Size = New System.Drawing.Size(319, 69)
        Me.cmdCountdown.TabIndex = 3
        Me.cmdCountdown.Text = "Herunterfahren mit Countdown"
        Me.cmdCountdown.UseVisualStyleBackColor = True
        '
        'cmdUhrzeit
        '
        Me.cmdUhrzeit.Font = New System.Drawing.Font("Lucida Console", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUhrzeit.Location = New System.Drawing.Point(12, 233)
        Me.cmdUhrzeit.Name = "cmdUhrzeit"
        Me.cmdUhrzeit.Size = New System.Drawing.Size(319, 69)
        Me.cmdUhrzeit.TabIndex = 4
        Me.cmdUhrzeit.Text = "Herunterfahren nach bestimmter Uhrzeit"
        Me.cmdUhrzeit.UseVisualStyleBackColor = True
        '
        'cmdBeenden
        '
        Me.cmdBeenden.Font = New System.Drawing.Font("Lucida Console", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBeenden.Location = New System.Drawing.Point(12, 458)
        Me.cmdBeenden.Name = "cmdBeenden"
        Me.cmdBeenden.Size = New System.Drawing.Size(319, 69)
        Me.cmdBeenden.TabIndex = 5
        Me.cmdBeenden.Text = "Beenden"
        Me.cmdBeenden.UseVisualStyleBackColor = True
        '
        'cmdUmrechner
        '
        Me.cmdUmrechner.Font = New System.Drawing.Font("Lucida Console", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUmrechner.Location = New System.Drawing.Point(12, 308)
        Me.cmdUmrechner.Name = "cmdUmrechner"
        Me.cmdUmrechner.Size = New System.Drawing.Size(319, 69)
        Me.cmdUmrechner.TabIndex = 6
        Me.cmdUmrechner.Text = "Umrechner"
        Me.cmdUmrechner.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(341, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(338, 538)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'cmdEinstellungen
        '
        Me.cmdEinstellungen.Font = New System.Drawing.Font("Lucida Console", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEinstellungen.Location = New System.Drawing.Point(12, 383)
        Me.cmdEinstellungen.Name = "cmdEinstellungen"
        Me.cmdEinstellungen.Size = New System.Drawing.Size(319, 69)
        Me.cmdEinstellungen.TabIndex = 8
        Me.cmdEinstellungen.Text = "Einstellungen"
        Me.cmdEinstellungen.UseVisualStyleBackColor = True
        '
        'Hauptmenü
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 537)
        Me.Controls.Add(Me.cmdEinstellungen)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmdUmrechner)
        Me.Controls.Add(Me.cmdBeenden)
        Me.Controls.Add(Me.cmdUhrzeit)
        Me.Controls.Add(Me.cmdCountdown)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Hauptmenü"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shutdown Timer - Hauptmenü"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdCountdown As System.Windows.Forms.Button
    Friend WithEvents cmdUhrzeit As System.Windows.Forms.Button
    Friend WithEvents cmdBeenden As System.Windows.Forms.Button
    Friend WithEvents cmdUmrechner As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdEinstellungen As Button
End Class
