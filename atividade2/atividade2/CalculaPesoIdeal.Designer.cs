namespace atividade2
{
    partial class CalculaPesoIdeal
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
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblPesoAtual = new System.Windows.Forms.Label();
            this.groupGenero = new System.Windows.Forms.GroupBox();
            this.radioM = new System.Windows.Forms.RadioButton();
            this.radioF = new System.Windows.Forms.RadioButton();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.groupGenero.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(27, 39);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(45, 17);
            this.lblAltura.TabIndex = 0;
            this.lblAltura.Text = "Altura";
            this.lblAltura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPesoAtual
            // 
            this.lblPesoAtual.AutoSize = true;
            this.lblPesoAtual.Location = new System.Drawing.Point(27, 85);
            this.lblPesoAtual.Name = "lblPesoAtual";
            this.lblPesoAtual.Size = new System.Drawing.Size(76, 17);
            this.lblPesoAtual.TabIndex = 1;
            this.lblPesoAtual.Text = "Peso Atual";
            // 
            // groupGenero
            // 
            this.groupGenero.Controls.Add(this.radioM);
            this.groupGenero.Controls.Add(this.radioF);
            this.groupGenero.Location = new System.Drawing.Point(290, 39);
            this.groupGenero.Name = "groupGenero";
            this.groupGenero.Size = new System.Drawing.Size(200, 100);
            this.groupGenero.TabIndex = 2;
            this.groupGenero.TabStop = false;
            this.groupGenero.Text = "Genero";
            // 
            // radioM
            // 
            this.radioM.AutoSize = true;
            this.radioM.Location = new System.Drawing.Point(19, 60);
            this.radioM.Name = "radioM";
            this.radioM.Size = new System.Drawing.Size(92, 21);
            this.radioM.TabIndex = 1;
            this.radioM.TabStop = true;
            this.radioM.Text = "Masculino";
            this.radioM.UseVisualStyleBackColor = true;
            // 
            // radioF
            // 
            this.radioF.AutoSize = true;
            this.radioF.Location = new System.Drawing.Point(19, 32);
            this.radioF.Name = "radioF";
            this.radioF.Size = new System.Drawing.Size(86, 21);
            this.radioF.TabIndex = 0;
            this.radioF.TabStop = true;
            this.radioF.Text = "Feminino";
            this.radioF.UseVisualStyleBackColor = true;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(109, 36);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 22);
            this.txtAltura.TabIndex = 3;
            this.txtAltura.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(109, 80);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 22);
            this.txtPeso.TabIndex = 4;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(125, 180);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(119, 48);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(250, 180);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(119, 48);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // CalculaPesoIdeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 248);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.groupGenero);
            this.Controls.Add(this.lblPesoAtual);
            this.Controls.Add(this.lblAltura);
            this.Name = "CalculaPesoIdeal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcular Peso Ideal";
            this.groupGenero.ResumeLayout(false);
            this.groupGenero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblPesoAtual;
        private System.Windows.Forms.GroupBox groupGenero;
        private System.Windows.Forms.RadioButton radioM;
        private System.Windows.Forms.RadioButton radioF;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
    }
}

