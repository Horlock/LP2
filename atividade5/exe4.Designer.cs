namespace PMenus
{
    partial class exe4
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
            this.rchtxtTexto = new System.Windows.Forms.RichTextBox();
            this.btnCaractNum = new System.Windows.Forms.Button();
            this.btnPrimEspaco = new System.Windows.Forms.Button();
            this.btnCaractAlfab = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchtxtTexto
            // 
            this.rchtxtTexto.Location = new System.Drawing.Point(79, 88);
            this.rchtxtTexto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rchtxtTexto.Name = "rchtxtTexto";
            this.rchtxtTexto.Size = new System.Drawing.Size(568, 173);
            this.rchtxtTexto.TabIndex = 0;
            this.rchtxtTexto.Text = "";
            // 
            // btnCaractNum
            // 
            this.btnCaractNum.Location = new System.Drawing.Point(79, 314);
            this.btnCaractNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCaractNum.Name = "btnCaractNum";
            this.btnCaractNum.Size = new System.Drawing.Size(184, 60);
            this.btnCaractNum.TabIndex = 1;
            this.btnCaractNum.Text = "Quantidade de caracteres númericos";
            this.btnCaractNum.UseVisualStyleBackColor = true;
            this.btnCaractNum.Click += new System.EventHandler(this.btnCaractNum_Click);
            // 
            // btnPrimEspaco
            // 
            this.btnPrimEspaco.Location = new System.Drawing.Point(271, 314);
            this.btnPrimEspaco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrimEspaco.Name = "btnPrimEspaco";
            this.btnPrimEspaco.Size = new System.Drawing.Size(184, 60);
            this.btnPrimEspaco.TabIndex = 2;
            this.btnPrimEspaco.Text = "Posição do primeiro espaço";
            this.btnPrimEspaco.UseVisualStyleBackColor = true;
            this.btnPrimEspaco.Click += new System.EventHandler(this.btnPrimBranco_Click);
            // 
            // btnCaractAlfab
            // 
            this.btnCaractAlfab.Location = new System.Drawing.Point(463, 314);
            this.btnCaractAlfab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCaractAlfab.Name = "btnCaractAlfab";
            this.btnCaractAlfab.Size = new System.Drawing.Size(184, 60);
            this.btnCaractAlfab.TabIndex = 3;
            this.btnCaractAlfab.Text = "Quantidade de caracteres Alfabeticos";
            this.btnCaractAlfab.UseVisualStyleBackColor = true;
            this.btnCaractAlfab.Click += new System.EventHandler(this.btnCaractAlfab_Click);
            // 
            // exe4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 464);
            this.Controls.Add(this.btnCaractAlfab);
            this.Controls.Add(this.btnPrimEspaco);
            this.Controls.Add(this.btnCaractNum);
            this.Controls.Add(this.rchtxtTexto);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "exe4";
            this.Text = "Exe4";
            this.Load += new System.EventHandler(this.exe4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtTexto;
        private System.Windows.Forms.Button btnCaractNum;
        private System.Windows.Forms.Button btnPrimEspaco;
        private System.Windows.Forms.Button btnCaractAlfab;
    }
}