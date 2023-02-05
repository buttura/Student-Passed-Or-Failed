namespace AlunoAprovadoOuReprovado
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
            this.Nota1 = new System.Windows.Forms.RichTextBox();
            this.Nota2 = new System.Windows.Forms.RichTextBox();
            this.Nota3 = new System.Windows.Forms.RichTextBox();
            this.CalcularMedia = new System.Windows.Forms.Button();
            this.lblMedia = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Nota1
            // 
            this.Nota1.Location = new System.Drawing.Point(33, 12);
            this.Nota1.Name = "Nota1";
            this.Nota1.Size = new System.Drawing.Size(373, 70);
            this.Nota1.TabIndex = 0;
            this.Nota1.Text = "";
            // 
            // Nota2
            // 
            this.Nota2.Location = new System.Drawing.Point(33, 99);
            this.Nota2.Name = "Nota2";
            this.Nota2.Size = new System.Drawing.Size(373, 64);
            this.Nota2.TabIndex = 1;
            this.Nota2.Text = "";
            // 
            // Nota3
            // 
            this.Nota3.Location = new System.Drawing.Point(33, 179);
            this.Nota3.Name = "Nota3";
            this.Nota3.Size = new System.Drawing.Size(373, 64);
            this.Nota3.TabIndex = 2;
            this.Nota3.Text = "";
            // 
            // CalcularMedia
            // 
            this.CalcularMedia.Location = new System.Drawing.Point(33, 258);
            this.CalcularMedia.Name = "CalcularMedia";
            this.CalcularMedia.Size = new System.Drawing.Size(373, 70);
            this.CalcularMedia.TabIndex = 3;
            this.CalcularMedia.Text = "Calcular Media";
            this.CalcularMedia.UseVisualStyleBackColor = true;
            this.CalcularMedia.Click += new System.EventHandler(this.CalcularMedia_Click);
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Cursor = System.Windows.Forms.Cursors.Cross;
            this.lblMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedia.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblMedia.Location = new System.Drawing.Point(20, 331);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(158, 73);
            this.lblMedia.TabIndex = 4;
            this.lblMedia.Text = "0.00";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSituacao.ForeColor = System.Drawing.Color.Red;
            this.lblSituacao.Location = new System.Drawing.Point(23, 467);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(0, 59);
            this.lblSituacao.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 575);
            this.Controls.Add(this.lblSituacao);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.CalcularMedia);
            this.Controls.Add(this.Nota3);
            this.Controls.Add(this.Nota2);
            this.Controls.Add(this.Nota1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Nota1;
        private System.Windows.Forms.RichTextBox Nota2;
        private System.Windows.Forms.RichTextBox Nota3;
        private System.Windows.Forms.Button CalcularMedia;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label lblSituacao;
    }
}

