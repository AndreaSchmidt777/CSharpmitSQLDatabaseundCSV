namespace CSHARP_MIT_MYSQL_DATENBANK
{
    partial class Form1
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
            this.dgvAngestellte = new System.Windows.Forms.DataGridView();
            this.btneinlesen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnspeichern = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAngestellte)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAngestellte
            // 
            this.dgvAngestellte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAngestellte.Location = new System.Drawing.Point(173, 190);
            this.dgvAngestellte.Name = "dgvAngestellte";
            this.dgvAngestellte.Size = new System.Drawing.Size(957, 375);
            this.dgvAngestellte.TabIndex = 0;
            // 
            // btneinlesen
            // 
            this.btneinlesen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneinlesen.Location = new System.Drawing.Point(628, 103);
            this.btneinlesen.Name = "btneinlesen";
            this.btneinlesen.Size = new System.Drawing.Size(248, 70);
            this.btneinlesen.TabIndex = 1;
            this.btneinlesen.Text = "Einlesen und Darstellen";
            this.btneinlesen.UseVisualStyleBackColor = true;
            this.btneinlesen.Click += new System.EventHandler(this.btneinlesen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(173, 103);
            this.txtFilePath.Multiline = true;
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(449, 70);
            this.txtFilePath.TabIndex = 2;
            // 
            // btnspeichern
            // 
            this.btnspeichern.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnspeichern.Location = new System.Drawing.Point(882, 103);
            this.btnspeichern.Name = "btnspeichern";
            this.btnspeichern.Size = new System.Drawing.Size(248, 70);
            this.btnspeichern.TabIndex = 3;
            this.btnspeichern.Text = "Datei speichern +";
            this.btnspeichern.UseVisualStyleBackColor = true;
            this.btnspeichern.Click += new System.EventHandler(this.btnspeichern_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1463, 661);
            this.Controls.Add(this.btnspeichern);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btneinlesen);
            this.Controls.Add(this.dgvAngestellte);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAngestellte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAngestellte;
        private System.Windows.Forms.Button btneinlesen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnspeichern;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

