namespace SysVenda_MDI
{
    partial class Form_Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
			btn_acesso = new Button();
			TxtUsuário = new TextBox();
			label1 = new Label();
			label2 = new Label();
			TxtSenha = new TextBox();
			label3 = new Label();
			pictureBox1 = new PictureBox();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// btn_acesso
			// 
			btn_acesso.BackColor = SystemColors.ControlLightLight;
			btn_acesso.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btn_acesso.ForeColor = SystemColors.ControlLightLight;
			btn_acesso.Image = Properties.Resources.images__2_;
			btn_acesso.Location = new Point(934, 466);
			btn_acesso.Name = "btn_acesso";
			btn_acesso.Size = new Size(75, 23);
			btn_acesso.TabIndex = 0;
			btn_acesso.Text = "Acessar";
			btn_acesso.UseVisualStyleBackColor = false;
			btn_acesso.Click += Btn_Acessar_Click;
			// 
			// TxtUsuário
			// 
			TxtUsuário.Location = new Point(921, 394);
			TxtUsuário.Name = "TxtUsuário";
			TxtUsuário.Size = new Size(100, 23);
			TxtUsuário.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = SystemColors.ControlDark;
			label1.FlatStyle = FlatStyle.Flat;
			label1.Location = new Point(865, 397);
			label1.Name = "label1";
			label1.Size = new Size(50, 15);
			label1.TabIndex = 2;
			label1.Text = "Usuário:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = SystemColors.ControlDark;
			label2.Location = new Point(865, 429);
			label2.Name = "label2";
			label2.Size = new Size(42, 15);
			label2.TabIndex = 3;
			label2.Text = "Senha:";
			// 
			// TxtSenha
			// 
			TxtSenha.Location = new Point(921, 426);
			TxtSenha.Name = "TxtSenha";
			TxtSenha.Size = new Size(100, 23);
			TxtSenha.TabIndex = 4;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = Color.Transparent;
			label3.Font = new Font("Harlow Solid Italic", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			label3.ForeColor = Color.Gold;
			label3.Location = new Point(865, 312);
			label3.Name = "label3";
			label3.Size = new Size(179, 61);
			label3.TabIndex = 5;
			label3.Text = "M.D.I";
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.tecnologia_inteligente_trabalho_humanizado;
			pictureBox1.Location = new Point(800, 238);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(317, 309);
			pictureBox1.TabIndex = 6;
			pictureBox1.TabStop = false;
			// 
			// Form_Login
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = Properties.Resources.tecnologia_inteligente_trabalho_humanizado;
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(1379, 727);
			Controls.Add(label3);
			Controls.Add(TxtSenha);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(TxtUsuário);
			Controls.Add(btn_acesso);
			Controls.Add(pictureBox1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "Form_Login";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "LOGIN";
			WindowState = FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btn_acesso;
        private TextBox TxtUsuário;
        private Label label1;
        private Label label2;
        private TextBox TxtSenha;
		private Label label3;
		private PictureBox pictureBox1;
	}
}