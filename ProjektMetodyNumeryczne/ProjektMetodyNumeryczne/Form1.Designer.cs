namespace ProjektMetodyNumeryczne
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
            this.funcPrinterBox = new System.Windows.Forms.PictureBox();
            this.dgvCoords = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonFuncInCoord = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.funcPrinterBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoords)).BeginInit();
            this.SuspendLayout();
            // 
            // funcPrinterBox
            // 
            this.funcPrinterBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.funcPrinterBox.Location = new System.Drawing.Point(12, 3);
            this.funcPrinterBox.Name = "funcPrinterBox";
            this.funcPrinterBox.Size = new System.Drawing.Size(677, 509);
            this.funcPrinterBox.TabIndex = 1;
            this.funcPrinterBox.TabStop = false;
            // 
            // dgvCoords
            // 
            this.dgvCoords.AllowUserToResizeColumns = false;
            this.dgvCoords.AllowUserToResizeRows = false;
            this.dgvCoords.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvCoords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvCoords.Location = new System.Drawing.Point(695, 12);
            this.dgvCoords.Name = "dgvCoords";
            this.dgvCoords.RowHeadersVisible = false;
            this.dgvCoords.Size = new System.Drawing.Size(139, 266);
            this.dgvCoords.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(695, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Podaj wartość x:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(695, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Podaj ilość punktów:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(702, 496);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Wynik:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(695, 424);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(695, 381);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(695, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 37);
            this.button1.TabIndex = 12;
            this.button1.Text = "Oblicz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonFuncInCoord
            // 
            this.buttonFuncInCoord.Location = new System.Drawing.Point(705, 299);
            this.buttonFuncInCoord.Name = "buttonFuncInCoord";
            this.buttonFuncInCoord.Size = new System.Drawing.Size(129, 42);
            this.buttonFuncInCoord.TabIndex = 11;
            this.buttonFuncInCoord.Text = "Wyświetl wykres";
            this.buttonFuncInCoord.UseVisualStyleBackColor = true;
            this.buttonFuncInCoord.Click += new System.EventHandler(this.buttonFuncInCoord_Click_1);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "     X";
            this.Column1.MaxInputLength = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "     Y";
            this.Column2.MaxInputLength = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 60;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 522);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonFuncInCoord);
            this.Controls.Add(this.dgvCoords);
            this.Controls.Add(this.funcPrinterBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.funcPrinterBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox funcPrinterBox;
        private System.Windows.Forms.DataGridView dgvCoords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonFuncInCoord;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

