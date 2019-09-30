namespace trabalhoFelipe
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
            this.btnImagem1 = new System.Windows.Forms.Button();
            this.btnImagem2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnImagem1
            // 
            this.btnImagem1.BackColor = System.Drawing.Color.Transparent;
            this.btnImagem1.BackgroundImage = global::trabalhoFelipe.Properties.Resources.xratao;
            this.btnImagem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImagem1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImagem1.Location = new System.Drawing.Point(13, 13);
            this.btnImagem1.Name = "btnImagem1";
            this.btnImagem1.Size = new System.Drawing.Size(300, 300);
            this.btnImagem1.TabIndex = 0;
            this.btnImagem1.Text = "btnImg1";
            this.btnImagem1.UseVisualStyleBackColor = false;
            this.btnImagem1.Click += new System.EventHandler(this.btnImagem1_Click);
            // 
            // btnImagem2
            // 
            this.btnImagem2.AutoEllipsis = true;
            this.btnImagem2.AutoSize = true;
            this.btnImagem2.BackColor = System.Drawing.Color.Transparent;
            this.btnImagem2.BackgroundImage = global::trabalhoFelipe.Properties.Resources.xratao;
            this.btnImagem2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImagem2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImagem2.Location = new System.Drawing.Point(319, 12);
            this.btnImagem2.Name = "btnImagem2";
            this.btnImagem2.Size = new System.Drawing.Size(300, 300);
            this.btnImagem2.TabIndex = 1;
            this.btnImagem2.Text = "btnImg2";
            this.btnImagem2.UseVisualStyleBackColor = false;
            this.btnImagem2.Click += new System.EventHandler(this.btnImagem2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 326);
            this.Controls.Add(this.btnImagem2);
            this.Controls.Add(this.btnImagem1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImagem1;
        private System.Windows.Forms.Button btnImagem2;
    }
}

