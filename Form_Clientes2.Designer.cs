namespace SysVenda_MDI
{
	partial class Form_Clientes2
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
			Txt_NOME_CLIENTES = new TextBox();
			label2 = new Label();
			Txt_CPF = new TextBox();
			label3 = new Label();
			Txt_RG = new TextBox();
			label4 = new Label();
			Txt_NASCIMENTO = new TextBox();
			label5 = new Label();
			Txt_ENDERECO = new TextBox();
			label6 = new Label();
			Txt_FONE = new TextBox();
			label7 = new Label();
			Txt_EMAIL = new TextBox();
			label8 = new Label();
			Btn_INSERIR = new Button();
			Btn_Ataualizar = new Button();
			Btn_Excluir = new Button();
			DGV_ListaClientes = new DataGridView();
			ButtonClick = new Button();
			Txt_CEP = new TextBox();
			((System.ComponentModel.ISupportInitialize)DGV_ListaClientes).BeginInit();
			SuspendLayout();
			// 
			// Txt_NOME_CLIENTES
			// 
			Txt_NOME_CLIENTES.Location = new Point(130, 24);
			Txt_NOME_CLIENTES.Margin = new Padding(4, 3, 4, 3);
			Txt_NOME_CLIENTES.Name = "Txt_NOME_CLIENTES";
			Txt_NOME_CLIENTES.Size = new Size(734, 23);
			Txt_NOME_CLIENTES.TabIndex = 1;
			Txt_NOME_CLIENTES.TextChanged += Txt_NOME_CLIENTES_TextChanged;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = SystemColors.Control;
			label2.Location = new Point(74, 28);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(43, 15);
			label2.TabIndex = 60;
			label2.Text = "Nome:";
			// 
			// Txt_CPF
			// 
			Txt_CPF.Location = new Point(130, 72);
			Txt_CPF.Margin = new Padding(4, 3, 4, 3);
			Txt_CPF.Name = "Txt_CPF";
			Txt_CPF.Size = new Size(116, 23);
			Txt_CPF.TabIndex = 2;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = SystemColors.Control;
			label3.Location = new Point(72, 75);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new Size(31, 15);
			label3.TabIndex = 61;
			label3.Text = "CPF:";
			// 
			// Txt_RG
			// 
			Txt_RG.Location = new Point(385, 72);
			Txt_RG.Margin = new Padding(4, 3, 4, 3);
			Txt_RG.Name = "Txt_RG";
			Txt_RG.Size = new Size(149, 23);
			Txt_RG.TabIndex = 3;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.BackColor = SystemColors.Control;
			label4.Location = new Point(317, 75);
			label4.Margin = new Padding(4, 0, 4, 0);
			label4.Name = "label4";
			label4.Size = new Size(25, 15);
			label4.TabIndex = 62;
			label4.Text = "RG:";
			label4.Click += label4_Click;
			// 
			// Txt_NASCIMENTO
			// 
			Txt_NASCIMENTO.Location = new Point(677, 72);
			Txt_NASCIMENTO.Margin = new Padding(4, 3, 4, 3);
			Txt_NASCIMENTO.Name = "Txt_NASCIMENTO";
			Txt_NASCIMENTO.Size = new Size(187, 23);
			Txt_NASCIMENTO.TabIndex = 4;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.BackColor = SystemColors.Control;
			label5.Location = new Point(561, 75);
			label5.Margin = new Padding(4, 0, 4, 0);
			label5.Name = "label5";
			label5.Size = new Size(84, 15);
			label5.TabIndex = 63;
			label5.Text = "NASCIMENTO:";
			// 
			// Txt_ENDERECO
			// 
			Txt_ENDERECO.Location = new Point(161, 118);
			Txt_ENDERECO.Margin = new Padding(4, 3, 4, 3);
			Txt_ENDERECO.Name = "Txt_ENDERECO";
			Txt_ENDERECO.Size = new Size(356, 23);
			Txt_ENDERECO.TabIndex = 5;
			Txt_ENDERECO.TextChanged += Txt_ENDERECO_TextChanged;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.BackColor = SystemColors.Control;
			label6.Location = new Point(72, 121);
			label6.Margin = new Padding(4, 0, 4, 0);
			label6.Name = "label6";
			label6.Size = new Size(69, 15);
			label6.TabIndex = 64;
			label6.Text = "ENDEREÇO:";
			// 
			// Txt_FONE
			// 
			Txt_FONE.Location = new Point(125, 174);
			Txt_FONE.Margin = new Padding(4, 3, 4, 3);
			Txt_FONE.Name = "Txt_FONE";
			Txt_FONE.Size = new Size(198, 23);
			Txt_FONE.TabIndex = 6;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.BackColor = SystemColors.Control;
			label7.Location = new Point(72, 178);
			label7.Margin = new Padding(4, 0, 4, 0);
			label7.Name = "label7";
			label7.Size = new Size(40, 15);
			label7.TabIndex = 12;
			label7.Text = "FONE:";
			// 
			// Txt_EMAIL
			// 
			Txt_EMAIL.Location = new Point(441, 174);
			Txt_EMAIL.Margin = new Padding(4, 3, 4, 3);
			Txt_EMAIL.Name = "Txt_EMAIL";
			Txt_EMAIL.Size = new Size(423, 23);
			Txt_EMAIL.TabIndex = 7;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.BackColor = SystemColors.Control;
			label8.Location = new Point(382, 178);
			label8.Margin = new Padding(4, 0, 4, 0);
			label8.Name = "label8";
			label8.Size = new Size(49, 15);
			label8.TabIndex = 14;
			label8.Text = "E-MAIL:";
			// 
			// Btn_INSERIR
			// 
			Btn_INSERIR.BackColor = SystemColors.ActiveCaptionText;
			Btn_INSERIR.ForeColor = SystemColors.ControlLightLight;
			Btn_INSERIR.Location = new Point(460, 437);
			Btn_INSERIR.Margin = new Padding(4, 3, 4, 3);
			Btn_INSERIR.Name = "Btn_INSERIR";
			Btn_INSERIR.Size = new Size(128, 47);
			Btn_INSERIR.TabIndex = 9;
			Btn_INSERIR.Text = "INSERIR";
			Btn_INSERIR.UseVisualStyleBackColor = false;
			Btn_INSERIR.Click += Btn_INSERIR_Click;
			// 
			// Btn_Ataualizar
			// 
			Btn_Ataualizar.BackColor = SystemColors.ActiveCaptionText;
			Btn_Ataualizar.ForeColor = SystemColors.ControlLightLight;
			Btn_Ataualizar.Location = new Point(603, 437);
			Btn_Ataualizar.Margin = new Padding(4, 3, 4, 3);
			Btn_Ataualizar.Name = "Btn_Ataualizar";
			Btn_Ataualizar.Size = new Size(128, 47);
			Btn_Ataualizar.TabIndex = 10;
			Btn_Ataualizar.Text = "ATAULIZAR";
			Btn_Ataualizar.UseVisualStyleBackColor = false;
			Btn_Ataualizar.Click += Btn_ATUALIZAR_Click;
			// 
			// Btn_Excluir
			// 
			Btn_Excluir.BackColor = SystemColors.ActiveCaptionText;
			Btn_Excluir.ForeColor = SystemColors.ControlLightLight;
			Btn_Excluir.Location = new Point(749, 437);
			Btn_Excluir.Margin = new Padding(4, 3, 4, 3);
			Btn_Excluir.Name = "Btn_Excluir";
			Btn_Excluir.Size = new Size(128, 47);
			Btn_Excluir.TabIndex = 11;
			Btn_Excluir.Text = "EXCLUIR";
			Btn_Excluir.UseVisualStyleBackColor = false;
			Btn_Excluir.Click += Btn_EXCLUIR_Click;
			// 
			// DGV_ListaClientes
			// 
			DGV_ListaClientes.BackgroundColor = SystemColors.ActiveCaption;
			DGV_ListaClientes.BorderStyle = BorderStyle.Fixed3D;
			DGV_ListaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			DGV_ListaClientes.EditMode = DataGridViewEditMode.EditProgrammatically;
			DGV_ListaClientes.GridColor = SystemColors.ActiveCaptionText;
			DGV_ListaClientes.Location = new Point(76, 220);
			DGV_ListaClientes.Margin = new Padding(4, 3, 4, 3);
			DGV_ListaClientes.Name = "DGV_ListaClientes";
			DGV_ListaClientes.ReadOnly = true;
			DGV_ListaClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			DGV_ListaClientes.Size = new Size(789, 200);
			DGV_ListaClientes.TabIndex = 8;
			// 
			// ButtonClick
			// 
			ButtonClick.BackColor = SystemColors.ActiveCaptionText;
			ButtonClick.ForeColor = SystemColors.ControlLightLight;
			ButtonClick.Location = new Point(730, 110);
			ButtonClick.Margin = new Padding(4, 3, 4, 3);
			ButtonClick.Name = "ButtonClick";
			ButtonClick.Size = new Size(134, 37);
			ButtonClick.TabIndex = 65;
			ButtonClick.Text = "Buscar";
			ButtonClick.UseVisualStyleBackColor = false;
			ButtonClick.Click += Txt_CEP_Click;
			// 
			// Txt_CEP
			// 
			Txt_CEP.Location = new Point(556, 118);
			Txt_CEP.Margin = new Padding(4, 3, 4, 3);
			Txt_CEP.Name = "Txt_CEP";
			Txt_CEP.Size = new Size(166, 23);
			Txt_CEP.TabIndex = 66;
			// 
			// Form_Clientes2
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ButtonFace;
			ClientSize = new Size(933, 519);
			Controls.Add(Txt_CEP);
			Controls.Add(ButtonClick);
			Controls.Add(DGV_ListaClientes);
			Controls.Add(Btn_Excluir);
			Controls.Add(Btn_Ataualizar);
			Controls.Add(Btn_INSERIR);
			Controls.Add(Txt_EMAIL);
			Controls.Add(label8);
			Controls.Add(Txt_FONE);
			Controls.Add(label7);
			Controls.Add(Txt_ENDERECO);
			Controls.Add(label6);
			Controls.Add(Txt_NASCIMENTO);
			Controls.Add(label5);
			Controls.Add(Txt_RG);
			Controls.Add(label4);
			Controls.Add(Txt_CPF);
			Controls.Add(label3);
			Controls.Add(Txt_NOME_CLIENTES);
			Controls.Add(label2);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			Margin = new Padding(4, 3, 4, 3);
			Name = "Form_Clientes2";
			Text = "Cadastros de Clientes";
			Load += Form_Clientes2_Load;
			((System.ComponentModel.ISupportInitialize)DGV_ListaClientes).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private System.Windows.Forms.TextBox Txt_NOME_CLIENTES;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox Txt_CPF;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox Txt_RG;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox Txt_NASCIMENTO;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox Txt_ENDERECO;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox Txt_FONE;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox Txt_EMAIL;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button Btn_INSERIR;
		private System.Windows.Forms.Button Btn_Ataualizar;
		private System.Windows.Forms.Button Btn_Excluir;
		private System.Windows.Forms.DataGridView DGV_ListaClientes;
		private System.Windows.Forms.Button ButtonClick;
		private System.Windows.Forms.TextBox Txt_CEP;
	}
}