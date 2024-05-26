namespace WF_lab2_zad1
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
            this.textBoxDzielna = new System.Windows.Forms.TextBox();
            this.textBoxDzielnik = new System.Windows.Forms.TextBox();
            this.btn_calc = new System.Windows.Forms.Button();
            this.textBoxWynik = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxDzielna
            // 
            this.textBoxDzielna.Location = new System.Drawing.Point(101, 111);
            this.textBoxDzielna.Name = "textBoxDzielna";
            this.textBoxDzielna.Size = new System.Drawing.Size(100, 20);
            this.textBoxDzielna.TabIndex = 0;
            // 
            // textBoxDzielnik
            // 
            this.textBoxDzielnik.Location = new System.Drawing.Point(101, 137);
            this.textBoxDzielnik.Name = "textBoxDzielnik";
            this.textBoxDzielnik.Size = new System.Drawing.Size(100, 20);
            this.textBoxDzielnik.TabIndex = 1;
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(101, 163);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(100, 23);
            this.btn_calc.TabIndex = 2;
            this.btn_calc.Text = "Oblicz";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.BtnCalcClick);
            // 
            // textBoxWynik
            // 
            this.textBoxWynik.Location = new System.Drawing.Point(101, 192);
            this.textBoxWynik.Name = "textBoxWynik";
            this.textBoxWynik.Size = new System.Drawing.Size(100, 20);
            this.textBoxWynik.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dzielna:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dzielnik:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Wynik:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(26, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dzielenie Dwóch Liczb";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxWynik);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.textBoxDzielnik);
            this.Controls.Add(this.textBoxDzielna);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDzielna; //dividend
        private System.Windows.Forms.TextBox textBoxDzielnik;//divisor 
        private System.Windows.Forms.TextBox textBoxWynik;//quotient 
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

