namespace Atividade_6
{
    partial class Exercicio4
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
            this.button1 = new System.Windows.Forms.Button();
            this.boxSalario = new System.Windows.Forms.TextBox();
            this.boxGratif = new System.Windows.Forms.TextBox();
            this.boxProd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 248);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 73);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calcular Salário Bruto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // boxSalario
            // 
            this.boxSalario.Location = new System.Drawing.Point(147, 87);
            this.boxSalario.Margin = new System.Windows.Forms.Padding(4);
            this.boxSalario.Name = "boxSalario";
            this.boxSalario.Size = new System.Drawing.Size(132, 22);
            this.boxSalario.TabIndex = 1;
            // 
            // boxGratif
            // 
            this.boxGratif.Location = new System.Drawing.Point(147, 167);
            this.boxGratif.Margin = new System.Windows.Forms.Padding(4);
            this.boxGratif.Name = "boxGratif";
            this.boxGratif.Size = new System.Drawing.Size(132, 22);
            this.boxGratif.TabIndex = 2;
            // 
            // boxProd
            // 
            this.boxProd.Location = new System.Drawing.Point(147, 129);
            this.boxProd.Margin = new System.Windows.Forms.Padding(4);
            this.boxProd.Name = "boxProd";
            this.boxProd.Size = new System.Drawing.Size(132, 22);
            this.boxProd.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Salario Base";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Produção";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Gratificação";
            // 
            // Exercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 335);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxProd);
            this.Controls.Add(this.boxGratif);
            this.Controls.Add(this.boxSalario);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Exercicio4";
            this.Text = "Exercicio 4";
            this.Load += new System.EventHandler(this.Exercicio4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox boxSalario;
        private System.Windows.Forms.TextBox boxGratif;
        private System.Windows.Forms.TextBox boxProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}