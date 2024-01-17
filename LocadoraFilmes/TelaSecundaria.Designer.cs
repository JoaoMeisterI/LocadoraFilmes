namespace LocadoraFilmes
{
    partial class TelaSecundaria
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
            btn_buscar = new Button();
            label1 = new Label();
            Txt_NomeFilme = new TextBox();
            lbl_Poster = new Label();
            lbl_infoFilme = new Label();
            img_Filme = new PictureBox();
            lbl_Nome = new Label();
            lbl_Elenco = new Label();
            lbl_anoLancamento = new Label();
            ((System.ComponentModel.ISupportInitialize)img_Filme).BeginInit();
            SuspendLayout();
            // 
            // btn_buscar
            // 
            btn_buscar.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_buscar.Location = new Point(408, 119);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(270, 32);
            btn_buscar.TabIndex = 0;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = true;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(480, 9);
            label1.Name = "label1";
            label1.Size = new Size(148, 25);
            label1.TabIndex = 1;
            label1.Text = "Nome do Filme";
            label1.Click += label1_Click;
            // 
            // Txt_NomeFilme
            // 
            Txt_NomeFilme.Font = new Font("Segoe UI Symbol", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Txt_NomeFilme.Location = new Point(408, 63);
            Txt_NomeFilme.Name = "Txt_NomeFilme";
            Txt_NomeFilme.Size = new Size(270, 31);
            Txt_NomeFilme.TabIndex = 2;
            // 
            // lbl_Poster
            // 
            lbl_Poster.AutoSize = true;
            lbl_Poster.Font = new Font("Segoe UI Symbol", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Poster.Location = new Point(98, 198);
            lbl_Poster.Name = "lbl_Poster";
            lbl_Poster.Size = new Size(121, 25);
            lbl_Poster.TabIndex = 3;
            lbl_Poster.Text = "Poster Filme";
            lbl_Poster.Visible = false;
            // 
            // lbl_infoFilme
            // 
            lbl_infoFilme.AutoSize = true;
            lbl_infoFilme.Font = new Font("Segoe UI Symbol", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_infoFilme.Location = new Point(871, 198);
            lbl_infoFilme.Name = "lbl_infoFilme";
            lbl_infoFilme.Size = new Size(175, 25);
            lbl_infoFilme.TabIndex = 4;
            lbl_infoFilme.Text = "Informações Filme";
            lbl_infoFilme.Visible = false;
            // 
            // img_Filme
            // 
            img_Filme.Location = new Point(12, 235);
            img_Filme.Name = "img_Filme";
            img_Filme.Size = new Size(295, 277);
            img_Filme.TabIndex = 5;
            img_Filme.TabStop = false;
            // 
            // lbl_Nome
            // 
            lbl_Nome.AutoSize = true;
            lbl_Nome.Font = new Font("Segoe UI Variable Display", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Nome.Location = new Point(754, 244);
            lbl_Nome.Name = "lbl_Nome";
            lbl_Nome.Size = new Size(0, 24);
            lbl_Nome.TabIndex = 6;
            // 
            // lbl_Elenco
            // 
            lbl_Elenco.AutoSize = true;
            lbl_Elenco.Font = new Font("Segoe UI Variable Display", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Elenco.Location = new Point(754, 355);
            lbl_Elenco.Name = "lbl_Elenco";
            lbl_Elenco.Size = new Size(0, 24);
            lbl_Elenco.TabIndex = 9;
            // 
            // lbl_anoLancamento
            // 
            lbl_anoLancamento.AutoSize = true;
            lbl_anoLancamento.Font = new Font("Segoe UI Variable Display", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_anoLancamento.Location = new Point(754, 464);
            lbl_anoLancamento.Name = "lbl_anoLancamento";
            lbl_anoLancamento.Size = new Size(0, 24);
            lbl_anoLancamento.TabIndex = 10;
            // 
            // TelaSecundaria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrange;
            ClientSize = new Size(1131, 524);
            Controls.Add(lbl_anoLancamento);
            Controls.Add(lbl_Elenco);
            Controls.Add(lbl_Nome);
            Controls.Add(img_Filme);
            Controls.Add(lbl_infoFilme);
            Controls.Add(lbl_Poster);
            Controls.Add(Txt_NomeFilme);
            Controls.Add(label1);
            Controls.Add(btn_buscar);
            Name = "TelaSecundaria";
            Text = "TelaSecundaria";
            ((System.ComponentModel.ISupportInitialize)img_Filme).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_buscar;
        private Label label1;
        private TextBox Txt_NomeFilme;
        private Label lbl_Poster;
        private Label lbl_infoFilme;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label5;
        private Label label3;
        private PictureBox img_Filme;
        private Label lbl_Nome;
        private Label lbl_Elenco;
        private Label lbl_;
        private Label lbl_anoLancamento;
    }
}