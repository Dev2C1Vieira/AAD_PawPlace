using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;


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
                DataTable DataTable = new DataTable();

                string instrucaoSelect = "SELECT A.ID_Animal, A.Nome_Animal, A.Data_Nascimento, A.Género, " +
                    "R.Designacao, " +
                    "C.Name";
                string instrucaoFrom = " FROM Cliente AS C " +
                    "JOIN Animal AS A ON C.ID_Client = A.A_ID_Client " +
                    "LEFT JOIN Raca AS R ON A.A_ID_Raca = R.ID_Raca";

                string instrucaoWhere = "";
                if (texto != "")
                {
                    instrucaoWhere = string.Format($" WHERE LOWER(Nome_Animal) LIKE '%{valor}%'");
                }

                string instrucaoOrder = " ORDER BY A.ID_Animal ASC";

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
                Tabela_Dados.Columns[5].HeaderText = "Proprietário";

            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.ToString());
            }
        }

        #endregion

        #region ButtonsMethods

        public void Preencher_Cmb_Proprietario()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conection))
                {
                    con.Open();

                    DataTable otable = new DataTable();

                    string instrucaoSelect = "SELECT * ";
                    string instrucaoFrom = "FROM Cliente ";
                    string instrucaoOrder = "ORDER BY ID_Client ASC";

                    string instrucao = instrucaoSelect + instrucaoFrom + instrucaoOrder;

                    SqlDataAdapter Cmd = new SqlDataAdapter(instrucao, conection);
                    Cmd.Fill(otable);

                    Cmb_Proprietario.DataSource = otable;
                    Cmb_Proprietario.DisplayMember = "Name";
                    Cmb_Proprietario.ValueMember = "ID_Client";

                    con.Close();
                }
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.ToString());
            }
        }

        private void Visualizar_Animais_Load(object sender, EventArgs e)
        {
            Preencher_Cmb_Proprietario();
            Cmb_Proprietario.Text = "";
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
                Btn_Fechar_Pesquisa.Visible = true;
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
                int ID_AnimalAlterar = (int)Tabela_Dados.CurrentRow.Cells[0].Value;
                Alterar_Animais alterar_animais = new Alterar_Animais();
                alterar_animais.id = ID_AnimalAlterar;
                if (alterar_animais.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Dados do Animal Alterados!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                DialogResult dialogResult = MessageBox.Show("Deseja que o animal seja efetivamente eliminado?", "Eliminar Animal", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(conection))
                    {
                        string idAnimalEliminar = Tabela_Dados.CurrentRow.Cells[0].Value.ToString();
                        con.Open();

                        DataTable DataTable = new DataTable();

                        string instrucaoDelete = "DELETE ";
                        string instrucaoFrom = "FROM Animal ";
                        string instrucaoWhere = $"WHERE ID_Animal = '{idAnimalEliminar}'";

                        string instrucao = instrucaoDelete + instrucaoFrom + instrucaoWhere;

                        SqlCommand CmdSql = new SqlCommand(instrucao, con);

                        CmdSql.ExecuteNonQuery();
                        MessageBox.Show("O Animal foi eliminado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        con.Close();

                        ReporTabelaDados(Txt_Pesquisar.Text);
                    }
                }
                else
                {
                    MessageBox.Show("O Animal não foi eliminado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.ToString());
            }
        }

        private void Btn_SP_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja executar o Stored Procedure?", "Stored Procedure!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(conection))
                    {
                        using (SqlCommand command = new SqlCommand("GetAnimaisPorCliente", con))
                        {
                            command.CommandType = CommandType.StoredProcedure;

                            // Adiciona o parâmetro aqui
                            command.Parameters.AddWithValue("@IDCliente", Cmb_Proprietario.SelectedValue);

                            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                            {
                                DataTable table = new DataTable();
                                adapter.Fill(table);
                                Tabela_Dados.DataSource = table;
                            }
                        }
                    }
                }
                catch (SqlException SqlE)
                {
                    // Tratamento de exceções específicas do SQL.
                    Console.WriteLine("Erro de SQL: " + SqlE.Message);
                }
                catch (Exception E)
                {
                    // Tratamento de outras exceções.
                    Console.WriteLine("Erro: " + E.Message);
                }
            }
            else
            {
                MessageBox.Show("O Stored Procedure, não foi executado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void Btn_Ajuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este Stored Procedure, realiza uma pesquisa á Base de Dados, \nprocurando todos os animais do proprietário, selecionado na comboBox à esquerda! ", "Stored Procedure!", MessageBoxButtons.OK);
        }

        private void Btn_Fechar_SP_Click(object sender, EventArgs e)
        {
            Cmb_Proprietario.Text = "";
            ReporTabelaDados(Txt_Pesquisar.Text);
        }
    }
}
