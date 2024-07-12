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
			pictureBox1 = new PictureBox();
			pictureBox2 = new PictureBox();
			pictureBox3 = new PictureBox();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			SuspendLayout();
			// 
			// btn_acesso
			// 
			btn_acesso.Anchor = AnchorStyles.Top;
			btn_acesso.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			btn_acesso.BackColor = SystemColors.ControlLightLight;
			btn_acesso.Font = new Font("Copperplate Gothic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btn_acesso.ForeColor = SystemColors.Control;
			btn_acesso.Image = Properties.Resources.thumbnail_1000111963;
			btn_acesso.ImageAlign = ContentAlignment.BottomCenter;
			btn_acesso.Location = new Point(302, 307);
			btn_acesso.Name = "btn_acesso";
			btn_acesso.Size = new Size(119, 39);
			btn_acesso.TabIndex = 0;
			btn_acesso.Text = "Acessar";
			btn_acesso.UseVisualStyleBackColor = false;
			btn_acesso.Click += Btn_Acessar_Click;
			// 
			// TxtUsuário
			// 
			TxtUsuário.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
			TxtUsuário.Font = new Font("Segoe UI", 15F);
			TxtUsuário.Location = new Point(287, 192);
			TxtUsuário.Name = "TxtUsuário";
			TxtUsuário.Size = new Size(150, 34);
			TxtUsuário.TabIndex = 1;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
			label1.AutoSize = true;
			label1.BackColor = SystemColors.ActiveCaptionText;
			label1.BorderStyle = BorderStyle.FixedSingle;
			label1.FlatStyle = FlatStyle.Flat;
			label1.Font = new Font("Bauhaus 93", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.ForeColor = SystemColors.ControlLightLight;
			label1.Image = Properties.Resources.thumbnail_1000111963;
			label1.ImageAlign = ContentAlignment.BottomRight;
			label1.Location = new Point(188, 201);
			label1.Name = "label1";
			label1.Size = new Size(81, 23);
			label1.TabIndex = 2;
			label1.Text = "Usuário:";
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
			label2.AutoSize = true;
			label2.BackColor = SystemColors.ActiveCaptionText;
			label2.BorderStyle = BorderStyle.FixedSingle;
			label2.Font = new Font("Bauhaus 93", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label2.ForeColor = SystemColors.ControlLightLight;
			label2.Image = Properties.Resources.thumbnail_1000111963;
			label2.ImageAlign = ContentAlignment.BottomRight;
			label2.Location = new Point(192, 257);
			label2.Name = "label2";
			label2.Size = new Size(69, 23);
			label2.TabIndex = 3;
			label2.Text = "Senha:";
			// 
			// TxtSenha
			// 
			TxtSenha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
			TxtSenha.Font = new Font("Segoe UI", 15F);
			TxtSenha.Location = new Point(287, 257);
			TxtSenha.Name = "TxtSenha";
			TxtSenha.Size = new Size(150, 34);
			TxtSenha.TabIndex = 4;
			// 
			// pictureBox1
			// 
			pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			pictureBox1.BackgroundImage = Properties.Resources.Captura_de_Tela__49_;
			pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
			pictureBox1.BorderStyle = BorderStyle.Fixed3D;
			pictureBox1.Location = new Point(251, 41);
			pictureBox1.MaximumSize = new Size(400, 250);
			pictureBox1.MinimumSize = new Size(199, 125);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(199, 125);
			pictureBox1.TabIndex = 5;
			pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			pictureBox2.BackgroundImage = Properties.Resources.thumbnail_Picsart_24_07_11_20_50_45_048;
			pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
			pictureBox2.BorderStyle = BorderStyle.Fixed3D;
			pictureBox2.Location = new Point(251, 320);
			pictureBox2.MaximumSize = new Size(250, 250);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(0, 0);
			pictureBox2.TabIndex = 6;
			pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			pictureBox3.Location = new Point(251, 290);
			pictureBox3.MaximumSize = new Size(250, 50);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(0, 0);
			pictureBox3.TabIndex = 7;
			pictureBox3.TabStop = false;
			// 
			// Form_Login
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = Properties.Resources.tecnologia_inteligente_trabalho_humanizado;
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(698, 436);
			Controls.Add(pictureBox3);
			Controls.Add(pictureBox2);
			Controls.Add(pictureBox1);
			Controls.Add(TxtSenha);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(TxtUsuário);
			Controls.Add(btn_acesso);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "Form_Login";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "LOGIN";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btn_acesso;
        private TextBox TxtUsuário;
        private Label label1;
        private Label label2;
        private TextBox TxtSenha;
		private PictureBox pictureBox1;
		private PictureBox pictureBox2;
		private PictureBox pictureBox3;
	}
}