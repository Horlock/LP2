namespace atividade4
{
    partial class calculoINSS
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSalarioBruto = new System.Windows.Forms.Label();
            this.lblFilhos = new System.Windows.Forms.Label();
            this.btnVerifica = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAliquotaINSS = new System.Windows.Forms.Label();
            this.lblAliquotaIRPF = new System.Windows.Forms.Label();
            this.lblSalarioFamilia = new System.Windows.Forms.Label();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.groupSexo = new System.Windows.Forms.GroupBox();
            this.radioM = new System.Windows.Forms.RadioButton();
            this.radioF = new System.Windows.Forms.RadioButton();
            this.checkCasado = new System.Windows.Forms.CheckBox();
            this.txtAliquotaINSS = new System.Windows.Forms.TextBox();
            this.txtAliquotaIRPF = new System.Windows.Forms.TextBox();
            this.txtSalarioFamilia = new System.Windows.Forms.TextBox();
            this.txtSalarioLiquido = new System.Windows.Forms.TextBox();
            this.txtDescontoIRPF = new System.Windows.Forms.TextBox();
            this.txtDescontoINSS = new System.Windows.Forms.TextBox();
            this.lblDescontoIRPF = new System.Windows.Forms.Label();
            this.lblDescontoINSS = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtFilhos = new System.Windows.Forms.MaskedTextBox();
            this.txtSalarioBruto = new System.Windows.Forms.MaskedTextBox();
            this.groupSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(34, 31);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(123, 17);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome funcionário:";
            // 
            // lblSalarioBruto
            // 
            this.lblSalarioBruto.AutoSize = true;
            this.lblSalarioBruto.Location = new System.Drawing.Point(34, 78);
            this.lblSalarioBruto.Name = "lblSalarioBruto";
            this.lblSalarioBruto.Size = new System.Drawing.Size(93, 17);
            this.lblSalarioBruto.TabIndex = 1;
            this.lblSalarioBruto.Text = "Salário bruto:";
            // 
            // lblFilhos
            // 
            this.lblFilhos.AutoSize = true;
            this.lblFilhos.Location = new System.Drawing.Point(34, 123);
            this.lblFilhos.Name = "lblFilhos";
            this.lblFilhos.Size = new System.Drawing.Size(119, 17);
            this.lblFilhos.TabIndex = 2;
            this.lblFilhos.Text = "Número de filhos:";
            // 
            // btnVerifica
            // 
            this.btnVerifica.Location = new System.Drawing.Point(164, 159);
            this.btnVerifica.Name = "btnVerifica";
            this.btnVerifica.Size = new System.Drawing.Size(172, 31);
            this.btnVerifica.TabIndex = 3;
            this.btnVerifica.Text = "Verifica Desconto";
            this.btnVerifica.UseVisualStyleBackColor = true;
            this.btnVerifica.Click += new System.EventHandler(this.btnVerifica_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dados";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblAliquotaINSS
            // 
            this.lblAliquotaINSS.AutoSize = true;
            this.lblAliquotaINSS.Location = new System.Drawing.Point(34, 248);
            this.lblAliquotaINSS.Name = "lblAliquotaINSS";
            this.lblAliquotaINSS.Size = new System.Drawing.Size(98, 17);
            this.lblAliquotaINSS.TabIndex = 5;
            this.lblAliquotaINSS.Text = "Alíquota INSS:";
            // 
            // lblAliquotaIRPF
            // 
            this.lblAliquotaIRPF.AutoSize = true;
            this.lblAliquotaIRPF.Location = new System.Drawing.Point(34, 283);
            this.lblAliquotaIRPF.Name = "lblAliquotaIRPF";
            this.lblAliquotaIRPF.Size = new System.Drawing.Size(97, 17);
            this.lblAliquotaIRPF.TabIndex = 6;
            this.lblAliquotaIRPF.Text = "Alíquota IRPF:";
            // 
            // lblSalarioFamilia
            // 
            this.lblSalarioFamilia.AutoSize = true;
            this.lblSalarioFamilia.Location = new System.Drawing.Point(34, 321);
            this.lblSalarioFamilia.Name = "lblSalarioFamilia";
            this.lblSalarioFamilia.Size = new System.Drawing.Size(104, 17);
            this.lblSalarioFamilia.TabIndex = 7;
            this.lblSalarioFamilia.Text = "Salário Família:";
            this.lblSalarioFamilia.Click += new System.EventHandler(this.lblSalarioFamilia_Click);
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.AutoSize = true;
            this.lblSalarioLiquido.Location = new System.Drawing.Point(34, 357);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(106, 17);
            this.lblSalarioLiquido.TabIndex = 8;
            this.lblSalarioLiquido.Text = "Salário Líquido:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(164, 31);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(171, 22);
            this.txtNome.TabIndex = 9;
            // 
            // groupSexo
            // 
            this.groupSexo.Controls.Add(this.radioM);
            this.groupSexo.Controls.Add(this.radioF);
            this.groupSexo.Location = new System.Drawing.Point(450, 31);
            this.groupSexo.Name = "groupSexo";
            this.groupSexo.Size = new System.Drawing.Size(200, 80);
            this.groupSexo.TabIndex = 12;
            this.groupSexo.TabStop = false;
            this.groupSexo.Text = "Sexo";
            // 
            // radioM
            // 
            this.radioM.AutoSize = true;
            this.radioM.Location = new System.Drawing.Point(7, 49);
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
            this.radioF.Location = new System.Drawing.Point(7, 22);
            this.radioF.Name = "radioF";
            this.radioF.Size = new System.Drawing.Size(86, 21);
            this.radioF.TabIndex = 0;
            this.radioF.TabStop = true;
            this.radioF.Text = "Feminino";
            this.radioF.UseVisualStyleBackColor = true;
            // 
            // checkCasado
            // 
            this.checkCasado.AutoSize = true;
            this.checkCasado.Location = new System.Drawing.Point(457, 117);
            this.checkCasado.Name = "checkCasado";
            this.checkCasado.Size = new System.Drawing.Size(78, 21);
            this.checkCasado.TabIndex = 13;
            this.checkCasado.Text = "Casado";
            this.checkCasado.UseVisualStyleBackColor = true;
            // 
            // txtAliquotaINSS
            // 
            this.txtAliquotaINSS.Location = new System.Drawing.Point(164, 243);
            this.txtAliquotaINSS.Name = "txtAliquotaINSS";
            this.txtAliquotaINSS.Size = new System.Drawing.Size(171, 22);
            this.txtAliquotaINSS.TabIndex = 14;
            // 
            // txtAliquotaIRPF
            // 
            this.txtAliquotaIRPF.Location = new System.Drawing.Point(164, 280);
            this.txtAliquotaIRPF.Name = "txtAliquotaIRPF";
            this.txtAliquotaIRPF.Size = new System.Drawing.Size(171, 22);
            this.txtAliquotaIRPF.TabIndex = 15;
            // 
            // txtSalarioFamilia
            // 
            this.txtSalarioFamilia.Location = new System.Drawing.Point(164, 316);
            this.txtSalarioFamilia.Name = "txtSalarioFamilia";
            this.txtSalarioFamilia.Size = new System.Drawing.Size(171, 22);
            this.txtSalarioFamilia.TabIndex = 16;
            // 
            // txtSalarioLiquido
            // 
            this.txtSalarioLiquido.Location = new System.Drawing.Point(164, 352);
            this.txtSalarioLiquido.Name = "txtSalarioLiquido";
            this.txtSalarioLiquido.Size = new System.Drawing.Size(171, 22);
            this.txtSalarioLiquido.TabIndex = 17;
            // 
            // txtDescontoIRPF
            // 
            this.txtDescontoIRPF.Location = new System.Drawing.Point(577, 275);
            this.txtDescontoIRPF.Name = "txtDescontoIRPF";
            this.txtDescontoIRPF.Size = new System.Drawing.Size(171, 22);
            this.txtDescontoIRPF.TabIndex = 21;
            // 
            // txtDescontoINSS
            // 
            this.txtDescontoINSS.Location = new System.Drawing.Point(577, 238);
            this.txtDescontoINSS.Name = "txtDescontoINSS";
            this.txtDescontoINSS.Size = new System.Drawing.Size(171, 22);
            this.txtDescontoINSS.TabIndex = 20;
            // 
            // lblDescontoIRPF
            // 
            this.lblDescontoIRPF.AutoSize = true;
            this.lblDescontoIRPF.Location = new System.Drawing.Point(447, 278);
            this.lblDescontoIRPF.Name = "lblDescontoIRPF";
            this.lblDescontoIRPF.Size = new System.Drawing.Size(106, 17);
            this.lblDescontoIRPF.TabIndex = 19;
            this.lblDescontoIRPF.Text = "Desconto IRPF:";
            // 
            // lblDescontoINSS
            // 
            this.lblDescontoINSS.AutoSize = true;
            this.lblDescontoINSS.Location = new System.Drawing.Point(447, 243);
            this.lblDescontoINSS.Name = "lblDescontoINSS";
            this.lblDescontoINSS.Size = new System.Drawing.Size(107, 17);
            this.lblDescontoINSS.TabIndex = 18;
            this.lblDescontoINSS.Text = "Desconto INSS:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(319, 392);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(171, 46);
            this.btnLimpar.TabIndex = 22;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtFilhos
            // 
            this.txtFilhos.Location = new System.Drawing.Point(165, 117);
            this.txtFilhos.Mask = "00";
            this.txtFilhos.Name = "txtFilhos";
            this.txtFilhos.Size = new System.Drawing.Size(170, 22);
            this.txtFilhos.TabIndex = 24;
            this.txtFilhos.ValidatingType = typeof(int);
            // 
            // txtSalarioBruto
            // 
            this.txtSalarioBruto.Location = new System.Drawing.Point(165, 78);
            this.txtSalarioBruto.Mask = "000000,00";
            this.txtSalarioBruto.Name = "txtSalarioBruto";
            this.txtSalarioBruto.Size = new System.Drawing.Size(170, 22);
            this.txtSalarioBruto.TabIndex = 25;
            // 
            // calculoINSS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 450);
            this.Controls.Add(this.txtSalarioBruto);
            this.Controls.Add(this.txtFilhos);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtDescontoIRPF);
            this.Controls.Add(this.txtDescontoINSS);
            this.Controls.Add(this.lblDescontoIRPF);
            this.Controls.Add(this.lblDescontoINSS);
            this.Controls.Add(this.txtSalarioLiquido);
            this.Controls.Add(this.txtSalarioFamilia);
            this.Controls.Add(this.txtAliquotaIRPF);
            this.Controls.Add(this.txtAliquotaINSS);
            this.Controls.Add(this.checkCasado);
            this.Controls.Add(this.groupSexo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblSalarioLiquido);
            this.Controls.Add(this.lblSalarioFamilia);
            this.Controls.Add(this.lblAliquotaIRPF);
            this.Controls.Add(this.lblAliquotaINSS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVerifica);
            this.Controls.Add(this.lblFilhos);
            this.Controls.Add(this.lblSalarioBruto);
            this.Controls.Add(this.lblNome);
            this.Name = "calculoINSS";
            this.Text = "Calcular INSS e IRPF";
            this.Load += new System.EventHandler(this.calculoINSS_Load);
            this.groupSexo.ResumeLayout(false);
            this.groupSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSalarioBruto;
        private System.Windows.Forms.Label lblFilhos;
        private System.Windows.Forms.Button btnVerifica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAliquotaINSS;
        private System.Windows.Forms.Label lblAliquotaIRPF;
        private System.Windows.Forms.Label lblSalarioFamilia;
        private System.Windows.Forms.Label lblSalarioLiquido;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox groupSexo;
        private System.Windows.Forms.RadioButton radioM;
        private System.Windows.Forms.RadioButton radioF;
        private System.Windows.Forms.CheckBox checkCasado;
        private System.Windows.Forms.TextBox txtAliquotaINSS;
        private System.Windows.Forms.TextBox txtAliquotaIRPF;
        private System.Windows.Forms.TextBox txtSalarioFamilia;
        private System.Windows.Forms.TextBox txtSalarioLiquido;
        private System.Windows.Forms.TextBox txtDescontoIRPF;
        private System.Windows.Forms.TextBox txtDescontoINSS;
        private System.Windows.Forms.Label lblDescontoIRPF;
        private System.Windows.Forms.Label lblDescontoINSS;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.MaskedTextBox txtFilhos;
        private System.Windows.Forms.MaskedTextBox txtSalarioBruto;
    }
}

