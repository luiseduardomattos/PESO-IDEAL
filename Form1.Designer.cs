namespace PESO_IDEAL
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxSexo = new System.Windows.Forms.TextBox();
            this.txtBoxPeso = new System.Windows.Forms.TextBox();
            this.btnCalculo = new System.Windows.Forms.Button();
            this.txtBoxResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DIGITE SEU SEXO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DIGITE SEU PESO:";
            // 
            // txtBoxSexo
            // 
            this.txtBoxSexo.Location = new System.Drawing.Point(145, 36);
            this.txtBoxSexo.Name = "txtBoxSexo";
            this.txtBoxSexo.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSexo.TabIndex = 2;
            // 
            // txtBoxPeso
            // 
            this.txtBoxPeso.Location = new System.Drawing.Point(145, 69);
            this.txtBoxPeso.Name = "txtBoxPeso";
            this.txtBoxPeso.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPeso.TabIndex = 3;
            // 
            // btnCalculo
            // 
            this.btnCalculo.Location = new System.Drawing.Point(37, 114);
            this.btnCalculo.Name = "btnCalculo";
            this.btnCalculo.Size = new System.Drawing.Size(75, 23);
            this.btnCalculo.TabIndex = 4;
            this.btnCalculo.Text = "CÁLCULO";
            this.btnCalculo.UseVisualStyleBackColor = true;
            // 
            // txtBoxResultado
            // 
            this.txtBoxResultado.Location = new System.Drawing.Point(145, 116);
            this.txtBoxResultado.Name = "txtBoxResultado";
            this.txtBoxResultado.Size = new System.Drawing.Size(100, 20);
            this.txtBoxResultado.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxResultado);
            this.Controls.Add(this.btnCalculo);
            this.Controls.Add(this.txtBoxPeso);
            this.Controls.Add(this.txtBoxSexo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxSexo;
        private System.Windows.Forms.TextBox txtBoxPeso;
        private System.Windows.Forms.Button btnCalculo;
        private System.Windows.Forms.TextBox txtBoxResultado;
    }
}

