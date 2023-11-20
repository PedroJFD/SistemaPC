namespace Sistema_Enzo.Telas
{
    partial class TelaCadastrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastrar));
            txt_senha = new TextBox();
            txt_usuario = new TextBox();
            btnVendas = new Button();
            txt_cpf = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // txt_senha
            // 
            txt_senha.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_senha.Location = new Point(266, 299);
            txt_senha.Name = "txt_senha";
            txt_senha.Size = new Size(236, 43);
            txt_senha.TabIndex = 29;
            // 
            // txt_usuario
            // 
            txt_usuario.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txt_usuario.Location = new Point(266, 254);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(236, 39);
            txt_usuario.TabIndex = 27;
            // 
            // btnVendas
            // 
            btnVendas.BackColor = Color.Transparent;
            btnVendas.FlatAppearance.BorderSize = 0;
            btnVendas.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            btnVendas.FlatStyle = FlatStyle.Flat;
            btnVendas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVendas.ForeColor = Color.White;
            btnVendas.ImageAlign = ContentAlignment.MiddleLeft;
            btnVendas.Location = new Point(286, 412);
            btnVendas.Margin = new Padding(4, 3, 4, 3);
            btnVendas.Name = "btnVendas";
            btnVendas.Size = new Size(161, 45);
            btnVendas.TabIndex = 30;
            btnVendas.Text = "Cadastrar";
            btnVendas.UseVisualStyleBackColor = false;
            btnVendas.Click += btnVendas_Click;
            // 
            // txt_cpf
            // 
            txt_cpf.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_cpf.Location = new Point(266, 346);
            txt_cpf.Name = "txt_cpf";
            txt_cpf.Size = new Size(236, 43);
            txt_cpf.TabIndex = 31;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            button1.FlatAppearance.MouseOverBackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(670, 12);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(47, 39);
            button1.TabIndex = 36;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // TelaCadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(730, 481);
            Controls.Add(button1);
            Controls.Add(txt_cpf);
            Controls.Add(btnVendas);
            Controls.Add(txt_senha);
            Controls.Add(txt_usuario);
            DoubleBuffered = true;
            Name = "TelaCadastrar";
            Text = "TelaCadastrar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_senha;
        private TextBox txt_usuario;
        private Button btnVendas;
        private TextBox txt_cpf;
        private Button button1;
    }
}