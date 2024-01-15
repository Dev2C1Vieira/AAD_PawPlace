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

        private void Btn_Fechar_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
