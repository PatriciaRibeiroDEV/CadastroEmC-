namespace Projeto_Integrado_III
{
    partial class Form3
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
            this.TxtFoneAluno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtIdadeAluno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtEmailAluno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNomeAluno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CboxSexoAluno = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCursoAluno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnConvConf = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtFoneAluno
            // 
            this.TxtFoneAluno.Location = new System.Drawing.Point(490, 283);
            this.TxtFoneAluno.Name = "TxtFoneAluno";
            this.TxtFoneAluno.Size = new System.Drawing.Size(189, 20);
            this.TxtFoneAluno.TabIndex = 22;
            this.TxtFoneAluno.TextChanged += new System.EventHandler(this.TxtFoneAluno_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(492, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Telefone";
            // 
            // TxtIdadeAluno
            // 
            this.TxtIdadeAluno.Location = new System.Drawing.Point(490, 228);
            this.TxtIdadeAluno.Name = "TxtIdadeAluno";
            this.TxtIdadeAluno.Size = new System.Drawing.Size(82, 20);
            this.TxtIdadeAluno.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(492, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Idade";
            // 
            // TxtEmailAluno
            // 
            this.TxtEmailAluno.Location = new System.Drawing.Point(218, 223);
            this.TxtEmailAluno.Name = "TxtEmailAluno";
            this.TxtEmailAluno.Size = new System.Drawing.Size(241, 20);
            this.TxtEmailAluno.TabIndex = 18;
            this.TxtEmailAluno.TextChanged += new System.EventHandler(this.TxtEmailAluno_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "E-mail";
            // 
            // TxtNomeAluno
            // 
            this.TxtNomeAluno.Location = new System.Drawing.Point(218, 176);
            this.TxtNomeAluno.Name = "TxtNomeAluno";
            this.TxtNomeAluno.Size = new System.Drawing.Size(244, 20);
            this.TxtNomeAluno.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nome";
            // 
            // CboxSexoAluno
            // 
            this.CboxSexoAluno.FormattingEnabled = true;
            this.CboxSexoAluno.Items.AddRange(new object[] {
            "Feminino",
            "Masculino",
            "Outro"});
            this.CboxSexoAluno.Location = new System.Drawing.Point(490, 175);
            this.CboxSexoAluno.Name = "CboxSexoAluno";
            this.CboxSexoAluno.Size = new System.Drawing.Size(127, 21);
            this.CboxSexoAluno.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(487, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Sexo";
            // 
            // TxtCursoAluno
            // 
            this.TxtCursoAluno.Location = new System.Drawing.Point(218, 283);
            this.TxtCursoAluno.Name = "TxtCursoAluno";
            this.TxtCursoAluno.Size = new System.Drawing.Size(241, 20);
            this.TxtCursoAluno.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Curso";
            // 
            // BtnConvConf
            // 
            this.BtnConvConf.Location = new System.Drawing.Point(370, 386);
            this.BtnConvConf.Name = "BtnConvConf";
            this.BtnConvConf.Size = new System.Drawing.Size(126, 56);
            this.BtnConvConf.TabIndex = 25;
            this.BtnConvConf.Text = "Confirma";
            this.BtnConvConf.UseVisualStyleBackColor = true;
            this.BtnConvConf.Click += new System.EventHandler(this.BtnConvConf_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::Projeto_Integrado_III.Properties.Resources.WhatsApp_Image_2022_10_16_at_7_33_38_AM__1_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(837, 471);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 471);
            this.Controls.Add(this.BtnConvConf);
            this.Controls.Add(this.TxtCursoAluno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtFoneAluno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtIdadeAluno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtEmailAluno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtNomeAluno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CboxSexoAluno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtFoneAluno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtIdadeAluno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtEmailAluno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNomeAluno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CboxSexoAluno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCursoAluno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnConvConf;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}