using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Management.Instrumentation;

namespace PawPlace.Forms.Entrada
{
    public partial class Menu : Form
    {
        //Código baseado em extensões, para permitir que o formulário possa ser movido.
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public Menu()
        {
            InitializeComponent();

            //Costumizar o form menu.
            customizeDesigne();
            PnlNav.Height = Btn_Home.Height;
            PnlNav.Top = Btn_Home.Top;
            PnlNav.Left = Btn_Home.Left;
            Btn_Home.BackColor = Color.FromArgb(24, 30, 40);
        }

        #region ResponsiveFormMethods

        private void Menu_Load(object sender, EventArgs e)
        {
            //Este código é realizado, quando o formulário é aberto.
            Relogio.Start();
            Btn_Maximizado.BringToFront();
            WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void Relogio_Tick(object sender, EventArgs e)
        {
            Lb_Data.Text = DateTime.Now.ToLongDateString();
            Lb_Hora.Text = DateTime.Now.ToLongTimeString();
        }


        private Form activeForm = null;

        public void openChildForm(Form ChildForm)
        {
            //Código que define as "características" do child form, ou seja, define as bordas, as propriedades, entre outros.
            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            Pnl_Child_Form.Controls.Add(ChildForm);
            Pnl_Child_Form.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void customizeDesigne()
        {
            Pnl_Sub_Clientes.Visible = false;
            Pnl_Sub_Animais.Visible = false;
            Pnl_Sub_Quartos.Visible = false;
        }

        private void HideSubMenu()
        {
            //Este código serve para caso os sub-paneis estejam fechado, este abre-os. Caso os mesmos estejam abertos, este fecha-os.
            if (Pnl_Sub_Clientes.Visible == true)
            {
                Pnl_Sub_Clientes.Visible = false;
            }
            if (Pnl_Sub_Animais.Visible == true)
            {
                Pnl_Sub_Animais.Visible = false;
            }
            if (Pnl_Sub_Quartos.Visible == true)
            {
                Pnl_Sub_Quartos.Visible = false;
            }
        }

        private void ShowSubMenu(Panel SubMenu)
        {
            //Este código funciona, através da leitura do programa sobre quais dos panéis que estam abertos, fechando os que não precisa, e abrindo os precisos.
            if (SubMenu.Visible == false)
            {
                HideSubMenu();
                SubMenu.Visible = true;
            }
            else
            {
                SubMenu.Visible = false;
            }
        }

        #endregion

        #region Responsive_Btn_Methods

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            //Código para minimizar o formulário.
            WindowState = FormWindowState.Minimized;
        }

        private void Btn_Maximizar_Click(object sender, EventArgs e)
        {
            //Código para maximizar o formulário.
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void Btn_Maximizado_Click(object sender, EventArgs e)
        {
            //Código para diminuir o formulário.
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Responsive_Pnl_Methods

        private void Pnl_Btn_Min_MouseHover(object sender, EventArgs e)
        {
            //Uma vez tendo o rato em cima do botão de minimizar, o seu panel correspondente altera a sua cor de fundo.
            Pnl_Btn_Min.BackColor = Color.DarkGray;
        }

        private void Pnl_Btn_Min_MouseLeave(object sender, EventArgs e)
        {
            //Uma vez deixando de ter o rato em cima do botão de minimizar, o seu panel correspondente altera a sua cor de fundo.
            Pnl_Btn_Min.BackColor = Color.Transparent;
        }

        private void Pnl_Btn_Max_MouseHover(object sender, EventArgs e)
        {
            //Uma vez tendo o rato em cima do botão de minimizar, o seu panel correspondente altera a sua cor de fundo.
            Pnl_Btn_Max.BackColor = Color.DarkGray;
        }

        private void Pnl_Btn_Max_MouseLeave(object sender, EventArgs e)
        {
            //Uma vez deixando de ter o rato em cima do botão de minimizar, o seu panel correspondente altera a sua cor de fundo.
            Pnl_Btn_Max.BackColor = Color.Transparent;
        }

        private void Pnl_Btn_Fechar_MouseHover(object sender, EventArgs e)
        {
            //Uma vez tendo o rato em cima do botão de minimizar, o seu panel correspondente altera a sua cor de fundo.
            Pnl_Btn_Fechar.BackColor = Color.DarkGray;
        }

        private void Pnl_Btn_Fechar_MouseLeave(object sender, EventArgs e)
        {
            //Uma vez deixando de ter o rato em cima do botão de minimizar, o seu panel correspondente altera a sua cor de fundo.
            Pnl_Btn_Fechar.BackColor = Color.Transparent;
        }

        private void Btn_Minimizar_MouseHover(object sender, EventArgs e)
        {
            //Uma vez tendo o rato em cima do botão de minimizar, o seu panel correspondente altera a sua cor de fundo.
            Pnl_Btn_Min.BackColor = Color.DarkGray;
        }

        private void Btn_Minimizar_MouseLeave(object sender, EventArgs e)
        {
            //Uma vez deixando de ter o rato em cima do botão de minimizar, o seu panel correspondente altera a sua cor de fundo.
            Pnl_Btn_Min.BackColor = Color.Transparent;
        }

        private void Btn_Maximizar_MouseHover(object sender, EventArgs e)
        {
            //Uma vez tendo o rato em cima do botão de minimizar, o seu panel correspondente altera a sua cor de fundo.
            Pnl_Btn_Max.BackColor = Color.DarkGray;
        }

        private void Btn_Maximizar_MouseLeave(object sender, EventArgs e)
        {
            //Uma vez deixando de ter o rato em cima do botão de minimizar, o seu panel correspondente altera a sua cor de fundo.
            Pnl_Btn_Max.BackColor = Color.Transparent;
        }

        private void Btn_Maximizado_MouseHover(object sender, EventArgs e)
        {
            //Uma vez tendo o rato em cima do botão de minimizar, o seu panel correspondente altera a sua cor de fundo.
            Pnl_Btn_Max.BackColor = Color.DarkGray;
        }

        private void Btn_Maximizado_MouseLeave(object sender, EventArgs e)
        {
            //Uma vez deixando de ter o rato em cima do botão de minimizar, o seu panel correspondente altera a sua cor de fundo.
            Pnl_Btn_Max.BackColor = Color.Transparent;
        }

        private void Btn_Fechar_MouseHover(object sender, EventArgs e)
        {
            //Uma vez tendo o rato em cima do botão de minimizar, o seu panel correspondente altera a sua cor de fundo.
            Pnl_Btn_Fechar.BackColor = Color.DarkGray;
        }

        private void Btn_Fechar_MouseLeave(object sender, EventArgs e)
        {
            //Uma vez deixando de ter o rato em cima do botão de minimizar, o seu panel correspondente altera a sua cor de fundo.
            Pnl_Btn_Fechar.BackColor = Color.Transparent;
        }

        private void Pnl_Superior_MouseDown(object sender, MouseEventArgs e)
        {
            //Código para permitir mover o formulário 
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        #region Menu_SizeChanged_Methods

        private void Menu_SizeChanged(object sender, EventArgs e)
        {
            //Código para ler quando o formulário é mexido, e nesse caso altera o botão de controlo visível de acordo com o acontecido.
            if (WindowState == FormWindowState.Normal)
            {
                Btn_Maximizar.BringToFront();
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                Btn_Maximizado.BringToFront();
            }
        }

        private void Pnl_Superior_DoubleClick(object sender, EventArgs e)
        {
            //Código para aumentar ou diminuir o formulário, quando efetuamos um double click no panel.
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        #endregion

        #region MainMethods

        #region HomeSectionMethods

        private void Btn_Home_Click(object sender, EventArgs e)
        {
            Forms.Entrada.Menu menu = new Forms.Entrada.Menu();
            menu.Show();
            this.Hide();
        }

        #endregion

        #region ClientesSectionMethods

        private void Btn_Clientes_Click(object sender, EventArgs e)
        {
            //Este código permite, no caso de fechado, abrir o subpanel dos clientes, para podermos aceder aos formulários de Adicionar e Visualizar.
            PnlNav.BringToFront();
            ShowSubMenu(Pnl_Sub_Clientes);
            PnlNav.Height = Btn_Clientes.Height;
            PnlNav.Top = Btn_Clientes.Top;
            Btn_Home.BackColor = Color.FromArgb(35, 48, 60);
            Btn_Clientes.BackColor = Color.FromArgb(24, 30, 40);
            Btn_Animais.BackColor = Color.FromArgb(35, 48, 60);
            Btn_Quartos.BackColor = Color.FromArgb(35, 48, 60);
        }

        private void Btn_Ver_Clientes_Click(object sender, EventArgs e)
        {
            //Código relativo ao botão Visualizar Clientes.
            Btn_Ver_Clientes.BackColor = Color.FromArgb(24, 30, 40);
            Btn_Ver_Clientes.ForeColor = Color.FromArgb(0, 126, 249);
            Btn_Add_Clientes.BackColor = Color.FromArgb(24, 30, 40);
            Btn_Add_Clientes.ForeColor = Color.WhiteSmoke;
            Btn_Ver_Animais.BackColor = Color.FromArgb(24, 30, 40);
            Btn_Ver_Animais.ForeColor = Color.WhiteSmoke;
            Btn_Add_Animais.BackColor = Color.FromArgb(24, 30, 40);
            Btn_Add_Animais.ForeColor = Color.WhiteSmoke;
            Btn_Ver_Quartos.BackColor = Color.FromArgb(24, 30, 40);
            Btn_Ver_Quartos.ForeColor = Color.WhiteSmoke;
            Btn_Add_Quartos.BackColor = Color.FromArgb(24, 30, 40);
            Btn_Add_Quartos.ForeColor = Color.WhiteSmoke;

            //Este código abre o subformulário, no caso o Visualizar Clientes, no panel Parent.
            openChildForm(new Clientes.Visualizar_Clientes());
        }

        private void Btn_Add_Clientes_Click(object sender, EventArgs e)
        {
            //Código relativo ao botão Visualizar Clientes.
            Btn_Ver_Clientes.BackColor = Color.FromArgb(24, 30, 40);
            Btn_Ver_Clientes.ForeColor = Color.WhiteSmoke;
            Btn_Add_Clientes.BackColor = Color.FromArgb(24, 30, 40);
            Btn_Add_Clientes.ForeColor = Color.FromArgb(0, 126, 249);
            Btn_Ver_Animais.BackColor = Color.FromArgb(24, 30, 40);
            Btn_Ver_Animais.ForeColor = Color.WhiteSmoke;
            Btn_Add_Animais.BackColor = Color.FromArgb(24, 30, 40);
            Btn_Add_Animais.ForeColor = Color.WhiteSmoke;
            Btn_Ver_Quartos.BackColor = Color.FromArgb(24, 30, 40);
            Btn_Ver_Quartos.ForeColor = Color.WhiteSmoke;
            Btn_Add_Quartos.BackColor = Color.FromArgb(24, 30, 40);
            Btn_Add_Quartos.ForeColor = Color.WhiteSmoke;

            //Este código abre o subformulário, no caso o Visualizar Clientes, no panel Parent.
            openChildForm(new Clientes.Adicionar_Cliente());
        }

        #endregion

        #region AnimaisSectionMethods

        private void Btn_Animais_Click(object sender, EventArgs e)
        {
            //Este código permite, no caso de fechado, abrir o subpanel dos clientes, para podermos aceder aos formulários de Adicionar e Visualizar.
            PnlNav.BringToFront();
            ShowSubMenu(Pnl_Sub_Animais);
            PnlNav.Height = Btn_Animais.Height;
            PnlNav.Top = Btn_Animais.Top;
            Btn_Home.BackColor = Color.FromArgb(35, 48, 60);
            Btn_Clientes.BackColor = Color.FromArgb(35, 48, 60);
            Btn_Animais.BackColor = Color.FromArgb(24, 30, 40);
            Btn_Quartos.BackColor = Color.FromArgb(35, 48, 60);
        }

        private void Btn_Ver_Animais_Click(object sender, EventArgs e)
        {
            //Código relativo ao botão Visualizar Clientes.
            Btn_Ver_Clientes.BackColor = Color.FromArgb(24, 30, 40);
            Btn_Ver_Clientes.ForeColor = Color.WhiteSmoke;
            Btn_Add_Clientes.BackColor = Color.FromArgb(24, 30, 40);
            Btn_Add_Clientes.ForeColor = Color.WhiteSmoke;
            Btn_Ver_Animais.BackColor = Color.FromArgb(24, 30, 40);
            Btn_Ver_Animais.ForeColor = Color.FromArgb(0, 126, 249);
            Btn_Add_Animais.BackColor = Color.FromArgb(24, 30, 40);
            Btn_Add_Animais.ForeColor = Color.WhiteSmoke;
            Btn_Ver_Quartos.BackColor = Color.FromArgb(24, 30, 40);
            Btn_Ver_Quartos.ForeColor = Color.WhiteSmoke;
            Btn_Add_Quartos.BackColor = Color.FromArgb(24, 30, 40);
            Btn_Add_Quartos.ForeColor = Color.WhiteSmoke;

            //Este código abre o subformulário, no caso o Visualizar Clientes, no panel Parent.
            openChildForm(new Animais.Visualizar_Animais());
        }

        private void Btn_Add_Animais_Click(object sender, EventArgs e)
        {
            //Código relativo ao botão Visualizar Clientes.
            Btn_Ver_Clientes.BackColor = Color.FromArgb(24, 30, 40);
            Btn_Ver_Clientes.ForeColor = Color.WhiteSmoke;
            Btn_Add_Clientes.BackColor = Color.FromArgb(24, 30, 40);
            Btn_Add_Clientes.ForeColor = Color.WhiteSmoke;
            Btn_Ver_Animais.BackColor = Color.FromArgb(24, 30, 40);
            Btn_Ver_Animais.ForeColor = Color.WhiteSmoke;
            Btn_Add_Animais.BackColor = Color.FromArgb(24, 30, 40);
            Btn_Add_Animais.ForeColor = Color.FromArgb(0, 126, 249);
            Btn_Ver_Quartos.BackColor = Color.FromArgb(24, 30, 40);
            Btn_Ver_Quartos.ForeColor = Color.WhiteSmoke;
            Btn_Add_Quartos.BackColor = Color.FromArgb(24, 30, 40);
            Btn_Add_Quartos.ForeColor = Color.WhiteSmoke;

            //Este código abre o subformulário, no caso o Visualizar Clientes, no panel Parent.
            openChildForm(new Animais.Adicionar_Animais());
        }

        #endregion

        #region QuartosSectionMethods

        private void Btn_Quartos_Click(object sender, EventArgs e)
        {
            //Este código permite, no caso de fechado, abrir o subpanel dos clientes, para podermos aceder aos formulários de Adicionar e Visualizar.
            PnlNav.BringToFront();
            ShowSubMenu(Pnl_Sub_Quartos);
            PnlNav.Height = Btn_Quartos.Height;
            PnlNav.Top = Btn_Quartos.Top;
            Btn_Home.BackColor = Color.FromArgb(35, 48, 60);
            Btn_Clientes.BackColor = Color.FromArgb(35, 48, 60);
            Btn_Animais.BackColor = Color.FromArgb(35, 48, 60);
            Btn_Quartos.BackColor = Color.FromArgb(24, 30, 40);
        }

        private void Btn_Ver_Quartos_Click(object sender, EventArgs e)
        {
            //Código relativo ao botão Visualizar Clientes.
            Btn_Ver_Clientes.BackColor = Color.FromArgb(24, 30, 40);
            Btn_Ver_Clientes.ForeColor = Color.WhiteSmoke;
            Btn_Add_Clientes.BackColor = Color.FromArgb(24, 30, 40);
            Btn_Add_Clientes.ForeColor = Color.WhiteSmoke;
            Btn_Ver_Animais.BackColor = Color.FromArgb(24, 30, 40);
            Btn_Ver_Animais.ForeColor = Color.WhiteSmoke;
            Btn_Add_Animais.BackColor = Color.FromArgb(24, 30, 40);
            Btn_Add_Animais.ForeColor = Color.WhiteSmoke;
            Btn_Ver_Quartos.BackColor = Color.FromArgb(24, 30, 40);
            Btn_Ver_Quartos.ForeColor = Color.FromArgb(0, 126, 249);
            Btn_Add_Quartos.BackColor = Color.FromArgb(24, 30, 40);
            Btn_Add_Quartos.ForeColor = Color.WhiteSmoke;

            //Este código abre o subformulário, no caso o Visualizar Clientes, no panel Parent.
            openChildForm(new Quartos.Visualizar_Quartos());
        }

        private void Btn_Add_Quartos_Click(object sender, EventArgs e)
        {
            //Código relativo ao botão Visualizar Clientes.
            Btn_Ver_Clientes.BackColor = Color.FromArgb(24, 30, 40);
            Btn_Ver_Clientes.ForeColor = Color.WhiteSmoke;
            Btn_Add_Clientes.BackColor = Color.FromArgb(24, 30, 40);
            Btn_Add_Clientes.ForeColor = Color.WhiteSmoke;
            Btn_Ver_Animais.BackColor = Color.FromArgb(24, 30, 40);
            Btn_Ver_Animais.ForeColor = Color.WhiteSmoke;
            Btn_Add_Animais.BackColor = Color.FromArgb(24, 30, 40);
            Btn_Add_Animais.ForeColor = Color.WhiteSmoke;
            Btn_Ver_Quartos.BackColor = Color.FromArgb(24, 30, 40);
            Btn_Ver_Quartos.ForeColor = Color.WhiteSmoke;
            Btn_Add_Quartos.BackColor = Color.FromArgb(24, 30, 40);
            Btn_Add_Quartos.ForeColor = Color.FromArgb(0, 126, 249);

            //Este código abre o subformulário, no caso o Visualizar Clientes, no panel Parent.
            openChildForm(new Quartos.Adicionar_Quartos());
        }

        #endregion

        #endregion
    }
}