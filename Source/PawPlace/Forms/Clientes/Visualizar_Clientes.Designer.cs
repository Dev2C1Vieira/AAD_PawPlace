namespace PawPlace.Forms.Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Visualizar_Clientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Pnl_Principal = new System.Windows.Forms.Panel();
            this.Pnl_Btn_Fechar = new System.Windows.Forms.Panel();
            this.Btn_Fechar = new System.Windows.Forms.PictureBox();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Pnl_Linha_Tabela = new System.Windows.Forms.Panel();
            this.Tabela_Dados = new System.Windows.Forms.DataGridView();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Pnl_Linha = new System.Windows.Forms.Panel();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.pawPlaceDataSet_Clientes = new PawPlace.PawPlaceDataSet_Clientes();
            this.clienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new PawPlace.PawPlaceDataSet_ClientesTableAdapters.ClienteTableAdapter();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pnl_Principal.SuspendLayout();
            this.Pnl_Btn_Fechar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Fechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabela_Dados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pawPlaceDataSet_Clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_Principal
            // 
            this.Pnl_Principal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Pnl_Principal.Controls.Add(this.Pnl_Btn_Fechar);
            this.Pnl_Principal.Controls.Add(this.Btn_Add);
            this.Pnl_Principal.Controls.Add(this.Pnl_Linha_Tabela);
            this.Pnl_Principal.Controls.Add(this.Tabela_Dados);
            this.Pnl_Principal.Controls.Add(this.Pnl_Linha);
            this.Pnl_Principal.Controls.Add(this.Lbl_Titulo);
            this.Pnl_Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Principal.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Principal.Name = "Pnl_Principal";
            this.Pnl_Principal.Size = new System.Drawing.Size(2288, 1767);
            this.Pnl_Principal.TabIndex = 0;
            // 
            // Pnl_Btn_Fechar
            // 
            this.Pnl_Btn_Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl_Btn_Fechar.Controls.Add(this.Btn_Fechar);
            this.Pnl_Btn_Fechar.Location = new System.Drawing.Point(2170, 16);
            this.Pnl_Btn_Fechar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Pnl_Btn_Fechar.Name = "Pnl_Btn_Fechar";
            this.Pnl_Btn_Fechar.Size = new System.Drawing.Size(101, 74);
            this.Pnl_Btn_Fechar.TabIndex = 48;
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
            // Btn_Add
            // 
            this.Btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(48)))), ((int)(((byte)(60)))));
            this.Btn_Add.FlatAppearance.BorderSize = 0;
            this.Btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Add.ForeColor = System.Drawing.Color.White;
            this.Btn_Add.Location = new System.Drawing.Point(1524, 1565);
            this.Btn_Add.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(500, 105);
            this.Btn_Add.TabIndex = 47;
            this.Btn_Add.Text = "Adicionar Cliente";
            this.Btn_Add.UseVisualStyleBackColor = false;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Pnl_Linha_Tabela
            // 
            this.Pnl_Linha_Tabela.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl_Linha_Tabela.BackColor = System.Drawing.Color.Black;
            this.Pnl_Linha_Tabela.Location = new System.Drawing.Point(224, 621);
            this.Pnl_Linha_Tabela.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Pnl_Linha_Tabela.Name = "Pnl_Linha_Tabela";
            this.Pnl_Linha_Tabela.Size = new System.Drawing.Size(1800, 2);
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
            this.Tabela_Dados.DataSource = this.clienteBindingSource1;
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
            this.Tabela_Dados.Location = new System.Drawing.Point(227, 528);
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
            this.Tabela_Dados.Size = new System.Drawing.Size(1800, 1000);
            this.Tabela_Dados.TabIndex = 45;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
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
            // pawPlaceDataSet_Clientes
            // 
            this.pawPlaceDataSet_Clientes.DataSetName = "PawPlaceDataSet_Clientes";
            this.pawPlaceDataSet_Clientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource1
            // 
            this.clienteBindingSource1.DataMember = "Cliente";
            this.clienteBindingSource1.DataSource = this.pawPlaceDataSet_Clientes;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
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
            // Visualizar_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2288, 1767);
            this.Controls.Add(this.Pnl_Principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Visualizar_Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar_Clientes";
            this.Load += new System.EventHandler(this.Visualizar_Clientes_Load);
            this.Pnl_Principal.ResumeLayout(false);
            this.Pnl_Principal.PerformLayout();
            this.Pnl_Btn_Fechar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Fechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabela_Dados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pawPlaceDataSet_Clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).EndInit();
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
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Panel Pnl_Btn_Fechar;
        private System.Windows.Forms.PictureBox Btn_Fechar;
        private PawPlaceDataSet_Clientes pawPlaceDataSet_Clientes;
        private System.Windows.Forms.BindingSource clienteBindingSource1;
        private PawPlaceDataSet_ClientesTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}