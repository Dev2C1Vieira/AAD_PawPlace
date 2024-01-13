namespace PawPlace.Forms.Clientes
{
    partial class Adicionar_Cliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adicionar_Cliente));
            this.Pnl_Principal = new System.Windows.Forms.Panel();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Mskd_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.Pnl_Linha_Titulo = new System.Windows.Forms.Panel();
            this.Mskd_Cod_Postal = new System.Windows.Forms.MaskedTextBox();
            this.Lb_Titulo = new System.Windows.Forms.Label();
            this.Txt_Contribuinte = new System.Windows.Forms.TextBox();
            this.Lb_ID = new System.Windows.Forms.Label();
            this.Lb_Contribuinte = new System.Windows.Forms.Label();
            this.Txt_ID = new System.Windows.Forms.TextBox();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.Txt_NomeCliente = new System.Windows.Forms.TextBox();
            this.Lb_Email = new System.Windows.Forms.Label();
            this.Lb_NomeCompleto = new System.Windows.Forms.Label();
            this.Lb_Telefone = new System.Windows.Forms.Label();
            this.Txt_Morada = new System.Windows.Forms.TextBox();
            this.Txt_Localidade = new System.Windows.Forms.TextBox();
            this.Lb_Morada = new System.Windows.Forms.Label();
            this.Lb_Localidade = new System.Windows.Forms.Label();
            this.Lb_Cod_Postal = new System.Windows.Forms.Label();
            this.Btn_Limpar = new System.Windows.Forms.PictureBox();
            this.Pnl_Btn_Fechar = new System.Windows.Forms.Panel();
            this.Btn_Fechar = new System.Windows.Forms.PictureBox();
            this.Pnl_Principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Limpar)).BeginInit();
            this.Pnl_Btn_Fechar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Fechar)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_Principal
            // 
            this.Pnl_Principal.Controls.Add(this.Pnl_Btn_Fechar);
            this.Pnl_Principal.Controls.Add(this.Btn_Limpar);
            this.Pnl_Principal.Controls.Add(this.Btn_Add);
            this.Pnl_Principal.Controls.Add(this.Mskd_Telefone);
            this.Pnl_Principal.Controls.Add(this.Pnl_Linha_Titulo);
            this.Pnl_Principal.Controls.Add(this.Mskd_Cod_Postal);
            this.Pnl_Principal.Controls.Add(this.Lb_Titulo);
            this.Pnl_Principal.Controls.Add(this.Txt_Contribuinte);
            this.Pnl_Principal.Controls.Add(this.Lb_ID);
            this.Pnl_Principal.Controls.Add(this.Lb_Contribuinte);
            this.Pnl_Principal.Controls.Add(this.Txt_ID);
            this.Pnl_Principal.Controls.Add(this.Txt_Email);
            this.Pnl_Principal.Controls.Add(this.Txt_NomeCliente);
            this.Pnl_Principal.Controls.Add(this.Lb_Email);
            this.Pnl_Principal.Controls.Add(this.Lb_NomeCompleto);
            this.Pnl_Principal.Controls.Add(this.Lb_Telefone);
            this.Pnl_Principal.Controls.Add(this.Txt_Morada);
            this.Pnl_Principal.Controls.Add(this.Txt_Localidade);
            this.Pnl_Principal.Controls.Add(this.Lb_Morada);
            this.Pnl_Principal.Controls.Add(this.Lb_Localidade);
            this.Pnl_Principal.Controls.Add(this.Lb_Cod_Postal);
            this.Pnl_Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Principal.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Principal.Name = "Pnl_Principal";
            this.Pnl_Principal.Size = new System.Drawing.Size(2450, 2000);
            this.Pnl_Principal.TabIndex = 0;
            // 
            // Btn_Add
            // 
            this.Btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(48)))), ((int)(((byte)(60)))));
            this.Btn_Add.FlatAppearance.BorderSize = 0;
            this.Btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Add.ForeColor = System.Drawing.Color.White;
            this.Btn_Add.Location = new System.Drawing.Point(112, 1063);
            this.Btn_Add.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(443, 105);
            this.Btn_Add.TabIndex = 51;
            this.Btn_Add.Text = "Adicionar";
            this.Btn_Add.UseVisualStyleBackColor = false;
            // 
            // Mskd_Telefone
            // 
            this.Mskd_Telefone.BackColor = System.Drawing.Color.White;
            this.Mskd_Telefone.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mskd_Telefone.ForeColor = System.Drawing.Color.Black;
            this.Mskd_Telefone.Location = new System.Drawing.Point(653, 717);
            this.Mskd_Telefone.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Mskd_Telefone.Mask = "### - ### - ###";
            this.Mskd_Telefone.Name = "Mskd_Telefone";
            this.Mskd_Telefone.Size = new System.Drawing.Size(857, 48);
            this.Mskd_Telefone.TabIndex = 48;
            // 
            // Pnl_Linha_Titulo
            // 
            this.Pnl_Linha_Titulo.BackColor = System.Drawing.Color.Black;
            this.Pnl_Linha_Titulo.Location = new System.Drawing.Point(114, 144);
            this.Pnl_Linha_Titulo.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Pnl_Linha_Titulo.Name = "Pnl_Linha_Titulo";
            this.Pnl_Linha_Titulo.Size = new System.Drawing.Size(1733, 7);
            this.Pnl_Linha_Titulo.TabIndex = 54;
            // 
            // Mskd_Cod_Postal
            // 
            this.Mskd_Cod_Postal.BackColor = System.Drawing.Color.White;
            this.Mskd_Cod_Postal.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mskd_Cod_Postal.ForeColor = System.Drawing.Color.Black;
            this.Mskd_Cod_Postal.Location = new System.Drawing.Point(653, 521);
            this.Mskd_Cod_Postal.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Mskd_Cod_Postal.Mask = "#### - ###";
            this.Mskd_Cod_Postal.Name = "Mskd_Cod_Postal";
            this.Mskd_Cod_Postal.Size = new System.Drawing.Size(857, 48);
            this.Mskd_Cod_Postal.TabIndex = 46;
            // 
            // Lb_Titulo
            // 
            this.Lb_Titulo.AutoSize = true;
            this.Lb_Titulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_Titulo.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Titulo.ForeColor = System.Drawing.Color.Black;
            this.Lb_Titulo.Location = new System.Drawing.Point(101, 75);
            this.Lb_Titulo.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Lb_Titulo.Name = "Lb_Titulo";
            this.Lb_Titulo.Size = new System.Drawing.Size(638, 57);
            this.Lb_Titulo.TabIndex = 53;
            this.Lb_Titulo.Text = "Informações do Cliente";
            // 
            // Txt_Contribuinte
            // 
            this.Txt_Contribuinte.BackColor = System.Drawing.Color.White;
            this.Txt_Contribuinte.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Contribuinte.ForeColor = System.Drawing.Color.Black;
            this.Txt_Contribuinte.Location = new System.Drawing.Point(653, 910);
            this.Txt_Contribuinte.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Txt_Contribuinte.Multiline = true;
            this.Txt_Contribuinte.Name = "Txt_Contribuinte";
            this.Txt_Contribuinte.Size = new System.Drawing.Size(857, 47);
            this.Txt_Contribuinte.TabIndex = 50;
            // 
            // Lb_ID
            // 
            this.Lb_ID.AutoSize = true;
            this.Lb_ID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_ID.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_ID.ForeColor = System.Drawing.Color.Black;
            this.Lb_ID.Location = new System.Drawing.Point(106, 221);
            this.Lb_ID.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Lb_ID.Name = "Lb_ID";
            this.Lb_ID.Size = new System.Drawing.Size(345, 41);
            this.Lb_ID.TabIndex = 52;
            this.Lb_ID.Text = "Código do Cliente: ";
            // 
            // Lb_Contribuinte
            // 
            this.Lb_Contribuinte.AutoSize = true;
            this.Lb_Contribuinte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_Contribuinte.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Contribuinte.ForeColor = System.Drawing.Color.Black;
            this.Lb_Contribuinte.Location = new System.Drawing.Point(112, 922);
            this.Lb_Contribuinte.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Lb_Contribuinte.Name = "Lb_Contribuinte";
            this.Lb_Contribuinte.Size = new System.Drawing.Size(244, 41);
            this.Lb_Contribuinte.TabIndex = 61;
            this.Lb_Contribuinte.Text = "Contribuinte:";
            // 
            // Txt_ID
            // 
            this.Txt_ID.BackColor = System.Drawing.Color.White;
            this.Txt_ID.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ID.ForeColor = System.Drawing.Color.Black;
            this.Txt_ID.Location = new System.Drawing.Point(653, 216);
            this.Txt_ID.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Txt_ID.Multiline = true;
            this.Txt_ID.Name = "Txt_ID";
            this.Txt_ID.Size = new System.Drawing.Size(857, 47);
            this.Txt_ID.TabIndex = 43;
            // 
            // Txt_Email
            // 
            this.Txt_Email.BackColor = System.Drawing.Color.White;
            this.Txt_Email.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Email.ForeColor = System.Drawing.Color.Black;
            this.Txt_Email.Location = new System.Drawing.Point(653, 812);
            this.Txt_Email.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Txt_Email.Multiline = true;
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(857, 47);
            this.Txt_Email.TabIndex = 49;
            // 
            // Txt_NomeCliente
            // 
            this.Txt_NomeCliente.BackColor = System.Drawing.Color.White;
            this.Txt_NomeCliente.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NomeCliente.ForeColor = System.Drawing.Color.Black;
            this.Txt_NomeCliente.Location = new System.Drawing.Point(653, 316);
            this.Txt_NomeCliente.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Txt_NomeCliente.Multiline = true;
            this.Txt_NomeCliente.Name = "Txt_NomeCliente";
            this.Txt_NomeCliente.Size = new System.Drawing.Size(857, 47);
            this.Txt_NomeCliente.TabIndex = 44;
            // 
            // Lb_Email
            // 
            this.Lb_Email.AutoSize = true;
            this.Lb_Email.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_Email.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Email.ForeColor = System.Drawing.Color.Black;
            this.Lb_Email.Location = new System.Drawing.Point(114, 815);
            this.Lb_Email.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Lb_Email.Name = "Lb_Email";
            this.Lb_Email.Size = new System.Drawing.Size(126, 41);
            this.Lb_Email.TabIndex = 60;
            this.Lb_Email.Text = "Email:";
            // 
            // Lb_NomeCompleto
            // 
            this.Lb_NomeCompleto.AutoSize = true;
            this.Lb_NomeCompleto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_NomeCompleto.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_NomeCompleto.ForeColor = System.Drawing.Color.Black;
            this.Lb_NomeCompleto.Location = new System.Drawing.Point(109, 319);
            this.Lb_NomeCompleto.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Lb_NomeCompleto.Name = "Lb_NomeCompleto";
            this.Lb_NomeCompleto.Size = new System.Drawing.Size(306, 41);
            this.Lb_NomeCompleto.TabIndex = 55;
            this.Lb_NomeCompleto.Text = "Nome Completo:";
            // 
            // Lb_Telefone
            // 
            this.Lb_Telefone.AutoSize = true;
            this.Lb_Telefone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_Telefone.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Telefone.ForeColor = System.Drawing.Color.Black;
            this.Lb_Telefone.Location = new System.Drawing.Point(109, 717);
            this.Lb_Telefone.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Lb_Telefone.Name = "Lb_Telefone";
            this.Lb_Telefone.Size = new System.Drawing.Size(174, 41);
            this.Lb_Telefone.TabIndex = 59;
            this.Lb_Telefone.Text = "Telefone:";
            // 
            // Txt_Morada
            // 
            this.Txt_Morada.BackColor = System.Drawing.Color.White;
            this.Txt_Morada.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Morada.ForeColor = System.Drawing.Color.Black;
            this.Txt_Morada.Location = new System.Drawing.Point(653, 416);
            this.Txt_Morada.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Txt_Morada.Multiline = true;
            this.Txt_Morada.Name = "Txt_Morada";
            this.Txt_Morada.Size = new System.Drawing.Size(857, 47);
            this.Txt_Morada.TabIndex = 45;
            // 
            // Txt_Localidade
            // 
            this.Txt_Localidade.BackColor = System.Drawing.Color.White;
            this.Txt_Localidade.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Localidade.ForeColor = System.Drawing.Color.Black;
            this.Txt_Localidade.Location = new System.Drawing.Point(653, 617);
            this.Txt_Localidade.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Txt_Localidade.Multiline = true;
            this.Txt_Localidade.Name = "Txt_Localidade";
            this.Txt_Localidade.Size = new System.Drawing.Size(857, 47);
            this.Txt_Localidade.TabIndex = 47;
            // 
            // Lb_Morada
            // 
            this.Lb_Morada.AutoSize = true;
            this.Lb_Morada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_Morada.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Morada.ForeColor = System.Drawing.Color.Black;
            this.Lb_Morada.Location = new System.Drawing.Point(112, 419);
            this.Lb_Morada.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Lb_Morada.Name = "Lb_Morada";
            this.Lb_Morada.Size = new System.Drawing.Size(158, 41);
            this.Lb_Morada.TabIndex = 56;
            this.Lb_Morada.Text = "Morada:";
            // 
            // Lb_Localidade
            // 
            this.Lb_Localidade.AutoSize = true;
            this.Lb_Localidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_Localidade.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Localidade.ForeColor = System.Drawing.Color.Black;
            this.Lb_Localidade.Location = new System.Drawing.Point(109, 619);
            this.Lb_Localidade.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Lb_Localidade.Name = "Lb_Localidade";
            this.Lb_Localidade.Size = new System.Drawing.Size(211, 41);
            this.Lb_Localidade.TabIndex = 58;
            this.Lb_Localidade.Text = "Localidade:";
            // 
            // Lb_Cod_Postal
            // 
            this.Lb_Cod_Postal.AutoSize = true;
            this.Lb_Cod_Postal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_Cod_Postal.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Cod_Postal.ForeColor = System.Drawing.Color.Black;
            this.Lb_Cod_Postal.Location = new System.Drawing.Point(109, 521);
            this.Lb_Cod_Postal.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Lb_Cod_Postal.Name = "Lb_Cod_Postal";
            this.Lb_Cod_Postal.Size = new System.Drawing.Size(263, 41);
            this.Lb_Cod_Postal.TabIndex = 57;
            this.Lb_Cod_Postal.Text = "Código Postal:";
            // 
            // Btn_Limpar
            // 
            this.Btn_Limpar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Limpar.Image")));
            this.Btn_Limpar.Location = new System.Drawing.Point(1752, 195);
            this.Btn_Limpar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Btn_Limpar.Name = "Btn_Limpar";
            this.Btn_Limpar.Size = new System.Drawing.Size(93, 83);
            this.Btn_Limpar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_Limpar.TabIndex = 62;
            this.Btn_Limpar.TabStop = false;
            // 
            // Pnl_Btn_Fechar
            // 
            this.Pnl_Btn_Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl_Btn_Fechar.Controls.Add(this.Btn_Fechar);
            this.Pnl_Btn_Fechar.Location = new System.Drawing.Point(2332, 16);
            this.Pnl_Btn_Fechar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Pnl_Btn_Fechar.Name = "Pnl_Btn_Fechar";
            this.Pnl_Btn_Fechar.Size = new System.Drawing.Size(101, 74);
            this.Pnl_Btn_Fechar.TabIndex = 63;
            // 
            // Btn_Fechar
            // 
            this.Btn_Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Fechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Fechar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Fechar.Image")));
            this.Btn_Fechar.Location = new System.Drawing.Point(24, 12);
            this.Btn_Fechar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Btn_Fechar.Name = "Btn_Fechar";
            this.Btn_Fechar.Size = new System.Drawing.Size(53, 48);
            this.Btn_Fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_Fechar.TabIndex = 0;
            this.Btn_Fechar.TabStop = false;
            this.Btn_Fechar.Click += new System.EventHandler(this.Btn_Fechar_Click);
            // 
            // Adicionar_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2450, 2000);
            this.Controls.Add(this.Pnl_Principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Adicionar_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar_Cliente";
            this.Pnl_Principal.ResumeLayout(false);
            this.Pnl_Principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Limpar)).EndInit();
            this.Pnl_Btn_Fechar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Fechar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Principal;
        private System.Windows.Forms.PictureBox Btn_Limpar;
        private System.Windows.Forms.Button Btn_Add;
        public System.Windows.Forms.MaskedTextBox Mskd_Telefone;
        private System.Windows.Forms.Panel Pnl_Linha_Titulo;
        public System.Windows.Forms.MaskedTextBox Mskd_Cod_Postal;
        private System.Windows.Forms.Label Lb_Titulo;
        public System.Windows.Forms.TextBox Txt_Contribuinte;
        private System.Windows.Forms.Label Lb_ID;
        private System.Windows.Forms.Label Lb_Contribuinte;
        public System.Windows.Forms.TextBox Txt_ID;
        public System.Windows.Forms.TextBox Txt_Email;
        public System.Windows.Forms.TextBox Txt_NomeCliente;
        private System.Windows.Forms.Label Lb_Email;
        private System.Windows.Forms.Label Lb_NomeCompleto;
        private System.Windows.Forms.Label Lb_Telefone;
        public System.Windows.Forms.TextBox Txt_Morada;
        public System.Windows.Forms.TextBox Txt_Localidade;
        private System.Windows.Forms.Label Lb_Morada;
        private System.Windows.Forms.Label Lb_Localidade;
        private System.Windows.Forms.Label Lb_Cod_Postal;
        private System.Windows.Forms.Panel Pnl_Btn_Fechar;
        private System.Windows.Forms.PictureBox Btn_Fechar;
    }
}