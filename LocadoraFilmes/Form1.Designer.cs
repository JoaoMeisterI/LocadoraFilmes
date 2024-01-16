namespace LocadoraFilmes
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_teste = new Button();
            lbl_teste = new Label();
            img_Box = new PictureBox();
            btn_imagem = new Button();
            ((System.ComponentModel.ISupportInitialize)img_Box).BeginInit();
            SuspendLayout();
            // 
            // btn_teste
            // 
            btn_teste.Location = new Point(12, 12);
            btn_teste.Name = "btn_teste";
            btn_teste.Size = new Size(256, 24);
            btn_teste.TabIndex = 0;
            btn_teste.Text = "Nome do Filme";
            btn_teste.UseVisualStyleBackColor = true;
            btn_teste.Click += button1_Click;
            // 
            // lbl_teste
            // 
            lbl_teste.AutoSize = true;
            lbl_teste.Location = new Point(104, 63);
            lbl_teste.Name = "lbl_teste";
            lbl_teste.Size = new Size(50, 20);
            lbl_teste.TabIndex = 1;
            lbl_teste.Text = "Nome";
            // 
            // img_Box
            // 
            img_Box.Location = new Point(425, 63);
            img_Box.Name = "img_Box";
            img_Box.Size = new Size(125, 62);
            img_Box.TabIndex = 2;
            img_Box.TabStop = false;
            // 
            // btn_imagem
            // 
            btn_imagem.Location = new Point(362, 12);
            btn_imagem.Name = "btn_imagem";
            btn_imagem.Size = new Size(256, 24);
            btn_imagem.TabIndex = 3;
            btn_imagem.Text = "Poster do filme";
            btn_imagem.UseVisualStyleBackColor = true;
            btn_imagem.Click += btn_imagem_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_imagem);
            Controls.Add(img_Box);
            Controls.Add(lbl_teste);
            Controls.Add(btn_teste);
            Name = "Menu";
            Text = "Menu Principal";
            ((System.ComponentModel.ISupportInitialize)img_Box).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_teste;
        private Label lbl_teste;
        private PictureBox img_Box;
        private Button btn_imagem;
    }
}
