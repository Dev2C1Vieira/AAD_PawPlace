namespace PawPlace.Forms.Animais
{
    partial class Alterar_Animais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alterar_Animais));
            this.DTP_DataNascimento = new System.Windows.Forms.DateTimePicker();
            this.Txt_Genero = new System.Windows.Forms.TextBox();
            this.Btn_Permitir_Alterar = new System.Windows.Forms.PictureBox();
            this.Lb_ID = new System.Windows.Forms.Label();
            this.Btn_Alterar = new System.Windows.Forms.Button();
            this.Lb_Genero = new System.Windows.Forms.Label();
            this.Lbl_Proprietario = new System.Windows.Forms.Label();
            this.Lb_DataNascimento = new System.Windows.Forms.Label();
            this.Txt_ID = new System.Windows.Forms.TextBox();
            this.Lb_NomeAnimal = new System.Windows.Forms.Label();
            this.Txt_NomeAnimal = new System.Windows.Forms.TextBox();
            this.Pnl_Superior = new System.Windows.Forms.Panel();
            this.Lb_Titulo = new System.Windows.Forms.Label();
            this.Pnl_Line = new System.Windows.Forms.Panel();
            this.Pnl_Btn_Fechar = new System.Windows.Forms.Panel();
            this.Btn_Fechar = new System.Windows.Forms.PictureBox();
            this.Txt_DataNascimento = new System.Windows.Forms.TextBox();
            this.Cmb_Proprietario = new System.Windows.Forms.ComboBox();
            this.Cmb_Raca = new System.Windows.Forms.ComboBox();
            this.Lbl_Raca = new System.Windows.Forms.Label();
            this.Cmb_Genero = new System.Windows.Forms.ComboBox();
            this.Txt_Raca = new System.Windows.Forms.TextBox();
            this.Txt_Proprietario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Permitir_Alterar)).BeginInit();
            this.Pnl_Superior.SuspendLayout();
            this.Pnl_Btn_Fechar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Fechar)).BeginInit();
            this.SuspendLayout();
            // 
            // DTP_DataNascimento
            // 
            this.DTP_DataNascimento.Location = new System.Drawing.Point(659, 443);
            this.DTP_DataNascimento.Name = "DTP_DataNascimento";
            this.DTP_DataNascimento.Size = new System.Drawing.Size(857, 38);
            this.DTP_DataNascimento.TabIndex = 105;
            this.DTP_DataNascimento.Visible = false;
            // 
            // Txt_Genero
            // 
            this.Txt_Genero.BackColor = System.Drawing.Color.White;
            this.Txt_Genero.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Genero.ForeColor = System.Drawing.Color.Black;
            this.Txt_Genero.Location = new System.Drawing.Point(659, 542);
            this.Txt_Genero.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Txt_Genero.Multiline = true;
            this.Txt_Genero.Name = "Txt_Genero";
            this.Txt_Genero.ReadOnly = true;
            this.Txt_Genero.Size = new System.Drawing.Size(857, 47);
            this.Txt_Genero.TabIndex = 104;
            this.Txt_Genero.UseWaitCursor = true;
            // 
            // Btn_Permitir_Alterar
            // 
            this.Btn_Permitir_Alterar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Permitir_Alterar.Image")));
            this.Btn_Permitir_Alterar.Location = new System.Drawing.Point(1607, 211);
            this.Btn_Permitir_Alterar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Btn_Permitir_Alterar.Name = "Btn_Permitir_Alterar";
            this.Btn_Permitir_Alterar.Size = new System.Drawing.Size(93, 83);
            this.Btn_Permitir_Alterar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_Permitir_Alterar.TabIndex = 102;
            this.Btn_Permitir_Alterar.TabStop = false;
            this.Btn_Permitir_Alterar.UseWaitCursor = true;
            this.Btn_Permitir_Alterar.Click += new System.EventHandler(this.Btn_Permitir_Alterar_Click);
            // 
            // Lb_ID
            // 
            this.Lb_ID.AutoSize = true;
            this.Lb_ID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_ID.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_ID.ForeColor = System.Drawing.Color.Black;
            this.Lb_ID.Location = new System.Drawing.Point(113, 242);
            this.Lb_ID.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Lb_ID.Name = "Lb_ID";
            this.Lb_ID.Size = new System.Drawing.Size(344, 41);
            this.Lb_ID.TabIndex = 97;
            this.Lb_ID.Text = "Código do Animal: ";
            this.Lb_ID.UseWaitCursor = true;
            // 
            // Btn_Alterar
            // 
            this.Btn_Alterar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Alterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(48)))), ((int)(((byte)(60)))));
            this.Btn_Alterar.FlatAppearance.BorderSize = 0;
            this.Btn_Alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Alterar.ForeColor = System.Drawing.Color.White;
            this.Btn_Alterar.Location = new System.Drawing.Point(1004, 951);
            this.Btn_Alterar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Btn_Alterar.Name = "Btn_Alterar";
            this.Btn_Alterar.Size = new System.Drawing.Size(512, 105);
            this.Btn_Alterar.TabIndex = 96;
            this.Btn_Alterar.Text = "Alterar Dados";
            this.Btn_Alterar.UseVisualStyleBackColor = false;
            this.Btn_Alterar.UseWaitCursor = true;
            this.Btn_Alterar.Visible = false;
            this.Btn_Alterar.Click += new System.EventHandler(this.Btn_Alterar_Click);
            // 
            // Lb_Genero
            // 
            this.Lb_Genero.AutoSize = true;
            this.Lb_Genero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_Genero.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Genero.ForeColor = System.Drawing.Color.Black;
            this.Lb_Genero.Location = new System.Drawing.Point(115, 542);
            this.Lb_Genero.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Lb_Genero.Name = "Lb_Genero";
            this.Lb_Genero.Size = new System.Drawing.Size(157, 41);
            this.Lb_Genero.TabIndex = 100;
            this.Lb_Genero.Text = "Genero:";
            this.Lb_Genero.UseWaitCursor = true;
            // 
            // Lbl_Proprietario
            // 
            this.Lbl_Proprietario.AutoSize = true;
            this.Lbl_Proprietario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lbl_Proprietario.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Proprietario.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Proprietario.Location = new System.Drawing.Point(113, 746);
            this.Lbl_Proprietario.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Lbl_Proprietario.Name = "Lbl_Proprietario";
            this.Lbl_Proprietario.Size = new System.Drawing.Size(233, 41);
            this.Lbl_Proprietario.TabIndex = 101;
            this.Lbl_Proprietario.Text = "Proprietário:";
            this.Lbl_Proprietario.UseWaitCursor = true;
            // 
            // Lb_DataNascimento
            // 
            this.Lb_DataNascimento.AutoSize = true;
            this.Lb_DataNascimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_DataNascimento.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_DataNascimento.ForeColor = System.Drawing.Color.Black;
            this.Lb_DataNascimento.Location = new System.Drawing.Point(118, 440);
            this.Lb_DataNascimento.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Lb_DataNascimento.Name = "Lb_DataNascimento";
            this.Lb_DataNascimento.Size = new System.Drawing.Size(376, 41);
            this.Lb_DataNascimento.TabIndex = 99;
            this.Lb_DataNascimento.Text = "Data de Nascimento:";
            this.Lb_DataNascimento.UseWaitCursor = true;
            // 
            // Txt_ID
            // 
            this.Txt_ID.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Txt_ID.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ID.ForeColor = System.Drawing.Color.Black;
            this.Txt_ID.Location = new System.Drawing.Point(659, 237);
            this.Txt_ID.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Txt_ID.Multiline = true;
            this.Txt_ID.Name = "Txt_ID";
            this.Txt_ID.ReadOnly = true;
            this.Txt_ID.Size = new System.Drawing.Size(857, 47);
            this.Txt_ID.TabIndex = 93;
            this.Txt_ID.UseWaitCursor = true;
            // 
            // Lb_NomeAnimal
            // 
            this.Lb_NomeAnimal.AutoSize = true;
            this.Lb_NomeAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_NomeAnimal.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_NomeAnimal.ForeColor = System.Drawing.Color.Black;
            this.Lb_NomeAnimal.Location = new System.Drawing.Point(115, 340);
            this.Lb_NomeAnimal.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Lb_NomeAnimal.Name = "Lb_NomeAnimal";
            this.Lb_NomeAnimal.Size = new System.Drawing.Size(314, 41);
            this.Lb_NomeAnimal.TabIndex = 98;
            this.Lb_NomeAnimal.Text = "Nome do Animal:";
            this.Lb_NomeAnimal.UseWaitCursor = true;
            // 
            // Txt_NomeAnimal
            // 
            this.Txt_NomeAnimal.BackColor = System.Drawing.Color.White;
            this.Txt_NomeAnimal.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NomeAnimal.ForeColor = System.Drawing.Color.Black;
            this.Txt_NomeAnimal.Location = new System.Drawing.Point(659, 337);
            this.Txt_NomeAnimal.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Txt_NomeAnimal.Multiline = true;
            this.Txt_NomeAnimal.Name = "Txt_NomeAnimal";
            this.Txt_NomeAnimal.ReadOnly = true;
            this.Txt_NomeAnimal.Size = new System.Drawing.Size(857, 47);
            this.Txt_NomeAnimal.TabIndex = 94;
            this.Txt_NomeAnimal.UseWaitCursor = true;
            // 
            // Pnl_Superior
            // 
            this.Pnl_Superior.Controls.Add(this.Lb_Titulo);
            this.Pnl_Superior.Controls.Add(this.Pnl_Line);
            this.Pnl_Superior.Controls.Add(this.Pnl_Btn_Fechar);
            this.Pnl_Superior.Location = new System.Drawing.Point(2, 1);
            this.Pnl_Superior.Name = "Pnl_Superior";
            this.Pnl_Superior.Size = new System.Drawing.Size(1813, 181);
            this.Pnl_Superior.TabIndex = 103;
            this.Pnl_Superior.UseWaitCursor = true;
            this.Pnl_Superior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pnl_Superior_MouseDown);
            // 
            // Lb_Titulo
            // 
            this.Lb_Titulo.AutoSize = true;
            this.Lb_Titulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_Titulo.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Titulo.ForeColor = System.Drawing.Color.Black;
            this.Lb_Titulo.Location = new System.Drawing.Point(33, 75);
            this.Lb_Titulo.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Lb_Titulo.Name = "Lb_Titulo";
            this.Lb_Titulo.Size = new System.Drawing.Size(638, 57);
            this.Lb_Titulo.TabIndex = 55;
            this.Lb_Titulo.Text = "Informações do Cliente";
            this.Lb_Titulo.UseWaitCursor = true;
            // 
            // Pnl_Line
            // 
            this.Pnl_Line.BackColor = System.Drawing.Color.Black;
            this.Pnl_Line.Location = new System.Drawing.Point(46, 144);
            this.Pnl_Line.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Pnl_Line.Name = "Pnl_Line";
            this.Pnl_Line.Size = new System.Drawing.Size(1600, 7);
            this.Pnl_Line.TabIndex = 56;
            this.Pnl_Line.UseWaitCursor = true;
            // 
            // Pnl_Btn_Fechar
            // 
            this.Pnl_Btn_Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl_Btn_Fechar.Controls.Add(this.Btn_Fechar);
            this.Pnl_Btn_Fechar.Location = new System.Drawing.Point(1705, 8);
            this.Pnl_Btn_Fechar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Pnl_Btn_Fechar.Name = "Pnl_Btn_Fechar";
            this.Pnl_Btn_Fechar.Size = new System.Drawing.Size(101, 74);
            this.Pnl_Btn_Fechar.TabIndex = 57;
            this.Pnl_Btn_Fechar.UseWaitCursor = true;
            this.Pnl_Btn_Fechar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pnl_Btn_Fechar_MouseDown);
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
            this.Btn_Fechar.UseWaitCursor = true;
            this.Btn_Fechar.Click += new System.EventHandler(this.Btn_Fechar_Click);
            this.Btn_Fechar.MouseHover += new System.EventHandler(this.Btn_Fechar_MouseHover);
            // 
            // Txt_DataNascimento
            // 
            this.Txt_DataNascimento.BackColor = System.Drawing.Color.White;
            this.Txt_DataNascimento.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_DataNascimento.ForeColor = System.Drawing.Color.Black;
            this.Txt_DataNascimento.Location = new System.Drawing.Point(659, 440);
            this.Txt_DataNascimento.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Txt_DataNascimento.Multiline = true;
            this.Txt_DataNascimento.Name = "Txt_DataNascimento";
            this.Txt_DataNascimento.ReadOnly = true;
            this.Txt_DataNascimento.Size = new System.Drawing.Size(857, 47);
            this.Txt_DataNascimento.TabIndex = 106;
            this.Txt_DataNascimento.UseWaitCursor = true;
            // 
            // Cmb_Proprietario
            // 
            this.Cmb_Proprietario.FormattingEnabled = true;
            this.Cmb_Proprietario.Location = new System.Drawing.Point(657, 750);
            this.Cmb_Proprietario.Name = "Cmb_Proprietario";
            this.Cmb_Proprietario.Size = new System.Drawing.Size(857, 39);
            this.Cmb_Proprietario.TabIndex = 107;
            this.Cmb_Proprietario.Visible = false;
            // 
            // Cmb_Raca
            // 
            this.Cmb_Raca.FormattingEnabled = true;
            this.Cmb_Raca.Location = new System.Drawing.Point(657, 652);
            this.Cmb_Raca.Name = "Cmb_Raca";
            this.Cmb_Raca.Size = new System.Drawing.Size(857, 39);
            this.Cmb_Raca.TabIndex = 109;
            this.Cmb_Raca.Visible = false;
            // 
            // Lbl_Raca
            // 
            this.Lbl_Raca.AutoSize = true;
            this.Lbl_Raca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lbl_Raca.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Raca.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Raca.Location = new System.Drawing.Point(113, 648);
            this.Lbl_Raca.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Lbl_Raca.Name = "Lbl_Raca";
            this.Lbl_Raca.Size = new System.Drawing.Size(114, 41);
            this.Lbl_Raca.TabIndex = 108;
            this.Lbl_Raca.Text = "Raça:";
            this.Lbl_Raca.UseWaitCursor = true;
            // 
            // Cmb_Genero
            // 
            this.Cmb_Genero.FormattingEnabled = true;
            this.Cmb_Genero.Items.AddRange(new object[] {
            "Macho",
            "Fêmea"});
            this.Cmb_Genero.Location = new System.Drawing.Point(659, 546);
            this.Cmb_Genero.Name = "Cmb_Genero";
            this.Cmb_Genero.Size = new System.Drawing.Size(857, 39);
            this.Cmb_Genero.TabIndex = 110;
            this.Cmb_Genero.Visible = false;
            // 
            // Txt_Raca
            // 
            this.Txt_Raca.BackColor = System.Drawing.Color.White;
            this.Txt_Raca.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Raca.ForeColor = System.Drawing.Color.Black;
            this.Txt_Raca.Location = new System.Drawing.Point(657, 645);
            this.Txt_Raca.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Txt_Raca.Multiline = true;
            this.Txt_Raca.Name = "Txt_Raca";
            this.Txt_Raca.ReadOnly = true;
            this.Txt_Raca.Size = new System.Drawing.Size(857, 47);
            this.Txt_Raca.TabIndex = 111;
            this.Txt_Raca.UseWaitCursor = true;
            // 
            // Txt_Proprietario
            // 
            this.Txt_Proprietario.BackColor = System.Drawing.Color.White;
            this.Txt_Proprietario.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Proprietario.ForeColor = System.Drawing.Color.Black;
            this.Txt_Proprietario.Location = new System.Drawing.Point(657, 746);
            this.Txt_Proprietario.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Txt_Proprietario.Multiline = true;
            this.Txt_Proprietario.Name = "Txt_Proprietario";
            this.Txt_Proprietario.ReadOnly = true;
            this.Txt_Proprietario.Size = new System.Drawing.Size(857, 47);
            this.Txt_Proprietario.TabIndex = 112;
            this.Txt_Proprietario.UseWaitCursor = true;
            // 
            // Alterar_Animais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1813, 1150);
            this.Controls.Add(this.Cmb_Genero);
            this.Controls.Add(this.Cmb_Raca);
            this.Controls.Add(this.Lbl_Raca);
            this.Controls.Add(this.Cmb_Proprietario);
            this.Controls.Add(this.DTP_DataNascimento);
            this.Controls.Add(this.Txt_Genero);
            this.Controls.Add(this.Btn_Permitir_Alterar);
            this.Controls.Add(this.Lb_ID);
            this.Controls.Add(this.Btn_Alterar);
            this.Controls.Add(this.Lb_Genero);
            this.Controls.Add(this.Lbl_Proprietario);
            this.Controls.Add(this.Lb_DataNascimento);
            this.Controls.Add(this.Txt_ID);
            this.Controls.Add(this.Lb_NomeAnimal);
            this.Controls.Add(this.Txt_NomeAnimal);
            this.Controls.Add(this.Pnl_Superior);
            this.Controls.Add(this.Txt_DataNascimento);
            this.Controls.Add(this.Txt_Raca);
            this.Controls.Add(this.Txt_Proprietario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Alterar_Animais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar_Animais";
            this.Load += new System.EventHandler(this.Alterar_Animais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Permitir_Alterar)).EndInit();
            this.Pnl_Superior.ResumeLayout(false);
            this.Pnl_Superior.PerformLayout();
            this.Pnl_Btn_Fechar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Fechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DTP_DataNascimento;
        public System.Windows.Forms.TextBox Txt_Genero;
        private System.Windows.Forms.PictureBox Btn_Permitir_Alterar;
        private System.Windows.Forms.Label Lb_ID;
        private System.Windows.Forms.Button Btn_Alterar;
        private System.Windows.Forms.Label Lb_Genero;
        private System.Windows.Forms.Label Lbl_Proprietario;
        private System.Windows.Forms.Label Lb_DataNascimento;
        public System.Windows.Forms.TextBox Txt_ID;
        private System.Windows.Forms.Label Lb_NomeAnimal;
        public System.Windows.Forms.TextBox Txt_NomeAnimal;
        private System.Windows.Forms.Panel Pnl_Superior;
        private System.Windows.Forms.Label Lb_Titulo;
        private System.Windows.Forms.Panel Pnl_Line;
        private System.Windows.Forms.Panel Pnl_Btn_Fechar;
        private System.Windows.Forms.PictureBox Btn_Fechar;
        public System.Windows.Forms.TextBox Txt_DataNascimento;
        private System.Windows.Forms.ComboBox Cmb_Proprietario;
        private System.Windows.Forms.ComboBox Cmb_Raca;
        private System.Windows.Forms.Label Lbl_Raca;
        private System.Windows.Forms.ComboBox Cmb_Genero;
        public System.Windows.Forms.TextBox Txt_Raca;
        public System.Windows.Forms.TextBox Txt_Proprietario;
    }
}