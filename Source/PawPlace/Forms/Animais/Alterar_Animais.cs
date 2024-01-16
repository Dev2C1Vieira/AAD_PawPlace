using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PawPlace.Forms.Animais
{
    public partial class Alterar_Animais : Form
    {
        private readonly string conection;

        Forms.Clientes.Visualizar_Clientes visualizar_clientes = new Forms.Clientes.Visualizar_Clientes();

        //Início do código para mover o Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public int id;
        public string racaDesignacao = string.Empty;
        public string proprietarioNome = string.Empty;

        public Alterar_Animais()
        {
            InitializeComponent();
            conection = Conection.DBConection.ObterMySQLConection();
        }

        #region PreencherCampos

        public void Preencher_Campos()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conection))
                {
                    con.Open();

                    SqlCommand command = new SqlCommand($"Select * From Animal Where ID_Animal = {id}", con);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Txt_ID.Text = reader.GetValue(0).ToString();
                        Txt_NomeAnimal.Text = reader.GetValue(1).ToString();
                        DTP_DataNascimento.Text = reader.GetValue(2).ToString();

                        DateTime dataAux = Convert.ToDateTime(reader.GetValue(2));
                        Txt_DataNascimento.Text = dataAux.ToLongDateString();

                        Txt_Genero.Text = reader.GetValue(3).ToString();
                        Cmb_Genero.Text = reader.GetValue(3).ToString();

                        GetProprietarioNome(Convert.ToInt32(reader.GetValue(4)));
                        Txt_Proprietario.Text = proprietarioNome.ToString();
                        Cmb_Proprietario.Text = proprietarioNome.ToString();

                        GetRacaDesignacao(Convert.ToInt32(reader.GetValue(5)));
                        Txt_Raca.Text = racaDesignacao.ToString();
                        Cmb_Raca.Text = racaDesignacao.ToString();
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

        public void GetRacaDesignacao(int idRaca)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conection))
                {
                    con.Open();

                    string instrucaoSelect = "SELECT Designacao ";
                    string instrucaoFrom = "FROM Raca ";
                    string instrucaoWhere = $"WHERE ID_Raca = {idRaca}";

                    string instrucao = instrucaoSelect + instrucaoFrom + instrucaoWhere;

                    SqlCommand cmd = new SqlCommand(instrucao, con);

                    using (SqlDataReader Dados = cmd.ExecuteReader())
                    {
                        if (Dados.Read())
                            racaDesignacao = Dados["Designacao"].ToString();
                    }

                    con.Close();
                }
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.ToString());
            }
        }

        public void GetProprietarioNome(int idProprietario)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conection))
                {
                    con.Open();

                    string instrucaoSelect = "SELECT Name ";
                    string instrucaoFrom = "FROM Cliente ";
                    string instrucaoWhere = $"WHERE ID_Client = {idProprietario}";

                    string instrucao = instrucaoSelect + instrucaoFrom + instrucaoWhere;

                    SqlCommand cmd = new SqlCommand(instrucao, con);

                    using (SqlDataReader Dados = cmd.ExecuteReader())
                    {
                        if (Dados.Read())
                            proprietarioNome = Dados["Name"].ToString();
                    }

                    con.Close();
                }
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.ToString());
            }
        }

        #endregion

        private void Alterar_Animais_Load(object sender, EventArgs e)
        {
            Preencher_Cmb_Raca();
            Preencher_Cmb_Proprietario();
            Preencher_Campos();
            Txt_NomeAnimal.Focus();
            Pnl_Btn_Fechar.BringToFront();
            Btn_Fechar.BringToFront();
            Btn_Permitir_Alterar.Show();
            Btn_Alterar.Hide();
        }

        private void Pnl_Superior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            //Fim do código para mover o Form.
        }

        private void Btn_Permitir_Alterar_Click(object sender, EventArgs e)
        {
            Btn_Alterar.Show();
            Txt_NomeAnimal.ReadOnly = false;
            Txt_DataNascimento.Visible = false;
            DTP_DataNascimento.Visible = true;
            Txt_Genero.Visible = false;
            Cmb_Genero.Visible = true;
            Txt_Raca.Visible = false;
            Cmb_Raca.Visible = true;
            Txt_Proprietario.Visible = false;
            Cmb_Proprietario.Visible = true;
            Btn_Permitir_Alterar.Hide();
        }

        private void Pnl_Btn_Fechar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            //Fim do código para mover o Form.
        }

        private void Btn_Fechar_MouseHover(object sender, EventArgs e)
        {
            //Uma vez deixando de ter o rato em cima do botão de fechar, o seu panel correspondente altera a sua cor de fundo.
            Pnl_Btn_Fechar.BackColor = Color.Transparent;
        }

        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Btn_Alterar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((Txt_ID.Text != "") && (Txt_NomeAnimal.Text != "") && (DTP_DataNascimento.Text != "")
                    && (Cmb_Genero.Text != "") && (Cmb_Raca.Text != "") && (Cmb_Proprietario.Text != ""))
                {
                    using (SqlConnection con = new SqlConnection(conection))
                    {
                        con.Open();
                        SqlCommand command = con.CreateCommand();
                        command.CommandText = "Update Animal Set Nome_Animal = @nomeAnimal, " +
                            "Data_Nascimento = @dataNascimento, Género = @genero, " +
                            "A_ID_Client = @idClient, A_ID_Raca = @idRaca Where ID_Animal = @idAnimal";
                        command.CommandType = CommandType.Text;
                        //Nesta parte dos paramentros, o @ identifica, que se está a tratar de uma variável.
                        command.Parameters.AddWithValue("@idAnimal", Txt_ID.Text);
                        command.Parameters.AddWithValue("@nomeAnimal", Txt_NomeAnimal.Text);
                        command.Parameters.AddWithValue("@dataNascimento", DTP_DataNascimento.Value);
                        command.Parameters.AddWithValue("@genero", Cmb_Genero.Text);
                        command.Parameters.AddWithValue("@idClient", Cmb_Proprietario.SelectedValue);
                        command.Parameters.AddWithValue("@idRaca", Cmb_Raca.SelectedValue);
                        command.ExecuteNonQuery();
                        DialogResult = DialogResult.OK;
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Todos os campos têm de ser preenchidos para poder alterar as informações do cliente!");
                }
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.ToString());
            }
        }
    }
}
