using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Integrado_III
{
    public partial class Form2 : Form
    {

        MySqlConnection conexao;

        public Form2()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnAlunoConf_Click(object sender, EventArgs e)
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

                    string sql = "INSERT INTO TbConvidado (Nome, Idade, Email, Telefone, Sexo) VALUES " + "('" + TxtNomeConv.Text + "', '" + TxtIdadeConv.Text + "', '" + TxtEmailConv.Text + "', '" + TxtFoneConv.Text + "', '" + CboxSexoConv.Text + "')";
                    MySqlCommand comando = new MySqlCommand(sql, conexao);
                    conexao.Open();

                    comando.ExecuteReader();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }



                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();

            }
        }
    }
}
