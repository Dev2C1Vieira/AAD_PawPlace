﻿namespace PawPlace.Forms.Clientes
{
    partial class Visualizar_Clientes
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Visualizar_Clientes));
            this.Pnl_Principal = new System.Windows.Forms.Panel();
            this.Pnl_Btn_Fechar = new System.Windows.Forms.Panel();
            this.Pnl_Linha_Tabela = new System.Windows.Forms.Panel();
            this.Tabela_Dados = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pawPlaceDataSet_Clientes = new PawPlace.PawPlaceDataSet_Clientes();
            this.Pnl_Linha = new System.Windows.Forms.Panel();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.clienteTableAdapter = new PawPlace.PawPlaceDataSet_ClientesTableAdapters.ClienteTableAdapter();
            this.Lb_PaginaAtual = new System.Windows.Forms.Label();
            this.Txt_Pesquisar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Lb_Procurar = new System.Windows.Forms.Label();
            this.Cmb_Qnt_Entrys = new System.Windows.Forms.ComboBox();
            this.Btn_Avancar = new System.Windows.Forms.PictureBox();
            this.Btn_Retoceder = new System.Windows.Forms.PictureBox();
            this.Btn_Alterar = new System.Windows.Forms.PictureBox();
            this.Btn_Delete = new System.Windows.Forms.PictureBox();
            this.Btn_Fechar_Pesquisa = new System.Windows.Forms.PictureBox();
            this.Btn_Fechar = new System.Windows.Forms.PictureBox();
            this.Pnl_Principal.SuspendLayout();
            this.Pnl_Btn_Fechar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tabela_Dados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pawPlaceDataSet_Clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Avancar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Retoceder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Alterar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Fechar_Pesquisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Fechar)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_Principal
            // 
            this.Pnl_Principal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Pnl_Principal.Controls.Add(this.Cmb_Qnt_Entrys);
            this.Pnl_Principal.Controls.Add(this.Btn_Avancar);
            this.Pnl_Principal.Controls.Add(this.Btn_Retoceder);
            this.Pnl_Principal.Controls.Add(this.Lb_PaginaAtual);
            this.Pnl_Principal.Controls.Add(this.Btn_Alterar);
            this.Pnl_Principal.Controls.Add(this.Btn_Delete);
            this.Pnl_Principal.Controls.Add(this.Txt_Pesquisar);
            this.Pnl_Principal.Controls.Add(this.Btn_Fechar_Pesquisa);
            this.Pnl_Principal.Controls.Add(this.label2);
            this.Pnl_Principal.Controls.Add(this.label1);
            this.Pnl_Principal.Controls.Add(this.Lb_Procurar);
            this.Pnl_Principal.Controls.Add(this.Pnl_Btn_Fechar);
            this.Pnl_Principal.Controls.Add(this.Pnl_Linha_Tabela);
            this.Pnl_Principal.Controls.Add(this.Tabela_Dados);
            this.Pnl_Principal.Controls.Add(this.Pnl_Linha);
            this.Pnl_Principal.Controls.Add(this.Lbl_Titulo);
            this.Pnl_Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Principal.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Principal.Name = "Pnl_Principal";
            this.Pnl_Principal.Size = new System.Drawing.Size(3000, 1767);
            this.Pnl_Principal.TabIndex = 0;
            // 
            // Pnl_Btn_Fechar
            // 
            this.Pnl_Btn_Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl_Btn_Fechar.Controls.Add(this.Btn_Fechar);
            this.Pnl_Btn_Fechar.Location = new System.Drawing.Point(2882, 16);
            this.Pnl_Btn_Fechar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Pnl_Btn_Fechar.Name = "Pnl_Btn_Fechar";
            this.Pnl_Btn_Fechar.Size = new System.Drawing.Size(101, 74);
            this.Pnl_Btn_Fechar.TabIndex = 48;
            // 
            // Pnl_Linha_Tabela
            // 
            this.Pnl_Linha_Tabela.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl_Linha_Tabela.BackColor = System.Drawing.Color.Black;
            this.Pnl_Linha_Tabela.Location = new System.Drawing.Point(224, 683);
            this.Pnl_Linha_Tabela.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Pnl_Linha_Tabela.Name = "Pnl_Linha_Tabela";
            this.Pnl_Linha_Tabela.Size = new System.Drawing.Size(2512, 2);
            this.Pnl_Linha_Tabela.TabIndex = 46;
            // 
            // Tabela_Dados
            // 
            this.Tabela_Dados.AllowDrop = true;
            this.Tabela_Dados.AllowUserToOrderColumns = true;
            this.Tabela_Dados.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(48)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.Tabela_Dados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Tabela_Dados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tabela_Dados.AutoGenerateColumns = false;
            this.Tabela_Dados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Tabela_Dados.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.Tabela_Dados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tabela_Dados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Tabela_Dados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Tabela_Dados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Tabela_Dados.ColumnHeadersHeight = 40;
            this.Tabela_Dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Tabela_Dados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.Tabela_Dados.DataSource = this.clienteBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(48)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Tabela_Dados.DefaultCellStyle = dataGridViewCellStyle3;
            this.Tabela_Dados.EnableHeadersVisualStyles = false;
            this.Tabela_Dados.GridColor = System.Drawing.SystemColors.ControlLight;
            this.Tabela_Dados.Location = new System.Drawing.Point(227, 590);
            this.Tabela_Dados.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Tabela_Dados.Name = "Tabela_Dados";
            this.Tabela_Dados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(48)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Tabela_Dados.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Tabela_Dados.RowHeadersVisible = false;
            this.Tabela_Dados.RowHeadersWidth = 40;
            this.Tabela_Dados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(48)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.Tabela_Dados.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Tabela_Dados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Tabela_Dados.Size = new System.Drawing.Size(2512, 1000);
            this.Tabela_Dados.TabIndex = 45;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ID_Client";
            this.dataGridViewTextBoxColumn6.HeaderText = "ID_Client";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn7.HeaderText = "Name";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Data_Nascimento";
            this.dataGridViewTextBoxColumn8.HeaderText = "Data_Nascimento";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "NIF";
            this.dataGridViewTextBoxColumn9.HeaderText = "NIF";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "C_Cod_Postal";
            this.dataGridViewTextBoxColumn10.HeaderText = "C_Cod_Postal";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.pawPlaceDataSet_Clientes;
            // 
            // pawPlaceDataSet_Clientes
            // 
            this.pawPlaceDataSet_Clientes.DataSetName = "PawPlaceDataSet_Clientes";
            this.pawPlaceDataSet_Clientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Pnl_Linha
            // 
            this.Pnl_Linha.BackColor = System.Drawing.Color.Black;
            this.Pnl_Linha.Location = new System.Drawing.Point(227, 241);
            this.Pnl_Linha.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Pnl_Linha.Name = "Pnl_Linha";
            this.Pnl_Linha.Size = new System.Drawing.Size(1733, 7);
            this.Pnl_Linha.TabIndex = 40;
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Verdana", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.Location = new System.Drawing.Point(216, 169);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(658, 65);
            this.Lbl_Titulo.TabIndex = 0;
            this.Lbl_Titulo.Text = "Registos dos Clientes";
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // Lb_PaginaAtual
            // 
            this.Lb_PaginaAtual.AutoSize = true;
            this.Lb_PaginaAtual.Font = new System.Drawing.Font("Verdana", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_PaginaAtual.Location = new System.Drawing.Point(980, 486);
            this.Lb_PaginaAtual.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Lb_PaginaAtual.Name = "Lb_PaginaAtual";
            this.Lb_PaginaAtual.Size = new System.Drawing.Size(180, 41);
            this.Lb_PaginaAtual.TabIndex = 54;
            this.Lb_PaginaAtual.Text = "Página: 1";
            // 
            // Txt_Pesquisar
            // 
            this.Txt_Pesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Pesquisar.BackColor = System.Drawing.Color.White;
            this.Txt_Pesquisar.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Pesquisar.Location = new System.Drawing.Point(1844, 488);
            this.Txt_Pesquisar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Txt_Pesquisar.Multiline = true;
            this.Txt_Pesquisar.Name = "Txt_Pesquisar";
            this.Txt_Pesquisar.Size = new System.Drawing.Size(892, 54);
            this.Txt_Pesquisar.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(546, 489);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 41);
            this.label2.TabIndex = 58;
            this.label2.Text = "registros";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 489);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 41);
            this.label1.TabIndex = 57;
            this.label1.Text = "Mostrar";
            // 
            // Lb_Procurar
            // 
            this.Lb_Procurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lb_Procurar.AutoSize = true;
            this.Lb_Procurar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Procurar.Location = new System.Drawing.Point(1624, 485);
            this.Lb_Procurar.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Lb_Procurar.Name = "Lb_Procurar";
            this.Lb_Procurar.Size = new System.Drawing.Size(206, 48);
            this.Lb_Procurar.TabIndex = 56;
            this.Lb_Procurar.Text = "Procurar:";
            // 
            // Cmb_Qnt_Entrys
            // 
            this.Cmb_Qnt_Entrys.FormattingEnabled = true;
            this.Cmb_Qnt_Entrys.Location = new System.Drawing.Point(390, 495);
            this.Cmb_Qnt_Entrys.Name = "Cmb_Qnt_Entrys";
            this.Cmb_Qnt_Entrys.Size = new System.Drawing.Size(121, 39);
            this.Cmb_Qnt_Entrys.TabIndex = 65;
            // 
            // Btn_Avancar
            // 
            this.Btn_Avancar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Avancar.Image")));
            this.Btn_Avancar.Location = new System.Drawing.Point(1210, 479);
            this.Btn_Avancar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Btn_Avancar.Name = "Btn_Avancar";
            this.Btn_Avancar.Size = new System.Drawing.Size(112, 62);
            this.Btn_Avancar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_Avancar.TabIndex = 64;
            this.Btn_Avancar.TabStop = false;
            // 
            // Btn_Retoceder
            // 
            this.Btn_Retoceder.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Retoceder.Image")));
            this.Btn_Retoceder.Location = new System.Drawing.Point(840, 477);
            this.Btn_Retoceder.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Btn_Retoceder.Name = "Btn_Retoceder";
            this.Btn_Retoceder.Size = new System.Drawing.Size(112, 62);
            this.Btn_Retoceder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_Retoceder.TabIndex = 63;
            this.Btn_Retoceder.TabStop = false;
            // 
            // Btn_Alterar
            // 
            this.Btn_Alterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Alterar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Alterar.Image")));
            this.Btn_Alterar.Location = new System.Drawing.Point(2453, 325);
            this.Btn_Alterar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Btn_Alterar.Name = "Btn_Alterar";
            this.Btn_Alterar.Size = new System.Drawing.Size(133, 95);
            this.Btn_Alterar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_Alterar.TabIndex = 62;
            this.Btn_Alterar.TabStop = false;
            this.Btn_Alterar.Click += new System.EventHandler(this.Btn_Alterar_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Delete.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Delete.Image")));
            this.Btn_Delete.Location = new System.Drawing.Point(2603, 320);
            this.Btn_Delete.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(133, 95);
            this.Btn_Delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_Delete.TabIndex = 61;
            this.Btn_Delete.TabStop = false;
            // 
            // Btn_Fechar_Pesquisa
            // 
            this.Btn_Fechar_Pesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Fechar_Pesquisa.BackColor = System.Drawing.Color.White;
            this.Btn_Fechar_Pesquisa.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Fechar_Pesquisa.Image")));
            this.Btn_Fechar_Pesquisa.Location = new System.Drawing.Point(4138, 417);
            this.Btn_Fechar_Pesquisa.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Btn_Fechar_Pesquisa.Name = "Btn_Fechar_Pesquisa";
            this.Btn_Fechar_Pesquisa.Size = new System.Drawing.Size(56, 48);
            this.Btn_Fechar_Pesquisa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_Fechar_Pesquisa.TabIndex = 59;
            this.Btn_Fechar_Pesquisa.TabStop = false;
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
            // Visualizar_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3000, 1767);
            this.Controls.Add(this.Pnl_Principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Visualizar_Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar_Clientes";
            this.Load += new System.EventHandler(this.Visualizar_Clientes_Load);
            this.Pnl_Principal.ResumeLayout(false);
            this.Pnl_Principal.PerformLayout();
            this.Pnl_Btn_Fechar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Tabela_Dados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pawPlaceDataSet_Clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Avancar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Retoceder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Alterar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Fechar_Pesquisa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Fechar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Principal;
        private System.Windows.Forms.Panel Pnl_Linha;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCodPostalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel Pnl_Linha_Tabela;
        public System.Windows.Forms.DataGridView Tabela_Dados;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Panel Pnl_Btn_Fechar;
        private System.Windows.Forms.PictureBox Btn_Fechar;
        private PawPlaceDataSet_Clientes pawPlaceDataSet_Clientes;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private PawPlaceDataSet_ClientesTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.PictureBox Btn_Avancar;
        private System.Windows.Forms.PictureBox Btn_Retoceder;
        private System.Windows.Forms.Label Lb_PaginaAtual;
        private System.Windows.Forms.PictureBox Btn_Alterar;
        private System.Windows.Forms.PictureBox Btn_Delete;
        private System.Windows.Forms.TextBox Txt_Pesquisar;
        private System.Windows.Forms.PictureBox Btn_Fechar_Pesquisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lb_Procurar;
        private System.Windows.Forms.ComboBox Cmb_Qnt_Entrys;
    }
}