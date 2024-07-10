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
			SuspendLayout();
			// 
			// btn_acesso
			// 
			btn_acesso.BackColor = SystemColors.ControlLightLight;
			btn_acesso.Location = new Point(127, 102);
			btn_acesso.Name = "btn_acesso";
			btn_acesso.Size = new Size(75, 23);
			btn_acesso.TabIndex = 0;
			btn_acesso.Text = "Acessar";
			btn_acesso.UseVisualStyleBackColor = false;
			btn_acesso.Click += Btn_Acessar_Click;
			// 
			// TxtUsuário
			// 
			TxtUsuário.Location = new Point(114, 30);
			TxtUsuário.Name = "TxtUsuário";
			TxtUsuário.Size = new Size(100, 23);
			TxtUsuário.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(58, 33);
			label1.Name = "label1";
			label1.Size = new Size(50, 15);
			label1.TabIndex = 2;
			label1.Text = "Usuário:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(58, 65);
			label2.Name = "label2";
			label2.Size = new Size(42, 15);
			label2.TabIndex = 3;
			label2.Text = "Senha:";
			// 
			// TxtSenha
			// 
			TxtSenha.Location = new Point(114, 62);
			TxtSenha.Name = "TxtSenha";
			TxtSenha.Size = new Size(100, 23);
			TxtSenha.TabIndex = 4;
			// 
			// Form_Login
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(330, 168);
			Controls.Add(TxtSenha);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(TxtUsuário);
			Controls.Add(btn_acesso);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "Form_Login";
			Text = "LOGIN";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btn_acesso;
        private TextBox TxtUsuário;
        private Label label1;
        private Label label2;
        private TextBox TxtSenha;
    }
}