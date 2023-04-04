namespace Projeto_Integrado_III
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
            this.BtnVisitante = new System.Windows.Forms.Button();
            this.BtnAluno = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnVisitante
            // 
            this.BtnVisitante.Location = new System.Drawing.Point(721, 211);
            this.BtnVisitante.Name = "BtnVisitante";
            this.BtnVisitante.Size = new System.Drawing.Size(53, 47);
            this.BtnVisitante.TabIndex = 0;
            this.BtnVisitante.Text = "Convidado";
            this.BtnVisitante.UseVisualStyleBackColor = true;
            this.BtnVisitante.Click += new System.EventHandler(this.BtnVisitante_Click);
            // 
            // BtnAluno
            // 
            this.BtnAluno.Location = new System.Drawing.Point(12, 211);
            this.BtnAluno.Name = "BtnAluno";
            this.BtnAluno.Size = new System.Drawing.Size(59, 47);
            this.BtnAluno.TabIndex = 1;
            this.BtnAluno.Text = "Aluno";
            this.BtnAluno.UseVisualStyleBackColor = true;
            this.BtnAluno.Click += new System.EventHandler(this.BtnAluno_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::Projeto_Integrado_III.Properties.Resources.WhatsApp_Image_2022_10_15_at_1_24_32_PM;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(840, 477);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 474);
            this.Controls.Add(this.BtnAluno);
            this.Controls.Add(this.BtnVisitante);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnVisitante;
        private System.Windows.Forms.Button BtnAluno;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

