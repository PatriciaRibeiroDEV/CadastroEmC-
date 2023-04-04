using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using MySql.Data.MySqlClient;

namespace Projeto_Integrado_III
{
    public partial class Form3 : Form
    {
MySqlConnection conexao;
        

        public Form3()
        {
            InitializeComponent();
        }

        private void BtnConvConf_Click(object sender, EventArgs e)
        {
            DialogResult Confirma;
            Confirma = MessageBox.Show("Deseja confirma os dados?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
          
            if (Confirma.Equals(DialogResult.No))
            {

            }
            else
            {
                try
                {
                    string data_source = "datasource=localhost;username=root;password=;database=Projetoint";

                    // Criar conexão
                    conexao = new MySqlConnection(data_source);

                    string sql = "INSERT INTO TbAluno (Nome, Curso, Idade, Email, Telefone, Sexo) VALUES " + "('" + TxtNomeAluno.Text + "', '" + TxtCursoAluno.Text +"', '" + TxtIdadeAluno.Text +"', '" + TxtEmailAluno.Text +"', '" + TxtFoneAluno.Text +"', '" + CboxSexoAluno.Text +"')";
                    MySqlCommand comando = new MySqlCommand(sql, conexao);
                    conexao.Open();

                    comando.ExecuteReader();

                }
                catch (Exception)
                {
                    MessageBox.Show("Tente Again");
                }



                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();

            }
        }

        private void TxtEmailAluno_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtFoneAluno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
