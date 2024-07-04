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
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			label7 = new Label();
			Txt_NOME_CLIENTES = new TextBox();
			Txt_CPF = new TextBox();
			Txt_RG = new TextBox();
			Txt_NASCIMENTO = new TextBox();
			Txt_ENDERECO = new TextBox();
			Txt_CEP = new TextBox();
			Txt_FONE = new TextBox();
			Txt_EMAIL = new TextBox();
			DGV_ListaClientes = new DataGridView();
			ButtonClick = new Button();
			Btn_INSERIR = new Button();
			button2 = new Button();
			button3 = new Button();
			((System.ComponentModel.ISupportInitialize)DGV_ListaClientes).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(46, 18);
			label1.Name = "label1";
			label1.Size = new Size(45, 13);
			label1.TabIndex = 0;
			label1.Text = "NOME :";
			label1.Click += label1_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(46, 55);
			label2.Name = "label2";
			label2.Size = new Size(33, 13);
			label2.TabIndex = 1;
			label2.Text = "CPF :";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(228, 55);
			label3.Name = "label3";
			label3.Size = new Size(29, 13);
			label3.TabIndex = 2;
			label3.Text = "RG :";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(417, 55);
			label4.Name = "label4";
			label4.Size = new Size(81, 13);
			label4.TabIndex = 3;
			label4.Text = "NASCIMENTO:";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(46, 90);
			label5.Name = "label5";
			label5.Size = new Size(73, 13);
			label5.TabIndex = 4;
			label5.Text = "ENDEREÇO :";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(46, 133);
			label6.Name = "label6";
			label6.Size = new Size(42, 13);
			label6.TabIndex = 5;
			label6.Text = "FONE :";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(279, 133);
			label7.Name = "label7";
			label7.Size = new Size(45, 13);
			label7.TabIndex = 6;
			label7.Text = "EMAIL :";
			// 
			// Txt_NOME_CLIENTES
			// 
			Txt_NOME_CLIENTES.BackColor = SystemColors.Window;
			Txt_NOME_CLIENTES.Cursor = Cursors.IBeam;
			Txt_NOME_CLIENTES.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Txt_NOME_CLIENTES.ImeMode = ImeMode.NoControl;
			Txt_NOME_CLIENTES.Location = new Point(95, 18);
			Txt_NOME_CLIENTES.Name = "Txt_NOME_CLIENTES";
			Txt_NOME_CLIENTES.Size = new Size(541, 20);
			Txt_NOME_CLIENTES.TabIndex = 1;
			Txt_NOME_CLIENTES.TextChanged += textBox1_TextChanged;
			// 
			// Txt_CPF
			// 
			Txt_CPF.Cursor = Cursors.IBeam;
			Txt_CPF.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Txt_CPF.ImeMode = ImeMode.NoControl;
			Txt_CPF.Location = new Point(95, 54);
			Txt_CPF.Name = "Txt_CPF";
			Txt_CPF.Size = new Size(86, 20);
			Txt_CPF.TabIndex = 2;
			// 
			// Txt_RG
			// 
			Txt_RG.Cursor = Cursors.IBeam;
			Txt_RG.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Txt_RG.ImeMode = ImeMode.NoControl;
			Txt_RG.Location = new Point(283, 54);
			Txt_RG.Name = "Txt_RG";
			Txt_RG.Size = new Size(110, 20);
			Txt_RG.TabIndex = 3;
			// 
			// Txt_NASCIMENTO
			// 
			Txt_NASCIMENTO.Cursor = Cursors.IBeam;
			Txt_NASCIMENTO.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Txt_NASCIMENTO.Location = new Point(497, 54);
			Txt_NASCIMENTO.Name = "Txt_NASCIMENTO";
			Txt_NASCIMENTO.Size = new Size(139, 20);
			Txt_NASCIMENTO.TabIndex = 4;
			// 
			// Txt_ENDERECO
			// 
			Txt_ENDERECO.Cursor = Cursors.IBeam;
			Txt_ENDERECO.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Txt_ENDERECO.Location = new Point(118, 88);
			Txt_ENDERECO.Name = "Txt_ENDERECO";
			Txt_ENDERECO.Size = new Size(263, 20);
			Txt_ENDERECO.TabIndex = 5;
			// 
			// Txt_CEP
			// 
			Txt_CEP.Cursor = Cursors.IBeam;
			Txt_CEP.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Txt_CEP.Location = new Point(409, 88);
			Txt_CEP.Name = "Txt_CEP";
			Txt_CEP.Size = new Size(123, 20);
			Txt_CEP.TabIndex = 66;
			// 
			// Txt_FONE
			// 
			Txt_FONE.Cursor = Cursors.IBeam;
			Txt_FONE.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Txt_FONE.Location = new Point(92, 131);
			Txt_FONE.Name = "Txt_FONE";
			Txt_FONE.Size = new Size(146, 20);
			Txt_FONE.TabIndex = 6;
			// 
			// Txt_EMAIL
			// 
			Txt_EMAIL.Cursor = Cursors.IBeam;
			Txt_EMAIL.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Txt_EMAIL.Location = new Point(324, 131);
			Txt_EMAIL.Name = "Txt_EMAIL";
			Txt_EMAIL.Size = new Size(312, 20);
			Txt_EMAIL.TabIndex = 7;
			// 
			// DGV_ListaClientes
			// 
			DGV_ListaClientes.BackgroundColor = SystemColors.ActiveCaption;
			DGV_ListaClientes.BorderStyle = BorderStyle.Fixed3D;
			DGV_ListaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			DGV_ListaClientes.EditMode = DataGridViewEditMode.EditProgrammatically;
			DGV_ListaClientes.GridColor = SystemColors.InactiveCaptionText;
			DGV_ListaClientes.ImeMode = ImeMode.NoControl;
			DGV_ListaClientes.Location = new Point(56, 166);
			DGV_ListaClientes.Name = "DGV_ListaClientes";
			DGV_ListaClientes.ReadOnly = true;
			DGV_ListaClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			DGV_ListaClientes.Size = new Size(579, 150);
			DGV_ListaClientes.TabIndex = 8;
			// 
			// ButtonClick
			// 
			ButtonClick.BackColor = SystemColors.ActiveCaptionText;
			ButtonClick.ForeColor = SystemColors.ControlLightLight;
			ButtonClick.Location = new Point(538, 81);
			ButtonClick.Name = "ButtonClick";
			ButtonClick.Size = new Size(98, 32);
			ButtonClick.TabIndex = 65;
			ButtonClick.Text = "Buscar";
			ButtonClick.UseVisualStyleBackColor = false;
			// 
			// Btn_INSERIR
			// 
			Btn_INSERIR.BackColor = SystemColors.ActiveCaptionText;
			Btn_INSERIR.ForeColor = SystemColors.HighlightText;
			Btn_INSERIR.Location = new Point(46, 330);
			Btn_INSERIR.Name = "Btn_INSERIR";
			Btn_INSERIR.Size = new Size(87, 36);
			Btn_INSERIR.TabIndex = 17;
			Btn_INSERIR.Text = "INSERIR";
			Btn_INSERIR.UseVisualStyleBackColor = false;
			// 
			// button2
			// 
			button2.BackColor = SystemColors.ActiveCaptionText;
			button2.ForeColor = SystemColors.HighlightText;
			button2.Location = new Point(551, 330);
			button2.Name = "button2";
			button2.Size = new Size(81, 36);
			button2.TabIndex = 18;
			button2.Text = "EXCLUIR";
			button2.UseVisualStyleBackColor = false;
			// 
			// button3
			// 
			button3.BackColor = SystemColors.ActiveCaptionText;
			button3.ForeColor = SystemColors.HighlightText;
			button3.Location = new Point(161, 330);
			button3.Name = "button3";
			button3.Size = new Size(81, 36);
			button3.TabIndex = 19;
			button3.Text = "ATUALIZAR";
			button3.UseVisualStyleBackColor = false;
			// 
			// Form_Clientes2
			// 
			AutoScaleDimensions = new SizeF(6F, 13F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ButtonFace;
			ClientSize = new Size(800, 404);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(Btn_INSERIR);
			Controls.Add(ButtonClick);
			Controls.Add(DGV_ListaClientes);
			Controls.Add(Txt_EMAIL);
			Controls.Add(Txt_FONE);
			Controls.Add(Txt_CEP);
			Controls.Add(Txt_ENDERECO);
			Controls.Add(Txt_NASCIMENTO);
			Controls.Add(Txt_RG);
			Controls.Add(Txt_CPF);
			Controls.Add(Txt_NOME_CLIENTES);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			Name = "Form_Clientes2";
			Text = "Cadastros de Clientes";
			((System.ComponentModel.ISupportInitialize)DGV_ListaClientes).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private TextBox Txt_NOME_CLIENTES;
		private TextBox Txt_CPF;
		private TextBox Txt_RG;
		private TextBox Txt_NASCIMENTO;
		private TextBox Txt_ENDERECO;
		private TextBox Txt_CEP;
		private TextBox Txt_FONE;
		private TextBox Txt_EMAIL;
		private DataGridView DGV_ListaClientes;
		private Button ButtonClick;
		private Button Btn_INSERIR;
		private Button button2;
		private Button button3;
	}
}