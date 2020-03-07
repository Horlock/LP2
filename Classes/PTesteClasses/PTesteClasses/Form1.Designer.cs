namespace PTesteClasses
{
    partial class Form1
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
            this.mensalita = new System.Windows.Forms.Button();
            this.horista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mensalita
            // 
            this.mensalita.Location = new System.Drawing.Point(12, 12);
            this.mensalita.Name = "mensalita";
            this.mensalita.Size = new System.Drawing.Size(148, 67);
            this.mensalita.TabIndex = 0;
            this.mensalita.Text = "Mensalita";
            this.mensalita.UseVisualStyleBackColor = true;
            this.mensalita.Click += new System.EventHandler(this.mensalita_Click);
            // 
            // horista
            // 
            this.horista.Location = new System.Drawing.Point(12, 85);
            this.horista.Name = "horista";
            this.horista.Size = new System.Drawing.Size(148, 67);
            this.horista.TabIndex = 1;
            this.horista.Text = "Horista";
            this.horista.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.horista);
            this.Controls.Add(this.mensalita);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mensalita;
        private System.Windows.Forms.Button horista;
    }
}

