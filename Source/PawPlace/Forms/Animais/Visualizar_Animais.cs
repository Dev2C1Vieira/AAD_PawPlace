using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using PawPlace.Forms.Clientes;

namespace PawPlace.Forms.Animais
{
    public partial class Visualizar_Animais : Form
    {
        private readonly string conection;

        DataSet ds = new DataSet();
        SqlDataAdapter DataAdapter = new SqlDataAdapter();

        public Visualizar_Animais()
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
                string valor = texto.ToLower();
                string id = texto.ToUpper();
                DataTable DataTable = new DataTable();

                string instrucaoSelect = "SELECT A.ID_Animal, A.Nome_Animal, A.Data_Nascimento, A.Género, " +
                    "R.Designacao, " +
                    "Co.Designacao, " +
                    "C.Name, " +
                    "Q.Descricao";
                string instrucaoFrom = " FROM Cliente AS C " +
                    "JOIN Animal AS A ON C.ID_Client = A.A_ID_Client " +
                    "JOIN Quarto AS Q ON A.A_ID_Quarto = Q.ID_Quarto " +
                    "LEFT JOIN Raca AS R ON A.A_ID_Raca = R.ID_Raca " +
                    "LEFT JOIN Cor_Animal AS CA ON A.ID_Animal = CA.C_ID_Animal " +
                    "LEFT JOIN Cor AS Co ON CA.C_ID_Cor = Co.ID_Cor";

                string instrucaoWhere = "";
                if (texto != "")
                {
                    instrucaoWhere = string.Format($" WHERE LOWER(Nome_Animal) LIKE '%{valor}%' " +
                        $"OR LOWER(C.Name) LIKE '%{valor}%' " +
                        $"OR LOWER(Q.Descricao LIKE '%{valor}%')");
                }

                string instrucaoOrder = " ORDER BY ID_Client ASC";

                string instrucao = instrucaoSelect + instrucaoFrom + instrucaoWhere + instrucaoOrder;

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
                Tabela_Dados.Columns[1].HeaderText = "Nome do Animal";
                Tabela_Dados.Columns[2].HeaderText = "Data de Nascimento";
                Tabela_Dados.Columns[3].HeaderText = "Género";
                Tabela_Dados.Columns[4].HeaderText = "Raca";
                Tabela_Dados.Columns[5].HeaderText = "Cor";
                Tabela_Dados.Columns[6].HeaderText = "Proprietário";
                Tabela_Dados.Columns[7].HeaderText = "Quarto";

            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.ToString());
            }
        }

        #endregion

        #region ButtonsMethods

        private void Visualizar_Animais_Load(object sender, EventArgs e)
        {
            ReporTabelaDados(Txt_Pesquisar.Text);
            Atribuir_Nomes_Tabela_Dados();
            Btn_Fechar_Pesquisa.Show();
            Btn_Fechar_Pesquisa.BringToFront();
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
            try
            {
                DialogResult dialogResult = MessageBox.Show("Deseja que o cliente seja efetivamente eliminado?", "Eliminar Cliente", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(conection))
                    {
                        string idClienteEliminar = Tabela_Dados.CurrentRow.Cells[0].Value.ToString();
                        con.Open();

                        DataTable DataTable = new DataTable();

                        string instrucaoDelete = "DELETE ";
                        string instrucaoFrom = "FROM Cliente ";
                        string instrucaoWhere = $"WHERE ID_Client = '{idClienteEliminar}'";

                        string instrucao = instrucaoDelete + instrucaoFrom + instrucaoWhere;

                        SqlCommand CmdSql = new SqlCommand(instrucao, con);

                        CmdSql.ExecuteNonQuery();
                        MessageBox.Show("O Cliente foi eliminado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        con.Close();

                        ReporTabelaDados(Txt_Pesquisar.Text);
                    }
                }
                else
                {
                    MessageBox.Show("O Cliente não foi eliminado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.ToString());
            }
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
