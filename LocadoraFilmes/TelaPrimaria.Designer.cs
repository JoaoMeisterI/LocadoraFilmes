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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            btn_entrar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(586, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(542, 411);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.ImageLocation = "";
            pictureBox3.Location = new Point(70, -19);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(823, 350);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(2, 1);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(160, 414);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // btn_entrar
            // 
            btn_entrar.AllowDrop = true;
            btn_entrar.AutoEllipsis = true;
            btn_entrar.AutoSize = true;
            btn_entrar.BackColor = Color.Firebrick;
            btn_entrar.Cursor = Cursors.Hand;
            btn_entrar.DialogResult = DialogResult.OK;
            btn_entrar.FlatAppearance.BorderColor = Color.Firebrick;
            btn_entrar.FlatAppearance.BorderSize = 30;
            btn_entrar.FlatAppearance.MouseOverBackColor = Color.Red;
            btn_entrar.Font = new Font("Sylfaen", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_entrar.ForeColor = SystemColors.ControlText;
            btn_entrar.ImageAlign = ContentAlignment.BottomCenter;
            btn_entrar.Location = new Point(429, 418);
            btn_entrar.Name = "btn_entrar";
            btn_entrar.Size = new Size(297, 44);
            btn_entrar.TabIndex = 4;
            btn_entrar.Text = "Entrar";
            btn_entrar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_entrar.UseVisualStyleBackColor = false;
            btn_entrar.Click += btn_entrar_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrange;
            ClientSize = new Size(1131, 524);
            Controls.Add(btn_entrar);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Name = "Menu";
            Text = "Menu Principal";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_teste;
        private Label lbl_teste;
        private PictureBox img_Box;
        private Button btn_imagem;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button btn_entrar;
    }
}
