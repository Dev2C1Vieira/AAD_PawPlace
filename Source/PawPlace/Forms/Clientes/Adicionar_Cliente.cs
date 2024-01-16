using System;
using System.Data;
using System.Data.SqlClient;

using System.Windows.Forms;

namespace PawPlace.Forms.Clientes
{
    public partial class Adicionar_Cliente : Form
    {
        private readonly string conection;

        public bool aux = false;

        public int newID = 0;

        public Adicionar_Cliente()
        {
            InitializeComponent();
            conection = Conection.DBConection.ObterMySQLConection();
        }

        private void LimparDados()
        {
            Txt_NomeCliente.Clear();
            DTP_DataNascimento.Text = DateTime.Now.ToLongDateString();
            Txt_NIF.Clear();
            Cmb_CodPostal.Text = "";
            Txt_Localidade.Clear();
            Txt_NomeCliente.Focus();
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

        public void Preencher_Cmb_CodPostal()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conection))
                {
                    con.Open();

                    DataTable otable = new DataTable();

                    string instrucaoSelect = "SELECT * ";
                    string instrucaoFrom = "FROM Cod_Postal ";
                    string instrucaoOrder = "ORDER BY Cod_Postal ASC";

                    string instrucao = instrucaoSelect + instrucaoFrom + instrucaoOrder;

                    SqlDataAdapter Cmd = new SqlDataAdapter(instrucao, conection);
                    Cmd.Fill(otable);

                    Cmb_CodPostal.DataSource = otable;
                    Cmb_CodPostal.DisplayMember = "Cod_Postal";
                    Cmb_CodPostal.ValueMember = "Cod_Postal";

                    con.Close();
                }
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.ToString());
            }
        }

        private void Adicionar_Cliente_Load(object sender, EventArgs e)
        {
            Preencher_Cmb_CodPostal();
            LimparDados();
        }

        private void Cmb_CodPostal_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conection))
                {
                    con.Open();

                    DataTable otable = new DataTable();

                    string instrucaoSelect = "SELECT Localidade ";
                    string instrucaoFrom = "FROM Cod_Postal ";
                    string instrucaoWhere = $"WHERE Cod_Postal = '{Cmb_CodPostal.SelectedValue}'";

                    string instrucao = instrucaoSelect + instrucaoFrom + instrucaoWhere;

                    SqlCommand cmd = new SqlCommand(instrucao, con);

                    using (SqlDataReader Dados = cmd.ExecuteReader())
                    {
                        if (Dados.Read())
                            Txt_Localidade.Text = Dados[0].ToString();
                    }

                    con.Close();
                }
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.ToString());
            }
        }

        //public void Verificar_Existencia_CodPostal(string codPostal)
        //{
        //    try
        //    {
        //        using (SqlConnection con = new SqlConnection(conection))
        //        {
        //            con.Open();

        //            string instrucaoSelect = "SELECT * ";
        //            string instrucaoFrom = "From Cod_Postal ";
        //            string instrucaoWhere = $"WHERE Cod_Postal = {codPostal}";

        //            string instrucao = instrucaoSelect + instrucaoFrom + instrucaoWhere;

        //            SqlCommand cmd = new SqlCommand(instrucao, con);

        //            using (SqlDataReader Dados = cmd.ExecuteReader())
        //            {
        //                if (Dados.Read())
        //                    auxCP = true;
        //                else
        //                    auxCP = false;
        //            }

        //            con.Close();
        //        }
        //    }
        //    catch (Exception Erro)
        //    {
        //        MessageBox.Show(Erro.ToString());
        //    }
        //}

        //public void Add_CodPostal(string codPostal, string localidade)
        //{
        //    try
        //    {
        //        Verificar_Existencia_CodPostal(codPostal);
        //    }
        //    catch
        //    {
        //        if (auxCP == false)
        //        {
        //            using (SqlConnection con = new SqlConnection(conection))
        //            {
        //                con.Open();

        //                SqlCommand command = con.CreateCommand();

        //                // Comando para inserir os dados na tabela Cliente.
        //                command.CommandText = "Insert Into Cod_Postal Values(@codPostal, @localidade)";
        //                command.CommandType = CommandType.Text;
        //                // Nesta parte dos paramentros, o @ identifica, que se está a tratar de uma variável.
        //                command.Parameters.AddWithValue("@codPostal", codPostal);
        //                command.Parameters.AddWithValue("@localidade", localidade);
        //                command.ExecuteNonQuery();

        //                con.Close();
        //            }
        //        }
        //    }
        //}

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                Verificar_Existencia(Txt_NomeCliente.Text, Convert.ToDateTime(DTP_DataNascimento.Value.ToShortDateString()), Convert.ToInt32(Txt_NIF.Text), Cmb_CodPostal.Text);
                GetNewID();
                if ((Txt_NomeCliente.Text != "") && (Txt_NIF.Text != "") && (Cmb_CodPostal.Text != "") && (Txt_Localidade.Text != null))
                {
                    if (aux == true)
                        MessageBox.Show("Já existe um Cliente com essas informações.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        using (SqlConnection con = new SqlConnection(conection))
                        {
                            con.Open();

                            SqlCommand command = con.CreateCommand();

                            // Comando para inserir os dados na tabela Cliente.
                            command.CommandText = "Insert Into Cliente Values(@idCliente, @nomeCliente, @dataNascimento, @nif, @codPostal)";
                            command.CommandType = CommandType.Text;
                            // Nesta parte dos paramentros, o @ identifica, que se está a tratar de uma variável.
                            command.Parameters.AddWithValue("@idCliente", newID);
                            command.Parameters.AddWithValue("@nomeCliente", Txt_NomeCliente.Text);
                            command.Parameters.AddWithValue("@dataNascimento", DTP_DataNascimento.Value);
                            command.Parameters.AddWithValue("@nif", Convert.ToInt32(Txt_NIF.Text));
                            command.Parameters.AddWithValue("@codPostal", Cmb_CodPostal.Text);
                            command.ExecuteNonQuery();

                            MessageBox.Show("Novo Cliente adicionado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            con.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Todos os campos têm de ser preenchidos para poder adicionar um novo cliente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void Txt_Localidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Este código impede que, ao premir qualquer tecla que não seja de uma letra ou do backspace ou do delete, insira o dado correspondente.
            //Com isto quero dizer dizer que este código não permite que eu insira números na caixa de texto da localidade.
            char ch = e.KeyChar;
            if (Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}