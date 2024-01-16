using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PawPlace.Forms.Clientes
{
    public partial class Alterar_Cliente : Form
    {
        private readonly string conection;

        Forms.Clientes.Visualizar_Clientes visualizar_clientes = new Forms.Clientes.Visualizar_Clientes();

        //Início do código para mover o Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public int id;

        public Alterar_Cliente()
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
                    SqlCommand command = new SqlCommand("Select * From Cliente Where ID_Client = '" + id + "'", con);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Txt_ID.Text = reader.GetValue(0).ToString();
                        Txt_NomeCliente.Text = reader.GetValue(1).ToString();
                        DTP_DataNascimento.Text = reader.GetValue(2).ToString();

                        DateTime dataAux = Convert.ToDateTime(reader.GetValue(2));
                        Txt_DataNascimento.Text = dataAux.ToLongDateString();

                        Txt_NIF.Text = reader.GetValue(3).ToString();
                        Txt_CodPostal.Text = reader.GetValue(4).ToString();
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

        private void Alterar_Cliente_Load(object sender, System.EventArgs e)
        {
            Preencher_Campos();
            Txt_NomeCliente.Focus();
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

        private void Btn_Permitir_Alterar_Click(object sender, System.EventArgs e)
        {
            Btn_Alterar.Show();
            Txt_NomeCliente.ReadOnly = false;
            Txt_DataNascimento.Visible = false;
            DTP_DataNascimento.Visible = true;
            Txt_NIF.ReadOnly = false;
            Txt_CodPostal.ReadOnly = false;
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

        private void Btn_Fechar_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Btn_Alterar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((Txt_ID.Text != "") && (Txt_NomeCliente.Text != "") && (DTP_DataNascimento.Text != "")
                    && (Txt_NIF.Text != "") && (Txt_CodPostal.Text != ""))
                {
                    using (SqlConnection con = new SqlConnection(conection))
                    {
                        con.Open();
                        SqlCommand command = con.CreateCommand();
                        command.CommandText = "Update Cliente Set Name = @name, " +
                            "Data_Nascimento = @dataNascimento, NIF = @nif Where ID_Client = @idClient";
                        command.CommandType = CommandType.Text;
                        //Nesta parte dos paramentros, o @ identifica, que se está a tratar de uma variável.
                        command.Parameters.AddWithValue("@idCLient", Txt_ID.Text);
                        command.Parameters.AddWithValue("@name", Txt_NomeCliente.Text);
                        command.Parameters.AddWithValue("@dataNascimento", DTP_DataNascimento.Value);
                        command.Parameters.AddWithValue("@nif", Txt_NIF.Text);
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
