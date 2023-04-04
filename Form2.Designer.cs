namespace Projeto_Integrado_III
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.CboxSexoConv = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNomeConv = new System.Windows.Forms.TextBox();
            this.TxtEmailConv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtIdadeConv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtFoneConv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnAlunoConf = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(490, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sexo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CboxSexoConv
            // 
            this.CboxSexoConv.FormattingEnabled = true;
            this.CboxSexoConv.Items.AddRange(new object[] {
            "Feminino",
            "Masculino",
            "Outro"});
            this.CboxSexoConv.Location = new System.Drawing.Point(487, 194);
            this.CboxSexoConv.Name = "CboxSexoConv";
            this.CboxSexoConv.Size = new System.Drawing.Size(96, 21);
            this.CboxSexoConv.TabIndex = 2;
            this.CboxSexoConv.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TxtNomeConv
            // 
            this.TxtNomeConv.Location = new System.Drawing.Point(209, 194);
            this.TxtNomeConv.Name = "TxtNomeConv";
            this.TxtNomeConv.Size = new System.Drawing.Size(210, 20);
            this.TxtNomeConv.TabIndex = 4;
            // 
            // TxtEmailConv
            // 
            this.TxtEmailConv.Location = new System.Drawing.Point(209, 247);
            this.TxtEmailConv.Name = "TxtEmailConv";
            this.TxtEmailConv.Size = new System.Drawing.Size(210, 20);
            this.TxtEmailConv.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "E-mail";
            // 
            // TxtIdadeConv
            // 
            this.TxtIdadeConv.Location = new System.Drawing.Point(487, 247);
            this.TxtIdadeConv.Name = "TxtIdadeConv";
            this.TxtIdadeConv.Size = new System.Drawing.Size(99, 20);
            this.TxtIdadeConv.TabIndex = 10;
            this.TxtIdadeConv.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(489, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Idade";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // TxtFoneConv
            // 
            this.TxtFoneConv.Location = new System.Drawing.Point(487, 300);
            this.TxtFoneConv.Name = "TxtFoneConv";
            this.TxtFoneConv.Size = new System.Drawing.Size(158, 20);
            this.TxtFoneConv.TabIndex = 12;
            this.TxtFoneConv.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(490, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Telefone";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // BtnAlunoConf
            // 
            this.BtnAlunoConf.Location = new System.Drawing.Point(380, 404);
            this.BtnAlunoConf.Name = "BtnAlunoConf";
            this.BtnAlunoConf.Size = new System.Drawing.Size(129, 53);
            this.BtnAlunoConf.TabIndex = 13;
            this.BtnAlunoConf.Text = "Confirma";
            this.BtnAlunoConf.UseVisualStyleBackColor = true;
            this.BtnAlunoConf.Click += new System.EventHandler(this.BtnAlunoConf_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::Projeto_Integrado_III.Properties.Resources.WhatsApp_Image_2022_10_16_at_7_33_38_AM;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(858, 488);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 479);
            this.Controls.Add(this.BtnAlunoConf);
            this.Controls.Add(this.TxtFoneConv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtIdadeConv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtEmailConv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtNomeConv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CboxSexoConv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboxSexoConv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNomeConv;
        private System.Windows.Forms.TextBox TxtEmailConv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtIdadeConv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtFoneConv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnAlunoConf;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}