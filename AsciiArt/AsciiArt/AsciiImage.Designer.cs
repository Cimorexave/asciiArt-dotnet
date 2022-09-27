namespace AsciiArt
{
    partial class AsciiImage
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
            this.txtBoxInput = new System.Windows.Forms.TextBox();
            this.txtBoxOutput = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnTranspose = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblLenght = new System.Windows.Forms.Label();
            this.txtBoxHeight = new System.Windows.Forms.TextBox();
            this.txtBoxLenght = new System.Windows.Forms.TextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxInput
            // 
            this.txtBoxInput.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxInput.Location = new System.Drawing.Point(12, 36);
            this.txtBoxInput.Multiline = true;
            this.txtBoxInput.Name = "txtBoxInput";
            this.txtBoxInput.Size = new System.Drawing.Size(365, 450);
            this.txtBoxInput.TabIndex = 0;
            // 
            // txtBoxOutput
            // 
            this.txtBoxOutput.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxOutput.Location = new System.Drawing.Point(383, 36);
            this.txtBoxOutput.Multiline = true;
            this.txtBoxOutput.Name = "txtBoxOutput";
            this.txtBoxOutput.Size = new System.Drawing.Size(365, 450);
            this.txtBoxOutput.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(93, 556);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(12, 556);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 3;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(174, 556);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(75, 23);
            this.btnReplace.TabIndex = 4;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnTranspose
            // 
            this.btnTranspose.Location = new System.Drawing.Point(255, 556);
            this.btnTranspose.Name = "btnTranspose";
            this.btnTranspose.Size = new System.Drawing.Size(75, 23);
            this.btnTranspose.TabIndex = 5;
            this.btnTranspose.Text = "Transpose";
            this.btnTranspose.UseVisualStyleBackColor = true;
            this.btnTranspose.Click += new System.EventHandler(this.btnTranspose_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(517, 5);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(82, 25);
            this.lblOutput.TabIndex = 7;
            this.lblOutput.Text = "Output";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(454, 562);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(41, 13);
            this.lblHeight.TabIndex = 8;
            this.lblHeight.Text = "Height:";
            // 
            // lblLenght
            // 
            this.lblLenght.AutoSize = true;
            this.lblLenght.Location = new System.Drawing.Point(602, 562);
            this.lblLenght.Name = "lblLenght";
            this.lblLenght.Size = new System.Drawing.Size(43, 13);
            this.lblLenght.TabIndex = 9;
            this.lblLenght.Text = "Lenght:";
            // 
            // txtBoxHeight
            // 
            this.txtBoxHeight.Location = new System.Drawing.Point(496, 559);
            this.txtBoxHeight.Name = "txtBoxHeight";
            this.txtBoxHeight.Size = new System.Drawing.Size(100, 20);
            this.txtBoxHeight.TabIndex = 10;
            // 
            // txtBoxLenght
            // 
            this.txtBoxLenght.Location = new System.Drawing.Point(648, 559);
            this.txtBoxLenght.Name = "txtBoxLenght";
            this.txtBoxLenght.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLenght.TabIndex = 11;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInput.Location = new System.Drawing.Point(170, 6);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(56, 24);
            this.lblInput.TabIndex = 12;
            this.lblInput.Text = "Input";
            // 
            // AsciiImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 591);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.txtBoxLenght);
            this.Controls.Add(this.txtBoxHeight);
            this.Controls.Add(this.lblLenght);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnTranspose);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtBoxOutput);
            this.Controls.Add(this.txtBoxInput);
            this.Name = "AsciiImage";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxInput;
        private System.Windows.Forms.TextBox txtBoxOutput;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnTranspose;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblLenght;
        private System.Windows.Forms.TextBox txtBoxHeight;
        private System.Windows.Forms.TextBox txtBoxLenght;
        private System.Windows.Forms.Label lblInput;
    }
}

