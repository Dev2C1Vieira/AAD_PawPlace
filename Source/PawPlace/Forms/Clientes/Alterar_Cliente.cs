using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PawPlace.Forms.Clientes
{
    public partial class Alterar_Cliente : Form
    {
        //Início do código para mover o Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public int id;

        public Alterar_Cliente()
        {
            InitializeComponent();
        }

        private void Alterar_Cliente_Load(object sender, System.EventArgs e)
        {

        }

        private void Pnl_Superior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            //Fim do código para mover o Form.
        }

        private void Btn_Fechar_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Btn_Permitir_Alterar_Click(object sender, System.EventArgs e)
        {
            Btn_Alterar.Show();
            Txt_NomeCliente.ReadOnly = false;
            Txt_Morada.ReadOnly = false;
            Mskd_Cod_Postal.ReadOnly = false;
            Txt_Localidade.ReadOnly = false;
            Mskd_Telefone.ReadOnly = false;
            Txt_Email.ReadOnly = false;
            Txt_Contribuinte.ReadOnly = false;
            Btn_Permitir_Alterar.Hide();
        }
    }
}
