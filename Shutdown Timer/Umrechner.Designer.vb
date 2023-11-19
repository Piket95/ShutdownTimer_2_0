<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Umrechner
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Umrechner))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmdUmrechnen = New System.Windows.Forms.Button()
        Me.txtVon = New System.Windows.Forms.TextBox()
        Me.txtZu = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboVon = New System.Windows.Forms.ComboBox()
        Me.cboZu = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Lithos Pro Regular", 12.75!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(184, 160)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(166, 61)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Zurück zum Hauptmenü"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmdUmrechnen
        '
        Me.cmdUmrechnen.Font = New System.Drawing.Font("Lithos Pro Regular", 12.75!, System.Drawing.FontStyle.Bold)
        Me.cmdUmrechnen.Location = New System.Drawing.Point(12, 160)
        Me.cmdUmrechnen.Name = "cmdUmrechnen"
        Me.cmdUmrechnen.Size = New System.Drawing.Size(166, 60)
        Me.cmdUmrechnen.TabIndex = 8
        Me.cmdUmrechnen.Text = "Umrechnen"
        Me.cmdUmrechnen.UseVisualStyleBackColor = True
        '
        'txtVon
        '
        Me.txtVon.Location = New System.Drawing.Point(12, 52)
        Me.txtVon.Name = "txtVon"
        Me.txtVon.Size = New System.Drawing.Size(147, 20)
        Me.txtVon.TabIndex = 9
        '
        'txtZu
        '
        Me.txtZu.Location = New System.Drawing.Point(203, 52)
        Me.txtZu.Name = "txtZu"
        Me.txtZu.ReadOnly = True
        Me.txtZu.Size = New System.Drawing.Size(147, 20)
        Me.txtZu.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(165, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "----->"
        '
        'cboVon
        '
        Me.cboVon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVon.FormattingEnabled = True
        Me.cboVon.Items.AddRange(New Object() {"Stunde", "Minute", "Sekunde"})
        Me.cboVon.Location = New System.Drawing.Point(12, 78)
        Me.cboVon.Name = "cboVon"
        Me.cboVon.Size = New System.Drawing.Size(121, 21)
        Me.cboVon.TabIndex = 12
        '
        'cboZu
        '
        Me.cboZu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboZu.FormattingEnabled = True
        Me.cboZu.Items.AddRange(New Object() {"Stunde", "Minute", "Sekunde"})
        Me.cboZu.Location = New System.Drawing.Point(203, 78)
        Me.cboZu.Name = "cboZu"
        Me.cboZu.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboZu.Size = New System.Drawing.Size(121, 21)
        Me.cboZu.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(9, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 11)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Anfangswert"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(200, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 11)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Endwert"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(356, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(316, 234)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Umrechner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 233)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboZu)
        Me.Controls.Add(Me.cboVon)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtZu)
        Me.Controls.Add(Me.txtVon)
        Me.Controls.Add(Me.cmdUmrechnen)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Umrechner"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Umrechner"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmdUmrechnen As System.Windows.Forms.Button
    Friend WithEvents txtVon As System.Windows.Forms.TextBox
    Friend WithEvents txtZu As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboVon As System.Windows.Forms.ComboBox
    Friend WithEvents cboZu As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
