namespace Bacon_cipher
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.gBSource = new System.Windows.Forms.GroupBox();
            this.rBFile = new System.Windows.Forms.RadioButton();
            this.rBText = new System.Windows.Forms.RadioButton();
            this.gBOperation = new System.Windows.Forms.GroupBox();
            this.rBD = new System.Windows.Forms.RadioButton();
            this.rBE = new System.Windows.Forms.RadioButton();
            this.btngo = new System.Windows.Forms.Button();
            this.tBText = new System.Windows.Forms.TextBox();
            this.tBMessage = new System.Windows.Forms.TextBox();
            this.gBSource.SuspendLayout();
            this.gBOperation.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBSource
            // 
            this.gBSource.Controls.Add(this.rBFile);
            this.gBSource.Controls.Add(this.rBText);
            this.gBSource.Location = new System.Drawing.Point(12, 13);
            this.gBSource.Name = "gBSource";
            this.gBSource.Size = new System.Drawing.Size(69, 73);
            this.gBSource.TabIndex = 0;
            this.gBSource.TabStop = false;
            this.gBSource.Text = "Source";
            // 
            // rBFile
            // 
            this.rBFile.AutoSize = true;
            this.rBFile.Location = new System.Drawing.Point(7, 43);
            this.rBFile.Name = "rBFile";
            this.rBFile.Size = new System.Drawing.Size(41, 17);
            this.rBFile.TabIndex = 1;
            this.rBFile.Text = "File";
            this.rBFile.UseVisualStyleBackColor = true;
            this.rBFile.CheckedChanged += new System.EventHandler(this.SelectSource);
            // 
            // rBText
            // 
            this.rBText.AutoSize = true;
            this.rBText.Checked = true;
            this.rBText.Location = new System.Drawing.Point(7, 20);
            this.rBText.Name = "rBText";
            this.rBText.Size = new System.Drawing.Size(46, 17);
            this.rBText.TabIndex = 0;
            this.rBText.TabStop = true;
            this.rBText.Text = "Text";
            this.rBText.UseVisualStyleBackColor = true;
            this.rBText.CheckedChanged += new System.EventHandler(this.SelectSource);
            // 
            // gBOperation
            // 
            this.gBOperation.Controls.Add(this.rBD);
            this.gBOperation.Controls.Add(this.rBE);
            this.gBOperation.Location = new System.Drawing.Point(12, 92);
            this.gBOperation.Name = "gBOperation";
            this.gBOperation.Size = new System.Drawing.Size(78, 73);
            this.gBOperation.TabIndex = 2;
            this.gBOperation.TabStop = false;
            this.gBOperation.Text = "Operations";
            // 
            // rBD
            // 
            this.rBD.AutoSize = true;
            this.rBD.Location = new System.Drawing.Point(7, 43);
            this.rBD.Name = "rBD";
            this.rBD.Size = new System.Drawing.Size(62, 17);
            this.rBD.TabIndex = 1;
            this.rBD.Text = "Decrypt";
            this.rBD.UseVisualStyleBackColor = true;
            this.rBD.CheckedChanged += new System.EventHandler(this.Operation);
            // 
            // rBE
            // 
            this.rBE.AutoSize = true;
            this.rBE.Checked = true;
            this.rBE.Location = new System.Drawing.Point(7, 20);
            this.rBE.Name = "rBE";
            this.rBE.Size = new System.Drawing.Size(61, 17);
            this.rBE.TabIndex = 0;
            this.rBE.TabStop = true;
            this.rBE.Text = "Encrypt";
            this.rBE.UseVisualStyleBackColor = true;
            this.rBE.CheckedChanged += new System.EventHandler(this.Operation);
            // 
            // btngo
            // 
            this.btngo.Location = new System.Drawing.Point(12, 172);
            this.btngo.Name = "btngo";
            this.btngo.Size = new System.Drawing.Size(75, 23);
            this.btngo.TabIndex = 3;
            this.btngo.Text = "Encrypt";
            this.btngo.UseVisualStyleBackColor = true;
            this.btngo.Click += new System.EventHandler(this.btngo_Click);
            // 
            // tBText
            // 
            this.tBText.Location = new System.Drawing.Point(98, 13);
            this.tBText.Multiline = true;
            this.tBText.Name = "tBText";
            this.tBText.Size = new System.Drawing.Size(344, 289);
            this.tBText.TabIndex = 4;
            // 
            // tBMessage
            // 
            this.tBMessage.Enabled = false;
            this.tBMessage.Location = new System.Drawing.Point(448, 13);
            this.tBMessage.Multiline = true;
            this.tBMessage.Name = "tBMessage";
            this.tBMessage.Size = new System.Drawing.Size(340, 289);
            this.tBMessage.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 314);
            this.Controls.Add(this.tBMessage);
            this.Controls.Add(this.tBText);
            this.Controls.Add(this.btngo);
            this.Controls.Add(this.gBOperation);
            this.Controls.Add(this.gBSource);
            this.Name = "Form1";
            this.Text = "Bacon cipher";
            this.gBSource.ResumeLayout(false);
            this.gBSource.PerformLayout();
            this.gBOperation.ResumeLayout(false);
            this.gBOperation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBSource;
        private System.Windows.Forms.RadioButton rBFile;
        private System.Windows.Forms.RadioButton rBText;
        private System.Windows.Forms.GroupBox gBOperation;
        private System.Windows.Forms.RadioButton rBD;
        private System.Windows.Forms.RadioButton rBE;
        private System.Windows.Forms.Button btngo;
        private System.Windows.Forms.TextBox tBText;
        private System.Windows.Forms.TextBox tBMessage;
    }
}

