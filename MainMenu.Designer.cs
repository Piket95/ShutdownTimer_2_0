
namespace ShutdownTimer_2_0
{
    partial class MainMenu
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCountdown = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTime = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCountdown
            // 
            this.btnCountdown.Location = new System.Drawing.Point(35, 167);
            this.btnCountdown.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCountdown.Name = "btnCountdown";
            this.btnCountdown.Size = new System.Drawing.Size(278, 52);
            this.btnCountdown.TabIndex = 0;
            this.btnCountdown.Text = "Timer stellen";
            this.btnCountdown.UseVisualStyleBackColor = true;
            this.btnCountdown.Click += new System.EventHandler(this.btnCountdown_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(305, 106);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mithilfe dieses Programms können\r\nSie bestimmen, wann Sie Ihren PC\r\nherunterfahre" +
    "n lassen wollen";
            // 
            // btnCalculator
            // 
            this.btnCalculator.Enabled = false;
            this.btnCalculator.Location = new System.Drawing.Point(35, 295);
            this.btnCalculator.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(278, 52);
            this.btnCalculator.TabIndex = 0;
            this.btnCalculator.Text = "Umrechner";
            this.btnCalculator.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            this.btnSettings.Enabled = false;
            this.btnSettings.Location = new System.Drawing.Point(35, 359);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(278, 52);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.Text = "Einstellungen";
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(35, 423);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(278, 52);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Beenden";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ShutdownTimer_2_0.Properties.Resources.edf190d972207aef;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(344, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 526);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnTime
            // 
            this.btnTime.Location = new System.Drawing.Point(35, 231);
            this.btnTime.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTime.Name = "btnTime";
            this.btnTime.Size = new System.Drawing.Size(278, 52);
            this.btnTime.TabIndex = 0;
            this.btnTime.Text = "Uhrzeit festlegen";
            this.btnTime.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 523);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnCalculator);
            this.Controls.Add(this.btnTime);
            this.Controls.Add(this.btnCountdown);
            this.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.Text = "ShutdownTimer 2.0 - Hauptmenü";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCountdown;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculator;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnTime;
    }
}

