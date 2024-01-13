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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Visualizar_Clientes));
            this.Pnl_Principal = new System.Windows.Forms.Panel();
            this.Pnl_Linha_Tabela = new System.Windows.Forms.Panel();
            this.Tabela_Dados = new System.Windows.Forms.DataGridView();
            this.Pnl_Linha = new System.Windows.Forms.Panel();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.pawPlaceDataSet = new PawPlace.PawPlaceDataSet();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new PawPlace.PawPlaceDataSetTableAdapters.ClienteTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Pnl_Btn_Fechar = new System.Windows.Forms.Panel();
            this.Btn_Fechar = new System.Windows.Forms.PictureBox();
            this.Pnl_Principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tabela_Dados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pawPlaceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.Pnl_Btn_Fechar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Fechar)).BeginInit();
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
            // Pnl_Linha_Tabela
            // 
            this.Pnl_Linha_Tabela.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl_Linha_Tabela.BackColor = System.Drawing.Color.Black;
            this.Pnl_Linha_Tabela.Location = new System.Drawing.Point(224, 621);
            this.Pnl_Linha_Tabela.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Pnl_Linha_Tabela.Name = "Pnl_Linha_Tabela";
            this.Pnl_Linha_Tabela.Size = new System.Drawing.Size(2000, 2);
            this.Pnl_Linha_Tabela.TabIndex = 46;
            // 
            // Tabela_Dados
            // 
            this.Tabela_Dados.AllowDrop = true;
            this.Tabela_Dados.AllowUserToOrderColumns = true;
            this.Tabela_Dados.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Verdana", 9F);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(48)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            this.Tabela_Dados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.Tabela_Dados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tabela_Dados.AutoGenerateColumns = false;
            this.Tabela_Dados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Tabela_Dados.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.Tabela_Dados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tabela_Dados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Tabela_Dados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Tabela_Dados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.Tabela_Dados.ColumnHeadersHeight = 40;
            this.Tabela_Dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Tabela_Dados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.Tabela_Dados.DataSource = this.clienteBindingSource;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Verdana", 9F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(48)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Tabela_Dados.DefaultCellStyle = dataGridViewCellStyle18;
            this.Tabela_Dados.EnableHeadersVisualStyles = false;
            this.Tabela_Dados.GridColor = System.Drawing.SystemColors.ControlLight;
            this.Tabela_Dados.Location = new System.Drawing.Point(227, 528);
            this.Tabela_Dados.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Tabela_Dados.Name = "Tabela_Dados";
            this.Tabela_Dados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Verdana", 9F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(48)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Tabela_Dados.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.Tabela_Dados.RowHeadersVisible = false;
            this.Tabela_Dados.RowHeadersWidth = 40;
            this.Tabela_Dados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Verdana", 9F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(48)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White;
            this.Tabela_Dados.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.Tabela_Dados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Tabela_Dados.Size = new System.Drawing.Size(2000, 1000);
            this.Tabela_Dados.TabIndex = 45;
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
            // pawPlaceDataSet
            // 
            this.pawPlaceDataSet.DataSetName = "PawPlaceDataSet";
            this.pawPlaceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.pawPlaceDataSet;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Client";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Client";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Data_Nascimento";
            this.dataGridViewTextBoxColumn3.HeaderText = "Data_Nascimento";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NIF";
            this.dataGridViewTextBoxColumn4.HeaderText = "NIF";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "C_Cod_Postal";
            this.dataGridViewTextBoxColumn5.HeaderText = "C_Cod_Postal";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Btn_Add
            // 
            this.Btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(48)))), ((int)(((byte)(60)))));
            this.Btn_Add.FlatAppearance.BorderSize = 0;
            this.Btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Add.ForeColor = System.Drawing.Color.White;
            this.Btn_Add.Location = new System.Drawing.Point(1724, 1564);
            this.Btn_Add.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(500, 105);
            this.Btn_Add.TabIndex = 47;
            this.Btn_Add.Text = "Adicionar Cliente";
            this.Btn_Add.UseVisualStyleBackColor = false;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.Tabela_Dados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pawPlaceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.Pnl_Btn_Fechar.ResumeLayout(false);
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
        private PawPlaceDataSet pawPlaceDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private PawPlaceDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Panel Pnl_Btn_Fechar;
        private System.Windows.Forms.PictureBox Btn_Fechar;
    }
}