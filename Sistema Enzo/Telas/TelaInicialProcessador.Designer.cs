namespace Sistema_Enzo.Telas
{
    partial class TelaInicialProcessador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicialProcessador));
            btn_avancar = new Button();
            check_1 = new CheckBox();
            check_2 = new CheckBox();
            check_3 = new CheckBox();
            check_4 = new CheckBox();
            check_5 = new CheckBox();
            check_6 = new CheckBox();
            check_7 = new CheckBox();
            check_8 = new CheckBox();
            SuspendLayout();
            // 
            // btn_avancar
            // 
            btn_avancar.BackColor = SystemColors.AppWorkspace;
            btn_avancar.FlatAppearance.BorderSize = 0;
            btn_avancar.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            btn_avancar.FlatStyle = FlatStyle.Flat;
            btn_avancar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_avancar.ForeColor = Color.Black;
            btn_avancar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_avancar.Location = new Point(755, 12);
            btn_avancar.Margin = new Padding(4, 3, 4, 3);
            btn_avancar.Name = "btn_avancar";
            btn_avancar.Size = new Size(152, 45);
            btn_avancar.TabIndex = 15;
            btn_avancar.Text = "Avançar";
            btn_avancar.UseVisualStyleBackColor = false;
            btn_avancar.Visible = false;
            btn_avancar.Click += btn_avancar_Click;
            // 
            // check_1
            // 
            check_1.AutoSize = true;
            check_1.Location = new Point(188, 220);
            check_1.Name = "check_1";
            check_1.Size = new Size(15, 14);
            check_1.TabIndex = 16;
            check_1.UseVisualStyleBackColor = true;
            check_1.CheckedChanged += check_1_CheckedChanged_1;
            // 
            // check_2
            // 
            check_2.AutoSize = true;
            check_2.Location = new Point(406, 220);
            check_2.Name = "check_2";
            check_2.Size = new Size(15, 14);
            check_2.TabIndex = 17;
            check_2.UseVisualStyleBackColor = true;
            check_2.CheckedChanged += check_2_CheckedChanged;
            // 
            // check_3
            // 
            check_3.AutoSize = true;
            check_3.Location = new Point(632, 220);
            check_3.Name = "check_3";
            check_3.Size = new Size(15, 14);
            check_3.TabIndex = 18;
            check_3.UseVisualStyleBackColor = true;
            check_3.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // check_4
            // 
            check_4.AutoSize = true;
            check_4.Location = new Point(851, 220);
            check_4.Name = "check_4";
            check_4.Size = new Size(15, 14);
            check_4.TabIndex = 19;
            check_4.UseVisualStyleBackColor = true;
            check_4.CheckedChanged += check_4_CheckedChanged;
            // 
            // check_5
            // 
            check_5.AutoSize = true;
            check_5.Location = new Point(188, 394);
            check_5.Name = "check_5";
            check_5.Size = new Size(15, 14);
            check_5.TabIndex = 20;
            check_5.UseVisualStyleBackColor = true;
            check_5.CheckedChanged += check_5_CheckedChanged;
            // 
            // check_6
            // 
            check_6.AutoSize = true;
            check_6.Location = new Point(406, 394);
            check_6.Name = "check_6";
            check_6.Size = new Size(15, 14);
            check_6.TabIndex = 21;
            check_6.UseVisualStyleBackColor = true;
            check_6.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // check_7
            // 
            check_7.AutoSize = true;
            check_7.Location = new Point(632, 394);
            check_7.Name = "check_7";
            check_7.Size = new Size(15, 14);
            check_7.TabIndex = 22;
            check_7.UseVisualStyleBackColor = true;
            check_7.CheckedChanged += check_7_CheckedChanged;
            // 
            // check_8
            // 
            check_8.AutoSize = true;
            check_8.Location = new Point(851, 394);
            check_8.Name = "check_8";
            check_8.Size = new Size(15, 14);
            check_8.TabIndex = 23;
            check_8.UseVisualStyleBackColor = true;
            check_8.CheckedChanged += check_8_CheckedChanged;
            // 
            // TelaInicialProcessador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(933, 569);
            Controls.Add(check_8);
            Controls.Add(check_7);
            Controls.Add(check_6);
            Controls.Add(check_5);
            Controls.Add(check_4);
            Controls.Add(check_3);
            Controls.Add(check_2);
            Controls.Add(check_1);
            Controls.Add(btn_avancar);
            Name = "TelaInicialProcessador";
            Text = "TelaInicial";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_avancar;
        private CheckBox check_1;
        private CheckBox check_2;
        private CheckBox check_3;
        private CheckBox check_4;
        private CheckBox check_5;
        private CheckBox check_6;
        private CheckBox check_7;
        private CheckBox check_8;
    }
}