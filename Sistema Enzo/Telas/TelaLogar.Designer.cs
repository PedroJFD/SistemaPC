namespace Sistema_Enzo.Telas
{
    partial class TelaLogar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogar));
            btnVendas = new Button();
            txt_usuario = new TextBox();
            txt_senha = new TextBox();
            button2 = new Button();
            label3 = new Label();
            txt_aviso = new Label();
            SuspendLayout();
            // 
            // btnVendas
            // 
            btnVendas.BackColor = Color.Transparent;
            btnVendas.FlatAppearance.BorderSize = 0;
            btnVendas.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            btnVendas.FlatStyle = FlatStyle.Flat;
            btnVendas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVendas.ForeColor = Color.FromArgb(64, 64, 64);
            btnVendas.ImageAlign = ContentAlignment.MiddleLeft;
            btnVendas.Location = new Point(292, 342);
            btnVendas.Margin = new Padding(4, 3, 4, 3);
            btnVendas.Name = "btnVendas";
            btnVendas.Size = new Size(163, 45);
            btnVendas.TabIndex = 16;
            btnVendas.Text = "Entrar";
            btnVendas.UseVisualStyleBackColor = false;
            btnVendas.Click += btnVendas_Click;
            // 
            // txt_usuario
            // 
            txt_usuario.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_usuario.Location = new Point(268, 229);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(245, 46);
            txt_usuario.TabIndex = 17;
            // 
            // txt_senha
            // 
            txt_senha.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_senha.Location = new Point(268, 281);
            txt_senha.Name = "txt_senha";
            txt_senha.Size = new Size(245, 46);
            txt_senha.TabIndex = 18;
            // 
            // button2
            // 
            button2.BackColor = Color.SandyBrown;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(64, 64, 64);
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(600, 444);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(126, 32);
            button2.TabIndex = 26;
            button2.Text = "Cadastrar-se";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(357, 450);
            label3.Name = "label3";
            label3.Size = new Size(245, 21);
            label3.TabIndex = 25;
            label3.Text = "Não possui conta? Cadastre-se:";
            label3.Click += label3_Click;
            // 
            // txt_aviso
            // 
            txt_aviso.AutoSize = true;
            txt_aviso.BackColor = Color.Transparent;
            txt_aviso.ForeColor = Color.Red;
            txt_aviso.Location = new Point(402, 435);
            txt_aviso.Name = "txt_aviso";
            txt_aviso.Size = new Size(0, 15);
            txt_aviso.TabIndex = 27;
            // 
            // TelaLogar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(730, 481);
            Controls.Add(txt_aviso);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(txt_senha);
            Controls.Add(txt_usuario);
            Controls.Add(btnVendas);
            DoubleBuffered = true;
            Name = "TelaLogar";
            Text = "TelaLogar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVendas;
        private TextBox txt_usuario;
        private TextBox txt_senha;
        private Button button2;
        private Label label3;
        private Label txt_aviso;
    }
}