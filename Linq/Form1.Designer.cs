namespace Linq
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
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxCountryPrice = new System.Windows.Forms.TextBox();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.buttonFindById = new System.Windows.Forms.Button();
            this.buttonFindByYear = new System.Windows.Forms.Button();
            this.buttonFindByCountry = new System.Windows.Forms.Button();
            this.buttonFindByCountryPrice = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.resultText = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(120, 17);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 0;
            this.textBoxId.TextChanged += new System.EventHandler(this.textBoxId_TextChanged);
            // 
            // textBoxCountryPrice
            // 
            this.textBoxCountryPrice.Location = new System.Drawing.Point(120, 136);
            this.textBoxCountryPrice.Name = "textBoxCountryPrice";
            this.textBoxCountryPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxCountryPrice.TabIndex = 1;
            this.textBoxCountryPrice.TextChanged += new System.EventHandler(this.textBoxCountryPrice_TextChanged);
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Location = new System.Drawing.Point(120, 69);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(100, 20);
            this.textBoxCountry.TabIndex = 2;
            this.textBoxCountry.TextChanged += new System.EventHandler(this.textBoxCountry_TextChanged);
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(120, 43);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(100, 20);
            this.textBoxYear.TabIndex = 3;
            this.textBoxYear.TextChanged += new System.EventHandler(this.textBoxYear_TextChanged);
            // 
            // buttonFindById
            // 
            this.buttonFindById.Location = new System.Drawing.Point(226, 17);
            this.buttonFindById.Name = "buttonFindById";
            this.buttonFindById.Size = new System.Drawing.Size(75, 20);
            this.buttonFindById.TabIndex = 4;
            this.buttonFindById.Text = "Wyszukaj";
            this.buttonFindById.UseVisualStyleBackColor = true;
            this.buttonFindById.Click += new System.EventHandler(this.buttonFindById_Click);
            // 
            // buttonFindByYear
            // 
            this.buttonFindByYear.Location = new System.Drawing.Point(226, 43);
            this.buttonFindByYear.Name = "buttonFindByYear";
            this.buttonFindByYear.Size = new System.Drawing.Size(75, 20);
            this.buttonFindByYear.TabIndex = 5;
            this.buttonFindByYear.Text = "Wyszukaj";
            this.buttonFindByYear.UseVisualStyleBackColor = true;
            this.buttonFindByYear.Click += new System.EventHandler(this.buttonFindByYear_Click);
            // 
            // buttonFindByCountry
            // 
            this.buttonFindByCountry.Location = new System.Drawing.Point(226, 69);
            this.buttonFindByCountry.Name = "buttonFindByCountry";
            this.buttonFindByCountry.Size = new System.Drawing.Size(75, 20);
            this.buttonFindByCountry.TabIndex = 6;
            this.buttonFindByCountry.Text = "Wyszukaj";
            this.buttonFindByCountry.UseVisualStyleBackColor = true;
            this.buttonFindByCountry.Click += new System.EventHandler(this.buttonFindByCountry_Click);
            // 
            // buttonFindByCountryPrice
            // 
            this.buttonFindByCountryPrice.Location = new System.Drawing.Point(92, 185);
            this.buttonFindByCountryPrice.Name = "buttonFindByCountryPrice";
            this.buttonFindByCountryPrice.Size = new System.Drawing.Size(75, 20);
            this.buttonFindByCountryPrice.TabIndex = 7;
            this.buttonFindByCountryPrice.Text = "Wyszukaj";
            this.buttonFindByCountryPrice.UseVisualStyleBackColor = true;
            this.buttonFindByCountryPrice.Click += new System.EventHandler(this.buttonFindByCountryPrice_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(14, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultText
            // 
            this.resultText.AutoSize = true;
            this.resultText.Location = new System.Drawing.Point(426, 24);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(0, 13);
            this.resultText.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(14, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Rok wydania:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(14, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Kraj wydania:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(14, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Kraj wydania:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(426, 24);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 13);
            this.labelResult.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(117, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Wyszukaj po kraju i cenie";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(14, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Cena wieksza niż:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(120, 159);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 19;
            this.textBoxPrice.TextChanged += new System.EventHandler(this.textBoxPrice_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonFindByCountryPrice);
            this.Controls.Add(this.buttonFindByCountry);
            this.Controls.Add(this.buttonFindByYear);
            this.Controls.Add(this.buttonFindById);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxCountry);
            this.Controls.Add(this.textBoxCountryPrice);
            this.Controls.Add(this.textBoxId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxCountryPrice;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Button buttonFindById;
        private System.Windows.Forms.Button buttonFindByYear;
        private System.Windows.Forms.Button buttonFindByCountry;
        private System.Windows.Forms.Button buttonFindByCountryPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label resultText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxPrice;
    }
}

