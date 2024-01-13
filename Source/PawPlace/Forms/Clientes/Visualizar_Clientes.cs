using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PawPlace.Forms.Clientes
{
    public partial class Visualizar_Clientes : Form
    {
        //private MySql.Data.MySqlClient.MySqlConnection conection;

        //DataSet ds = new DataSet();
        //MySqlDataAdapter DataAdapter = new MySqlDataAdapter();

        //int inicio = 0;
        //int pagAtual = 1;
        //int tamanhoPagina = 0;
        //int totalRegistos = 0;

        public Visualizar_Clientes()
        {
            InitializeComponent();
            //conection = Conection.DBConection.ObterConexao();
        }

        //// Este codigo nao esta bem.
        //public void ReporTabelaDados(string texto, string limit)
        //{
        //    //Este código permite-me utilizar o conceito Low Code, pois uma vez que o código se repete diversas vezes, dei a criação de um metodo, com variaveis qe fazem o trabalho por si.
        //    try
        //    {
        //        string Valor = texto.ToLower();
        //        string ID = texto.ToUpper();
        //        conection.Open();
        //        DataTable DataTable = new DataTable();
        //        string instrucao = "Select ID_Cliente, NomeCliente, Morada, Codigo_Postal, Localidade, Telefone, Email, Contribuinte From Clientes";
        //        string instrucaoWhere = " Where Estado = 'Disponivel'";
        //        if (texto != "")
        //        {
        //            instrucaoWhere = string.Format(" Where ID_Cliente like '%{1}%' or Lower(NomeCliente) like '%{0}%'", Valor, ID);
        //        }
        //        string instrucaoOrder = " Order By ID_Cliente Asc";
        //        string instrucaoLimite = "";
        //        if (limit != "All")
        //        {
        //            instrucaoLimite = " Limit " + limit;
        //        }
        //        string instrucaoOffset = "";
        //        if (pagAtual > 1)
        //        {
        //            instrucaoOffset = string.Format(" offset {0} ", tamanhoPagina * (pagAtual - 1));
        //        }
        //        instrucao = instrucao + instrucaoWhere + instrucaoOrder + instrucaoLimite + instrucaoOffset;
        //        System.Diagnostics.Debug.WriteLine(instrucao);
        //        DataAdapter = new MySqlDataAdapter(instrucao, conection);
        //        DataAdapter.Fill(DataTable);
        //        Tabela_Dados.DataSource = DataTable;
        //    }
        //    catch (Exception Erro)
        //    {
        //        MessageBox.Show(Erro.ToString());
        //    }
        //    finally
        //    {
        //        conection.Close();
        //    }
        //}

        //public void Atribuir_Nomes_Tabela_Dados()
        //{
        //    try
        //    {
        //        Tabela_Dados.Columns[0].HeaderText = "Código";
        //        Tabela_Dados.Columns[1].HeaderText = "Nome";
        //        Tabela_Dados.Columns[2].HeaderText = "Morada";
        //        Tabela_Dados.Columns[3].HeaderText = "Código Postal";
        //        Tabela_Dados.Columns[4].HeaderText = "Localidade";
        //        Tabela_Dados.Columns[5].HeaderText = "Telefone";
        //        Tabela_Dados.Columns[6].HeaderText = "Email";
        //        Tabela_Dados.Columns[7].HeaderText = "Contribuinte";
        //    }
        //    catch (Exception Erro)
        //    {
        //        MessageBox.Show(Erro.ToString());
        //    }
        //}

        private void Visualizar_Clientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pawPlaceDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.pawPlaceDataSet.Cliente);

        }

        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            Forms.Entrada.Menu menu = new Forms.Entrada.Menu();
            menu.Show();
            this.Hide();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            Forms.Clientes.Adicionar_Cliente adicionar_Cliente = new Forms.Clientes.Adicionar_Cliente();
            adicionar_Cliente.Show();
        }
    }
}
