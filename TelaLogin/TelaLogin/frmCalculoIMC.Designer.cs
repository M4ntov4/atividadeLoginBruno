
namespace TelaLogin
{
    partial class frmCalculoIMC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lbIMC = new System.Windows.Forms.Label();
            this.lbClassificacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPeso
            // 
            this.txtPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.Location = new System.Drawing.Point(133, 21);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 41);
            this.txtPeso.TabIndex = 0;
            // 
            // txtAltura
            // 
            this.txtAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltura.Location = new System.Drawing.Point(133, 99);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 41);
            this.txtAltura.TabIndex = 1;
            this.txtAltura.TextChanged += new System.EventHandler(this.txtAltura_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Peso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Altura";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(457, 328);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(193, 50);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lbIMC
            // 
            this.lbIMC.AutoSize = true;
            this.lbIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIMC.Location = new System.Drawing.Point(146, 176);
            this.lbIMC.Name = "lbIMC";
            this.lbIMC.Size = new System.Drawing.Size(69, 36);
            this.lbIMC.TabIndex = 5;
            this.lbIMC.Text = "IMC";
            // 
            // lbClassificacao
            // 
            this.lbClassificacao.AutoSize = true;
            this.lbClassificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClassificacao.Location = new System.Drawing.Point(94, 238);
            this.lbClassificacao.Name = "lbClassificacao";
            this.lbClassificacao.Size = new System.Drawing.Size(190, 36);
            this.lbClassificacao.TabIndex = 6;
            this.lbClassificacao.Text = "Classificação";
            // 
            // frmCalculoIMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 400);
            this.Controls.Add(this.lbClassificacao);
            this.Controls.Add(this.lbIMC);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtPeso);
            this.Name = "frmCalculoIMC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema para Cálculo do IMC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lbIMC;
        private System.Windows.Forms.Label lbClassificacao;
    }
}