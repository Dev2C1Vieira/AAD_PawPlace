namespace PawPlace.Forms.Animais
{
    partial class Adicionar_Animais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adicionar_Animais));
            this.Lb_Titulo = new System.Windows.Forms.Label();
            this.Pnl_Linha_Titulo = new System.Windows.Forms.Panel();
            this.Cmb_Genero = new System.Windows.Forms.ComboBox();
            this.Cmb_Raca = new System.Windows.Forms.ComboBox();
            this.Lbl_Raca = new System.Windows.Forms.Label();
            this.Cmb_Proprietario = new System.Windows.Forms.ComboBox();
            this.DTP_DataNascimento = new System.Windows.Forms.DateTimePicker();
            this.Lb_Genero = new System.Windows.Forms.Label();
            this.Lbl_Proprietario = new System.Windows.Forms.Label();
            this.Lb_DataNascimento = new System.Windows.Forms.Label();
            this.Lb_NomeAnimal = new System.Windows.Forms.Label();
            this.Txt_NomeAnimal = new System.Windows.Forms.TextBox();
            this.Txt_DataNascimento = new System.Windows.Forms.TextBox();
            this.Btn_Limpar = new System.Windows.Forms.PictureBox();
            this.Btn_Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Limpar)).BeginInit();
            this.SuspendLayout();
            // 
            // Lb_Titulo
            // 
            this.Lb_Titulo.AutoSize = true;
            this.Lb_Titulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_Titulo.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Titulo.ForeColor = System.Drawing.Color.Black;
            this.Lb_Titulo.Location = new System.Drawing.Point(92, 82);
            this.Lb_Titulo.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Lb_Titulo.Name = "Lb_Titulo";
            this.Lb_Titulo.Size = new System.Drawing.Size(654, 57);
            this.Lb_Titulo.TabIndex = 54;
            this.Lb_Titulo.Text = "Informações  do Animal";
            // 
            // Pnl_Linha_Titulo
            // 
            this.Pnl_Linha_Titulo.BackColor = System.Drawing.Color.Black;
            this.Pnl_Linha_Titulo.Location = new System.Drawing.Point(103, 144);
            this.Pnl_Linha_Titulo.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Pnl_Linha_Titulo.Name = "Pnl_Linha_Titulo";
            this.Pnl_Linha_Titulo.Size = new System.Drawing.Size(1733, 7);
            this.Pnl_Linha_Titulo.TabIndex = 55;
            // 
            // Cmb_Genero
            // 
            this.Cmb_Genero.FormattingEnabled = true;
            this.Cmb_Genero.Items.AddRange(new object[] {
            "Macho",
            "Fêmea"});
            this.Cmb_Genero.Location = new System.Drawing.Point(710, 448);
            this.Cmb_Genero.Name = "Cmb_Genero";
            this.Cmb_Genero.Size = new System.Drawing.Size(857, 39);
            this.Cmb_Genero.TabIndex = 124;
            // 
            // Cmb_Raca
            // 
            this.Cmb_Raca.FormattingEnabled = true;
            this.Cmb_Raca.Location = new System.Drawing.Point(708, 554);
            this.Cmb_Raca.Name = "Cmb_Raca";
            this.Cmb_Raca.Size = new System.Drawing.Size(857, 39);
            this.Cmb_Raca.TabIndex = 123;
            // 
            // Lbl_Raca
            // 
            this.Lbl_Raca.AutoSize = true;
            this.Lbl_Raca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lbl_Raca.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Raca.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Raca.Location = new System.Drawing.Point(164, 550);
            this.Lbl_Raca.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Lbl_Raca.Name = "Lbl_Raca";
            this.Lbl_Raca.Size = new System.Drawing.Size(114, 41);
            this.Lbl_Raca.TabIndex = 122;
            this.Lbl_Raca.Text = "Raça:";
            this.Lbl_Raca.UseWaitCursor = true;
            // 
            // Cmb_Proprietario
            // 
            this.Cmb_Proprietario.FormattingEnabled = true;
            this.Cmb_Proprietario.Location = new System.Drawing.Point(708, 652);
            this.Cmb_Proprietario.Name = "Cmb_Proprietario";
            this.Cmb_Proprietario.Size = new System.Drawing.Size(857, 39);
            this.Cmb_Proprietario.TabIndex = 121;
            // 
            // DTP_DataNascimento
            // 
            this.DTP_DataNascimento.Location = new System.Drawing.Point(710, 345);
            this.DTP_DataNascimento.Name = "DTP_DataNascimento";
            this.DTP_DataNascimento.Size = new System.Drawing.Size(857, 38);
            this.DTP_DataNascimento.TabIndex = 119;
            this.DTP_DataNascimento.Visible = false;
            // 
            // Lb_Genero
            // 
            this.Lb_Genero.AutoSize = true;
            this.Lb_Genero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_Genero.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Genero.ForeColor = System.Drawing.Color.Black;
            this.Lb_Genero.Location = new System.Drawing.Point(166, 444);
            this.Lb_Genero.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Lb_Genero.Name = "Lb_Genero";
            this.Lb_Genero.Size = new System.Drawing.Size(157, 41);
            this.Lb_Genero.TabIndex = 116;
            this.Lb_Genero.Text = "Genero:";
            this.Lb_Genero.UseWaitCursor = true;
            // 
            // Lbl_Proprietario
            // 
            this.Lbl_Proprietario.AutoSize = true;
            this.Lbl_Proprietario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lbl_Proprietario.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Proprietario.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Proprietario.Location = new System.Drawing.Point(164, 648);
            this.Lbl_Proprietario.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Lbl_Proprietario.Name = "Lbl_Proprietario";
            this.Lbl_Proprietario.Size = new System.Drawing.Size(233, 41);
            this.Lbl_Proprietario.TabIndex = 117;
            this.Lbl_Proprietario.Text = "Proprietário:";
            this.Lbl_Proprietario.UseWaitCursor = true;
            // 
            // Lb_DataNascimento
            // 
            this.Lb_DataNascimento.AutoSize = true;
            this.Lb_DataNascimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_DataNascimento.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_DataNascimento.ForeColor = System.Drawing.Color.Black;
            this.Lb_DataNascimento.Location = new System.Drawing.Point(169, 342);
            this.Lb_DataNascimento.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Lb_DataNascimento.Name = "Lb_DataNascimento";
            this.Lb_DataNascimento.Size = new System.Drawing.Size(376, 41);
            this.Lb_DataNascimento.TabIndex = 115;
            this.Lb_DataNascimento.Text = "Data de Nascimento:";
            this.Lb_DataNascimento.UseWaitCursor = true;
            // 
            // Lb_NomeAnimal
            // 
            this.Lb_NomeAnimal.AutoSize = true;
            this.Lb_NomeAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_NomeAnimal.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_NomeAnimal.ForeColor = System.Drawing.Color.Black;
            this.Lb_NomeAnimal.Location = new System.Drawing.Point(166, 242);
            this.Lb_NomeAnimal.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Lb_NomeAnimal.Name = "Lb_NomeAnimal";
            this.Lb_NomeAnimal.Size = new System.Drawing.Size(314, 41);
            this.Lb_NomeAnimal.TabIndex = 114;
            this.Lb_NomeAnimal.Text = "Nome do Animal:";
            this.Lb_NomeAnimal.UseWaitCursor = true;
            // 
            // Txt_NomeAnimal
            // 
            this.Txt_NomeAnimal.BackColor = System.Drawing.Color.White;
            this.Txt_NomeAnimal.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NomeAnimal.ForeColor = System.Drawing.Color.Black;
            this.Txt_NomeAnimal.Location = new System.Drawing.Point(710, 239);
            this.Txt_NomeAnimal.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Txt_NomeAnimal.Multiline = true;
            this.Txt_NomeAnimal.Name = "Txt_NomeAnimal";
            this.Txt_NomeAnimal.ReadOnly = true;
            this.Txt_NomeAnimal.Size = new System.Drawing.Size(857, 47);
            this.Txt_NomeAnimal.TabIndex = 113;
            this.Txt_NomeAnimal.UseWaitCursor = true;
            // 
            // Txt_DataNascimento
            // 
            this.Txt_DataNascimento.BackColor = System.Drawing.Color.White;
            this.Txt_DataNascimento.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_DataNascimento.ForeColor = System.Drawing.Color.Black;
            this.Txt_DataNascimento.Location = new System.Drawing.Point(710, 342);
            this.Txt_DataNascimento.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Txt_DataNascimento.Multiline = true;
            this.Txt_DataNascimento.Name = "Txt_DataNascimento";
            this.Txt_DataNascimento.ReadOnly = true;
            this.Txt_DataNascimento.Size = new System.Drawing.Size(857, 47);
            this.Txt_DataNascimento.TabIndex = 120;
            this.Txt_DataNascimento.UseWaitCursor = true;
            // 
            // Btn_Limpar
            // 
            this.Btn_Limpar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Limpar.Image")));
            this.Btn_Limpar.Location = new System.Drawing.Point(1743, 219);
            this.Btn_Limpar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Btn_Limpar.Name = "Btn_Limpar";
            this.Btn_Limpar.Size = new System.Drawing.Size(93, 83);
            this.Btn_Limpar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_Limpar.TabIndex = 128;
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
            this.Btn_Add.Location = new System.Drawing.Point(103, 1054);
            this.Btn_Add.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(443, 105);
            this.Btn_Add.TabIndex = 127;
            this.Btn_Add.Text = "Adicionar";
            this.Btn_Add.UseVisualStyleBackColor = false;
            // 
            // Adicionar_Animais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(2200, 1500);
            this.Controls.Add(this.Btn_Limpar);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.Cmb_Genero);
            this.Controls.Add(this.Cmb_Raca);
            this.Controls.Add(this.Lbl_Raca);
            this.Controls.Add(this.Cmb_Proprietario);
            this.Controls.Add(this.DTP_DataNascimento);
            this.Controls.Add(this.Lb_Genero);
            this.Controls.Add(this.Lbl_Proprietario);
            this.Controls.Add(this.Lb_DataNascimento);
            this.Controls.Add(this.Lb_NomeAnimal);
            this.Controls.Add(this.Txt_NomeAnimal);
            this.Controls.Add(this.Txt_DataNascimento);
            this.Controls.Add(this.Pnl_Linha_Titulo);
            this.Controls.Add(this.Lb_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Adicionar_Animais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar_Animais";
            this.Load += new System.EventHandler(this.Adicionar_Animais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Limpar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb_Titulo;
        private System.Windows.Forms.Panel Pnl_Linha_Titulo;
        private System.Windows.Forms.ComboBox Cmb_Genero;
        private System.Windows.Forms.ComboBox Cmb_Raca;
        private System.Windows.Forms.Label Lbl_Raca;
        private System.Windows.Forms.ComboBox Cmb_Proprietario;
        private System.Windows.Forms.DateTimePicker DTP_DataNascimento;
        private System.Windows.Forms.Label Lb_Genero;
        private System.Windows.Forms.Label Lbl_Proprietario;
        private System.Windows.Forms.Label Lb_DataNascimento;
        private System.Windows.Forms.Label Lb_NomeAnimal;
        public System.Windows.Forms.TextBox Txt_NomeAnimal;
        public System.Windows.Forms.TextBox Txt_DataNascimento;
        private System.Windows.Forms.PictureBox Btn_Limpar;
        private System.Windows.Forms.Button Btn_Add;
    }
}