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
            this.btnEinlesen = new System.Windows.Forms.Button();
            this.txtBoxInput = new System.Windows.Forms.TextBox();
            this.txtBoxOutput = new System.Windows.Forms.TextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblHoehe = new System.Windows.Forms.Label();
            this.lblLaenge = new System.Windows.Forms.Label();
            this.txtBoxHoehe = new System.Windows.Forms.TextBox();
            this.txtBoxLaenge = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnTranspose = new System.Windows.Forms.Button();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.txtBoxReplace = new System.Windows.Forms.TextBox();
            this.txtBoxThreshhold = new System.Windows.Forms.TextBox();
            this.lblThreshhold = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEinlesen
            // 
            this.btnEinlesen.Location = new System.Drawing.Point(21, 761);
            this.btnEinlesen.Margin = new System.Windows.Forms.Padding(4);
            this.btnEinlesen.Name = "btnEinlesen";
            this.btnEinlesen.Size = new System.Drawing.Size(88, 28);
            this.btnEinlesen.TabIndex = 0;
            this.btnEinlesen.Text = "Einlesen";
            this.btnEinlesen.UseVisualStyleBackColor = true;
            this.btnEinlesen.Click += new System.EventHandler(this.btnEinlesen_Click);
            // 
            // txtBoxInput
            // 
            this.txtBoxInput.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxInput.Location = new System.Drawing.Point(16, 39);
            this.txtBoxInput.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxInput.Multiline = true;
            this.txtBoxInput.Name = "txtBoxInput";
            this.txtBoxInput.Size = new System.Drawing.Size(489, 632);
            this.txtBoxInput.TabIndex = 1;
            // 
            // txtBoxOutput
            // 
            this.txtBoxOutput.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxOutput.Location = new System.Drawing.Point(539, 39);
            this.txtBoxOutput.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxOutput.Multiline = true;
            this.txtBoxOutput.Name = "txtBoxOutput";
            this.txtBoxOutput.Size = new System.Drawing.Size(489, 632);
            this.txtBoxOutput.TabIndex = 2;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInput.Location = new System.Drawing.Point(233, 11);
            this.lblInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(60, 25);
            this.lblInput.TabIndex = 3;
            this.lblInput.Text = "Input";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(723, 11);
            this.lblOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(77, 25);
            this.lblOutput.TabIndex = 4;
            this.lblOutput.Text = "Output";
            // 
            // lblHoehe
            // 
            this.lblHoehe.AutoSize = true;
            this.lblHoehe.Location = new System.Drawing.Point(643, 769);
            this.lblHoehe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoehe.Name = "lblHoehe";
            this.lblHoehe.Size = new System.Drawing.Size(46, 17);
            this.lblHoehe.TabIndex = 5;
            this.lblHoehe.Text = "Höhe:";
            // 
            // lblLaenge
            // 
            this.lblLaenge.AutoSize = true;
            this.lblLaenge.Location = new System.Drawing.Point(840, 769);
            this.lblLaenge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLaenge.Name = "lblLaenge";
            this.lblLaenge.Size = new System.Drawing.Size(52, 17);
            this.lblLaenge.TabIndex = 6;
            this.lblLaenge.Text = "Länge:";
            // 
            // txtBoxHoehe
            // 
            this.txtBoxHoehe.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxHoehe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxHoehe.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBoxHoehe.Location = new System.Drawing.Point(699, 764);
            this.txtBoxHoehe.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxHoehe.Name = "txtBoxHoehe";
            this.txtBoxHoehe.Size = new System.Drawing.Size(133, 22);
            this.txtBoxHoehe.TabIndex = 7;
            // 
            // txtBoxLaenge
            // 
            this.txtBoxLaenge.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxLaenge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxLaenge.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBoxLaenge.Location = new System.Drawing.Point(901, 764);
            this.txtBoxLaenge.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxLaenge.Name = "txtBoxLaenge";
            this.txtBoxLaenge.Size = new System.Drawing.Size(133, 22);
            this.txtBoxLaenge.TabIndex = 8;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(117, 761);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 28);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Claer";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(123, 678);
            this.btnReplace.Margin = new System.Windows.Forms.Padding(4);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(88, 28);
            this.btnReplace.TabIndex = 10;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnTranspose
            // 
            this.btnTranspose.Location = new System.Drawing.Point(213, 761);
            this.btnTranspose.Margin = new System.Windows.Forms.Padding(4);
            this.btnTranspose.Name = "btnTranspose";
            this.btnTranspose.Size = new System.Drawing.Size(88, 28);
            this.btnTranspose.TabIndex = 11;
            this.btnTranspose.Text = "Transpose";
            this.btnTranspose.UseVisualStyleBackColor = true;
            this.btnTranspose.Click += new System.EventHandler(this.btnTranspose_Click);
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Items.AddRange(new object[] {
            "Binary",
            "Median",
            "Average",
            "Replace",
            "Clear",
            "Transpose"});
            this.comboBoxFilter.Location = new System.Drawing.Point(845, 678);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(183, 24);
            this.comboBoxFilter.TabIndex = 12;
            this.comboBoxFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilter_SelectedIndexChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(796, 681);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(43, 17);
            this.lblFilter.TabIndex = 13;
            this.lblFilter.Text = "Filter:";
            // 
            // txtBoxReplace
            // 
            this.txtBoxReplace.Location = new System.Drawing.Point(16, 680);
            this.txtBoxReplace.Name = "txtBoxReplace";
            this.txtBoxReplace.Size = new System.Drawing.Size(100, 22);
            this.txtBoxReplace.TabIndex = 14;
            // 
            // txtBoxThreshhold
            // 
            this.txtBoxThreshhold.Location = new System.Drawing.Point(928, 708);
            this.txtBoxThreshhold.Name = "txtBoxThreshhold";
            this.txtBoxThreshhold.Size = new System.Drawing.Size(100, 22);
            this.txtBoxThreshhold.TabIndex = 15;
            // 
            // lblThreshhold
            // 
            this.lblThreshhold.AutoSize = true;
            this.lblThreshhold.Location = new System.Drawing.Point(838, 711);
            this.lblThreshhold.Name = "lblThreshhold";
            this.lblThreshhold.Size = new System.Drawing.Size(84, 17);
            this.lblThreshhold.TabIndex = 16;
            this.lblThreshhold.Text = "Threshhold:";
            // 
            // AsciiImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 796);
            this.Controls.Add(this.lblThreshhold);
            this.Controls.Add(this.txtBoxThreshhold);
            this.Controls.Add(this.txtBoxReplace);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.btnTranspose);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtBoxLaenge);
            this.Controls.Add(this.txtBoxHoehe);
            this.Controls.Add(this.lblLaenge);
            this.Controls.Add(this.lblHoehe);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.txtBoxOutput);
            this.Controls.Add(this.txtBoxInput);
            this.Controls.Add(this.btnEinlesen);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AsciiImage";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEinlesen;
        private System.Windows.Forms.TextBox txtBoxInput;
        private System.Windows.Forms.TextBox txtBoxOutput;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblHoehe;
        private System.Windows.Forms.Label lblLaenge;
        private System.Windows.Forms.TextBox txtBoxHoehe;
        private System.Windows.Forms.TextBox txtBoxLaenge;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnTranspose;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.TextBox txtBoxReplace;
        private System.Windows.Forms.TextBox txtBoxThreshhold;
        private System.Windows.Forms.Label lblThreshhold;
    }
}

