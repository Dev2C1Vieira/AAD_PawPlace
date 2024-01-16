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
            this.Txt_Localidade = new System.Windows.Forms.TextBox();
            this.Lbl_Localidade = new System.Windows.Forms.Label();
            this.Cmb_CodPostal = new System.Windows.Forms.ComboBox();
            this.DTP_DataNascimento = new System.Windows.Forms.DateTimePicker();
            this.Txt_NIF = new System.Windows.Forms.TextBox();
            this.Lb_NIF = new System.Windows.Forms.Label();
            this.Lb_Localidade = new System.Windows.Forms.Label();
            this.Lb_DataNascimento = new System.Windows.Forms.Label();
            this.Lb_NomeCompleto = new System.Windows.Forms.Label();
            this.Txt_NomeCliente = new System.Windows.Forms.TextBox();
            this.Btn_Limpar = new System.Windows.Forms.PictureBox();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Pnl_Linha_Titulo = new System.Windows.Forms.Panel();
            this.Lb_Titulo = new System.Windows.Forms.Label();
            this.Pnl_Principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Limpar)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_Principal
            // 
            this.Pnl_Principal.Controls.Add(this.Txt_Localidade);
            this.Pnl_Principal.Controls.Add(this.Lbl_Localidade);
            this.Pnl_Principal.Controls.Add(this.Cmb_CodPostal);
            this.Pnl_Principal.Controls.Add(this.DTP_DataNascimento);
            this.Pnl_Principal.Controls.Add(this.Txt_NIF);
            this.Pnl_Principal.Controls.Add(this.Lb_NIF);
            this.Pnl_Principal.Controls.Add(this.Lb_Localidade);
            this.Pnl_Principal.Controls.Add(this.Lb_DataNascimento);
            this.Pnl_Principal.Controls.Add(this.Lb_NomeCompleto);
            this.Pnl_Principal.Controls.Add(this.Txt_NomeCliente);
            this.Pnl_Principal.Controls.Add(this.Btn_Limpar);
            this.Pnl_Principal.Controls.Add(this.Btn_Add);
            this.Pnl_Principal.Controls.Add(this.Pnl_Linha_Titulo);
            this.Pnl_Principal.Controls.Add(this.Lb_Titulo);
            this.Pnl_Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Principal.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Principal.Name = "Pnl_Principal";
            this.Pnl_Principal.Size = new System.Drawing.Size(2200, 1500);
            this.Pnl_Principal.TabIndex = 0;
            // 
            // Txt_Localidade
            // 
            this.Txt_Localidade.BackColor = System.Drawing.Color.White;
            this.Txt_Localidade.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Localidade.ForeColor = System.Drawing.Color.Black;
            this.Txt_Localidade.Location = new System.Drawing.Point(682, 630);
            this.Txt_Localidade.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Txt_Localidade.Multiline = true;
            this.Txt_Localidade.Name = "Txt_Localidade";
            this.Txt_Localidade.ReadOnly = true;
            this.Txt_Localidade.Size = new System.Drawing.Size(857, 47);
            this.Txt_Localidade.TabIndex = 105;
            this.Txt_Localidade.UseWaitCursor = true;
            // 
            // Lbl_Localidade
            // 
            this.Lbl_Localidade.AutoSize = true;
            this.Lbl_Localidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lbl_Localidade.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Localidade.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Localidade.Location = new System.Drawing.Point(138, 630);
            this.Lbl_Localidade.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Lbl_Localidade.Name = "Lbl_Localidade";
            this.Lbl_Localidade.Size = new System.Drawing.Size(211, 41);
            this.Lbl_Localidade.TabIndex = 104;
            this.Lbl_Localidade.Text = "Localidade:";
            this.Lbl_Localidade.UseWaitCursor = true;
            // 
            // Cmb_CodPostal
            // 
            this.Cmb_CodPostal.FormattingEnabled = true;
            this.Cmb_CodPostal.Location = new System.Drawing.Point(682, 538);
            this.Cmb_CodPostal.Name = "Cmb_CodPostal";
            this.Cmb_CodPostal.Size = new System.Drawing.Size(857, 39);
            this.Cmb_CodPostal.TabIndex = 103;
            this.Cmb_CodPostal.SelectionChangeCommitted += new System.EventHandler(this.Cmb_CodPostal_SelectionChangeCommitted);
            // 
            // DTP_DataNascimento
            // 
            this.DTP_DataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_DataNascimento.Location = new System.Drawing.Point(679, 337);
            this.DTP_DataNascimento.Name = "DTP_DataNascimento";
            this.DTP_DataNascimento.Size = new System.Drawing.Size(857, 38);
            this.DTP_DataNascimento.TabIndex = 102;
            // 
            // Txt_NIF
            // 
            this.Txt_NIF.BackColor = System.Drawing.Color.White;
            this.Txt_NIF.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NIF.ForeColor = System.Drawing.Color.Black;
            this.Txt_NIF.Location = new System.Drawing.Point(682, 436);
            this.Txt_NIF.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Txt_NIF.Multiline = true;
            this.Txt_NIF.Name = "Txt_NIF";
            this.Txt_NIF.Size = new System.Drawing.Size(857, 47);
            this.Txt_NIF.TabIndex = 101;
            this.Txt_NIF.UseWaitCursor = true;
            // 
            // Lb_NIF
            // 
            this.Lb_NIF.AutoSize = true;
            this.Lb_NIF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_NIF.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_NIF.ForeColor = System.Drawing.Color.Black;
            this.Lb_NIF.Location = new System.Drawing.Point(138, 436);
            this.Lb_NIF.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Lb_NIF.Name = "Lb_NIF";
            this.Lb_NIF.Size = new System.Drawing.Size(92, 41);
            this.Lb_NIF.TabIndex = 99;
            this.Lb_NIF.Text = "NIF:";
            this.Lb_NIF.UseWaitCursor = true;
            // 
            // Lb_Localidade
            // 
            this.Lb_Localidade.AutoSize = true;
            this.Lb_Localidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_Localidade.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Localidade.ForeColor = System.Drawing.Color.Black;
            this.Lb_Localidade.Location = new System.Drawing.Point(138, 534);
            this.Lb_Localidade.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Lb_Localidade.Name = "Lb_Localidade";
            this.Lb_Localidade.Size = new System.Drawing.Size(263, 41);
            this.Lb_Localidade.TabIndex = 100;
            this.Lb_Localidade.Text = "Código Postal:";
            this.Lb_Localidade.UseWaitCursor = true;
            // 
            // Lb_DataNascimento
            // 
            this.Lb_DataNascimento.AutoSize = true;
            this.Lb_DataNascimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_DataNascimento.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_DataNascimento.ForeColor = System.Drawing.Color.Black;
            this.Lb_DataNascimento.Location = new System.Drawing.Point(138, 334);
            this.Lb_DataNascimento.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Lb_DataNascimento.Name = "Lb_DataNascimento";
            this.Lb_DataNascimento.Size = new System.Drawing.Size(376, 41);
            this.Lb_DataNascimento.TabIndex = 98;
            this.Lb_DataNascimento.Text = "Data de Nascimento:";
            this.Lb_DataNascimento.UseWaitCursor = true;
            // 
            // Lb_NomeCompleto
            // 
            this.Lb_NomeCompleto.AutoSize = true;
            this.Lb_NomeCompleto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_NomeCompleto.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_NomeCompleto.ForeColor = System.Drawing.Color.Black;
            this.Lb_NomeCompleto.Location = new System.Drawing.Point(138, 237);
            this.Lb_NomeCompleto.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Lb_NomeCompleto.Name = "Lb_NomeCompleto";
            this.Lb_NomeCompleto.Size = new System.Drawing.Size(306, 41);
            this.Lb_NomeCompleto.TabIndex = 97;
            this.Lb_NomeCompleto.Text = "Nome Completo:";
            this.Lb_NomeCompleto.UseWaitCursor = true;
            // 
            // Txt_NomeCliente
            // 
            this.Txt_NomeCliente.BackColor = System.Drawing.Color.White;
            this.Txt_NomeCliente.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NomeCliente.ForeColor = System.Drawing.Color.Black;
            this.Txt_NomeCliente.Location = new System.Drawing.Point(682, 234);
            this.Txt_NomeCliente.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Txt_NomeCliente.Multiline = true;
            this.Txt_NomeCliente.Name = "Txt_NomeCliente";
            this.Txt_NomeCliente.Size = new System.Drawing.Size(857, 47);
            this.Txt_NomeCliente.TabIndex = 94;
            this.Txt_NomeCliente.UseWaitCursor = true;
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
            this.Btn_Limpar.Click += new System.EventHandler(this.Btn_Limpar_Click);
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
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
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
            // Adicionar_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(2200, 1500);
            this.Controls.Add(this.Pnl_Principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Adicionar_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar_Cliente";
            this.Load += new System.EventHandler(this.Adicionar_Cliente_Load);
            this.Pnl_Principal.ResumeLayout(false);
            this.Pnl_Principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Limpar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Principal;
        private System.Windows.Forms.PictureBox Btn_Limpar;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Panel Pnl_Linha_Titulo;
        private System.Windows.Forms.Label Lb_Titulo;
        private System.Windows.Forms.DateTimePicker DTP_DataNascimento;
        public System.Windows.Forms.TextBox Txt_NIF;
        private System.Windows.Forms.Label Lb_NIF;
        private System.Windows.Forms.Label Lb_Localidade;
        private System.Windows.Forms.Label Lb_DataNascimento;
        private System.Windows.Forms.Label Lb_NomeCompleto;
        public System.Windows.Forms.TextBox Txt_NomeCliente;
        private System.Windows.Forms.ComboBox Cmb_CodPostal;
        private System.Windows.Forms.Label Lbl_Localidade;
        public System.Windows.Forms.TextBox Txt_Localidade;
    }
}