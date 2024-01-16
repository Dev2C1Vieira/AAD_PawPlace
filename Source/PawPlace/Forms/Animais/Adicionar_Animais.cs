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

        public bool aux = false;

        public int newID = 0;

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

                    string instrucaoSelect = "SELECT TOP 1 ID_Client";
                    string instrucaoFrom = " FROM Cliente ";
                    string instrucaoOrder = "ORDER BY ID_Client DESC";

                    string instrucao = instrucaoSelect + instrucaoFrom + instrucaoOrder;

                    SqlCommand cmd = new SqlCommand(instrucao, con);

                    using (SqlDataReader Dados = cmd.ExecuteReader())
                    {
                        if (Dados.Read())
                            newID = Convert.ToInt32(Dados["ID_Client"]) + 1;
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

        public void Verificar_Existencia(string nomeCliente, DateTime dataNascimento, int nif, string codPostal)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conection))
                {
                    con.Open();

                    string instrucaoSelect = "SELECT * ";
                    string instrucaoFrom = "From Cliente ";
                    string instrucaoWhere = $"WHERE Name = '{nomeCliente}' " +
                        $"AND Data_Nascimento = {dataNascimento} " +
                        $"AND NIF = {nif} " +
                        $"AND C_Cod_Postal = '{codPostal}'";

                    string instrucao = instrucaoSelect + instrucaoFrom + instrucaoWhere;

                    SqlCommand cmd = new SqlCommand(instrucao, con);

                    using (SqlDataReader Dados = cmd.ExecuteReader())
                    {
                        if (Dados.Read())
                            aux = true;
                        else
                            aux = false;
                    }

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
    }
}
