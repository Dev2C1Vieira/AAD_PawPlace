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

namespace PawPlace.Forms.Animais
{
    public partial class Adicionar_Animais : Form
    {
        private readonly string conection;

        public bool auxR = false;

        public int newID = 0;
        public int newRacaID = 0;

        public Adicionar_Animais()
        {
            InitializeComponent();
            conection = Conection.DBConection.ObterMySQLConection();
        }

        private void LimparDados()
        {
            Txt_NomeAnimal.Clear();
            DTP_DataNascimento.Text = DateTime.Now.ToLongDateString();
            Cmb_Genero.Text = "";
            Cmb_Proprietario.Text = "";
            Cmb_Raca.Text = "";
            Txt_NomeAnimal.Focus();
        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            LimparDados();
        }

        public void GetNewID()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conection))
                {
                    con.Open();

                    string instrucaoSelect = "SELECT TOP 1 ID_Animal";
                    string instrucaoFrom = " FROM Animal ";
                    string instrucaoOrder = "ORDER BY ID_Animal DESC";

                    string instrucao = instrucaoSelect + instrucaoFrom + instrucaoOrder;

                    SqlCommand cmd = new SqlCommand(instrucao, con);

                    using (SqlDataReader Dados = cmd.ExecuteReader())
                    {
                        if (Dados.Read())
                            newID = Convert.ToInt32(Dados["ID_Animal"]) + 1;
                    }

                    con.Close();
                }
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.ToString());
            }
        }

        public void GetNewRacaID()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conection))
                {
                    con.Open();

                    string instrucaoSelect = "SELECT TOP 1 ID_Raca";
                    string instrucaoFrom = " FROM Raca ";
                    string instrucaoOrder = "ORDER BY ID_Raca DESC";

                    string instrucao = instrucaoSelect + instrucaoFrom + instrucaoOrder;

                    SqlCommand cmd = new SqlCommand(instrucao, con);

                    using (SqlDataReader Dados = cmd.ExecuteReader())
                    {
                        if (Dados.Read())
                            newRacaID = Convert.ToInt32(Dados["ID_Raca"]) + 1;
                    }

                    con.Close();
                }
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.ToString());
            }
        }

        public void Preencher_Cmb_Raca()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conection))
                {
                    con.Open();

                    DataTable otable = new DataTable();

                    string instrucaoSelect = "SELECT * ";
                    string instrucaoFrom = "FROM Raca ";
                    string instrucaoOrder = "ORDER BY ID_Raca ASC";

                    string instrucao = instrucaoSelect + instrucaoFrom + instrucaoOrder;

                    SqlDataAdapter Cmd = new SqlDataAdapter(instrucao, conection);
                    Cmd.Fill(otable);

                    Cmb_Raca.DataSource = otable;
                    Cmb_Raca.DisplayMember = "Designacao";
                    Cmb_Raca.ValueMember = "ID_Raca";

                    con.Close();
                }
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.ToString());
            }
        }

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

        private void Adicionar_Animais_Load(object sender, EventArgs e)
        {
            Preencher_Cmb_Raca();
            Preencher_Cmb_Proprietario();
            LimparDados();
        }

        public void Verificar_Existencia_Raca(int idRaca, string designacao)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conection))
                {
                    con.Open();

                    string instrucaoSelect = "SELECT * ";
                    string instrucaoFrom = "From Raca ";
                    string instrucaoWhere = $"WHERE Designacao = '{designacao}' " +
                        $"AND ID_Raca = '{idRaca}'";

                    string instrucao = instrucaoSelect + instrucaoFrom + instrucaoWhere;

                    SqlCommand cmd = new SqlCommand(instrucao, con);

                    using (SqlDataReader Dados = cmd.ExecuteReader())
                    {
                        if (Dados.Read())
                            auxR = true;
                        else
                            auxR = false;
                    }

                    con.Close();
                }
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.ToString());
            }
        }

        public void InsertNewAnimal(string nomeAnimal, DateTime dataNascimento, string genero, int idCliente, int idRaca)
        {
            try
            {
                GetNewRacaID();
                using (SqlConnection con = new SqlConnection(conection))
                {
                    con.Open();

                    SqlCommand command = con.CreateCommand();

                    // Comando para inserir os dados na tabela Cliente.
                    command.CommandText = "Insert Into Animal Values(@idAnimal, @nomeAnimal, @dataNascimento, @genero, @idCliente, @idRaca)";
                    command.CommandType = CommandType.Text;
                    // Nesta parte dos paramentros, o @ identifica, que se está a tratar de uma variável.
                    command.Parameters.AddWithValue("@idAnimal", newID);
                    command.Parameters.AddWithValue("@nomeAnimal", nomeAnimal);
                    command.Parameters.AddWithValue("@dataNascimento", dataNascimento);
                    command.Parameters.AddWithValue("@genero", genero);
                    command.Parameters.AddWithValue("@idCliente", idCliente);
                    command.Parameters.AddWithValue("@idRaca", idRaca);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Novo Cliente adicionado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    con.Close();
                }
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.ToString());
            }
        }

        public void InsertNewRaca(string designacao)
        {
            try
            {
                GetNewRacaID();
                using (SqlConnection con = new SqlConnection(conection))
                {
                    con.Open();

                    SqlCommand command = con.CreateCommand();

                    // Comando para inserir os dados na tabela Cliente.
                    command.CommandText = "Insert Into Raca Values(@idRaca, @designacao)";
                    command.CommandType = CommandType.Text;
                    // Nesta parte dos paramentros, o @ identifica, que se está a tratar de uma variável.
                    command.Parameters.AddWithValue("@idRaca", newRacaID);
                    command.Parameters.AddWithValue("@designacao", designacao);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Novo Cliente adicionado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    con.Close();
                }
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.ToString());
            }
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                GetNewID();
                Verificar_Existencia_Raca(Convert.ToInt32(Cmb_Raca.SelectedValue), Cmb_Raca.Text);
                if ((Txt_NomeAnimal.Text != "") && (Cmb_Genero.Text != "") && (Cmb_Raca.Text != "") && (Cmb_Proprietario.Text != null))
                {
                    if (auxR == false)
                    {
                        InsertNewRaca(Cmb_Raca.Text);
                        InsertNewAnimal(Txt_NomeAnimal.Text, DTP_DataNascimento.Value, Cmb_Genero.Text, (int)Cmb_Proprietario.SelectedValue, newRacaID);
                    }
                    else
                    {
                        InsertNewAnimal(Txt_NomeAnimal.Text, DTP_DataNascimento.Value, Cmb_Genero.Text, (int)Cmb_Proprietario.SelectedValue, (int)Cmb_Raca.SelectedValue);
                    }
                }
                else
                {
                    MessageBox.Show("Todos os campos têm de ser preenchidos para poder adicionar um novo animal!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.ToString());
            }
            finally
            {
                LimparDados();
            }
        }
    }
}
