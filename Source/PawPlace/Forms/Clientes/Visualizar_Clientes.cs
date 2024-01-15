using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PawPlace.Forms.Clientes
{
    public partial class Visualizar_Clientes : Form
    {
        private readonly string conection;

        DataSet ds = new DataSet();
        SqlDataAdapter DataAdapter = new SqlDataAdapter();

        int inicio = 0;
        int pagAtual = 1;
        int tamanhoPagina = 0;
        int totalRegistos = 0;

        public Visualizar_Clientes()
        {
            InitializeComponent();
            conection = Conection.DBConection.ObterMySQLConection();
        }

        #region ReporTabelaDados

        // Este codigo nao esta bem.
        public void ReporTabelaDados(string texto)
        {
            //Este código permite-me utilizar o conceito Low Code, pois uma vez que o código se repete diversas vezes, dei a criação de um metodo, com variaveis qe fazem o trabalho por si.
            try
            {
                string Valor = texto.ToLower();
                string ID = texto.ToUpper();
                DataTable DataTable = new DataTable();
                string instrucao = "Select ID_Client, Name, Data_Nascimento, NIF, C_Cod_Postal";
                string instrucaoFrom = " From Cliente";
                string instrucaoOrder = " Order By ID_Client Asc";
                instrucao = instrucao + instrucaoFrom + instrucaoOrder;
                System.Diagnostics.Debug.WriteLine(instrucao);
                DataAdapter = new SqlDataAdapter(instrucao, conection);
                DataAdapter.Fill(DataTable);
                Tabela_Dados.DataSource = DataTable;
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.ToString());
            }
        }

        public void Atribuir_Nomes_Tabela_Dados()
        {
            try
            {
                Tabela_Dados.Columns[0].HeaderText = "Código";
                Tabela_Dados.Columns[1].HeaderText = "Nome";
                Tabela_Dados.Columns[2].HeaderText = "Data de Nascimento";
                Tabela_Dados.Columns[3].HeaderText = "NIF";
                Tabela_Dados.Columns[4].HeaderText = "Código Postal";
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.ToString());
            }
        }

        #endregion

        #region ButtonsMethods

        private void Visualizar_Clientes_Load(object sender, EventArgs e)
        {
            ReporTabelaDados(Txt_Pesquisar.Text);
            Atribuir_Nomes_Tabela_Dados();
            Btn_Fechar_Pesquisa.Show();
            Btn_Fechar_Pesquisa.BringToFront();
            totalRegistos = Tabela_Dados.Rows.Count;
        }

        private void Txt_Pesquisar_TextChanged(object sender, EventArgs e)
        {
            //Código utilizado para pesquisar a informação na base de dados, diretamente através da textbox.
            try
            {
                ReporTabelaDados(Txt_Pesquisar.Text);
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.ToString());
            }
        }

        private void Btn_Alterar_Click(object sender, EventArgs e)
        {
            //Este código recolhe as informações presentes na datagridview e guardas em variáveis, que depois são por sua vez guardadas
            //nas respetivas caixas de texto, no formulário de alterar os dados.
            try
            {
                int ID_ClienteAlterar = (int)Tabela_Dados.CurrentRow.Cells[0].Value;
                Alterar_Cliente alterar_cliente = new Alterar_Cliente();
                alterar_cliente.id = ID_ClienteAlterar;
                if (alterar_cliente.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Dados do Cliente Alterados!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReporTabelaDados(Txt_Pesquisar.Text);
                }
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.ToString());
            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            ////Este código elimina todas as informações do registo que tiver selecionado, permitindo a confirmação da eliminação
            ////para permitir anular, caso o botão tenha sido premido por engano.
            //try
            //{
            //    DialogResult dialogResult = MessageBox.Show("Deseja que o relacionamento seja efetivamente removido?", "Removido Relacionamento", MessageBoxButtons.YesNo);
            //    if (dialogResult == DialogResult.Yes)
            //    {
            //        string idClientesAlterar = Tabela_Dados.CurrentRow.Cells[0].Value.ToString();
            //        conection.Open();
            //        MySqlCommand command = new MySqlCommand("Update Clientes Set Estado = 'Indisponivel' Where ID_Cliente = '" + idClientesAlterar + "'", conection);
            //        command.ExecuteNonQuery();
            //        MessageBox.Show("O Cliente foi removido!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        conection.Close();
            //        ReporTabelaDados(Txt_Pesquisar.Text, Qnt_Entrys.Text);
            //    }
            //    else
            //    {
            //        MessageBox.Show("O Cliente não foi removido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //}
            //catch (Exception Erro)
            //{
            //    MessageBox.Show(Erro.ToString());
            //}
        }

        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        #endregion

        #region ResponsiveButtonsMethods

        private void Btn_Fechar_Pesquisa_Click(object sender, EventArgs e)
        {
            Txt_Pesquisar.Clear();
        }

        private void Txt_Pesquisar_Leave(object sender, EventArgs e)
        {
            Pnl_Principal.Focus();
        }

        private void Pnl_Principal_Click(object sender, EventArgs e)
        {
            Pnl_Principal.Focus();
        }

        private void Btn_Alterar_MouseHover(object sender, EventArgs e)
        {
            Btn_Alterar.BackColor = Color.Silver;
        }

        private void Btn_Delete_MouseHover(object sender, EventArgs e)
        {
            Btn_Delete.BackColor = Color.Silver;
        }

        private void Btn_Alterar_MouseLeave(object sender, EventArgs e)
        {
            Btn_Alterar.BackColor = Color.Transparent;
        }

        private void Btn_Delete_MouseLeave(object sender, EventArgs e)
        {
            Btn_Delete.BackColor = Color.Transparent;
        }

        #endregion
    }
}
