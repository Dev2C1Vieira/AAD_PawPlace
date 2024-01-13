using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PawPlace.Forms.Entrada
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();


            //Costumizar o form menu.
            PnlNav.Height = Btn_Home.Height;
            PnlNav.Top = Btn_Home.Top;
            PnlNav.Left = Btn_Home.Left;
            Btn_Home.BackColor = Color.FromArgb(24, 30, 40);
        }

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

        private void Btn_Home_Click(object sender, EventArgs e)
        {
            Forms.Entrada.Menu menu = new Forms.Entrada.Menu();
            menu.Show();
            this.Hide();
        }

        private void Btn_ViewClientes_Click(object sender, EventArgs e)
        {
            //Este código permite aceder aos formulário de Visualizar Clientes.
            PnlNav.BringToFront();
            PnlNav.Height = Btn_ViewClientes.Height;
            PnlNav.Top = Btn_ViewClientes.Top;

            Btn_Home.BackColor = Color.FromArgb(35, 48, 60);
            Btn_ViewClientes.BackColor = Color.FromArgb(24, 30, 40);
            Btn_ViewAnimais.BackColor = Color.FromArgb(35, 48, 60);
            Btn_View_Quartos.BackColor = Color.FromArgb(35, 48, 60);

            //Este código abre o subformulário, no caso o Visualizar Clientes, no panel Parent.
            openChildForm(new Clientes.Visualizar_Clientes());
        }

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
    }
}