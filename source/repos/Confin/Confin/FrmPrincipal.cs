using Confin.Controle;
using Confin.Modelo;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Confin
{
    public partial class FrmPrincipal : Form
    {
        NpgsqlConnection conexao = null;

        public FrmPrincipal()
        {
            conexao = Conexao.getConexao();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Conexao.setFechaConexao(conexao);
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            List<Estado> lista = EstadoDB.GetEstados(conexao);
            richTextBox1.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                Estado estado = lista[i];
                richTextBox1.AppendText("Sigla: " + estado.est_sigla);
                richTextBox1.AppendText(" Nome: " + estado.nome);
                richTextBox1.AppendText("\n");
            }
        }

        private void atualizaDados()
        {
            List<Estado> lista = EstadoDB.GetEstados(conexao);
            richTextBox1.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                Estado estado = lista[i];
                richTextBox1.AppendText("Sigla: " + estado.est_sigla);
                richTextBox1.AppendText(" Nome: " + estado.nome);
                richTextBox1.AppendText("\n");
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonIncluir_Click(object sender, EventArgs e)
        {
            Estado estado = new Estado("SP", "São Paulo");
            bool retonro = EstadoDB.SetInsereEstado(estado, conexao);
            if (retonro)
            {
                MessageBox.Show("Estado inserido!");
            }
            else
            {
                MessageBox.Show("Erro ao inserir estado!");
            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            Estado estado = new Estado("SC", "Santa Cataria 2");
            bool retorno = EstadoDB.SetAlteraEstado(estado, conexao);
            if(retorno)
            {
                MessageBox.Show("Estado alterado");
            }
            else
            {
                MessageBox.Show("Erro ao alterar Estado");
            }
        }

        private void buttonExclui_Click(object sender, EventArgs e)
        {
            string sigla = "TO";
            bool retorno = EstadoDB.SetExcluirEstado(sigla, conexao);
            if (retorno)
            {
                MessageBox.Show("Estado excluido");
            }
            else
            {
                MessageBox.Show("Erro ao excluir Estado");
            }
        }

        private void buttonListaCidade_Click(object sender, EventArgs e)
        {
            List<Cidade> lista = CidadeDB.GetCidade(conexao);
            richTextBox2.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                Cidade cidade = lista[i];
                richTextBox2.AppendText("Código: " + cidade.cid_codigo);
                richTextBox2.AppendText(" Nome: " + cidade.nome);
                richTextBox2.AppendText(" Sigla: " + cidade.est_sigla);
                richTextBox2.AppendText("\n");
            }
        }

        private void buttonIncluirCidade_Click(object sender, EventArgs e)
        {
            Cidade cidade = new Cidade(7, "Rio do Sul", "SC");
            bool retonro = CidadeDB.SetInsereCidade(cidade, conexao);
            if (retonro)
            {
                MessageBox.Show("Cidade inserido!");
            }
            else
            {
                MessageBox.Show("Erro ao inserir Cidade!");
            }
        }

        private void buttonAlterarCidade_Click(object sender, EventArgs e)
        {
            Cidade cidade = new Cidade(7, "Alterou OK", "SC");
            bool retorno = CidadeDB.SetAlteraCidade(cidade, conexao);
            if (retorno)
            {
                MessageBox.Show("Cidade alterado");
            }
            else
            {
                MessageBox.Show("Erro ao alterar Cidade");
            }
        }

        private void buttonExcluirCidade_Click(object sender, EventArgs e)
        {
            int iCodigo = 5;
            bool retorno = CidadeDB.SetExcluiCidade(iCodigo, conexao);
            if (retorno)
            {
                MessageBox.Show("Cidade excluido");
            }
            else
            {
                MessageBox.Show("Erro ao excluir Cidade");
            }
        }
    }
}
